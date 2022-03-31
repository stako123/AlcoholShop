
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.alcoholBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcoholPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcohol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcoholBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlcohol
            // 
            this.dgvAlcohol.AutoGenerateColumns = false;
            this.dgvAlcohol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlcohol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.alcoholPercentDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.dgvAlcohol.DataSource = this.alcoholBindingSource;
            this.dgvAlcohol.Location = new System.Drawing.Point(12, 36);
            this.dgvAlcohol.Name = "dgvAlcohol";
            this.dgvAlcohol.Size = new System.Drawing.Size(344, 167);
            this.dgvAlcohol.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(379, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 48);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCreate
            // 
            this.txtCreate.Location = new System.Drawing.Point(508, 33);
            this.txtCreate.Multiline = true;
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(130, 51);
            this.txtCreate.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(665, 33);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 170);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPercent.Location = new System.Drawing.Point(379, 98);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(105, 48);
            this.lblPercent.TabIndex = 4;
            this.lblPercent.Text = "Procent";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(379, 158);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(105, 48);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(508, 155);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 51);
            this.txtPrice.TabIndex = 6;
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(508, 98);
            this.txtPercent.Multiline = true;
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(130, 51);
            this.txtPercent.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(665, 237);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 170);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // alcoholBindingSource
            // 
            this.alcoholBindingSource.DataSource = typeof(AlcoholShop.Model.Alcohol);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // alcoholPercentDataGridViewTextBoxColumn
            // 
            this.alcoholPercentDataGridViewTextBoxColumn.DataPropertyName = "Alcohol_Percent";
            this.alcoholPercentDataGridViewTextBoxColumn.HeaderText = "Alcohol_Percent";
            this.alcoholPercentDataGridViewTextBoxColumn.Name = "alcoholPercentDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // AlcoholView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlcoholShop.Properties.Resources.свали;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCreate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvAlcohol);
            this.Name = "AlcoholView";
            this.Text = "AlcoholView";
            this.Load += new System.EventHandler(this.AlcoholView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlcohol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcoholBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlcohol;
        private AlcoholDBDataSet alcoholDBDataSet;
        private AlcoholDBDataSetTableAdapters.AlcoholTableAdapter alcoholTableAdapter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcoholPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource alcoholBindingSource;
    }
}