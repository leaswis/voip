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
            this.voipButton = new System.Windows.Forms.Button();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // myProfileButton
            // 
            this.myProfileButton.BackColor = System.Drawing.Color.White;
            this.myProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myProfileButton.FlatAppearance.BorderSize = 0;
            this.myProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.myProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.myProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.myProfileButton.Location = new System.Drawing.Point(28, 168);
            this.myProfileButton.Name = "myProfileButton";
            this.myProfileButton.Size = new System.Drawing.Size(103, 27);
            this.myProfileButton.TabIndex = 1;
            this.myProfileButton.Text = "Mój profil";
            this.myProfileButton.UseVisualStyleBackColor = false;
            this.myProfileButton.Click += new System.EventHandler(this.myProfileButton_Click);
            // 
            // voipButton
            // 
            this.voipButton.BackgroundImage = global::Komunikator.Properties.Resources.tele;
            this.voipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voipButton.FlatAppearance.BorderSize = 0;
            this.voipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.voipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.voipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voipButton.Location = new System.Drawing.Point(183, 74);
            this.voipButton.Name = "voipButton";
            this.voipButton.Size = new System.Drawing.Size(67, 64);
            this.voipButton.TabIndex = 2;
            this.voipButton.UseVisualStyleBackColor = true;
            this.voipButton.Click += new System.EventHandler(this.voipButton_Click);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Image = global::Komunikator.Properties.Resources.avek1;
            this.avatarPictureBox.Location = new System.Drawing.Point(25, 49);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(109, 102);
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(25, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 170);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHello.Location = new System.Drawing.Point(17, 11);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(0, 20);
            this.labelHello.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(288, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 177);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dodaj kontakt";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(161, 214);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 19);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Komunikator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(582, 429);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.voipButton);
            this.Controls.Add(this.myProfileButton);
            this.Controls.Add(this.avatarPictureBox);
            this.Name = "Komunikator";
            this.Text = "Komunikator";
            this.Load += new System.EventHandler(this.Komunikator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Button voipButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
    }
}