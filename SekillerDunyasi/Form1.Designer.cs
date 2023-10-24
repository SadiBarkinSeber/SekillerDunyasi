namespace SekillerDunyasi
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
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudGenislik = new System.Windows.Forms.NumericUpDown();
            this.nudYukseklik = new System.Windows.Forms.NumericUpDown();
            this.cboTur = new System.Windows.Forms.ComboBox();
            this.btnRastgeleEkle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnMetinEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.lstSekiller = new System.Windows.Forms.ListBox();
            this.pnlCizim = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYukari = new System.Windows.Forms.Button();
            this.pboRenk = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenislik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYukseklik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).BeginInit();
            this.SuspendLayout();
            // 
            // nudX
            // 
            this.nudX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudX.Location = new System.Drawing.Point(12, 54);
            this.nudX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(52, 26);
            this.nudX.TabIndex = 0;
            // 
            // nudY
            // 
            this.nudY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudY.Location = new System.Drawing.Point(77, 54);
            this.nudY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(51, 26);
            this.nudY.TabIndex = 1;
            // 
            // nudGenislik
            // 
            this.nudGenislik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudGenislik.Location = new System.Drawing.Point(216, 54);
            this.nudGenislik.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGenislik.Name = "nudGenislik";
            this.nudGenislik.Size = new System.Drawing.Size(91, 26);
            this.nudGenislik.TabIndex = 3;
            this.nudGenislik.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudYukseklik
            // 
            this.nudYukseklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudYukseklik.Location = new System.Drawing.Point(313, 54);
            this.nudYukseklik.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudYukseklik.Name = "nudYukseklik";
            this.nudYukseklik.Size = new System.Drawing.Size(91, 26);
            this.nudYukseklik.TabIndex = 4;
            this.nudYukseklik.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cboTur
            // 
            this.cboTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboTur.FormattingEnabled = true;
            this.cboTur.Items.AddRange(new object[] {
            "Dikdörtgen",
            "Elips"});
            this.cboTur.Location = new System.Drawing.Point(419, 51);
            this.cboTur.Name = "cboTur";
            this.cboTur.Size = new System.Drawing.Size(117, 28);
            this.cboTur.TabIndex = 5;
            // 
            // btnRastgeleEkle
            // 
            this.btnRastgeleEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRastgeleEkle.Location = new System.Drawing.Point(553, 49);
            this.btnRastgeleEkle.Name = "btnRastgeleEkle";
            this.btnRastgeleEkle.Size = new System.Drawing.Size(41, 31);
            this.btnRastgeleEkle.TabIndex = 6;
            this.btnRastgeleEkle.Text = "?";
            this.btnRastgeleEkle.UseVisualStyleBackColor = true;
            this.btnRastgeleEkle.Click += new System.EventHandler(this.btnRastgeleEkle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(613, 49);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 29);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "ŞEKİL EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnMetinEkle
            // 
            this.btnMetinEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetinEkle.Location = new System.Drawing.Point(613, 96);
            this.btnMetinEkle.Name = "btnMetinEkle";
            this.btnMetinEkle.Size = new System.Drawing.Size(111, 26);
            this.btnMetinEkle.TabIndex = 8;
            this.btnMetinEkle.Text = "METİN EKLE";
            this.btnMetinEkle.UseVisualStyleBackColor = true;
            this.btnMetinEkle.Click += new System.EventHandler(this.btnMetinEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Metin :";
            // 
            // txtMetin
            // 
            this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMetin.Location = new System.Drawing.Point(75, 96);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(519, 26);
            this.txtMetin.TabIndex = 10;
            // 
            // lstSekiller
            // 
            this.lstSekiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSekiller.FormattingEnabled = true;
            this.lstSekiller.ItemHeight = 20;
            this.lstSekiller.Location = new System.Drawing.Point(12, 139);
            this.lstSekiller.Name = "lstSekiller";
            this.lstSekiller.Size = new System.Drawing.Size(676, 104);
            this.lstSekiller.TabIndex = 11;
            // 
            // pnlCizim
            // 
            this.pnlCizim.BackColor = System.Drawing.Color.White;
            this.pnlCizim.Location = new System.Drawing.Point(13, 253);
            this.pnlCizim.Name = "pnlCizim";
            this.pnlCizim.Size = new System.Drawing.Size(711, 476);
            this.pnlCizim.TabIndex = 15;
            this.pnlCizim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizim_Paint);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(17, 745);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(111, 27);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(152, 745);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 27);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(148, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Renk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(212, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Genişlik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(309, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Yükseklik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(415, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Şekil Türü";
            // 
            // btnAsagi
            // 
            this.btnAsagi.BackgroundImage = global::SekillerDunyasi.Properties.Resources.MicrosoftTeams_image;
            this.btnAsagi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAsagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAsagi.Location = new System.Drawing.Point(694, 213);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(30, 30);
            this.btnAsagi.TabIndex = 14;
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::SekillerDunyasi.Properties.Resources.pngtree_vector_cross_icon_png_image_960976;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(694, 176);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(30, 30);
            this.btnSil.TabIndex = 13;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYukari
            // 
            this.btnYukari.BackgroundImage = global::SekillerDunyasi.Properties.Resources.yukari;
            this.btnYukari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYukari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukari.Location = new System.Drawing.Point(694, 139);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(30, 30);
            this.btnYukari.TabIndex = 12;
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // pboRenk
            // 
            this.pboRenk.BackColor = System.Drawing.Color.Black;
            this.pboRenk.Location = new System.Drawing.Point(152, 54);
            this.pboRenk.Name = "pboRenk";
            this.pboRenk.Size = new System.Drawing.Size(25, 26);
            this.pboRenk.TabIndex = 2;
            this.pboRenk.TabStop = false;
            this.pboRenk.Click += new System.EventHandler(this.pboRenk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(752, 790);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.pnlCizim);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.lstSekiller);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMetinEkle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnRastgeleEkle);
            this.Controls.Add(this.cboTur);
            this.Controls.Add(this.nudYukseklik);
            this.Controls.Add(this.nudGenislik);
            this.Controls.Add(this.pboRenk);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenislik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYukseklik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.PictureBox pboRenk;
        private System.Windows.Forms.NumericUpDown nudGenislik;
        private System.Windows.Forms.NumericUpDown nudYukseklik;
        private System.Windows.Forms.ComboBox cboTur;
        private System.Windows.Forms.Button btnRastgeleEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnMetinEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.ListBox lstSekiller;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Panel pnlCizim;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

