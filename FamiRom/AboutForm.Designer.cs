namespace FamiRom
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.AboutLabel1 = new System.Windows.Forms.Label();
            this.AboutLabel2 = new System.Windows.Forms.Label();
            this.AboutLabel3 = new System.Windows.Forms.Label();
            this.AboutLabel4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::FamiRom.Properties.Resources.PictureBox;
            this.PictureBox.Location = new System.Drawing.Point(0, 1);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(216, 669);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // AboutLabel1
            // 
            this.AboutLabel1.AutoSize = true;
            this.AboutLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AboutLabel1.Location = new System.Drawing.Point(230, 13);
            this.AboutLabel1.Name = "AboutLabel1";
            this.AboutLabel1.Size = new System.Drawing.Size(212, 25);
            this.AboutLabel1.TabIndex = 1;
            this.AboutLabel1.Text = "FamiRom By reimolaev";
            // 
            // AboutLabel2
            // 
            this.AboutLabel2.AutoSize = true;
            this.AboutLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AboutLabel2.Location = new System.Drawing.Point(230, 331);
            this.AboutLabel2.Name = "AboutLabel2";
            this.AboutLabel2.Size = new System.Drawing.Size(117, 25);
            this.AboutLabel2.TabIndex = 2;
            this.AboutLabel2.Text = "Version: 1.2";
            // 
            // AboutLabel3
            // 
            this.AboutLabel3.AutoSize = true;
            this.AboutLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AboutLabel3.Location = new System.Drawing.Point(227, 99);
            this.AboutLabel3.Name = "AboutLabel3";
            this.AboutLabel3.Size = new System.Drawing.Size(369, 90);
            this.AboutLabel3.TabIndex = 3;
            this.AboutLabel3.Text = "Thanks:\r\nNesDev.org: Mappers Name\r\nnesdir.github.io: For the names of games with " +
    "mappers\r\n@Malaert64: Icon\r\n\r\n";
            // 
            // AboutLabel4
            // 
            this.AboutLabel4.AutoSize = true;
            this.AboutLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AboutLabel4.Location = new System.Drawing.Point(232, 374);
            this.AboutLabel4.Name = "AboutLabel4";
            this.AboutLabel4.Size = new System.Drawing.Size(113, 17);
            this.AboutLabel4.TabIndex = 4;
            this.AboutLabel4.Text = "reimolaev, 2025.";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 400);
            this.Controls.Add(this.AboutLabel4);
            this.Controls.Add(this.AboutLabel3);
            this.Controls.Add(this.AboutLabel2);
            this.Controls.Add(this.AboutLabel1);
            this.Controls.Add(this.PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label AboutLabel1;
        private System.Windows.Forms.Label AboutLabel2;
        private System.Windows.Forms.Label AboutLabel3;
        private System.Windows.Forms.Label AboutLabel4;
    }
}