namespace IntervCut
{
    partial class IntervCut
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        private void InitializeComponent()
        {
            this.Btn_Import_MovieFile = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MovieFilePathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ExtractFolderPathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Extract_Folder = new MetroFramework.Controls.MetroButton();
            this.Btn_Start_Extraction = new MetroFramework.Controls.MetroButton();
            this.TopMost_CheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.ImageQuality_ComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.IntervalSec_TextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.ExtensionType_ComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.GrayScale_CheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.Sobel_CheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.MovieFile_Link = new MetroFramework.Controls.MetroLink();
            this.OutputFolder_Link = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // Btn_Import_MovieFile
            // 
            this.Btn_Import_MovieFile.Location = new System.Drawing.Point(488, 96);
            this.Btn_Import_MovieFile.Name = "Btn_Import_MovieFile";
            this.Btn_Import_MovieFile.Size = new System.Drawing.Size(80, 23);
            this.Btn_Import_MovieFile.Style = MetroFramework.MetroColorStyle.Purple;
            this.Btn_Import_MovieFile.TabIndex = 0;
            this.Btn_Import_MovieFile.Text = "参照";
            this.Btn_Import_MovieFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Btn_Import_MovieFile.UseSelectable = true;
            this.Btn_Import_MovieFile.TextChanged += new System.EventHandler(this.Btn_Import_MovieFile_TextChanged);
            this.Btn_Import_MovieFile.Click += new System.EventHandler(this.Btn_Import_MovieFile_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "動画ファイル";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MovieFilePathTextBox
            // 
            this.MovieFilePathTextBox.CustomButton.Image = null;
            this.MovieFilePathTextBox.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.MovieFilePathTextBox.CustomButton.Name = "";
            this.MovieFilePathTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MovieFilePathTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MovieFilePathTextBox.CustomButton.TabIndex = 1;
            this.MovieFilePathTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MovieFilePathTextBox.CustomButton.UseSelectable = true;
            this.MovieFilePathTextBox.CustomButton.Visible = false;
            this.MovieFilePathTextBox.Lines = new string[0];
            this.MovieFilePathTextBox.Location = new System.Drawing.Point(105, 96);
            this.MovieFilePathTextBox.MaxLength = 32767;
            this.MovieFilePathTextBox.Name = "MovieFilePathTextBox";
            this.MovieFilePathTextBox.PasswordChar = '\0';
            this.MovieFilePathTextBox.PromptText = "Movie File Path";
            this.MovieFilePathTextBox.ReadOnly = true;
            this.MovieFilePathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MovieFilePathTextBox.SelectedText = "";
            this.MovieFilePathTextBox.SelectionLength = 0;
            this.MovieFilePathTextBox.SelectionStart = 0;
            this.MovieFilePathTextBox.ShortcutsEnabled = true;
            this.MovieFilePathTextBox.Size = new System.Drawing.Size(364, 23);
            this.MovieFilePathTextBox.Style = MetroFramework.MetroColorStyle.Purple;
            this.MovieFilePathTextBox.TabIndex = 2;
            this.MovieFilePathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MovieFilePathTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MovieFilePathTextBox.UseSelectable = true;
            this.MovieFilePathTextBox.WaterMark = "Movie File Path";
            this.MovieFilePathTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MovieFilePathTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "出力フォルダ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ExtractFolderPathTextBox
            // 
            this.ExtractFolderPathTextBox.CustomButton.Image = null;
            this.ExtractFolderPathTextBox.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.ExtractFolderPathTextBox.CustomButton.Name = "";
            this.ExtractFolderPathTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ExtractFolderPathTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ExtractFolderPathTextBox.CustomButton.TabIndex = 1;
            this.ExtractFolderPathTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ExtractFolderPathTextBox.CustomButton.UseSelectable = true;
            this.ExtractFolderPathTextBox.CustomButton.Visible = false;
            this.ExtractFolderPathTextBox.Lines = new string[0];
            this.ExtractFolderPathTextBox.Location = new System.Drawing.Point(105, 143);
            this.ExtractFolderPathTextBox.MaxLength = 32767;
            this.ExtractFolderPathTextBox.Name = "ExtractFolderPathTextBox";
            this.ExtractFolderPathTextBox.PasswordChar = '\0';
            this.ExtractFolderPathTextBox.PromptText = "Extract Folder Path";
            this.ExtractFolderPathTextBox.ReadOnly = true;
            this.ExtractFolderPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExtractFolderPathTextBox.SelectedText = "";
            this.ExtractFolderPathTextBox.SelectionLength = 0;
            this.ExtractFolderPathTextBox.SelectionStart = 0;
            this.ExtractFolderPathTextBox.ShortcutsEnabled = true;
            this.ExtractFolderPathTextBox.Size = new System.Drawing.Size(364, 23);
            this.ExtractFolderPathTextBox.Style = MetroFramework.MetroColorStyle.Purple;
            this.ExtractFolderPathTextBox.TabIndex = 4;
            this.ExtractFolderPathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExtractFolderPathTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ExtractFolderPathTextBox.UseSelectable = true;
            this.ExtractFolderPathTextBox.WaterMark = "Extract Folder Path";
            this.ExtractFolderPathTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ExtractFolderPathTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_Extract_Folder
            // 
            this.Btn_Extract_Folder.Location = new System.Drawing.Point(488, 143);
            this.Btn_Extract_Folder.Name = "Btn_Extract_Folder";
            this.Btn_Extract_Folder.Size = new System.Drawing.Size(80, 23);
            this.Btn_Extract_Folder.Style = MetroFramework.MetroColorStyle.Purple;
            this.Btn_Extract_Folder.TabIndex = 5;
            this.Btn_Extract_Folder.Text = "参照";
            this.Btn_Extract_Folder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Btn_Extract_Folder.UseSelectable = true;
            this.Btn_Extract_Folder.TextChanged += new System.EventHandler(this.Btn_Extract_Folder_TextChanged);
            this.Btn_Extract_Folder.Click += new System.EventHandler(this.Btn_Extract_Folder_Click);
            // 
            // Btn_Start_Extraction
            // 
            this.Btn_Start_Extraction.Enabled = false;
            this.Btn_Start_Extraction.Location = new System.Drawing.Point(469, 214);
            this.Btn_Start_Extraction.Name = "Btn_Start_Extraction";
            this.Btn_Start_Extraction.Size = new System.Drawing.Size(150, 23);
            this.Btn_Start_Extraction.Style = MetroFramework.MetroColorStyle.Purple;
            this.Btn_Start_Extraction.TabIndex = 6;
            this.Btn_Start_Extraction.Text = "抽出開始";
            this.Btn_Start_Extraction.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Btn_Start_Extraction.UseSelectable = true;
            this.Btn_Start_Extraction.Click += new System.EventHandler(this.Btn_Start_Extraction_Click);
            // 
            // TopMost_CheckBox
            // 
            this.TopMost_CheckBox.AutoSize = true;
            this.TopMost_CheckBox.Location = new System.Drawing.Point(500, 34);
            this.TopMost_CheckBox.Name = "TopMost_CheckBox";
            this.TopMost_CheckBox.Size = new System.Drawing.Size(119, 15);
            this.TopMost_CheckBox.Style = MetroFramework.MetroColorStyle.Purple;
            this.TopMost_CheckBox.TabIndex = 7;
            this.TopMost_CheckBox.Text = "最前面に表示する";
            this.TopMost_CheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost_CheckBox.UseSelectable = true;
            this.TopMost_CheckBox.CheckedChanged += new System.EventHandler(this.TopMost_CheckBox_CheckedChanged);
            // 
            // ImageQuality_ComboBox1
            // 
            this.ImageQuality_ComboBox1.FormattingEnabled = true;
            this.ImageQuality_ComboBox1.ItemHeight = 23;
            this.ImageQuality_ComboBox1.Location = new System.Drawing.Point(334, 208);
            this.ImageQuality_ComboBox1.Name = "ImageQuality_ComboBox1";
            this.ImageQuality_ComboBox1.PromptText = "解像度設定";
            this.ImageQuality_ComboBox1.Size = new System.Drawing.Size(113, 29);
            this.ImageQuality_ComboBox1.Style = MetroFramework.MetroColorStyle.Purple;
            this.ImageQuality_ComboBox1.TabIndex = 8;
            this.ImageQuality_ComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ImageQuality_ComboBox1.UseSelectable = true;
            this.ImageQuality_ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ImageQuality_ComboBox1_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 218);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "秒数間隔";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // IntervalSec_TextBox1
            // 
            this.IntervalSec_TextBox1.CustomButton.Image = null;
            this.IntervalSec_TextBox1.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.IntervalSec_TextBox1.CustomButton.Name = "";
            this.IntervalSec_TextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.IntervalSec_TextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IntervalSec_TextBox1.CustomButton.TabIndex = 1;
            this.IntervalSec_TextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IntervalSec_TextBox1.CustomButton.UseSelectable = true;
            this.IntervalSec_TextBox1.CustomButton.Visible = false;
            this.IntervalSec_TextBox1.Lines = new string[0];
            this.IntervalSec_TextBox1.Location = new System.Drawing.Point(94, 214);
            this.IntervalSec_TextBox1.MaxLength = 2;
            this.IntervalSec_TextBox1.Name = "IntervalSec_TextBox1";
            this.IntervalSec_TextBox1.PasswordChar = '\0';
            this.IntervalSec_TextBox1.PromptText = "interval";
            this.IntervalSec_TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IntervalSec_TextBox1.SelectedText = "";
            this.IntervalSec_TextBox1.SelectionLength = 0;
            this.IntervalSec_TextBox1.SelectionStart = 0;
            this.IntervalSec_TextBox1.ShortcutsEnabled = true;
            this.IntervalSec_TextBox1.Size = new System.Drawing.Size(85, 23);
            this.IntervalSec_TextBox1.Style = MetroFramework.MetroColorStyle.Purple;
            this.IntervalSec_TextBox1.TabIndex = 10;
            this.IntervalSec_TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IntervalSec_TextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IntervalSec_TextBox1.UseSelectable = true;
            this.IntervalSec_TextBox1.WaterMark = "interval";
            this.IntervalSec_TextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IntervalSec_TextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.IntervalSec_TextBox1.TextChanged += new System.EventHandler(this.IntervalSec_TextBox1_TextChanged);
            this.IntervalSec_TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntervalSec_TextBox1_KeyPress);
            // 
            // ExtensionType_ComboBox1
            // 
            this.ExtensionType_ComboBox1.FormattingEnabled = true;
            this.ExtensionType_ComboBox1.ItemHeight = 23;
            this.ExtensionType_ComboBox1.Location = new System.Drawing.Point(206, 208);
            this.ExtensionType_ComboBox1.Name = "ExtensionType_ComboBox1";
            this.ExtensionType_ComboBox1.PromptText = "出力形式";
            this.ExtensionType_ComboBox1.Size = new System.Drawing.Size(113, 29);
            this.ExtensionType_ComboBox1.Style = MetroFramework.MetroColorStyle.Purple;
            this.ExtensionType_ComboBox1.TabIndex = 11;
            this.ExtensionType_ComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ExtensionType_ComboBox1.UseSelectable = true;
            this.ExtensionType_ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ExtensionType_ComboBox1_SelectedIndexChanged);
            // 
            // GrayScale_CheckBox
            // 
            this.GrayScale_CheckBox.AutoSize = true;
            this.GrayScale_CheckBox.Location = new System.Drawing.Point(359, 34);
            this.GrayScale_CheckBox.Name = "GrayScale_CheckBox";
            this.GrayScale_CheckBox.Size = new System.Drawing.Size(122, 15);
            this.GrayScale_CheckBox.Style = MetroFramework.MetroColorStyle.Purple;
            this.GrayScale_CheckBox.TabIndex = 12;
            this.GrayScale_CheckBox.Text = "グレースケール出力";
            this.GrayScale_CheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.GrayScale_CheckBox.UseSelectable = true;
            // 
            // Sobel_CheckBox
            // 
            this.Sobel_CheckBox.AutoSize = true;
            this.Sobel_CheckBox.Location = new System.Drawing.Point(236, 34);
            this.Sobel_CheckBox.Name = "Sobel_CheckBox";
            this.Sobel_CheckBox.Size = new System.Drawing.Size(104, 15);
            this.Sobel_CheckBox.Style = MetroFramework.MetroColorStyle.Purple;
            this.Sobel_CheckBox.TabIndex = 13;
            this.Sobel_CheckBox.Text = "エッジ検出出力";
            this.Sobel_CheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Sobel_CheckBox.UseSelectable = true;
            // 
            // MovieFile_Link
            // 
            this.MovieFile_Link.Location = new System.Drawing.Point(574, 96);
            this.MovieFile_Link.Name = "MovieFile_Link";
            this.MovieFile_Link.Size = new System.Drawing.Size(55, 23);
            this.MovieFile_Link.Style = MetroFramework.MetroColorStyle.Purple;
            this.MovieFile_Link.TabIndex = 14;
            this.MovieFile_Link.Text = "開く";
            this.MovieFile_Link.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MovieFile_Link.UseSelectable = true;
            this.MovieFile_Link.Click += new System.EventHandler(this.MovieFile_Link_Click);
            // 
            // OutputFolder_Link
            // 
            this.OutputFolder_Link.Location = new System.Drawing.Point(574, 143);
            this.OutputFolder_Link.Name = "OutputFolder_Link";
            this.OutputFolder_Link.Size = new System.Drawing.Size(55, 23);
            this.OutputFolder_Link.Style = MetroFramework.MetroColorStyle.Purple;
            this.OutputFolder_Link.TabIndex = 15;
            this.OutputFolder_Link.Text = "開く";
            this.OutputFolder_Link.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OutputFolder_Link.UseSelectable = true;
            this.OutputFolder_Link.Click += new System.EventHandler(this.OutputFolder_Link_Click);
            // 
            // IntervCut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 275);
            this.Controls.Add(this.OutputFolder_Link);
            this.Controls.Add(this.MovieFile_Link);
            this.Controls.Add(this.Sobel_CheckBox);
            this.Controls.Add(this.GrayScale_CheckBox);
            this.Controls.Add(this.ExtensionType_ComboBox1);
            this.Controls.Add(this.IntervalSec_TextBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ImageQuality_ComboBox1);
            this.Controls.Add(this.TopMost_CheckBox);
            this.Controls.Add(this.Btn_Start_Extraction);
            this.Controls.Add(this.Btn_Extract_Folder);
            this.Controls.Add(this.ExtractFolderPathTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.MovieFilePathTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Btn_Import_MovieFile);
            this.MaximizeBox = false;
            this.Name = "IntervCut";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "IntervCut";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Btn_Import_MovieFile;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox MovieFilePathTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox ExtractFolderPathTextBox;
        private MetroFramework.Controls.MetroButton Btn_Extract_Folder;
        private MetroFramework.Controls.MetroButton Btn_Start_Extraction;
        private MetroFramework.Controls.MetroCheckBox TopMost_CheckBox;
        private MetroFramework.Controls.MetroComboBox ImageQuality_ComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox IntervalSec_TextBox1;
        private MetroFramework.Controls.MetroComboBox ExtensionType_ComboBox1;
        private MetroFramework.Controls.MetroCheckBox GrayScale_CheckBox;
        private MetroFramework.Controls.MetroCheckBox Sobel_CheckBox;
        private MetroFramework.Controls.MetroLink MovieFile_Link;
        private MetroFramework.Controls.MetroLink OutputFolder_Link;
    }
}

