
namespace MaxiKiosco.Contable
{
    partial class FormConsultaLibroDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaLibroDiario));
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimixar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_fechas = new System.Windows.Forms.GroupBox();
            this.btn_verCompletoLdiario = new System.Windows.Forms.Button();
            this.btn_buscarLibroDiario = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dttimep_inicialLibroDiario = new System.Windows.Forms.DateTimePicker();
            this.dttimep_finalLibroDiario = new System.Windows.Forms.DateTimePicker();
            this.dgv_LibroDIario = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbx_fechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LibroDIario)).BeginInit();
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
            this.btnVolver.Location = new System.Drawing.Point(12, 57);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(85, 34);
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
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 52);
            this.panel1.TabIndex = 41;
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
            this.label1.Size = new System.Drawing.Size(247, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Consulta Libro Diario";
            // 
            // gbx_fechas
            // 
            this.gbx_fechas.Controls.Add(this.btn_verCompletoLdiario);
            this.gbx_fechas.Controls.Add(this.btn_buscarLibroDiario);
            this.gbx_fechas.Controls.Add(this.label11);
            this.gbx_fechas.Controls.Add(this.label12);
            this.gbx_fechas.Controls.Add(this.dttimep_inicialLibroDiario);
            this.gbx_fechas.Controls.Add(this.dttimep_finalLibroDiario);
            this.gbx_fechas.Location = new System.Drawing.Point(78, 107);
            this.gbx_fechas.Name = "gbx_fechas";
            this.gbx_fechas.Size = new System.Drawing.Size(746, 73);
            this.gbx_fechas.TabIndex = 48;
            this.gbx_fechas.TabStop = false;
            // 
            // btn_verCompletoLdiario
            // 
            this.btn_verCompletoLdiario.Location = new System.Drawing.Point(564, 22);
            this.btn_verCompletoLdiario.Name = "btn_verCompletoLdiario";
            this.btn_verCompletoLdiario.Size = new System.Drawing.Size(91, 29);
            this.btn_verCompletoLdiario.TabIndex = 29;
            this.btn_verCompletoLdiario.Text = "Ver completo";
            this.btn_verCompletoLdiario.UseVisualStyleBackColor = true;
            this.btn_verCompletoLdiario.Click += new System.EventHandler(this.btn_verCompletoLdiario_Click);
            // 
            // btn_buscarLibroDiario
            // 
            this.btn_buscarLibroDiario.Location = new System.Drawing.Point(422, 22);
            this.btn_buscarLibroDiario.Name = "btn_buscarLibroDiario";
            this.btn_buscarLibroDiario.Size = new System.Drawing.Size(91, 29);
            this.btn_buscarLibroDiario.TabIndex = 28;
            this.btn_buscarLibroDiario.Text = "Buscar";
            this.btn_buscarLibroDiario.UseVisualStyleBackColor = true;
            this.btn_buscarLibroDiario.Click += new System.EventHandler(this.btn_buscarLibroDiario_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(263, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Hasta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(131, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Desde: ";
            // 
            // dttimep_inicialLibroDiario
            // 
            this.dttimep_inicialLibroDiario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttimep_inicialLibroDiario.Location = new System.Drawing.Point(103, 31);
            this.dttimep_inicialLibroDiario.Name = "dttimep_inicialLibroDiario";
            this.dttimep_inicialLibroDiario.Size = new System.Drawing.Size(113, 20);
            this.dttimep_inicialLibroDiario.TabIndex = 2;
            // 
            // dttimep_finalLibroDiario
            // 
            this.dttimep_finalLibroDiario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttimep_finalLibroDiario.Location = new System.Drawing.Point(239, 31);
            this.dttimep_finalLibroDiario.Name = "dttimep_finalLibroDiario";
            this.dttimep_finalLibroDiario.Size = new System.Drawing.Size(113, 20);
            this.dttimep_finalLibroDiario.TabIndex = 1;
            // 
            // dgv_LibroDIario
            // 
            this.dgv_LibroDIario.AllowUserToAddRows = false;
            this.dgv_LibroDIario.AllowUserToDeleteRows = false;
            this.dgv_LibroDIario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LibroDIario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_LibroDIario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LibroDIario.Location = new System.Drawing.Point(78, 186);
            this.dgv_LibroDIario.Name = "dgv_LibroDIario";
            this.dgv_LibroDIario.ReadOnly = true;
            this.dgv_LibroDIario.RowHeadersVisible = false;
            this.dgv_LibroDIario.Size = new System.Drawing.Size(746, 322);
            this.dgv_LibroDIario.TabIndex = 47;
            // 
            // FormConsultaLibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(926, 544);
            this.Controls.Add(this.gbx_fechas);
            this.Controls.Add(this.dgv_LibroDIario);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaLibroDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaLibroDiario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbx_fechas.ResumeLayout(false);
            this.gbx_fechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LibroDIario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimixar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_fechas;
        private System.Windows.Forms.Button btn_verCompletoLdiario;
        private System.Windows.Forms.Button btn_buscarLibroDiario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dttimep_inicialLibroDiario;
        private System.Windows.Forms.DateTimePicker dttimep_finalLibroDiario;
        private System.Windows.Forms.DataGridView dgv_LibroDIario;
    }
}