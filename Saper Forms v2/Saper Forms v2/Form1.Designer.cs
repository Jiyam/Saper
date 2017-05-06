namespace Saper_Forms_v2
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.graToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(103, 41);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(214, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 4;
            this.label2.Tag = "Dane.pozostałoBomb";
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graToolStripMenuItem1
            // 
            this.graToolStripMenuItem1.Name = "graToolStripMenuItem1";
            this.graToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.graToolStripMenuItem1.Text = "Gra";
            // 
            // nowaGraToolStripMenuItem1
            // 
            this.nowaGraToolStripMenuItem1.Name = "nowaGraToolStripMenuItem1";
            this.nowaGraToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // opcjeToolStripMenuItem1
            // 
            this.opcjeToolStripMenuItem1.Name = "opcjeToolStripMenuItem1";
            this.opcjeToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // zakończToolStripMenuItem1
            // 
            this.zakończToolStripMenuItem1.Name = "zakończToolStripMenuItem1";
            this.zakończToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(285, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graToolStripMenuItem2
            // 
            this.graToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem2,
            this.opcjeToolStripMenuItem2,
            this.zakończToolStripMenuItem2});
            this.graToolStripMenuItem2.Name = "graToolStripMenuItem2";
            this.graToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.graToolStripMenuItem2.Text = "Gra";
            // 
            // nowaGraToolStripMenuItem2
            // 
            this.nowaGraToolStripMenuItem2.Name = "nowaGraToolStripMenuItem2";
            this.nowaGraToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.nowaGraToolStripMenuItem2.Text = "Nowa Gra";
            this.nowaGraToolStripMenuItem2.Click += new System.EventHandler(this.nowaGraToolStripMenuItem2_Click);
            // 
            // opcjeToolStripMenuItem2
            // 
            this.opcjeToolStripMenuItem2.Name = "opcjeToolStripMenuItem2";
            this.opcjeToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.opcjeToolStripMenuItem2.Text = "Opcje";
            this.opcjeToolStripMenuItem2.Click += new System.EventHandler(this.opcjeToolStripMenuItem2_Click);
            // 
            // zakończToolStripMenuItem2
            // 
            this.zakończToolStripMenuItem2.Name = "zakończToolStripMenuItem2";
            this.zakończToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.zakończToolStripMenuItem2.Text = "Zakończ";
            this.zakończToolStripMenuItem2.Click += new System.EventHandler(this.zakończToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem2;
    }
}

