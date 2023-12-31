﻿namespace hospital_management_system
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
            label4 = new Label();
            phoneInput = new TextBox();
            label5 = new Label();
            emailInput = new TextBox();
            label6 = new Label();
            label7 = new Label();
            specialtyInput = new TextBox();
            label8 = new Label();
            roomInput = new TextBox();
            registerBtn = new Button();
            cancelBtn = new Button();
            birthdateInput = new DateTimePicker();
            genderInput = new ComboBox();
            SuspendLayout();
            // 
            // nameInput
            // 
            nameInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            nameInput.BorderStyle = BorderStyle.FixedSingle;
            nameInput.Location = new Point(91, 62);
            nameInput.Margin = new Padding(2);
            nameInput.MaxLength = 120;
            nameInput.Multiline = true;
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(211, 28);
            nameInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(120, 214, 198);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(656, 28);
            label1.TabIndex = 1;
            label1.Text = "New Doctor Registration Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 64);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 100);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 139);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // phoneInput
            // 
            phoneInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            phoneInput.BorderStyle = BorderStyle.FixedSingle;
            phoneInput.Location = new Point(91, 137);
            phoneInput.Margin = new Padding(2);
            phoneInput.MaxLength = 20;
            phoneInput.Multiline = true;
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(211, 28);
            phoneInput.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 179);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // emailInput
            // 
            emailInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            emailInput.BorderStyle = BorderStyle.FixedSingle;
            emailInput.Location = new Point(91, 177);
            emailInput.Margin = new Padding(2);
            emailInput.MaxLength = 120;
            emailInput.Multiline = true;
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(211, 28);
            emailInput.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 218);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "Birthdate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 64);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 12;
            label7.Text = "Specialty";
            // 
            // specialtyInput
            // 
            specialtyInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            specialtyInput.BorderStyle = BorderStyle.FixedSingle;
            specialtyInput.Location = new Point(423, 62);
            specialtyInput.Margin = new Padding(2);
            specialtyInput.MaxLength = 120;
            specialtyInput.Multiline = true;
            specialtyInput.Name = "specialtyInput";
            specialtyInput.Size = new Size(211, 28);
            specialtyInput.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 98);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 14;
            label8.Text = "Room";
            // 
            // roomInput
            // 
            roomInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            roomInput.BorderStyle = BorderStyle.FixedSingle;
            roomInput.Location = new Point(423, 97);
            roomInput.Margin = new Padding(2);
            roomInput.Multiline = true;
            roomInput.Name = "roomInput";
            roomInput.Size = new Size(211, 28);
            roomInput.TabIndex = 13;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.White;
            registerBtn.Location = new Point(480, 284);
            registerBtn.Margin = new Padding(2);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(153, 40);
            registerBtn.TabIndex = 15;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.White;
            cancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            cancelBtn.Location = new Point(310, 284);
            cancelBtn.Margin = new Padding(2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(153, 40);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // birthdateInput
            // 
            birthdateInput.CustomFormat = "yyyy-MM-dd";
            birthdateInput.Format = DateTimePickerFormat.Custom;
            birthdateInput.Location = new Point(91, 218);
            birthdateInput.Name = "birthdateInput";
            birthdateInput.Size = new Size(211, 23);
            birthdateInput.TabIndex = 17;
            // 
            // genderInput
            // 
            genderInput.FormattingEnabled = true;
            genderInput.Items.AddRange(new object[] { "Male", "Female", "Others" });
            genderInput.Location = new Point(91, 102);
            genderInput.Name = "genderInput";
            genderInput.Size = new Size(211, 23);
            genderInput.TabIndex = 18;
            // 
            // AddDoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 331);
            Controls.Add(genderInput);
            Controls.Add(birthdateInput);
            Controls.Add(cancelBtn);
            Controls.Add(registerBtn);
            Controls.Add(label8);
            Controls.Add(roomInput);
            Controls.Add(label7);
            Controls.Add(specialtyInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(emailInput);
            Controls.Add(label4);
            Controls.Add(phoneInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameInput);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
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
        private Label label4;
        private TextBox phoneInput;
        private Label label5;
        private TextBox emailInput;
        private Label label6;
        private Label label7;
        private TextBox specialtyInput;
        private Label label8;
        private TextBox roomInput;
        private Button registerBtn;
        private Button cancelBtn;
        private DateTimePicker birthdateInput;
        private ComboBox genderInput;
    }
}