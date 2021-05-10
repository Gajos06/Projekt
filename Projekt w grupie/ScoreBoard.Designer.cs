
namespace Projekt_w_grupie
{
    partial class ScoreBoard
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
            this.start_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start_btn.Image = global::Projekt_w_grupie.Properties.Resources.general;
            this.start_btn.Location = new System.Drawing.Point(12, 12);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(488, 38);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "    NICK                                                                         " +
    "          WYNIK";
            this.start_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.start_btn.UseVisualStyleBackColor = true;
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_w_grupie.Properties.Resources._135153_blue_solid_backgrounds_screensaver_2560x1600_h;
            this.ClientSize = new System.Drawing.Size(512, 406);
            this.Controls.Add(this.start_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScoreBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablica Wyników";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScoreBoard_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
    }
}