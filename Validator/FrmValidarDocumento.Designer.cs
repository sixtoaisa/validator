
namespace Validator
{
    partial class FrmValidarDocumento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtfhasta = new System.Windows.Forms.DateTimePicker();
            this.txtEmpresa = new System.Windows.Forms.ComboBox();
            this.txtfdesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.femision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xml = new System.Windows.Forms.DataGridViewButtonColumn();
            this.respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enviarsunat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Controls.Add(this.txtfhasta);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.txtfdesde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 59);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProcesar.Location = new System.Drawing.Point(842, 19);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(112, 30);
            this.btnProcesar.TabIndex = 23;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtfhasta
            // 
            this.txtfhasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfhasta.Location = new System.Drawing.Point(663, 24);
            this.txtfhasta.Name = "txtfhasta";
            this.txtfhasta.Size = new System.Drawing.Size(92, 20);
            this.txtfhasta.TabIndex = 22;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEmpresa.FormattingEnabled = true;
            this.txtEmpresa.Items.AddRange(new object[] {
            "EMPRESA 01",
            "EMPRESA 02"});
            this.txtEmpresa.Location = new System.Drawing.Point(74, 23);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(246, 21);
            this.txtEmpresa.TabIndex = 21;
            // 
            // txtfdesde
            // 
            this.txtfdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfdesde.Location = new System.Drawing.Point(506, 24);
            this.txtfdesde.Name = "txtfdesde";
            this.txtfdesde.Size = new System.Drawing.Size(92, 20);
            this.txtfdesde.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "F.Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Empresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "F.Desde:";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(883, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 30);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doc,
            this.serie,
            this.numero,
            this.femision,
            this.cliente,
            this.importe,
            this.xml,
            this.respuesta,
            this.enviarsunat});
            this.dataGrid.Location = new System.Drawing.Point(12, 77);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(960, 306);
            this.dataGrid.TabIndex = 21;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // doc
            // 
            this.doc.HeaderText = "Doc";
            this.doc.Name = "doc";
            this.doc.ReadOnly = true;
            this.doc.Width = 50;
            // 
            // serie
            // 
            this.serie.HeaderText = "Serie";
            this.serie.Name = "serie";
            this.serie.ReadOnly = true;
            this.serie.Width = 80;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 80;
            // 
            // femision
            // 
            this.femision.HeaderText = "F.Emision";
            this.femision.Name = "femision";
            this.femision.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 200;
            // 
            // importe
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.importe.DefaultCellStyle = dataGridViewCellStyle1;
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // xml
            // 
            this.xml.HeaderText = "XML";
            this.xml.Name = "xml";
            this.xml.ReadOnly = true;
            this.xml.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xml.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // respuesta
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.respuesta.DefaultCellStyle = dataGridViewCellStyle2;
            this.respuesta.HeaderText = "Respuesta";
            this.respuesta.Name = "respuesta";
            this.respuesta.ReadOnly = true;
            // 
            // enviarsunat
            // 
            this.enviarsunat.HeaderText = "Enviar";
            this.enviarsunat.Name = "enviarsunat";
            this.enviarsunat.ReadOnly = true;
            this.enviarsunat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.enviarsunat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(777, 389);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 30);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmValidarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmValidarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar Documento";
            this.Load += new System.EventHandler(this.FrmValidarDocumento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox txtEmpresa;
        private System.Windows.Forms.DateTimePicker txtfdesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DateTimePicker txtfhasta;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn femision;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewButtonColumn xml;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuesta;
        private System.Windows.Forms.DataGridViewButtonColumn enviarsunat;
        private System.Windows.Forms.Button btnLimpiar;
    }
}