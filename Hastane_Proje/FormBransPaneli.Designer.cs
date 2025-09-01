namespace Hastane_Proje
{
    partial class FormBransPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBransPaneli));
            buttonGuncelle = new Button();
            buttonSil = new Button();
            buttonEkle = new Button();
            dataGridView1 = new DataGridView();
            textBoxBransAd = new TextBox();
            textBoxBransID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.Location = new Point(130, 212);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(194, 50);
            buttonGuncelle.TabIndex = 27;
            buttonGuncelle.Text = "Güncelle";
            buttonGuncelle.UseVisualStyleBackColor = true;
            buttonGuncelle.Click += buttonGuncelle_Click;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(230, 156);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(94, 50);
            buttonSil.TabIndex = 26;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new Point(130, 156);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(94, 50);
            buttonEkle.TabIndex = 25;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(353, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(377, 220);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBoxBransAd
            // 
            textBoxBransAd.Location = new Point(130, 98);
            textBoxBransAd.Name = "textBoxBransAd";
            textBoxBransAd.Size = new Size(194, 34);
            textBoxBransAd.TabIndex = 20;
            // 
            // textBoxBransID
            // 
            textBoxBransID.Location = new Point(130, 42);
            textBoxBransID.Name = "textBoxBransID";
            textBoxBransID.Size = new Size(194, 34);
            textBoxBransID.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(113, 29);
            label2.TabIndex = 15;
            label2.Text = "Branş Adı:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 45);
            label1.Name = "label1";
            label1.Size = new Size(102, 29);
            label1.TabIndex = 14;
            label1.Text = "Branş ID:";
            // 
            // FormBransPaneli
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(763, 323);
            Controls.Add(buttonGuncelle);
            Controls.Add(buttonSil);
            Controls.Add(buttonEkle);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxBransAd);
            Controls.Add(textBoxBransID);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormBransPaneli";
            Text = "Branş Paneli";
            Load += FormBransPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGuncelle;
        private Button buttonSil;
        private Button buttonEkle;
        private DataGridView dataGridView1;
        private TextBox textBoxBransAd;
        private TextBox textBoxBransID;
        private Label label2;
        private Label label1;
    }
}