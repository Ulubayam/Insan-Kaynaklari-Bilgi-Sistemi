namespace VERİODEV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnSirket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(197, 238);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(140, 63);
            this.btnPersonel.TabIndex = 1;
            this.btnPersonel.Text = "PERSONEL";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnSirket
            // 
            this.btnSirket.Location = new System.Drawing.Point(376, 238);
            this.btnSirket.Name = "btnSirket";
            this.btnSirket.Size = new System.Drawing.Size(137, 63);
            this.btnSirket.TabIndex = 2;
            this.btnSirket.Text = "ŞİRKET";
            this.btnSirket.UseVisualStyleBackColor = true;
            this.btnSirket.Click += new System.EventHandler(this.btnSirket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(721, 430);
            this.Controls.Add(this.btnSirket);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "İnsan Kaynakları Bilgi Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnSirket;
        public static IkiliAramaAgaci ikili = new IkiliAramaAgaci();//Kişi Bilgileri
        public static HashMapIsyeri hashIsyeri = new HashMapIsyeri();//işyeri bilgileri tutuluyor
        public static HashMapIlan ilan = new HashMapIlan();//ilan no ve başvuran kişiler atılıyor
       public static Heap iseBasvuranKisiler = new Heap(10);
         
        
    }
}

