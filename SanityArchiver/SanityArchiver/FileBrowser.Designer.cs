namespace SanityArchiver
{
    partial class FileManager
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.fileBrowser = new System.Windows.Forms.WebBrowser();
            this.dirComboBox = new System.Windows.Forms.ComboBox();
            this.compressBtn = new System.Windows.Forms.Button();
            this.extractBtn = new System.Windows.Forms.Button();
            this.refresBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(61, 12);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(43, 23);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(282, 15);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(32, 13);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "Path:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(311, 12);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(421, 20);
            this.pathBox.TabIndex = 4;
            // 
            // fileBrowser
            // 
            this.fileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBrowser.Location = new System.Drawing.Point(12, 42);
            this.fileBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.fileBrowser.Name = "fileBrowser";
            this.fileBrowser.Size = new System.Drawing.Size(720, 358);
            this.fileBrowser.TabIndex = 5;
            this.fileBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.fileBrowser_DocumentCompleted);
            // 
            // dirComboBox
            // 
            this.dirComboBox.FormattingEnabled = true;
            this.dirComboBox.Items.AddRange(new object[] {
            "C:\\",
            "D:\\"});
            this.dirComboBox.Location = new System.Drawing.Point(155, 12);
            this.dirComboBox.Name = "dirComboBox";
            this.dirComboBox.Size = new System.Drawing.Size(121, 21);
            this.dirComboBox.TabIndex = 6;
            this.dirComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // compressBtn
            // 
            this.compressBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.compressBtn.Location = new System.Drawing.Point(12, 406);
            this.compressBtn.Name = "compressBtn";
            this.compressBtn.Size = new System.Drawing.Size(75, 23);
            this.compressBtn.TabIndex = 7;
            this.compressBtn.Text = "Compress";
            this.compressBtn.UseVisualStyleBackColor = true;
            this.compressBtn.Click += new System.EventHandler(this.compressBtn_Click);
            // 
            // extractBtn
            // 
            this.extractBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.extractBtn.Location = new System.Drawing.Point(93, 406);
            this.extractBtn.Name = "extractBtn";
            this.extractBtn.Size = new System.Drawing.Size(75, 23);
            this.extractBtn.TabIndex = 8;
            this.extractBtn.Text = "Extract";
            this.extractBtn.UseVisualStyleBackColor = true;
            this.extractBtn.Click += new System.EventHandler(this.extractBtn_Click);
            // 
            // refresBtn
            // 
            this.refresBtn.Location = new System.Drawing.Point(110, 12);
            this.refresBtn.Name = "refresBtn";
            this.refresBtn.Size = new System.Drawing.Size(39, 23);
            this.refresBtn.TabIndex = 9;
            this.refresBtn.Text = "R";
            this.refresBtn.UseVisualStyleBackColor = true;
            this.refresBtn.Click += new System.EventHandler(this.refresBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(285, 406);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 10;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(366, 406);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptBtn.TabIndex = 11;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 435);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.refresBtn);
            this.Controls.Add(this.extractBtn);
            this.Controls.Add(this.compressBtn);
            this.Controls.Add(this.dirComboBox);
            this.Controls.Add(this.fileBrowser);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Name = "FileManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.WebBrowser fileBrowser;
        private System.Windows.Forms.ComboBox dirComboBox;
        private System.Windows.Forms.Button compressBtn;
        private System.Windows.Forms.Button extractBtn;
        private System.Windows.Forms.Button refresBtn;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
    }
}

