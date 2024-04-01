namespace Octopus.Layers.UI.Consultas
{
    partial class FrmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultas));
            this.dgvPlanilla = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReenviar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHVacaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalarioIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTPercep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTDeduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSalDol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.clmID,
            this.clmHoras,
            this.clmHVacaciones,
            this.clmSalarioIni,
            this.clmTPercep,
            this.clmTDeduc,
            this.clmSalario,
            this.ClmSalDol,
            this.clmFecha});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanilla.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanilla.Location = new System.Drawing.Point(9, 140);
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
            this.dgvPlanilla.Size = new System.Drawing.Size(798, 406);
            this.dgvPlanilla.TabIndex = 29;
            this.dgvPlanilla.SelectionChanged += new System.EventHandler(this.dgvPlanilla_SelectionChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(922, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 34);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(401, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Consultar planillas";
            // 
            // btnReenviar
            // 
            this.btnReenviar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReenviar.Enabled = false;
            this.btnReenviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReenviar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReenviar.ForeColor = System.Drawing.Color.White;
            this.btnReenviar.Image = ((System.Drawing.Image)(resources.GetObject("btnReenviar.Image")));
            this.btnReenviar.Location = new System.Drawing.Point(817, 361);
            this.btnReenviar.Name = "btnReenviar";
            this.btnReenviar.Size = new System.Drawing.Size(134, 185);
            this.btnReenviar.TabIndex = 38;
            this.btnReenviar.Text = "Reenviar";
            this.btnReenviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReenviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReenviar.UseVisualStyleBackColor = false;
            this.btnReenviar.Click += new System.EventHandler(this.btnReenviar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(817, 193);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(134, 162);
            this.btnFiltrar.TabIndex = 39;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(432, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Fecha hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(74, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fecha desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarFont = new System.Drawing.Font("Roboto", 15.75F);
            this.dtpHasta.CalendarMonthBackground = System.Drawing.Color.GhostWhite;
            this.dtpHasta.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Location = new System.Drawing.Point(436, 80);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(274, 33);
            this.dtpHasta.TabIndex = 41;
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.CalendarMonthBackground = System.Drawing.Color.GhostWhite;
            this.dtpDesde.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Location = new System.Drawing.Point(78, 80);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(274, 33);
            this.dtpDesde.TabIndex = 40;
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
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRestablecer.Enabled = false;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestablecer.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.ForeColor = System.Drawing.Color.White;
            this.btnRestablecer.Location = new System.Drawing.Point(817, 140);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(134, 47);
            this.btnRestablecer.TabIndex = 44;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // clmID
            // 
            this.clmID.FillWeight = 41.63052F;
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmHoras
            // 
            this.clmHoras.FillWeight = 51.02806F;
            this.clmHoras.HeaderText = "Horas";
            this.clmHoras.Name = "clmHoras";
            this.clmHoras.ReadOnly = true;
            // 
            // clmHVacaciones
            // 
            this.clmHVacaciones.FillWeight = 69.25647F;
            this.clmHVacaciones.HeaderText = "Horas Vacaciones";
            this.clmHVacaciones.Name = "clmHVacaciones";
            this.clmHVacaciones.ReadOnly = true;
            // 
            // clmSalarioIni
            // 
            this.clmSalarioIni.FillWeight = 149.6808F;
            this.clmSalarioIni.HeaderText = "SalarioInicial";
            this.clmSalarioIni.Name = "clmSalarioIni";
            this.clmSalarioIni.ReadOnly = true;
            // 
            // clmTPercep
            // 
            this.clmTPercep.FillWeight = 133.7762F;
            this.clmTPercep.HeaderText = "Total Percepciones";
            this.clmTPercep.Name = "clmTPercep";
            this.clmTPercep.ReadOnly = true;
            // 
            // clmTDeduc
            // 
            this.clmTDeduc.FillWeight = 136.3398F;
            this.clmTDeduc.HeaderText = "Total Deducciones";
            this.clmTDeduc.Name = "clmTDeduc";
            this.clmTDeduc.ReadOnly = true;
            // 
            // clmSalario
            // 
            this.clmSalario.FillWeight = 122.5195F;
            this.clmSalario.HeaderText = "SalarioFinal";
            this.clmSalario.Name = "clmSalario";
            this.clmSalario.ReadOnly = true;
            // 
            // ClmSalDol
            // 
            this.ClmSalDol.FillWeight = 88.92182F;
            this.ClmSalDol.HeaderText = "Salario Dolares";
            this.ClmSalDol.Name = "ClmSalDol";
            this.ClmSalDol.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.FillWeight = 85.31084F;
            this.clmFecha.HeaderText = "Fecha Pago";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(959, 556);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnReenviar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvPlanilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanilla;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReenviar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHVacaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalarioIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTPercep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTDeduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSalDol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
    }
}