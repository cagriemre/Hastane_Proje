namespace Hastane_Proje
{
    partial class FormHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaDetay));
            groupBox1 = new GroupBox();
            labelAdSoyad = new Label();
            label3 = new Label();
            labelTC = new Label();
            label1 = new Label();
            comboBoxBrans = new ComboBox();
            richTextBoxSikayet = new RichTextBox();
            label5 = new Label();
            buttonRandevuAl = new Button();
            groupBox2 = new GroupBox();
            textBoxID = new TextBox();
            label2 = new Label();
            linkLabelBilgiDuzenle = new LinkLabel();
            label7 = new Label();
            label6 = new Label();
            comboBoxDoktor = new ComboBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgisi";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // labelAdSoyad
            // 
            labelAdSoyad.AutoSize = true;
            labelAdSoyad.Location = new Point(139, 88);
            labelAdSoyad.Name = "labelAdSoyad";
            labelAdSoyad.Size = new Size(97, 29);
            labelAdSoyad.TabIndex = 1;
            labelAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 88);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 1;
            label3.Text = "Ad Soyad:";
            // 
            // labelTC
            // 
            labelTC.AutoSize = true;
            labelTC.Location = new Point(94, 42);
            labelTC.Name = "labelTC";
            labelTC.Size = new Size(156, 29);
            labelTC.TabIndex = 1;
            labelTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 42);
            label1.Name = "label1";
            label1.Size = new Size(76, 29);
            label1.TabIndex = 1;
            label1.Text = "TC No:";
            // 
            // comboBoxBrans
            // 
            comboBoxBrans.FormattingEnabled = true;
            comboBoxBrans.Location = new Point(104, 102);
            comboBoxBrans.Name = "comboBoxBrans";
            comboBoxBrans.Size = new Size(199, 37);
            comboBoxBrans.TabIndex = 1;
            comboBoxBrans.SelectedIndexChanged += comboBoxBrans_SelectedIndexChanged;
            // 
            // richTextBoxSikayet
            // 
            richTextBoxSikayet.Location = new Point(104, 228);
            richTextBoxSikayet.Name = "richTextBoxSikayet";
            richTextBoxSikayet.Size = new Size(199, 133);
            richTextBoxSikayet.TabIndex = 2;
            richTextBoxSikayet.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 105);
            label5.Name = "label5";
            label5.Size = new Size(75, 29);
            label5.TabIndex = 3;
            label5.Text = "Branş:";
            // 
            // buttonRandevuAl
            // 
            buttonRandevuAl.Location = new Point(122, 380);
            buttonRandevuAl.Name = "buttonRandevuAl";
            buttonRandevuAl.Size = new Size(164, 44);
            buttonRandevuAl.TabIndex = 4;
            buttonRandevuAl.Text = "Randevu Al";
            buttonRandevuAl.UseVisualStyleBackColor = true;
            buttonRandevuAl.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxID);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(linkLabelBilgiDuzenle);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(buttonRandevuAl);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBoxDoktor);
            groupBox2.Controls.Add(richTextBoxSikayet);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBoxBrans);
            groupBox2.Location = new Point(16, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 484);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Sistemi";
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Location = new Point(104, 39);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(199, 34);
            textBoxID.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 42);
            label2.Name = "label2";
            label2.Size = new Size(40, 29);
            label2.TabIndex = 8;
            label2.Text = "ID:";
            // 
            // linkLabelBilgiDuzenle
            // 
            linkLabelBilgiDuzenle.AutoSize = true;
            linkLabelBilgiDuzenle.Location = new Point(6, 437);
            linkLabelBilgiDuzenle.Name = "linkLabelBilgiDuzenle";
            linkLabelBilgiDuzenle.Size = new Size(174, 29);
            linkLabelBilgiDuzenle.TabIndex = 7;
            linkLabelBilgiDuzenle.TabStop = true;
            linkLabelBilgiDuzenle.Text = "Bilgileri Düzenle";
            linkLabelBilgiDuzenle.LinkClicked += linkLabelBilgiDuzenle_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 231);
            label7.Name = "label7";
            label7.Size = new Size(91, 29);
            label7.TabIndex = 6;
            label7.Text = "Şikayet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 168);
            label6.Name = "label6";
            label6.Size = new Size(85, 29);
            label6.TabIndex = 5;
            label6.Text = "Doktor:";
            // 
            // comboBoxDoktor
            // 
            comboBoxDoktor.FormattingEnabled = true;
            comboBoxDoktor.Location = new Point(104, 165);
            comboBoxDoktor.Name = "comboBoxDoktor";
            comboBoxDoktor.Size = new Size(199, 37);
            comboBoxDoktor.TabIndex = 4;
            comboBoxDoktor.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(387, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(799, 329);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Geçmişi";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(793, 296);
            dataGridView1.TabIndex = 8;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(387, 338);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(799, 347);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(793, 314);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // FormHastaDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1198, 725);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormHastaDetay";
            Text = "Hasta Detay";
            Load += FormHastaDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelTC;
        private Label label1;
        private Label label3;
        private Label labelAdSoyad;
        private ComboBox comboBoxBrans;
        private RichTextBox richTextBoxSikayet;
        private Label label5;
        private Button buttonRandevuAl;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private ComboBox comboBoxDoktor;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private LinkLabel linkLabelBilgiDuzenle;
        private TextBox textBoxID;
        private Label label2;
    }
}