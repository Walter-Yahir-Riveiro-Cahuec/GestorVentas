namespace GestorVentas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblBienvenida = new Label();
            tabPage2 = new TabPage();
            dgvVentas = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            lblTituloPromedio = new Label();
            lblPromedioGeneral = new Label();
            btnRecargar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblBienvenida);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pestaña 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBienvenida.Location = new Point(30, 30);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(228, 28);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Sistema Gestor de Ventas";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvVentas);
            tabPage2.Controls.Add(lblTituloPromedio);
            tabPage2.Controls.Add(lblPromedioGeneral);
            tabPage2.Controls.Add(btnRecargar);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pestaña 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colId, colCliente, colFecha, colMonto });
            dgvVentas.Location = new Point(20, 20);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(750, 320);
            dgvVentas.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colCliente
            // 
            colCliente.DataPropertyName = "Cliente";
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.DataPropertyName = "Fecha";
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colMonto
            // 
            colMonto.DataPropertyName = "Monto";
            colMonto.HeaderText = "Monto";
            colMonto.MinimumWidth = 6;
            colMonto.Name = "Monto";
            colMonto.ReadOnly = true;
            // 
            // lblTituloPromedio
            // 
            lblTituloPromedio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTituloPromedio.AutoSize = true;
            lblTituloPromedio.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloPromedio.Location = new Point(20, 362);
            lblTituloPromedio.Name = "lblTituloPromedio";
            lblTituloPromedio.Size = new Size(160, 23);
            lblTituloPromedio.TabIndex = 1;
            lblTituloPromedio.Text = "Promedio General:";
            // 
            // lblPromedioGeneral
            // 
            lblPromedioGeneral.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPromedioGeneral.AutoSize = true;
            lblPromedioGeneral.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPromedioGeneral.ForeColor = Color.DarkGreen;
            lblPromedioGeneral.Location = new Point(190, 360);
            lblPromedioGeneral.Name = "lblPromedioGeneral";
            lblPromedioGeneral.Size = new Size(59, 25);
            lblPromedioGeneral.TabIndex = 2;
            lblPromedioGeneral.Text = "$0.00";
            // 
            // btnRecargar
            // 
            btnRecargar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecargar.Location = new Point(650, 355);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(120, 35);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Ventas";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public TabControl tabControl1;
        public TabPage tabPage1;
        public TabPage tabPage2;
        public Label lblBienvenida;
        public DataGridView dgvVentas;
        public DataGridViewTextBoxColumn colId;
        public DataGridViewTextBoxColumn colCliente;
        public DataGridViewTextBoxColumn colFecha;
        public DataGridViewTextBoxColumn colMonto;
        public Label lblTituloPromedio;
        public Label lblPromedioGeneral;
        public Button btnRecargar;
    }
}
