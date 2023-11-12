
namespace MaxiKiosco
{
    partial class formLibroDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLibroDiario));
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimixar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLibroDiario = new System.Windows.Forms.DataGridView();
            this.codCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCuentaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDebe = new System.Windows.Forms.Label();
            this.lblHaber = new System.Windows.Forms.Label();
            this.lblHola = new System.Windows.Forms.Label();
            this.btnAsiento = new System.Windows.Forms.Button();
            this.btnAgregarFila = new System.Windows.Forms.Button();
            this.dgvResumenAsientos = new System.Windows.Forms.DataGridView();
            this.NumAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibroDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenAsientos)).BeginInit();
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
            this.btnVolver.Location = new System.Drawing.Point(-1, 60);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(85, 35);
            this.btnVolver.TabIndex = 36;
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimixar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 57);
            this.panel1.TabIndex = 35;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(959, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(49, 42);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnMinimixar
            // 
            this.btnMinimixar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimixar.FlatAppearance.BorderSize = 0;
            this.btnMinimixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimixar.ForeColor = System.Drawing.Color.White;
            this.btnMinimixar.Location = new System.Drawing.Point(904, 11);
            this.btnMinimixar.Name = "btnMinimixar";
            this.btnMinimixar.Size = new System.Drawing.Size(49, 42);
            this.btnMinimixar.TabIndex = 1;
            this.btnMinimixar.Text = "-";
            this.btnMinimixar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimixar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Libro Diario";
            // 
            // dgvLibroDiario
            // 
            this.dgvLibroDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibroDiario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCuenta,
            this.TipoCuentaColumn,
            this.detalle,
            this.debe,
            this.haber});
            this.dgvLibroDiario.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvLibroDiario.Location = new System.Drawing.Point(34, 120);
            this.dgvLibroDiario.Name = "dgvLibroDiario";
            this.dgvLibroDiario.RowHeadersVisible = false;
            this.dgvLibroDiario.Size = new System.Drawing.Size(503, 150);
            this.dgvLibroDiario.TabIndex = 37;
            this.dgvLibroDiario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibroDiario_CellDoubleClick);
            this.dgvLibroDiario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibroDiario_CellEndEdit);
            this.dgvLibroDiario.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvLibroDiario_EditingControlShowing);
            // 
            // codCuenta
            // 
            this.codCuenta.HeaderText = "CodCuenta";
            this.codCuenta.Name = "codCuenta";
            // 
            // TipoCuentaColumn
            // 
            this.TipoCuentaColumn.HeaderText = "TipoCuenta";
            this.TipoCuentaColumn.Name = "TipoCuentaColumn";
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // debe
            // 
            this.debe.HeaderText = "Debe";
            this.debe.Name = "debe";
            // 
            // haber
            // 
            this.haber.HeaderText = "Haber";
            this.haber.Name = "haber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Total Debe: $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 27);
            this.label3.TabIndex = 38;
            this.label3.Text = "Total Haber: $";
            // 
            // lblDebe
            // 
            this.lblDebe.AutoSize = true;
            this.lblDebe.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebe.ForeColor = System.Drawing.Color.White;
            this.lblDebe.Location = new System.Drawing.Point(170, 379);
            this.lblDebe.Name = "lblDebe";
            this.lblDebe.Size = new System.Drawing.Size(25, 27);
            this.lblDebe.TabIndex = 39;
            this.lblDebe.Text = "0";
            // 
            // lblHaber
            // 
            this.lblHaber.AutoSize = true;
            this.lblHaber.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaber.ForeColor = System.Drawing.Color.White;
            this.lblHaber.Location = new System.Drawing.Point(170, 430);
            this.lblHaber.Name = "lblHaber";
            this.lblHaber.Size = new System.Drawing.Size(25, 27);
            this.lblHaber.TabIndex = 40;
            this.lblHaber.Text = "0";
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHola.ForeColor = System.Drawing.Color.White;
            this.lblHola.Location = new System.Drawing.Point(12, 493);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(162, 27);
            this.lblHola.TabIndex = 41;
            this.lblHola.Text = "Total Debe: $";
            // 
            // btnAsiento
            // 
            this.btnAsiento.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAsiento.FlatAppearance.BorderSize = 0;
            this.btnAsiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsiento.ForeColor = System.Drawing.Color.White;
            this.btnAsiento.Image = ((System.Drawing.Image)(resources.GetObject("btnAsiento.Image")));
            this.btnAsiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsiento.Location = new System.Drawing.Point(407, 276);
            this.btnAsiento.Name = "btnAsiento";
            this.btnAsiento.Size = new System.Drawing.Size(130, 34);
            this.btnAsiento.TabIndex = 42;
            this.btnAsiento.Text = "     Asiento";
            this.btnAsiento.UseVisualStyleBackColor = false;
            this.btnAsiento.Click += new System.EventHandler(this.btnAsiento_Click);
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarFila.FlatAppearance.BorderSize = 0;
            this.btnAgregarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFila.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFila.ForeColor = System.Drawing.Color.White;
            this.btnAgregarFila.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFila.Image")));
            this.btnAgregarFila.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarFila.Location = new System.Drawing.Point(543, 120);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(47, 34);
            this.btnAgregarFila.TabIndex = 43;
            this.btnAgregarFila.Text = "     Asiento";
            this.btnAgregarFila.UseVisualStyleBackColor = false;
            this.btnAgregarFila.Click += new System.EventHandler(this.btnAgregarFila_Click);
            // 
            // dgvResumenAsientos
            // 
            this.dgvResumenAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumAsiento,
            this.Fecha});
            this.dgvResumenAsientos.Location = new System.Drawing.Point(407, 333);
            this.dgvResumenAsientos.Name = "dgvResumenAsientos";
            this.dgvResumenAsientos.RowHeadersVisible = false;
            this.dgvResumenAsientos.Size = new System.Drawing.Size(567, 150);
            this.dgvResumenAsientos.TabIndex = 44;
            // 
            // NumAsiento
            // 
            this.NumAsiento.HeaderText = "NumAsiento";
            this.NumAsiento.Name = "NumAsiento";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // formLibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1019, 564);
            this.Controls.Add(this.dgvResumenAsientos);
            this.Controls.Add(this.btnAgregarFila);
            this.Controls.Add(this.btnAsiento);
            this.Controls.Add(this.lblHola);
            this.Controls.Add(this.lblHaber);
            this.Controls.Add(this.lblDebe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLibroDiario);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLibroDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLibroDiario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibroDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimixar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLibroDiario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDebe;
        private System.Windows.Forms.Label lblHaber;
        private System.Windows.Forms.Label lblHola;
        private System.Windows.Forms.Button btnAsiento;
        private System.Windows.Forms.Button btnAgregarFila;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCuentaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
        private System.Windows.Forms.DataGridView dgvResumenAsientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}