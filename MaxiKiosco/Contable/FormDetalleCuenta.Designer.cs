
namespace MaxiKiosco.Contable
{
    partial class FormDetalleCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleCuenta));
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimixar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totalDetalle = new System.Windows.Forms.TextBox();
            this.lbl_DetalleCuenta = new System.Windows.Forms.Label();
            this.dgv_detalleCuenta = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalleCuenta)).BeginInit();
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
            this.btnVolver.Location = new System.Drawing.Point(12, 59);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(85, 34);
            this.btnVolver.TabIndex = 44;
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
            this.panel1.Location = new System.Drawing.Point(-179, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 54);
            this.panel1.TabIndex = 43;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(682, 3);
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
            this.btnMinimixar.Location = new System.Drawing.Point(642, 9);
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
            this.label1.Location = new System.Drawing.Point(208, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Detalle de Cuentas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "TOTAL :";
            // 
            // txt_totalDetalle
            // 
            this.txt_totalDetalle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_totalDetalle.Location = new System.Drawing.Point(380, 337);
            this.txt_totalDetalle.Name = "txt_totalDetalle";
            this.txt_totalDetalle.ReadOnly = true;
            this.txt_totalDetalle.Size = new System.Drawing.Size(109, 20);
            this.txt_totalDetalle.TabIndex = 47;
            this.txt_totalDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_DetalleCuenta
            // 
            this.lbl_DetalleCuenta.AutoSize = true;
            this.lbl_DetalleCuenta.Location = new System.Drawing.Point(79, 135);
            this.lbl_DetalleCuenta.Name = "lbl_DetalleCuenta";
            this.lbl_DetalleCuenta.Size = new System.Drawing.Size(46, 13);
            this.lbl_DetalleCuenta.TabIndex = 46;
            this.lbl_DetalleCuenta.Text = "ACTIVO";
            // 
            // dgv_detalleCuenta
            // 
            this.dgv_detalleCuenta.AllowUserToAddRows = false;
            this.dgv_detalleCuenta.AllowUserToDeleteRows = false;
            this.dgv_detalleCuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detalleCuenta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_detalleCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalleCuenta.Enabled = false;
            this.dgv_detalleCuenta.Location = new System.Drawing.Point(73, 160);
            this.dgv_detalleCuenta.Name = "dgv_detalleCuenta";
            this.dgv_detalleCuenta.RowHeadersVisible = false;
            this.dgv_detalleCuenta.Size = new System.Drawing.Size(416, 160);
            this.dgv_detalleCuenta.TabIndex = 45;
            // 
            // FormDetalleCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_totalDetalle);
            this.Controls.Add(this.lbl_DetalleCuenta);
            this.Controls.Add(this.dgv_detalleCuenta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetalleCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetalleCuenta";
            this.Load += new System.EventHandler(this.FormDetalleCuenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalleCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimixar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totalDetalle;
        private System.Windows.Forms.Label lbl_DetalleCuenta;
        private System.Windows.Forms.DataGridView dgv_detalleCuenta;
    }
}