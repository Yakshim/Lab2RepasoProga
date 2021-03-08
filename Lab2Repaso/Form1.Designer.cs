
namespace Lab2Repaso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGWVehiculos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxVK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonVh = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxPlaca = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxKilometros = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerDv = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePickerAl = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DGWClientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.labelRCliente = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxNit = new System.Windows.Forms.ComboBox();
            this.labelRVh = new System.Windows.Forms.Label();
            this.labelRAlquiler = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGWAlquiler = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAlquiler = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWVehiculos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 460);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(855, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonRefresh);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.DGWClientes);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.DGWVehiculos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(855, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingreso de Alquiler";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // DGWVehiculos
            // 
            this.DGWVehiculos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGWVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWVehiculos.Location = new System.Drawing.Point(16, 35);
            this.DGWVehiculos.Name = "DGWVehiculos";
            this.DGWVehiculos.Size = new System.Drawing.Size(455, 150);
            this.DGWVehiculos.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelRVh);
            this.groupBox1.Controls.Add(this.buttonVh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxVK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMarca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPlaca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(91, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculos";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(126, 65);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlaca.TabIndex = 0;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(126, 103);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(100, 22);
            this.textBoxMarca.TabIndex = 1;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(126, 141);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(100, 22);
            this.textBoxModelo.TabIndex = 2;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(126, 178);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 22);
            this.textBoxColor.TabIndex = 3;
            // 
            // textBoxVK
            // 
            this.textBoxVK.Location = new System.Drawing.Point(126, 215);
            this.textBoxVK.Name = "textBoxVK";
            this.textBoxVK.Size = new System.Drawing.Size(100, 22);
            this.textBoxVK.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(79, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(75, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(68, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(81, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(20, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Kilometros:";
            // 
            // buttonVh
            // 
            this.buttonVh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVh.Location = new System.Drawing.Point(126, 259);
            this.buttonVh.Name = "buttonVh";
            this.buttonVh.Size = new System.Drawing.Size(100, 30);
            this.buttonVh.TabIndex = 10;
            this.buttonVh.Text = "Ingresar";
            this.buttonVh.UseVisualStyleBackColor = true;
            this.buttonVh.Click += new System.EventHandler(this.buttonVh_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(13, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Vehiculos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelRAlquiler);
            this.groupBox3.Controls.Add(this.comboBoxNit);
            this.groupBox3.Controls.Add(this.comboBoxPlaca);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxKilometros);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dateTimePickerDv);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.dateTimePickerAl);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(510, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 365);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alquileres";
            // 
            // comboBoxPlaca
            // 
            this.comboBoxPlaca.FormattingEnabled = true;
            this.comboBoxPlaca.Location = new System.Drawing.Point(149, 96);
            this.comboBoxPlaca.Name = "comboBoxPlaca";
            this.comboBoxPlaca.Size = new System.Drawing.Size(100, 24);
            this.comboBoxPlaca.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(149, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ingresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(11, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Kilometros Recorridos:";
            // 
            // textBoxKilometros
            // 
            this.textBoxKilometros.Location = new System.Drawing.Point(149, 212);
            this.textBoxKilometros.Name = "textBoxKilometros";
            this.textBoxKilometros.Size = new System.Drawing.Size(100, 22);
            this.textBoxKilometros.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(35, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "Fecha Devolución:";
            // 
            // dateTimePickerDv
            // 
            this.dateTimePickerDv.Location = new System.Drawing.Point(149, 171);
            this.dateTimePickerDv.Name = "dateTimePickerDv";
            this.dateTimePickerDv.Size = new System.Drawing.Size(100, 22);
            this.dateTimePickerDv.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(55, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Fecha Alquiler:";
            // 
            // dateTimePickerAl
            // 
            this.dateTimePickerAl.Location = new System.Drawing.Point(149, 136);
            this.dateTimePickerAl.Name = "dateTimePickerAl";
            this.dateTimePickerAl.Size = new System.Drawing.Size(100, 22);
            this.dateTimePickerAl.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(102, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 15);
            this.label16.TabIndex = 17;
            this.label16.Text = "Placa:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(118, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "Nit:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(13, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Clientes Existentes";
            // 
            // DGWClientes
            // 
            this.DGWClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGWClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGWClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGWClientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGWClientes.Location = new System.Drawing.Point(13, 219);
            this.DGWClientes.Name = "DGWClientes";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGWClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGWClientes.Size = new System.Drawing.Size(455, 150);
            this.DGWClientes.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRCliente);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxDireccion);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxNit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(451, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 365);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(126, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(58, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Direccion:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(126, 141);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 22);
            this.textBoxDireccion.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(65, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(126, 103);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(95, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nit:";
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(126, 65);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(100, 22);
            this.textBoxNit.TabIndex = 0;
            // 
            // labelRCliente
            // 
            this.labelRCliente.AutoSize = true;
            this.labelRCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelRCliente.Location = new System.Drawing.Point(74, 273);
            this.labelRCliente.Name = "labelRCliente";
            this.labelRCliente.Size = new System.Drawing.Size(0, 16);
            this.labelRCliente.TabIndex = 11;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.Red;
            this.buttonRefresh.Location = new System.Drawing.Point(184, 384);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(97, 34);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Mostrar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxNit
            // 
            this.comboBoxNit.FormattingEnabled = true;
            this.comboBoxNit.Location = new System.Drawing.Point(149, 55);
            this.comboBoxNit.Name = "comboBoxNit";
            this.comboBoxNit.Size = new System.Drawing.Size(100, 24);
            this.comboBoxNit.TabIndex = 22;
            // 
            // labelRVh
            // 
            this.labelRVh.AutoSize = true;
            this.labelRVh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelRVh.Location = new System.Drawing.Point(81, 302);
            this.labelRVh.Name = "labelRVh";
            this.labelRVh.Size = new System.Drawing.Size(0, 16);
            this.labelRVh.TabIndex = 11;
            // 
            // labelRAlquiler
            // 
            this.labelRAlquiler.AutoSize = true;
            this.labelRAlquiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelRAlquiler.Location = new System.Drawing.Point(77, 307);
            this.labelRAlquiler.Name = "labelRAlquiler";
            this.labelRAlquiler.Size = new System.Drawing.Size(0, 16);
            this.labelRAlquiler.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAlquiler);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.DGWAlquiler);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(855, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultar Alquileres";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGWAlquiler
            // 
            this.DGWAlquiler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGWAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWAlquiler.Location = new System.Drawing.Point(34, 52);
            this.DGWAlquiler.Name = "DGWAlquiler";
            this.DGWAlquiler.Size = new System.Drawing.Size(492, 179);
            this.DGWAlquiler.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(207, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vehiculos en Alquiler";
            // 
            // buttonAlquiler
            // 
            this.buttonAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlquiler.ForeColor = System.Drawing.Color.Red;
            this.buttonAlquiler.Location = new System.Drawing.Point(547, 128);
            this.buttonAlquiler.Name = "buttonAlquiler";
            this.buttonAlquiler.Size = new System.Drawing.Size(98, 39);
            this.buttonAlquiler.TabIndex = 7;
            this.buttonAlquiler.Text = "Consultar";
            this.buttonAlquiler.UseVisualStyleBackColor = true;
            this.buttonAlquiler.Click += new System.EventHandler(this.buttonAlquiler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 484);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Alquiler de Vehiculos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWVehiculos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWAlquiler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGWVehiculos;
        private System.Windows.Forms.Button buttonVh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxPlaca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxKilometros;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerDv;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePickerAl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DGWClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.Label labelRCliente;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ComboBox comboBoxNit;
        private System.Windows.Forms.Label labelRVh;
        private System.Windows.Forms.Label labelRAlquiler;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonAlquiler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGWAlquiler;
    }
}

