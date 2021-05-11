
namespace Projekt_w_grupie
{
    partial class enterName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enterName));
            this.start_btn = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start_btn.Image = global::Projekt_w_grupie.Properties.Resources.general;
            this.start_btn.Location = new System.Drawing.Point(12, 12);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(484, 86);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "WPROWADŹ SWOJE IMIĘ";
            this.start_btn.UseVisualStyleBackColor = true;
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F);
            this.name_textBox.Location = new System.Drawing.Point(12, 121);
            this.name_textBox.Multiline = true;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(315, 46);
            this.name_textBox.TabIndex = 2;
            this.name_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_textBox_KeyDown);
            // 
            // Ok_btn
            // 
            this.Ok_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ok_btn.Image = global::Projekt_w_grupie.Properties.Resources.general;
            this.Ok_btn.Location = new System.Drawing.Point(380, 121);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(98, 49);
            this.Ok_btn.TabIndex = 3;
            this.Ok_btn.Text = "OK";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // enterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_w_grupie.Properties.Resources._135153_blue_solid_backgrounds_screensaver_2560x1600_h;
            this.ClientSize = new System.Drawing.Size(508, 205);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.start_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "enterName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milionerzy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.enterName_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Button Ok_btn;
    }
}