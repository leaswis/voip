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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.userProfile = new System.Windows.Forms.Button();
            this.userArchive = new System.Windows.Forms.Button();
            this.userSettings = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.callButton = new System.Windows.Forms.Button();
            this.reklamaBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reklamaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 298);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(527, 96);
            this.textBox2.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.White;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendButton.Location = new System.Drawing.Point(648, 400);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(96, 28);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Wyślij";
            this.sendButton.UseVisualStyleBackColor = false;
            // 
            // userProfile
            // 
            this.userProfile.BackColor = System.Drawing.Color.White;
            this.userProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userProfile.Location = new System.Drawing.Point(12, 12);
            this.userProfile.Name = "userProfile";
            this.userProfile.Size = new System.Drawing.Size(107, 28);
            this.userProfile.TabIndex = 7;
            this.userProfile.Text = "Profil";
            this.userProfile.UseVisualStyleBackColor = false;
            this.userProfile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userArchive
            // 
            this.userArchive.BackColor = System.Drawing.Color.White;
            this.userArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userArchive.Location = new System.Drawing.Point(12, 46);
            this.userArchive.Name = "userArchive";
            this.userArchive.Size = new System.Drawing.Size(107, 28);
            this.userArchive.TabIndex = 8;
            this.userArchive.Text = "Archiwum";
            this.userArchive.UseVisualStyleBackColor = false;
            this.userArchive.Click += new System.EventHandler(this.userArchive_Click);
            // 
            // userSettings
            // 
            this.userSettings.BackColor = System.Drawing.Color.White;
            this.userSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userSettings.Location = new System.Drawing.Point(12, 80);
            this.userSettings.Name = "userSettings";
            this.userSettings.Size = new System.Drawing.Size(107, 28);
            this.userSettings.TabIndex = 9;
            this.userSettings.Text = "Ustawienia";
            this.userSettings.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(524, 158);
            this.textBox1.TabIndex = 10;
            // 
            // callButton
            // 
            this.callButton.Image = global::WindowsFormsApplication3.Properties.Resources.phone;
            this.callButton.Location = new System.Drawing.Point(129, 29);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(71, 67);
            this.callButton.TabIndex = 11;
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // reklamaBox
            // 
            this.reklamaBox.BackColor = System.Drawing.Color.Red;
            this.reklamaBox.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.baner1;
            this.reklamaBox.Location = new System.Drawing.Point(217, 1);
            this.reklamaBox.Name = "reklamaBox";
            this.reklamaBox.Size = new System.Drawing.Size(527, 107);
            this.reklamaBox.TabIndex = 0;
            this.reklamaBox.TabStop = false;
            // 
            // Komunikator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(755, 457);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userSettings);
            this.Controls.Add(this.userArchive);
            this.Controls.Add(this.userProfile);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.reklamaBox);
            this.Name = "Komunikator";
            this.Text = "Komunikator";
            this.Load += new System.EventHandler(this.Komunikator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reklamaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox reklamaBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button userProfile;
        private System.Windows.Forms.Button userArchive;
        private System.Windows.Forms.Button userSettings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button callButton;
    }
}

