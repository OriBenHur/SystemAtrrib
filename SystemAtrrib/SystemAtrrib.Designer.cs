namespace SystemAtrrib
{
    partial class SystemAtrrib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemAtrrib));
            this.SysFile = new System.Windows.Forms.Button();
            this.SysFolder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SysFile
            // 
            this.SysFile.BackColor = System.Drawing.Color.Red;
            this.SysFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SysFile.Location = new System.Drawing.Point(28, 10);
            this.SysFile.Name = "SysFile";
            this.SysFile.Size = new System.Drawing.Size(180, 40);
            this.SysFile.TabIndex = 0;
            this.SysFile.Text = "הפוך לקובץ מערכת";
            this.SysFile.UseVisualStyleBackColor = false;
            this.SysFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // SysFolder
            // 
            this.SysFolder.BackColor = System.Drawing.Color.Red;
            this.SysFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SysFolder.Location = new System.Drawing.Point(218, 10);
            this.SysFolder.Name = "SysFolder";
            this.SysFolder.Size = new System.Drawing.Size(180, 40);
            this.SysFolder.TabIndex = 1;
            this.SysFolder.Text = "הפוך לתיקית מערכת";
            this.SysFolder.UseVisualStyleBackColor = false;
            this.SysFolder.Click += new System.EventHandler(this.SysFolder_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(28, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "ביטול הגדרת קובץ מערכת";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(218, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "ביטול הגדרת תיקית מערכת";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SystemAtrrib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 114);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SysFolder);
            this.Controls.Add(this.SysFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SystemAtrrib";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "מה תרצה לעשות?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SystemAtrrib_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SysFile;
        private System.Windows.Forms.Button SysFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

