namespace CampusNavegación
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnHeap = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnMostrarGrafo = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.panelCampus = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.btnReiniciar);
            this.panelMenu.Controls.Add(this.btnHeap);
            this.panelMenu.Controls.Add(this.btnHash);
            this.panelMenu.Controls.Add(this.btnDFS);
            this.panelMenu.Controls.Add(this.btnBFS);
            this.panelMenu.Controls.Add(this.btnMostrarGrafo);
            this.panelMenu.Controls.Add(this.cmbDestino);
            this.panelMenu.Controls.Add(this.lblDestino);
            this.panelMenu.Controls.Add(this.cmbOrigen);
            this.panelMenu.Controls.Add(this.lblOrigen);
            this.panelMenu.Controls.Add(this.lblTitulo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(307, 814);
            this.panelMenu.TabIndex = 0;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(27, 734);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(240, 52);
            this.btnReiniciar.TabIndex = 11;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnHeap
            // 
            this.btnHeap.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHeap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnHeap.ForeColor = System.Drawing.Color.White;
            this.btnHeap.Location = new System.Drawing.Point(27, 652);
            this.btnHeap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHeap.Name = "btnHeap";
            this.btnHeap.Size = new System.Drawing.Size(240, 62);
            this.btnHeap.TabIndex = 10;
            this.btnHeap.Text = "Min Heap";
            this.btnHeap.UseVisualStyleBackColor = false;
            this.btnHeap.Click += new System.EventHandler(this.btnHeap_Click);
            // 
            // btnHash
            // 
            this.btnHash.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnHash.ForeColor = System.Drawing.Color.White;
            this.btnHash.Location = new System.Drawing.Point(27, 566);
            this.btnHash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(240, 62);
            this.btnHash.TabIndex = 9;
            this.btnHash.Text = "Tabla Hash";
            this.btnHash.UseVisualStyleBackColor = false;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDFS.ForeColor = System.Drawing.Color.White;
            this.btnDFS.Location = new System.Drawing.Point(27, 480);
            this.btnDFS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(240, 62);
            this.btnDFS.TabIndex = 8;
            this.btnDFS.Text = "Recorrido DFS";
            this.btnDFS.UseVisualStyleBackColor = false;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click_1);
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBFS.ForeColor = System.Drawing.Color.White;
            this.btnBFS.Location = new System.Drawing.Point(27, 394);
            this.btnBFS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(240, 62);
            this.btnBFS.TabIndex = 7;
            this.btnBFS.Text = "Recorrido BFS";
            this.btnBFS.UseVisualStyleBackColor = false;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click_1);
            // 
            // btnMostrarGrafo
            // 
            this.btnMostrarGrafo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMostrarGrafo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarGrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnMostrarGrafo.ForeColor = System.Drawing.Color.White;
            this.btnMostrarGrafo.Location = new System.Drawing.Point(27, 308);
            this.btnMostrarGrafo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarGrafo.Name = "btnMostrarGrafo";
            this.btnMostrarGrafo.Size = new System.Drawing.Size(240, 62);
            this.btnMostrarGrafo.TabIndex = 6;
            this.btnMostrarGrafo.Text = "Mostrar Grafo";
            this.btnMostrarGrafo.UseVisualStyleBackColor = false;
            this.btnMostrarGrafo.Click += new System.EventHandler(this.btnMostrarGrafo_Click_1);
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(27, 240);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(239, 28);
            this.cmbDestino.TabIndex = 5;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDestino.ForeColor = System.Drawing.Color.White;
            this.lblDestino.Location = new System.Drawing.Point(23, 215);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(67, 20);
            this.lblDestino.TabIndex = 4;
            this.lblDestino.Text = "Destino";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(27, 172);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(239, 28);
            this.cmbOrigen.TabIndex = 3;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblOrigen.ForeColor = System.Drawing.Color.White;
            this.lblOrigen.Location = new System.Drawing.Point(23, 148);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(59, 20);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Origen";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(4, 55);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(299, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Campus Universitario";
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.txtResultado);
            this.panelContenido.Controls.Add(this.panelCampus);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(307, 0);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.panelContenido.Size = new System.Drawing.Size(1272, 814);
            this.panelContenido.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultado.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.txtResultado.Location = new System.Drawing.Point(16, 458);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(1240, 341);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.Text = "";
            // 
            // panelCampus
            // 
            this.panelCampus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCampus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCampus.Location = new System.Drawing.Point(16, 15);
            this.panelCampus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCampus.Name = "panelCampus";
            this.panelCampus.Size = new System.Drawing.Size(1240, 443);
            this.panelCampus.TabIndex = 0;
            this.panelCampus.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCampus_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusNavegacion - Sistema de Navegación del Campus";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnHeap;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnMostrarGrafo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.Panel panelCampus;
    }
}

