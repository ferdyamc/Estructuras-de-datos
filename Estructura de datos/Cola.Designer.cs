
namespace Estructura_de_datos
{
    partial class Cola
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.DtgEmpleadosCola = new System.Windows.Forms.DataGridView();
            this.TxtSalarioAsignado = new System.Windows.Forms.TextBox();
            this.LblSalarioAsignado = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.LblIdentificacion = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.DttFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.EpvError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmpleadosCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvError)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Formulario para manejo de datos para la Cola";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpRegistrar,
            this.OpEliminar,
            this.OpSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 29);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpRegistrar
            // 
            this.OpRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OpRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpRegistrar.Name = "OpRegistrar";
            this.OpRegistrar.Size = new System.Drawing.Size(85, 25);
            this.OpRegistrar.Text = "Registrar";
            this.OpRegistrar.Click += new System.EventHandler(this.OpRegistrar_Click);
            // 
            // OpEliminar
            // 
            this.OpEliminar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OpEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpEliminar.Name = "OpEliminar";
            this.OpEliminar.Size = new System.Drawing.Size(79, 25);
            this.OpEliminar.Text = "Eliminar";
            this.OpEliminar.Click += new System.EventHandler(this.OpEliminar_Click);
            // 
            // OpSalir
            // 
            this.OpSalir.BackColor = System.Drawing.Color.DarkRed;
            this.OpSalir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OpSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpSalir.Name = "OpSalir";
            this.OpSalir.Size = new System.Drawing.Size(53, 25);
            this.OpSalir.Text = "Salir";
            this.OpSalir.Click += new System.EventHandler(this.OpSalir_Click);
            // 
            // DtgEmpleadosCola
            // 
            this.DtgEmpleadosCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEmpleadosCola.Location = new System.Drawing.Point(408, 158);
            this.DtgEmpleadosCola.Name = "DtgEmpleadosCola";
            this.DtgEmpleadosCola.Size = new System.Drawing.Size(449, 206);
            this.DtgEmpleadosCola.TabIndex = 30;
            // 
            // TxtSalarioAsignado
            // 
            this.TxtSalarioAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalarioAsignado.Location = new System.Drawing.Point(171, 248);
            this.TxtSalarioAsignado.Name = "TxtSalarioAsignado";
            this.TxtSalarioAsignado.Size = new System.Drawing.Size(215, 26);
            this.TxtSalarioAsignado.TabIndex = 29;
            // 
            // LblSalarioAsignado
            // 
            this.LblSalarioAsignado.AutoSize = true;
            this.LblSalarioAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalarioAsignado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblSalarioAsignado.Location = new System.Drawing.Point(12, 248);
            this.LblSalarioAsignado.Name = "LblSalarioAsignado";
            this.LblSalarioAsignado.Size = new System.Drawing.Size(155, 20);
            this.LblSalarioAsignado.TabIndex = 28;
            this.LblSalarioAsignado.Text = "Salario Asignado :";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(171, 204);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(215, 26);
            this.TxtNombre.TabIndex = 27;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblNombre.Location = new System.Drawing.Point(12, 204);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(81, 20);
            this.LblNombre.TabIndex = 26;
            this.LblNombre.Text = "Nombre :";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(171, 158);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(215, 26);
            this.TxtIdentificacion.TabIndex = 25;
            // 
            // LblIdentificacion
            // 
            this.LblIdentificacion.AutoSize = true;
            this.LblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdentificacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblIdentificacion.Location = new System.Drawing.Point(12, 158);
            this.LblIdentificacion.Name = "LblIdentificacion";
            this.LblIdentificacion.Size = new System.Drawing.Size(127, 20);
            this.LblIdentificacion.TabIndex = 24;
            this.LblIdentificacion.Text = "Identificación :";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Blue;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBack.FlatAppearance.BorderSize = 2;
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBack.Location = new System.Drawing.Point(704, 110);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(153, 29);
            this.BtnBack.TabIndex = 23;
            this.BtnBack.Text = "Regresar al menú";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DttFecha
            // 
            this.DttFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DttFecha.Location = new System.Drawing.Point(101, 297);
            this.DttFecha.Name = "DttFecha";
            this.DttFecha.Size = new System.Drawing.Size(285, 26);
            this.DttFecha.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha :";
            // 
            // EpvError
            // 
            this.EpvError.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(236, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desarrollado por Ferdy Andrés Marulanda Carvajal 2022";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 35);
            this.panel2.TabIndex = 33;
            // 
            // Cola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DttFecha);
            this.Controls.Add(this.DtgEmpleadosCola);
            this.Controls.Add(this.TxtSalarioAsignado);
            this.Controls.Add(this.LblSalarioAsignado);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.LblIdentificacion);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Cola";
            this.Text = "Administrar datos de la Cola";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmpleadosCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvError)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpRegistrar;
        private System.Windows.Forms.ToolStripMenuItem OpEliminar;
        private System.Windows.Forms.ToolStripMenuItem OpSalir;
        private System.Windows.Forms.DataGridView DtgEmpleadosCola;
        private System.Windows.Forms.TextBox TxtSalarioAsignado;
        private System.Windows.Forms.Label LblSalarioAsignado;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label LblIdentificacion;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DateTimePicker DttFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider EpvError;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}