namespace hospital_management_system
{
    partial class AddConsultationForm
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
            cancelBtn = new Button();
            registerBtn = new Button();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            doctorInput = new TextBox();
            label2 = new Label();
            patientInput = new TextBox();
            datetimeInput = new DateTimePicker();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Salmon;
            cancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            cancelBtn.Location = new Point(458, 477);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(219, 67);
            cancelBtn.TabIndex = 45;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.MediumSeaGreen;
            registerBtn.Location = new Point(701, 477);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(219, 67);
            registerBtn.TabIndex = 44;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(937, 38);
            label1.TabIndex = 33;
            label1.Text = "New Patient Registration Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 269);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 51;
            label5.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 169);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 49;
            label6.Text = "Doctor ID";
            // 
            // doctorInput
            // 
            doctorInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            doctorInput.BorderStyle = BorderStyle.FixedSingle;
            doctorInput.Location = new Point(199, 206);
            doctorInput.MaxLength = 20;
            doctorInput.Multiline = true;
            doctorInput.Name = "doctorInput";
            doctorInput.Size = new Size(542, 45);
            doctorInput.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 68);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 47;
            label2.Text = "Patient ID";
            // 
            // patientInput
            // 
            patientInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            patientInput.BorderStyle = BorderStyle.FixedSingle;
            patientInput.ImeMode = ImeMode.Off;
            patientInput.Location = new Point(199, 108);
            patientInput.MaxLength = 30;
            patientInput.Multiline = true;
            patientInput.Name = "patientInput";
            patientInput.Size = new Size(542, 45);
            patientInput.TabIndex = 46;
            // 
            // datetimeInput
            // 
            datetimeInput.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            datetimeInput.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            datetimeInput.Format = DateTimePickerFormat.Custom;
            datetimeInput.Location = new Point(199, 313);
            datetimeInput.Name = "datetimeInput";
            datetimeInput.Size = new Size(542, 32);
            datetimeInput.TabIndex = 52;
            datetimeInput.UseWaitCursor = true;
            // 
            // AddConsultationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 552);
            Controls.Add(datetimeInput);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(doctorInput);
            Controls.Add(label2);
            Controls.Add(patientInput);
            Controls.Add(cancelBtn);
            Controls.Add(registerBtn);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "AddConsultationForm";
            Text = "AddConsultationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button registerBtn;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox doctorInput;
        private Label label2;
        private TextBox patientInput;
        private DateTimePicker datetimeInput;
    }
}