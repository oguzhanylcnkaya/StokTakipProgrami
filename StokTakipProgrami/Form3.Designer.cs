namespace StokTakipProgrami
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gorselProgramlamaOdevDataSet2 = new StokTakipProgrami.GorselProgramlamaOdevDataSet2();
            this.stokKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokKayitTableAdapter = new StokTakipProgrami.GorselProgramlamaOdevDataSet2TableAdapters.StokKayitTableAdapter();
            this.kayitNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokModeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokSeriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaydedenKisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgramlamaOdevDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKayitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kayitNoDataGridViewTextBoxColumn,
            this.stokAdiDataGridViewTextBoxColumn,
            this.stokModeliDataGridViewTextBoxColumn,
            this.stokSeriNoDataGridViewTextBoxColumn,
            this.stokAdediDataGridViewTextBoxColumn,
            this.stokTarihiDataGridViewTextBoxColumn,
            this.kaydedenKisiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stokKayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(937, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // gorselProgramlamaOdevDataSet2
            // 
            this.gorselProgramlamaOdevDataSet2.DataSetName = "GorselProgramlamaOdevDataSet2";
            this.gorselProgramlamaOdevDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokKayitBindingSource
            // 
            this.stokKayitBindingSource.DataMember = "StokKayit";
            this.stokKayitBindingSource.DataSource = this.gorselProgramlamaOdevDataSet2;
            // 
            // stokKayitTableAdapter
            // 
            this.stokKayitTableAdapter.ClearBeforeFill = true;
            // 
            // kayitNoDataGridViewTextBoxColumn
            // 
            this.kayitNoDataGridViewTextBoxColumn.DataPropertyName = "KayitNo";
            this.kayitNoDataGridViewTextBoxColumn.HeaderText = "KayitNo";
            this.kayitNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitNoDataGridViewTextBoxColumn.Name = "kayitNoDataGridViewTextBoxColumn";
            this.kayitNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.kayitNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokAdiDataGridViewTextBoxColumn
            // 
            this.stokAdiDataGridViewTextBoxColumn.DataPropertyName = "StokAdi";
            this.stokAdiDataGridViewTextBoxColumn.HeaderText = "StokAdi";
            this.stokAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokAdiDataGridViewTextBoxColumn.Name = "stokAdiDataGridViewTextBoxColumn";
            this.stokAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokModeliDataGridViewTextBoxColumn
            // 
            this.stokModeliDataGridViewTextBoxColumn.DataPropertyName = "StokModeli";
            this.stokModeliDataGridViewTextBoxColumn.HeaderText = "StokModeli";
            this.stokModeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokModeliDataGridViewTextBoxColumn.Name = "stokModeliDataGridViewTextBoxColumn";
            this.stokModeliDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokSeriNoDataGridViewTextBoxColumn
            // 
            this.stokSeriNoDataGridViewTextBoxColumn.DataPropertyName = "StokSeriNo";
            this.stokSeriNoDataGridViewTextBoxColumn.HeaderText = "StokSeriNo";
            this.stokSeriNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokSeriNoDataGridViewTextBoxColumn.Name = "stokSeriNoDataGridViewTextBoxColumn";
            this.stokSeriNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokAdediDataGridViewTextBoxColumn
            // 
            this.stokAdediDataGridViewTextBoxColumn.DataPropertyName = "StokAdedi";
            this.stokAdediDataGridViewTextBoxColumn.HeaderText = "StokAdedi";
            this.stokAdediDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokAdediDataGridViewTextBoxColumn.Name = "stokAdediDataGridViewTextBoxColumn";
            this.stokAdediDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokTarihiDataGridViewTextBoxColumn
            // 
            this.stokTarihiDataGridViewTextBoxColumn.DataPropertyName = "StokTarihi";
            this.stokTarihiDataGridViewTextBoxColumn.HeaderText = "StokTarihi";
            this.stokTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokTarihiDataGridViewTextBoxColumn.Name = "stokTarihiDataGridViewTextBoxColumn";
            this.stokTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kaydedenKisiDataGridViewTextBoxColumn
            // 
            this.kaydedenKisiDataGridViewTextBoxColumn.DataPropertyName = "KaydedenKisi";
            this.kaydedenKisiDataGridViewTextBoxColumn.HeaderText = "KaydedenKisi";
            this.kaydedenKisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kaydedenKisiDataGridViewTextBoxColumn.Name = "kaydedenKisiDataGridViewTextBoxColumn";
            this.kaydedenKisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(115, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stok Adı Ara";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(97, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 28);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgramlamaOdevDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokKayitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GorselProgramlamaOdevDataSet2 gorselProgramlamaOdevDataSet2;
        private System.Windows.Forms.BindingSource stokKayitBindingSource;
        private GorselProgramlamaOdevDataSet2TableAdapters.StokKayitTableAdapter stokKayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokModeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokSeriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAdediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaydedenKisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}