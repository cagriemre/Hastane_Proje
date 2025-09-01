namespace Hastane_Proje
{
    partial class FormHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaGiris));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            maskedTextBoxTC = new MaskedTextBox();
            textBoxSifre = new TextBox();
            buttonGiris = new Button();
            linkLabeluyeol = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(54, 34);
            label1.Name = "label1";
            label1.Size = new Size(399, 54);
            label1.TabIndex = 0;
            label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 122);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 1;
            label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 180);
            label3.Name = "label3";
            label3.Size = new Size(65, 29);
            label3.TabIndex = 2;
            label3.Text = "Şifre:";
            // 
            // maskedTextBoxTC
            // 
            maskedTextBoxTC.Location = new Point(213, 119);
            maskedTextBoxTC.Mask = "00000000000";
            maskedTextBoxTC.Name = "maskedTextBoxTC";
            maskedTextBoxTC.Size = new Size(171, 34);
            maskedTextBoxTC.TabIndex = 3;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(213, 177);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(171, 34);
            textBoxSifre.TabIndex = 4;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(251, 232);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(133, 49);
            buttonGiris.TabIndex = 5;
            buttonGiris.Text = "Giriş Yap";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // linkLabeluyeol
            // 
            linkLabeluyeol.AutoSize = true;
            linkLabeluyeol.Location = new Point(451, 180);
            linkLabeluyeol.Name = "linkLabeluyeol";
            linkLabeluyeol.Size = new Size(76, 29);
            linkLabeluyeol.TabIndex = 6;
            linkLabeluyeol.TabStop = true;
            linkLabeluyeol.Text = "Üye Ol";
            linkLabeluyeol.LinkClicked += linkLabeluyeol_LinkClicked;
            // 
            // FormHastaGiris
            // 
            AcceptButton = buttonGiris;
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(607, 371);
            Controls.Add(linkLabeluyeol);
            Controls.Add(buttonGiris);
            Controls.Add(textBoxSifre);
            Controls.Add(maskedTextBoxTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormHastaGiris";
            Text = "Hasta Girişi";
            Load += FormHastaGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBoxTC;
        private TextBox textBoxSifre;
        private Button buttonGiris;
        private LinkLabel linkLabeluyeol;
    }
}