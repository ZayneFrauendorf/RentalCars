namespace RentalCars.UI
{
   public partial class AvailableCarsList
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
            this.Close = new System.Windows.Forms.Button();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodystyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNGINENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wOFDueAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand,
            this.CarModel,
            this.statusDataGridViewTextBoxColumn,
            this.bodystyleDataGridViewTextBoxColumn,
            this.registrationDueDateDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.eNGINENUMBERDataGridViewTextBoxColumn,
            this.wOFDueAtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(776, 194);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(RentalCars.Car);
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // CarModel
            // 
            this.CarModel.DataPropertyName = "CarModel";
            this.CarModel.HeaderText = "Car Model";
            this.CarModel.Name = "CarModel";
            this.CarModel.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodystyleDataGridViewTextBoxColumn
            // 
            this.bodystyleDataGridViewTextBoxColumn.DataPropertyName = "Bodystyle";
            this.bodystyleDataGridViewTextBoxColumn.HeaderText = "Body Style";
            this.bodystyleDataGridViewTextBoxColumn.Name = "bodystyleDataGridViewTextBoxColumn";
            this.bodystyleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registrationDueDateDataGridViewTextBoxColumn
            // 
            this.registrationDueDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDueDate";
            this.registrationDueDateDataGridViewTextBoxColumn.HeaderText = "Reg Due Date";
            this.registrationDueDateDataGridViewTextBoxColumn.Name = "registrationDueDateDataGridViewTextBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            this.colourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNGINENUMBERDataGridViewTextBoxColumn
            // 
            this.eNGINENUMBERDataGridViewTextBoxColumn.DataPropertyName = "ENGINENUMBER";
            this.eNGINENUMBERDataGridViewTextBoxColumn.HeaderText = "Engine Number";
            this.eNGINENUMBERDataGridViewTextBoxColumn.Name = "eNGINENUMBERDataGridViewTextBoxColumn";
            this.eNGINENUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wOFDueAtDataGridViewTextBoxColumn
            // 
            this.wOFDueAtDataGridViewTextBoxColumn.DataPropertyName = "WOFDueAt";
            this.wOFDueAtDataGridViewTextBoxColumn.HeaderText = "WOF Due Date";
            this.wOFDueAtDataGridViewTextBoxColumn.Name = "wOFDueAtDataGridViewTextBoxColumn";
            // 
            // AvailableCarsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 257);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AvailableCarsList";
            this.Text = "List of Available Cars";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodystyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNGINENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wOFDueAtDataGridViewTextBoxColumn;
    }
}