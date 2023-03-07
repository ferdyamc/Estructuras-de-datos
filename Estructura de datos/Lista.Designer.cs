
namespace Estructura_de_datos
{
    partial class Lista
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblRaza = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.CmbRaza = new System.Windows.Forms.ComboBox();
            this.DtgLista = new System.Windows.Forms.DataGridView();
            this.TlsOpciones = new System.Windows.Forms.ToolStrip();
            this.TlsRegistrar = new System.Windows.Forms.ToolStripLabel();
            this.TlsConsultar = new System.Windows.Forms.ToolStripLabel();
            this.TlsEliminar = new System.Windows.Forms.ToolStripLabel();
            this.TlsSalir = new System.Windows.Forms.ToolStripLabel();
            this.EpvError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLista)).BeginInit();
            this.TlsOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpvError)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Formulario para manejo de datos para la Lista";
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
            this.BtnBack.Location = new System.Drawing.Point(550, 89);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(176, 29);
            this.BtnBack.TabIndex = 11;
            this.BtnBack.Text = "Regresar al menú";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TxtEdad
            // 
            this.TxtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdad.Location = new System.Drawing.Point(101, 225);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(243, 26);
            this.TxtEdad.TabIndex = 35;
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblEdad.Location = new System.Drawing.Point(12, 225);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(61, 20);
            this.LblEdad.TabIndex = 34;
            this.LblEdad.Text = "Edad :";
            // 
            // LblRaza
            // 
            this.LblRaza.AutoSize = true;
            this.LblRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRaza.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblRaza.Location = new System.Drawing.Point(12, 181);
            this.LblRaza.Name = "LblRaza";
            this.LblRaza.Size = new System.Drawing.Size(61, 20);
            this.LblRaza.TabIndex = 32;
            this.LblRaza.Text = "Raza :";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(101, 135);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(243, 26);
            this.TxtNombre.TabIndex = 31;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblNombre.Location = new System.Drawing.Point(12, 135);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(81, 20);
            this.LblNombre.TabIndex = 30;
            this.LblNombre.Text = "Nombre :";
            // 
            // CmbRaza
            // 
            this.CmbRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRaza.FormattingEnabled = true;
            this.CmbRaza.Items.AddRange(new object[] {
            "",
            "Beagle",
            "Boston Terrier",
            "Bull Dog",
            "Bull Dog Frances",
            "Doberman"});
            this.CmbRaza.Location = new System.Drawing.Point(101, 178);
            this.CmbRaza.Name = "CmbRaza";
            this.CmbRaza.Size = new System.Drawing.Size(243, 28);
            this.CmbRaza.TabIndex = 36;
            // 
            // DtgLista
            // 
            this.DtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgLista.Location = new System.Drawing.Point(380, 135);
            this.DtgLista.Name = "DtgLista";
            this.DtgLista.Size = new System.Drawing.Size(346, 116);
            this.DtgLista.TabIndex = 37;
            // 
            // TlsOpciones
            // 
            this.TlsOpciones.BackColor = System.Drawing.Color.MidnightBlue;
            this.TlsOpciones.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TlsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlsRegistrar,
            this.TlsConsultar,
            this.TlsEliminar,
            this.TlsSalir});
            this.TlsOpciones.Location = new System.Drawing.Point(0, 0);
            this.TlsOpciones.Name = "TlsOpciones";
            this.TlsOpciones.Size = new System.Drawing.Size(742, 25);
            this.TlsOpciones.TabIndex = 38;
            this.TlsOpciones.Text = "toolStrip1";
            // 
            // TlsRegistrar
            // 
            this.TlsRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TlsRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TlsRegistrar.Name = "TlsRegistrar";
            this.TlsRegistrar.Size = new System.Drawing.Size(78, 22);
            this.TlsRegistrar.Text = "Registrar";
            this.TlsRegistrar.Click += new System.EventHandler(this.TlsRegistrar_Click);
            // 
            // TlsConsultar
            // 
            this.TlsConsultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TlsConsultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TlsConsultar.Name = "TlsConsultar";
            this.TlsConsultar.Size = new System.Drawing.Size(83, 22);
            this.TlsConsultar.Text = "Consultar";
            this.TlsConsultar.Click += new System.EventHandler(this.TlsConsultar_Click);
            // 
            // TlsEliminar
            // 
            this.TlsEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TlsEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TlsEliminar.Name = "TlsEliminar";
            this.TlsEliminar.Size = new System.Drawing.Size(74, 22);
            this.TlsEliminar.Text = "Eliminar";
            this.TlsEliminar.Click += new System.EventHandler(this.TlsEliminar_Click);
            // 
            // TlsSalir
            // 
            this.TlsSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.TlsSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TlsSalir.ForeColor = System.Drawing.Color.Red;
            this.TlsSalir.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TlsSalir.Name = "TlsSalir";
            this.TlsSalir.Size = new System.Drawing.Size(44, 22);
            this.TlsSalir.Text = "Salir";
            this.TlsSalir.Click += new System.EventHandler(this.TlsSalir_Click);
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
            this.label3.Location = new System.Drawing.Point(173, 10);
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
            this.panel2.Size = new System.Drawing.Size(742, 35);
            this.panel2.TabIndex = 39;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TlsOpciones);
            this.Controls.Add(this.DtgLista);
            this.Controls.Add(this.CmbRaza);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.LblRaza);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Name = "Lista";
            this.Text = "Administrar datos de la Lista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DtgLista)).EndInit();
            this.TlsOpciones.ResumeLayout(false);
            this.TlsOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpvError)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblRaza;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.ComboBox CmbRaza;
        private System.Windows.Forms.DataGridView DtgLista;
        private System.Windows.Forms.ToolStrip TlsOpciones;
        private System.Windows.Forms.ToolStripLabel TlsRegistrar;
        private System.Windows.Forms.ToolStripLabel TlsConsultar;
        private System.Windows.Forms.ToolStripLabel TlsEliminar;
        private System.Windows.Forms.ToolStripLabel TlsSalir;
        private System.Windows.Forms.ErrorProvider EpvError;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}