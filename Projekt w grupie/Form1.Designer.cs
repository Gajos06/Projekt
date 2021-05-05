namespace Projekt_w_grupie
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.autorzy = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::Projekt_w_grupie.Properties.Resources.odpowiedz;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(688, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nowa Gra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::Projekt_w_grupie.Properties.Resources.odpowiedz;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(12, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(688, 94);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // autorzy
            // 
            this.autorzy.Image = global::Projekt_w_grupie.Properties.Resources.odpowiedz;
            this.autorzy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.autorzy.Location = new System.Drawing.Point(12, 209);
            this.autorzy.Name = "autorzy";
            this.autorzy.Size = new System.Drawing.Size(688, 94);
            this.autorzy.TabIndex = 7;
            this.autorzy.Text = "Autorzy";
            this.autorzy.UseVisualStyleBackColor = true;
            this.autorzy.Click += new System.EventHandler(this.autorzy_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Projekt_w_grupie.Properties.Resources.odpowiedz;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(12, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(688, 94);
            this.button3.TabIndex = 8;
            this.button3.Text = "NOWY BUTTON";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(737, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(343, 168);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1527, 608);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.autorzy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button autorzy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

