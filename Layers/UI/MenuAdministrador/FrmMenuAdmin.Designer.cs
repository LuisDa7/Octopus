namespace Octopus.Layers.UI
{
    partial class FrmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuAdmin));
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnPlanilla = new System.Windows.Forms.Button();
            this.btnEnviarComp = new System.Windows.Forms.Button();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnHacerSolicitud = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnReporteFecha = new System.Windows.Forms.Button();
            this.btnReporteComp = new System.Windows.Forms.Button();
            this.btnReporteSolicitudes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMantenimento = new System.Windows.Forms.Button();
            this.timerVentana = new System.Windows.Forms.Timer(this.components);
            this.timerVentanaCerrar = new System.Windows.Forms.Timer(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarcas.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.ForeColor = System.Drawing.Color.White;
            this.btnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcas.Image")));
            this.btnMarcas.Location = new System.Drawing.Point(20, 63);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(145, 308);
            this.btnMarcas.TabIndex = 0;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnPlanilla
            // 
            this.btnPlanilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(194)))), ((int)(((byte)(85)))));
            this.btnPlanilla.Enabled = false;
            this.btnPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlanilla.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanilla.ForeColor = System.Drawing.Color.White;
            this.btnPlanilla.Image = ((System.Drawing.Image)(resources.GetObject("btnPlanilla.Image")));
            this.btnPlanilla.Location = new System.Drawing.Point(183, 63);
            this.btnPlanilla.Name = "btnPlanilla";
            this.btnPlanilla.Size = new System.Drawing.Size(145, 145);
            this.btnPlanilla.TabIndex = 1;
            this.btnPlanilla.Text = "Planilla";
            this.btnPlanilla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlanilla.UseVisualStyleBackColor = false;
            this.btnPlanilla.Click += new System.EventHandler(this.btnPlanilla_Click);
            // 
            // btnEnviarComp
            // 
            this.btnEnviarComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(194)))));
            this.btnEnviarComp.Enabled = false;
            this.btnEnviarComp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviarComp.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarComp.ForeColor = System.Drawing.Color.White;
            this.btnEnviarComp.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarComp.Image")));
            this.btnEnviarComp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnviarComp.Location = new System.Drawing.Point(183, 226);
            this.btnEnviarComp.Name = "btnEnviarComp";
            this.btnEnviarComp.Size = new System.Drawing.Size(308, 145);
            this.btnEnviarComp.TabIndex = 2;
            this.btnEnviarComp.Text = "Enviar Comprobantes";
            this.btnEnviarComp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnviarComp.UseVisualStyleBackColor = false;
            this.btnEnviarComp.Click += new System.EventHandler(this.btnEnviarComp_Click);
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.BackColor = System.Drawing.Color.Sienna;
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSolicitudes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitudes.ForeColor = System.Drawing.Color.White;
            this.btnSolicitudes.Image = ((System.Drawing.Image)(resources.GetObject("btnSolicitudes.Image")));
            this.btnSolicitudes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSolicitudes.Location = new System.Drawing.Point(709, 208);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(145, 145);
            this.btnSolicitudes.TabIndex = 3;
            this.btnSolicitudes.Text = "Revisar Solicitudes";
            this.btnSolicitudes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSolicitudes.UseVisualStyleBackColor = false;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // btnHacerSolicitud
            // 
            this.btnHacerSolicitud.BackColor = System.Drawing.Color.Orange;
            this.btnHacerSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHacerSolicitud.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnHacerSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btnHacerSolicitud.Image")));
            this.btnHacerSolicitud.Location = new System.Drawing.Point(546, 45);
            this.btnHacerSolicitud.Name = "btnHacerSolicitud";
            this.btnHacerSolicitud.Size = new System.Drawing.Size(308, 145);
            this.btnHacerSolicitud.TabIndex = 4;
            this.btnHacerSolicitud.Text = "Hacer Solicitud";
            this.btnHacerSolicitud.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHacerSolicitud.UseVisualStyleBackColor = false;
            this.btnHacerSolicitud.Click += new System.EventHandler(this.btnHacerSolicitud_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Brown;
            this.btnAnular.Enabled = false;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnular.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.Location = new System.Drawing.Point(346, 63);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(145, 145);
            this.btnAnular.TabIndex = 5;
            this.btnAnular.Text = "Anular Planilla";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(211)))), ((int)(((byte)(162)))));
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultas.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.Location = new System.Drawing.Point(534, 409);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(145, 145);
            this.btnConsultas.TabIndex = 6;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnReporteFecha
            // 
            this.btnReporteFecha.BackColor = System.Drawing.Color.Gray;
            this.btnReporteFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporteFecha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteFecha.ForeColor = System.Drawing.Color.White;
            this.btnReporteFecha.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteFecha.Image")));
            this.btnReporteFecha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporteFecha.Location = new System.Drawing.Point(183, 393);
            this.btnReporteFecha.Name = "btnReporteFecha";
            this.btnReporteFecha.Size = new System.Drawing.Size(145, 145);
            this.btnReporteFecha.TabIndex = 7;
            this.btnReporteFecha.Text = "Balance De Planillas";
            this.btnReporteFecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporteFecha.UseVisualStyleBackColor = false;
            this.btnReporteFecha.Click += new System.EventHandler(this.btnReporteFecha_Click);
            // 
            // btnReporteComp
            // 
            this.btnReporteComp.BackColor = System.Drawing.Color.White;
            this.btnReporteComp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporteComp.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteComp.ForeColor = System.Drawing.Color.Black;
            this.btnReporteComp.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteComp.Image")));
            this.btnReporteComp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporteComp.Location = new System.Drawing.Point(346, 393);
            this.btnReporteComp.Name = "btnReporteComp";
            this.btnReporteComp.Size = new System.Drawing.Size(145, 145);
            this.btnReporteComp.TabIndex = 8;
            this.btnReporteComp.Text = "Reporte De Comprobantes";
            this.btnReporteComp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporteComp.UseVisualStyleBackColor = false;
            this.btnReporteComp.Click += new System.EventHandler(this.btnReporteComp_Click);
            // 
            // btnReporteSolicitudes
            // 
            this.btnReporteSolicitudes.BackColor = System.Drawing.Color.Gold;
            this.btnReporteSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporteSolicitudes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteSolicitudes.ForeColor = System.Drawing.Color.Black;
            this.btnReporteSolicitudes.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteSolicitudes.Image")));
            this.btnReporteSolicitudes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporteSolicitudes.Location = new System.Drawing.Point(546, 208);
            this.btnReporteSolicitudes.Name = "btnReporteSolicitudes";
            this.btnReporteSolicitudes.Size = new System.Drawing.Size(145, 145);
            this.btnReporteSolicitudes.TabIndex = 9;
            this.btnReporteSolicitudes.Text = "Reporte De Solicitudes";
            this.btnReporteSolicitudes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporteSolicitudes.UseVisualStyleBackColor = false;
            this.btnReporteSolicitudes.Click += new System.EventHandler(this.btnReporteSolicitudes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Planilla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(542, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vacaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(530, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Consultar Planillas";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(697, 409);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(145, 145);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(693, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Salir Del Menú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(173, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Menú Administrador";
            // 
            // btnMantenimento
            // 
            this.btnMantenimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(60)))), ((int)(((byte)(186)))));
            this.btnMantenimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMantenimento.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimento.ForeColor = System.Drawing.Color.White;
            this.btnMantenimento.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimento.Image")));
            this.btnMantenimento.Location = new System.Drawing.Point(20, 393);
            this.btnMantenimento.Name = "btnMantenimento";
            this.btnMantenimento.Size = new System.Drawing.Size(145, 145);
            this.btnMantenimento.TabIndex = 16;
            this.btnMantenimento.Text = "Mantenimiento";
            this.btnMantenimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMantenimento.UseVisualStyleBackColor = false;
            this.btnMantenimento.Click += new System.EventHandler(this.btnMantenimento_Click);
            // 
            // timerVentana
            // 
            this.timerVentana.Interval = 30;
            this.timerVentana.Tick += new System.EventHandler(this.timerVentana_Tick);
            // 
            // timerVentanaCerrar
            // 
            this.timerVentanaCerrar.Interval = 30;
            this.timerVentanaCerrar.Tick += new System.EventHandler(this.timerVentanaCerrar_Tick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblNombre.Location = new System.Drawing.Point(216, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(24, 19);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "...";
            // 
            // FrmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 590);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnMantenimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReporteSolicitudes);
            this.Controls.Add(this.btnReporteComp);
            this.Controls.Add(this.btnReporteFecha);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnHacerSolicitud);
            this.Controls.Add(this.btnSolicitudes);
            this.Controls.Add(this.btnEnviarComp);
            this.Controls.Add(this.btnPlanilla);
            this.Controls.Add(this.btnMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnPlanilla;
        private System.Windows.Forms.Button btnEnviarComp;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnHacerSolicitud;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnReporteFecha;
        private System.Windows.Forms.Button btnReporteComp;
        private System.Windows.Forms.Button btnReporteSolicitudes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMantenimento;
        private System.Windows.Forms.Timer timerVentana;
        private System.Windows.Forms.Timer timerVentanaCerrar;
        private System.Windows.Forms.Label lblNombre;
    }
}