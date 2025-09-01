namespace Hastane_Proje
{
    partial class FormBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBilgiDuzenle));
            buttonGuncelle = new Button();
            label6 = new Label();
            comboBoxCinsiyet = new ComboBox();
            maskedTextBoxtelno = new MaskedTextBox();
            label5 = new Label();
            textBoxSoyad = new TextBox();
            label4 = new Label();
            textBoxAd = new TextBox();
            label1 = new Label();
            textBoxSifre = new TextBox();
            maskedTextBoxTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.BackColor = Color.MintCream;
            buttonGuncelle.Location = new Point(184, 336);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(171, 61);
            buttonGuncelle.TabIndex = 7;
            buttonGuncelle.Text = "Güncelle";
            buttonGuncelle.UseVisualStyleBackColor = false;
            buttonGuncelle.Click += buttonGuncelle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 274);
            label6.Name = "label6";
            label6.Size = new Size(89, 29);
            label6.TabIndex = 29;
            label6.Text = "Cinsiyet";
            // 
            // comboBoxCinsiyet
            // 
            comboBoxCinsiyet.FormattingEnabled = true;
            comboBoxCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBoxCinsiyet.Location = new Point(184, 271);
            comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            comboBoxCinsiyet.Size = new Size(171, 37);
            comboBoxCinsiyet.TabIndex = 6;
            // 
            // maskedTextBoxtelno
            // 
            maskedTextBoxtelno.Location = new Point(184, 178);
            maskedTextBoxtelno.Mask = "(999) 000-0000";
            maskedTextBoxtelno.Name = "maskedTextBoxtelno";
            maskedTextBoxtelno.Size = new Size(171, 34);
            maskedTextBoxtelno.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 181);
            label5.Name = "label5";
            label5.Size = new Size(81, 29);
            label5.TabIndex = 26;
            label5.Text = "Tel No:";
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(184, 83);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(171, 34);
            textBoxSoyad.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 86);
            label4.Name = "label4";
            label4.Size = new Size(78, 29);
            label4.TabIndex = 24;
            label4.Text = "Soyad:";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(184, 37);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(171, 34);
            textBoxAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 40);
            label1.Name = "label1";
            label1.Size = new Size(45, 29);
            label1.TabIndex = 22;
            label1.Text = "Ad:";
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(184, 224);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(171, 34);
            textBoxSifre.TabIndex = 5;
            // 
            // maskedTextBoxTC
            // 
            maskedTextBoxTC.Location = new Point(184, 131);
            maskedTextBoxTC.Mask = "00000000000";
            maskedTextBoxTC.Name = "maskedTextBoxTC";
            maskedTextBoxTC.Size = new Size(171, 34);
            maskedTextBoxTC.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 227);
            label3.Name = "label3";
            label3.Size = new Size(65, 29);
            label3.TabIndex = 19;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 134);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 18;
            label2.Text = "TC Kimlik No:";
            // 
            // FormBilgiDuzenle
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(464, 448);
            Controls.Add(buttonGuncelle);
            Controls.Add(label6);
            Controls.Add(comboBoxCinsiyet);
            Controls.Add(maskedTextBoxtelno);
            Controls.Add(label5);
            Controls.Add(textBoxSoyad);
            Controls.Add(label4);
            Controls.Add(textBoxAd);
            Controls.Add(label1);
            Controls.Add(textBoxSifre);
            Controls.Add(maskedTextBoxTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormBilgiDuzenle";
            Text = "Bilgileri Düzenle";
            Load += FormBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGuncelle;
        private Label label6;
        private ComboBox comboBoxCinsiyet;
        private MaskedTextBox maskedTextBoxtelno;
        private Label label5;
        private TextBox textBoxSoyad;
        private Label label4;
        private TextBox textBoxAd;
        private Label label1;
        private TextBox textBoxSifre;
        private MaskedTextBox maskedTextBoxTC;
        private Label label3;
        private Label label2;
    }
}