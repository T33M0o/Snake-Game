namespace Snake
{
    partial class frmMain
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(0, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(300, 200);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Creat de Teuca Timotei\r\n\r\nFolositi sagetile pentru a schimba directia\r\n\r\nApasati " +
    "SPACE pentru a pune pauza\r\n\r\nApasati ENTER pentru a incepe !\r\n";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 239);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(316, 239);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake - Score: 1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
    }
}

