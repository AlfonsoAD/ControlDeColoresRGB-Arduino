namespace controlDeColores
{
    partial class ControlColores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlColores));
            this.pnlColor = new System.Windows.Forms.Panel();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSincronizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarColor = new System.Windows.Forms.Button();
            this.grpConfigColor = new System.Windows.Forms.GroupBox();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.btnAgregarColorSucesion = new System.Windows.Forms.Button();
            this.btnCrearSucesion = new System.Windows.Forms.Button();
            this.btnCtrl12 = new System.Windows.Forms.Button();
            this.btnCtrl11 = new System.Windows.Forms.Button();
            this.btnCtrl10 = new System.Windows.Forms.Button();
            this.btnCtrl9 = new System.Windows.Forms.Button();
            this.btnCtrl8 = new System.Windows.Forms.Button();
            this.btnCtrl7 = new System.Windows.Forms.Button();
            this.btnCtrl6 = new System.Windows.Forms.Button();
            this.btnCtrl5 = new System.Windows.Forms.Button();
            this.btnCtrl4 = new System.Windows.Forms.Button();
            this.btnCtrl3 = new System.Windows.Forms.Button();
            this.btnCtrl2 = new System.Windows.Forms.Button();
            this.btnCtrl1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLed1 = new System.Windows.Forms.Panel();
            this.pnlLed2 = new System.Windows.Forms.Panel();
            this.pnlLed3 = new System.Windows.Forms.Panel();
            this.pnlLed5 = new System.Windows.Forms.Panel();
            this.pnlLed6 = new System.Windows.Forms.Panel();
            this.pnlLed4 = new System.Windows.Forms.Panel();
            this.lbColores = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            this.grpConfigColor.SuspendLayout();
            this.grpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlColor
            // 
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor.Location = new System.Drawing.Point(11, 32);
            this.pnlColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(290, 185);
            this.pnlColor.TabIndex = 0;
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(309, 45);
            this.tbRed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(477, 45);
            this.tbRed.TabIndex = 1;
            this.tbRed.Scroll += new System.EventHandler(this.tbRed_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(309, 185);
            this.tbBlue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(477, 45);
            this.tbBlue.TabIndex = 2;
            this.tbBlue.Scroll += new System.EventHandler(this.tbBlue_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(309, 112);
            this.tbGreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(477, 45);
            this.tbGreen.TabIndex = 3;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(795, 51);
            this.lblRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(15, 13);
            this.lblRed.TabIndex = 4;
            this.lblRed.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(795, 118);
            this.lblGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(15, 13);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "0";
            this.lblGreen.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(795, 191);
            this.lblBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(15, 13);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Blue";
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(832, 70);
            this.txtRGB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(132, 20);
            this.txtRGB.TabIndex = 10;
            // 
            // txtHexa
            // 
            this.txtHexa.Location = new System.Drawing.Point(832, 118);
            this.txtHexa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.Size = new System.Drawing.Size(132, 20);
            this.txtHexa.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(828, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Color HEXA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(828, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Color RGB";
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.Location = new System.Drawing.Point(8, 187);
            this.btnSincronizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(184, 51);
            this.btnSincronizar.TabIndex = 16;
            this.btnSincronizar.Text = "Mostrar";
            this.btnSincronizar.UseVisualStyleBackColor = true;
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Color";
            // 
            // btnGuardarColor
            // 
            this.btnGuardarColor.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGuardarColor.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarColor.ForeColor = System.Drawing.Color.Green;
            this.btnGuardarColor.Location = new System.Drawing.Point(832, 154);
            this.btnGuardarColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardarColor.Name = "btnGuardarColor";
            this.btnGuardarColor.Size = new System.Drawing.Size(133, 63);
            this.btnGuardarColor.TabIndex = 19;
            this.btnGuardarColor.Text = "Guardar color";
            this.btnGuardarColor.UseVisualStyleBackColor = false;
            this.btnGuardarColor.Click += new System.EventHandler(this.btnGuardarColor_Click);
            // 
            // grpConfigColor
            // 
            this.grpConfigColor.Controls.Add(this.btnGuardarColor);
            this.grpConfigColor.Controls.Add(this.pnlColor);
            this.grpConfigColor.Controls.Add(this.tbRed);
            this.grpConfigColor.Controls.Add(this.label3);
            this.grpConfigColor.Controls.Add(this.tbBlue);
            this.grpConfigColor.Controls.Add(this.tbGreen);
            this.grpConfigColor.Controls.Add(this.lblRed);
            this.grpConfigColor.Controls.Add(this.lblGreen);
            this.grpConfigColor.Controls.Add(this.label6);
            this.grpConfigColor.Controls.Add(this.lblBlue);
            this.grpConfigColor.Controls.Add(this.label5);
            this.grpConfigColor.Controls.Add(this.label1);
            this.grpConfigColor.Controls.Add(this.txtHexa);
            this.grpConfigColor.Controls.Add(this.label2);
            this.grpConfigColor.Controls.Add(this.txtRGB);
            this.grpConfigColor.Controls.Add(this.label4);
            this.grpConfigColor.ForeColor = System.Drawing.Color.White;
            this.grpConfigColor.Location = new System.Drawing.Point(16, 12);
            this.grpConfigColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpConfigColor.Name = "grpConfigColor";
            this.grpConfigColor.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpConfigColor.Size = new System.Drawing.Size(991, 236);
            this.grpConfigColor.TabIndex = 20;
            this.grpConfigColor.TabStop = false;
            this.grpConfigColor.Text = "Personalizar color";
            // 
            // grpControl
            // 
            this.grpControl.BackColor = System.Drawing.Color.DimGray;
            this.grpControl.Controls.Add(this.btnAgregarColorSucesion);
            this.grpControl.Controls.Add(this.btnCrearSucesion);
            this.grpControl.Controls.Add(this.btnCtrl12);
            this.grpControl.Controls.Add(this.btnCtrl11);
            this.grpControl.Controls.Add(this.btnCtrl10);
            this.grpControl.Controls.Add(this.btnSincronizar);
            this.grpControl.Controls.Add(this.btnCtrl9);
            this.grpControl.Controls.Add(this.btnCtrl8);
            this.grpControl.Controls.Add(this.btnCtrl7);
            this.grpControl.Controls.Add(this.btnCtrl6);
            this.grpControl.Controls.Add(this.btnCtrl5);
            this.grpControl.Controls.Add(this.btnCtrl4);
            this.grpControl.Controls.Add(this.btnCtrl3);
            this.grpControl.Controls.Add(this.btnCtrl2);
            this.grpControl.Controls.Add(this.btnCtrl1);
            this.grpControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpControl.ForeColor = System.Drawing.Color.Black;
            this.grpControl.Location = new System.Drawing.Point(13, 254);
            this.grpControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpControl.Name = "grpControl";
            this.grpControl.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpControl.Size = new System.Drawing.Size(199, 364);
            this.grpControl.TabIndex = 21;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Control";
            // 
            // btnAgregarColorSucesion
            // 
            this.btnAgregarColorSucesion.Location = new System.Drawing.Point(9, 244);
            this.btnAgregarColorSucesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarColorSucesion.Name = "btnAgregarColorSucesion";
            this.btnAgregarColorSucesion.Size = new System.Drawing.Size(184, 51);
            this.btnAgregarColorSucesion.TabIndex = 26;
            this.btnAgregarColorSucesion.Text = "Agregar color a sucesion";
            this.btnAgregarColorSucesion.UseVisualStyleBackColor = true;
            this.btnAgregarColorSucesion.Click += new System.EventHandler(this.btnAgregarColorSucesion_Click);
            // 
            // btnCrearSucesion
            // 
            this.btnCrearSucesion.Location = new System.Drawing.Point(9, 301);
            this.btnCrearSucesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCrearSucesion.Name = "btnCrearSucesion";
            this.btnCrearSucesion.Size = new System.Drawing.Size(184, 51);
            this.btnCrearSucesion.TabIndex = 25;
            this.btnCrearSucesion.Text = "Crear sucesion";
            this.btnCrearSucesion.UseVisualStyleBackColor = true;
            this.btnCrearSucesion.Click += new System.EventHandler(this.btnCrearSucesion_Click);
            // 
            // btnCtrl12
            // 
            this.btnCtrl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(7)))), ((int)(((byte)(182)))));
            this.btnCtrl12.Location = new System.Drawing.Point(142, 147);
            this.btnCtrl12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl12.Name = "btnCtrl12";
            this.btnCtrl12.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl12.TabIndex = 24;
            this.btnCtrl12.UseVisualStyleBackColor = false;
            this.btnCtrl12.Click += new System.EventHandler(this.btnCtrl12_Click);
            // 
            // btnCtrl11
            // 
            this.btnCtrl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(36)))), ((int)(((byte)(15)))));
            this.btnCtrl11.Location = new System.Drawing.Point(142, 107);
            this.btnCtrl11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl11.Name = "btnCtrl11";
            this.btnCtrl11.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl11.TabIndex = 23;
            this.btnCtrl11.UseVisualStyleBackColor = false;
            this.btnCtrl11.Click += new System.EventHandler(this.btnCtrl11_Click);
            // 
            // btnCtrl10
            // 
            this.btnCtrl10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnCtrl10.Location = new System.Drawing.Point(142, 67);
            this.btnCtrl10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl10.Name = "btnCtrl10";
            this.btnCtrl10.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl10.TabIndex = 22;
            this.btnCtrl10.UseVisualStyleBackColor = false;
            this.btnCtrl10.Click += new System.EventHandler(this.btnCtrl10_Click);
            // 
            // btnCtrl9
            // 
            this.btnCtrl9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(148)))));
            this.btnCtrl9.Location = new System.Drawing.Point(142, 27);
            this.btnCtrl9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl9.Name = "btnCtrl9";
            this.btnCtrl9.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl9.TabIndex = 21;
            this.btnCtrl9.UseVisualStyleBackColor = false;
            this.btnCtrl9.Click += new System.EventHandler(this.btnCtrl9_Click);
            // 
            // btnCtrl8
            // 
            this.btnCtrl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(107)))));
            this.btnCtrl8.Location = new System.Drawing.Point(75, 147);
            this.btnCtrl8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl8.Name = "btnCtrl8";
            this.btnCtrl8.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl8.TabIndex = 20;
            this.btnCtrl8.UseVisualStyleBackColor = false;
            this.btnCtrl8.Click += new System.EventHandler(this.btnCtrl8_Click);
            // 
            // btnCtrl7
            // 
            this.btnCtrl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(96)))), ((int)(((byte)(191)))));
            this.btnCtrl7.Location = new System.Drawing.Point(75, 107);
            this.btnCtrl7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl7.Name = "btnCtrl7";
            this.btnCtrl7.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl7.TabIndex = 19;
            this.btnCtrl7.UseVisualStyleBackColor = false;
            this.btnCtrl7.Click += new System.EventHandler(this.btnCtrl7_Click);
            // 
            // btnCtrl6
            // 
            this.btnCtrl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(134)))), ((int)(((byte)(237)))));
            this.btnCtrl6.Location = new System.Drawing.Point(75, 67);
            this.btnCtrl6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl6.Name = "btnCtrl6";
            this.btnCtrl6.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl6.TabIndex = 18;
            this.btnCtrl6.UseVisualStyleBackColor = false;
            this.btnCtrl6.Click += new System.EventHandler(this.btnCtrl6_Click);
            // 
            // btnCtrl5
            // 
            this.btnCtrl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(153)))), ((int)(((byte)(13)))));
            this.btnCtrl5.Location = new System.Drawing.Point(75, 27);
            this.btnCtrl5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl5.Name = "btnCtrl5";
            this.btnCtrl5.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl5.TabIndex = 17;
            this.btnCtrl5.UseVisualStyleBackColor = false;
            this.btnCtrl5.Click += new System.EventHandler(this.btnCtrl5_Click);
            // 
            // btnCtrl4
            // 
            this.btnCtrl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(2)))));
            this.btnCtrl4.Location = new System.Drawing.Point(7, 147);
            this.btnCtrl4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl4.Name = "btnCtrl4";
            this.btnCtrl4.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl4.TabIndex = 16;
            this.btnCtrl4.UseVisualStyleBackColor = false;
            this.btnCtrl4.Click += new System.EventHandler(this.btnCtrl4_Click);
            // 
            // btnCtrl3
            // 
            this.btnCtrl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(98)))), ((int)(((byte)(26)))));
            this.btnCtrl3.Location = new System.Drawing.Point(7, 107);
            this.btnCtrl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl3.Name = "btnCtrl3";
            this.btnCtrl3.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl3.TabIndex = 15;
            this.btnCtrl3.UseVisualStyleBackColor = false;
            this.btnCtrl3.Click += new System.EventHandler(this.btnCtrl3_Click);
            // 
            // btnCtrl2
            // 
            this.btnCtrl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.btnCtrl2.Location = new System.Drawing.Point(7, 67);
            this.btnCtrl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl2.Name = "btnCtrl2";
            this.btnCtrl2.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl2.TabIndex = 14;
            this.btnCtrl2.UseVisualStyleBackColor = false;
            this.btnCtrl2.Click += new System.EventHandler(this.btnCtrl2_Click);
            // 
            // btnCtrl1
            // 
            this.btnCtrl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.btnCtrl1.ForeColor = System.Drawing.Color.White;
            this.btnCtrl1.Location = new System.Drawing.Point(7, 27);
            this.btnCtrl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCtrl1.Name = "btnCtrl1";
            this.btnCtrl1.Size = new System.Drawing.Size(49, 34);
            this.btnCtrl1.TabIndex = 13;
            this.btnCtrl1.UseVisualStyleBackColor = false;
            this.btnCtrl1.Click += new System.EventHandler(this.btnCtrl1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(456, 250);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pnlLed1
            // 
            this.pnlLed1.BackColor = System.Drawing.Color.Black;
            this.pnlLed1.Location = new System.Drawing.Point(527, 318);
            this.pnlLed1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLed1.Name = "pnlLed1";
            this.pnlLed1.Size = new System.Drawing.Size(32, 24);
            this.pnlLed1.TabIndex = 23;
            // 
            // pnlLed2
            // 
            this.pnlLed2.BackColor = System.Drawing.Color.Black;
            this.pnlLed2.Location = new System.Drawing.Point(589, 288);
            this.pnlLed2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLed2.Name = "pnlLed2";
            this.pnlLed2.Size = new System.Drawing.Size(32, 24);
            this.pnlLed2.TabIndex = 24;
            // 
            // pnlLed3
            // 
            this.pnlLed3.BackColor = System.Drawing.Color.Black;
            this.pnlLed3.Location = new System.Drawing.Point(677, 262);
            this.pnlLed3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLed3.Name = "pnlLed3";
            this.pnlLed3.Size = new System.Drawing.Size(32, 24);
            this.pnlLed3.TabIndex = 24;
            // 
            // pnlLed5
            // 
            this.pnlLed5.BackColor = System.Drawing.Color.Black;
            this.pnlLed5.Location = new System.Drawing.Point(848, 288);
            this.pnlLed5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLed5.Name = "pnlLed5";
            this.pnlLed5.Size = new System.Drawing.Size(32, 24);
            this.pnlLed5.TabIndex = 24;
            // 
            // pnlLed6
            // 
            this.pnlLed6.BackColor = System.Drawing.Color.Black;
            this.pnlLed6.Location = new System.Drawing.Point(908, 318);
            this.pnlLed6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLed6.Name = "pnlLed6";
            this.pnlLed6.Size = new System.Drawing.Size(32, 24);
            this.pnlLed6.TabIndex = 24;
            // 
            // pnlLed4
            // 
            this.pnlLed4.BackColor = System.Drawing.Color.Black;
            this.pnlLed4.Location = new System.Drawing.Point(772, 262);
            this.pnlLed4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLed4.Name = "pnlLed4";
            this.pnlLed4.Size = new System.Drawing.Size(32, 24);
            this.pnlLed4.TabIndex = 24;
            // 
            // lbColores
            // 
            this.lbColores.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColores.FormattingEnabled = true;
            this.lbColores.ItemHeight = 11;
            this.lbColores.Location = new System.Drawing.Point(219, 339);
            this.lbColores.Name = "lbColores";
            this.lbColores.Size = new System.Drawing.Size(230, 279);
            this.lbColores.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 321);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Colores seleccionados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Serial Port";
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(219, 270);
            this.cbSerialPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(132, 21);
            this.cbSerialPort.TabIndex = 28;
            // 
            // ControlColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1013, 624);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSerialPort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbColores);
            this.Controls.Add(this.pnlLed6);
            this.Controls.Add(this.pnlLed5);
            this.Controls.Add(this.pnlLed2);
            this.Controls.Add(this.pnlLed3);
            this.Controls.Add(this.pnlLed4);
            this.Controls.Add(this.pnlLed1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpControl);
            this.Controls.Add(this.grpConfigColor);
            this.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ControlColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Sistemas programables";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            this.grpConfigColor.ResumeLayout(false);
            this.grpConfigColor.PerformLayout();
            this.grpControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSincronizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarColor;
        private System.Windows.Forms.GroupBox grpConfigColor;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.Button btnCtrl12;
        private System.Windows.Forms.Button btnCtrl11;
        private System.Windows.Forms.Button btnCtrl10;
        private System.Windows.Forms.Button btnCtrl9;
        private System.Windows.Forms.Button btnCtrl8;
        private System.Windows.Forms.Button btnCtrl7;
        private System.Windows.Forms.Button btnCtrl6;
        private System.Windows.Forms.Button btnCtrl5;
        private System.Windows.Forms.Button btnCtrl4;
        private System.Windows.Forms.Button btnCtrl3;
        private System.Windows.Forms.Button btnCtrl2;
        private System.Windows.Forms.Button btnCtrl1;
        private System.Windows.Forms.Button btnAgregarColorSucesion;
        private System.Windows.Forms.Button btnCrearSucesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLed1;
        private System.Windows.Forms.Panel pnlLed2;
        private System.Windows.Forms.Panel pnlLed3;
        private System.Windows.Forms.Panel pnlLed5;
        private System.Windows.Forms.Panel pnlLed6;
        private System.Windows.Forms.Panel pnlLed4;
        private System.Windows.Forms.ListBox lbColores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSerialPort;
    }
}

