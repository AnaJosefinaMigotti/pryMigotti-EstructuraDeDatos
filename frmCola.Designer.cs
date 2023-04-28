
namespace pryMigotti_ED_POO
{
    partial class frmCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtCodigo1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.lblTramite1 = new System.Windows.Forms.Label();
            this.txtTramite1 = new System.Windows.Forms.TextBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.gpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramiteE = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lsbCola = new System.Windows.Forms.ListBox();
            this.gbListadoLista = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListadoGrilla = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbNuevoElemento.SuspendLayout();
            this.gpElementoEliminado.SuspendLayout();
            this.gbListadoLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.gbListadoGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.txtCodigo1);
            this.gbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbNuevoElemento.Controls.Add(this.txtNombre1);
            this.gbNuevoElemento.Controls.Add(this.lblTramite1);
            this.gbNuevoElemento.Controls.Add(this.txtTramite1);
            this.gbNuevoElemento.Controls.Add(this.lblNombre1);
            this.gbNuevoElemento.Controls.Add(this.lblCodigo1);
            this.gbNuevoElemento.Location = new System.Drawing.Point(241, 12);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(200, 128);
            this.gbNuevoElemento.TabIndex = 0;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.Location = new System.Drawing.Point(67, 20);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo1.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(66, 96);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(67, 44);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(100, 20);
            this.txtNombre1.TabIndex = 11;
            // 
            // lblTramite1
            // 
            this.lblTramite1.AutoSize = true;
            this.lblTramite1.Location = new System.Drawing.Point(14, 72);
            this.lblTramite1.Name = "lblTramite1";
            this.lblTramite1.Size = new System.Drawing.Size(45, 13);
            this.lblTramite1.TabIndex = 4;
            this.lblTramite1.Text = "Trámite:";
            // 
            // txtTramite1
            // 
            this.txtTramite1.Location = new System.Drawing.Point(67, 68);
            this.txtTramite1.Name = "txtTramite1";
            this.txtTramite1.Size = new System.Drawing.Size(100, 20);
            this.txtTramite1.TabIndex = 12;
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(14, 48);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(47, 13);
            this.lblNombre1.TabIndex = 3;
            this.lblNombre1.Text = "Nombre:";
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(14, 24);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo1.TabIndex = 2;
            this.lblCodigo1.Text = "Código:";
            // 
            // gpElementoEliminado
            // 
            this.gpElementoEliminado.Controls.Add(this.lblTramiteE);
            this.gpElementoEliminado.Controls.Add(this.lblNombreE);
            this.gpElementoEliminado.Controls.Add(this.lblCodigoE);
            this.gpElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpElementoEliminado.Controls.Add(this.lblTramite2);
            this.gpElementoEliminado.Controls.Add(this.lblNombre2);
            this.gpElementoEliminado.Controls.Add(this.lblCodigo2);
            this.gpElementoEliminado.Location = new System.Drawing.Point(447, 12);
            this.gpElementoEliminado.Name = "gpElementoEliminado";
            this.gpElementoEliminado.Size = new System.Drawing.Size(200, 128);
            this.gpElementoEliminado.TabIndex = 1;
            this.gpElementoEliminado.TabStop = false;
            this.gpElementoEliminado.Text = "Elemento Eliminado";
            this.gpElementoEliminado.Enter += new System.EventHandler(this.gpElementoEliminado_Enter);
            // 
            // lblTramiteE
            // 
            this.lblTramiteE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTramiteE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteE.Location = new System.Drawing.Point(64, 70);
            this.lblTramiteE.Name = "lblTramiteE";
            this.lblTramiteE.Size = new System.Drawing.Size(100, 20);
            this.lblTramiteE.TabIndex = 11;
            // 
            // lblNombreE
            // 
            this.lblNombreE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombreE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreE.Location = new System.Drawing.Point(64, 46);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(100, 20);
            this.lblNombreE.TabIndex = 10;
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodigoE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoE.Location = new System.Drawing.Point(64, 22);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(100, 20);
            this.lblCodigoE.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(67, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Location = new System.Drawing.Point(14, 74);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(45, 13);
            this.lblTramite2.TabIndex = 7;
            this.lblTramite2.Text = "Trámite:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(14, 50);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2.TabIndex = 6;
            this.lblNombre2.Text = "Nombre:";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(14, 26);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo2.TabIndex = 5;
            this.lblCodigo2.Text = "Código";
            // 
            // lsbCola
            // 
            this.lsbCola.FormattingEnabled = true;
            this.lsbCola.Location = new System.Drawing.Point(6, 19);
            this.lsbCola.Name = "lsbCola";
            this.lsbCola.Size = new System.Drawing.Size(208, 160);
            this.lsbCola.TabIndex = 3;
            // 
            // gbListadoLista
            // 
            this.gbListadoLista.Controls.Add(this.lsbCola);
            this.gbListadoLista.Location = new System.Drawing.Point(12, 240);
            this.gbListadoLista.Name = "gbListadoLista";
            this.gbListadoLista.Size = new System.Drawing.Size(222, 186);
            this.gbListadoLista.TabIndex = 4;
            this.gbListadoLista.TabStop = false;
            this.gbListadoLista.Text = "Listado en una Lista";
            // 
            // dgvCola
            // 
            this.dgvCola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Column1});
            this.dgvCola.Location = new System.Drawing.Point(32, 27);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(340, 240);
            this.dgvCola.TabIndex = 4;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Trámite";
            this.Column1.Name = "Column1";
            // 
            // gbListadoGrilla
            // 
            this.gbListadoGrilla.Controls.Add(this.dgvCola);
            this.gbListadoGrilla.Location = new System.Drawing.Point(241, 146);
            this.gbListadoGrilla.Name = "gbListadoGrilla";
            this.gbListadoGrilla.Size = new System.Drawing.Size(406, 280);
            this.gbListadoGrilla.TabIndex = 5;
            this.gbListadoGrilla.TabStop = false;
            this.gbListadoGrilla.Text = "Listado en una Grilla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryMigotti_ED_POO.Properties.Resources.cola;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 222);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 432);
            this.Controls.Add(this.gbListadoGrilla);
            this.Controls.Add(this.gbListadoLista);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpElementoEliminado);
            this.Controls.Add(this.gbNuevoElemento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cola";
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gpElementoEliminado.ResumeLayout(false);
            this.gpElementoEliminado.PerformLayout();
            this.gbListadoLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.gbListadoGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.TextBox txtCodigo1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.TextBox txtTramite1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.GroupBox gpElementoEliminado;
        private System.Windows.Forms.Label lblTramiteE;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lsbCola;
        private System.Windows.Forms.GroupBox gbListadoLista;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox gbListadoGrilla;
    }
}