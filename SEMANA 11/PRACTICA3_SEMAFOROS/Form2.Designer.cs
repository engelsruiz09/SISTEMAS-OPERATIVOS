namespace PRACTICA3_SEMAFOROS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            lblEntrada = new Label();
            lblSalida = new Label();
            pictureBox1 = new PictureBox();
            txtCantidadVehiculos = new TextBox();
            txtTiempoSemaforo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            listBoxcolaentrada = new ListBox();
            listBoxcolasalida = new ListBox();
            cmbUnidadTiempo = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(200, 202);
            button1.Name = "button1";
            button1.Size = new Size(110, 43);
            button1.TabIndex = 0;
            button1.Text = "Agregar ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(781, 206);
            button2.Name = "button2";
            button2.Size = new Size(115, 38);
            button2.TabIndex = 1;
            button2.Text = "Salida";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 205);
            label1.Name = "label1";
            label1.Size = new Size(182, 31);
            label1.TabIndex = 2;
            label1.Text = "Agregar Entrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(600, 210);
            label2.Name = "label2";
            label2.Size = new Size(165, 31);
            label2.TabIndex = 3;
            label2.Text = "Agregar Salida";
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.BackColor = Color.Orange;
            lblEntrada.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEntrada.Location = new Point(80, 301);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(191, 31);
            lblEntrada.TabIndex = 4;
            lblEntrada.Text = "Coches Entrando:";
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.BackColor = Color.Orange;
            lblSalida.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalida.Location = new Point(611, 302);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(186, 31);
            lblSalida.TabIndex = 5;
            lblSalida.Text = "Coches Saliendo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(404, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 132);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtCantidadVehiculos
            // 
            txtCantidadVehiculos.BackColor = SystemColors.MenuText;
            txtCantidadVehiculos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidadVehiculos.ForeColor = SystemColors.Menu;
            txtCantidadVehiculos.Location = new Point(80, 109);
            txtCantidadVehiculos.Name = "txtCantidadVehiculos";
            txtCantidadVehiculos.Size = new Size(125, 38);
            txtCantidadVehiculos.TabIndex = 7;
            // 
            // txtTiempoSemaforo
            // 
            txtTiempoSemaforo.BackColor = SystemColors.InfoText;
            txtTiempoSemaforo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTiempoSemaforo.ForeColor = SystemColors.Menu;
            txtTiempoSemaforo.Location = new Point(736, 110);
            txtTiempoSemaforo.Name = "txtTiempoSemaforo";
            txtTiempoSemaforo.Size = new Size(125, 38);
            txtTiempoSemaforo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Orange;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 75);
            label5.Name = "label5";
            label5.Size = new Size(242, 31);
            label5.TabIndex = 9;
            label5.Text = "Cantidad de Vehiculos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Orange;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(686, 76);
            label6.Name = "label6";
            label6.Size = new Size(230, 31);
            label6.TabIndex = 10;
            label6.Text = "Tiempo del semaforo";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(435, 204);
            button3.Name = "button3";
            button3.Size = new Size(56, 237);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(387, 61);
            button4.Name = "button4";
            button4.Size = new Size(154, 162);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = false;
            // 
            // listBoxcolaentrada
            // 
            listBoxcolaentrada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxcolaentrada.BackColor = SystemColors.InfoText;
            listBoxcolaentrada.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxcolaentrada.ForeColor = SystemColors.Menu;
            listBoxcolaentrada.FormattingEnabled = true;
            listBoxcolaentrada.ItemHeight = 25;
            listBoxcolaentrada.Location = new Point(80, 355);
            listBoxcolaentrada.Name = "listBoxcolaentrada";
            listBoxcolaentrada.Size = new Size(191, 104);
            listBoxcolaentrada.TabIndex = 13;
            // 
            // listBoxcolasalida
            // 
            listBoxcolasalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxcolasalida.BackColor = SystemColors.InfoText;
            listBoxcolasalida.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxcolasalida.ForeColor = SystemColors.Menu;
            listBoxcolasalida.FormattingEnabled = true;
            listBoxcolasalida.ItemHeight = 25;
            listBoxcolasalida.Location = new Point(611, 356);
            listBoxcolasalida.Name = "listBoxcolasalida";
            listBoxcolasalida.Size = new Size(186, 104);
            listBoxcolasalida.TabIndex = 14;
            // 
            // cmbUnidadTiempo
            // 
            cmbUnidadTiempo.BackColor = SystemColors.InfoText;
            cmbUnidadTiempo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUnidadTiempo.ForeColor = SystemColors.Menu;
            cmbUnidadTiempo.FormattingEnabled = true;
            cmbUnidadTiempo.Items.AddRange(new object[] { "Segundos", "Minutos" });
            cmbUnidadTiempo.Location = new Point(781, 154);
            cmbUnidadTiempo.Name = "cmbUnidadTiempo";
            cmbUnidadTiempo.Size = new Size(151, 39);
            cmbUnidadTiempo.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Orange;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(551, 157);
            label3.Name = "label3";
            label3.Size = new Size(229, 31);
            label3.TabIndex = 16;
            label3.Text = "Dimensional Tiempo:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(941, 504);
            Controls.Add(label3);
            Controls.Add(cmbUnidadTiempo);
            Controls.Add(listBoxcolasalida);
            Controls.Add(listBoxcolaentrada);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTiempoSemaforo);
            Controls.Add(txtCantidadVehiculos);
            Controls.Add(pictureBox1);
            Controls.Add(lblSalida);
            Controls.Add(lblEntrada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRACTICA 3 - SEMAFOROS - JULIO RUIZ - 1284719";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label lblEntrada;
        private Label lblSalida;
        private PictureBox pictureBox1;
        private TextBox txtCantidadVehiculos;
        private TextBox txtTiempoSemaforo;
        private Label label5;
        private Label label6;
        private Button button3;
        private Button button4;
        private ListBox listBoxcolaentrada;
        private ListBox listBoxcolasalida;
        private ComboBox cmbUnidadTiempo;
        private Label label3;
    }
}