namespace VideoConverter
{
    partial class VideoConverterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFilebutton = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.OpenFiletextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fromFormatcomboBox = new System.Windows.Forms.ComboBox();
            this.toFormatcomboBox = new System.Windows.Forms.ComboBox();
            this.fromFormatlabel = new System.Windows.Forms.Label();
            this.toFormatlabel = new System.Windows.Forms.Label();
            this.Processinglabel = new System.Windows.Forms.Label();
            this.Progresslabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Settingsbutton = new System.Windows.Forms.Button();
            this.ASRatelabel = new System.Windows.Forms.Label();
            this.VFrameratelabel = new System.Windows.Forms.Label();
            this.VFrameratetextBox = new System.Windows.Forms.TextBox();
            this.ASRatecomboBox = new System.Windows.Forms.ComboBox();
            this.OpenFolderbutton = new System.Windows.Forms.Button();
            this.OpenFoldertextBox = new System.Windows.Forms.TextBox();
            this.openFolderDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.subDircheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OpenFilebutton
            // 
            this.OpenFilebutton.Location = new System.Drawing.Point(12, 8);
            this.OpenFilebutton.Name = "OpenFilebutton";
            this.OpenFilebutton.Size = new System.Drawing.Size(100, 20);
            this.OpenFilebutton.TabIndex = 0;
            this.OpenFilebutton.Text = "Open File";
            this.OpenFilebutton.UseVisualStyleBackColor = true;
            this.OpenFilebutton.Click += new System.EventHandler(this.OpenFilebutton_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(12, 60);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(100, 20);
            this.Startbutton.TabIndex = 1;
            this.Startbutton.Text = "Convert Video";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(12, 86);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(100, 20);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // OpenFiletextBox
            // 
            this.OpenFiletextBox.Location = new System.Drawing.Point(118, 8);
            this.OpenFiletextBox.Name = "OpenFiletextBox";
            this.OpenFiletextBox.Size = new System.Drawing.Size(115, 20);
            this.OpenFiletextBox.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fromFormatcomboBox
            // 
            this.fromFormatcomboBox.FormattingEnabled = true;
            this.fromFormatcomboBox.Items.AddRange(new object[] {
            "All",
            ".mp4",
            ".mkv",
            ".avi",
            ".mov",
            ".mpeg",
            ".ogg",
            ".flv",
            ".webm"});
            this.fromFormatcomboBox.Location = new System.Drawing.Point(118, 113);
            this.fromFormatcomboBox.Name = "fromFormatcomboBox";
            this.fromFormatcomboBox.Size = new System.Drawing.Size(121, 21);
            this.fromFormatcomboBox.TabIndex = 4;
            // 
            // toFormatcomboBox
            // 
            this.toFormatcomboBox.FormattingEnabled = true;
            this.toFormatcomboBox.Items.AddRange(new object[] {
            ".mp4",
            ".mkv",
            ".avi",
            ".mov",
            ".mpeg",
            ".ogg",
            ".flv",
            ".webm"});
            this.toFormatcomboBox.Location = new System.Drawing.Point(118, 140);
            this.toFormatcomboBox.Name = "toFormatcomboBox";
            this.toFormatcomboBox.Size = new System.Drawing.Size(121, 21);
            this.toFormatcomboBox.TabIndex = 5;
            // 
            // fromFormatlabel
            // 
            this.fromFormatlabel.AutoSize = true;
            this.fromFormatlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fromFormatlabel.Location = new System.Drawing.Point(12, 112);
            this.fromFormatlabel.Name = "fromFormatlabel";
            this.fromFormatlabel.Size = new System.Drawing.Size(100, 18);
            this.fromFormatlabel.TabIndex = 6;
            this.fromFormatlabel.Text = "Convert From";
            // 
            // toFormatlabel
            // 
            this.toFormatlabel.AutoSize = true;
            this.toFormatlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.toFormatlabel.Location = new System.Drawing.Point(12, 139);
            this.toFormatlabel.Name = "toFormatlabel";
            this.toFormatlabel.Size = new System.Drawing.Size(82, 18);
            this.toFormatlabel.TabIndex = 7;
            this.toFormatlabel.Text = "Convert To";
            // 
            // Processinglabel
            // 
            this.Processinglabel.AutoSize = true;
            this.Processinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Processinglabel.Location = new System.Drawing.Point(12, 229);
            this.Processinglabel.Name = "Processinglabel";
            this.Processinglabel.Size = new System.Drawing.Size(154, 18);
            this.Processinglabel.TabIndex = 8;
            this.Processinglabel.Text = "Currently Processing: ";
            // 
            // Progresslabel
            // 
            this.Progresslabel.AutoSize = true;
            this.Progresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Progresslabel.Location = new System.Drawing.Point(12, 247);
            this.Progresslabel.Name = "Progresslabel";
            this.Progresslabel.Size = new System.Drawing.Size(189, 18);
            this.Progresslabel.TabIndex = 9;
            this.Progresslabel.Text = "Progress 00:00:00/00:00:00";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 268);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(410, 23);
            this.progressBar.TabIndex = 10;
            // 
            // Settingsbutton
            // 
            this.Settingsbutton.Location = new System.Drawing.Point(12, 297);
            this.Settingsbutton.Name = "Settingsbutton";
            this.Settingsbutton.Size = new System.Drawing.Size(410, 23);
            this.Settingsbutton.TabIndex = 11;
            this.Settingsbutton.Text = "Advanced Settings";
            this.Settingsbutton.UseVisualStyleBackColor = true;
            this.Settingsbutton.Click += new System.EventHandler(this.Settingsbutton_Click);
            // 
            // ASRatelabel
            // 
            this.ASRatelabel.AutoSize = true;
            this.ASRatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ASRatelabel.Location = new System.Drawing.Point(12, 362);
            this.ASRatelabel.Name = "ASRatelabel";
            this.ASRatelabel.Size = new System.Drawing.Size(134, 18);
            this.ASRatelabel.TabIndex = 12;
            this.ASRatelabel.Text = "Audio Sample Rate";
            // 
            // VFrameratelabel
            // 
            this.VFrameratelabel.AutoSize = true;
            this.VFrameratelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.VFrameratelabel.Location = new System.Drawing.Point(12, 336);
            this.VFrameratelabel.Name = "VFrameratelabel";
            this.VFrameratelabel.Size = new System.Drawing.Size(117, 18);
            this.VFrameratelabel.TabIndex = 13;
            this.VFrameratelabel.Text = "Video Framerate";
            // 
            // VFrameratetextBox
            // 
            this.VFrameratetextBox.Location = new System.Drawing.Point(152, 336);
            this.VFrameratetextBox.Name = "VFrameratetextBox";
            this.VFrameratetextBox.Size = new System.Drawing.Size(121, 20);
            this.VFrameratetextBox.TabIndex = 14;
            // 
            // ASRatecomboBox
            // 
            this.ASRatecomboBox.FormattingEnabled = true;
            this.ASRatecomboBox.Items.AddRange(new object[] {
            "Default",
            "8000",
            "11025",
            "22050",
            "44100",
            "48000"});
            this.ASRatecomboBox.Location = new System.Drawing.Point(152, 362);
            this.ASRatecomboBox.Name = "ASRatecomboBox";
            this.ASRatecomboBox.Size = new System.Drawing.Size(121, 21);
            this.ASRatecomboBox.TabIndex = 15;
            // 
            // OpenFolderbutton
            // 
            this.OpenFolderbutton.Location = new System.Drawing.Point(12, 34);
            this.OpenFolderbutton.Name = "OpenFolderbutton";
            this.OpenFolderbutton.Size = new System.Drawing.Size(100, 20);
            this.OpenFolderbutton.TabIndex = 16;
            this.OpenFolderbutton.Text = "Open Folder";
            this.OpenFolderbutton.UseVisualStyleBackColor = true;
            this.OpenFolderbutton.Click += new System.EventHandler(this.OpenFolderbutton_Click);
            // 
            // OpenFoldertextBox
            // 
            this.OpenFoldertextBox.Location = new System.Drawing.Point(118, 34);
            this.OpenFoldertextBox.Name = "OpenFoldertextBox";
            this.OpenFoldertextBox.Size = new System.Drawing.Size(115, 20);
            this.OpenFoldertextBox.TabIndex = 17;
            // 
            // subDircheckBox
            // 
            this.subDircheckBox.AutoSize = true;
            this.subDircheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.subDircheckBox.Location = new System.Drawing.Point(58, 167);
            this.subDircheckBox.Name = "subDircheckBox";
            this.subDircheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subDircheckBox.Size = new System.Drawing.Size(178, 22);
            this.subDircheckBox.TabIndex = 18;
            this.subDircheckBox.Text = "Convert Subdirectories";
            this.subDircheckBox.UseVisualStyleBackColor = true;
            // 
            // VideoConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.subDircheckBox);
            this.Controls.Add(this.OpenFoldertextBox);
            this.Controls.Add(this.OpenFolderbutton);
            this.Controls.Add(this.ASRatecomboBox);
            this.Controls.Add(this.VFrameratetextBox);
            this.Controls.Add(this.VFrameratelabel);
            this.Controls.Add(this.ASRatelabel);
            this.Controls.Add(this.Settingsbutton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Progresslabel);
            this.Controls.Add(this.Processinglabel);
            this.Controls.Add(this.toFormatlabel);
            this.Controls.Add(this.fromFormatlabel);
            this.Controls.Add(this.toFormatcomboBox);
            this.Controls.Add(this.fromFormatcomboBox);
            this.Controls.Add(this.OpenFiletextBox);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.OpenFilebutton);
            this.Name = "VideoConverterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFilebutton;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.TextBox OpenFiletextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox fromFormatcomboBox;
        private System.Windows.Forms.ComboBox toFormatcomboBox;
        private System.Windows.Forms.Label fromFormatlabel;
        private System.Windows.Forms.Label toFormatlabel;
        private System.Windows.Forms.Label Processinglabel;
        private System.Windows.Forms.Label Progresslabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button Settingsbutton;
        private System.Windows.Forms.Label ASRatelabel;
        private System.Windows.Forms.Label VFrameratelabel;
        private System.Windows.Forms.TextBox VFrameratetextBox;
        private System.Windows.Forms.ComboBox ASRatecomboBox;
        private System.Windows.Forms.Button OpenFolderbutton;
        private System.Windows.Forms.TextBox OpenFoldertextBox;
        private System.Windows.Forms.FolderBrowserDialog openFolderDialog1;
        private System.Windows.Forms.CheckBox subDircheckBox;
    }
}

