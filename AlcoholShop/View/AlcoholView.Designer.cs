
namespace AlcoholShop.View
{
    partial class AlcoholView
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
            this.dgvAlcohol = new System.Windows.Forms.DataGridView();
            this.alcoholDBDataSet = new AlcoholShop.AlcoholDBDataSet();
            this.alcoholBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alcoholTableAdapter = new AlcoholShop.AlcoholDBDataSetTableAdapters.AlcoholTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcoholPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcoholBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcohol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcoholDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcoholBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcoholBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlcohol
            // 
            this.dgvAlcohol.AutoGenerateColumns = false;
            this.dgvAlcohol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlcohol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.alcoholPercentDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvAlcohol.DataSource = this.alcoholBindingSource1;
            this.dgvAlcohol.Location = new System.Drawing.Point(82, 47);
            this.dgvAlcohol.Name = "dgvAlcohol";
            this.dgvAlcohol.Size = new System.Drawing.Size(343, 151);
            this.dgvAlcohol.TabIndex = 0;
            // 
            // alcoholDBDataSet
            // 
            this.alcoholDBDataSet.DataSetName = "AlcoholDBDataSet";
            this.alcoholDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alcoholBindingSource
            // 
            this.alcoholBindingSource.DataMember = "Alcohol";
            this.alcoholBindingSource.DataSource = this.alcoholDBDataSet;
            // 
            // alcoholTableAdapter
            // 
            this.alcoholTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // alcoholPercentDataGridViewTextBoxColumn
            // 
            this.alcoholPercentDataGridViewTextBoxColumn.DataPropertyName = "Alcohol_Percent";
            this.alcoholPercentDataGridViewTextBoxColumn.HeaderText = "Alcohol_Percent";
            this.alcoholPercentDataGridViewTextBoxColumn.Name = "alcoholPercentDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // alcoholBindingSource1
            // 
            this.alcoholBindingSource1.DataSource = typeof(AlcoholShop.Model.Alcohol);
            // 
            // AlcoholView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAlcohol);
            this.Name = "AlcoholView";
            this.Text = "AlcoholView";
            this.Load += new System.EventHandler(this.AlcoholView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcohol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcoholDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcoholBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcoholBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlcohol;
        private AlcoholDBDataSet alcoholDBDataSet;
        private System.Windows.Forms.BindingSource alcoholBindingSource;
        private AlcoholDBDataSetTableAdapters.AlcoholTableAdapter alcoholTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcoholPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alcoholBindingSource1;
    }
}