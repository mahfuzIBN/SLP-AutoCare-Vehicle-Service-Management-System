namespace VehicleServiceCenter
{
    partial class VehicleEditForm
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
            btnSave = new Button();
            btnCancel = new Button();
            blSubtitle = new Label();
            lblTitle = new Label();
            label1 = new Label();
            cmbCustomer = new ComboBox();
            lblRegistrationNumber = new Label();
            txtRegistrationNumber = new TextBox();
            lblBrand = new Label();
            txtBrand = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblVehicleType = new Label();
            cmbVehicleType = new ComboBox();
            lblManufacturingYear = new Label();
            nudManufacturingYear = new NumericUpDown();
            picVehicle = new PictureBox();
            lblVehiclePhoto = new Label();
            btnBrowseImage = new Button();
            ((System.ComponentModel.ISupportInitialize)nudManufacturingYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVehicle).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(425, 540);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 42);
            btnSave.TabIndex = 15;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.DarkSlateGray;
            btnCancel.Location = new Point(235, 540);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 42);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // blSubtitle
            // 
            blSubtitle.AutoSize = true;
            blSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            blSubtitle.ForeColor = Color.DimGray;
            blSubtitle.Location = new Point(40, 68);
            blSubtitle.Name = "blSubtitle";
            blSubtitle.Size = new Size(175, 20);
            blSubtitle.TabIndex = 13;
            blSubtitle.Text = "Enter vehicle information";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(40, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 46);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Add Vehicle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 120);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 16;
            label1.Text = "Customer";
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(40, 145);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(320, 28);
            cmbCustomer.TabIndex = 17;
            // 
            // lblRegistrationNumber
            // 
            lblRegistrationNumber.AutoSize = true;
            lblRegistrationNumber.Location = new Point(40, 190);
            lblRegistrationNumber.Name = "lblRegistrationNumber";
            lblRegistrationNumber.Size = new Size(116, 20);
            lblRegistrationNumber.TabIndex = 18;
            lblRegistrationNumber.Text = "Registration No.";
            // 
            // txtRegistrationNumber
            // 
            txtRegistrationNumber.Location = new Point(40, 215);
            txtRegistrationNumber.Name = "txtRegistrationNumber";
            txtRegistrationNumber.Size = new Size(320, 27);
            txtRegistrationNumber.TabIndex = 19;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(40, 260);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(48, 20);
            lblBrand.TabIndex = 20;
            lblBrand.Text = "Brand";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(40, 285);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(320, 27);
            txtBrand.TabIndex = 21;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(40, 330);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 22;
            lblModel.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(40, 355);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(320, 27);
            txtModel.TabIndex = 23;
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Location = new Point(40, 400);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(91, 20);
            lblVehicleType.TabIndex = 24;
            lblVehicleType.Text = "Vehicle Type";
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Location = new Point(40, 425);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(320, 28);
            cmbVehicleType.TabIndex = 25;
            // 
            // lblManufacturingYear
            // 
            lblManufacturingYear.AutoSize = true;
            lblManufacturingYear.Location = new Point(40, 470);
            lblManufacturingYear.Name = "lblManufacturingYear";
            lblManufacturingYear.Size = new Size(137, 20);
            lblManufacturingYear.TabIndex = 26;
            lblManufacturingYear.Text = "Manufacturing Year";
            lblManufacturingYear.Click += lblManufacturingYear_Click;
            // 
            // nudManufacturingYear
            // 
            nudManufacturingYear.Location = new Point(40, 495);
            nudManufacturingYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudManufacturingYear.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            nudManufacturingYear.Name = "nudManufacturingYear";
            nudManufacturingYear.Size = new Size(320, 27);
            nudManufacturingYear.TabIndex = 27;
            nudManufacturingYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // picVehicle
            // 
            picVehicle.BorderStyle = BorderStyle.FixedSingle;
            picVehicle.Location = new Point(440, 145);
            picVehicle.Name = "picVehicle";
            picVehicle.Size = new Size(330, 230);
            picVehicle.SizeMode = PictureBoxSizeMode.Zoom;
            picVehicle.TabIndex = 28;
            picVehicle.TabStop = false;
            // 
            // lblVehiclePhoto
            // 
            lblVehiclePhoto.AutoSize = true;
            lblVehiclePhoto.Location = new Point(440, 120);
            lblVehiclePhoto.Name = "lblVehiclePhoto";
            lblVehiclePhoto.Size = new Size(99, 20);
            lblVehiclePhoto.TabIndex = 29;
            lblVehiclePhoto.Text = "Vehicle Photo";
            lblVehiclePhoto.Click += label2_Click;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(520, 390);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(170, 38);
            btnBrowseImage.TabIndex = 30;
            btnBrowseImage.Text = "BROWSE IMAGE";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // VehicleEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 603);
            Controls.Add(btnBrowseImage);
            Controls.Add(lblVehiclePhoto);
            Controls.Add(picVehicle);
            Controls.Add(nudManufacturingYear);
            Controls.Add(lblManufacturingYear);
            Controls.Add(cmbVehicleType);
            Controls.Add(lblVehicleType);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            Controls.Add(txtBrand);
            Controls.Add(lblBrand);
            Controls.Add(txtRegistrationNumber);
            Controls.Add(lblRegistrationNumber);
            Controls.Add(cmbCustomer);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(blSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VehicleEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Vehicle";
            ((System.ComponentModel.ISupportInitialize)nudManufacturingYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVehicle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label blSubtitle;
        private Label lblTitle;
        private Label label1;
        private ComboBox cmbCustomer;
        private Label lblRegistrationNumber;
        private TextBox txtRegistrationNumber;
        private Label lblBrand;
        private TextBox txtBrand;
        private Label lblModel;
        private TextBox txtModel;
        private Label lblVehicleType;
        private ComboBox cmbVehicleType;
        private Label lblManufacturingYear;
        private NumericUpDown nudManufacturingYear;
        private PictureBox picVehicle;
        private Label lblVehiclePhoto;
        private Button btnBrowseImage;
    }
}