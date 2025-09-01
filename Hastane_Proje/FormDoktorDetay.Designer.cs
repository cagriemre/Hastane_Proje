namespace Hastane_Proje
{
    partial class FormDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorDetay));
            groupBox1 = new GroupBox();
            labelAdSoyad = new Label();
            label3 = new Label();
            labelTC = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            richTextBoxSikayet = new RichTextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            buttonCikis = new Button();
            buttonDuyurular = new Button();
            buttonGuncelle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgi";
            // 
            // labelAdSoyad
            // 
            labelAdSoyad.AutoSize = true;
            labelAdSoyad.Location = new Point(132, 91);
            labelAdSoyad.Name = "labelAdSoyad";
            labelAdSoyad.Size = new Size(97, 29);
            labelAdSoyad.TabIndex = 4;
            labelAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 91);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 3;
            label3.Text = "Ad Soyad:";
            // 
            // labelTC
            // 
            labelTC.AutoSize = true;
            labelTC.Location = new Point(131, 40);
            labelTC.Name = "labelTC";
            labelTC.Size = new Size(156, 29);
            labelTC.TabIndex = 2;
            labelTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 40);
            label1.Name = "label1";
            label1.Size = new Size(76, 29);
            label1.TabIndex = 1;
            label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxSikayet);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(14, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 277);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detay";
            // 
            // richTextBoxSikayet
            // 
            richTextBoxSikayet.Location = new Point(92, 51);
            richTextBoxSikayet.Name = "richTextBoxSikayet";
            richTextBoxSikayet.Size = new Size(295, 170);
            richTextBoxSikayet.TabIndex = 1;
            richTextBoxSikayet.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 51);
            label5.Name = "label5";
            label5.Size = new Size(91, 29);
            label5.TabIndex = 0;
            label5.Text = "Şikayet:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(414, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(767, 628);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(761, 595);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonCikis);
            groupBox4.Controls.Add(buttonDuyurular);
            groupBox4.Controls.Add(buttonGuncelle);
            groupBox4.Location = new Point(14, 445);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(394, 187);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hızlı Erişim";
            // 
            // buttonCikis
            // 
            buttonCikis.Location = new Point(7, 106);
            buttonCikis.Name = "buttonCikis";
            buttonCikis.Size = new Size(380, 52);
            buttonCikis.TabIndex = 3;
            buttonCikis.Text = "Çıkış";
            buttonCikis.UseVisualStyleBackColor = true;
            buttonCikis.Click += buttonCikis_Click;
            // 
            // buttonDuyurular
            // 
            buttonDuyurular.Location = new Point(204, 42);
            buttonDuyurular.Name = "buttonDuyurular";
            buttonDuyurular.Size = new Size(184, 52);
            buttonDuyurular.TabIndex = 1;
            buttonDuyurular.Text = "Duyurular";
            buttonDuyurular.UseVisualStyleBackColor = true;
            buttonDuyurular.Click += buttonDuyurular_Click;
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.Location = new Point(7, 42);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(183, 52);
            buttonGuncelle.TabIndex = 0;
            buttonGuncelle.Text = "Güncelle";
            buttonGuncelle.UseVisualStyleBackColor = true;
            buttonGuncelle.Click += buttonGuncelle_Click;
            // 
            // FormDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1193, 644);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormDoktorDetay";
            Text = "Doktor Detay";
            Load += FormDoktorDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelTC;
        private Label label1;
        private Label labelAdSoyad;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private RichTextBox richTextBoxSikayet;
        private Label label5;
        private GroupBox groupBox4;
        private Button buttonCikis;
        private Button buttonDuyurular;
        private Button buttonGuncelle;
    }
}