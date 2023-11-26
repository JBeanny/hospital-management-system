namespace hospital_management_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            viewDoctorBtn = new Button();
            viewConsultationBtn = new Button();
            viewPatientBtn = new Button();
            doctorLabel = new Label();
            nurseLabel = new Label();
            patientLabel = new Label();
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // viewDoctorBtn
            // 
            viewDoctorBtn.BackgroundImage = Resource1.nurse__1_;
            viewDoctorBtn.BackgroundImageLayout = ImageLayout.Zoom;
            viewDoctorBtn.Cursor = Cursors.Hand;
            viewDoctorBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            viewDoctorBtn.ImageAlign = ContentAlignment.TopCenter;
            viewDoctorBtn.Location = new Point(375, 310);
            viewDoctorBtn.Name = "viewDoctorBtn";
            viewDoctorBtn.Size = new Size(170, 163);
            viewDoctorBtn.TabIndex = 1;
            viewDoctorBtn.TextAlign = ContentAlignment.BottomCenter;
            viewDoctorBtn.UseVisualStyleBackColor = true;
            viewDoctorBtn.Click += viewDoctors;
            // 
            // viewConsultationBtn
            // 
            viewConsultationBtn.BackgroundImage = Resource1.consultation;
            viewConsultationBtn.BackgroundImageLayout = ImageLayout.Zoom;
            viewConsultationBtn.Cursor = Cursors.Hand;
            viewConsultationBtn.Location = new Point(666, 310);
            viewConsultationBtn.Name = "viewConsultationBtn";
            viewConsultationBtn.Size = new Size(170, 163);
            viewConsultationBtn.TabIndex = 2;
            viewConsultationBtn.UseVisualStyleBackColor = true;
            // 
            // viewPatientBtn
            // 
            viewPatientBtn.BackgroundImage = Resource1.male_nurse;
            viewPatientBtn.BackgroundImageLayout = ImageLayout.Zoom;
            viewPatientBtn.Cursor = Cursors.Hand;
            viewPatientBtn.Location = new Point(946, 310);
            viewPatientBtn.Name = "viewPatientBtn";
            viewPatientBtn.Size = new Size(170, 163);
            viewPatientBtn.TabIndex = 3;
            viewPatientBtn.UseVisualStyleBackColor = true;
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.BorderStyle = BorderStyle.Fixed3D;
            doctorLabel.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            doctorLabel.Location = new Point(399, 500);
            doctorLabel.Margin = new Padding(4, 0, 4, 0);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.RightToLeft = RightToLeft.No;
            doctorLabel.Size = new Size(115, 28);
            doctorLabel.TabIndex = 4;
            doctorLabel.Text = "Doctors";
            // 
            // nurseLabel
            // 
            nurseLabel.AutoSize = true;
            nurseLabel.BorderStyle = BorderStyle.Fixed3D;
            nurseLabel.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nurseLabel.Location = new Point(666, 500);
            nurseLabel.Margin = new Padding(4, 0, 4, 0);
            nurseLabel.Name = "nurseLabel";
            nurseLabel.RightToLeft = RightToLeft.No;
            nurseLabel.Size = new Size(172, 28);
            nurseLabel.TabIndex = 5;
            nurseLabel.Text = "Consultations";
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.BorderStyle = BorderStyle.Fixed3D;
            patientLabel.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            patientLabel.Location = new Point(981, 500);
            patientLabel.Margin = new Padding(4, 0, 4, 0);
            patientLabel.Name = "patientLabel";
            patientLabel.RightToLeft = RightToLeft.No;
            patientLabel.Size = new Size(106, 28);
            patientLabel.TabIndex = 6;
            patientLabel.Text = "Patients";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Underline, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(150, 194, 145);
            titleLabel.ImageAlign = ContentAlignment.MiddleLeft;
            titleLabel.Location = new Point(600, 75);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.RightToLeft = RightToLeft.No;
            titleLabel.Size = new Size(0, 54);
            titleLabel.TabIndex = 7;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Click += titleLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.hospital_logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-25, -54);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 255);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1507, 847);
            Controls.Add(pictureBox1);
            Controls.Add(titleLabel);
            Controls.Add(patientLabel);
            Controls.Add(nurseLabel);
            Controls.Add(doctorLabel);
            Controls.Add(viewPatientBtn);
            Controls.Add(viewConsultationBtn);
            Controls.Add(viewDoctorBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Hospital Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button viewDoctorBtn;
        private Button viewConsultationBtn;
        private Button viewPatientBtn;
        private Label doctorLabel;
        private Label nurseLabel;
        private Label patientLabel;
        private Label titleLabel;
        private PictureBox pictureBox1;
    }
}