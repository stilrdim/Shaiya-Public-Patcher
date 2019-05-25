namespace Patcher_Public
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.enableSahFX = new System.Windows.Forms.Button();
            this.disableSahFX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.successfulPatchLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.detectFX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.disableGameFX = new System.Windows.Forms.Button();
            this.enableGameFX = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Sah/exe files only|*.sah;*.exe";
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.BackColor = System.Drawing.Color.DimGray;
            this.directoryTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryTextBox.ForeColor = System.Drawing.Color.Silver;
            this.directoryTextBox.Location = new System.Drawing.Point(232, 179);
            this.directoryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.ReadOnly = true;
            this.directoryTextBox.Size = new System.Drawing.Size(551, 22);
            this.directoryTextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(815, 179);
            this.browseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(87, 26);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // enableSahFX
            // 
            this.enableSahFX.Enabled = false;
            this.enableSahFX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableSahFX.Location = new System.Drawing.Point(793, 383);
            this.enableSahFX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enableSahFX.Name = "enableSahFX";
            this.enableSahFX.Size = new System.Drawing.Size(110, 26);
            this.enableSahFX.TabIndex = 2;
            this.enableSahFX.Text = "Enable effects";
            this.enableSahFX.UseVisualStyleBackColor = true;
            this.enableSahFX.Click += new System.EventHandler(this.enableSahFX_Click);
            // 
            // disableSahFX
            // 
            this.disableSahFX.Enabled = false;
            this.disableSahFX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableSahFX.Location = new System.Drawing.Point(793, 308);
            this.disableSahFX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.disableSahFX.Name = "disableSahFX";
            this.disableSahFX.Size = new System.Drawing.Size(110, 26);
            this.disableSahFX.TabIndex = 3;
            this.disableSahFX.Text = "Disable effects";
            this.disableSahFX.UseVisualStyleBackColor = true;
            this.disableSahFX.Click += new System.EventHandler(this.disableSahFX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(799, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "data.sah options";
            // 
            // successfulPatchLabel
            // 
            this.successfulPatchLabel.AutoSize = true;
            this.successfulPatchLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.successfulPatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successfulPatchLabel.ForeColor = System.Drawing.Color.Lime;
            this.successfulPatchLabel.Location = new System.Drawing.Point(311, 465);
            this.successfulPatchLabel.Name = "successfulPatchLabel";
            this.successfulPatchLabel.Size = new System.Drawing.Size(0, 20);
            this.successfulPatchLabel.TabIndex = 5;
            this.successfulPatchLabel.Click += new System.EventHandler(this.successfulPatchLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Path to data.sah or game.exe";
            // 
            // detectFX
            // 
            this.detectFX.AutoSize = true;
            this.detectFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectFX.ForeColor = System.Drawing.Color.Silver;
            this.detectFX.Location = new System.Drawing.Point(260, 422);
            this.detectFX.Name = "detectFX";
            this.detectFX.Size = new System.Drawing.Size(0, 20);
            this.detectFX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Help;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(36, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "game.exe options";
            // 
            // disableGameFX
            // 
            this.disableGameFX.Enabled = false;
            this.disableGameFX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableGameFX.Location = new System.Drawing.Point(31, 308);
            this.disableGameFX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.disableGameFX.Name = "disableGameFX";
            this.disableGameFX.Size = new System.Drawing.Size(110, 26);
            this.disableGameFX.TabIndex = 10;
            this.disableGameFX.Text = "Disable effects";
            this.disableGameFX.UseVisualStyleBackColor = true;
            this.disableGameFX.Click += new System.EventHandler(this.disableGameFX_Click);
            // 
            // enableGameFX
            // 
            this.enableGameFX.Enabled = false;
            this.enableGameFX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableGameFX.Location = new System.Drawing.Point(31, 383);
            this.enableGameFX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enableGameFX.Name = "enableGameFX";
            this.enableGameFX.Size = new System.Drawing.Size(110, 26);
            this.enableGameFX.TabIndex = 9;
            this.enableGameFX.Text = "Enable effects";
            this.enableGameFX.UseVisualStyleBackColor = true;
            this.enableGameFX.Click += new System.EventHandler(this.enableGameFX_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Help;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(36, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "FAQ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.disableGameFX);
            this.Controls.Add(this.enableGameFX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detectFX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.successfulPatchLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disableSahFX);
            this.Controls.Add(this.enableSahFX);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.directoryTextBox);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Public patcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button enableSahFX;
        private System.Windows.Forms.Button disableSahFX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label successfulPatchLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label detectFX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button disableGameFX;
        private System.Windows.Forms.Button enableGameFX;
        private System.Windows.Forms.Label label4;
    }
}

