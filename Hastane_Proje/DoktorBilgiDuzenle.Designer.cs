namespace Hastane_Proje
{
    partial class DoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorBilgiDuzenle));
            textBoxSoyad = new TextBox();
            label4 = new Label();
            textBoxAd = new TextBox();
            label1 = new Label();
            textBoxSifre = new TextBox();
            maskedTextBoxTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            labelBrans = new Label();
            comboBoxBrans = new ComboBox();
            buttonGuncelle = new Button();
            SuspendLayout();
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(189, 98);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(171, 34);
            textBoxSoyad.TabIndex = 33;
//            textBoxSoyad.TextChanged += this.textBoxSoyad_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 101);
            label4.Name = "label4";
            label4.Size = new Size(78, 29);
            label4.TabIndex = 32;
            label4.Text = "Soyad:";
//            label4.Click += this.label4_Click;
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(189, 52);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(171, 34);
            textBoxAd.TabIndex = 31;
   //         textBoxAd.TextChanged += this.textBoxAd_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 55);
            label1.Name = "label1";
            label1.Size = new Size(45, 29);
            label1.TabIndex = 30;
            label1.Text = "Ad:";
            label1.Click += this.label1_Click;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(189, 245);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(171, 34);
            textBoxSifre.TabIndex = 29;
            textBoxSifre.TextChanged += this.textBoxSifre_TextChanged;
            // 
            // maskedTextBoxTC
            // 
            maskedTextBoxTC.Location = new Point(189, 144);
            maskedTextBoxTC.Mask = "00000000000";
            maskedTextBoxTC.Name = "maskedTextBoxTC";
            maskedTextBoxTC.Size = new Size(171, 34);
            maskedTextBoxTC.TabIndex = 28;
       //     maskedTextBoxTC.MaskInputRejected += this.maskedTextBoxTC_MaskInputRejected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 248);
            label3.Name = "label3";
            label3.Size = new Size(65, 29);
            label3.TabIndex = 27;
            label3.Text = "Şifre:";
       //     label3.Click += this.label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 149);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 26;
            label2.Text = "TC Kimlik No:";
            label2.Click += label2_Click;
            // 
            // labelBrans
            // 
            labelBrans.AutoSize = true;
            labelBrans.Location = new Point(109, 197);
            labelBrans.Name = "labelBrans";
            labelBrans.Size = new Size(75, 29);
            labelBrans.TabIndex = 34;
            labelBrans.Text = "Branş:";
       //     labelBrans.Click += this.labelBrans_Click;
            // 
            // comboBoxBrans
            // 
            comboBoxBrans.FormattingEnabled = true;
            comboBoxBrans.Location = new Point(189, 194);
            comboBoxBrans.Name = "comboBoxBrans";
            comboBoxBrans.Size = new Size(171, 37);
            comboBoxBrans.TabIndex = 35;
      //      comboBoxBrans.SelectedIndexChanged += this.comboBoxBrans_SelectedIndexChanged;
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.Location = new Point(189, 304);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(171, 59);
            buttonGuncelle.TabIndex = 36;
            buttonGuncelle.Text = "Güncelle";
            buttonGuncelle.UseVisualStyleBackColor = true;
            buttonGuncelle.Click += buttonGuncelle_Click;
            // 
            // DoktorBilgiDuzenle
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(452, 422);
            Controls.Add(buttonGuncelle);
            Controls.Add(comboBoxBrans);
            Controls.Add(labelBrans);
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
            MaximizeBox = false;
            Name = "DoktorBilgiDuzenle";
            Text = "Doktor Bilgi Düzenle";
            Load += DoktorBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSoyad;
        private Label label4;
        private TextBox textBoxAd;
        private Label label1;
        private TextBox textBoxSifre;
        private MaskedTextBox maskedTextBoxTC;
        private Label label3;
        private Label label2;
        private Label labelBrans;
        private ComboBox comboBoxBrans;
        private Button buttonGuncelle;
    }
}