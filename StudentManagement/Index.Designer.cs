namespace StudentManagement
{
    partial class Index
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewChart = new System.Windows.Forms.Button();
            this.btnAddNewStu = new System.Windows.Forms.Button();
            this.qLSVienDataSet = new StudentManagement.QLSVienDataSet();
            this.sVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sVIENTableAdapter = new StudentManagement.QLSVienDataSetTableAdapters.SVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load from DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(531, 337);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "C# .NET Student Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnViewChart);
            this.panel1.Controls.Add(this.btnAddNewStu);
            this.panel1.Location = new System.Drawing.Point(10, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 48);
            this.panel1.TabIndex = 4;
            // 
            // btnViewChart
            // 
            this.btnViewChart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnViewChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnViewChart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewChart.Location = new System.Drawing.Point(226, 3);
            this.btnViewChart.Name = "btnViewChart";
            this.btnViewChart.Size = new System.Drawing.Size(128, 44);
            this.btnViewChart.TabIndex = 1;
            this.btnViewChart.Text = "View Chart";
            this.btnViewChart.UseVisualStyleBackColor = false;
            this.btnViewChart.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnAddNewStu
            // 
            this.btnAddNewStu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNewStu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddNewStu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewStu.Location = new System.Drawing.Point(359, 2);
            this.btnAddNewStu.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewStu.Name = "btnAddNewStu";
            this.btnAddNewStu.Size = new System.Drawing.Size(170, 46);
            this.btnAddNewStu.TabIndex = 0;
            this.btnAddNewStu.Text = "Add new student";
            this.btnAddNewStu.UseVisualStyleBackColor = false;
            this.btnAddNewStu.Click += new System.EventHandler(this.button2_Click);
            // 
            // qLSVienDataSet
            // 
            this.qLSVienDataSet.DataSetName = "QLSVienDataSet";
            this.qLSVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sVIENBindingSource
            // 
            this.sVIENBindingSource.DataMember = "SVIEN";
            this.sVIENBindingSource.DataSource = this.qLSVienDataSet;
            // 
            // sVIENTableAdapter
            // 
            this.sVIENTableAdapter.ClearBeforeFill = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Index";
            this.Text = "Student Management";
            this.Activated += new System.EventHandler(this.Index_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLSVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private QLSVienDataSet qLSVienDataSet;
        private System.Windows.Forms.BindingSource sVIENBindingSource;
        private QLSVienDataSetTableAdapters.SVIENTableAdapter sVIENTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNewStu;
        private System.Windows.Forms.Button btnViewChart;
    }
}

