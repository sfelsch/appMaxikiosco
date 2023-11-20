
namespace MaxiKiosco.Contable
{
    partial class FormLibroMayor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibroMayor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimixar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.txt_subtHaber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_Saldos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_subtotoalDebe = new System.Windows.Forms.TextBox();
            this.txt_Sdeudor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_cuenta = new System.Windows.Forms.CheckBox();
            this.gbx_cuenta = new System.Windows.Forms.GroupBox();
            this.cbx_cuentaMayor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_TipoCuentaMayor = new System.Windows.Forms.ComboBox();
            this.txt_CodCuentaMayor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CuentaDMayor = new System.Windows.Forms.TextBox();
            this.checkBox_fecha = new System.Windows.Forms.CheckBox();
            this.btn_buscarMayor = new System.Windows.Forms.Button();
            this.gbx_fechas = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dttimep_inicialMayor = new System.Windows.Forms.DateTimePicker();
            this.dttimep_finalMayor = new System.Windows.Forms.DateTimePicker();
            this.dgv_libroMayor = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Saldos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbx_cuenta.SuspendLayout();
            this.gbx_fechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libroMayor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimixar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 48);
            this.panel1.TabIndex = 42;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(866, 2);
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
            this.btnMinimixar.Location = new System.Drawing.Point(818, 2);
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
            this.label1.Location = new System.Drawing.Point(36, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Libro Mayor";
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.AutoSize = true;
            this.lbl_Saldo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Saldo.Location = new System.Drawing.Point(560, 543);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(46, 13);
            this.lbl_Saldo.TabIndex = 51;
            this.lbl_Saldo.Text = "SALDO:";
            // 
            // txt_subtHaber
            // 
            this.txt_subtHaber.Location = new System.Drawing.Point(441, 540);
            this.txt_subtHaber.Name = "txt_subtHaber";
            this.txt_subtHaber.ReadOnly = true;
            this.txt_subtHaber.Size = new System.Drawing.Size(99, 20);
            this.txt_subtHaber.TabIndex = 50;
            this.txt_subtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(546, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 49;
            this.textBox1.Text = "SALDOS";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_Saldos
            // 
            this.dgv_Saldos.AllowUserToAddRows = false;
            this.dgv_Saldos.AllowUserToDeleteRows = false;
            this.dgv_Saldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Saldos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Saldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Saldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_Saldos.Location = new System.Drawing.Point(546, 240);
            this.dgv_Saldos.Name = "dgv_Saldos";
            this.dgv_Saldos.ReadOnly = true;
            this.dgv_Saldos.RowHeadersVisible = false;
            this.dgv_Saldos.Size = new System.Drawing.Size(223, 285);
            this.dgv_Saldos.TabIndex = 48;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S. DEUDOR";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "S. ACREEDOR";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txt_subtotoalDebe
            // 
            this.txt_subtotoalDebe.Location = new System.Drawing.Point(330, 540);
            this.txt_subtotoalDebe.Name = "txt_subtotoalDebe";
            this.txt_subtotoalDebe.ReadOnly = true;
            this.txt_subtotoalDebe.Size = new System.Drawing.Size(99, 20);
            this.txt_subtotoalDebe.TabIndex = 47;
            this.txt_subtotoalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Sdeudor
            // 
            this.txt_Sdeudor.Location = new System.Drawing.Point(670, 540);
            this.txt_Sdeudor.Name = "txt_Sdeudor";
            this.txt_Sdeudor.ReadOnly = true;
            this.txt_Sdeudor.Size = new System.Drawing.Size(99, 20);
            this.txt_Sdeudor.TabIndex = 46;
            this.txt_Sdeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(243, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "SUBTOTALES:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_cuenta);
            this.groupBox2.Controls.Add(this.gbx_cuenta);
            this.groupBox2.Controls.Add(this.checkBox_fecha);
            this.groupBox2.Controls.Add(this.btn_buscarMayor);
            this.groupBox2.Controls.Add(this.gbx_fechas);
            this.groupBox2.Location = new System.Drawing.Point(30, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 160);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de búsqueda";
            // 
            // checkBox_cuenta
            // 
            this.checkBox_cuenta.AutoSize = true;
            this.checkBox_cuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_cuenta.Location = new System.Drawing.Point(440, 19);
            this.checkBox_cuenta.Name = "checkBox_cuenta";
            this.checkBox_cuenta.Size = new System.Drawing.Size(78, 17);
            this.checkBox_cuenta.TabIndex = 28;
            this.checkBox_cuenta.Text = "Por cuenta";
            this.checkBox_cuenta.UseVisualStyleBackColor = true;
            this.checkBox_cuenta.CheckedChanged += new System.EventHandler(this.checkBox_cuenta_CheckedChanged);
            // 
            // gbx_cuenta
            // 
            this.gbx_cuenta.Controls.Add(this.cbx_cuentaMayor);
            this.gbx_cuenta.Controls.Add(this.label6);
            this.gbx_cuenta.Controls.Add(this.label2);
            this.gbx_cuenta.Controls.Add(this.label3);
            this.gbx_cuenta.Controls.Add(this.cbx_TipoCuentaMayor);
            this.gbx_cuenta.Controls.Add(this.txt_CodCuentaMayor);
            this.gbx_cuenta.Controls.Add(this.label4);
            this.gbx_cuenta.Controls.Add(this.txt_CuentaDMayor);
            this.gbx_cuenta.Enabled = false;
            this.gbx_cuenta.Location = new System.Drawing.Point(287, 38);
            this.gbx_cuenta.Name = "gbx_cuenta";
            this.gbx_cuenta.Size = new System.Drawing.Size(548, 86);
            this.gbx_cuenta.TabIndex = 27;
            this.gbx_cuenta.TabStop = false;
            // 
            // cbx_cuentaMayor
            // 
            this.cbx_cuentaMayor.FormattingEnabled = true;
            this.cbx_cuentaMayor.Location = new System.Drawing.Point(368, 15);
            this.cbx_cuentaMayor.Name = "cbx_cuentaMayor";
            this.cbx_cuentaMayor.Size = new System.Drawing.Size(148, 21);
            this.cbx_cuentaMayor.TabIndex = 27;
            this.cbx_cuentaMayor.SelectedIndexChanged += new System.EventHandler(this.cbx_cuentaMayor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(318, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Por cuenta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(318, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Còdigo:";
            // 
            // cbx_TipoCuentaMayor
            // 
            this.cbx_TipoCuentaMayor.FormattingEnabled = true;
            this.cbx_TipoCuentaMayor.Location = new System.Drawing.Point(153, 15);
            this.cbx_TipoCuentaMayor.Name = "cbx_TipoCuentaMayor";
            this.cbx_TipoCuentaMayor.Size = new System.Drawing.Size(148, 21);
            this.cbx_TipoCuentaMayor.TabIndex = 6;
            this.cbx_TipoCuentaMayor.SelectedIndexChanged += new System.EventHandler(this.cbx_TipoCuentaMayor_SelectedIndexChanged);
            // 
            // txt_CodCuentaMayor
            // 
            this.txt_CodCuentaMayor.Location = new System.Drawing.Point(367, 57);
            this.txt_CodCuentaMayor.Name = "txt_CodCuentaMayor";
            this.txt_CodCuentaMayor.ReadOnly = true;
            this.txt_CodCuentaMayor.Size = new System.Drawing.Size(66, 20);
            this.txt_CodCuentaMayor.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione Tipo de cuenta :";
            // 
            // txt_CuentaDMayor
            // 
            this.txt_CuentaDMayor.Location = new System.Drawing.Point(77, 54);
            this.txt_CuentaDMayor.Name = "txt_CuentaDMayor";
            this.txt_CuentaDMayor.Size = new System.Drawing.Size(227, 20);
            this.txt_CuentaDMayor.TabIndex = 7;
            // 
            // checkBox_fecha
            // 
            this.checkBox_fecha.AutoSize = true;
            this.checkBox_fecha.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_fecha.Location = new System.Drawing.Point(103, 22);
            this.checkBox_fecha.Name = "checkBox_fecha";
            this.checkBox_fecha.Size = new System.Drawing.Size(72, 17);
            this.checkBox_fecha.TabIndex = 26;
            this.checkBox_fecha.Text = "Por fecha";
            this.checkBox_fecha.UseVisualStyleBackColor = true;
            this.checkBox_fecha.CheckedChanged += new System.EventHandler(this.checkBox_fecha_CheckedChanged);
            // 
            // btn_buscarMayor
            // 
            this.btn_buscarMayor.Location = new System.Drawing.Point(734, 130);
            this.btn_buscarMayor.Name = "btn_buscarMayor";
            this.btn_buscarMayor.Size = new System.Drawing.Size(101, 23);
            this.btn_buscarMayor.TabIndex = 23;
            this.btn_buscarMayor.Text = "Buscar";
            this.btn_buscarMayor.UseVisualStyleBackColor = true;
            this.btn_buscarMayor.Click += new System.EventHandler(this.btn_buscarMayor_Click);
            // 
            // gbx_fechas
            // 
            this.gbx_fechas.Controls.Add(this.label5);
            this.gbx_fechas.Controls.Add(this.label8);
            this.gbx_fechas.Controls.Add(this.dttimep_inicialMayor);
            this.gbx_fechas.Controls.Add(this.dttimep_finalMayor);
            this.gbx_fechas.Enabled = false;
            this.gbx_fechas.Location = new System.Drawing.Point(6, 38);
            this.gbx_fechas.Name = "gbx_fechas";
            this.gbx_fechas.Size = new System.Drawing.Size(275, 86);
            this.gbx_fechas.TabIndex = 8;
            this.gbx_fechas.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(175, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(43, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Desde: ";
            // 
            // dttimep_inicialMayor
            // 
            this.dttimep_inicialMayor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttimep_inicialMayor.Location = new System.Drawing.Point(15, 29);
            this.dttimep_inicialMayor.Name = "dttimep_inicialMayor";
            this.dttimep_inicialMayor.Size = new System.Drawing.Size(113, 20);
            this.dttimep_inicialMayor.TabIndex = 2;
            // 
            // dttimep_finalMayor
            // 
            this.dttimep_finalMayor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttimep_finalMayor.Location = new System.Drawing.Point(151, 29);
            this.dttimep_finalMayor.Name = "dttimep_finalMayor";
            this.dttimep_finalMayor.Size = new System.Drawing.Size(113, 20);
            this.dttimep_finalMayor.TabIndex = 1;
            // 
            // dgv_libroMayor
            // 
            this.dgv_libroMayor.AllowUserToAddRows = false;
            this.dgv_libroMayor.AllowUserToDeleteRows = false;
            this.dgv_libroMayor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_libroMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_libroMayor.Location = new System.Drawing.Point(133, 240);
            this.dgv_libroMayor.Name = "dgv_libroMayor";
            this.dgv_libroMayor.ReadOnly = true;
            this.dgv_libroMayor.RowHeadersVisible = false;
            this.dgv_libroMayor.Size = new System.Drawing.Size(407, 285);
            this.dgv_libroMayor.TabIndex = 43;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(12, 530);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(85, 34);
            this.btnVolver.TabIndex = 52;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormLibroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(904, 569);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbl_Saldo);
            this.Controls.Add(this.txt_subtHaber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_Saldos);
            this.Controls.Add(this.txt_subtotoalDebe);
            this.Controls.Add(this.txt_Sdeudor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_libroMayor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLibroMayor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLibroMayor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Saldos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbx_cuenta.ResumeLayout(false);
            this.gbx_cuenta.PerformLayout();
            this.gbx_fechas.ResumeLayout(false);
            this.gbx_fechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libroMayor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimixar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.TextBox txt_subtHaber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_Saldos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txt_subtotoalDebe;
        private System.Windows.Forms.TextBox txt_Sdeudor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_cuenta;
        private System.Windows.Forms.GroupBox gbx_cuenta;
        private System.Windows.Forms.ComboBox cbx_cuentaMayor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_TipoCuentaMayor;
        private System.Windows.Forms.TextBox txt_CodCuentaMayor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CuentaDMayor;
        private System.Windows.Forms.CheckBox checkBox_fecha;
        private System.Windows.Forms.Button btn_buscarMayor;
        private System.Windows.Forms.GroupBox gbx_fechas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dttimep_inicialMayor;
        private System.Windows.Forms.DateTimePicker dttimep_finalMayor;
        private System.Windows.Forms.DataGridView dgv_libroMayor;
        private System.Windows.Forms.Button btnVolver;
    }
}