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
            this.Startbutton.Location = new System.Drawing.Point(12, 37);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(100, 20);
            this.Startbutton.TabIndex = 1;
            this.Startbutton.Text = "Convert Video";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(12, 66);
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
            this.fromFormatcomboBox.Location = new System.Drawing.Point(118, 90);
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
            this.toFormatcomboBox.Location = new System.Drawing.Point(118, 117);
            this.toFormatcomboBox.Name = "toFormatcomboBox";
            this.toFormatcomboBox.Size = new System.Drawing.Size(121, 21);
            this.toFormatcomboBox.TabIndex = 5;
            // 
            // fromFormatlabel
            // 
            this.fromFormatlabel.AutoSize = true;
            this.fromFormatlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fromFormatlabel.Location = new System.Drawing.Point(12, 89);
            this.fromFormatlabel.Name = "fromFormatlabel";
            this.fromFormatlabel.Size = new System.Drawing.Size(100, 18);
            this.fromFormatlabel.TabIndex = 6;
            this.fromFormatlabel.Text = "Convert From";
            // 
            // toFormatlabel
            // 
            this.toFormatlabel.AutoSize = true;
            this.toFormatlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.toFormatlabel.Location = new System.Drawing.Point(12, 116);
            this.toFormatlabel.Name = "toFormatlabel";
            this.toFormatlabel.Size = new System.Drawing.Size(82, 18);
            this.toFormatlabel.TabIndex = 7;
            this.toFormatlabel.Text = "Convert To";
            // 
            // VideoConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
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
    }
}

