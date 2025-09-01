namespace Hastane_Proje
{
    partial class FormGirisler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGirisler));
            buttonDoktorGirisi = new Button();
            buttonHastaGirisi = new Button();
            buttonSekreterGirisi = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonDoktorGirisi
            // 
            buttonDoktorGirisi.BackgroundImage = (Image)resources.GetObject("buttonDoktorGirisi.BackgroundImage");
            buttonDoktorGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDoktorGirisi.Location = new Point(12, 201);
            buttonDoktorGirisi.Name = "buttonDoktorGirisi";
            buttonDoktorGirisi.Size = new Size(223, 189);
            buttonDoktorGirisi.TabIndex = 0;
            buttonDoktorGirisi.UseVisualStyleBackColor = true;
            buttonDoktorGirisi.Click += buttonDoktorGirisi_Click;
            // 
            // buttonHastaGirisi
            // 
            buttonHastaGirisi.BackgroundImage = (Image)resources.GetObject("buttonHastaGirisi.BackgroundImage");
            buttonHastaGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            buttonHastaGirisi.Location = new Point(284, 201);
            buttonHastaGirisi.Name = "buttonHastaGirisi";
            buttonHastaGirisi.Size = new Size(223, 189);
            buttonHastaGirisi.TabIndex = 1;
            buttonHastaGirisi.UseVisualStyleBackColor = true;
            buttonHastaGirisi.Click += buttonHastaGirisi_Click;
            // 
            // buttonSekreterGirisi
            // 
            buttonSekreterGirisi.BackgroundImage = (Image)resources.GetObject("buttonSekreterGirisi.BackgroundImage");
            buttonSekreterGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSekreterGirisi.Location = new Point(554, 201);
            buttonSekreterGirisi.Name = "buttonSekreterGirisi";
            buttonSekreterGirisi.Size = new Size(223, 189);
            buttonSekreterGirisi.TabIndex = 2;
            buttonSekreterGirisi.UseVisualStyleBackColor = true;
            buttonSekreterGirisi.Click += buttonSekreterGirisi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(89, 402);
            label2.Name = "label2";
            label2.Size = new Size(79, 29);
            label2.TabIndex = 3;
            label2.Text = "Doktor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(360, 402);
            label3.Name = "label3";
            label3.Size = new Size(69, 29);
            label3.TabIndex = 4;
            label3.Text = "Hasta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(619, 402);
            label4.Name = "label4";
            label4.Size = new Size(97, 29);
            label4.TabIndex = 5;
            label4.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(463, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(39, 74);
            label1.Name = "label1";
            label1.Size = new Size(396, 54);
            label1.TabIndex = 7;
            label1.Text = "EMRE Hospital";
            label1.Click += label1_Click;
            // 
            // FormGirisler
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(789, 451);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonSekreterGirisi);
            Controls.Add(buttonHastaGirisi);
            Controls.Add(buttonDoktorGirisi);
            Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormGirisler";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDoktorGirisi;
        private Button buttonHastaGirisi;
        private Button buttonSekreterGirisi;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
