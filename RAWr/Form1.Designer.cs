namespace RAWr
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FolderButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pathLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderButton
            // 
            this.FolderButton.BackColor = System.Drawing.Color.Gray;
            this.FolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FolderButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FolderButton.Location = new System.Drawing.Point(28, -3);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(36, 23);
            this.FolderButton.TabIndex = 0;
            this.FolderButton.Text = "In";
            this.FolderButton.UseVisualStyleBackColor = false;
            this.FolderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pathLabel.Location = new System.Drawing.Point(101, 2);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Path";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Gray;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveButton.Location = new System.Drawing.Point(61, -3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(34, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Out";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.BackColor = System.Drawing.Color.Gray;
            this.StartButton.Enabled = false;
            this.StartButton.ForeColor = System.Drawing.SystemColors.Window;
            this.StartButton.Location = new System.Drawing.Point(448, -4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(37, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Go";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.ErrorImage = global::RAWr.Properties.Resources.Splashrawr;
            this.pictureBox1.InitialImage = global::RAWr.Properties.Resources.Splashrawr;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.infoLabel.Location = new System.Drawing.Point(0, 526);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(25, 13);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Info";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Enabled = false;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Location = new System.Drawing.Point(-1, -4);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(31, 23);
            this.buttonCheck.TabIndex = 6;
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(731, 539);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.buttonCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(747, 578);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAWr - V1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button buttonCheck;
    }
}

