namespace KanBagis
{
    partial class KanStok
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kangrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanstokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanstoguBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kanbagisDataSet5 = new KanBagis.kanbagisDataSet5();
            this.kanbagisDataSet4 = new KanBagis.kanbagisDataSet4();
            this.kanstoguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kan_stoguTableAdapter = new KanBagis.kanbagisDataSet4TableAdapters.kan_stoguTableAdapter();
            this.kan_stoguTableAdapter1 = new KanBagis.kanbagisDataSet5TableAdapters.kan_stoguTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanstoguBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbagisDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbagisDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanstoguBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kan Stoğu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kangrubuDataGridViewTextBoxColumn,
            this.kanstokDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kanstoguBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(115, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(364, 310);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kangrubuDataGridViewTextBoxColumn
            // 
            this.kangrubuDataGridViewTextBoxColumn.DataPropertyName = "kangrubu";
            this.kangrubuDataGridViewTextBoxColumn.HeaderText = "kangrubu";
            this.kangrubuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kangrubuDataGridViewTextBoxColumn.Name = "kangrubuDataGridViewTextBoxColumn";
            this.kangrubuDataGridViewTextBoxColumn.Width = 125;
            // 
            // kanstokDataGridViewTextBoxColumn
            // 
            this.kanstokDataGridViewTextBoxColumn.DataPropertyName = "kanstok";
            this.kanstokDataGridViewTextBoxColumn.HeaderText = "kanstok";
            this.kanstokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kanstokDataGridViewTextBoxColumn.Name = "kanstokDataGridViewTextBoxColumn";
            this.kanstokDataGridViewTextBoxColumn.Width = 125;
            // 
            // kanstoguBindingSource1
            // 
            this.kanstoguBindingSource1.DataMember = "kan_stogu";
            this.kanstoguBindingSource1.DataSource = this.kanbagisDataSet5;
            // 
            // kanbagisDataSet5
            // 
            this.kanbagisDataSet5.DataSetName = "kanbagisDataSet5";
            this.kanbagisDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kanbagisDataSet4
            // 
            this.kanbagisDataSet4.DataSetName = "kanbagisDataSet4";
            this.kanbagisDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kanstoguBindingSource
            // 
            this.kanstoguBindingSource.DataMember = "kan_stogu";
            this.kanstoguBindingSource.DataSource = this.kanbagisDataSet4;
            // 
            // kan_stoguTableAdapter
            // 
            this.kan_stoguTableAdapter.ClearBeforeFill = true;
            // 
            // kan_stoguTableAdapter1
            // 
            this.kan_stoguTableAdapter1.ClearBeforeFill = true;
            // 
            // KanStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 423);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "KanStok";
            this.Text = "KanStok";
            this.Load += new System.EventHandler(this.KanStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanstoguBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbagisDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbagisDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanstoguBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kanbagisDataSet4 kanbagisDataSet4;
        private System.Windows.Forms.BindingSource kanstoguBindingSource;
        private kanbagisDataSet4TableAdapters.kan_stoguTableAdapter kan_stoguTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kangrubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanstokDataGridViewTextBoxColumn;
        private kanbagisDataSet5 kanbagisDataSet5;
        private System.Windows.Forms.BindingSource kanstoguBindingSource1;
        private kanbagisDataSet5TableAdapters.kan_stoguTableAdapter kan_stoguTableAdapter1;
    }
}