
namespace MaxiKiosco.Contable
{
    partial class FormBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBalance));
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimixar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_PNtotales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_PNeto2 = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txt_PmasPN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_INGRESOS = new System.Windows.Forms.TextBox();
            this.txt_ventas = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txt_IngreMenosVentas = new System.Windows.Forms.TextBox();
            this.txt_ResBruto = new System.Windows.Forms.TextBox();
            this.txt_resultadoEjercicio = new System.Windows.Forms.TextBox();
            this.txt_EgreMenosCVM = new System.Windows.Forms.TextBox();
            this.txt_CMV = new System.Windows.Forms.TextBox();
            this.txt_EGRESOS = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbx_fechas = new System.Windows.Forms.GroupBox();
            this.btn_verCompleto = new System.Windows.Forms.Button();
            this.btn_buscarBalance = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dttimep_inicialBalance = new System.Windows.Forms.DateTimePicker();
            this.dttimep_finalBalance = new System.Windows.Forms.DateTimePicker();
            this.txt_totalPN = new System.Windows.Forms.TextBox();
            this.txt_totalPasivo = new System.Windows.Forms.TextBox();
            this.txt_totalActivo = new System.Windows.Forms.TextBox();
            this.dgv_Pasivo = new System.Windows.Forms.DataGridView();
            this.dgv_Activo = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PNtotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PNeto2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbx_fechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Activo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(12, 439);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 39);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimixar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-12, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 50);
            this.panel1.TabIndex = 41;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(826, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(49, 42);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimixar
            // 
            this.btnMinimixar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimixar.FlatAppearance.BorderSize = 0;
            this.btnMinimixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimixar.ForeColor = System.Drawing.Color.White;
            this.btnMinimixar.Location = new System.Drawing.Point(793, 5);
            this.btnMinimixar.Name = "btnMinimixar";
            this.btnMinimixar.Size = new System.Drawing.Size(49, 42);
            this.btnMinimixar.TabIndex = 1;
            this.btnMinimixar.Text = "-";
            this.btnMinimixar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimixar.UseVisualStyleBackColor = false;
            this.btnMinimixar.Click += new System.EventHandler(this.btnMinimixar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Balance";
            // 
            // dgv_PNtotales
            // 
            this.dgv_PNtotales.AllowUserToAddRows = false;
            this.dgv_PNtotales.AllowUserToDeleteRows = false;
            this.dgv_PNtotales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PNtotales.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_PNtotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PNtotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_PNtotales.Enabled = false;
            this.dgv_PNtotales.Location = new System.Drawing.Point(405, 297);
            this.dgv_PNtotales.Name = "dgv_PNtotales";
            this.dgv_PNtotales.RowHeadersVisible = false;
            this.dgv_PNtotales.Size = new System.Drawing.Size(147, 74);
            this.dgv_PNtotales.TabIndex = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TOTAL";
            this.Column1.Name = "Column1";
            // 
            // dgv_PNeto2
            // 
            this.dgv_PNeto2.AllowUserToAddRows = false;
            this.dgv_PNeto2.AllowUserToDeleteRows = false;
            this.dgv_PNeto2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PNeto2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_PNeto2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PNeto2.Location = new System.Drawing.Point(278, 297);
            this.dgv_PNeto2.Name = "dgv_PNeto2";
            this.dgv_PNeto2.ReadOnly = true;
            this.dgv_PNeto2.RowHeadersVisible = false;
            this.dgv_PNeto2.Size = new System.Drawing.Size(120, 74);
            this.dgv_PNeto2.TabIndex = 59;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox7.Location = new System.Drawing.Point(278, 401);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(120, 20);
            this.textBox7.TabIndex = 58;
            this.textBox7.Text = "TOTAL P + PN";
            // 
            // txt_PmasPN
            // 
            this.txt_PmasPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_PmasPN.Location = new System.Drawing.Point(405, 401);
            this.txt_PmasPN.Name = "txt_PmasPN";
            this.txt_PmasPN.ReadOnly = true;
            this.txt_PmasPN.Size = new System.Drawing.Size(147, 20);
            this.txt_PmasPN.TabIndex = 57;
            this.txt_PmasPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(173, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "(*) Doble clic sobre el registro para ver detalles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_INGRESOS);
            this.groupBox1.Controls.Add(this.txt_ventas);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.txt_IngreMenosVentas);
            this.groupBox1.Controls.Add(this.txt_ResBruto);
            this.groupBox1.Controls.Add(this.txt_resultadoEjercicio);
            this.groupBox1.Controls.Add(this.txt_EgreMenosCVM);
            this.groupBox1.Controls.Add(this.txt_CMV);
            this.groupBox1.Controls.Add(this.txt_EGRESOS);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(558, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 362);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTADO DE RESULTADOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(6, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(6, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(210, 264);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(205, 192);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(205, 105);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(17, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "-";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox8.Location = new System.Drawing.Point(30, 82);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(115, 20);
            this.textBox8.TabIndex = 41;
            this.textBox8.Text = "VENTAS";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox10.Location = new System.Drawing.Point(30, 161);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(115, 20);
            this.textBox10.TabIndex = 44;
            this.textBox10.Text = "RES. BRUTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(40, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "(*) Doble clic sobre los textos  para ver detalles";
            // 
            // txt_INGRESOS
            // 
            this.txt_INGRESOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_INGRESOS.Location = new System.Drawing.Point(30, 232);
            this.txt_INGRESOS.Name = "txt_INGRESOS";
            this.txt_INGRESOS.ReadOnly = true;
            this.txt_INGRESOS.Size = new System.Drawing.Size(115, 20);
            this.txt_INGRESOS.TabIndex = 32;
            this.txt_INGRESOS.Text = "INGRESOS";
            this.txt_INGRESOS.DoubleClick += new System.EventHandler(this.txt_INGRESOS_DoubleClick);
            // 
            // txt_ventas
            // 
            this.txt_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_ventas.Location = new System.Drawing.Point(151, 82);
            this.txt_ventas.Name = "txt_ventas";
            this.txt_ventas.ReadOnly = true;
            this.txt_ventas.Size = new System.Drawing.Size(129, 20);
            this.txt_ventas.TabIndex = 39;
            this.txt_ventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox9.Location = new System.Drawing.Point(30, 326);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(115, 20);
            this.textBox9.TabIndex = 35;
            this.textBox9.Text = "RES. D. EJERCICIO";
            // 
            // txt_IngreMenosVentas
            // 
            this.txt_IngreMenosVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_IngreMenosVentas.Location = new System.Drawing.Point(151, 232);
            this.txt_IngreMenosVentas.Name = "txt_IngreMenosVentas";
            this.txt_IngreMenosVentas.ReadOnly = true;
            this.txt_IngreMenosVentas.Size = new System.Drawing.Size(129, 20);
            this.txt_IngreMenosVentas.TabIndex = 18;
            this.txt_IngreMenosVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ResBruto
            // 
            this.txt_ResBruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_ResBruto.Location = new System.Drawing.Point(152, 161);
            this.txt_ResBruto.Name = "txt_ResBruto";
            this.txt_ResBruto.ReadOnly = true;
            this.txt_ResBruto.Size = new System.Drawing.Size(129, 20);
            this.txt_ResBruto.TabIndex = 43;
            this.txt_ResBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_resultadoEjercicio
            // 
            this.txt_resultadoEjercicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_resultadoEjercicio.Location = new System.Drawing.Point(152, 326);
            this.txt_resultadoEjercicio.Name = "txt_resultadoEjercicio";
            this.txt_resultadoEjercicio.ReadOnly = true;
            this.txt_resultadoEjercicio.Size = new System.Drawing.Size(129, 20);
            this.txt_resultadoEjercicio.TabIndex = 34;
            this.txt_resultadoEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_EgreMenosCVM
            // 
            this.txt_EgreMenosCVM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_EgreMenosCVM.Location = new System.Drawing.Point(152, 300);
            this.txt_EgreMenosCVM.Name = "txt_EgreMenosCVM";
            this.txt_EgreMenosCVM.ReadOnly = true;
            this.txt_EgreMenosCVM.Size = new System.Drawing.Size(129, 20);
            this.txt_EgreMenosCVM.TabIndex = 23;
            this.txt_EgreMenosCVM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CMV
            // 
            this.txt_CMV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_CMV.Location = new System.Drawing.Point(152, 135);
            this.txt_CMV.Name = "txt_CMV";
            this.txt_CMV.ReadOnly = true;
            this.txt_CMV.Size = new System.Drawing.Size(129, 20);
            this.txt_CMV.TabIndex = 40;
            this.txt_CMV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_EGRESOS
            // 
            this.txt_EGRESOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_EGRESOS.Location = new System.Drawing.Point(30, 300);
            this.txt_EGRESOS.Name = "txt_EGRESOS";
            this.txt_EGRESOS.ReadOnly = true;
            this.txt_EGRESOS.Size = new System.Drawing.Size(115, 20);
            this.txt_EGRESOS.TabIndex = 33;
            this.txt_EGRESOS.Text = "EGRESOS";
            this.txt_EGRESOS.DoubleClick += new System.EventHandler(this.txt_EGRESOS_DoubleClick);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox14.Location = new System.Drawing.Point(30, 135);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(115, 20);
            this.textBox14.TabIndex = 42;
            this.textBox14.Text = "CMV";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox6.Location = new System.Drawing.Point(278, 146);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(274, 20);
            this.textBox6.TabIndex = 54;
            this.textBox6.Text = "PASIVO";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox5.Location = new System.Drawing.Point(278, 245);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(120, 20);
            this.textBox5.TabIndex = 53;
            this.textBox5.Text = "TOTAL PASIVO";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox4.Location = new System.Drawing.Point(17, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(255, 20);
            this.textBox4.TabIndex = 52;
            this.textBox4.Text = "ACTIVO";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.Location = new System.Drawing.Point(18, 401);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 51;
            this.textBox3.Text = "TOTAL ACTIVO";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(278, 271);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(274, 20);
            this.textBox2.TabIndex = 50;
            this.textBox2.Text = "PARIMONIO NETO";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(278, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 49;
            this.textBox1.Text = "TOTAL PN";
            // 
            // gbx_fechas
            // 
            this.gbx_fechas.Controls.Add(this.btn_verCompleto);
            this.gbx_fechas.Controls.Add(this.btn_buscarBalance);
            this.gbx_fechas.Controls.Add(this.label11);
            this.gbx_fechas.Controls.Add(this.label12);
            this.gbx_fechas.Controls.Add(this.dttimep_inicialBalance);
            this.gbx_fechas.Controls.Add(this.dttimep_finalBalance);
            this.gbx_fechas.Location = new System.Drawing.Point(12, 53);
            this.gbx_fechas.Name = "gbx_fechas";
            this.gbx_fechas.Size = new System.Drawing.Size(540, 73);
            this.gbx_fechas.TabIndex = 48;
            this.gbx_fechas.TabStop = false;
            // 
            // btn_verCompleto
            // 
            this.btn_verCompleto.Location = new System.Drawing.Point(425, 27);
            this.btn_verCompleto.Name = "btn_verCompleto";
            this.btn_verCompleto.Size = new System.Drawing.Size(91, 29);
            this.btn_verCompleto.TabIndex = 29;
            this.btn_verCompleto.Text = "Ver completo";
            this.btn_verCompleto.UseVisualStyleBackColor = true;
            this.btn_verCompleto.Click += new System.EventHandler(this.btn_verCompleto_Click);
            // 
            // btn_buscarBalance
            // 
            this.btn_buscarBalance.Location = new System.Drawing.Point(311, 27);
            this.btn_buscarBalance.Name = "btn_buscarBalance";
            this.btn_buscarBalance.Size = new System.Drawing.Size(91, 29);
            this.btn_buscarBalance.TabIndex = 28;
            this.btn_buscarBalance.Text = "Buscar";
            this.btn_buscarBalance.UseVisualStyleBackColor = true;
            this.btn_buscarBalance.Click += new System.EventHandler(this.btn_buscarBalance_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(175, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Hasta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(43, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Desde: ";
            // 
            // dttimep_inicialBalance
            // 
            this.dttimep_inicialBalance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttimep_inicialBalance.Location = new System.Drawing.Point(15, 29);
            this.dttimep_inicialBalance.Name = "dttimep_inicialBalance";
            this.dttimep_inicialBalance.Size = new System.Drawing.Size(113, 20);
            this.dttimep_inicialBalance.TabIndex = 2;
            // 
            // dttimep_finalBalance
            // 
            this.dttimep_finalBalance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttimep_finalBalance.Location = new System.Drawing.Point(151, 29);
            this.dttimep_finalBalance.Name = "dttimep_finalBalance";
            this.dttimep_finalBalance.Size = new System.Drawing.Size(113, 20);
            this.dttimep_finalBalance.TabIndex = 1;
            // 
            // txt_totalPN
            // 
            this.txt_totalPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_totalPN.Location = new System.Drawing.Point(404, 374);
            this.txt_totalPN.Name = "txt_totalPN";
            this.txt_totalPN.ReadOnly = true;
            this.txt_totalPN.Size = new System.Drawing.Size(148, 20);
            this.txt_totalPN.TabIndex = 47;
            this.txt_totalPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_totalPasivo
            // 
            this.txt_totalPasivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_totalPasivo.Location = new System.Drawing.Point(404, 245);
            this.txt_totalPasivo.Name = "txt_totalPasivo";
            this.txt_totalPasivo.ReadOnly = true;
            this.txt_totalPasivo.Size = new System.Drawing.Size(148, 20);
            this.txt_totalPasivo.TabIndex = 46;
            this.txt_totalPasivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_totalActivo
            // 
            this.txt_totalActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_totalActivo.Location = new System.Drawing.Point(134, 401);
            this.txt_totalActivo.Name = "txt_totalActivo";
            this.txt_totalActivo.ReadOnly = true;
            this.txt_totalActivo.Size = new System.Drawing.Size(139, 20);
            this.txt_totalActivo.TabIndex = 45;
            this.txt_totalActivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgv_Pasivo
            // 
            this.dgv_Pasivo.AllowUserToAddRows = false;
            this.dgv_Pasivo.AllowUserToDeleteRows = false;
            this.dgv_Pasivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Pasivo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Pasivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pasivo.Location = new System.Drawing.Point(278, 167);
            this.dgv_Pasivo.Name = "dgv_Pasivo";
            this.dgv_Pasivo.ReadOnly = true;
            this.dgv_Pasivo.RowHeadersVisible = false;
            this.dgv_Pasivo.Size = new System.Drawing.Size(274, 74);
            this.dgv_Pasivo.TabIndex = 44;
            this.dgv_Pasivo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pasivo_CellDoubleClick);
            // 
            // dgv_Activo
            // 
            this.dgv_Activo.AllowUserToAddRows = false;
            this.dgv_Activo.AllowUserToDeleteRows = false;
            this.dgv_Activo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Activo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Activo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Activo.Location = new System.Drawing.Point(17, 166);
            this.dgv_Activo.Name = "dgv_Activo";
            this.dgv_Activo.ReadOnly = true;
            this.dgv_Activo.RowHeadersVisible = false;
            this.dgv_Activo.Size = new System.Drawing.Size(255, 228);
            this.dgv_Activo.TabIndex = 43;
            this.dgv_Activo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Activo_CellDoubleClick);
            // 
            // FormBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(867, 489);
            this.Controls.Add(this.dgv_PNtotales);
            this.Controls.Add(this.dgv_PNeto2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txt_PmasPN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbx_fechas);
            this.Controls.Add(this.txt_totalPN);
            this.Controls.Add(this.txt_totalPasivo);
            this.Controls.Add(this.txt_totalActivo);
            this.Controls.Add(this.dgv_Pasivo);
            this.Controls.Add(this.dgv_Activo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBalance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PNtotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PNeto2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbx_fechas.ResumeLayout(false);
            this.gbx_fechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Activo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimixar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_PNtotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgv_PNeto2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txt_PmasPN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_INGRESOS;
        private System.Windows.Forms.TextBox txt_ventas;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txt_IngreMenosVentas;
        private System.Windows.Forms.TextBox txt_ResBruto;
        private System.Windows.Forms.TextBox txt_resultadoEjercicio;
        private System.Windows.Forms.TextBox txt_EgreMenosCVM;
        private System.Windows.Forms.TextBox txt_CMV;
        private System.Windows.Forms.TextBox txt_EGRESOS;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbx_fechas;
        private System.Windows.Forms.Button btn_verCompleto;
        private System.Windows.Forms.Button btn_buscarBalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dttimep_inicialBalance;
        private System.Windows.Forms.DateTimePicker dttimep_finalBalance;
        private System.Windows.Forms.TextBox txt_totalPN;
        private System.Windows.Forms.TextBox txt_totalPasivo;
        private System.Windows.Forms.TextBox txt_totalActivo;
        private System.Windows.Forms.DataGridView dgv_Pasivo;
        private System.Windows.Forms.DataGridView dgv_Activo;
    }
}