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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.answer_textbox = new System.Windows.Forms.TextBox();
            this.nextQuestion_btn = new System.Windows.Forms.Button();
            this.question_textBox = new System.Windows.Forms.Button();
            this.optionD_btn = new System.Windows.Forms.Button();
            this.optionC_btn = new System.Windows.Forms.Button();
            this.optionB_btn = new System.Windows.Forms.Button();
            this.optionA_btn = new System.Windows.Forms.Button();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.name_btn = new System.Windows.Forms.Button();
            this.fifty_btn = new System.Windows.Forms.Button();
            this.audience_btn = new System.Windows.Forms.Button();
            this.swap_btn = new System.Windows.Forms.Button();
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_200 = new System.Windows.Forms.Button();
            this.btn_300 = new System.Windows.Forms.Button();
            this.btn_500 = new System.Windows.Forms.Button();
            this.btn_8000 = new System.Windows.Forms.Button();
            this.btn_4000 = new System.Windows.Forms.Button();
            this.btn_2000 = new System.Windows.Forms.Button();
            this.btn_1000 = new System.Windows.Forms.Button();
            this.btn_125000 = new System.Windows.Forms.Button();
            this.btn_64000 = new System.Windows.Forms.Button();
            this.btn_32000 = new System.Windows.Forms.Button();
            this.btn_16000 = new System.Windows.Forms.Button();
            this.btn_million = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_250000 = new System.Windows.Forms.Button();
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
            // fifty_btn
            // 
            this.fifty_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fifty_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources._50501;
            this.fifty_btn.FlatAppearance.BorderSize = 0;
            this.fifty_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fifty_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fifty_btn.Location = new System.Drawing.Point(555, 13);
            this.fifty_btn.Name = "fifty_btn";
            this.fifty_btn.Size = new System.Drawing.Size(60, 45);
            this.fifty_btn.TabIndex = 23;
            this.fifty_btn.UseVisualStyleBackColor = false;
            this.fifty_btn.Click += new System.EventHandler(this.fifty_btn_Click);
            // 
            // audience_btn
            // 
            this.audience_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.audience_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.audience;
            this.audience_btn.FlatAppearance.BorderSize = 0;
            this.audience_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audience_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.audience_btn.Location = new System.Drawing.Point(620, 13);
            this.audience_btn.Name = "audience_btn";
            this.audience_btn.Size = new System.Drawing.Size(60, 45);
            this.audience_btn.TabIndex = 24;
            this.audience_btn.UseVisualStyleBackColor = false;
            this.audience_btn.Click += new System.EventHandler(this.audience_btn_Click);
            // 
            // swap_btn
            // 
            this.swap_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.swap_btn.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.swap;
            this.swap_btn.FlatAppearance.BorderSize = 0;
            this.swap_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swap_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.swap_btn.Location = new System.Drawing.Point(689, 13);
            this.swap_btn.Name = "swap_btn";
            this.swap_btn.Size = new System.Drawing.Size(60, 45);
            this.swap_btn.TabIndex = 25;
            this.swap_btn.UseVisualStyleBackColor = false;
            this.swap_btn.Click += new System.EventHandler(this.swap_btn_Click);
            // 
            // btn_100
            // 
            this.btn_100.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_100.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_100.FlatAppearance.BorderSize = 0;
            this.btn_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_100.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_100.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_100.Location = new System.Drawing.Point(850, 509);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(255, 30);
            this.btn_100.TabIndex = 26;
            this.btn_100.Text = "100$";
            this.btn_100.UseVisualStyleBackColor = false;
            // 
            // btn_200
            // 
            this.btn_200.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_200.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_200.FlatAppearance.BorderSize = 0;
            this.btn_200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_200.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_200.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_200.Location = new System.Drawing.Point(850, 473);
            this.btn_200.Name = "btn_200";
            this.btn_200.Size = new System.Drawing.Size(255, 30);
            this.btn_200.TabIndex = 27;
            this.btn_200.Text = "200$";
            this.btn_200.UseVisualStyleBackColor = false;
            // 
            // btn_300
            // 
            this.btn_300.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_300.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_300.FlatAppearance.BorderSize = 0;
            this.btn_300.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_300.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_300.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_300.Location = new System.Drawing.Point(850, 437);
            this.btn_300.Name = "btn_300";
            this.btn_300.Size = new System.Drawing.Size(255, 30);
            this.btn_300.TabIndex = 28;
            this.btn_300.Text = "300$";
            this.btn_300.UseVisualStyleBackColor = false;
            // 
            // btn_500
            // 
            this.btn_500.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_500.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_500.FlatAppearance.BorderSize = 0;
            this.btn_500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_500.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_500.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_500.Location = new System.Drawing.Point(850, 401);
            this.btn_500.Name = "btn_500";
            this.btn_500.Size = new System.Drawing.Size(255, 30);
            this.btn_500.TabIndex = 29;
            this.btn_500.Text = "500$";
            this.btn_500.UseVisualStyleBackColor = false;
            // 
            // btn_8000
            // 
            this.btn_8000.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_8000.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_8000.FlatAppearance.BorderSize = 0;
            this.btn_8000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_8000.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_8000.Location = new System.Drawing.Point(850, 257);
            this.btn_8000.Name = "btn_8000";
            this.btn_8000.Size = new System.Drawing.Size(255, 30);
            this.btn_8000.TabIndex = 33;
            this.btn_8000.Text = "8 000$";
            this.btn_8000.UseVisualStyleBackColor = false;
            // 
            // btn_4000
            // 
            this.btn_4000.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_4000.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_4000.FlatAppearance.BorderSize = 0;
            this.btn_4000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_4000.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_4000.Location = new System.Drawing.Point(850, 293);
            this.btn_4000.Name = "btn_4000";
            this.btn_4000.Size = new System.Drawing.Size(255, 30);
            this.btn_4000.TabIndex = 32;
            this.btn_4000.Text = "4 000$";
            this.btn_4000.UseVisualStyleBackColor = false;
            // 
            // btn_2000
            // 
            this.btn_2000.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_2000.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_2000.FlatAppearance.BorderSize = 0;
            this.btn_2000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_2000.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_2000.Location = new System.Drawing.Point(850, 329);
            this.btn_2000.Name = "btn_2000";
            this.btn_2000.Size = new System.Drawing.Size(255, 30);
            this.btn_2000.TabIndex = 31;
            this.btn_2000.Text = "2 000$";
            this.btn_2000.UseVisualStyleBackColor = false;
            // 
            // btn_1000
            // 
            this.btn_1000.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_1000.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_1000.FlatAppearance.BorderSize = 0;
            this.btn_1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_1000.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_1000.Location = new System.Drawing.Point(850, 365);
            this.btn_1000.Name = "btn_1000";
            this.btn_1000.Size = new System.Drawing.Size(255, 30);
            this.btn_1000.TabIndex = 30;
            this.btn_1000.Text = "1 000$";
            this.btn_1000.UseVisualStyleBackColor = false;
            // 
            // btn_125000
            // 
            this.btn_125000.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_125000.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_125000.FlatAppearance.BorderSize = 0;
            this.btn_125000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_125000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_125000.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_125000.Location = new System.Drawing.Point(850, 113);
            this.btn_125000.Name = "btn_125000";
            this.btn_125000.Size = new System.Drawing.Size(255, 30);
            this.btn_125000.TabIndex = 37;
            this.btn_125000.Text = "125 000$";
            this.btn_125000.UseVisualStyleBackColor = false;
            // 
            // btn_64000
            // 
            this.btn_64000.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_64000.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_64000.FlatAppearance.BorderSize = 0;
            this.btn_64000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_64000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_64000.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_64000.Location = new System.Drawing.Point(850, 149);
            this.btn_64000.Name = "btn_64000";
            this.btn_64000.Size = new System.Drawing.Size(255, 30);
            this.btn_64000.TabIndex = 36;
            this.btn_64000.Text = "64 000$";
            this.btn_64000.UseVisualStyleBackColor = false;
            // 
            // btn_32000
            // 
            this.btn_32000.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_32000.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_32000.FlatAppearance.BorderSize = 0;
            this.btn_32000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_32000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_32000.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_32000.Location = new System.Drawing.Point(850, 185);
            this.btn_32000.Name = "btn_32000";
            this.btn_32000.Size = new System.Drawing.Size(255, 30);
            this.btn_32000.TabIndex = 35;
            this.btn_32000.Text = "32 000$";
            this.btn_32000.UseVisualStyleBackColor = false;
            // 
            // btn_16000
            // 
            this.btn_16000.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_16000.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_16000.FlatAppearance.BorderSize = 0;
            this.btn_16000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_16000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_16000.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_16000.Location = new System.Drawing.Point(850, 221);
            this.btn_16000.Name = "btn_16000";
            this.btn_16000.Size = new System.Drawing.Size(255, 30);
            this.btn_16000.TabIndex = 34;
            this.btn_16000.Text = "16 000$";
            this.btn_16000.UseVisualStyleBackColor = false;
            // 
            // btn_million
            // 
            this.btn_million.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_million.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_million.FlatAppearance.BorderSize = 0;
            this.btn_million.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_million.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_million.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_million.Location = new System.Drawing.Point(850, 4);
            this.btn_million.Name = "btn_million";
            this.btn_million.Size = new System.Drawing.Size(255, 30);
            this.btn_million.TabIndex = 40;
            this.btn_million.Text = "1 MILLION $";
            this.btn_million.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(850, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 30);
            this.button2.TabIndex = 39;
            this.button2.Text = "500 000$";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_250000
            // 
            this.btn_250000.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_250000.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.price_btn;
            this.btn_250000.FlatAppearance.BorderSize = 0;
            this.btn_250000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_250000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btn_250000.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_250000.Location = new System.Drawing.Point(850, 76);
            this.btn_250000.Name = "btn_250000";
            this.btn_250000.Size = new System.Drawing.Size(255, 30);
            this.btn_250000.TabIndex = 38;
            this.btn_250000.Text = "250 000$";
            this.btn_250000.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Projekt_w_grupie.Properties.Resources.backGround3;
            this.ClientSize = new System.Drawing.Size(1110, 550);
            this.Controls.Add(this.btn_million);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_250000);
            this.Controls.Add(this.btn_125000);
            this.Controls.Add(this.btn_64000);
            this.Controls.Add(this.btn_32000);
            this.Controls.Add(this.btn_16000);
            this.Controls.Add(this.btn_8000);
            this.Controls.Add(this.btn_4000);
            this.Controls.Add(this.btn_2000);
            this.Controls.Add(this.btn_1000);
            this.Controls.Add(this.btn_500);
            this.Controls.Add(this.btn_300);
            this.Controls.Add(this.btn_200);
            this.Controls.Add(this.btn_100);
            this.Controls.Add(this.swap_btn);
            this.Controls.Add(this.audience_btn);
            this.Controls.Add(this.fifty_btn);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Button name_btn;
        private System.Windows.Forms.Button fifty_btn;
        private System.Windows.Forms.Button audience_btn;
        private System.Windows.Forms.Button swap_btn;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Button btn_200;
        private System.Windows.Forms.Button btn_300;
        private System.Windows.Forms.Button btn_500;
        private System.Windows.Forms.Button btn_8000;
        private System.Windows.Forms.Button btn_4000;
        private System.Windows.Forms.Button btn_2000;
        private System.Windows.Forms.Button btn_1000;
        private System.Windows.Forms.Button btn_125000;
        private System.Windows.Forms.Button btn_64000;
        private System.Windows.Forms.Button btn_32000;
        private System.Windows.Forms.Button btn_16000;
        private System.Windows.Forms.Button btn_million;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_250000;
    }
}

