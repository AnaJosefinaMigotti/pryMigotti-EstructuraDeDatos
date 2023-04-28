
namespace pryMigotti_ED_POO
{
    partial class frmListaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaSimple));
            this.gbListadoGrilla = new System.Windows.Forms.GroupBox();
            this.dgvListaSimple = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListadoLista = new System.Windows.Forms.GroupBox();
            this.lsbListaSimple = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar3 = new System.Windows.Forms.Button();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtCodigo3 = new System.Windows.Forms.TextBox();
            this.btnAgregar3 = new System.Windows.Forms.Button();
            this.txtNombre3 = new System.Windows.Forms.TextBox();
            this.lblTramite1 = new System.Windows.Forms.Label();
            this.txtTramite3 = new System.Windows.Forms.TextBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.gbListadoGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).BeginInit();
            this.gbListadoLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpElementoEliminado.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListadoGrilla
            // 
            this.gbListadoGrilla.Controls.Add(this.dgvListaSimple);
            this.gbListadoGrilla.Location = new System.Drawing.Point(241, 146);
            this.gbListadoGrilla.Name = "gbListadoGrilla";
            this.gbListadoGrilla.Size = new System.Drawing.Size(406, 280);
            this.gbListadoGrilla.TabIndex = 10;
            this.gbListadoGrilla.TabStop = false;
            this.gbListadoGrilla.Text = "Listado en una Grilla";
            // 
            // dgvListaSimple
            // 
            this.dgvListaSimple.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSimple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Column1});
            this.dgvListaSimple.Location = new System.Drawing.Point(32, 27);
            this.dgvListaSimple.Name = "dgvListaSimple";
            this.dgvListaSimple.Size = new System.Drawing.Size(340, 240);
            this.dgvListaSimple.TabIndex = 4;
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
            this.gbListadoLista.Controls.Add(this.lsbListaSimple);
            this.gbListadoLista.Location = new System.Drawing.Point(12, 240);
            this.gbListadoLista.Name = "gbListadoLista";
            this.gbListadoLista.Size = new System.Drawing.Size(222, 186);
            this.gbListadoLista.TabIndex = 9;
            this.gbListadoLista.TabStop = false;
            this.gbListadoLista.Text = "Listado en una Lista";
            // 
            // lsbListaSimple
            // 
            this.lsbListaSimple.FormattingEnabled = true;
            this.lsbListaSimple.Location = new System.Drawing.Point(6, 19);
            this.lsbListaSimple.Name = "lsbListaSimple";
            this.lsbListaSimple.Size = new System.Drawing.Size(208, 160);
            this.lsbListaSimple.TabIndex = 3;
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
            this.gpElementoEliminado.Controls.Add(this.cbCodigo);
            this.gpElementoEliminado.Controls.Add(this.btnEliminar3);
            this.gpElementoEliminado.Controls.Add(this.lblCodigo2);
            this.gpElementoEliminado.Location = new System.Drawing.Point(447, 12);
            this.gpElementoEliminado.Name = "gpElementoEliminado";
            this.gpElementoEliminado.Size = new System.Drawing.Size(200, 128);
            this.gpElementoEliminado.TabIndex = 7;
            this.gpElementoEliminado.TabStop = false;
            this.gpElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cbCodigo
            // 
            this.cbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(60, 23);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(121, 21);
            this.cbCodigo.TabIndex = 10;
            this.cbCodigo.SelectedIndexChanged += new System.EventHandler(this.cbCodigo_SelectedIndexChanged);
            // 
            // btnEliminar3
            // 
            this.btnEliminar3.Location = new System.Drawing.Point(67, 99);
            this.btnEliminar3.Name = "btnEliminar3";
            this.btnEliminar3.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar3.TabIndex = 9;
            this.btnEliminar3.Text = "Eliminar";
            this.btnEliminar3.UseVisualStyleBackColor = true;
            this.btnEliminar3.Click += new System.EventHandler(this.btnEliminar3_Click);
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
            this.gbNuevoElemento.Controls.Add(this.txtCodigo3);
            this.gbNuevoElemento.Controls.Add(this.btnAgregar3);
            this.gbNuevoElemento.Controls.Add(this.txtNombre3);
            this.gbNuevoElemento.Controls.Add(this.lblTramite1);
            this.gbNuevoElemento.Controls.Add(this.txtTramite3);
            this.gbNuevoElemento.Controls.Add(this.lblNombre1);
            this.gbNuevoElemento.Controls.Add(this.lblCodigo1);
            this.gbNuevoElemento.Location = new System.Drawing.Point(241, 12);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(200, 128);
            this.gbNuevoElemento.TabIndex = 6;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtCodigo3
            // 
            this.txtCodigo3.Location = new System.Drawing.Point(67, 20);
            this.txtCodigo3.Name = "txtCodigo3";
            this.txtCodigo3.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo3.TabIndex = 10;
            // 
            // btnAgregar3
            // 
            this.btnAgregar3.Location = new System.Drawing.Point(66, 96);
            this.btnAgregar3.Name = "btnAgregar3";
            this.btnAgregar3.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar3.TabIndex = 8;
            this.btnAgregar3.Text = "Agregar";
            this.btnAgregar3.UseVisualStyleBackColor = true;
            this.btnAgregar3.Click += new System.EventHandler(this.btnAgregar3_Click);
            // 
            // txtNombre3
            // 
            this.txtNombre3.Location = new System.Drawing.Point(67, 44);
            this.txtNombre3.Name = "txtNombre3";
            this.txtNombre3.Size = new System.Drawing.Size(100, 20);
            this.txtNombre3.TabIndex = 11;
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
            // txtTramite3
            // 
            this.txtTramite3.Location = new System.Drawing.Point(67, 68);
            this.txtTramite3.Name = "txtTramite3";
            this.txtTramite3.Size = new System.Drawing.Size(100, 20);
            this.txtTramite3.TabIndex = 12;
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
            // frmListaSimple
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
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Simple";
            this.gbListadoGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).EndInit();
            this.gbListadoLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpElementoEliminado.ResumeLayout(false);
            this.gpElementoEliminado.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoGrilla;
        private System.Windows.Forms.DataGridView dgvListaSimple;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox gbListadoLista;
        private System.Windows.Forms.ListBox lsbListaSimple;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpElementoEliminado;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.Button btnEliminar3;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.TextBox txtCodigo3;
        private System.Windows.Forms.Button btnAgregar3;
        private System.Windows.Forms.TextBox txtNombre3;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.TextBox txtTramite3;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblCodigo1;
    }
}