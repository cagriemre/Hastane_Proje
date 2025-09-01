namespace Hastane_Proje
{
    partial class FormSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSekreterDetay));
            groupBox1 = new GroupBox();
            labelAdSoyad = new Label();
            label3 = new Label();
            labelTC = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonDuyurular = new Button();
            buttonDuyuruOlustur = new Button();
            richTextBoxDuyuru = new RichTextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxID = new TextBox();
            maskedTextBoxTarih = new MaskedTextBox();
            maskedTextBoxSaat = new MaskedTextBox();
            comboBoxBrans = new ComboBox();
            comboBoxDoktor = new ComboBox();
            maskedTextBoxTC = new MaskedTextBox();
            checkBoxMusait = new CheckBox();
            buttonKaydet = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox6 = new GroupBox();
            buttonRandevuList = new Button();
            buttonBransPaneli = new Button();
            buttonRandevuPanel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sekreter Bilgisi";
            // 
            // labelAdSoyad
            // 
            labelAdSoyad.AutoSize = true;
            labelAdSoyad.Location = new Point(152, 106);
            labelAdSoyad.Name = "labelAdSoyad";
            labelAdSoyad.Size = new Size(97, 29);
            labelAdSoyad.TabIndex = 8;
            labelAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 106);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 7;
            label3.Text = "Ad Soyad:";
            // 
            // labelTC
            // 
            labelTC.AutoSize = true;
            labelTC.Location = new Point(151, 55);
            labelTC.Name = "labelTC";
            labelTC.Size = new Size(156, 29);
            labelTC.TabIndex = 6;
            labelTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 55);
            label1.Name = "label1";
            label1.Size = new Size(76, 29);
            label1.TabIndex = 5;
            label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonDuyurular);
            groupBox2.Controls.Add(buttonDuyuruOlustur);
            groupBox2.Controls.Add(richTextBoxDuyuru);
            groupBox2.Location = new Point(15, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 303);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Paneli";
            // 
            // buttonDuyurular
            // 
            buttonDuyurular.Location = new Point(6, 239);
            buttonDuyurular.Name = "buttonDuyurular";
            buttonDuyurular.Size = new Size(155, 49);
            buttonDuyurular.TabIndex = 2;
            buttonDuyurular.Text = "Duyurular";
            buttonDuyurular.UseVisualStyleBackColor = true;
            buttonDuyurular.Click += buttonDuyurular_Click;
            // 
            // buttonDuyuruOlustur
            // 
            buttonDuyuruOlustur.Location = new Point(182, 239);
            buttonDuyuruOlustur.Name = "buttonDuyuruOlustur";
            buttonDuyuruOlustur.Size = new Size(155, 49);
            buttonDuyuruOlustur.TabIndex = 1;
            buttonDuyuruOlustur.Text = "Oluştur";
            buttonDuyuruOlustur.UseVisualStyleBackColor = true;
            buttonDuyuruOlustur.Click += buttonDuyuruOlustur_Click;
            // 
            // richTextBoxDuyuru
            // 
            richTextBoxDuyuru.Location = new Point(6, 33);
            richTextBoxDuyuru.Name = "richTextBoxDuyuru";
            richTextBoxDuyuru.Size = new Size(331, 200);
            richTextBoxDuyuru.TabIndex = 0;
            richTextBoxDuyuru.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 55);
            label2.Name = "label2";
            label2.Size = new Size(40, 29);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 106);
            label4.Name = "label4";
            label4.Size = new Size(68, 29);
            label4.TabIndex = 1;
            label4.Text = "Tarih:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 157);
            label5.Name = "label5";
            label5.Size = new Size(63, 29);
            label5.TabIndex = 2;
            label5.Text = "Saat:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 208);
            label6.Name = "label6";
            label6.Size = new Size(75, 29);
            label6.TabIndex = 3;
            label6.Text = "Branş:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 259);
            label7.Name = "label7";
            label7.Size = new Size(85, 29);
            label7.TabIndex = 4;
            label7.Text = "Doktor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 361);
            label8.Name = "label8";
            label8.Size = new Size(86, 29);
            label8.TabIndex = 5;
            label8.Text = "Durum:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 310);
            label9.Name = "label9";
            label9.Size = new Size(105, 29);
            label9.TabIndex = 6;
            label9.Text = "Hasta TC:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(127, 52);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(174, 34);
            textBoxID.TabIndex = 3;
            // 
            // maskedTextBoxTarih
            // 
            maskedTextBoxTarih.Location = new Point(127, 103);
            maskedTextBoxTarih.Mask = "00/00/0000";
            maskedTextBoxTarih.Name = "maskedTextBoxTarih";
            maskedTextBoxTarih.Size = new Size(174, 34);
            maskedTextBoxTarih.TabIndex = 8;
            maskedTextBoxTarih.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxSaat
            // 
            maskedTextBoxSaat.Location = new Point(127, 154);
            maskedTextBoxSaat.Mask = "00:00";
            maskedTextBoxSaat.Name = "maskedTextBoxSaat";
            maskedTextBoxSaat.Size = new Size(174, 34);
            maskedTextBoxSaat.TabIndex = 3;
            maskedTextBoxSaat.ValidatingType = typeof(DateTime);
            // 
            // comboBoxBrans
            // 
            comboBoxBrans.FormattingEnabled = true;
            comboBoxBrans.Location = new Point(127, 205);
            comboBoxBrans.Name = "comboBoxBrans";
            comboBoxBrans.Size = new Size(174, 37);
            comboBoxBrans.TabIndex = 9;
            comboBoxBrans.SelectedIndexChanged += comboBoxBrans_SelectedIndexChanged;
            // 
            // comboBoxDoktor
            // 
            comboBoxDoktor.FormattingEnabled = true;
            comboBoxDoktor.Location = new Point(127, 256);
            comboBoxDoktor.Name = "comboBoxDoktor";
            comboBoxDoktor.Size = new Size(174, 37);
            comboBoxDoktor.TabIndex = 10;
            // 
            // maskedTextBoxTC
            // 
            maskedTextBoxTC.Location = new Point(127, 305);
            maskedTextBoxTC.Mask = "00000000000";
            maskedTextBoxTC.Name = "maskedTextBoxTC";
            maskedTextBoxTC.Size = new Size(174, 34);
            maskedTextBoxTC.TabIndex = 11;
            // 
            // checkBoxMusait
            // 
            checkBoxMusait.AutoSize = true;
            checkBoxMusait.Location = new Point(127, 360);
            checkBoxMusait.Name = "checkBoxMusait";
            checkBoxMusait.Size = new Size(100, 33);
            checkBoxMusait.TabIndex = 12;
            checkBoxMusait.Text = "Müsait";
            checkBoxMusait.UseVisualStyleBackColor = true;
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(62, 412);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(203, 65);
            buttonKaydet.TabIndex = 13;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonKaydet);
            groupBox3.Controls.Add(checkBoxMusait);
            groupBox3.Controls.Add(maskedTextBoxTC);
            groupBox3.Controls.Add(comboBoxDoktor);
            groupBox3.Controls.Add(comboBoxBrans);
            groupBox3.Controls.Add(maskedTextBoxSaat);
            groupBox3.Controls.Add(maskedTextBoxTarih);
            groupBox3.Controls.Add(textBoxID);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(376, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(326, 517);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Paneli";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(722, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(497, 314);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(491, 281);
            dataGridView1.TabIndex = 17;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Location = new Point(722, 324);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(497, 353);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(491, 320);
            dataGridView2.TabIndex = 18;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(buttonRandevuList);
            groupBox6.Controls.Add(buttonBransPaneli);
            groupBox6.Controls.Add(buttonRandevuPanel);
            groupBox6.Location = new Point(15, 527);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(687, 150);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "Hızlı Erişim";
            // 
            // buttonRandevuList
            // 
            buttonRandevuList.Location = new Point(469, 50);
            buttonRandevuList.Name = "buttonRandevuList";
            buttonRandevuList.Size = new Size(206, 64);
            buttonRandevuList.TabIndex = 20;
            buttonRandevuList.Text = "Randevu Listesi";
            buttonRandevuList.UseVisualStyleBackColor = true;
            buttonRandevuList.Click += buttonRandevuList_Click;
            // 
            // buttonBransPaneli
            // 
            buttonBransPaneli.Location = new Point(240, 50);
            buttonBransPaneli.Name = "buttonBransPaneli";
            buttonBransPaneli.Size = new Size(206, 64);
            buttonBransPaneli.TabIndex = 19;
            buttonBransPaneli.Text = "Branş Paneli";
            buttonBransPaneli.UseVisualStyleBackColor = true;
            buttonBransPaneli.Click += buttonBransPaneli_Click;
            // 
            // buttonRandevuPanel
            // 
            buttonRandevuPanel.Location = new Point(11, 50);
            buttonRandevuPanel.Name = "buttonRandevuPanel";
            buttonRandevuPanel.Size = new Size(206, 64);
            buttonRandevuPanel.TabIndex = 18;
            buttonRandevuPanel.Text = "Doktor Paneli";
            buttonRandevuPanel.UseVisualStyleBackColor = true;
            buttonRandevuPanel.Click += buttonRandevuPanel_Click;
            // 
            // FormSekreterDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1231, 689);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormSekreterDetay";
            Text = "Sekreter Detay";
            Load += FormSekreterDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelAdSoyad;
        private Label label3;
        private Label labelTC;
        private Label label1;
        private GroupBox groupBox2;
        private Button buttonDuyuruOlustur;
        private RichTextBox richTextBoxDuyuru;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxID;
        private MaskedTextBox maskedTextBoxTarih;
        private MaskedTextBox maskedTextBoxSaat;
        private ComboBox comboBoxBrans;
        private ComboBox comboBoxDoktor;
        private MaskedTextBox maskedTextBoxTC;
        private CheckBox checkBoxMusait;
        private Button buttonKaydet;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        private Button buttonRandevuList;
        private Button buttonBransPaneli;
        private Button buttonRandevuPanel;
        private Button buttonDuyurular;
    }
}