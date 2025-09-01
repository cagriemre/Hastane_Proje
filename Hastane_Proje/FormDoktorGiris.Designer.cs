namespace Hastane_Proje
{
    partial class FormDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorGiris));
            buttonGiris = new Button();
            textBoxSifre = new TextBox();
            maskedTextBoxTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(250, 239);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(133, 49);
            buttonGiris.TabIndex = 12;
            buttonGiris.Text = "Giriş Yap";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(212, 184);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(171, 34);
            textBoxSifre.TabIndex = 11;
            textBoxSifre.Text = "1234";
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // maskedTextBoxTC
            // 
            maskedTextBoxTC.Location = new Point(212, 126);
            maskedTextBoxTC.Mask = "00000000000";
            maskedTextBoxTC.Name = "maskedTextBoxTC";
            maskedTextBoxTC.Size = new Size(171, 34);
            maskedTextBoxTC.TabIndex = 10;
            maskedTextBoxTC.Text = "12345678910";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 187);
            label3.Name = "label3";
            label3.Size = new Size(65, 29);
            label3.TabIndex = 9;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 129);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 8;
            label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(52, 43);
            label1.Name = "label1";
            label1.Size = new Size(421, 54);
            label1.TabIndex = 7;
            label1.Text = "Doktor Giriş Paneli";
            // 
            // FormDoktorGiris
            // 
            AcceptButton = buttonGiris;
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(607, 371);
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
            Name = "FormDoktorGiris";
            Text = "Doktor Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonGiris;
        private TextBox textBoxSifre;
        private MaskedTextBox maskedTextBoxTC;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}