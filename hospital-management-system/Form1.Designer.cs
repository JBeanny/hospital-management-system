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
            listView1 = new ListView();
            viewDoctorBtn = new Button();
            viewNurseBtn = new Button();
            viewPatientBtn = new Button();
            logoImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoImageBox).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(150, 194, 145);
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(300, 848);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // viewDoctorBtn
            // 
            viewDoctorBtn.Cursor = Cursors.Hand;
            viewDoctorBtn.Location = new Point(12, 192);
            viewDoctorBtn.Name = "viewDoctorBtn";
            viewDoctorBtn.Size = new Size(277, 74);
            viewDoctorBtn.TabIndex = 1;
            viewDoctorBtn.Text = "List Doctors";
            viewDoctorBtn.UseVisualStyleBackColor = true;
            viewDoctorBtn.Click += viewDoctors;
            // 
            // viewNurseBtn
            // 
            viewNurseBtn.Cursor = Cursors.Hand;
            viewNurseBtn.Location = new Point(12, 293);
            viewNurseBtn.Name = "viewNurseBtn";
            viewNurseBtn.Size = new Size(277, 74);
            viewNurseBtn.TabIndex = 2;
            viewNurseBtn.Text = "List Nurses";
            viewNurseBtn.UseVisualStyleBackColor = true;
            // 
            // viewPatientBtn
            // 
            viewPatientBtn.Cursor = Cursors.Hand;
            viewPatientBtn.Location = new Point(12, 394);
            viewPatientBtn.Name = "viewPatientBtn";
            viewPatientBtn.Size = new Size(277, 74);
            viewPatientBtn.TabIndex = 3;
            viewPatientBtn.Text = "List Patients";
            viewPatientBtn.UseVisualStyleBackColor = true;
            // 
            // logoImageBox
            // 
            logoImageBox.Image = Resource1.logo;
            logoImageBox.ImageLocation = "";
            logoImageBox.Location = new Point(68, 12);
            logoImageBox.Name = "logoImageBox";
            logoImageBox.Size = new Size(150, 75);
            logoImageBox.TabIndex = 4;
            logoImageBox.TabStop = false;
            logoImageBox.Click += logoImageBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 847);
            Controls.Add(logoImageBox);
            Controls.Add(viewPatientBtn);
            Controls.Add(viewNurseBtn);
            Controls.Add(viewDoctorBtn);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Hospital Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logoImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button viewDoctorBtn;
        private Button viewNurseBtn;
        private Button viewPatientBtn;
        private PictureBox logoImageBox;
    }
}