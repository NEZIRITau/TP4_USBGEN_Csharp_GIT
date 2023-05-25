
namespace TP4_UsbGen
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_Signal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_PortCOM = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numeric_Freq = new System.Windows.Forms.NumericUpDown();
            this.numeric_Ampl = new System.Windows.Forms.NumericUpDown();
            this.numeric_Offset = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_USB = new System.Windows.Forms.TextBox();
            this.button_Envoi = new System.Windows.Forms.Button();
            this.buttn_Envoi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Ouv_Port = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Cls_Port = new System.Windows.Forms.Button();
            this.Lab_Port = new System.Windows.Forms.Label();
            this.Btn_refresh = new System.Windows.Forms.Button();
            this.Pic_Box = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Ampl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Signal
            // 
            this.comboBox_Signal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Signal.FormattingEnabled = true;
            this.comboBox_Signal.Items.AddRange(new object[] {
            "Sinus",
            "Triangle",
            "Carré",
            "Dent-de-scie"});
            this.comboBox_Signal.Location = new System.Drawing.Point(125, 38);
            this.comboBox_Signal.Name = "comboBox_Signal";
            this.comboBox_Signal.Size = new System.Drawing.Size(126, 24);
            this.comboBox_Signal.TabIndex = 0;
            this.comboBox_Signal.SelectedIndexChanged += new System.EventHandler(this.comboBox_Signal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fréquence :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amplitude :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Offset :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 42);
            this.label6.TabIndex = 10;
            this.label6.Text = "TP4_UsbGen";
            // 
            // comboBox_PortCOM
            // 
            this.comboBox_PortCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_PortCOM.FormattingEnabled = true;
            this.comboBox_PortCOM.Location = new System.Drawing.Point(190, 38);
            this.comboBox_PortCOM.Name = "comboBox_PortCOM";
            this.comboBox_PortCOM.Size = new System.Drawing.Size(126, 24);
            this.comboBox_PortCOM.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Choix du port(COM) :";
            // 
            // numeric_Freq
            // 
            this.numeric_Freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_Freq.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_Freq.Location = new System.Drawing.Point(125, 80);
            this.numeric_Freq.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numeric_Freq.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numeric_Freq.Name = "numeric_Freq";
            this.numeric_Freq.Size = new System.Drawing.Size(120, 22);
            this.numeric_Freq.TabIndex = 18;
            this.numeric_Freq.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numeric_Ampl
            // 
            this.numeric_Ampl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_Ampl.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_Ampl.Location = new System.Drawing.Point(125, 122);
            this.numeric_Ampl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_Ampl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Ampl.Name = "numeric_Ampl";
            this.numeric_Ampl.Size = new System.Drawing.Size(120, 22);
            this.numeric_Ampl.TabIndex = 19;
            this.numeric_Ampl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeric_Offset
            // 
            this.numeric_Offset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_Offset.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_Offset.Location = new System.Drawing.Point(125, 161);
            this.numeric_Offset.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numeric_Offset.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.numeric_Offset.Name = "numeric_Offset";
            this.numeric_Offset.Size = new System.Drawing.Size(120, 22);
            this.numeric_Offset.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Envoi : ";
            // 
            // textBox_USB
            // 
            this.textBox_USB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_USB.Location = new System.Drawing.Point(114, 36);
            this.textBox_USB.Name = "textBox_USB";
            this.textBox_USB.Size = new System.Drawing.Size(251, 22);
            this.textBox_USB.TabIndex = 22;
            // 
            // button_Envoi
            // 
            this.button_Envoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Envoi.Location = new System.Drawing.Point(370, 449);
            this.button_Envoi.Name = "button_Envoi";
            this.button_Envoi.Size = new System.Drawing.Size(160, 64);
            this.button_Envoi.TabIndex = 23;
            this.button_Envoi.Text = "Envoi";
            this.button_Envoi.UseVisualStyleBackColor = true;
            this.button_Envoi.Click += new System.EventHandler(this.button_Envoi_Click);
            // 
            // buttn_Envoi
            // 
            this.buttn_Envoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttn_Envoi.Location = new System.Drawing.Point(548, 449);
            this.buttn_Envoi.Name = "buttn_Envoi";
            this.buttn_Envoi.Size = new System.Drawing.Size(160, 64);
            this.buttn_Envoi.TabIndex = 15;
            this.buttn_Envoi.Text = "Sauvegarde";
            this.buttn_Envoi.UseVisualStyleBackColor = true;
            this.buttn_Envoi.Click += new System.EventHandler(this.buttn_Save_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(114, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Réception : ";
            // 
            // Ouv_Port
            // 
            this.Ouv_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ouv_Port.Location = new System.Drawing.Point(379, 197);
            this.Ouv_Port.Name = "Ouv_Port";
            this.Ouv_Port.Size = new System.Drawing.Size(160, 29);
            this.Ouv_Port.TabIndex = 27;
            this.Ouv_Port.Text = "Open Port";
            this.Ouv_Port.UseVisualStyleBackColor = true;
            this.Ouv_Port.Click += new System.EventHandler(this.Ouv_Port_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Cls_Port
            // 
            this.Cls_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cls_Port.Location = new System.Drawing.Point(21, 135);
            this.Cls_Port.Name = "Cls_Port";
            this.Cls_Port.Size = new System.Drawing.Size(160, 29);
            this.Cls_Port.TabIndex = 28;
            this.Cls_Port.Text = "Close Port";
            this.Cls_Port.UseVisualStyleBackColor = true;
            this.Cls_Port.Click += new System.EventHandler(this.Cls_Port_Click);
            // 
            // Lab_Port
            // 
            this.Lab_Port.AutoSize = true;
            this.Lab_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Port.Location = new System.Drawing.Point(213, 144);
            this.Lab_Port.Name = "Lab_Port";
            this.Lab_Port.Size = new System.Drawing.Size(0, 20);
            this.Lab_Port.TabIndex = 29;
            // 
            // Btn_refresh
            // 
            this.Btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_refresh.Location = new System.Drawing.Point(230, 93);
            this.Btn_refresh.Name = "Btn_refresh";
            this.Btn_refresh.Size = new System.Drawing.Size(120, 29);
            this.Btn_refresh.TabIndex = 30;
            this.Btn_refresh.Text = "Refresh";
            this.Btn_refresh.UseVisualStyleBackColor = true;
            this.Btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // Pic_Box
            // 
            this.Pic_Box.Image = global::TP4_UsbGen.Properties.Resources.SignSinus;
            this.Pic_Box.Location = new System.Drawing.Point(52, 339);
            this.Pic_Box.Name = "Pic_Box";
            this.Pic_Box.Size = new System.Drawing.Size(211, 157);
            this.Pic_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Box.TabIndex = 31;
            this.Pic_Box.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Signal);
            this.groupBox1.Controls.Add(this.numeric_Freq);
            this.groupBox1.Controls.Add(this.numeric_Ampl);
            this.groupBox1.Controls.Add(this.numeric_Offset);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 420);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paramètres du signal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_refresh);
            this.groupBox2.Controls.Add(this.Lab_Port);
            this.groupBox2.Controls.Add(this.Cls_Port);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox_PortCOM);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(358, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 185);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ports COM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox_USB);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(355, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 209);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trame USB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pic_Box);
            this.Controls.Add(this.Ouv_Port);
            this.Controls.Add(this.button_Envoi);
            this.Controls.Add(this.buttn_Envoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Application USB";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Ampl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Signal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_PortCOM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numeric_Freq;
        private System.Windows.Forms.NumericUpDown numeric_Ampl;
        private System.Windows.Forms.NumericUpDown numeric_Offset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_USB;
        private System.Windows.Forms.Button button_Envoi;
        private System.Windows.Forms.Button buttn_Envoi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Ouv_Port;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Cls_Port;
        private System.Windows.Forms.Label Lab_Port;
        private System.Windows.Forms.Button Btn_refresh;
        private System.Windows.Forms.PictureBox Pic_Box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

