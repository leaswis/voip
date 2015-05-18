namespace WindowsFormsApplication3
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
            this.userProfile = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ad1PictureBox = new System.Windows.Forms.PictureBox();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.messageButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userProfile
            // 
            this.userProfile.BackColor = System.Drawing.Color.White;
            this.userProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userProfile.Location = new System.Drawing.Point(17, 133);
            this.userProfile.Name = "userProfile";
            this.userProfile.Size = new System.Drawing.Size(107, 28);
            this.userProfile.TabIndex = 7;
            this.userProfile.Text = "o mnie";
            this.userProfile.UseVisualStyleBackColor = false;
            this.userProfile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(237, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(256, 345);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // ad1PictureBox
            // 
            this.ad1PictureBox.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.ads;
            this.ad1PictureBox.Location = new System.Drawing.Point(14, 182);
            this.ad1PictureBox.Name = "ad1PictureBox";
            this.ad1PictureBox.Size = new System.Drawing.Size(208, 176);
            this.ad1PictureBox.TabIndex = 14;
            this.ad1PictureBox.TabStop = false;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.avek1;
            this.avatarPictureBox.Location = new System.Drawing.Point(12, 12);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(118, 110);
            this.avatarPictureBox.TabIndex = 13;
            this.avatarPictureBox.TabStop = false;
            // 
            // messageButton
            // 
            this.messageButton.Image = global::WindowsFormsApplication3.Properties.Resources.rozmowa;
            this.messageButton.Location = new System.Drawing.Point(152, 94);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(71, 67);
            this.messageButton.TabIndex = 12;
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // callButton
            // 
            this.callButton.Image = global::WindowsFormsApplication3.Properties.Resources.tele;
            this.callButton.Location = new System.Drawing.Point(152, 12);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(71, 67);
            this.callButton.TabIndex = 11;
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Komunikator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 370);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ad1PictureBox);
            this.Controls.Add(this.avatarPictureBox);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.userProfile);
            this.Name = "Komunikator";
            this.Text = "Komunikator";
            this.Load += new System.EventHandler(this.Komunikator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userProfile;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.PictureBox ad1PictureBox;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

