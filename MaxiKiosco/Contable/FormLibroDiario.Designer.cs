
namespace MaxiKiosco.Contable
{
    partial class FormLibroDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibroDiario));
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimixar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LibroMayor = new System.Windows.Forms.Button();
            this.txt_N_asiento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_cerrarAsiento = new System.Windows.Forms.Button();
            this.txt_totalDebe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_totalHaber = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Transaccion = new System.Windows.Forms.ComboBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_detalleCuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TipoCuenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_RubroCuenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_agregarAsiento = new System.Windows.Forms.Button();
            this.txt_CodigoCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_cuenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_TipoCuenta = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_libroDiario = new System.Windows.Forms.DateTimePicker();
            this.dgv_LibroDiario = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LibroDiario)).BeginInit();
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
            this.btnVolver.Location = new System.Drawing.Point(21, 522);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(85, 34);
            this.btnVolver.TabIndex = 40;
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
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 56);
            this.panel1.TabIndex = 39;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(904, 7);
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
            this.btnMinimixar.Location = new System.Drawing.Point(866, 11);
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
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Libro Diario";
            // 
            // btn_LibroMayor
            // 
            this.btn_LibroMayor.Location = new System.Drawing.Point(794, 514);
            this.btn_LibroMayor.Name = "btn_LibroMayor";
            this.btn_LibroMayor.Size = new System.Drawing.Size(100, 36);
            this.btn_LibroMayor.TabIndex = 51;
            this.btn_LibroMayor.Text = "Ver mayores";
            this.btn_LibroMayor.UseVisualStyleBackColor = true;
            this.btn_LibroMayor.Click += new System.EventHandler(this.btn_LibroMayor_Click);
            // 
            // txt_N_asiento
            // 
            this.txt_N_asiento.Location = new System.Drawing.Point(335, 81);
            this.txt_N_asiento.Name = "txt_N_asiento";
            this.txt_N_asiento.Size = new System.Drawing.Size(68, 20);
            this.txt_N_asiento.TabIndex = 50;
            this.txt_N_asiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(194, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Nº de asientos de la fecha:";
            // 
            // btn_cerrarAsiento
            // 
            this.btn_cerrarAsiento.Location = new System.Drawing.Point(752, 348);
            this.btn_cerrarAsiento.Name = "btn_cerrarAsiento";
            this.btn_cerrarAsiento.Size = new System.Drawing.Size(100, 36);
            this.btn_cerrarAsiento.TabIndex = 48;
            this.btn_cerrarAsiento.Text = "Cerrar asiento";
            this.btn_cerrarAsiento.UseVisualStyleBackColor = true;
            this.btn_cerrarAsiento.Click += new System.EventHandler(this.btn_cerrarAsiento_Click);
            // 
            // txt_totalDebe
            // 
            this.txt_totalDebe.Location = new System.Drawing.Point(523, 532);
            this.txt_totalDebe.Name = "txt_totalDebe";
            this.txt_totalDebe.ReadOnly = true;
            this.txt_totalDebe.Size = new System.Drawing.Size(99, 20);
            this.txt_totalDebe.TabIndex = 47;
            this.txt_totalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(458, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "TOTALES:";
            // 
            // txt_totalHaber
            // 
            this.txt_totalHaber.Location = new System.Drawing.Point(628, 532);
            this.txt_totalHaber.Name = "txt_totalHaber";
            this.txt_totalHaber.ReadOnly = true;
            this.txt_totalHaber.Size = new System.Drawing.Size(94, 20);
            this.txt_totalHaber.TabIndex = 45;
            this.txt_totalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmb_Transaccion);
            this.groupBox3.Controls.Add(this.txt_monto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_detalleCuenta);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_TipoCuenta);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_RubroCuenta);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_agregarAsiento);
            this.groupBox3.Controls.Add(this.txt_CodigoCuenta);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(21, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 99);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(261, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Transacción:";
            // 
            // cmb_Transaccion
            // 
            this.cmb_Transaccion.FormattingEnabled = true;
            this.cmb_Transaccion.Location = new System.Drawing.Point(264, 64);
            this.cmb_Transaccion.Name = "cmb_Transaccion";
            this.cmb_Transaccion.Size = new System.Drawing.Size(106, 21);
            this.cmb_Transaccion.TabIndex = 19;
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(144, 65);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(68, 20);
            this.txt_monto.TabIndex = 18;
            this.txt_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(141, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Monto:";
            // 
            // txt_detalleCuenta
            // 
            this.txt_detalleCuenta.Location = new System.Drawing.Point(97, 20);
            this.txt_detalleCuenta.Name = "txt_detalleCuenta";
            this.txt_detalleCuenta.Size = new System.Drawing.Size(273, 20);
            this.txt_detalleCuenta.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(17, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Detalle Cuenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(141, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "(*) Si conoce la cuenta ingrese el nombre en DETALLE";
            // 
            // txt_TipoCuenta
            // 
            this.txt_TipoCuenta.Location = new System.Drawing.Point(585, 43);
            this.txt_TipoCuenta.Name = "txt_TipoCuenta";
            this.txt_TipoCuenta.ReadOnly = true;
            this.txt_TipoCuenta.Size = new System.Drawing.Size(110, 20);
            this.txt_TipoCuenta.TabIndex = 14;
            this.txt_TipoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(516, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo cuenta:";
            // 
            // txt_RubroCuenta
            // 
            this.txt_RubroCuenta.Location = new System.Drawing.Point(585, 69);
            this.txt_RubroCuenta.Name = "txt_RubroCuenta";
            this.txt_RubroCuenta.ReadOnly = true;
            this.txt_RubroCuenta.Size = new System.Drawing.Size(110, 20);
            this.txt_RubroCuenta.TabIndex = 12;
            this.txt_RubroCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(546, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rubro:";
            // 
            // btn_agregarAsiento
            // 
            this.btn_agregarAsiento.Location = new System.Drawing.Point(405, 66);
            this.btn_agregarAsiento.Name = "btn_agregarAsiento";
            this.btn_agregarAsiento.Size = new System.Drawing.Size(100, 25);
            this.btn_agregarAsiento.TabIndex = 4;
            this.btn_agregarAsiento.Text = "Agregar detalle";
            this.btn_agregarAsiento.UseVisualStyleBackColor = true;
            this.btn_agregarAsiento.Click += new System.EventHandler(this.btn_agregarAsiento_Click);
            // 
            // txt_CodigoCuenta
            // 
            this.txt_CodigoCuenta.Location = new System.Drawing.Point(585, 17);
            this.txt_CodigoCuenta.Name = "txt_CodigoCuenta";
            this.txt_CodigoCuenta.ReadOnly = true;
            this.txt_CodigoCuenta.Size = new System.Drawing.Size(68, 20);
            this.txt_CodigoCuenta.TabIndex = 10;
            this.txt_CodigoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(536, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_cuenta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbx_TipoCuenta);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(738, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 161);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "¿No recuerda la cuenta?";
            // 
            // cmb_cuenta
            // 
            this.cmb_cuenta.FormattingEnabled = true;
            this.cmb_cuenta.Location = new System.Drawing.Point(38, 114);
            this.cmb_cuenta.Name = "cmb_cuenta";
            this.cmb_cuenta.Size = new System.Drawing.Size(148, 21);
            this.cmb_cuenta.TabIndex = 10;
            this.cmb_cuenta.SelectedIndexChanged += new System.EventHandler(this.cmb_cuenta_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccione cuenta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(15, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Seleccione Tipo de cuenta :";
            // 
            // cbx_TipoCuenta
            // 
            this.cbx_TipoCuenta.FormattingEnabled = true;
            this.cbx_TipoCuenta.Location = new System.Drawing.Point(38, 56);
            this.cbx_TipoCuenta.Name = "cbx_TipoCuenta";
            this.cbx_TipoCuenta.Size = new System.Drawing.Size(148, 21);
            this.cbx_TipoCuenta.TabIndex = 6;
            this.cbx_TipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cbx_TipoCuenta_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_libroDiario);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(21, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 56);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar fecha";
            // 
            // dateTimePicker_libroDiario
            // 
            this.dateTimePicker_libroDiario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_libroDiario.Location = new System.Drawing.Point(22, 23);
            this.dateTimePicker_libroDiario.Name = "dateTimePicker_libroDiario";
            this.dateTimePicker_libroDiario.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker_libroDiario.TabIndex = 1;
            this.dateTimePicker_libroDiario.ValueChanged += new System.EventHandler(this.dateTimePicker_libroDiario_ValueChanged);
            // 
            // dgv_LibroDiario
            // 
            this.dgv_LibroDiario.AllowUserToAddRows = false;
            this.dgv_LibroDiario.AllowUserToDeleteRows = false;
            this.dgv_LibroDiario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_LibroDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LibroDiario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_LibroDiario.Location = new System.Drawing.Point(21, 232);
            this.dgv_LibroDiario.Name = "dgv_LibroDiario";
            this.dgv_LibroDiario.RowHeadersVisible = false;
            this.dgv_LibroDiario.Size = new System.Drawing.Size(703, 281);
            this.dgv_LibroDiario.TabIndex = 41;
            this.dgv_LibroDiario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LibroDiario_CellEndEdit);
            this.dgv_LibroDiario.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LibroDiario_CellEnter);
            // 
            // Column5
            // 
            this.Column5.FillWeight = 90F;
            this.Column5.HeaderText = "Nº ASIENTO";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "        CODIGO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "                        DETALLE  CUENTA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "           DEBE";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "        HABER";
            this.Column4.Name = "Column4";
            // 
            // FormLibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(961, 562);
            this.Controls.Add(this.btn_LibroMayor);
            this.Controls.Add(this.txt_N_asiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btn_cerrarAsiento);
            this.Controls.Add(this.txt_totalDebe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_totalHaber);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_LibroDiario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLibroDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLibroDiario";
            this.Load += new System.EventHandler(this.FormLibroDiario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LibroDiario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimixar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LibroMayor;
        private System.Windows.Forms.TextBox txt_N_asiento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_cerrarAsiento;
        private System.Windows.Forms.TextBox txt_totalDebe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_totalHaber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_Transaccion;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_detalleCuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TipoCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_RubroCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_agregarAsiento;
        private System.Windows.Forms.TextBox txt_CodigoCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_cuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbx_TipoCuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_libroDiario;
        private System.Windows.Forms.DataGridView dgv_LibroDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}