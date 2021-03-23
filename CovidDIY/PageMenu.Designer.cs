namespace CovidDIY
{
    partial class PageMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.cOVID19BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOVID19DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOVID19DataSet = new CovidDIY.COVID19DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cOVID19TableAdapter = new CovidDIY.COVID19DataSetTableAdapters.COVID19TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.kabupatenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exposedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recoveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID19BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID19DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID19DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cOVID19BindingSource, "Kabupaten", true));
            this.txt_SearchName.Location = new System.Drawing.Point(352, 114);
            this.txt_SearchName.Multiline = true;
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(231, 28);
            this.txt_SearchName.TabIndex = 0;
            this.txt_SearchName.Tag = "";
            this.txt_SearchName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cOVID19BindingSource
            // 
            this.cOVID19BindingSource.DataMember = "COVID19";
            this.cOVID19BindingSource.DataSource = this.cOVID19DataSetBindingSource;
            // 
            // cOVID19DataSetBindingSource
            // 
            this.cOVID19DataSetBindingSource.DataSource = this.cOVID19DataSet;
            this.cOVID19DataSetBindingSource.Position = 0;
            // 
            // cOVID19DataSet
            // 
            this.cOVID19DataSet.DataSetName = "COVID19DataSet";
            this.cOVID19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by Kabupaten";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kabupatenDataGridViewTextBoxColumn,
            this.suspectedDataGridViewTextBoxColumn,
            this.exposedDataGridViewTextBoxColumn,
            this.infectedDataGridViewTextBoxColumn,
            this.recoveredDataGridViewTextBoxColumn,
            this.deadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOVID19BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 194);
            this.dataGridView1.TabIndex = 2;
            // 
            // cOVID19TableAdapter
            // 
            this.cOVID19TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "DAERAH ISTIMEWA YOGYAKARTA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_SearchName);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 471);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, -14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 90);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(177, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(491, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search Data Covid Per-Kabupaten";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // kabupatenDataGridViewTextBoxColumn
            // 
            this.kabupatenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kabupatenDataGridViewTextBoxColumn.DataPropertyName = "Kabupaten";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.kabupatenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.kabupatenDataGridViewTextBoxColumn.HeaderText = "Kabupaten";
            this.kabupatenDataGridViewTextBoxColumn.Name = "kabupatenDataGridViewTextBoxColumn";
            // 
            // suspectedDataGridViewTextBoxColumn
            // 
            this.suspectedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.suspectedDataGridViewTextBoxColumn.DataPropertyName = "Suspected";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.suspectedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.suspectedDataGridViewTextBoxColumn.HeaderText = "Suspected";
            this.suspectedDataGridViewTextBoxColumn.Name = "suspectedDataGridViewTextBoxColumn";
            // 
            // exposedDataGridViewTextBoxColumn
            // 
            this.exposedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exposedDataGridViewTextBoxColumn.DataPropertyName = "Exposed";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.exposedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.exposedDataGridViewTextBoxColumn.HeaderText = "Exposed";
            this.exposedDataGridViewTextBoxColumn.Name = "exposedDataGridViewTextBoxColumn";
            // 
            // infectedDataGridViewTextBoxColumn
            // 
            this.infectedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.infectedDataGridViewTextBoxColumn.DataPropertyName = "Infected";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.infectedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.infectedDataGridViewTextBoxColumn.HeaderText = "Infected";
            this.infectedDataGridViewTextBoxColumn.Name = "infectedDataGridViewTextBoxColumn";
            // 
            // recoveredDataGridViewTextBoxColumn
            // 
            this.recoveredDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recoveredDataGridViewTextBoxColumn.DataPropertyName = "Recovered";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.recoveredDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.recoveredDataGridViewTextBoxColumn.HeaderText = "Recovered";
            this.recoveredDataGridViewTextBoxColumn.Name = "recoveredDataGridViewTextBoxColumn";
            // 
            // deadDataGridViewTextBoxColumn
            // 
            this.deadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deadDataGridViewTextBoxColumn.DataPropertyName = "Dead";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.deadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.deadDataGridViewTextBoxColumn.HeaderText = "Dead";
            this.deadDataGridViewTextBoxColumn.Name = "deadDataGridViewTextBoxColumn";
            // 
            // PageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchRecord";
            this.Load += new System.EventHandler(this.PageMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOVID19BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID19DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID19DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cOVID19DataSetBindingSource;
        private COVID19DataSet cOVID19DataSet;
        private System.Windows.Forms.BindingSource cOVID19BindingSource;
        private COVID19DataSetTableAdapters.COVID19TableAdapter cOVID19TableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kabupatenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspectedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exposedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infectedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recoveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadDataGridViewTextBoxColumn;
    }
}