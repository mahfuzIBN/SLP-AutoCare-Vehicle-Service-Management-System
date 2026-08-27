namespace VehicleServiceCenter
{
    partial class ServiceRequestEditForm
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
            lblSubtitle = new Label();
            lblTitle = new Label();
            lblProblemDescription = new Label();
            txtProblemDescription = new TextBox();
            lblServiceType = new Label();
            lblRequestDate = new Label();
            cmbVehicle = new ComboBox();
            lblVehicle = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            dtpRequestDate = new DateTimePicker();
            cmbServiceType = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(14, 47);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(227, 20);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Enter service request information";
            lblSubtitle.Click += blSubtitle_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(345, 46);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Add Service Request";
            // 
            // lblProblemDescription
            // 
            lblProblemDescription.AutoSize = true;
            lblProblemDescription.Location = new Point(25, 302);
            lblProblemDescription.Name = "lblProblemDescription";
            lblProblemDescription.Size = new Size(145, 20);
            lblProblemDescription.TabIndex = 38;
            lblProblemDescription.Text = "Problem Description";
            // 
            // txtProblemDescription
            // 
            txtProblemDescription.Location = new Point(25, 326);
            txtProblemDescription.Multiline = true;
            txtProblemDescription.Name = "txtProblemDescription";
            txtProblemDescription.ScrollBars = ScrollBars.Vertical;
            txtProblemDescription.Size = new Size(520, 68);
            txtProblemDescription.TabIndex = 37;
            // 
            // lblServiceType
            // 
            lblServiceType.AutoSize = true;
            lblServiceType.Location = new Point(25, 231);
            lblServiceType.Name = "lblServiceType";
            lblServiceType.Size = new Size(91, 20);
            lblServiceType.TabIndex = 36;
            lblServiceType.Text = "Service Type";
            // 
            // lblRequestDate
            // 
            lblRequestDate.AutoSize = true;
            lblRequestDate.Location = new Point(25, 162);
            lblRequestDate.Name = "lblRequestDate";
            lblRequestDate.Size = new Size(98, 20);
            lblRequestDate.TabIndex = 32;
            lblRequestDate.Text = "Request Date";
            // 
            // cmbVehicle
            // 
            cmbVehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Location = new Point(25, 118);
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(360, 28);
            cmbVehicle.TabIndex = 31;
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Location = new Point(25, 93);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(56, 20);
            lblVehicle.TabIndex = 30;
            lblVehicle.Text = "Vehicle";
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
            btnSave.Location = new Point(312, 508);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 42);
            btnSave.TabIndex = 29;
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
            btnCancel.Location = new Point(122, 508);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 42);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // dtpRequestDate
            // 
            dtpRequestDate.Format = DateTimePickerFormat.Short;
            dtpRequestDate.Location = new Point(25, 188);
            dtpRequestDate.Name = "dtpRequestDate";
            dtpRequestDate.Size = new Size(360, 27);
            dtpRequestDate.TabIndex = 42;
            // 
            // cmbServiceType
            // 
            cmbServiceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServiceType.FormattingEnabled = true;
            cmbServiceType.Location = new Point(25, 258);
            cmbServiceType.Name = "cmbServiceType";
            cmbServiceType.Size = new Size(360, 28);
            cmbServiceType.TabIndex = 43;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(25, 413);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 44;
            lblStatus.Text = "Status";
            lblStatus.Click += label1_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(25, 436);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(360, 28);
            cmbStatus.TabIndex = 45;
            // 
            // ServiceRequestEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(682, 573);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbServiceType);
            Controls.Add(dtpRequestDate);
            Controls.Add(lblProblemDescription);
            Controls.Add(txtProblemDescription);
            Controls.Add(lblServiceType);
            Controls.Add(lblRequestDate);
            Controls.Add(cmbVehicle);
            Controls.Add(lblVehicle);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ServiceRequestEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Service Request";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubtitle;
        private Label lblTitle;
        private Label lblProblemDescription;
        private TextBox txtProblemDescription;
        private Label lblServiceType;
        private TextBox txtBrand;
        
        private Label lblRequestDate;
        private ComboBox cmbVehicle;
        private Label lblVehicle;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtpRequestDate;
        private ComboBox cmbServiceType;
        private Label lblStatus;
        private ComboBox cmbStatus;
    }
}