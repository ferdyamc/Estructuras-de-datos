
namespace Estructura_de_datos
{
    partial class Pila
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblIdentificacion = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtSalarioDia = new System.Windows.Forms.TextBox();
            this.LblSalarioDia = new System.Windows.Forms.Label();
            this.TxtDiasLaborados = new System.Windows.Forms.TextBox();
            this.LblDiaLaborado = new System.Windows.Forms.Label();
            this.TxtDevengado = new System.Windows.Forms.TextBox();
            this.LblDevengado = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.DtgEmpleados = new System.Windows.Forms.DataGridView();
            this.EpvError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvError)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.BtnBack.Location = new System.Drawing.Point(667, 111);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(176, 29);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Regresar al menú";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Formulario para manejo de datos para la Pila";
            // 
            // LblIdentificacion
            // 
            this.LblIdentificacion.AutoSize = true;
            this.LblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdentificacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblIdentificacion.Location = new System.Drawing.Point(11, 158);
            this.LblIdentificacion.Name = "LblIdentificacion";
            this.LblIdentificacion.Size = new System.Drawing.Size(127, 20);
            this.LblIdentificacion.TabIndex = 11;
            this.LblIdentificacion.Text = "Identificación :";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(156, 157);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(126, 26);
            this.TxtIdentificacion.TabIndex = 12;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(156, 203);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(126, 26);
            this.TxtNombre.TabIndex = 14;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblNombre.Location = new System.Drawing.Point(11, 204);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(81, 20);
            this.LblNombre.TabIndex = 13;
            this.LblNombre.Text = "Nombre :";
            // 
            // TxtSalarioDia
            // 
            this.TxtSalarioDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalarioDia.Location = new System.Drawing.Point(156, 247);
            this.TxtSalarioDia.Name = "TxtSalarioDia";
            this.TxtSalarioDia.Size = new System.Drawing.Size(126, 26);
            this.TxtSalarioDia.TabIndex = 16;
            // 
            // LblSalarioDia
            // 
            this.LblSalarioDia.AutoSize = true;
            this.LblSalarioDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalarioDia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblSalarioDia.Location = new System.Drawing.Point(11, 248);
            this.LblSalarioDia.Name = "LblSalarioDia";
            this.LblSalarioDia.Size = new System.Drawing.Size(104, 20);
            this.LblSalarioDia.TabIndex = 15;
            this.LblSalarioDia.Text = "Salario día :";
            // 
            // TxtDiasLaborados
            // 
            this.TxtDiasLaborados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiasLaborados.Location = new System.Drawing.Point(156, 289);
            this.TxtDiasLaborados.Name = "TxtDiasLaborados";
            this.TxtDiasLaborados.Size = new System.Drawing.Size(126, 26);
            this.TxtDiasLaborados.TabIndex = 18;
            // 
            // LblDiaLaborado
            // 
            this.LblDiaLaborado.AutoSize = true;
            this.LblDiaLaborado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiaLaborado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblDiaLaborado.Location = new System.Drawing.Point(11, 290);
            this.LblDiaLaborado.Name = "LblDiaLaborado";
            this.LblDiaLaborado.Size = new System.Drawing.Size(139, 20);
            this.LblDiaLaborado.TabIndex = 17;
            this.LblDiaLaborado.Text = "Dias laborados :";
            // 
            // TxtDevengado
            // 
            this.TxtDevengado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtDevengado.Enabled = false;
            this.TxtDevengado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDevengado.Location = new System.Drawing.Point(156, 337);
            this.TxtDevengado.Name = "TxtDevengado";
            this.TxtDevengado.Size = new System.Drawing.Size(126, 26);
            this.TxtDevengado.TabIndex = 20;
            // 
            // LblDevengado
            // 
            this.LblDevengado.AutoSize = true;
            this.LblDevengado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDevengado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblDevengado.Location = new System.Drawing.Point(11, 338);
            this.LblDevengado.Name = "LblDevengado";
            this.LblDevengado.Size = new System.Drawing.Size(110, 20);
            this.LblDevengado.TabIndex = 19;
            this.LblDevengado.Text = "Devengado :";
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
            this.menuStrip1.Size = new System.Drawing.Size(855, 29);
            this.menuStrip1.TabIndex = 21;
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
            // DtgEmpleados
            // 
            this.DtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEmpleados.Location = new System.Drawing.Point(315, 158);
            this.DtgEmpleados.Name = "DtgEmpleados";
            this.DtgEmpleados.Size = new System.Drawing.Size(528, 206);
            this.DtgEmpleados.TabIndex = 22;
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
            this.label3.Location = new System.Drawing.Point(229, 10);
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
            this.panel2.Size = new System.Drawing.Size(855, 35);
            this.panel2.TabIndex = 23;
            // 
            // Pila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DtgEmpleados);
            this.Controls.Add(this.TxtDevengado);
            this.Controls.Add(this.LblDevengado);
            this.Controls.Add(this.TxtDiasLaborados);
            this.Controls.Add(this.LblDiaLaborado);
            this.Controls.Add(this.TxtSalarioDia);
            this.Controls.Add(this.LblSalarioDia);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.LblIdentificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pila";
            this.Text = "Administrar datos de la Pila";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvError)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblIdentificacion;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtSalarioDia;
        private System.Windows.Forms.Label LblSalarioDia;
        private System.Windows.Forms.TextBox TxtDiasLaborados;
        private System.Windows.Forms.Label LblDiaLaborado;
        private System.Windows.Forms.TextBox TxtDevengado;
        private System.Windows.Forms.Label LblDevengado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpRegistrar;
        private System.Windows.Forms.ToolStripMenuItem OpEliminar;
        private System.Windows.Forms.ToolStripMenuItem OpSalir;
        private System.Windows.Forms.DataGridView DtgEmpleados;
        private System.Windows.Forms.ErrorProvider EpvError;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}