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
            this.components = new System.ComponentModel.Container();
            this.optionA_btn = new System.Windows.Forms.Button();
            this.optionB_btn = new System.Windows.Forms.Button();
            this.optionC_btn = new System.Windows.Forms.Button();
            this.optionD_btn = new System.Windows.Forms.Button();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.answer_textbox = new System.Windows.Forms.TextBox();
            this.question_textBox = new System.Windows.Forms.TextBox();
            this.nextQuestion_btn = new System.Windows.Forms.Button();
            this.Id_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // optionA_btn
            // 
            this.optionA_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.optionA_btn.Location = new System.Drawing.Point(12, 313);
            this.optionA_btn.Name = "optionA_btn";
            this.optionA_btn.Size = new System.Drawing.Size(300, 98);
            this.optionA_btn.TabIndex = 2;
            this.optionA_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionA_btn.UseVisualStyleBackColor = true;
            this.optionA_btn.Click += new System.EventHandler(this.optionA_btn_Click);
            // 
            // optionB_btn
            // 
            this.optionB_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.optionB_btn.Location = new System.Drawing.Point(374, 313);
            this.optionB_btn.Name = "optionB_btn";
            this.optionB_btn.Size = new System.Drawing.Size(300, 98);
            this.optionB_btn.TabIndex = 9;
            this.optionB_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionB_btn.UseVisualStyleBackColor = true;
            this.optionB_btn.Click += new System.EventHandler(this.optionB_btn_Click);
            // 
            // optionC_btn
            // 
            this.optionC_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.optionC_btn.Location = new System.Drawing.Point(12, 438);
            this.optionC_btn.Name = "optionC_btn";
            this.optionC_btn.Size = new System.Drawing.Size(300, 98);
            this.optionC_btn.TabIndex = 10;
            this.optionC_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionC_btn.UseVisualStyleBackColor = true;
            this.optionC_btn.Click += new System.EventHandler(this.optionC_btn_Click);
            // 
            // optionD_btn
            // 
            this.optionD_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.optionD_btn.Location = new System.Drawing.Point(374, 438);
            this.optionD_btn.Name = "optionD_btn";
            this.optionD_btn.Size = new System.Drawing.Size(300, 98);
            this.optionD_btn.TabIndex = 11;
            this.optionD_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionD_btn.UseVisualStyleBackColor = true;
            this.optionD_btn.Click += new System.EventHandler(this.optionD_btn_Click);
            // 
            // answer_textbox
            // 
            this.answer_textbox.Location = new System.Drawing.Point(12, 197);
            this.answer_textbox.Name = "answer_textbox";
            this.answer_textbox.Size = new System.Drawing.Size(100, 20);
            this.answer_textbox.TabIndex = 12;
            // 
            // question_textBox
            // 
            this.question_textBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_textBox.Location = new System.Drawing.Point(12, 223);
            this.question_textBox.Multiline = true;
            this.question_textBox.Name = "question_textBox";
            this.question_textBox.Size = new System.Drawing.Size(662, 68);
            this.question_textBox.TabIndex = 13;
            // 
            // nextQuestion_btn
            // 
            this.nextQuestion_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.nextQuestion_btn.Location = new System.Drawing.Point(453, 157);
            this.nextQuestion_btn.Name = "nextQuestion_btn";
            this.nextQuestion_btn.Size = new System.Drawing.Size(221, 51);
            this.nextQuestion_btn.TabIndex = 14;
            this.nextQuestion_btn.Text = "Nastepne Pytanie";
            this.nextQuestion_btn.UseVisualStyleBackColor = true;
            this.nextQuestion_btn.Click += new System.EventHandler(this.nextQuestion_btn_Click);
            // 
            // Id_textBox
            // 
            this.Id_textBox.Location = new System.Drawing.Point(130, 197);
            this.Id_textBox.Name = "Id_textBox";
            this.Id_textBox.Size = new System.Drawing.Size(100, 20);
            this.Id_textBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1527, 608);
            this.Controls.Add(this.Id_textBox);
            this.Controls.Add(this.nextQuestion_btn);
            this.Controls.Add(this.question_textBox);
            this.Controls.Add(this.answer_textbox);
            this.Controls.Add(this.optionD_btn);
            this.Controls.Add(this.optionC_btn);
            this.Controls.Add(this.optionB_btn);
            this.Controls.Add(this.optionA_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button optionA_btn;
        private System.Windows.Forms.Button optionB_btn;
        private System.Windows.Forms.Button optionC_btn;
        private System.Windows.Forms.Button optionD_btn;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.TextBox answer_textbox;
        private System.Windows.Forms.TextBox question_textBox;
        private System.Windows.Forms.Button nextQuestion_btn;
        private System.Windows.Forms.TextBox Id_textBox;
    }
}

