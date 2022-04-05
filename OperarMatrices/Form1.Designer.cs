namespace OperarMatrices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_filas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_det1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.printPage_matriz = new System.Windows.Forms.TabPage();
            this.print_labelMatriz = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.print_labelMatrizT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_azar = new System.Windows.Forms.Button();
            this.button_manual = new System.Windows.Forms.Button();
            this.txt_columnas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_det2 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.print_labelMatriz2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.print_labelMatrizT2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_azar2 = new System.Windows.Forms.Button();
            this.button_manual2 = new System.Windows.Forms.Button();
            this.txt_columnas2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_filas2 = new System.Windows.Forms.TextBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.print_labelMatriz3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.print_labelMatrizT3 = new System.Windows.Forms.Label();
            this.button_calcular = new System.Windows.Forms.Button();
            this.label_det3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox_A = new System.Windows.Forms.ComboBox();
            this.comboBox_B = new System.Windows.Forms.ComboBox();
            this.comboBox_opc = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_matriz = new System.Windows.Forms.RadioButton();
            this.radioButton_cons = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton_A = new System.Windows.Forms.RadioButton();
            this.radioButton_B = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.printPage_matriz.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPERADOR DE MATRICES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de filas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operación a realizar:";
            // 
            // txt_filas
            // 
            this.txt_filas.AccessibleName = "txt_filas";
            this.txt_filas.Location = new System.Drawing.Point(129, 31);
            this.txt_filas.Name = "txt_filas";
            this.txt_filas.Size = new System.Drawing.Size(50, 20);
            this.txt_filas.TabIndex = 3;
            this.txt_filas.TextChanged += new System.EventHandler(this.txt_filas_TextChanged);
            this.txt_filas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filas_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_det1);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button_azar);
            this.groupBox1.Controls.Add(this.button_manual);
            this.groupBox1.Controls.Add(this.txt_columnas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_filas);
            this.groupBox1.Location = new System.Drawing.Point(32, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 403);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Matríz:";
            // 
            // label_det1
            // 
            this.label_det1.AutoSize = true;
            this.label_det1.Location = new System.Drawing.Point(20, 367);
            this.label_det1.Name = "label_det1";
            this.label_det1.Size = new System.Drawing.Size(73, 13);
            this.label_det1.TabIndex = 11;
            this.label_det1.Text = "Determinante:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.printPage_matriz);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 195);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(161, 158);
            this.tabControl1.TabIndex = 12;
            // 
            // printPage_matriz
            // 
            this.printPage_matriz.Controls.Add(this.print_labelMatriz);
            this.printPage_matriz.Location = new System.Drawing.Point(4, 22);
            this.printPage_matriz.Name = "printPage_matriz";
            this.printPage_matriz.Padding = new System.Windows.Forms.Padding(3);
            this.printPage_matriz.Size = new System.Drawing.Size(153, 132);
            this.printPage_matriz.TabIndex = 0;
            this.printPage_matriz.Text = "Normal";
            this.printPage_matriz.UseVisualStyleBackColor = true;
            // 
            // print_labelMatriz
            // 
            this.print_labelMatriz.AutoSize = true;
            this.print_labelMatriz.Location = new System.Drawing.Point(14, 16);
            this.print_labelMatriz.Name = "print_labelMatriz";
            this.print_labelMatriz.Size = new System.Drawing.Size(10, 13);
            this.print_labelMatriz.TabIndex = 7;
            this.print_labelMatriz.Text = ".";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.print_labelMatrizT);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(153, 132);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transpuesta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // print_labelMatrizT
            // 
            this.print_labelMatrizT.AutoSize = true;
            this.print_labelMatrizT.Location = new System.Drawing.Point(14, 16);
            this.print_labelMatrizT.Name = "print_labelMatrizT";
            this.print_labelMatrizT.Size = new System.Drawing.Size(10, 13);
            this.print_labelMatrizT.TabIndex = 6;
            this.print_labelMatrizT.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Llenar matríz de forma:";
            // 
            // button_azar
            // 
            this.button_azar.Location = new System.Drawing.Point(104, 128);
            this.button_azar.Name = "button_azar";
            this.button_azar.Size = new System.Drawing.Size(75, 23);
            this.button_azar.TabIndex = 8;
            this.button_azar.Text = "Aleatoria";
            this.button_azar.UseVisualStyleBackColor = true;
            this.button_azar.Click += new System.EventHandler(this.button_azar_Click);
            // 
            // button_manual
            // 
            this.button_manual.Location = new System.Drawing.Point(18, 128);
            this.button_manual.Name = "button_manual";
            this.button_manual.Size = new System.Drawing.Size(75, 23);
            this.button_manual.TabIndex = 7;
            this.button_manual.Text = "Manual";
            this.button_manual.UseVisualStyleBackColor = true;
            this.button_manual.Click += new System.EventHandler(this.button_manual_Click);
            // 
            // txt_columnas
            // 
            this.txt_columnas.AccessibleName = "txt_columnas";
            this.txt_columnas.Location = new System.Drawing.Point(128, 66);
            this.txt_columnas.Name = "txt_columnas";
            this.txt_columnas.Size = new System.Drawing.Size(50, 20);
            this.txt_columnas.TabIndex = 6;
            this.txt_columnas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_columnas_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Número de columnas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label_det2);
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button_azar2);
            this.groupBox2.Controls.Add(this.button_manual2);
            this.groupBox2.Controls.Add(this.txt_columnas2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_filas2);
            this.groupBox2.Location = new System.Drawing.Point(249, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 403);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Matríz:";
            // 
            // label_det2
            // 
            this.label_det2.AutoSize = true;
            this.label_det2.Location = new System.Drawing.Point(20, 367);
            this.label_det2.Name = "label_det2";
            this.label_det2.Size = new System.Drawing.Size(73, 13);
            this.label_det2.TabIndex = 11;
            this.label_det2.Text = "Determinante:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(18, 195);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(161, 158);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.print_labelMatriz2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(153, 132);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Normal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // print_labelMatriz2
            // 
            this.print_labelMatriz2.AutoSize = true;
            this.print_labelMatriz2.Location = new System.Drawing.Point(14, 16);
            this.print_labelMatriz2.Name = "print_labelMatriz2";
            this.print_labelMatriz2.Size = new System.Drawing.Size(10, 13);
            this.print_labelMatriz2.TabIndex = 7;
            this.print_labelMatriz2.Text = ".";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.print_labelMatrizT2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(153, 132);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Transpuesta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // print_labelMatrizT2
            // 
            this.print_labelMatrizT2.AutoSize = true;
            this.print_labelMatrizT2.Location = new System.Drawing.Point(14, 16);
            this.print_labelMatrizT2.Name = "print_labelMatrizT2";
            this.print_labelMatrizT2.Size = new System.Drawing.Size(10, 13);
            this.print_labelMatrizT2.TabIndex = 6;
            this.print_labelMatrizT2.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Llenar matríz de forma:";
            // 
            // button_azar2
            // 
            this.button_azar2.Location = new System.Drawing.Point(104, 128);
            this.button_azar2.Name = "button_azar2";
            this.button_azar2.Size = new System.Drawing.Size(75, 23);
            this.button_azar2.TabIndex = 8;
            this.button_azar2.Text = "Aleatoria";
            this.button_azar2.UseVisualStyleBackColor = true;
            this.button_azar2.Click += new System.EventHandler(this.button_azar2_Click);
            // 
            // button_manual2
            // 
            this.button_manual2.Location = new System.Drawing.Point(18, 128);
            this.button_manual2.Name = "button_manual2";
            this.button_manual2.Size = new System.Drawing.Size(75, 23);
            this.button_manual2.TabIndex = 7;
            this.button_manual2.Text = "Manual";
            this.button_manual2.UseVisualStyleBackColor = true;
            this.button_manual2.Click += new System.EventHandler(this.button_manual2_Click);
            // 
            // txt_columnas2
            // 
            this.txt_columnas2.AccessibleName = "txt_columnas";
            this.txt_columnas2.Location = new System.Drawing.Point(128, 66);
            this.txt_columnas2.Name = "txt_columnas2";
            this.txt_columnas2.Size = new System.Drawing.Size(50, 20);
            this.txt_columnas2.TabIndex = 6;
            this.txt_columnas2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_columnas2_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Número de columnas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Número de filas:";
            // 
            // txt_filas2
            // 
            this.txt_filas2.AccessibleName = "txt_filas";
            this.txt_filas2.Location = new System.Drawing.Point(129, 31);
            this.txt_filas2.Name = "txt_filas2";
            this.txt_filas2.Size = new System.Drawing.Size(50, 20);
            this.txt_filas2.TabIndex = 3;
            this.txt_filas2.TextChanged += new System.EventHandler(this.txt_filas2_TextChanged);
            this.txt_filas2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filas2_KeyPress);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Location = new System.Drawing.Point(473, 285);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(167, 116);
            this.tabControl3.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.print_labelMatriz3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(159, 90);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Normal";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // print_labelMatriz3
            // 
            this.print_labelMatriz3.AutoSize = true;
            this.print_labelMatriz3.Location = new System.Drawing.Point(13, 16);
            this.print_labelMatriz3.Name = "print_labelMatriz3";
            this.print_labelMatriz3.Size = new System.Drawing.Size(10, 13);
            this.print_labelMatriz3.TabIndex = 8;
            this.print_labelMatriz3.Text = ".";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.print_labelMatrizT3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(159, 90);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Traspuesta";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // print_labelMatrizT3
            // 
            this.print_labelMatrizT3.AutoSize = true;
            this.print_labelMatrizT3.Location = new System.Drawing.Point(13, 16);
            this.print_labelMatrizT3.Name = "print_labelMatrizT3";
            this.print_labelMatrizT3.Size = new System.Drawing.Size(10, 13);
            this.print_labelMatrizT3.TabIndex = 0;
            this.print_labelMatrizT3.Text = ".";
            // 
            // button_calcular
            // 
            this.button_calcular.Enabled = false;
            this.button_calcular.Location = new System.Drawing.Point(515, 247);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(83, 23);
            this.button_calcular.TabIndex = 11;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_det3
            // 
            this.label_det3.AutoSize = true;
            this.label_det3.Location = new System.Drawing.Point(474, 419);
            this.label_det3.Name = "label_det3";
            this.label_det3.Size = new System.Drawing.Size(73, 13);
            this.label_det3.TabIndex = 12;
            this.label_det3.Text = "Determinante:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(470, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "A:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(470, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "B:";
            // 
            // comboBox_A
            // 
            this.comboBox_A.Enabled = false;
            this.comboBox_A.FormattingEnabled = true;
            this.comboBox_A.Items.AddRange(new object[] {
            "Normal",
            "Transpuesta"});
            this.comboBox_A.Location = new System.Drawing.Point(506, 182);
            this.comboBox_A.Name = "comboBox_A";
            this.comboBox_A.Size = new System.Drawing.Size(121, 21);
            this.comboBox_A.TabIndex = 16;
            this.comboBox_A.Text = "Selecciona matríz";
            this.comboBox_A.SelectedIndexChanged += new System.EventHandler(this.comboBox_A_SelectedIndexChanged);
            // 
            // comboBox_B
            // 
            this.comboBox_B.Enabled = false;
            this.comboBox_B.FormattingEnabled = true;
            this.comboBox_B.Items.AddRange(new object[] {
            "Normal",
            "Transpuesta"});
            this.comboBox_B.Location = new System.Drawing.Point(506, 213);
            this.comboBox_B.Name = "comboBox_B";
            this.comboBox_B.Size = new System.Drawing.Size(121, 21);
            this.comboBox_B.TabIndex = 17;
            this.comboBox_B.Text = "Selecciona matríz";
            this.comboBox_B.SelectedIndexChanged += new System.EventHandler(this.comboBox_B_SelectedIndexChanged);
            // 
            // comboBox_opc
            // 
            this.comboBox_opc.Enabled = false;
            this.comboBox_opc.FormattingEnabled = true;
            this.comboBox_opc.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación"});
            this.comboBox_opc.Location = new System.Drawing.Point(473, 75);
            this.comboBox_opc.Name = "comboBox_opc";
            this.comboBox_opc.Size = new System.Drawing.Size(149, 21);
            this.comboBox_opc.TabIndex = 18;
            this.comboBox_opc.Text = "Seleccione una operación";
            this.comboBox_opc.SelectedIndexChanged += new System.EventHandler(this.comboBox_opc_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_matriz
            // 
            this.radioButton_matriz.AutoSize = true;
            this.radioButton_matriz.Enabled = false;
            this.radioButton_matriz.Location = new System.Drawing.Point(480, 128);
            this.radioButton_matriz.Name = "radioButton_matriz";
            this.radioButton_matriz.Size = new System.Drawing.Size(55, 17);
            this.radioButton_matriz.TabIndex = 20;
            this.radioButton_matriz.TabStop = true;
            this.radioButton_matriz.Text = "Matríz";
            this.radioButton_matriz.UseVisualStyleBackColor = true;
            this.radioButton_matriz.CheckedChanged += new System.EventHandler(this.radioButton_matriz_CheckedChanged);
            // 
            // radioButton_cons
            // 
            this.radioButton_cons.AutoSize = true;
            this.radioButton_cons.Enabled = false;
            this.radioButton_cons.Location = new System.Drawing.Point(541, 128);
            this.radioButton_cons.Name = "radioButton_cons";
            this.radioButton_cons.Size = new System.Drawing.Size(73, 17);
            this.radioButton_cons.TabIndex = 21;
            this.radioButton_cons.TabStop = true;
            this.radioButton_cons.Text = "Constante";
            this.radioButton_cons.UseVisualStyleBackColor = true;
            this.radioButton_cons.CheckedChanged += new System.EventHandler(this.radioButton_cons_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Matrices a operar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Operar por:";
            // 
            // radioButton_A
            // 
            this.radioButton_A.AutoSize = true;
            this.radioButton_A.Enabled = false;
            this.radioButton_A.Location = new System.Drawing.Point(486, 186);
            this.radioButton_A.Name = "radioButton_A";
            this.radioButton_A.Size = new System.Drawing.Size(14, 13);
            this.radioButton_A.TabIndex = 24;
            this.radioButton_A.TabStop = true;
            this.radioButton_A.UseVisualStyleBackColor = true;
            this.radioButton_A.CheckedChanged += new System.EventHandler(this.radioButton_A_CheckedChanged);
            // 
            // radioButton_B
            // 
            this.radioButton_B.AutoSize = true;
            this.radioButton_B.Enabled = false;
            this.radioButton_B.Location = new System.Drawing.Point(486, 217);
            this.radioButton_B.Name = "radioButton_B";
            this.radioButton_B.Size = new System.Drawing.Size(14, 13);
            this.radioButton_B.TabIndex = 25;
            this.radioButton_B.TabStop = true;
            this.radioButton_B.UseVisualStyleBackColor = true;
            this.radioButton_B.CheckedChanged += new System.EventHandler(this.radioButton_B_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 488);
            this.Controls.Add(this.radioButton_B);
            this.Controls.Add(this.radioButton_A);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton_cons);
            this.Controls.Add(this.radioButton_matriz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_opc);
            this.Controls.Add(this.label_det3);
            this.Controls.Add(this.comboBox_B);
            this.Controls.Add(this.comboBox_A);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caluladora de Matríces";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.printPage_matriz.ResumeLayout(false);
            this.printPage_matriz.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_filas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_columnas;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_azar;
        private System.Windows.Forms.Button button_manual;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage printPage_matriz;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_det1;
        private System.Windows.Forms.Label print_labelMatrizT;
        private System.Windows.Forms.Label print_labelMatriz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label print_labelMatriz2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label print_labelMatrizT2;
        private System.Windows.Forms.Label label_det2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_azar2;
        private System.Windows.Forms.Button button_manual2;
        private System.Windows.Forms.TextBox txt_columnas2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_filas2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label print_labelMatriz3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_det3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox_A;
        private System.Windows.Forms.ComboBox comboBox_B;
        private System.Windows.Forms.ComboBox comboBox_opc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label print_labelMatrizT3;
        private System.Windows.Forms.RadioButton radioButton_matriz;
        private System.Windows.Forms.RadioButton radioButton_cons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton_A;
        private System.Windows.Forms.RadioButton radioButton_B;
    }
}

