namespace RentalCars.UI
{
    partial class IssueCar
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
            this.employeeDropDown = new System.Windows.Forms.ComboBox();
            this.customerDropDown = new System.Windows.Forms.ComboBox();
            this.durationUpDown = new System.Windows.Forms.NumericUpDown();
            this.availableCarsCheckList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IssueCarbtn = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDropDown
            // 
            this.employeeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDropDown.FormattingEnabled = true;
            this.employeeDropDown.Location = new System.Drawing.Point(2, 17);
            this.employeeDropDown.Name = "employeeDropDown";
            this.employeeDropDown.Size = new System.Drawing.Size(121, 21);
            this.employeeDropDown.TabIndex = 1;
            // 
            // customerDropDown
            // 
            this.customerDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerDropDown.FormattingEnabled = true;
            this.customerDropDown.Location = new System.Drawing.Point(2, 73);
            this.customerDropDown.Name = "customerDropDown";
            this.customerDropDown.Size = new System.Drawing.Size(121, 21);
            this.customerDropDown.TabIndex = 2;
            // 
            // durationUpDown
            // 
            this.durationUpDown.Location = new System.Drawing.Point(2, 128);
            this.durationUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationUpDown.Name = "durationUpDown";
            this.durationUpDown.Size = new System.Drawing.Size(120, 20);
            this.durationUpDown.TabIndex = 3;
            this.durationUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // availableCarsCheckList
            // 
            this.availableCarsCheckList.FormattingEnabled = true;
            this.availableCarsCheckList.Location = new System.Drawing.Point(154, 32);
            this.availableCarsCheckList.Name = "availableCarsCheckList";
            this.availableCarsCheckList.Size = new System.Drawing.Size(120, 94);
            this.availableCarsCheckList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duration In Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Available Cars";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(RentalCars.Car);
            // 
            // IssueCarbtn
            // 
            this.IssueCarbtn.Location = new System.Drawing.Point(309, 48);
            this.IssueCarbtn.Name = "IssueCarbtn";
            this.IssueCarbtn.Size = new System.Drawing.Size(75, 23);
            this.IssueCarbtn.TabIndex = 9;
            this.IssueCarbtn.Text = "Issue Car";
            this.IssueCarbtn.UseVisualStyleBackColor = true;
            this.IssueCarbtn.Click += new System.EventHandler(this.IssueCarbtn_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(309, 87);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // IssueCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 168);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.IssueCarbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.availableCarsCheckList);
            this.Controls.Add(this.durationUpDown);
            this.Controls.Add(this.customerDropDown);
            this.Controls.Add(this.employeeDropDown);
            this.Name = "IssueCar";
            this.Text = "IssueCar";
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.ComboBox employeeDropDown;
        private System.Windows.Forms.ComboBox customerDropDown;
        private System.Windows.Forms.NumericUpDown durationUpDown;
        private System.Windows.Forms.CheckedListBox availableCarsCheckList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button IssueCarbtn;
        private System.Windows.Forms.Button BtnCancel;
    }
}