namespace Komunikator
{
    partial class Komunikator
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
            this.myProfileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.voipButton = new System.Windows.Forms.Button();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // myProfileButton
            // 
            this.myProfileButton.BackColor = System.Drawing.Color.White;
            this.myProfileButton.FlatAppearance.BorderSize = 0;
            this.myProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.myProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.myProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.myProfileButton.Location = new System.Drawing.Point(25, 131);
            this.myProfileButton.Name = "myProfileButton";
            this.myProfileButton.Size = new System.Drawing.Size(103, 27);
            this.myProfileButton.TabIndex = 1;
            this.myProfileButton.Text = "Mój profil";
            this.myProfileButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Komunikator.Properties.Resources.rozmowa;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(158, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 64);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // voipButton
            // 
            this.voipButton.BackgroundImage = global::Komunikator.Properties.Resources.tele;
            this.voipButton.FlatAppearance.BorderSize = 0;
            this.voipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.voipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.voipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voipButton.Location = new System.Drawing.Point(158, 15);
            this.voipButton.Name = "voipButton";
            this.voipButton.Size = new System.Drawing.Size(67, 64);
            this.voipButton.TabIndex = 2;
            this.voipButton.UseVisualStyleBackColor = true;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Image = global::Komunikator.Properties.Resources.avek1;
            this.avatarPictureBox.Location = new System.Drawing.Point(22, 15);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(109, 102);
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(255, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 319);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(24, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 161);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Komunikator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(543, 359);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.voipButton);
            this.Controls.Add(this.myProfileButton);
            this.Controls.Add(this.avatarPictureBox);
            this.Name = "Komunikator";
            this.Text = "Komunikator";
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Button voipButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}