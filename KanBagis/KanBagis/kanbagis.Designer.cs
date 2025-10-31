namespace KanBagis
{
    partial class kanbagis
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
            this.kangrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanstokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanstoguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kanbagisDataSet8 = new KanBagis.kanbagisDataSet8();
            this.kan_stoguTableAdapter = new KanBagis.kanbagisDataSet8TableAdapters.kan_stoguTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kangrubuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kanbagisDataSet9 = new KanBagis.kanbagisDataSet9();
            this.donorTableAdapter = new KanBagis.kanbagisDataSet9TableAdapters.donorTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanstoguBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbagisDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbagisDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kangrubuDataGridViewTextBoxColumn,
            this.kanstokDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kanstoguBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(353, 263);
            this.dataGridView1.TabIndex = 0;
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
            // kanstoguBindingSource
            // 
            this.kanstoguBindingSource.DataMember = "kan_stogu";
            this.kanstoguBindingSource.DataSource = this.kanbagisDataSet8;
            // 
            // kanbagisDataSet8
            // 
            this.kanbagisDataSet8.DataSetName = "kanbagisDataSet8";
            this.kanbagisDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kan_stoguTableAdapter
            // 
            this.kan_stoguTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adsoyadDataGridViewTextBoxColumn,
            this.yasDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.kangrubuDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.donorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(396, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(570, 263);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "ad_soyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "ad_soyad";
            this.adsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            this.adsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yasDataGridViewTextBoxColumn
            // 
            this.yasDataGridViewTextBoxColumn.DataPropertyName = "yas";
            this.yasDataGridViewTextBoxColumn.HeaderText = "yas";
            this.yasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yasDataGridViewTextBoxColumn.Name = "yasDataGridViewTextBoxColumn";
            this.yasDataGridViewTextBoxColumn.Width = 125;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // kangrubuDataGridViewTextBoxColumn1
            // 
            this.kangrubuDataGridViewTextBoxColumn1.DataPropertyName = "kangrubu";
            this.kangrubuDataGridViewTextBoxColumn1.HeaderText = "kangrubu";
            this.kangrubuDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kangrubuDataGridViewTextBoxColumn1.Name = "kangrubuDataGridViewTextBoxColumn1";
            this.kangrubuDataGridViewTextBoxColumn1.Width = 125;
            // 
            // donorBindingSource
            // 
            this.donorBindingSource.DataMember = "donor";
            this.donorBindingSource.DataSource = this.kanbagisDataSet9;
            // 
            // kanbagisDataSet9
            // 
            this.kanbagisDataSet9.DataSetName = "kanbagisDataSet9";
            this.kanbagisDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorTableAdapter
            // 
            this.donorTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kan Grubu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(298, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kan Bağışla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(489, 319);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // kanbagis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kanbagis";
            this.Text = "kanbagis";
            this.Load += new System.EventHandler(this.kanbagis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanstoguBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbagisDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbagisDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kanbagisDataSet8 kanbagisDataSet8;
        private System.Windows.Forms.BindingSource kanstoguBindingSource;
        private kanbagisDataSet8TableAdapters.kan_stoguTableAdapter kan_stoguTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kangrubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanstokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private kanbagisDataSet9 kanbagisDataSet9;
        private System.Windows.Forms.BindingSource donorBindingSource;
        private kanbagisDataSet9TableAdapters.donorTableAdapter donorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kangrubuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}