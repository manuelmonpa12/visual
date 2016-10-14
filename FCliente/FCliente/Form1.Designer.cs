namespace FCliente
{
    partial class FCliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCliente));
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRCHIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDICCIONARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTUALIZARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(148, 37);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(393, 20);
            this.txtid.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(148, 72);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(170, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(148, 110);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(170, 20);
            this.txtApe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identificacion:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(330, 65);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 32);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(330, 103);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 32);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(441, 104);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 30);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(441, 65);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 32);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(18, 161);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.Size = new System.Drawing.Size(522, 176);
            this.dgDatos.TabIndex = 11;
            this.dgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDatos_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            this.aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDICCIONARToolStripMenuItem,
            this.cONSULTARToolStripMenuItem,
            this.eLIMINARToolStripMenuItem,
            this.aCTUALIZARToolStripMenuItem,
            this.toolStripSeparator1,
            this.sALIRToolStripMenuItem});
            this.aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            this.aRCHIVOToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.aRCHIVOToolStripMenuItem.Text = "&OPERADORES";
            this.aRCHIVOToolStripMenuItem.Click += new System.EventHandler(this.aRCHIVOToolStripMenuItem_Click);
            // 
            // aDICCIONARToolStripMenuItem
            // 
            this.aDICCIONARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aDICCIONARToolStripMenuItem.Image")));
            this.aDICCIONARToolStripMenuItem.Name = "aDICCIONARToolStripMenuItem";
            this.aDICCIONARToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aDICCIONARToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aDICCIONARToolStripMenuItem.Text = "AGREGAR";
            this.aDICCIONARToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // cONSULTARToolStripMenuItem
            // 
            this.cONSULTARToolStripMenuItem.Name = "cONSULTARToolStripMenuItem";
            this.cONSULTARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cONSULTARToolStripMenuItem.Text = "CONSULTAR";
            this.cONSULTARToolStripMenuItem.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // eLIMINARToolStripMenuItem
            // 
            this.eLIMINARToolStripMenuItem.Name = "eLIMINARToolStripMenuItem";
            this.eLIMINARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eLIMINARToolStripMenuItem.Text = "ACTUALIZAR";
            this.eLIMINARToolStripMenuItem.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // aCTUALIZARToolStripMenuItem
            // 
            this.aCTUALIZARToolStripMenuItem.Name = "aCTUALIZARToolStripMenuItem";
            this.aCTUALIZARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aCTUALIZARToolStripMenuItem.Text = "ELIMINAR";
            this.aCTUALIZARToolStripMenuItem.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(546, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(241, 17);
            this.toolStripStatusLabel1.Text = "Derechos Reservados - CopyRight 2016-2020";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // FCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 364);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDICCIONARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCTUALIZARToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

