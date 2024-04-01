namespace Octopus.Layers.UI.Planilla
{
    partial class FrmPlanilla
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanilla));
            this.dgvPlanilla = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.clmColab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHorasV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalarioIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTPercep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTDeduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSalDol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanilla
            // 
            this.dgvPlanilla.AllowUserToAddRows = false;
            this.dgvPlanilla.AllowUserToDeleteRows = false;
            this.dgvPlanilla.AllowUserToResizeRows = false;
            this.dgvPlanilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanilla.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmColab,
            this.clmHoras,
            this.clmHorasV,
            this.clmSalarioIni,
            this.clmTPercep,
            this.clmTDeduc,
            this.clmSalario,
            this.clmTCambio,
            this.ClmSalDol});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanilla.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanilla.Location = new System.Drawing.Point(12, 95);
            this.dgvPlanilla.MultiSelect = false;
            this.dgvPlanilla.Name = "dgvPlanilla";
            this.dgvPlanilla.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlanilla.RowHeadersVisible = false;
            this.dgvPlanilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanilla.Size = new System.Drawing.Size(865, 453);
            this.dgvPlanilla.TabIndex = 28;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(992, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 34);
            this.btnCerrar.TabIndex = 34;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(421, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Calcular Planilla";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(194)))), ((int)(((byte)(85)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(890, 330);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 218);
            this.btnCalcular.TabIndex = 36;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHasta.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.ForeColor = System.Drawing.Color.PowderBlue;
            this.lblFechaHasta.Location = new System.Drawing.Point(455, 69);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(112, 23);
            this.lblFechaHasta.TabIndex = 42;
            this.lblFechaHasta.Text = "Fecha hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDesde.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.PowderBlue;
            this.lblFechaDesde.Location = new System.Drawing.Point(38, 69);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(118, 23);
            this.lblFechaDesde.TabIndex = 41;
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOrdenar.Enabled = false;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.White;
            this.btnOrdenar.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenar.Image")));
            this.btnOrdenar.Location = new System.Drawing.Point(890, 95);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(125, 218);
            this.btnOrdenar.TabIndex = 43;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // clmColab
            // 
            this.clmColab.FillWeight = 129.2861F;
            this.clmColab.HeaderText = "Colaborador";
            this.clmColab.Name = "clmColab";
            this.clmColab.ReadOnly = true;
            // 
            // clmHoras
            // 
            this.clmHoras.FillWeight = 43.80325F;
            this.clmHoras.HeaderText = "Horas";
            this.clmHoras.Name = "clmHoras";
            this.clmHoras.ReadOnly = true;
            // 
            // clmHorasV
            // 
            this.clmHorasV.FillWeight = 43.29013F;
            this.clmHorasV.HeaderText = "Horas vacaciones";
            this.clmHorasV.Name = "clmHorasV";
            this.clmHorasV.ReadOnly = true;
            // 
            // clmSalarioIni
            // 
            this.clmSalarioIni.FillWeight = 127.5392F;
            this.clmSalarioIni.HeaderText = "SalarioInicial";
            this.clmSalarioIni.Name = "clmSalarioIni";
            this.clmSalarioIni.ReadOnly = true;
            // 
            // clmTPercep
            // 
            this.clmTPercep.FillWeight = 129.2861F;
            this.clmTPercep.HeaderText = "Total Percepciones";
            this.clmTPercep.Name = "clmTPercep";
            this.clmTPercep.ReadOnly = true;
            // 
            // clmTDeduc
            // 
            this.clmTDeduc.FillWeight = 129.2861F;
            this.clmTDeduc.HeaderText = "Total Deducciones";
            this.clmTDeduc.Name = "clmTDeduc";
            this.clmTDeduc.ReadOnly = true;
            // 
            // clmSalario
            // 
            this.clmSalario.FillWeight = 90.81319F;
            this.clmSalario.HeaderText = "SalarioFinal";
            this.clmSalario.Name = "clmSalario";
            this.clmSalario.ReadOnly = true;
            // 
            // clmTCambio
            // 
            this.clmTCambio.FillWeight = 61.63897F;
            this.clmTCambio.HeaderText = "Tipo de Cambio";
            this.clmTCambio.Name = "clmTCambio";
            this.clmTCambio.ReadOnly = true;
            // 
            // ClmSalDol
            // 
            this.ClmSalDol.FillWeight = 82.5641F;
            this.ClmSalDol.HeaderText = "Salario Dolares";
            this.ClmSalDol.Name = "ClmSalDol";
            this.ClmSalDol.ReadOnly = true;
            // 
            // FrmPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1027, 560);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvPlanilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPlanilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planilla";
            this.Load += new System.EventHandler(this.FrmPlanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanilla;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColab;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHorasV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalarioIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTPercep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTDeduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSalDol;
    }
}