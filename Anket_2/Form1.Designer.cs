namespace Anket_2
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            button_elave = new Button();
            button_deyis = new Button();
            tb_birhday = new TextBox();
            label_doğum = new Label();
            label_tel = new Label();
            tb_tel = new TextBox();
            tb_email = new TextBox();
            label_email = new Label();
            tb_soyad = new TextBox();
            label_soyad = new Label();
            tb_ad = new TextBox();
            lable_ad = new Label();
            listBox1 = new ListBox();
            label_fayl = new Label();
            tb_filename = new TextBox();
            button_load = new Button();
            button_save = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_elave);
            groupBox1.Controls.Add(button_deyis);
            groupBox1.Controls.Add(tb_birhday);
            groupBox1.Controls.Add(label_doğum);
            groupBox1.Controls.Add(label_tel);
            groupBox1.Controls.Add(tb_tel);
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(label_email);
            groupBox1.Controls.Add(tb_soyad);
            groupBox1.Controls.Add(label_soyad);
            groupBox1.Controls.Add(tb_ad);
            groupBox1.Controls.Add(lable_ad);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // button_elave
            // 
            button_elave.Location = new Point(357, 381);
            button_elave.Name = "button_elave";
            button_elave.Size = new Size(114, 39);
            button_elave.TabIndex = 11;
            button_elave.Text = "Əlavə et";
            button_elave.UseVisualStyleBackColor = true;
            button_elave.Click += button_elave_Click;
            // 
            // button_deyis
            // 
            button_deyis.Location = new Point(357, 335);
            button_deyis.Name = "button_deyis";
            button_deyis.Size = new Size(114, 40);
            button_deyis.TabIndex = 10;
            button_deyis.Text = "Dəyiş";
            button_deyis.UseVisualStyleBackColor = true;
            button_deyis.Visible = false;
            button_deyis.Click += button_deyis_Click;
            // 
            // tb_birhday
            // 
            tb_birhday.Location = new Point(101, 290);
            tb_birhday.Name = "tb_birhday";
            tb_birhday.Size = new Size(270, 27);
            tb_birhday.TabIndex = 9;
            // 
            // label_doğum
            // 
            label_doğum.AutoSize = true;
            label_doğum.Location = new Point(6, 293);
            label_doğum.Name = "label_doğum";
            label_doğum.Size = new Size(59, 20);
            label_doğum.TabIndex = 8;
            label_doğum.Text = "Doğum";
            // 
            // label_tel
            // 
            label_tel.AutoSize = true;
            label_tel.Location = new Point(6, 227);
            label_tel.Name = "label_tel";
            label_tel.Size = new Size(28, 20);
            label_tel.TabIndex = 7;
            label_tel.Text = "Tel";
            // 
            // tb_tel
            // 
            tb_tel.Location = new Point(101, 227);
            tb_tel.Name = "tb_tel";
            tb_tel.Size = new Size(270, 27);
            tb_tel.TabIndex = 6;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(101, 163);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(270, 27);
            tb_email.TabIndex = 5;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(6, 166);
            label_email.Name = "label_email";
            label_email.Size = new Size(46, 20);
            label_email.TabIndex = 4;
            label_email.Text = "Email";
            // 
            // tb_soyad
            // 
            tb_soyad.Location = new Point(101, 101);
            tb_soyad.Name = "tb_soyad";
            tb_soyad.Size = new Size(270, 27);
            tb_soyad.TabIndex = 3;
            // 
            // label_soyad
            // 
            label_soyad.AutoSize = true;
            label_soyad.Location = new Point(6, 104);
            label_soyad.Name = "label_soyad";
            label_soyad.Size = new Size(50, 20);
            label_soyad.TabIndex = 2;
            label_soyad.Text = "Soyad";
            // 
            // tb_ad
            // 
            tb_ad.Location = new Point(101, 41);
            tb_ad.Name = "tb_ad";
            tb_ad.Size = new Size(270, 27);
            tb_ad.TabIndex = 1;
            // 
            // lable_ad
            // 
            lable_ad.AutoSize = true;
            lable_ad.Location = new Point(6, 44);
            lable_ad.Name = "lable_ad";
            lable_ad.Size = new Size(28, 20);
            lable_ad.TabIndex = 0;
            lable_ad.Text = "Ad";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(495, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(293, 324);
            listBox1.TabIndex = 1;
            // 
            // label_fayl
            // 
            label_fayl.AutoSize = true;
            label_fayl.Location = new Point(495, 357);
            label_fayl.Name = "label_fayl";
            label_fayl.Size = new Size(59, 20);
            label_fayl.TabIndex = 2;
            label_fayl.Text = "Fayl adı";
            // 
            // tb_filename
            // 
            tb_filename.Location = new Point(551, 354);
            tb_filename.Name = "tb_filename";
            tb_filename.Size = new Size(237, 27);
            tb_filename.TabIndex = 3;
            // 
            // button_load
            // 
            button_load.Location = new Point(495, 403);
            button_load.Name = "button_load";
            button_load.Size = new Size(136, 29);
            button_load.TabIndex = 4;
            button_load.Text = "Load";
            button_load.UseVisualStyleBackColor = true;
            button_load.Click += button_load_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(651, 403);
            button_save.Name = "button_save";
            button_save.Size = new Size(137, 29);
            button_save.TabIndex = 5;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_save);
            Controls.Add(button_load);
            Controls.Add(tb_filename);
            Controls.Add(label_fayl);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public GroupBox groupBox1;
        public TextBox tb_email;
        public Label label_email;
        public TextBox tb_soyad;
        public Label label_soyad;
        public TextBox tb_ad;
        public Label lable_ad;
        public ListBox listBox1;
        public Button button_elave;
        public Button button_deyis;
        public TextBox tb_birhday;
        public Label label_doğum;
        public Label label_tel;
        public TextBox tb_tel;
        public Label label_fayl;
        public TextBox tb_filename;
        public Button button_load;
        public Button button_save;
        public OpenFileDialog openFileDialog1;
    }
}