﻿namespace SW_T8_9_10
{
    partial class Form1
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_From_File_PB1 = new System.Windows.Forms.Button();
            this.button_Browse_Files_PB1 = new System.Windows.Forms.Button();
            this.textBox_Image_Path_PB1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.textBox_G = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.button_Ustaw_Jako_Palnosc = new System.Windows.Forms.Button();
            this.button_Ustaw_Jako_Nadpalenie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Cecha_dowolna = new System.Windows.Forms.CheckBox();
            this.label_Liczba_obiektow = new System.Windows.Forms.Label();
            this.label_Nadpalone = new System.Windows.Forms.Label();
            this.label_Wypalone = new System.Windows.Forms.Label();
            this.label_Palace = new System.Windows.Forms.Label();
            this.label_Tlace = new System.Windows.Forms.Label();
            this.button_Rozpocznij_pozar = new System.Windows.Forms.Button();
            this.button_Pozar_calosci = new System.Windows.Forms.Button();
            this.button_Cykl_pozaru = new System.Windows.Forms.Button();
            this.button_Krok_pozaru = new System.Windows.Forms.Button();
            this.checkBox_Skos = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_R_nadpal = new System.Windows.Forms.TextBox();
            this.textBox_G_nadpal = new System.Windows.Forms.TextBox();
            this.textBox_B_nadpal = new System.Windows.Forms.TextBox();
            this.textBox_R_pal = new System.Windows.Forms.TextBox();
            this.textBox_G_pal = new System.Windows.Forms.TextBox();
            this.textBox_B_pal = new System.Windows.Forms.TextBox();
            this.button_Pokaz_obiekt = new System.Windows.Forms.Button();
            this.numericUpDown_Numer_obiektu = new System.Windows.Forms.NumericUpDown();
            this.button_Czysc = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_Mechanika = new System.Windows.Forms.Button();
            this.listView_Dane_Mechanika = new System.Windows.Forms.ListView();
            this.button_Obrysuj = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Numer_obiektu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(0, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // button_From_File_PB1
            // 
            this.button_From_File_PB1.Location = new System.Drawing.Point(0, 28);
            this.button_From_File_PB1.Name = "button_From_File_PB1";
            this.button_From_File_PB1.Size = new System.Drawing.Size(48, 22);
            this.button_From_File_PB1.TabIndex = 51;
            this.button_From_File_PB1.Text = "Z pliku";
            this.button_From_File_PB1.UseVisualStyleBackColor = true;
            this.button_From_File_PB1.Click += new System.EventHandler(this.button_From_File_PB1_Click);
            // 
            // button_Browse_Files_PB1
            // 
            this.button_Browse_Files_PB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Browse_Files_PB1.Location = new System.Drawing.Point(292, 2);
            this.button_Browse_Files_PB1.Name = "button_Browse_Files_PB1";
            this.button_Browse_Files_PB1.Size = new System.Drawing.Size(28, 20);
            this.button_Browse_Files_PB1.TabIndex = 54;
            this.button_Browse_Files_PB1.Text = "...";
            this.button_Browse_Files_PB1.UseVisualStyleBackColor = true;
            this.button_Browse_Files_PB1.Click += new System.EventHandler(this.button_Browse_Files_PB1_Click);
            // 
            // textBox_Image_Path_PB1
            // 
            this.textBox_Image_Path_PB1.Location = new System.Drawing.Point(44, 2);
            this.textBox_Image_Path_PB1.Name = "textBox_Image_Path_PB1";
            this.textBox_Image_Path_PB1.Size = new System.Drawing.Size(247, 20);
            this.textBox_Image_Path_PB1.TabIndex = 53;
            this.textBox_Image_Path_PB1.Text = "C:\\Users\\Piotr Łuczak\\Desktop\\elipsa3.bmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ścieżka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Listing koloru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "X:";
            // 
            // textBox_R
            // 
            this.textBox_R.BackColor = System.Drawing.Color.LightPink;
            this.textBox_R.Location = new System.Drawing.Point(130, 42);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(36, 20);
            this.textBox_R.TabIndex = 59;
            this.textBox_R.Text = "0";
            // 
            // textBox_G
            // 
            this.textBox_G.BackColor = System.Drawing.Color.LawnGreen;
            this.textBox_G.Location = new System.Drawing.Point(93, 42);
            this.textBox_G.Name = "textBox_G";
            this.textBox_G.Size = new System.Drawing.Size(36, 20);
            this.textBox_G.TabIndex = 58;
            this.textBox_G.Text = "0";
            // 
            // textBox_B
            // 
            this.textBox_B.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_B.Location = new System.Drawing.Point(55, 42);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(36, 20);
            this.textBox_B.TabIndex = 57;
            this.textBox_B.Text = "0";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(131, 65);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(35, 20);
            this.textBox_Y.TabIndex = 56;
            this.textBox_Y.Text = "0";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(73, 65);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(35, 20);
            this.textBox_X.TabIndex = 55;
            this.textBox_X.Text = "0";
            // 
            // button_Ustaw_Jako_Palnosc
            // 
            this.button_Ustaw_Jako_Palnosc.Location = new System.Drawing.Point(172, 28);
            this.button_Ustaw_Jako_Palnosc.Name = "button_Ustaw_Jako_Palnosc";
            this.button_Ustaw_Jako_Palnosc.Size = new System.Drawing.Size(71, 57);
            this.button_Ustaw_Jako_Palnosc.TabIndex = 63;
            this.button_Ustaw_Jako_Palnosc.Text = "Ustaw jako cecha palności";
            this.button_Ustaw_Jako_Palnosc.UseVisualStyleBackColor = true;
            this.button_Ustaw_Jako_Palnosc.Click += new System.EventHandler(this.button_Ustaw_Jako_Palnosc_Click);
            // 
            // button_Ustaw_Jako_Nadpalenie
            // 
            this.button_Ustaw_Jako_Nadpalenie.Location = new System.Drawing.Point(249, 28);
            this.button_Ustaw_Jako_Nadpalenie.Name = "button_Ustaw_Jako_Nadpalenie";
            this.button_Ustaw_Jako_Nadpalenie.Size = new System.Drawing.Size(71, 57);
            this.button_Ustaw_Jako_Nadpalenie.TabIndex = 64;
            this.button_Ustaw_Jako_Nadpalenie.Text = "Ustaw jako cecha nadpalenia";
            this.button_Ustaw_Jako_Nadpalenie.UseVisualStyleBackColor = true;
            this.button_Ustaw_Jako_Nadpalenie.Click += new System.EventHandler(this.button_Ustaw_Jako_Nadpalenie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Cecha_dowolna);
            this.groupBox1.Controls.Add(this.label_Liczba_obiektow);
            this.groupBox1.Controls.Add(this.label_Nadpalone);
            this.groupBox1.Controls.Add(this.label_Wypalone);
            this.groupBox1.Controls.Add(this.label_Palace);
            this.groupBox1.Controls.Add(this.label_Tlace);
            this.groupBox1.Controls.Add(this.button_Rozpocznij_pozar);
            this.groupBox1.Controls.Add(this.button_Pozar_calosci);
            this.groupBox1.Controls.Add(this.button_Cykl_pozaru);
            this.groupBox1.Controls.Add(this.button_Krok_pozaru);
            this.groupBox1.Controls.Add(this.checkBox_Skos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_R_nadpal);
            this.groupBox1.Controls.Add(this.textBox_G_nadpal);
            this.groupBox1.Controls.Add(this.textBox_B_nadpal);
            this.groupBox1.Controls.Add(this.textBox_R_pal);
            this.groupBox1.Controls.Add(this.textBox_G_pal);
            this.groupBox1.Controls.Add(this.textBox_B_pal);
            this.groupBox1.Location = new System.Drawing.Point(326, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 329);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia segmentacji";
            // 
            // checkBox_Cecha_dowolna
            // 
            this.checkBox_Cecha_dowolna.AutoSize = true;
            this.checkBox_Cecha_dowolna.Location = new System.Drawing.Point(113, 71);
            this.checkBox_Cecha_dowolna.Name = "checkBox_Cecha_dowolna";
            this.checkBox_Cecha_dowolna.Size = new System.Drawing.Size(100, 17);
            this.checkBox_Cecha_dowolna.TabIndex = 78;
            this.checkBox_Cecha_dowolna.Text = "Cecha dowolna";
            this.checkBox_Cecha_dowolna.UseVisualStyleBackColor = true;
            this.checkBox_Cecha_dowolna.CheckedChanged += new System.EventHandler(this.checkBox_Cecha_dowolna_CheckedChanged);
            // 
            // label_Liczba_obiektow
            // 
            this.label_Liczba_obiektow.AutoSize = true;
            this.label_Liczba_obiektow.Location = new System.Drawing.Point(3, 163);
            this.label_Liczba_obiektow.Name = "label_Liczba_obiektow";
            this.label_Liczba_obiektow.Size = new System.Drawing.Size(87, 13);
            this.label_Liczba_obiektow.TabIndex = 77;
            this.label_Liczba_obiektow.Text = "Liczba obiektów:";
            // 
            // label_Nadpalone
            // 
            this.label_Nadpalone.AutoSize = true;
            this.label_Nadpalone.Location = new System.Drawing.Point(3, 127);
            this.label_Nadpalone.Name = "label_Nadpalone";
            this.label_Nadpalone.Size = new System.Drawing.Size(137, 13);
            this.label_Nadpalone.TabIndex = 76;
            this.label_Nadpalone.Text = "Liczba pikseli nadpalonych:";
            // 
            // label_Wypalone
            // 
            this.label_Wypalone.AutoSize = true;
            this.label_Wypalone.Location = new System.Drawing.Point(3, 140);
            this.label_Wypalone.Name = "label_Wypalone";
            this.label_Wypalone.Size = new System.Drawing.Size(132, 13);
            this.label_Wypalone.TabIndex = 75;
            this.label_Wypalone.Text = "Liczba pikseli wypalonych:";
            // 
            // label_Palace
            // 
            this.label_Palace.AutoSize = true;
            this.label_Palace.Location = new System.Drawing.Point(3, 114);
            this.label_Palace.Name = "label_Palace";
            this.label_Palace.Size = new System.Drawing.Size(119, 13);
            this.label_Palace.TabIndex = 74;
            this.label_Palace.Text = "Liczba pikseli palacych:";
            // 
            // label_Tlace
            // 
            this.label_Tlace.AutoSize = true;
            this.label_Tlace.Location = new System.Drawing.Point(3, 101);
            this.label_Tlace.Name = "label_Tlace";
            this.label_Tlace.Size = new System.Drawing.Size(110, 13);
            this.label_Tlace.TabIndex = 73;
            this.label_Tlace.Text = "Liczba pikseli tlacych:";
            // 
            // button_Rozpocznij_pozar
            // 
            this.button_Rozpocznij_pozar.Location = new System.Drawing.Point(6, 213);
            this.button_Rozpocznij_pozar.Name = "button_Rozpocznij_pozar";
            this.button_Rozpocznij_pozar.Size = new System.Drawing.Size(100, 23);
            this.button_Rozpocznij_pozar.TabIndex = 72;
            this.button_Rozpocznij_pozar.Text = "Rozpocznij pożar";
            this.button_Rozpocznij_pozar.UseVisualStyleBackColor = true;
            this.button_Rozpocznij_pozar.Click += new System.EventHandler(this.button_Rozpocznij_pozar_Click);
            // 
            // button_Pozar_calosci
            // 
            this.button_Pozar_calosci.Location = new System.Drawing.Point(6, 300);
            this.button_Pozar_calosci.Name = "button_Pozar_calosci";
            this.button_Pozar_calosci.Size = new System.Drawing.Size(100, 23);
            this.button_Pozar_calosci.TabIndex = 71;
            this.button_Pozar_calosci.Text = "Pożar całości";
            this.button_Pozar_calosci.UseVisualStyleBackColor = true;
            this.button_Pozar_calosci.Click += new System.EventHandler(this.button_Pozar_calosci_Click);
            // 
            // button_Cykl_pozaru
            // 
            this.button_Cykl_pozaru.Location = new System.Drawing.Point(6, 271);
            this.button_Cykl_pozaru.Name = "button_Cykl_pozaru";
            this.button_Cykl_pozaru.Size = new System.Drawing.Size(100, 23);
            this.button_Cykl_pozaru.TabIndex = 70;
            this.button_Cykl_pozaru.Text = "Cykl pożaru";
            this.button_Cykl_pozaru.UseVisualStyleBackColor = true;
            this.button_Cykl_pozaru.Click += new System.EventHandler(this.button_Cykl_pozaru_Click);
            // 
            // button_Krok_pozaru
            // 
            this.button_Krok_pozaru.Location = new System.Drawing.Point(6, 242);
            this.button_Krok_pozaru.Name = "button_Krok_pozaru";
            this.button_Krok_pozaru.Size = new System.Drawing.Size(100, 23);
            this.button_Krok_pozaru.TabIndex = 69;
            this.button_Krok_pozaru.Text = "Krok pożaru";
            this.button_Krok_pozaru.UseVisualStyleBackColor = true;
            this.button_Krok_pozaru.Click += new System.EventHandler(this.button_Krok_pozaru_Click);
            // 
            // checkBox_Skos
            // 
            this.checkBox_Skos.AutoSize = true;
            this.checkBox_Skos.Location = new System.Drawing.Point(19, 71);
            this.checkBox_Skos.Name = "checkBox_Skos";
            this.checkBox_Skos.Size = new System.Drawing.Size(50, 17);
            this.checkBox_Skos.TabIndex = 68;
            this.checkBox_Skos.Text = "Skos";
            this.checkBox_Skos.UseVisualStyleBackColor = true;
            this.checkBox_Skos.CheckedChanged += new System.EventHandler(this.checkBox_Skos_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Cecha nadpalenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Cecha palności";
            // 
            // textBox_R_nadpal
            // 
            this.textBox_R_nadpal.BackColor = System.Drawing.Color.LightPink;
            this.textBox_R_nadpal.Location = new System.Drawing.Point(81, 45);
            this.textBox_R_nadpal.Name = "textBox_R_nadpal";
            this.textBox_R_nadpal.Size = new System.Drawing.Size(36, 20);
            this.textBox_R_nadpal.TabIndex = 65;
            this.textBox_R_nadpal.Text = "0";
            // 
            // textBox_G_nadpal
            // 
            this.textBox_G_nadpal.BackColor = System.Drawing.Color.LawnGreen;
            this.textBox_G_nadpal.Location = new System.Drawing.Point(44, 45);
            this.textBox_G_nadpal.Name = "textBox_G_nadpal";
            this.textBox_G_nadpal.Size = new System.Drawing.Size(36, 20);
            this.textBox_G_nadpal.TabIndex = 64;
            this.textBox_G_nadpal.Text = "0";
            // 
            // textBox_B_nadpal
            // 
            this.textBox_B_nadpal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_B_nadpal.Location = new System.Drawing.Point(6, 45);
            this.textBox_B_nadpal.Name = "textBox_B_nadpal";
            this.textBox_B_nadpal.Size = new System.Drawing.Size(36, 20);
            this.textBox_B_nadpal.TabIndex = 63;
            this.textBox_B_nadpal.Text = "0";
            // 
            // textBox_R_pal
            // 
            this.textBox_R_pal.BackColor = System.Drawing.Color.LightPink;
            this.textBox_R_pal.Location = new System.Drawing.Point(81, 19);
            this.textBox_R_pal.Name = "textBox_R_pal";
            this.textBox_R_pal.Size = new System.Drawing.Size(36, 20);
            this.textBox_R_pal.TabIndex = 62;
            this.textBox_R_pal.Text = "0xFF";
            // 
            // textBox_G_pal
            // 
            this.textBox_G_pal.BackColor = System.Drawing.Color.LawnGreen;
            this.textBox_G_pal.Location = new System.Drawing.Point(44, 19);
            this.textBox_G_pal.Name = "textBox_G_pal";
            this.textBox_G_pal.Size = new System.Drawing.Size(36, 20);
            this.textBox_G_pal.TabIndex = 61;
            this.textBox_G_pal.Text = "0xFF";
            // 
            // textBox_B_pal
            // 
            this.textBox_B_pal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_B_pal.Location = new System.Drawing.Point(6, 19);
            this.textBox_B_pal.Name = "textBox_B_pal";
            this.textBox_B_pal.Size = new System.Drawing.Size(36, 20);
            this.textBox_B_pal.TabIndex = 60;
            this.textBox_B_pal.Text = "0xFF";
            // 
            // button_Pokaz_obiekt
            // 
            this.button_Pokaz_obiekt.Location = new System.Drawing.Point(0, 337);
            this.button_Pokaz_obiekt.Name = "button_Pokaz_obiekt";
            this.button_Pokaz_obiekt.Size = new System.Drawing.Size(100, 23);
            this.button_Pokaz_obiekt.TabIndex = 79;
            this.button_Pokaz_obiekt.Text = "Pokaż obiekt nr:";
            this.button_Pokaz_obiekt.UseVisualStyleBackColor = true;
            this.button_Pokaz_obiekt.Click += new System.EventHandler(this.button_Pokaz_obiekt_Click);
            // 
            // numericUpDown_Numer_obiektu
            // 
            this.numericUpDown_Numer_obiektu.Location = new System.Drawing.Point(106, 337);
            this.numericUpDown_Numer_obiektu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Numer_obiektu.Name = "numericUpDown_Numer_obiektu";
            this.numericUpDown_Numer_obiektu.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_Numer_obiektu.TabIndex = 80;
            this.numericUpDown_Numer_obiektu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_Czysc
            // 
            this.button_Czysc.Location = new System.Drawing.Point(0, 56);
            this.button_Czysc.Name = "button_Czysc";
            this.button_Czysc.Size = new System.Drawing.Size(48, 34);
            this.button_Czysc.TabIndex = 81;
            this.button_Czysc.Text = "Czyść";
            this.button_Czysc.UseVisualStyleBackColor = true;
            this.button_Czysc.Click += new System.EventHandler(this.button_Czysc_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(447, 366);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(320, 240);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // button_Mechanika
            // 
            this.button_Mechanika.Location = new System.Drawing.Point(332, 366);
            this.button_Mechanika.Name = "button_Mechanika";
            this.button_Mechanika.Size = new System.Drawing.Size(100, 159);
            this.button_Mechanika.TabIndex = 83;
            this.button_Mechanika.Text = "Mechanika";
            this.button_Mechanika.UseVisualStyleBackColor = true;
            this.button_Mechanika.Click += new System.EventHandler(this.button_Mechanika_Click);
            // 
            // listView_Dane_Mechanika
            // 
            this.listView_Dane_Mechanika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_Dane_Mechanika.Location = new System.Drawing.Point(0, 612);
            this.listView_Dane_Mechanika.Name = "listView_Dane_Mechanika";
            this.listView_Dane_Mechanika.Size = new System.Drawing.Size(432, 195);
            this.listView_Dane_Mechanika.TabIndex = 84;
            this.listView_Dane_Mechanika.UseCompatibleStateImageBehavior = false;
            this.listView_Dane_Mechanika.View = System.Windows.Forms.View.Details;
            // 
            // button_Obrysuj
            // 
            this.button_Obrysuj.Location = new System.Drawing.Point(332, 531);
            this.button_Obrysuj.Name = "button_Obrysuj";
            this.button_Obrysuj.Size = new System.Drawing.Size(100, 75);
            this.button_Obrysuj.TabIndex = 85;
            this.button_Obrysuj.Text = "Obrysuj";
            this.button_Obrysuj.UseVisualStyleBackColor = true;
            this.button_Obrysuj.Click += new System.EventHandler(this.button_Obrysuj_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Wyniki analizy:";
            this.columnHeader1.Width = 409;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 810);
            this.Controls.Add(this.button_Obrysuj);
            this.Controls.Add(this.listView_Dane_Mechanika);
            this.Controls.Add(this.button_Mechanika);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button_Czysc);
            this.Controls.Add(this.numericUpDown_Numer_obiektu);
            this.Controls.Add(this.button_Pokaz_obiekt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Ustaw_Jako_Nadpalenie);
            this.Controls.Add(this.button_Ustaw_Jako_Palnosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_R);
            this.Controls.Add(this.textBox_G);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.button_Browse_Files_PB1);
            this.Controls.Add(this.textBox_Image_Path_PB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_From_File_PB1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "SW T5-6: Segmentacja, mechanika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Numer_obiektu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_From_File_PB1;
        private System.Windows.Forms.Button button_Browse_Files_PB1;
        private System.Windows.Forms.TextBox textBox_Image_Path_PB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.TextBox textBox_G;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Button button_Ustaw_Jako_Palnosc;
        private System.Windows.Forms.Button button_Ustaw_Jako_Nadpalenie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_R_nadpal;
        private System.Windows.Forms.TextBox textBox_G_nadpal;
        private System.Windows.Forms.TextBox textBox_B_nadpal;
        private System.Windows.Forms.TextBox textBox_R_pal;
        private System.Windows.Forms.TextBox textBox_G_pal;
        private System.Windows.Forms.TextBox textBox_B_pal;
        private System.Windows.Forms.CheckBox checkBox_Skos;
        private System.Windows.Forms.Button button_Pozar_calosci;
        private System.Windows.Forms.Button button_Cykl_pozaru;
        private System.Windows.Forms.Button button_Krok_pozaru;
        private System.Windows.Forms.Button button_Rozpocznij_pozar;
        private System.Windows.Forms.Label label_Nadpalone;
        private System.Windows.Forms.Label label_Wypalone;
        private System.Windows.Forms.Label label_Palace;
        private System.Windows.Forms.Label label_Tlace;
        private System.Windows.Forms.Label label_Liczba_obiektow;
        private System.Windows.Forms.CheckBox checkBox_Cecha_dowolna;
        private System.Windows.Forms.Button button_Pokaz_obiekt;
        private System.Windows.Forms.NumericUpDown numericUpDown_Numer_obiektu;
        private System.Windows.Forms.Button button_Czysc;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_Mechanika;
        private System.Windows.Forms.ListView listView_Dane_Mechanika;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button_Obrysuj;
    }
}

