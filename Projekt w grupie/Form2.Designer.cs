
namespace Projekt_w_grupie
{
    partial class Form2
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
            this.nextQuestion_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextQuestion_btn
            // 
            this.nextQuestion_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.button5;
            this.nextQuestion_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.nextQuestion_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextQuestion_btn.Location = new System.Drawing.Point(55, 203);
            this.nextQuestion_btn.Name = "nextQuestion_btn";
            this.nextQuestion_btn.Size = new System.Drawing.Size(221, 51);
            this.nextQuestion_btn.TabIndex = 15;
            this.nextQuestion_btn.Text = "Wyjscie z Gry";
            this.nextQuestion_btn.UseVisualStyleBackColor = true;
            this.nextQuestion_btn.Click += new System.EventHandler(this.nextQuestion_btn_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.button5;
            this.button1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(55, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "Nowa Gra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.button5;
            this.button2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(90, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 54);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(84, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Twój Wynik";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::Projekt_w_grupie.Properties.Resources._135153_blue_solid_backgrounds_screensaver_2560x1600_h;
            this.ClientSize = new System.Drawing.Size(334, 284);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextQuestion_btn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextQuestion_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}