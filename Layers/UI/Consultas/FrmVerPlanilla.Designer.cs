namespace Octopus.Layers.UI.Consultas
{
    partial class FrmVerPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerPlanilla));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombrePlanilla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColab = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSalIni = new System.Windows.Forms.Label();
            this.lblTotPercep = new System.Windows.Forms.Label();
            this.lblTotDeduc = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblFinalDol = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(803, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 34);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDescripcion,
            this.ClmTipo,
            this.clmMonto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalles.Location = new System.Drawing.Point(36, 147);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(466, 385);
            this.dgvDetalles.TabIndex = 32;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.FillWeight = 122.5195F;
            this.clmDescripcion.HeaderText = "Descripción";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            // 
            // ClmTipo
            // 
            this.ClmTipo.FillWeight = 88.92182F;
            this.ClmTipo.HeaderText = "Tipo";
            this.ClmTipo.Name = "ClmTipo";
            this.ClmTipo.ReadOnly = true;
            // 
            // clmMonto
            // 
            this.clmMonto.FillWeight = 85.31084F;
            this.clmMonto.HeaderText = "Monto";
            this.clmMonto.Name = "clmMonto";
            this.clmMonto.ReadOnly = true;
            // 
            // lblNombrePlanilla
            // 
            this.lblNombrePlanilla.AutoSize = true;
            this.lblNombrePlanilla.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePlanilla.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlanilla.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblNombrePlanilla.Location = new System.Drawing.Point(349, 9);
            this.lblNombrePlanilla.Name = "lblNombrePlanilla";
            this.lblNombrePlanilla.Size = new System.Drawing.Size(85, 19);
            this.lblNombrePlanilla.TabIndex = 33;
            this.lblNombrePlanilla.Text = "Planilla del";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(42, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Detalles";
            // 
            // lblColab
            // 
            this.lblColab.AutoSize = true;
            this.lblColab.BackColor = System.Drawing.Color.Transparent;
            this.lblColab.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColab.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblColab.Location = new System.Drawing.Point(27, 49);
            this.lblColab.Name = "lblColab";
            this.lblColab.Size = new System.Drawing.Size(109, 19);
            this.lblColab.TabIndex = 35;
            this.lblColab.Text = "Colaborador";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.BackColor = System.Drawing.Color.Transparent;
            this.lblHoras.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblHoras.Location = new System.Drawing.Point(28, 84);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(48, 18);
            this.lblHoras.TabIndex = 36;
            this.lblHoras.Text = "Horas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(583, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Salario Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(583, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Total de percepciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(583, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Total de deducciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(583, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Salario final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumPurple;
            this.label6.Location = new System.Drawing.Point(583, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Salario final en dólares";
            // 
            // lblSalIni
            // 
            this.lblSalIni.AutoSize = true;
            this.lblSalIni.BackColor = System.Drawing.Color.Transparent;
            this.lblSalIni.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalIni.ForeColor = System.Drawing.Color.Silver;
            this.lblSalIni.Location = new System.Drawing.Point(594, 84);
            this.lblSalIni.Name = "lblSalIni";
            this.lblSalIni.Size = new System.Drawing.Size(122, 19);
            this.lblSalIni.TabIndex = 42;
            this.lblSalIni.Text = "Salario Inicial";
            // 
            // lblTotPercep
            // 
            this.lblTotPercep.AutoSize = true;
            this.lblTotPercep.BackColor = System.Drawing.Color.Transparent;
            this.lblTotPercep.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotPercep.ForeColor = System.Drawing.Color.LightGreen;
            this.lblTotPercep.Location = new System.Drawing.Point(594, 174);
            this.lblTotPercep.Name = "lblTotPercep";
            this.lblTotPercep.Size = new System.Drawing.Size(122, 19);
            this.lblTotPercep.TabIndex = 43;
            this.lblTotPercep.Text = "Salario Inicial";
            // 
            // lblTotDeduc
            // 
            this.lblTotDeduc.AutoSize = true;
            this.lblTotDeduc.BackColor = System.Drawing.Color.Transparent;
            this.lblTotDeduc.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotDeduc.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTotDeduc.Location = new System.Drawing.Point(594, 261);
            this.lblTotDeduc.Name = "lblTotDeduc";
            this.lblTotDeduc.Size = new System.Drawing.Size(122, 19);
            this.lblTotDeduc.TabIndex = 44;
            this.lblTotDeduc.Text = "Salario Inicial";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.ForeColor = System.Drawing.Color.White;
            this.lblFinal.Location = new System.Drawing.Point(594, 352);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(112, 19);
            this.lblFinal.TabIndex = 45;
            this.lblFinal.Text = "Salario Final";
            // 
            // lblFinalDol
            // 
            this.lblFinalDol.AutoSize = true;
            this.lblFinalDol.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalDol.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDol.ForeColor = System.Drawing.Color.White;
            this.lblFinalDol.Location = new System.Drawing.Point(594, 509);
            this.lblFinalDol.Name = "lblFinalDol";
            this.lblFinalDol.Size = new System.Drawing.Size(134, 19);
            this.lblFinalDol.TabIndex = 46;
            this.lblFinalDol.Text = "Salario Dolares";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoCambio.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCambio.ForeColor = System.Drawing.Color.White;
            this.lblTipoCambio.Location = new System.Drawing.Point(594, 435);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(129, 19);
            this.lblTipoCambio.TabIndex = 48;
            this.lblTipoCambio.Text = "tipo de cambio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumPurple;
            this.label8.Location = new System.Drawing.Point(583, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "Tipo de cambio";
            // 
            // FrmVerPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(839, 563);
            this.Controls.Add(this.lblTipoCambio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFinalDol);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblTotDeduc);
            this.Controls.Add(this.lblTotPercep);
            this.Controls.Add(this.lblSalIni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblColab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombrePlanilla);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVerPlanilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planilla";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonto;
        private System.Windows.Forms.Label lblNombrePlanilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColab;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSalIni;
        private System.Windows.Forms.Label lblTotPercep;
        private System.Windows.Forms.Label lblTotDeduc;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblFinalDol;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Label label8;
    }
}