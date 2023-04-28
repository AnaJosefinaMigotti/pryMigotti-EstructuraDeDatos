
namespace pryMigotti_ED_POO
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.gbListadoGrilla = new System.Windows.Forms.GroupBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListadoLista = new System.Windows.Forms.GroupBox();
            this.lsbPila = new System.Windows.Forms.ListBox();
            this.gpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramiteP = new System.Windows.Forms.Label();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.btnEliminarPila = new System.Windows.Forms.Button();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.btnAgregarPila = new System.Windows.Forms.Button();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.lblTramite1 = new System.Windows.Forms.Label();
            this.txtTramite2 = new System.Windows.Forms.TextBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.pcPila = new System.Windows.Forms.PictureBox();
            this.gbListadoGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.gbListadoLista.SuspendLayout();
            this.gpElementoEliminado.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPila)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListadoGrilla
            // 
            this.gbListadoGrilla.Controls.Add(this.dgvPila);
            this.gbListadoGrilla.Location = new System.Drawing.Point(241, 146);
            this.gbListadoGrilla.Name = "gbListadoGrilla";
            this.gbListadoGrilla.Size = new System.Drawing.Size(406, 280);
            this.gbListadoGrilla.TabIndex = 10;
            this.gbListadoGrilla.TabStop = false;
            this.gbListadoGrilla.Text = "Listado en una Grilla";
            // 
            // dgvPila
            // 
            this.dgvPila.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Column1});
            this.dgvPila.Location = new System.Drawing.Point(32, 27);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.Size = new System.Drawing.Size(340, 240);
            this.dgvPila.TabIndex = 4;
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
            // gbListadoLista
            // 
            this.gbListadoLista.Controls.Add(this.lsbPila);
            this.gbListadoLista.Location = new System.Drawing.Point(12, 240);
            this.gbListadoLista.Name = "gbListadoLista";
            this.gbListadoLista.Size = new System.Drawing.Size(222, 186);
            this.gbListadoLista.TabIndex = 9;
            this.gbListadoLista.TabStop = false;
            this.gbListadoLista.Text = "Listado en una Lista";
            // 
            // lsbPila
            // 
            this.lsbPila.FormattingEnabled = true;
            this.lsbPila.Location = new System.Drawing.Point(6, 19);
            this.lsbPila.Name = "lsbPila";
            this.lsbPila.Size = new System.Drawing.Size(208, 160);
            this.lsbPila.TabIndex = 3;
            // 
            // gpElementoEliminado
            // 
            this.gpElementoEliminado.Controls.Add(this.lblTramiteP);
            this.gpElementoEliminado.Controls.Add(this.lblNombreP);
            this.gpElementoEliminado.Controls.Add(this.lblCodigoP);
            this.gpElementoEliminado.Controls.Add(this.btnEliminarPila);
            this.gpElementoEliminado.Controls.Add(this.lblTramite2);
            this.gpElementoEliminado.Controls.Add(this.lblNombre2);
            this.gpElementoEliminado.Controls.Add(this.lblCodigo2);
            this.gpElementoEliminado.Location = new System.Drawing.Point(447, 12);
            this.gpElementoEliminado.Name = "gpElementoEliminado";
            this.gpElementoEliminado.Size = new System.Drawing.Size(200, 128);
            this.gpElementoEliminado.TabIndex = 7;
            this.gpElementoEliminado.TabStop = false;
            this.gpElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblTramiteP
            // 
            this.lblTramiteP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTramiteP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteP.Location = new System.Drawing.Point(64, 70);
            this.lblTramiteP.Name = "lblTramiteP";
            this.lblTramiteP.Size = new System.Drawing.Size(100, 20);
            this.lblTramiteP.TabIndex = 11;
            // 
            // lblNombreP
            // 
            this.lblNombreP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombreP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreP.Location = new System.Drawing.Point(64, 46);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(100, 20);
            this.lblNombreP.TabIndex = 10;
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodigoP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoP.Location = new System.Drawing.Point(64, 22);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(100, 20);
            this.lblCodigoP.TabIndex = 2;
            // 
            // btnEliminarPila
            // 
            this.btnEliminarPila.Location = new System.Drawing.Point(67, 99);
            this.btnEliminarPila.Name = "btnEliminarPila";
            this.btnEliminarPila.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPila.TabIndex = 9;
            this.btnEliminarPila.Text = "Eliminar";
            this.btnEliminarPila.UseVisualStyleBackColor = true;
            this.btnEliminarPila.Click += new System.EventHandler(this.btnEliminarPila_Click);
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
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.txtCodigo2);
            this.gbNuevoElemento.Controls.Add(this.btnAgregarPila);
            this.gbNuevoElemento.Controls.Add(this.txtNombre2);
            this.gbNuevoElemento.Controls.Add(this.lblTramite1);
            this.gbNuevoElemento.Controls.Add(this.txtTramite2);
            this.gbNuevoElemento.Controls.Add(this.lblNombre1);
            this.gbNuevoElemento.Controls.Add(this.lblCodigo1);
            this.gbNuevoElemento.Location = new System.Drawing.Point(241, 12);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(200, 128);
            this.gbNuevoElemento.TabIndex = 6;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(67, 20);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo2.TabIndex = 10;
            // 
            // btnAgregarPila
            // 
            this.btnAgregarPila.Location = new System.Drawing.Point(66, 96);
            this.btnAgregarPila.Name = "btnAgregarPila";
            this.btnAgregarPila.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPila.TabIndex = 8;
            this.btnAgregarPila.Text = "Agregar";
            this.btnAgregarPila.UseVisualStyleBackColor = true;
            this.btnAgregarPila.Click += new System.EventHandler(this.btnAgregarPila_Click);
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(67, 44);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(100, 20);
            this.txtNombre2.TabIndex = 11;
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
            // txtTramite2
            // 
            this.txtTramite2.Location = new System.Drawing.Point(67, 68);
            this.txtTramite2.Name = "txtTramite2";
            this.txtTramite2.Size = new System.Drawing.Size(100, 20);
            this.txtTramite2.TabIndex = 12;
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
            // pcPila
            // 
            this.pcPila.Location = new System.Drawing.Point(12, 12);
            this.pcPila.Name = "pcPila";
            this.pcPila.Size = new System.Drawing.Size(214, 222);
            this.pcPila.TabIndex = 8;
            this.pcPila.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 432);
            this.Controls.Add(this.gbListadoGrilla);
            this.Controls.Add(this.gbListadoLista);
            this.Controls.Add(this.pcPila);
            this.Controls.Add(this.gpElementoEliminado);
            this.Controls.Add(this.gbNuevoElemento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pila";
            this.gbListadoGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.gbListadoLista.ResumeLayout(false);
            this.gpElementoEliminado.ResumeLayout(false);
            this.gpElementoEliminado.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPila)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoGrilla;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox gbListadoLista;
        private System.Windows.Forms.ListBox lsbPila;
        private System.Windows.Forms.PictureBox pcPila;
        private System.Windows.Forms.GroupBox gpElementoEliminado;
        private System.Windows.Forms.Label lblTramiteP;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblCodigoP;
        private System.Windows.Forms.Button btnEliminarPila;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.Button btnAgregarPila;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.TextBox txtTramite2;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblCodigo1;
    }
}