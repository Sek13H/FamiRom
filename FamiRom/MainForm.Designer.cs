namespace FamiRom
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.AboutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.GitHubStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.NesDevStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.IconStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Selectbtn = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutStrip});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // AboutStrip
            // 
            this.AboutStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStrip,
            this.GitHubStrip,
            this.NesDevStrip,
            this.IconStrip});
            this.AboutStrip.Name = "AboutStrip";
            this.AboutStrip.Size = new System.Drawing.Size(82, 20);
            this.AboutStrip.Text = "About/Help";
            // 
            // AboutToolStrip
            // 
            this.AboutToolStrip.Name = "AboutToolStrip";
            this.AboutToolStrip.Size = new System.Drawing.Size(180, 22);
            this.AboutToolStrip.Text = "About";
            this.AboutToolStrip.Click += new System.EventHandler(this.AboutToolStrip_Click);
            // 
            // GitHubStrip
            // 
            this.GitHubStrip.Name = "GitHubStrip";
            this.GitHubStrip.Size = new System.Drawing.Size(180, 22);
            this.GitHubStrip.Text = "GitHub";
            this.GitHubStrip.Click += new System.EventHandler(this.GitHubStrip_Click);
            // 
            // NesDevStrip
            // 
            this.NesDevStrip.Name = "NesDevStrip";
            this.NesDevStrip.Size = new System.Drawing.Size(180, 22);
            this.NesDevStrip.Text = "NesDev.org";
            this.NesDevStrip.Click += new System.EventHandler(this.NesDevStrip_Click);
            // 
            // IconStrip
            // 
            this.IconStrip.Name = "IconStrip";
            this.IconStrip.Size = new System.Drawing.Size(180, 22);
            this.IconStrip.Text = "Icon";
            this.IconStrip.Click += new System.EventHandler(this.IconStrip_Click);
            // 
            // Selectbtn
            // 
            this.Selectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Selectbtn.Location = new System.Drawing.Point(10, 45);
            this.Selectbtn.Name = "Selectbtn";
            this.Selectbtn.Size = new System.Drawing.Size(779, 106);
            this.Selectbtn.TabIndex = 1;
            this.Selectbtn.Text = "Select .nes File";
            this.Selectbtn.UseVisualStyleBackColor = true;
            this.Selectbtn.Click += new System.EventHandler(this.Selectbtn_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OutputLabel.Location = new System.Drawing.Point(273, 192);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(108, 25);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "Information";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Selectbtn);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "FamiRom";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutStrip;
        private System.Windows.Forms.Button Selectbtn;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStrip;
        private System.Windows.Forms.ToolStripMenuItem GitHubStrip;
        private System.Windows.Forms.ToolStripMenuItem NesDevStrip;
        private System.Windows.Forms.ToolStripMenuItem IconStrip;
    }
}

