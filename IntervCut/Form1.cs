using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace IntervCut
{
    public partial class IntervCut : MetroFramework.Forms.MetroForm
    {
        private readonly string iniPath = Path.Combine(Application.StartupPath, "settings.ini");

        public IntervCut()
        {
            InitializeComponent();
            
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_Start_Extraction.Enabled = false;
            ImageQuality_ComboBox1.Items.AddRange(new string[] { "1920x1080", "1280x720", "640x480", "320x240" });
            ExtensionType_ComboBox1.Items.AddRange(new string[] { "PNG", "JPEG", "BMP" });
        }

        private void UpdateStartButtonState()
        {
            Btn_Start_Extraction.Enabled = !string.IsNullOrEmpty(MovieFilePathTextBox.Text) 
                && !string.IsNullOrEmpty(ExtractFolderPathTextBox.Text) 
                && !string.IsNullOrEmpty(IntervalSec_TextBox1.Text) 
                && !string.IsNullOrEmpty(ImageQuality_ComboBox1.Text)
                && !string.IsNullOrEmpty(ExtensionType_ComboBox1.Text);
        }

        private string ExtractEmbeddedffmpeg()
        {
            string resourcePath = "IntervCut.ffmpeg.exe";
            string outputPath = Path.Combine(Application.StartupPath, "ffmpeg.exe");

            if (!File.Exists(outputPath))
            {
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath))
                {
                    if (stream != null)
                    {
                        using (FileStream fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                        {
                            stream.CopyTo(fileStream);
                        }
                    } else
                    {
                        MessageBox.Show("ffmpeg.exe not found in resources.");
                        return string.Empty;
                    }
                }
            }
            return outputPath;
        }

        private void Btn_Import_MovieFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "動画ファイルを選択";
                openFileDialog.Filter = "動画ファイル|*.mp4;*.avi;*.mov;*.mkv;*.flv;*.wmv";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    MovieFilePathTextBox.Text = selectedFilePath;

                    try
                    {
                        string savePath = Path.Combine(Application.StartupPath, "settings.ini");
                        File.WriteAllText(savePath, selectedFilePath, Encoding.UTF8);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("パスの保存に失敗しました: " + ex.Message);
                    }
                }
                UpdateStartButtonState();
            }
        }

        private void Btn_Extract_Folder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "保存先フォルダを選択";
                folderBrowserDialog.ShowNewFolderButton = true;
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    ExtractFolderPathTextBox.Text = selectedFolderPath;

                    try
                    {
                        string savePath = Path.Combine(Application.StartupPath, "settings.ini");
                        File.WriteAllText(savePath, selectedFolderPath, Encoding.UTF8);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("パスの保存に失敗しました: " + ex.Message);
                    }
                }
                UpdateStartButtonState();
            }
        }

        private async void Btn_Start_Extraction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MovieFilePathTextBox.Text) || string.IsNullOrEmpty(ExtractFolderPathTextBox.Text))
            {
                MessageBox.Show("動画ファイルと保存先フォルダを選択してください。");
                return;
            }

            Btn_Start_Extraction.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                string ffmpegPath = ExtractEmbeddedffmpeg();

                int intervalSec = Convert.ToInt32(IntervalSec_TextBox1.Text);
                int width = 1280;
                int height = 720;
                if (ImageQuality_ComboBox1.SelectedItem != null)
                {
                    string selectedQuality = ImageQuality_ComboBox1.SelectedItem.ToString();
                    switch (selectedQuality)
                    {
                        case "1920x1080":
                            width = 1920;
                            height = 1080;
                            break;
                        case "1280x720":
                            width = 1280;
                            height = 720;
                            break;
                        case "640x480":
                            width = 640;
                            height = 480;
                            break;
                        case "320x240":
                            width = 320;
                            height = 240;
                            break;
                    }
                }

                string extensionType = ExtensionType_ComboBox1.SelectedItem.ToString();
                string extension;

                switch(extensionType)
                {
                    case "PNG":
                        extension = "png";
                        break;
                    case "JPEG":
                        extension = "jpg";
                        break;
                    case "BMP":
                        extension = "bmp";
                        break;
                    default:
                        extension = "png";
                        break;
                }
                
                string outputFileName = Path.GetFileNameWithoutExtension(MovieFilePathTextBox.Text);
                string outputPattern = Path.Combine(ExtractFolderPathTextBox.Text, $"{outputFileName}_%04d.{extension}");
                string filter = $"fps=1/{intervalSec},scale={width}:{height}";
                if (Sobel_CheckBox.Checked)
                {
                    filter += ",sobel";
                }
                if (GrayScale_CheckBox.Checked)
                {
                    filter += ",format=gray";
                }
                string arguments = $"-i \"{MovieFilePathTextBox.Text}\" -vf \"{filter}\" \"{outputPattern}\"";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();

                    await Task.Run(() =>
                    {
                        process.WaitForExit();
                    });
                }

                MessageBox.Show("画像の抽出が完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラーが発生しました: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Btn_Start_Extraction.Enabled = true;
                Cursor.Current = Cursors.Default;
            }

        }

        private void Btn_Import_MovieFile_TextChanged(object sender, EventArgs e)
        {
            UpdateStartButtonState();
        }

        private void Btn_Extract_Folder_TextChanged(object sender, EventArgs e)
        {
            UpdateStartButtonState();
        }

        private void TopMost_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = TopMost_CheckBox.Checked;
        }

        private void IntervalSec_TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IntervalSec_TextBox1.SelectionStart == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void IntervalSec_TextBox1_TextChanged(object sender, EventArgs e)
        {
            string digitsOnly = new string(IntervalSec_TextBox1.Text.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(IntervalSec_TextBox1.Text) && IntervalSec_TextBox1.Text.StartsWith("0"))
            {
                digitsOnly = digitsOnly.TrimStart('0');
            }

            if (IntervalSec_TextBox1.Text != digitsOnly)
            {
                int selectionStart = IntervalSec_TextBox1.SelectionStart;
                IntervalSec_TextBox1.Text = digitsOnly;
                IntervalSec_TextBox1.SelectionStart = Math.Min(selectionStart, IntervalSec_TextBox1.Text.Length);
            }
            UpdateStartButtonState();
        }

        private void ImageQuality_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStartButtonState();
        }

        private void ExtensionType_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStartButtonState();
        }

        private void MovieFile_Link_Click(object sender, EventArgs e)
        {
            string filePath = MovieFilePathTextBox.Text;

            if (File.Exists(filePath))
            {
                try
                {

                   Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ファイルを開くことができません: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("指定されたファイルが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OutputFolder_Link_Click(object sender, EventArgs e)
        {
            string folderPath = ExtractFolderPathTextBox.Text;

            if (Directory.Exists(folderPath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(folderPath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("フォルダを開くことができません: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("指定されたフォルダが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}