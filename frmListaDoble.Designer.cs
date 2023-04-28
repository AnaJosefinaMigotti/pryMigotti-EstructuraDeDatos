namespace pryMigotti_ED_POO
{
    partial class frmListaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDoble));
            this.gbListadoGrilla = new System.Windows.Forms.GroupBox();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListadoLista = new System.Windows.Forms.GroupBox();
            this.lsbListaDoble = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.btnEliminar4 = new System.Windows.Forms.Button();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtCodigo4 = new System.Windows.Forms.TextBox();
            this.btnAgregar4 = new System.Windows.Forms.Button();
            this.txtNombre4 = new System.Windows.Forms.TextBox();
            this.lblTramite1 = new System.Windows.Forms.Label();
            this.txtTramite4 = new System.Windows.Forms.TextBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.cbCodigo4 = new System.Windows.Forms.ComboBox();
            this.gbListadoGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.gbListadoLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpElementoEliminado.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListadoGrilla
            // 
            this.gbListadoGrilla.Controls.Add(this.dgvListaDoble);
            this.gbListadoGrilla.Location = new System.Drawing.Point(241, 146);
            this.gbListadoGrilla.Name = "gbListadoGrilla";
            this.gbListadoGrilla.Size = new System.Drawing.Size(406, 280);
            this.gbListadoGrilla.TabIndex = 10;
            this.gbListadoGrilla.TabStop = false;
            this.gbListadoGrilla.Text = "Listado en una Grilla";
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Column1});
            this.dgvListaDoble.Location = new System.Drawing.Point(32, 27);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.Size = new System.Drawing.Size(340, 240);
            this.dgvListaDoble.TabIndex = 4;
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
            this.gbListadoLista.Controls.Add(this.lsbListaDoble);
            this.gbListadoLista.Location = new System.Drawing.Point(12, 240);
            this.gbListadoLista.Name = "gbListadoLista";
            this.gbListadoLista.Size = new System.Drawing.Size(222, 186);
            this.gbListadoLista.TabIndex = 9;
            this.gbListadoLista.TabStop = false;
            this.gbListadoLista.Text = "Listado en una Lista";
            // 
            // lsbListaDoble
            // 
            this.lsbListaDoble.FormattingEnabled = true;
            this.lsbListaDoble.Location = new System.Drawing.Point(6, 19);
            this.lsbListaDoble.Name = "lsbListaDoble";
            this.lsbListaDoble.Size = new System.Drawing.Size(208, 160);
            this.lsbListaDoble.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 222);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // gpElementoEliminado
            // 
            this.gpElementoEliminado.Controls.Add(this.cbCodigo4);
            this.gpElementoEliminado.Controls.Add(this.btnEliminar4);
            this.gpElementoEliminado.Controls.Add(this.lblCodigo2);
            this.gpElementoEliminado.Location = new System.Drawing.Point(447, 12);
            this.gpElementoEliminado.Name = "gpElementoEliminado";
            this.gpElementoEliminado.Size = new System.Drawing.Size(200, 85);
            this.gpElementoEliminado.TabIndex = 7;
            this.gpElementoEliminado.TabStop = false;
            this.gpElementoEliminado.Text = "Elemento Eliminado";
            // 
            // btnEliminar4
            // 
            this.btnEliminar4.Location = new System.Drawing.Point(64, 50);
            this.btnEliminar4.Name = "btnEliminar4";
            this.btnEliminar4.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar4.TabIndex = 9;
            this.btnEliminar4.Text = "Eliminar";
            this.btnEliminar4.UseVisualStyleBackColor = true;
            this.btnEliminar4.Click += new System.EventHandler(this.btnEliminar4_Click);
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
            this.gbNuevoElemento.Controls.Add(this.txtCodigo4);
            this.gbNuevoElemento.Controls.Add(this.btnAgregar4);
            this.gbNuevoElemento.Controls.Add(this.txtNombre4);
            this.gbNuevoElemento.Controls.Add(this.lblTramite1);
            this.gbNuevoElemento.Controls.Add(this.txtTramite4);
            this.gbNuevoElemento.Controls.Add(this.lblNombre1);
            this.gbNuevoElemento.Controls.Add(this.lblCodigo1);
            this.gbNuevoElemento.Location = new System.Drawing.Point(241, 12);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(200, 128);
            this.gbNuevoElemento.TabIndex = 6;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtCodigo4
            // 
            this.txtCodigo4.Location = new System.Drawing.Point(67, 20);
            this.txtCodigo4.Name = "txtCodigo4";
            this.txtCodigo4.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo4.TabIndex = 10;
            // 
            // btnAgregar4
            // 
            this.btnAgregar4.Location = new System.Drawing.Point(66, 96);
            this.btnAgregar4.Name = "btnAgregar4";
            this.btnAgregar4.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar4.TabIndex = 8;
            this.btnAgregar4.Text = "Agregar";
            this.btnAgregar4.UseVisualStyleBackColor = true;
            this.btnAgregar4.Click += new System.EventHandler(this.btnAgregar4_Click);
            // 
            // txtNombre4
            // 
            this.txtNombre4.Location = new System.Drawing.Point(67, 44);
            this.txtNombre4.Name = "txtNombre4";
            this.txtNombre4.Size = new System.Drawing.Size(100, 20);
            this.txtNombre4.TabIndex = 11;
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
            // txtTramite4
            // 
            this.txtTramite4.Location = new System.Drawing.Point(67, 68);
            this.txtTramite4.Name = "txtTramite4";
            this.txtTramite4.Size = new System.Drawing.Size(100, 20);
            this.txtTramite4.TabIndex = 12;
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
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Location = new System.Drawing.Point(490, 105);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(119, 17);
            this.rbAscendente.TabIndex = 11;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Listado Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            this.rbAscendente.CheckedChanged += new System.EventHandler(this.rbAscendente_CheckedChanged);
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(490, 124);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(126, 17);
            this.rbDescendente.TabIndex = 12;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Listado Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            this.rbDescendente.CheckedChanged += new System.EventHandler(this.rbDescendente_CheckedChanged);
            // 
            // cbCodigo4
            // 
            this.cbCodigo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigo4.FormattingEnabled = true;
            this.cbCodigo4.Location = new System.Drawing.Point(60, 22);
            this.cbCodigo4.Name = "cbCodigo4";
            this.cbCodigo4.Size = new System.Drawing.Size(121, 21);
            this.cbCodigo4.TabIndex = 11;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 432);
            this.Controls.Add(this.rbDescendente);
            this.Controls.Add(this.rbAscendente);
            this.Controls.Add(this.gbListadoGrilla);
            this.Controls.Add(this.gbListadoLista);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpElementoEliminado);
            this.Controls.Add(this.gbNuevoElemento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Doble";
            this.gbListadoGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.gbListadoLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpElementoEliminado.ResumeLayout(false);
            this.gpElementoEliminado.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoGrilla;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox gbListadoLista;
        private System.Windows.Forms.ListBox lsbListaDoble;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpElementoEliminado;
        private System.Windows.Forms.Button btnEliminar4;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.TextBox txtCodigo4;
        private System.Windows.Forms.Button btnAgregar4;
        private System.Windows.Forms.TextBox txtNombre4;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.TextBox txtTramite4;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.ComboBox cbCodigo4;
    }
}