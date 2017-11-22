namespace RentalCars.UI
{
    partial class CarEditor
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
            this.engineNumberLabel = new System.Windows.Forms.Label();
            this.engineNumberTxt = new System.Windows.Forms.TextBox();
            this.wofDueLbl = new System.Windows.Forms.Label();
            this.wofDuePicker = new System.Windows.Forms.DateTimePicker();
            this.registrationDueDateLbl = new System.Windows.Forms.Label();
            this.registrationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.carColourLbl = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.carColourTxt = new System.Windows.Forms.TextBox();
            this.bodyStyleLbl = new System.Windows.Forms.Label();
            this.bodyStyleCombo = new System.Windows.Forms.ComboBox();
            this.brandLbl = new System.Windows.Forms.Label();
            this.brandTxt = new System.Windows.Forms.TextBox();
            this.modelTxtBox = new System.Windows.Forms.TextBox();
            this.modelLbl = new System.Windows.Forms.Label();
            this.yearOfManufactureDropDown = new System.Windows.Forms.NumericUpDown();
            this.yearOfManufactureLbl = new System.Windows.Forms.Label();
            this.engineSizePicker = new System.Windows.Forms.NumericUpDown();
            this.engineSizeLbl = new System.Windows.Forms.Label();
            this.passengerCapacityDropDown = new System.Windows.Forms.NumericUpDown();
            this.passengerCapcityLbl = new System.Windows.Forms.Label();
            this.totalSeatsLbl = new System.Windows.Forms.Label();
            this.totalSeatsDropDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.maxFuelCapacityDropDown = new System.Windows.Forms.NumericUpDown();
            this.rentChargePerDayDropDown = new System.Windows.Forms.NumericUpDown();
            this.rentChargePerDayLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceDropDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearOfManufactureDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineSizePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerCapacityDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSeatsDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxFuelCapacityDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentChargePerDayDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDropDown)).BeginInit();
            this.SuspendLayout();
            // 
            // engineNumberLabel
            // 
            this.engineNumberLabel.AutoSize = true;
            this.engineNumberLabel.Location = new System.Drawing.Point(241, 2);
            this.engineNumberLabel.Name = "engineNumberLabel";
            this.engineNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.engineNumberLabel.TabIndex = 1;
            this.engineNumberLabel.Text = "Engine Number";
            // 
            // engineNumberTxt
            // 
            this.engineNumberTxt.Location = new System.Drawing.Point(244, 15);
            this.engineNumberTxt.Name = "engineNumberTxt";
            this.engineNumberTxt.Size = new System.Drawing.Size(100, 22);
            this.engineNumberTxt.TabIndex = 2;
            // 
            // wofDueLbl
            // 
            this.wofDueLbl.AutoSize = true;
            this.wofDueLbl.Location = new System.Drawing.Point(123, 178);
            this.wofDueLbl.Name = "wofDueLbl";
            this.wofDueLbl.Size = new System.Drawing.Size(80, 13);
            this.wofDueLbl.TabIndex = 3;
            this.wofDueLbl.Text = "Wof Due Date";
            // 
            // wofDuePicker
            // 
            this.wofDuePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.wofDuePicker.Location = new System.Drawing.Point(123, 194);
            this.wofDuePicker.Name = "wofDuePicker";
            this.wofDuePicker.Size = new System.Drawing.Size(100, 22);
            this.wofDuePicker.TabIndex = 4;
            // 
            // registrationDueDateLbl
            // 
            this.registrationDueDateLbl.AutoSize = true;
            this.registrationDueDateLbl.Location = new System.Drawing.Point(-1, 181);
            this.registrationDueDateLbl.Name = "registrationDueDateLbl";
            this.registrationDueDateLbl.Size = new System.Drawing.Size(78, 13);
            this.registrationDueDateLbl.TabIndex = 5;
            this.registrationDueDateLbl.Text = "Reg Due Date";
            // 
            // registrationDatePicker
            // 
            this.registrationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.registrationDatePicker.Location = new System.Drawing.Point(2, 194);
            this.registrationDatePicker.Name = "registrationDatePicker";
            this.registrationDatePicker.Size = new System.Drawing.Size(100, 22);
            this.registrationDatePicker.TabIndex = 6;
            // 
            // carColourLbl
            // 
            this.carColourLbl.AutoSize = true;
            this.carColourLbl.Location = new System.Drawing.Point(362, 2);
            this.carColourLbl.Name = "carColourLbl";
            this.carColourLbl.Size = new System.Drawing.Size(42, 13);
            this.carColourLbl.TabIndex = 7;
            this.carColourLbl.Text = "Colour";
            // 
            // colorDialog1
            // 
            this.colorDialog1.SolidColorOnly = true;
            // 
            // carColourTxt
            // 
            this.carColourTxt.Location = new System.Drawing.Point(365, 15);
            this.carColourTxt.Name = "carColourTxt";
            this.carColourTxt.Size = new System.Drawing.Size(100, 22);
            this.carColourTxt.TabIndex = 8;
            // 
            // bodyStyleLbl
            // 
            this.bodyStyleLbl.AutoSize = true;
            this.bodyStyleLbl.Location = new System.Drawing.Point(362, 119);
            this.bodyStyleLbl.Name = "bodyStyleLbl";
            this.bodyStyleLbl.Size = new System.Drawing.Size(60, 13);
            this.bodyStyleLbl.TabIndex = 9;
            this.bodyStyleLbl.Text = "Body Style";
            // 
            // bodyStyleCombo
            // 
            this.bodyStyleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bodyStyleCombo.FormattingEnabled = true;
            this.bodyStyleCombo.Location = new System.Drawing.Point(365, 134);
            this.bodyStyleCombo.Name = "bodyStyleCombo";
            this.bodyStyleCombo.Size = new System.Drawing.Size(100, 21);
            this.bodyStyleCombo.TabIndex = 10;
            // 
            // brandLbl
            // 
            this.brandLbl.AutoSize = true;
            this.brandLbl.Location = new System.Drawing.Point(2, 2);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(38, 13);
            this.brandLbl.TabIndex = 11;
            this.brandLbl.Text = "Brand";
            // 
            // brandTxt
            // 
            this.brandTxt.Location = new System.Drawing.Point(2, 15);
            this.brandTxt.Name = "brandTxt";
            this.brandTxt.Size = new System.Drawing.Size(100, 22);
            this.brandTxt.TabIndex = 12;
            // 
            // modelTxtBox
            // 
            this.modelTxtBox.Location = new System.Drawing.Point(123, 15);
            this.modelTxtBox.Name = "modelTxtBox";
            this.modelTxtBox.Size = new System.Drawing.Size(100, 22);
            this.modelTxtBox.TabIndex = 13;
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Location = new System.Drawing.Point(120, 2);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(40, 13);
            this.modelLbl.TabIndex = 14;
            this.modelLbl.Text = "Model";
            // 
            // yearOfManufactureDropDown
            // 
            this.yearOfManufactureDropDown.Location = new System.Drawing.Point(2, 72);
            this.yearOfManufactureDropDown.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearOfManufactureDropDown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearOfManufactureDropDown.Name = "yearOfManufactureDropDown";
            this.yearOfManufactureDropDown.Size = new System.Drawing.Size(100, 22);
            this.yearOfManufactureDropDown.TabIndex = 15;
            this.yearOfManufactureDropDown.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // yearOfManufactureLbl
            // 
            this.yearOfManufactureLbl.AutoSize = true;
            this.yearOfManufactureLbl.Location = new System.Drawing.Point(-1, 59);
            this.yearOfManufactureLbl.Name = "yearOfManufactureLbl";
            this.yearOfManufactureLbl.Size = new System.Drawing.Size(110, 13);
            this.yearOfManufactureLbl.TabIndex = 16;
            this.yearOfManufactureLbl.Text = "Year of Manufacture";
            // 
            // engineSizePicker
            // 
            this.engineSizePicker.Location = new System.Drawing.Point(123, 72);
            this.engineSizePicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.engineSizePicker.Name = "engineSizePicker";
            this.engineSizePicker.Size = new System.Drawing.Size(100, 22);
            this.engineSizePicker.TabIndex = 17;
            this.engineSizePicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // engineSizeLbl
            // 
            this.engineSizeLbl.AutoSize = true;
            this.engineSizeLbl.Location = new System.Drawing.Point(120, 59);
            this.engineSizeLbl.Name = "engineSizeLbl";
            this.engineSizeLbl.Size = new System.Drawing.Size(66, 13);
            this.engineSizeLbl.TabIndex = 18;
            this.engineSizeLbl.Text = "Engine Size";
            // 
            // passengerCapacityDropDown
            // 
            this.passengerCapacityDropDown.Location = new System.Drawing.Point(244, 72);
            this.passengerCapacityDropDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.passengerCapacityDropDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passengerCapacityDropDown.Name = "passengerCapacityDropDown";
            this.passengerCapacityDropDown.Size = new System.Drawing.Size(100, 22);
            this.passengerCapacityDropDown.TabIndex = 19;
            this.passengerCapacityDropDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // passengerCapcityLbl
            // 
            this.passengerCapcityLbl.AutoSize = true;
            this.passengerCapcityLbl.Location = new System.Drawing.Point(241, 59);
            this.passengerCapcityLbl.Name = "passengerCapcityLbl";
            this.passengerCapcityLbl.Size = new System.Drawing.Size(105, 13);
            this.passengerCapcityLbl.TabIndex = 20;
            this.passengerCapcityLbl.Text = "Passenger Capacity";
            // 
            // totalSeatsLbl
            // 
            this.totalSeatsLbl.AutoSize = true;
            this.totalSeatsLbl.Location = new System.Drawing.Point(365, 58);
            this.totalSeatsLbl.Name = "totalSeatsLbl";
            this.totalSeatsLbl.Size = new System.Drawing.Size(61, 13);
            this.totalSeatsLbl.TabIndex = 21;
            this.totalSeatsLbl.Text = "Total Seats";
            // 
            // totalSeatsDropDown
            // 
            this.totalSeatsDropDown.Location = new System.Drawing.Point(365, 71);
            this.totalSeatsDropDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.totalSeatsDropDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.totalSeatsDropDown.Name = "totalSeatsDropDown";
            this.totalSeatsDropDown.Size = new System.Drawing.Size(100, 22);
            this.totalSeatsDropDown.TabIndex = 22;
            this.totalSeatsDropDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Max Fuel Capacity";
            // 
            // maxFuelCapacityDropDown
            // 
            this.maxFuelCapacityDropDown.Location = new System.Drawing.Point(2, 135);
            this.maxFuelCapacityDropDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maxFuelCapacityDropDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxFuelCapacityDropDown.Name = "maxFuelCapacityDropDown";
            this.maxFuelCapacityDropDown.Size = new System.Drawing.Size(100, 22);
            this.maxFuelCapacityDropDown.TabIndex = 24;
            this.maxFuelCapacityDropDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rentChargePerDayDropDown
            // 
            this.rentChargePerDayDropDown.Location = new System.Drawing.Point(123, 135);
            this.rentChargePerDayDropDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.rentChargePerDayDropDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rentChargePerDayDropDown.Name = "rentChargePerDayDropDown";
            this.rentChargePerDayDropDown.Size = new System.Drawing.Size(100, 22);
            this.rentChargePerDayDropDown.TabIndex = 25;
            this.rentChargePerDayDropDown.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // rentChargePerDayLbl
            // 
            this.rentChargePerDayLbl.AutoSize = true;
            this.rentChargePerDayLbl.Location = new System.Drawing.Point(123, 119);
            this.rentChargePerDayLbl.Name = "rentChargePerDayLbl";
            this.rentChargePerDayLbl.Size = new System.Drawing.Size(72, 13);
            this.rentChargePerDayLbl.TabIndex = 26;
            this.rentChargePerDayLbl.Text = "Rent Per Day";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(244, 194);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 22);
            this.SaveBtn.TabIndex = 27;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(241, 120);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(31, 13);
            this.priceLbl.TabIndex = 28;
            this.priceLbl.Text = "Price";
            // 
            // priceDropDown
            // 
            this.priceDropDown.Location = new System.Drawing.Point(244, 136);
            this.priceDropDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceDropDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceDropDown.Name = "priceDropDown";
            this.priceDropDown.Size = new System.Drawing.Size(100, 22);
            this.priceDropDown.TabIndex = 29;
            this.priceDropDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(365, 194);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 22);
            this.BtnCancel.TabIndex = 31;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CarEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 246);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceDropDown);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.rentChargePerDayLbl);
            this.Controls.Add(this.rentChargePerDayDropDown);
            this.Controls.Add(this.maxFuelCapacityDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalSeatsDropDown);
            this.Controls.Add(this.totalSeatsLbl);
            this.Controls.Add(this.passengerCapcityLbl);
            this.Controls.Add(this.passengerCapacityDropDown);
            this.Controls.Add(this.engineSizeLbl);
            this.Controls.Add(this.engineSizePicker);
            this.Controls.Add(this.yearOfManufactureLbl);
            this.Controls.Add(this.yearOfManufactureDropDown);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.modelTxtBox);
            this.Controls.Add(this.brandTxt);
            this.Controls.Add(this.brandLbl);
            this.Controls.Add(this.bodyStyleCombo);
            this.Controls.Add(this.bodyStyleLbl);
            this.Controls.Add(this.carColourTxt);
            this.Controls.Add(this.carColourLbl);
            this.Controls.Add(this.registrationDatePicker);
            this.Controls.Add(this.registrationDueDateLbl);
            this.Controls.Add(this.wofDuePicker);
            this.Controls.Add(this.wofDueLbl);
            this.Controls.Add(this.engineNumberTxt);
            this.Controls.Add(this.engineNumberLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CarEditor";
            this.Text = "CarEditor";
            this.Load += new System.EventHandler(this.CarEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearOfManufactureDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineSizePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerCapacityDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSeatsDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxFuelCapacityDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentChargePerDayDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDropDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label engineNumberLabel;
        private System.Windows.Forms.TextBox engineNumberTxt;
        private System.Windows.Forms.Label wofDueLbl;
        private System.Windows.Forms.DateTimePicker wofDuePicker;
        private System.Windows.Forms.Label registrationDueDateLbl;
        private System.Windows.Forms.DateTimePicker registrationDatePicker;
        private System.Windows.Forms.Label carColourLbl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox carColourTxt;
        private System.Windows.Forms.Label bodyStyleLbl;
        private System.Windows.Forms.ComboBox bodyStyleCombo;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.TextBox brandTxt;
        private System.Windows.Forms.TextBox modelTxtBox;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.NumericUpDown yearOfManufactureDropDown;
        private System.Windows.Forms.Label yearOfManufactureLbl;
        private System.Windows.Forms.NumericUpDown engineSizePicker;
        private System.Windows.Forms.Label engineSizeLbl;
        private System.Windows.Forms.NumericUpDown passengerCapacityDropDown;
        private System.Windows.Forms.Label passengerCapcityLbl;
        private System.Windows.Forms.Label totalSeatsLbl;
        private System.Windows.Forms.NumericUpDown totalSeatsDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown maxFuelCapacityDropDown;
        private System.Windows.Forms.NumericUpDown rentChargePerDayDropDown;
        private System.Windows.Forms.Label rentChargePerDayLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.NumericUpDown priceDropDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCancel;
    }
}