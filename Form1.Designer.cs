namespace Prog_122_Final
{
    partial class Form1
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
            this.gbAddCar = new System.Windows.Forms.GroupBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.lblAddCarOwner = new System.Windows.Forms.Label();
            this.lbAddCarOwner = new System.Windows.Forms.ListBox();
            this.tbAddCarMileage = new System.Windows.Forms.TextBox();
            this.lblAddCarMileage = new System.Windows.Forms.Label();
            this.gbAddCarFeatures = new System.Windows.Forms.GroupBox();
            this.chkAddCarBackUpCam = new System.Windows.Forms.CheckBox();
            this.chkAddCarGPS = new System.Windows.Forms.CheckBox();
            this.cbAddCarYear = new System.Windows.Forms.ComboBox();
            this.tbAddCarModel = new System.Windows.Forms.TextBox();
            this.lblAddCarYear = new System.Windows.Forms.Label();
            this.lblAddCarModel = new System.Windows.Forms.Label();
            this.gbAddCarMake = new System.Windows.Forms.GroupBox();
            this.rbAddCarNissan = new System.Windows.Forms.RadioButton();
            this.rbAddCarHonda = new System.Windows.Forms.RadioButton();
            this.rbAddCarToyota = new System.Windows.Forms.RadioButton();
            this.rbAddCarSubaru = new System.Windows.Forms.RadioButton();
            this.lvMainDisplay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFilterOptions = new System.Windows.Forms.GroupBox();
            this.lblFilterOptionsOwners = new System.Windows.Forms.Label();
            this.btnFilterByOwner = new System.Windows.Forms.Button();
            this.lbFilterOptionsOwners = new System.Windows.Forms.ListBox();
            this.gbFilterOptionsMileage = new System.Windows.Forms.GroupBox();
            this.btnFilterByMileage = new System.Windows.Forms.Button();
            this.lblFilterOptionsAbove = new System.Windows.Forms.Label();
            this.cbFilterOptionsMileage = new System.Windows.Forms.ComboBox();
            this.gbFilterOptionsYear = new System.Windows.Forms.GroupBox();
            this.btnFilterByYear = new System.Windows.Forms.Button();
            this.lblFilterOptionsTo = new System.Windows.Forms.Label();
            this.lblFilterOptionsFrom = new System.Windows.Forms.Label();
            this.cbFilterOptionsTo = new System.Windows.Forms.ComboBox();
            this.cbFilterOptionsFrom = new System.Windows.Forms.ComboBox();
            this.gbFilterOptionsMake = new System.Windows.Forms.GroupBox();
            this.btnFilterByMake = new System.Windows.Forms.Button();
            this.rbFilterOptionsNissan = new System.Windows.Forms.RadioButton();
            this.rbFilterOptionsHonda = new System.Windows.Forms.RadioButton();
            this.rbFilterOptionsToyota = new System.Windows.Forms.RadioButton();
            this.rbFilterOptionsSubaru = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAverageMileage = new System.Windows.Forms.Label();
            this.tbAverageMileage = new System.Windows.Forms.TextBox();
            this.gbAddCar.SuspendLayout();
            this.gbAddCarFeatures.SuspendLayout();
            this.gbAddCarMake.SuspendLayout();
            this.gbFilterOptions.SuspendLayout();
            this.gbFilterOptionsMileage.SuspendLayout();
            this.gbFilterOptionsYear.SuspendLayout();
            this.gbFilterOptionsMake.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddCar
            // 
            this.gbAddCar.Controls.Add(this.btnAddCar);
            this.gbAddCar.Controls.Add(this.lblAddCarOwner);
            this.gbAddCar.Controls.Add(this.lbAddCarOwner);
            this.gbAddCar.Controls.Add(this.tbAddCarMileage);
            this.gbAddCar.Controls.Add(this.lblAddCarMileage);
            this.gbAddCar.Controls.Add(this.gbAddCarFeatures);
            this.gbAddCar.Controls.Add(this.cbAddCarYear);
            this.gbAddCar.Controls.Add(this.tbAddCarModel);
            this.gbAddCar.Controls.Add(this.lblAddCarYear);
            this.gbAddCar.Controls.Add(this.lblAddCarModel);
            this.gbAddCar.Controls.Add(this.gbAddCarMake);
            this.gbAddCar.Location = new System.Drawing.Point(12, 12);
            this.gbAddCar.Name = "gbAddCar";
            this.gbAddCar.Size = new System.Drawing.Size(253, 790);
            this.gbAddCar.TabIndex = 0;
            this.gbAddCar.TabStop = false;
            this.gbAddCar.Text = "Add Car";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(9, 733);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(225, 39);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // lblAddCarOwner
            // 
            this.lblAddCarOwner.AutoSize = true;
            this.lblAddCarOwner.Location = new System.Drawing.Point(6, 484);
            this.lblAddCarOwner.Name = "lblAddCarOwner";
            this.lblAddCarOwner.Size = new System.Drawing.Size(45, 16);
            this.lblAddCarOwner.TabIndex = 3;
            this.lblAddCarOwner.Text = "Owner";
            // 
            // lbAddCarOwner
            // 
            this.lbAddCarOwner.FormattingEnabled = true;
            this.lbAddCarOwner.ItemHeight = 16;
            this.lbAddCarOwner.Location = new System.Drawing.Point(9, 515);
            this.lbAddCarOwner.Name = "lbAddCarOwner";
            this.lbAddCarOwner.Size = new System.Drawing.Size(225, 196);
            this.lbAddCarOwner.TabIndex = 7;
            // 
            // tbAddCarMileage
            // 
            this.tbAddCarMileage.Location = new System.Drawing.Point(9, 450);
            this.tbAddCarMileage.Name = "tbAddCarMileage";
            this.tbAddCarMileage.Size = new System.Drawing.Size(222, 22);
            this.tbAddCarMileage.TabIndex = 6;
            // 
            // lblAddCarMileage
            // 
            this.lblAddCarMileage.AutoSize = true;
            this.lblAddCarMileage.Location = new System.Drawing.Point(6, 419);
            this.lblAddCarMileage.Name = "lblAddCarMileage";
            this.lblAddCarMileage.Size = new System.Drawing.Size(56, 16);
            this.lblAddCarMileage.TabIndex = 2;
            this.lblAddCarMileage.Text = "Mileage";
            // 
            // gbAddCarFeatures
            // 
            this.gbAddCarFeatures.Controls.Add(this.chkAddCarBackUpCam);
            this.gbAddCarFeatures.Controls.Add(this.chkAddCarGPS);
            this.gbAddCarFeatures.Location = new System.Drawing.Point(9, 318);
            this.gbAddCarFeatures.Name = "gbAddCarFeatures";
            this.gbAddCarFeatures.Size = new System.Drawing.Size(225, 87);
            this.gbAddCarFeatures.TabIndex = 5;
            this.gbAddCarFeatures.TabStop = false;
            this.gbAddCarFeatures.Text = "Features";
            // 
            // chkAddCarBackUpCam
            // 
            this.chkAddCarBackUpCam.AutoSize = true;
            this.chkAddCarBackUpCam.Location = new System.Drawing.Point(52, 47);
            this.chkAddCarBackUpCam.Name = "chkAddCarBackUpCam";
            this.chkAddCarBackUpCam.Size = new System.Drawing.Size(112, 20);
            this.chkAddCarBackUpCam.TabIndex = 2;
            this.chkAddCarBackUpCam.Text = "Back Up Cam";
            this.chkAddCarBackUpCam.UseVisualStyleBackColor = true;
            // 
            // chkAddCarGPS
            // 
            this.chkAddCarGPS.AutoSize = true;
            this.chkAddCarGPS.Location = new System.Drawing.Point(52, 21);
            this.chkAddCarGPS.Name = "chkAddCarGPS";
            this.chkAddCarGPS.Size = new System.Drawing.Size(57, 20);
            this.chkAddCarGPS.TabIndex = 1;
            this.chkAddCarGPS.Text = "GPS";
            this.chkAddCarGPS.UseVisualStyleBackColor = true;
            // 
            // cbAddCarYear
            // 
            this.cbAddCarYear.FormattingEnabled = true;
            this.cbAddCarYear.Location = new System.Drawing.Point(9, 278);
            this.cbAddCarYear.Name = "cbAddCarYear";
            this.cbAddCarYear.Size = new System.Drawing.Size(222, 24);
            this.cbAddCarYear.TabIndex = 3;
            // 
            // tbAddCarModel
            // 
            this.tbAddCarModel.Location = new System.Drawing.Point(9, 210);
            this.tbAddCarModel.Name = "tbAddCarModel";
            this.tbAddCarModel.Size = new System.Drawing.Size(222, 22);
            this.tbAddCarModel.TabIndex = 4;
            // 
            // lblAddCarYear
            // 
            this.lblAddCarYear.AutoSize = true;
            this.lblAddCarYear.Location = new System.Drawing.Point(6, 250);
            this.lblAddCarYear.Name = "lblAddCarYear";
            this.lblAddCarYear.Size = new System.Drawing.Size(36, 16);
            this.lblAddCarYear.TabIndex = 1;
            this.lblAddCarYear.Text = "Year";
            // 
            // lblAddCarModel
            // 
            this.lblAddCarModel.AutoSize = true;
            this.lblAddCarModel.Location = new System.Drawing.Point(6, 191);
            this.lblAddCarModel.Name = "lblAddCarModel";
            this.lblAddCarModel.Size = new System.Drawing.Size(45, 16);
            this.lblAddCarModel.TabIndex = 3;
            this.lblAddCarModel.Text = "Model";
            // 
            // gbAddCarMake
            // 
            this.gbAddCarMake.AutoSize = true;
            this.gbAddCarMake.BackColor = System.Drawing.SystemColors.Control;
            this.gbAddCarMake.Controls.Add(this.rbAddCarNissan);
            this.gbAddCarMake.Controls.Add(this.rbAddCarHonda);
            this.gbAddCarMake.Controls.Add(this.rbAddCarToyota);
            this.gbAddCarMake.Controls.Add(this.rbAddCarSubaru);
            this.gbAddCarMake.Location = new System.Drawing.Point(9, 35);
            this.gbAddCarMake.Name = "gbAddCarMake";
            this.gbAddCarMake.Size = new System.Drawing.Size(225, 153);
            this.gbAddCarMake.TabIndex = 0;
            this.gbAddCarMake.TabStop = false;
            this.gbAddCarMake.Text = "Make";
            // 
            // rbAddCarNissan
            // 
            this.rbAddCarNissan.AutoSize = true;
            this.rbAddCarNissan.Location = new System.Drawing.Point(52, 110);
            this.rbAddCarNissan.Name = "rbAddCarNissan";
            this.rbAddCarNissan.Size = new System.Drawing.Size(70, 20);
            this.rbAddCarNissan.TabIndex = 3;
            this.rbAddCarNissan.TabStop = true;
            this.rbAddCarNissan.Text = "Nissan";
            this.rbAddCarNissan.UseVisualStyleBackColor = true;
            // 
            // rbAddCarHonda
            // 
            this.rbAddCarHonda.AutoSize = true;
            this.rbAddCarHonda.Location = new System.Drawing.Point(52, 84);
            this.rbAddCarHonda.Name = "rbAddCarHonda";
            this.rbAddCarHonda.Size = new System.Drawing.Size(69, 20);
            this.rbAddCarHonda.TabIndex = 4;
            this.rbAddCarHonda.TabStop = true;
            this.rbAddCarHonda.Text = "Honda";
            this.rbAddCarHonda.UseVisualStyleBackColor = true;
            // 
            // rbAddCarToyota
            // 
            this.rbAddCarToyota.AutoSize = true;
            this.rbAddCarToyota.Location = new System.Drawing.Point(52, 58);
            this.rbAddCarToyota.Name = "rbAddCarToyota";
            this.rbAddCarToyota.Size = new System.Drawing.Size(71, 20);
            this.rbAddCarToyota.TabIndex = 5;
            this.rbAddCarToyota.TabStop = true;
            this.rbAddCarToyota.Text = "Toyota";
            this.rbAddCarToyota.UseVisualStyleBackColor = true;
            // 
            // rbAddCarSubaru
            // 
            this.rbAddCarSubaru.AutoSize = true;
            this.rbAddCarSubaru.Location = new System.Drawing.Point(52, 32);
            this.rbAddCarSubaru.Name = "rbAddCarSubaru";
            this.rbAddCarSubaru.Size = new System.Drawing.Size(71, 20);
            this.rbAddCarSubaru.TabIndex = 6;
            this.rbAddCarSubaru.TabStop = true;
            this.rbAddCarSubaru.Text = "Subaru";
            this.rbAddCarSubaru.UseVisualStyleBackColor = true;
            // 
            // lvMainDisplay
            // 
            this.lvMainDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMainDisplay.HideSelection = false;
            this.lvMainDisplay.Location = new System.Drawing.Point(295, 12);
            this.lvMainDisplay.Name = "lvMainDisplay";
            this.lvMainDisplay.Size = new System.Drawing.Size(697, 672);
            this.lvMainDisplay.TabIndex = 1;
            this.lvMainDisplay.UseCompatibleStateImageBehavior = false;
            this.lvMainDisplay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Make";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Year";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "GPS";
            this.columnHeader4.Width = 62;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Backup Cam";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mileage";
            this.columnHeader6.Width = 109;
            // 
            // gbFilterOptions
            // 
            this.gbFilterOptions.Controls.Add(this.lblFilterOptionsOwners);
            this.gbFilterOptions.Controls.Add(this.btnFilterByOwner);
            this.gbFilterOptions.Controls.Add(this.lbFilterOptionsOwners);
            this.gbFilterOptions.Controls.Add(this.gbFilterOptionsMileage);
            this.gbFilterOptions.Controls.Add(this.gbFilterOptionsYear);
            this.gbFilterOptions.Controls.Add(this.gbFilterOptionsMake);
            this.gbFilterOptions.Location = new System.Drawing.Point(1019, 12);
            this.gbFilterOptions.Name = "gbFilterOptions";
            this.gbFilterOptions.Size = new System.Drawing.Size(318, 790);
            this.gbFilterOptions.TabIndex = 2;
            this.gbFilterOptions.TabStop = false;
            this.gbFilterOptions.Text = "Filter Options";
            // 
            // lblFilterOptionsOwners
            // 
            this.lblFilterOptionsOwners.AutoSize = true;
            this.lblFilterOptionsOwners.Location = new System.Drawing.Point(6, 545);
            this.lblFilterOptionsOwners.Name = "lblFilterOptionsOwners";
            this.lblFilterOptionsOwners.Size = new System.Drawing.Size(52, 16);
            this.lblFilterOptionsOwners.TabIndex = 6;
            this.lblFilterOptionsOwners.Text = "Owners";
            // 
            // btnFilterByOwner
            // 
            this.btnFilterByOwner.Location = new System.Drawing.Point(44, 734);
            this.btnFilterByOwner.Name = "btnFilterByOwner";
            this.btnFilterByOwner.Size = new System.Drawing.Size(231, 37);
            this.btnFilterByOwner.TabIndex = 5;
            this.btnFilterByOwner.Text = "Filter By Owner";
            this.btnFilterByOwner.UseVisualStyleBackColor = true;
            this.btnFilterByOwner.Click += new System.EventHandler(this.btnFilterByOwner_Click);
            // 
            // lbFilterOptionsOwners
            // 
            this.lbFilterOptionsOwners.FormattingEnabled = true;
            this.lbFilterOptionsOwners.ItemHeight = 16;
            this.lbFilterOptionsOwners.Location = new System.Drawing.Point(7, 575);
            this.lbFilterOptionsOwners.Name = "lbFilterOptionsOwners";
            this.lbFilterOptionsOwners.Size = new System.Drawing.Size(305, 148);
            this.lbFilterOptionsOwners.TabIndex = 4;
            // 
            // gbFilterOptionsMileage
            // 
            this.gbFilterOptionsMileage.Controls.Add(this.btnFilterByMileage);
            this.gbFilterOptionsMileage.Controls.Add(this.lblFilterOptionsAbove);
            this.gbFilterOptionsMileage.Controls.Add(this.cbFilterOptionsMileage);
            this.gbFilterOptionsMileage.Location = new System.Drawing.Point(7, 400);
            this.gbFilterOptionsMileage.Name = "gbFilterOptionsMileage";
            this.gbFilterOptionsMileage.Size = new System.Drawing.Size(231, 124);
            this.gbFilterOptionsMileage.TabIndex = 3;
            this.gbFilterOptionsMileage.TabStop = false;
            this.gbFilterOptionsMileage.Text = "Mileage";
            // 
            // btnFilterByMileage
            // 
            this.btnFilterByMileage.Location = new System.Drawing.Point(9, 72);
            this.btnFilterByMileage.Name = "btnFilterByMileage";
            this.btnFilterByMileage.Size = new System.Drawing.Size(216, 46);
            this.btnFilterByMileage.TabIndex = 7;
            this.btnFilterByMileage.Text = "Filter By Mileage";
            this.btnFilterByMileage.UseVisualStyleBackColor = true;
            this.btnFilterByMileage.Click += new System.EventHandler(this.btnFilterByMileage_Click);
            // 
            // lblFilterOptionsAbove
            // 
            this.lblFilterOptionsAbove.AutoSize = true;
            this.lblFilterOptionsAbove.Location = new System.Drawing.Point(6, 33);
            this.lblFilterOptionsAbove.Name = "lblFilterOptionsAbove";
            this.lblFilterOptionsAbove.Size = new System.Drawing.Size(47, 16);
            this.lblFilterOptionsAbove.TabIndex = 6;
            this.lblFilterOptionsAbove.Text = "Above";
            // 
            // cbFilterOptionsMileage
            // 
            this.cbFilterOptionsMileage.FormattingEnabled = true;
            this.cbFilterOptionsMileage.Location = new System.Drawing.Point(68, 30);
            this.cbFilterOptionsMileage.Name = "cbFilterOptionsMileage";
            this.cbFilterOptionsMileage.Size = new System.Drawing.Size(157, 24);
            this.cbFilterOptionsMileage.TabIndex = 5;
            // 
            // gbFilterOptionsYear
            // 
            this.gbFilterOptionsYear.Controls.Add(this.btnFilterByYear);
            this.gbFilterOptionsYear.Controls.Add(this.lblFilterOptionsTo);
            this.gbFilterOptionsYear.Controls.Add(this.lblFilterOptionsFrom);
            this.gbFilterOptionsYear.Controls.Add(this.cbFilterOptionsTo);
            this.gbFilterOptionsYear.Controls.Add(this.cbFilterOptionsFrom);
            this.gbFilterOptionsYear.Location = new System.Drawing.Point(7, 238);
            this.gbFilterOptionsYear.Name = "gbFilterOptionsYear";
            this.gbFilterOptionsYear.Size = new System.Drawing.Size(231, 147);
            this.gbFilterOptionsYear.TabIndex = 1;
            this.gbFilterOptionsYear.TabStop = false;
            this.gbFilterOptionsYear.Text = "Year";
            // 
            // btnFilterByYear
            // 
            this.btnFilterByYear.Location = new System.Drawing.Point(9, 93);
            this.btnFilterByYear.Name = "btnFilterByYear";
            this.btnFilterByYear.Size = new System.Drawing.Size(216, 48);
            this.btnFilterByYear.TabIndex = 6;
            this.btnFilterByYear.Text = "Filter By Year";
            this.btnFilterByYear.UseVisualStyleBackColor = true;
            this.btnFilterByYear.Click += new System.EventHandler(this.btnFilterByYear_Click);
            // 
            // lblFilterOptionsTo
            // 
            this.lblFilterOptionsTo.AutoSize = true;
            this.lblFilterOptionsTo.Location = new System.Drawing.Point(6, 66);
            this.lblFilterOptionsTo.Name = "lblFilterOptionsTo";
            this.lblFilterOptionsTo.Size = new System.Drawing.Size(24, 16);
            this.lblFilterOptionsTo.TabIndex = 4;
            this.lblFilterOptionsTo.Text = "To";
            // 
            // lblFilterOptionsFrom
            // 
            this.lblFilterOptionsFrom.AutoSize = true;
            this.lblFilterOptionsFrom.Location = new System.Drawing.Point(6, 24);
            this.lblFilterOptionsFrom.Name = "lblFilterOptionsFrom";
            this.lblFilterOptionsFrom.Size = new System.Drawing.Size(38, 16);
            this.lblFilterOptionsFrom.TabIndex = 5;
            this.lblFilterOptionsFrom.Text = "From";
            // 
            // cbFilterOptionsTo
            // 
            this.cbFilterOptionsTo.FormattingEnabled = true;
            this.cbFilterOptionsTo.Location = new System.Drawing.Point(68, 63);
            this.cbFilterOptionsTo.Name = "cbFilterOptionsTo";
            this.cbFilterOptionsTo.Size = new System.Drawing.Size(157, 24);
            this.cbFilterOptionsTo.TabIndex = 4;
            // 
            // cbFilterOptionsFrom
            // 
            this.cbFilterOptionsFrom.FormattingEnabled = true;
            this.cbFilterOptionsFrom.Location = new System.Drawing.Point(68, 21);
            this.cbFilterOptionsFrom.Name = "cbFilterOptionsFrom";
            this.cbFilterOptionsFrom.Size = new System.Drawing.Size(157, 24);
            this.cbFilterOptionsFrom.TabIndex = 3;
            // 
            // gbFilterOptionsMake
            // 
            this.gbFilterOptionsMake.Controls.Add(this.btnFilterByMake);
            this.gbFilterOptionsMake.Controls.Add(this.rbFilterOptionsNissan);
            this.gbFilterOptionsMake.Controls.Add(this.rbFilterOptionsHonda);
            this.gbFilterOptionsMake.Controls.Add(this.rbFilterOptionsToyota);
            this.gbFilterOptionsMake.Controls.Add(this.rbFilterOptionsSubaru);
            this.gbFilterOptionsMake.Location = new System.Drawing.Point(7, 22);
            this.gbFilterOptionsMake.Name = "gbFilterOptionsMake";
            this.gbFilterOptionsMake.Size = new System.Drawing.Size(231, 210);
            this.gbFilterOptionsMake.TabIndex = 0;
            this.gbFilterOptionsMake.TabStop = false;
            this.gbFilterOptionsMake.Text = "Make";
            // 
            // btnFilterByMake
            // 
            this.btnFilterByMake.Location = new System.Drawing.Point(6, 161);
            this.btnFilterByMake.Name = "btnFilterByMake";
            this.btnFilterByMake.Size = new System.Drawing.Size(219, 43);
            this.btnFilterByMake.TabIndex = 11;
            this.btnFilterByMake.Text = "Filter By Make";
            this.btnFilterByMake.UseVisualStyleBackColor = true;
            this.btnFilterByMake.Click += new System.EventHandler(this.btnFilterByMake_Click);
            // 
            // rbFilterOptionsNissan
            // 
            this.rbFilterOptionsNissan.AutoSize = true;
            this.rbFilterOptionsNissan.Location = new System.Drawing.Point(77, 113);
            this.rbFilterOptionsNissan.Name = "rbFilterOptionsNissan";
            this.rbFilterOptionsNissan.Size = new System.Drawing.Size(70, 20);
            this.rbFilterOptionsNissan.TabIndex = 7;
            this.rbFilterOptionsNissan.TabStop = true;
            this.rbFilterOptionsNissan.Text = "Nissan";
            this.rbFilterOptionsNissan.UseVisualStyleBackColor = true;
            // 
            // rbFilterOptionsHonda
            // 
            this.rbFilterOptionsHonda.AutoSize = true;
            this.rbFilterOptionsHonda.Location = new System.Drawing.Point(77, 87);
            this.rbFilterOptionsHonda.Name = "rbFilterOptionsHonda";
            this.rbFilterOptionsHonda.Size = new System.Drawing.Size(69, 20);
            this.rbFilterOptionsHonda.TabIndex = 8;
            this.rbFilterOptionsHonda.TabStop = true;
            this.rbFilterOptionsHonda.Text = "Honda";
            this.rbFilterOptionsHonda.UseVisualStyleBackColor = true;
            // 
            // rbFilterOptionsToyota
            // 
            this.rbFilterOptionsToyota.AutoSize = true;
            this.rbFilterOptionsToyota.Location = new System.Drawing.Point(77, 61);
            this.rbFilterOptionsToyota.Name = "rbFilterOptionsToyota";
            this.rbFilterOptionsToyota.Size = new System.Drawing.Size(71, 20);
            this.rbFilterOptionsToyota.TabIndex = 9;
            this.rbFilterOptionsToyota.TabStop = true;
            this.rbFilterOptionsToyota.Text = "Toyota";
            this.rbFilterOptionsToyota.UseVisualStyleBackColor = true;
            // 
            // rbFilterOptionsSubaru
            // 
            this.rbFilterOptionsSubaru.AutoSize = true;
            this.rbFilterOptionsSubaru.Location = new System.Drawing.Point(77, 35);
            this.rbFilterOptionsSubaru.Name = "rbFilterOptionsSubaru";
            this.rbFilterOptionsSubaru.Size = new System.Drawing.Size(71, 20);
            this.rbFilterOptionsSubaru.TabIndex = 10;
            this.rbFilterOptionsSubaru.TabStop = true;
            this.rbFilterOptionsSubaru.Text = "Subaru";
            this.rbFilterOptionsSubaru.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(563, 712);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(259, 72);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblAverageMileage
            // 
            this.lblAverageMileage.AutoSize = true;
            this.lblAverageMileage.Location = new System.Drawing.Point(291, 704);
            this.lblAverageMileage.Name = "lblAverageMileage";
            this.lblAverageMileage.Size = new System.Drawing.Size(111, 16);
            this.lblAverageMileage.TabIndex = 5;
            this.lblAverageMileage.Text = "Average Mileage";
            // 
            // tbAverageMileage
            // 
            this.tbAverageMileage.Location = new System.Drawing.Point(408, 701);
            this.tbAverageMileage.Name = "tbAverageMileage";
            this.tbAverageMileage.Size = new System.Drawing.Size(149, 22);
            this.tbAverageMileage.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 814);
            this.Controls.Add(this.tbAverageMileage);
            this.Controls.Add(this.lblAverageMileage);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbFilterOptions);
            this.Controls.Add(this.lvMainDisplay);
            this.Controls.Add(this.gbAddCar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAddCar.ResumeLayout(false);
            this.gbAddCar.PerformLayout();
            this.gbAddCarFeatures.ResumeLayout(false);
            this.gbAddCarFeatures.PerformLayout();
            this.gbAddCarMake.ResumeLayout(false);
            this.gbAddCarMake.PerformLayout();
            this.gbFilterOptions.ResumeLayout(false);
            this.gbFilterOptions.PerformLayout();
            this.gbFilterOptionsMileage.ResumeLayout(false);
            this.gbFilterOptionsMileage.PerformLayout();
            this.gbFilterOptionsYear.ResumeLayout(false);
            this.gbFilterOptionsYear.PerformLayout();
            this.gbFilterOptionsMake.ResumeLayout(false);
            this.gbFilterOptionsMake.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddCar;
        private System.Windows.Forms.GroupBox gbAddCarFeatures;
        private System.Windows.Forms.ComboBox cbAddCarYear;
        private System.Windows.Forms.TextBox tbAddCarModel;
        private System.Windows.Forms.Label lblAddCarYear;
        private System.Windows.Forms.Label lblAddCarModel;
        private System.Windows.Forms.GroupBox gbAddCarMake;
        private System.Windows.Forms.RadioButton rbAddCarNissan;
        private System.Windows.Forms.RadioButton rbAddCarHonda;
        private System.Windows.Forms.RadioButton rbAddCarToyota;
        private System.Windows.Forms.RadioButton rbAddCarSubaru;
        private System.Windows.Forms.Label lblAddCarMileage;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Label lblAddCarOwner;
        private System.Windows.Forms.ListBox lbAddCarOwner;
        private System.Windows.Forms.TextBox tbAddCarMileage;
        private System.Windows.Forms.CheckBox chkAddCarBackUpCam;
        private System.Windows.Forms.CheckBox chkAddCarGPS;
        private System.Windows.Forms.ListView lvMainDisplay;
        private System.Windows.Forms.GroupBox gbFilterOptions;
        private System.Windows.Forms.Label lblFilterOptionsOwners;
        private System.Windows.Forms.Button btnFilterByOwner;
        private System.Windows.Forms.ListBox lbFilterOptionsOwners;
        private System.Windows.Forms.GroupBox gbFilterOptionsMileage;
        private System.Windows.Forms.GroupBox gbFilterOptionsYear;
        private System.Windows.Forms.GroupBox gbFilterOptionsMake;
        private System.Windows.Forms.Label lblFilterOptionsTo;
        private System.Windows.Forms.Label lblFilterOptionsFrom;
        private System.Windows.Forms.ComboBox cbFilterOptionsTo;
        private System.Windows.Forms.ComboBox cbFilterOptionsFrom;
        private System.Windows.Forms.Button btnFilterByMake;
        private System.Windows.Forms.RadioButton rbFilterOptionsNissan;
        private System.Windows.Forms.RadioButton rbFilterOptionsHonda;
        private System.Windows.Forms.RadioButton rbFilterOptionsToyota;
        private System.Windows.Forms.RadioButton rbFilterOptionsSubaru;
        private System.Windows.Forms.Button btnFilterByMileage;
        private System.Windows.Forms.Label lblFilterOptionsAbove;
        private System.Windows.Forms.ComboBox cbFilterOptionsMileage;
        private System.Windows.Forms.Button btnFilterByYear;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblAverageMileage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox tbAverageMileage;
    }
}

