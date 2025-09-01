namespace Hastane_Proje
{
    partial class FormDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorPaneli));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxAd = new TextBox();
            textBoxSoyad = new TextBox();
            comboBoxBrans = new ComboBox();
            maskedTextBoxTC = new MaskedTextBox();
            textBoxSifre = new TextBox();
            dataGridView1 = new DataGridView();
            buttonEkle = new Button();
            buttonSil = new Button();
            buttonGuncelle = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 45);
            label1.Name = "label1";
            label1.Size = new Size(45, 29);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 101);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 157);
            label3.Name = "label3";
            label3.Size = new Size(75, 29);
            label3.TabIndex = 2;
            label3.Text = "Branş:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 213);
            label4.Name = "label4";
            label4.Size = new Size(43, 29);
            label4.TabIndex = 3;
            label4.Text = "TC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 269);
            label5.Name = "label5";
            label5.Size = new Size(65, 29);
            label5.TabIndex = 4;
            label5.Text = "Şifre:";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(118, 42);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(191, 34);
            textBoxAd.TabIndex = 1;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(118, 98);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(191, 34);
            textBoxSoyad.TabIndex = 2;
            // 
            // comboBoxBrans
            // 
            comboBoxBrans.FormattingEnabled = true;
            comboBoxBrans.Location = new Point(118, 154);
            comboBoxBrans.Name = "comboBoxBrans";
            comboBoxBrans.Size = new Size(191, 37);
            comboBoxBrans.TabIndex = 3;
            comboBoxBrans.SelectedIndexChanged += comboBoxBrans_SelectedIndexChanged;
            // 
            // maskedTextBoxTC
            // 
            maskedTextBoxTC.Location = new Point(118, 210);
            maskedTextBoxTC.Mask = "00000000000";
            maskedTextBoxTC.Name = "maskedTextBoxTC";
            maskedTextBoxTC.Size = new Size(191, 34);
            maskedTextBoxTC.TabIndex = 4;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(118, 266);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(191, 34);
            textBoxSifre.TabIndex = 5;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(339, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(974, 383);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new Point(23, 317);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(133, 50);
            buttonEkle.TabIndex = 6;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(177, 373);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(132, 50);
            buttonSil.TabIndex = 7;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.Location = new Point(177, 317);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(132, 50);
            buttonGuncelle.TabIndex = 8;
            buttonGuncelle.Text = "Güncelle";
            buttonGuncelle.UseVisualStyleBackColor = true;
            buttonGuncelle.Click += buttonGuncelle_Click;
            // 
            // button1
            // 
            button1.Location = new Point(23, 373);
            button1.Name = "button1";
            button1.Size = new Size(133, 50);
            button1.TabIndex = 11;
            button1.Text = "Temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormDoktorPaneli
            // 
            AcceptButton = buttonEkle;
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1340, 459);
            Controls.Add(button1);
            Controls.Add(buttonGuncelle);
            Controls.Add(buttonSil);
            Controls.Add(buttonEkle);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxSifre);
            Controls.Add(maskedTextBoxTC);
            Controls.Add(comboBoxBrans);
            Controls.Add(textBoxSoyad);
            Controls.Add(textBoxAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormDoktorPaneli";
            Text = "Doktor Paneli";
            Load += FormDoktorPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxAd;
        private TextBox textBoxSoyad;
        private ComboBox comboBoxBrans;
        private MaskedTextBox maskedTextBoxTC;
        private TextBox textBoxSifre;
        private DataGridView dataGridView1;
        private Button buttonEkle;
        private Button buttonSil;
        private Button buttonGuncelle;
        private Button button1;
    }
}