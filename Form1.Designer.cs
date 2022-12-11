namespace controlDeColores
{
    partial class Form1
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
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSincronizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrarControl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlColor
            // 
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor.Location = new System.Drawing.Point(12, 28);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(213, 163);
            this.pnlColor.TabIndex = 0;
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(248, 28);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(330, 45);
            this.tbRed.TabIndex = 1;
            this.tbRed.Scroll += new System.EventHandler(this.tbRed_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(248, 168);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(330, 45);
            this.tbBlue.TabIndex = 2;
            this.tbBlue.Scroll += new System.EventHandler(this.tbBlue_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(248, 95);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(330, 45);
            this.tbGreen.TabIndex = 3;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(602, 28);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(13, 13);
            this.lblRed.TabIndex = 4;
            this.lblRed.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(602, 95);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(13, 13);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "0";
            this.lblGreen.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(602, 168);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(13, 13);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Blue";
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(639, 38);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(100, 20);
            this.txtRGB.TabIndex = 10;
            // 
            // txtHexa
            // 
            this.txtHexa.Location = new System.Drawing.Point(639, 86);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.Size = new System.Drawing.Size(100, 20);
            this.txtHexa.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Color HEXA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Color RGB";
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(639, 129);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(100, 21);
            this.cbSerialPort.TabIndex = 14;
            this.cbSerialPort.DropDown += new System.EventHandler(this.cbSerialPort_DropDown);
            this.cbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cbSerialPort_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Serial Port";
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.Location = new System.Drawing.Point(639, 163);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(100, 23);
            this.btnSincronizar.TabIndex = 16;
            this.btnSincronizar.Text = "Sincronizar color";
            this.btnSincronizar.UseVisualStyleBackColor = true;
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Color";
            // 
            // btnMostrarControl
            // 
            this.btnMostrarControl.Location = new System.Drawing.Point(639, 201);
            this.btnMostrarControl.Name = "btnMostrarControl";
            this.btnMostrarControl.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarControl.TabIndex = 18;
            this.btnMostrarControl.Text = "Control";
            this.btnMostrarControl.UseVisualStyleBackColor = true;
            this.btnMostrarControl.Click += new System.EventHandler(this.btnMostrarControl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 236);
            this.Controls.Add(this.btnMostrarControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSincronizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSerialPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.pnlColor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
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
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSincronizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostrarControl;
    }
}

