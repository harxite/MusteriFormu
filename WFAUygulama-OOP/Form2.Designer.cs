namespace WFAUygulama_OOP
{
    partial class Form2
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
            label1 = new Label();
            txtAdSoyad = new TextBox();
            label2 = new Label();
            txtTelefon = new TextBox();
            label3 = new Label();
            nudYas = new NumericUpDown();
            label4 = new Label();
            txtAdres = new TextBox();
            btnKaydet = new Button();
            btnListeyeDon = new Button();
            ((System.ComponentModel.ISupportInitialize)nudYas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 69);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(226, 62);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(298, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 135);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(226, 128);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(298, 27);
            txtTelefon.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 217);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 0;
            label3.Text = "Yas";
            // 
            // nudYas
            // 
            nudYas.Location = new Point(226, 210);
            nudYas.Name = "nudYas";
            nudYas.Size = new Size(298, 27);
            nudYas.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 297);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 0;
            label4.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(226, 297);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(298, 157);
            txtAdres.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(226, 480);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(298, 46);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnListeyeDon
            // 
            btnListeyeDon.Location = new Point(226, 532);
            btnListeyeDon.Name = "btnListeyeDon";
            btnListeyeDon.Size = new Size(298, 46);
            btnListeyeDon.TabIndex = 4;
            btnListeyeDon.Text = "Listeye Don";
            btnListeyeDon.UseVisualStyleBackColor = true;
            btnListeyeDon.Click += btnListeyeDon_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 608);
            Controls.Add(btnListeyeDon);
            Controls.Add(btnKaydet);
            Controls.Add(txtAdres);
            Controls.Add(nudYas);
            Controls.Add(txtTelefon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAdSoyad);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)nudYas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdSoyad;
        private Label label2;
        private TextBox txtTelefon;
        private Label label3;
        private NumericUpDown nudYas;
        private Label label4;
        private TextBox txtAdres;
        private Button btnKaydet;
        private Button btnListeyeDon;
    }
}