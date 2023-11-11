namespace hospital_management_system
{
    partial class AddDoctorForm
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
            nameInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            genderInput = new TextBox();
            label4 = new Label();
            phoneInput = new TextBox();
            label5 = new Label();
            emailInput = new TextBox();
            label6 = new Label();
            birthdateInput = new TextBox();
            label7 = new Label();
            specialtyInput = new TextBox();
            label8 = new Label();
            roomInput = new TextBox();
            registerBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // nameInput
            // 
            nameInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            nameInput.BorderStyle = BorderStyle.FixedSingle;
            nameInput.Location = new Point(130, 103);
            nameInput.MaxLength = 120;
            nameInput.Multiline = true;
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(300, 45);
            nameInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(555, 40);
            label1.TabIndex = 1;
            label1.Text = "New Doctor Registration Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 106);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 167);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // genderInput
            // 
            genderInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            genderInput.BorderStyle = BorderStyle.FixedSingle;
            genderInput.ImeMode = ImeMode.Off;
            genderInput.Location = new Point(130, 164);
            genderInput.MaxLength = 30;
            genderInput.Multiline = true;
            genderInput.Name = "genderInput";
            genderInput.Size = new Size(300, 45);
            genderInput.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 231);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // phoneInput
            // 
            phoneInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            phoneInput.BorderStyle = BorderStyle.FixedSingle;
            phoneInput.Location = new Point(130, 228);
            phoneInput.MaxLength = 20;
            phoneInput.Multiline = true;
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(300, 45);
            phoneInput.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 298);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // emailInput
            // 
            emailInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            emailInput.BorderStyle = BorderStyle.FixedSingle;
            emailInput.Location = new Point(130, 295);
            emailInput.MaxLength = 120;
            emailInput.Multiline = true;
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(300, 45);
            emailInput.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 363);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 10;
            label6.Text = "Birthdate";
            label6.Click += label6_Click;
            // 
            // birthdateInput
            // 
            birthdateInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            birthdateInput.BorderStyle = BorderStyle.FixedSingle;
            birthdateInput.Cursor = Cursors.Cross;
            birthdateInput.Location = new Point(130, 357);
            birthdateInput.MaxLength = 120;
            birthdateInput.Multiline = true;
            birthdateInput.Name = "birthdateInput";
            birthdateInput.Size = new Size(300, 45);
            birthdateInput.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(495, 106);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 12;
            label7.Text = "Specialty";
            // 
            // specialtyInput
            // 
            specialtyInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            specialtyInput.BorderStyle = BorderStyle.FixedSingle;
            specialtyInput.Location = new Point(604, 103);
            specialtyInput.MaxLength = 120;
            specialtyInput.Multiline = true;
            specialtyInput.Name = "specialtyInput";
            specialtyInput.Size = new Size(300, 45);
            specialtyInput.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(495, 164);
            label8.Name = "label8";
            label8.Size = new Size(60, 25);
            label8.TabIndex = 14;
            label8.Text = "Room";
            // 
            // roomInput
            // 
            roomInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            roomInput.BorderStyle = BorderStyle.FixedSingle;
            roomInput.Location = new Point(604, 161);
            roomInput.Multiline = true;
            roomInput.Name = "roomInput";
            roomInput.Size = new Size(300, 45);
            roomInput.TabIndex = 13;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.MediumSeaGreen;
            registerBtn.Location = new Point(686, 473);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(218, 67);
            registerBtn.TabIndex = 15;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Salmon;
            cancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            cancelBtn.Location = new Point(443, 473);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(218, 67);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // AddDoctorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 552);
            Controls.Add(cancelBtn);
            Controls.Add(registerBtn);
            Controls.Add(label8);
            Controls.Add(roomInput);
            Controls.Add(label7);
            Controls.Add(specialtyInput);
            Controls.Add(label6);
            Controls.Add(birthdateInput);
            Controls.Add(label5);
            Controls.Add(emailInput);
            Controls.Add(label4);
            Controls.Add(phoneInput);
            Controls.Add(label3);
            Controls.Add(genderInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameInput);
            Name = "AddDoctorForm";
            Text = "Doctor Registration Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox genderInput;
        private Label label4;
        private TextBox phoneInput;
        private Label label5;
        private TextBox emailInput;
        private Label label6;
        private TextBox birthdateInput;
        private Label label7;
        private TextBox specialtyInput;
        private Label label8;
        private TextBox roomInput;
        private Button registerBtn;
        private Button cancelBtn;
    }
}