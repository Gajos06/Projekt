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
            this.start_btn = new System.Windows.Forms.Button();
            this.optionB_btn = new System.Windows.Forms.Button();
            this.optionC_btn = new System.Windows.Forms.Button();
            this.optionD_btn = new System.Windows.Forms.Button();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.answer_textbox = new System.Windows.Forms.TextBox();
            this.question_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // optionA_btn
            // 
            this.optionA_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionA_btn.Location = new System.Drawing.Point(12, 313);
            this.optionA_btn.Name = "optionA_btn";
            this.optionA_btn.Size = new System.Drawing.Size(300, 98);
            this.optionA_btn.TabIndex = 2;
            this.optionA_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionA_btn.UseVisualStyleBackColor = true;
            this.optionA_btn.Click += new System.EventHandler(this.optionA_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(160, 45);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(300, 98);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // optionB_btn
            // 
            this.optionB_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.optionC_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.optionD_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionD_btn.Location = new System.Drawing.Point(374, 438);
            this.optionD_btn.Name = "optionD_btn";
            this.optionD_btn.Size = new System.Drawing.Size(300, 98);
            this.optionD_btn.TabIndex = 11;
            this.optionD_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionD_btn.UseVisualStyleBackColor = true;
            this.optionD_btn.Click += new System.EventHandler(this.optionD_btn_Click);
            // 
            // delay
            // 
            this.delay.Interval = 1000;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
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
            this.question_textBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F);
            this.question_textBox.Location = new System.Drawing.Point(12, 223);
            this.question_textBox.Multiline = true;
            this.question_textBox.Name = "question_textBox";
            this.question_textBox.Size = new System.Drawing.Size(662, 59);
            this.question_textBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1527, 608);
            this.Controls.Add(this.answer_textbox);
            this.Controls.Add(this.optionD_btn);
            this.Controls.Add(this.optionC_btn);
            this.Controls.Add(this.optionB_btn);
            this.Controls.Add(this.question_textBox);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.optionA_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button optionA_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button optionB_btn;
        private System.Windows.Forms.Button optionC_btn;
        private System.Windows.Forms.Button optionD_btn;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.TextBox answer_textbox;
        private System.Windows.Forms.TextBox question_textBox;
    }
}

