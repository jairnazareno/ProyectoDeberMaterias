namespace IUWindowsForms
{
    partial class frmMostrarMaterias
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.linkActualizar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.linkEliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE MATERIAS INGRESADAS";
            // 
            // dtListado
            // 
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkActualizar,
            this.linkEliminar});
            this.dtListado.Location = new System.Drawing.Point(89, 141);
            this.dtListado.Name = "dtListado";
            this.dtListado.Size = new System.Drawing.Size(439, 163);
            this.dtListado.TabIndex = 1;
            this.dtListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListado_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(270, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "VISUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkActualizar
            // 
            this.linkActualizar.HeaderText = "Accion";
            this.linkActualizar.Name = "linkActualizar";
            this.linkActualizar.Text = "Actualizar";
            this.linkActualizar.UseColumnTextForLinkValue = true;
            // 
            // linkEliminar
            // 
            this.linkEliminar.HeaderText = "Accion";
            this.linkEliminar.Name = "linkEliminar";
            this.linkEliminar.Text = "Eliminar";
            this.linkEliminar.UseColumnTextForLinkValue = true;
            // 
            // frmMostrarMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtListado);
            this.Controls.Add(this.label1);
            this.Name = "frmMostrarMaterias";
            this.Text = "Mostrar Materias";
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewLinkColumn linkActualizar;
        private System.Windows.Forms.DataGridViewLinkColumn linkEliminar;
    }
}