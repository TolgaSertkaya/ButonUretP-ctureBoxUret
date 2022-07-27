
namespace ButonUretPıctureBoxUret
{
    partial class Form1
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
            this.btnUret = new System.Windows.Forms.Button();
            this.btnAtAt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(62, 366);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(108, 60);
            this.btnUret.TabIndex = 0;
            this.btnUret.Text = "Buton Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // btnAtAt
            // 
            this.btnAtAt.Location = new System.Drawing.Point(211, 366);
            this.btnAtAt.Name = "btnAtAt";
            this.btnAtAt.Size = new System.Drawing.Size(101, 60);
            this.btnAtAt.TabIndex = 1;
            this.btnAtAt.Text = "AT AT";
            this.btnAtAt.UseVisualStyleBackColor = true;
            this.btnAtAt.Click += new System.EventHandler(this.btnAtAt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ButonUretPıctureBoxUret.Properties.Resources.horse2;
            this.pictureBox1.Location = new System.Drawing.Point(364, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAtAt);
            this.Controls.Add(this.btnUret);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Button btnAtAt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

