
namespace MaxiKiosco.Contable
{
    partial class FormCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCuentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimixar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Baja = new System.Windows.Forms.GroupBox();
            this.btn_ELiminar = new System.Windows.Forms.Button();
            this.txt_CuentaELiminar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_CuentaMod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.txt_cuentaSelec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cuentas = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Cuentas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AgregarCuenta = new System.Windows.Forms.Button();
            this.txt_nuevaCuenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_RubroAgregar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_CuentaAgregar = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_TipoCuentaBuscar = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.Baja.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Cuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cuentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.btnVolver.Location = new System.Drawing.Point(12, 74);
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
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 59);
            this.panel1.TabIndex = 39;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(861, 7);
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
            this.btnMinimixar.Location = new System.Drawing.Point(806, 7);
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
            this.label1.Text = "Cuentas";
            // 
            // Baja
            // 
            this.Baja.Controls.Add(this.btn_ELiminar);
            this.Baja.Controls.Add(this.txt_CuentaELiminar);
            this.Baja.Controls.Add(this.label8);
            this.Baja.ForeColor = System.Drawing.SystemColors.Control;
            this.Baja.Location = new System.Drawing.Point(550, 431);
            this.Baja.Name = "Baja";
            this.Baja.Size = new System.Drawing.Size(350, 93);
            this.Baja.TabIndex = 45;
            this.Baja.TabStop = false;
            this.Baja.Text = "Baja";
            // 
            // btn_ELiminar
            // 
            this.btn_ELiminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ELiminar.Location = new System.Drawing.Point(250, 44);
            this.btn_ELiminar.Name = "btn_ELiminar";
            this.btn_ELiminar.Size = new System.Drawing.Size(86, 33);
            this.btn_ELiminar.TabIndex = 13;
            this.btn_ELiminar.Text = "Eliminar";
            this.btn_ELiminar.UseVisualStyleBackColor = true;
            this.btn_ELiminar.Click += new System.EventHandler(this.btn_ELiminar_Click);
            // 
            // txt_CuentaELiminar
            // 
            this.txt_CuentaELiminar.Location = new System.Drawing.Point(18, 51);
            this.txt_CuentaELiminar.Name = "txt_CuentaELiminar";
            this.txt_CuentaELiminar.ReadOnly = true;
            this.txt_CuentaELiminar.Size = new System.Drawing.Size(208, 20);
            this.txt_CuentaELiminar.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(15, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cuenta Seleccionada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_CuentaMod);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_Modificar);
            this.groupBox3.Controls.Add(this.txt_cuentaSelec);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(552, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 151);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificación";
            // 
            // txt_CuentaMod
            // 
            this.txt_CuentaMod.Location = new System.Drawing.Point(18, 100);
            this.txt_CuentaMod.Name = "txt_CuentaMod";
            this.txt_CuentaMod.Size = new System.Drawing.Size(208, 20);
            this.txt_CuentaMod.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(15, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nueva cuenta:";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Modificar.Location = new System.Drawing.Point(250, 93);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(86, 33);
            this.btn_Modificar.TabIndex = 13;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txt_cuentaSelec
            // 
            this.txt_cuentaSelec.Location = new System.Drawing.Point(18, 51);
            this.txt_cuentaSelec.Name = "txt_cuentaSelec";
            this.txt_cuentaSelec.ReadOnly = true;
            this.txt_cuentaSelec.Size = new System.Drawing.Size(208, 20);
            this.txt_cuentaSelec.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cuenta Seleccionada";
            // 
            // Cuentas
            // 
            this.Cuentas.Controls.Add(this.label7);
            this.Cuentas.Controls.Add(this.dgv_Cuentas);
            this.Cuentas.ForeColor = System.Drawing.SystemColors.Control;
            this.Cuentas.Location = new System.Drawing.Point(16, 197);
            this.Cuentas.Name = "Cuentas";
            this.Cuentas.Size = new System.Drawing.Size(530, 327);
            this.Cuentas.TabIndex = 43;
            this.Cuentas.TabStop = false;
            this.Cuentas.Text = "Cuentas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(151, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "(*) Doble clic sobre el registro para Baja/modificación";
            // 
            // dgv_Cuentas
            // 
            this.dgv_Cuentas.AllowUserToAddRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgv_Cuentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Cuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Cuentas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cuentas.Location = new System.Drawing.Point(6, 44);
            this.dgv_Cuentas.Name = "dgv_Cuentas";
            this.dgv_Cuentas.ReadOnly = true;
            this.dgv_Cuentas.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgv_Cuentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Cuentas.Size = new System.Drawing.Size(522, 267);
            this.dgv_Cuentas.TabIndex = 10;
            this.dgv_Cuentas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cuentas_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AgregarCuenta);
            this.groupBox1.Controls.Add(this.txt_nuevaCuenta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_RubroAgregar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_CuentaAgregar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(552, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 141);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de cuenta";
            // 
            // btn_AgregarCuenta
            // 
            this.btn_AgregarCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AgregarCuenta.Location = new System.Drawing.Point(250, 93);
            this.btn_AgregarCuenta.Name = "btn_AgregarCuenta";
            this.btn_AgregarCuenta.Size = new System.Drawing.Size(86, 33);
            this.btn_AgregarCuenta.TabIndex = 13;
            this.btn_AgregarCuenta.Text = "Agregar";
            this.btn_AgregarCuenta.UseVisualStyleBackColor = true;
            this.btn_AgregarCuenta.Click += new System.EventHandler(this.btn_AgregarCuenta_Click);
            // 
            // txt_nuevaCuenta
            // 
            this.txt_nuevaCuenta.Location = new System.Drawing.Point(18, 100);
            this.txt_nuevaCuenta.Name = "txt_nuevaCuenta";
            this.txt_nuevaCuenta.Size = new System.Drawing.Size(208, 20);
            this.txt_nuevaCuenta.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(15, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nueva cuenta:";
            // 
            // cmb_RubroAgregar
            // 
            this.cmb_RubroAgregar.FormattingEnabled = true;
            this.cmb_RubroAgregar.Location = new System.Drawing.Point(184, 56);
            this.cmb_RubroAgregar.Name = "cmb_RubroAgregar";
            this.cmb_RubroAgregar.Size = new System.Drawing.Size(148, 21);
            this.cmb_RubroAgregar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(181, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccione rubro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione Tipo de cuenta :";
            // 
            // cmb_CuentaAgregar
            // 
            this.cmb_CuentaAgregar.FormattingEnabled = true;
            this.cmb_CuentaAgregar.Location = new System.Drawing.Point(18, 56);
            this.cmb_CuentaAgregar.Name = "cmb_CuentaAgregar";
            this.cmb_CuentaAgregar.Size = new System.Drawing.Size(148, 21);
            this.cmb_CuentaAgregar.TabIndex = 6;
            this.cmb_CuentaAgregar.SelectedIndexChanged += new System.EventHandler(this.cmb_CuentaAgregar_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmb_TipoCuentaBuscar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(16, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 64);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta de cuentas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(25, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Seleccione Tipo de cuenta :";
            // 
            // cmb_TipoCuentaBuscar
            // 
            this.cmb_TipoCuentaBuscar.FormattingEnabled = true;
            this.cmb_TipoCuentaBuscar.Location = new System.Drawing.Point(184, 26);
            this.cmb_TipoCuentaBuscar.Name = "cmb_TipoCuentaBuscar";
            this.cmb_TipoCuentaBuscar.Size = new System.Drawing.Size(148, 21);
            this.cmb_TipoCuentaBuscar.TabIndex = 6;
            this.cmb_TipoCuentaBuscar.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoCuentaBuscar_SelectedIndexChanged);
            // 
            // FormCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(924, 547);
            this.Controls.Add(this.Baja);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Cuentas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCuentas";
            this.Load += new System.EventHandler(this.FormCuentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Baja.ResumeLayout(false);
            this.Baja.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Cuentas.ResumeLayout(false);
            this.Cuentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cuentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimixar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Baja;
        private System.Windows.Forms.Button btn_ELiminar;
        private System.Windows.Forms.TextBox txt_CuentaELiminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_CuentaMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox txt_cuentaSelec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Cuentas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_Cuentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AgregarCuenta;
        private System.Windows.Forms.TextBox txt_nuevaCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_RubroAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_CuentaAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_TipoCuentaBuscar;
    }
}