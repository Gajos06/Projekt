﻿namespace Projekt_w_grupie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.answer_textbox = new System.Windows.Forms.TextBox();
            this.nextQuestion_btn = new System.Windows.Forms.Button();
            this.question_textBox = new System.Windows.Forms.Button();
            this.optionD_btn = new System.Windows.Forms.Button();
            this.optionC_btn = new System.Windows.Forms.Button();
            this.optionB_btn = new System.Windows.Forms.Button();
            this.optionA_btn = new System.Windows.Forms.Button();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.name_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answer_textbox
            // 
            this.answer_textbox.Location = new System.Drawing.Point(12, 12);
            this.answer_textbox.Name = "answer_textbox";
            this.answer_textbox.Size = new System.Drawing.Size(100, 20);
            this.answer_textbox.TabIndex = 12;
            // 
            // nextQuestion_btn
            // 
            this.nextQuestion_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.button5;
            this.nextQuestion_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.nextQuestion_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextQuestion_btn.Location = new System.Drawing.Point(528, 168);
            this.nextQuestion_btn.Name = "nextQuestion_btn";
            this.nextQuestion_btn.Size = new System.Drawing.Size(221, 51);
            this.nextQuestion_btn.TabIndex = 14;
            this.nextQuestion_btn.Text = "Nastepne Pytanie";
            this.nextQuestion_btn.UseVisualStyleBackColor = true;
            this.nextQuestion_btn.Click += new System.EventHandler(this.nextQuestion_btn_Click);
            // 
            // question_textBox
            // 
            this.question_textBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.question_textBox.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.button4;
            this.question_textBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.question_textBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.question_textBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.question_textBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.question_textBox.Location = new System.Drawing.Point(22, 223);
            this.question_textBox.Name = "question_textBox";
            this.question_textBox.Size = new System.Drawing.Size(727, 98);
            this.question_textBox.TabIndex = 21;
            this.question_textBox.UseVisualStyleBackColor = false;
            // 
            // optionD_btn
            // 
            this.optionD_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optionD_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.newbutton;
            this.optionD_btn.FlatAppearance.BorderSize = 0;
            this.optionD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionD_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.optionD_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionD_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionD_btn.Location = new System.Drawing.Point(393, 441);
            this.optionD_btn.Name = "optionD_btn";
            this.optionD_btn.Size = new System.Drawing.Size(356, 98);
            this.optionD_btn.TabIndex = 20;
            this.optionD_btn.UseVisualStyleBackColor = false;
            this.optionD_btn.Click += new System.EventHandler(this.optionD_btn_Click);
            // 
            // optionC_btn
            // 
            this.optionC_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optionC_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.newbutton;
            this.optionC_btn.FlatAppearance.BorderSize = 0;
            this.optionC_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionC_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.optionC_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionC_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionC_btn.Location = new System.Drawing.Point(22, 441);
            this.optionC_btn.Name = "optionC_btn";
            this.optionC_btn.Size = new System.Drawing.Size(356, 98);
            this.optionC_btn.TabIndex = 19;
            this.optionC_btn.UseVisualStyleBackColor = false;
            this.optionC_btn.Click += new System.EventHandler(this.optionC_btn_Click);
            // 
            // optionB_btn
            // 
            this.optionB_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optionB_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.newbutton;
            this.optionB_btn.FlatAppearance.BorderSize = 0;
            this.optionB_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionB_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.optionB_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionB_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionB_btn.Location = new System.Drawing.Point(393, 337);
            this.optionB_btn.Name = "optionB_btn";
            this.optionB_btn.Size = new System.Drawing.Size(356, 98);
            this.optionB_btn.TabIndex = 18;
            this.optionB_btn.UseVisualStyleBackColor = false;
            this.optionB_btn.Click += new System.EventHandler(this.optionB_btn_Click);
            // 
            // optionA_btn
            // 
            this.optionA_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optionA_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.newbutton;
            this.optionA_btn.FlatAppearance.BorderSize = 0;
            this.optionA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionA_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionA_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionA_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionA_btn.Location = new System.Drawing.Point(22, 337);
            this.optionA_btn.Name = "optionA_btn";
            this.optionA_btn.Size = new System.Drawing.Size(356, 98);
            this.optionA_btn.TabIndex = 17;
            this.optionA_btn.UseVisualStyleBackColor = false;
            this.optionA_btn.Click += new System.EventHandler(this.optionA_btn_Click);
            // 
            // delay
            // 
            this.delay.Interval = 3000;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // name_btn
            // 
            this.name_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_btn.Image = global::Projekt_w_grupie.Properties.Resources.general;
            this.name_btn.Location = new System.Drawing.Point(12, 12);
            this.name_btn.Name = "name_btn";
            this.name_btn.Size = new System.Drawing.Size(213, 46);
            this.name_btn.TabIndex = 22;
            this.name_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.backGround31;
            this.ClientSize = new System.Drawing.Size(1170, 550);
            this.Controls.Add(this.name_btn);
            this.Controls.Add(this.question_textBox);
            this.Controls.Add(this.optionD_btn);
            this.Controls.Add(this.optionC_btn);
            this.Controls.Add(this.optionB_btn);
            this.Controls.Add(this.optionA_btn);
            this.Controls.Add(this.nextQuestion_btn);
            this.Controls.Add(this.answer_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milionerzy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox answer_textbox;
        private System.Windows.Forms.Button nextQuestion_btn;
        private System.Windows.Forms.Button optionA_btn;
        private System.Windows.Forms.Button optionB_btn;
        private System.Windows.Forms.Button optionD_btn;
        private System.Windows.Forms.Button optionC_btn;
        private System.Windows.Forms.Button question_textBox;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button name_btn;
    }
}

