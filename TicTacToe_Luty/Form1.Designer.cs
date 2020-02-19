namespace TicTacToe_Luty
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A4 = new System.Windows.Forms.Button();
            this.A5 = new System.Windows.Forms.Button();
            this.A6 = new System.Windows.Forms.Button();
            this.A7 = new System.Windows.Forms.Button();
            this.A8 = new System.Windows.Forms.Button();
            this.A9 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A1.Location = new System.Drawing.Point(32, 27);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(70, 70);
            this.A1.TabIndex = 0;
            this.A1.Tag = "2";
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A2.Location = new System.Drawing.Point(108, 29);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(70, 70);
            this.A2.TabIndex = 1;
            this.A2.Tag = "7";
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A3.Location = new System.Drawing.Point(184, 29);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(70, 70);
            this.A3.TabIndex = 2;
            this.A3.Tag = "6";
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // A4
            // 
            this.A4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A4.Location = new System.Drawing.Point(32, 105);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(70, 70);
            this.A4.TabIndex = 3;
            this.A4.Tag = "9";
            this.A4.UseVisualStyleBackColor = true;
            this.A4.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // A5
            // 
            this.A5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A5.Location = new System.Drawing.Point(108, 105);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(70, 70);
            this.A5.TabIndex = 4;
            this.A5.Tag = "5";
            this.A5.UseVisualStyleBackColor = true;
            this.A5.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // A6
            // 
            this.A6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A6.Location = new System.Drawing.Point(184, 105);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(70, 70);
            this.A6.TabIndex = 5;
            this.A6.Tag = "1";
            this.A6.UseVisualStyleBackColor = true;
            this.A6.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // A7
            // 
            this.A7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A7.Location = new System.Drawing.Point(32, 181);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(70, 70);
            this.A7.TabIndex = 6;
            this.A7.Tag = "4";
            this.A7.UseVisualStyleBackColor = true;
            this.A7.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // A8
            // 
            this.A8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A8.Location = new System.Drawing.Point(108, 181);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(70, 70);
            this.A8.TabIndex = 7;
            this.A8.Tag = "3";
            this.A8.UseVisualStyleBackColor = true;
            this.A8.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // A9
            // 
            this.A9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A9.Location = new System.Drawing.Point(184, 181);
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(70, 70);
            this.A9.TabIndex = 8;
            this.A9.Tag = "8";
            this.A9.UseVisualStyleBackColor = true;
            this.A9.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 267);
            this.Controls.Add(this.A9);
            this.Controls.Add(this.A8);
            this.Controls.Add(this.A7);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A4;
        private System.Windows.Forms.Button A5;
        private System.Windows.Forms.Button A6;
        private System.Windows.Forms.Button A7;
        private System.Windows.Forms.Button A8;
        private System.Windows.Forms.Button A9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

