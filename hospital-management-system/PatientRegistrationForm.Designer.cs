namespace hospital_management_system
{
    partial class PatientRegistrationForm
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
            label1 = new Label();
            cancelBtn = new Button();
            registerBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            emailInput = new TextBox();
            label4 = new Label();
            phoneInput = new TextBox();
            label3 = new Label();
            label2 = new Label();
            nameInput = new TextBox();
            label8 = new Label();
            allergyInput = new TextBox();
            label7 = new Label();
            sicknessInput = new TextBox();
            birthdateInput = new DateTimePicker();
            genderInput = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(120, 214, 198);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(656, 23);
            label1.TabIndex = 0;
            label1.Text = "New Patient Registration Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.White;
            cancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            cancelBtn.Location = new Point(321, 281);
            cancelBtn.Margin = new Padding(2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(153, 40);
            cancelBtn.TabIndex = 28;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.White;
            registerBtn.Location = new Point(491, 281);
            registerBtn.Margin = new Padding(2);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(153, 40);
            registerBtn.TabIndex = 27;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 215);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 26;
            label6.Text = "Birthdate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 176);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 24;
            label5.Text = "Email";
            // 
            // emailInput
            // 
            emailInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            emailInput.BorderStyle = BorderStyle.FixedSingle;
            emailInput.Location = new Point(102, 174);
            emailInput.Margin = new Padding(2);
            emailInput.MaxLength = 120;
            emailInput.Multiline = true;
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(211, 28);
            emailInput.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 136);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 22;
            label4.Text = "Phone";
            // 
            // phoneInput
            // 
            phoneInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            phoneInput.BorderStyle = BorderStyle.FixedSingle;
            phoneInput.Location = new Point(102, 134);
            phoneInput.Margin = new Padding(2);
            phoneInput.MaxLength = 20;
            phoneInput.Multiline = true;
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(211, 28);
            phoneInput.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 20;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 18;
            label2.Text = "Name";
            // 
            // nameInput
            // 
            nameInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            nameInput.BorderStyle = BorderStyle.FixedSingle;
            nameInput.Location = new Point(102, 59);
            nameInput.Margin = new Padding(2);
            nameInput.MaxLength = 120;
            nameInput.Multiline = true;
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(211, 28);
            nameInput.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(331, 95);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 32;
            label8.Text = "Allergy";
            // 
            // allergyInput
            // 
            allergyInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            allergyInput.BorderStyle = BorderStyle.FixedSingle;
            allergyInput.Location = new Point(408, 94);
            allergyInput.Margin = new Padding(2);
            allergyInput.Multiline = true;
            allergyInput.Name = "allergyInput";
            allergyInput.Size = new Size(211, 28);
            allergyInput.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 61);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 30;
            label7.Text = "Sickness";
            // 
            // sicknessInput
            // 
            sicknessInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            sicknessInput.BorderStyle = BorderStyle.FixedSingle;
            sicknessInput.Location = new Point(408, 59);
            sicknessInput.Margin = new Padding(2);
            sicknessInput.MaxLength = 120;
            sicknessInput.Multiline = true;
            sicknessInput.Name = "sicknessInput";
            sicknessInput.Size = new Size(211, 28);
            sicknessInput.TabIndex = 29;
            // 
            // birthdateInput
            // 
            birthdateInput.CustomFormat = "yyyy-MM-dd";
            birthdateInput.Format = DateTimePickerFormat.Custom;
            birthdateInput.Location = new Point(102, 215);
            birthdateInput.Name = "birthdateInput";
            birthdateInput.Size = new Size(211, 23);
            birthdateInput.TabIndex = 33;
            // 
            // genderInput
            // 
            genderInput.DisplayMember = "Male";
            genderInput.FormattingEnabled = true;
            genderInput.IntegralHeight = false;
            genderInput.Items.AddRange(new object[] { "Male", "Female", "Others" });
            genderInput.Location = new Point(102, 97);
            genderInput.Name = "genderInput";
            genderInput.Size = new Size(211, 23);
            genderInput.TabIndex = 34;
            genderInput.ValueMember = "Male";
            // 
            // PatientRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 331);
            Controls.Add(genderInput);
            Controls.Add(birthdateInput);
            Controls.Add(label8);
            Controls.Add(allergyInput);
            Controls.Add(label7);
            Controls.Add(sicknessInput);
            Controls.Add(cancelBtn);
            Controls.Add(registerBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(emailInput);
            Controls.Add(label4);
            Controls.Add(phoneInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "PatientRegistrationForm";
            Text = "PatientRegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button cancelBtn;
        private Button registerBtn;
        private Label label6;
        private Label label5;
        private TextBox emailInput;
        private Label label4;
        private TextBox phoneInput;
        private Label label3;
        private ComboBox genderInput;
        private Label label2;
        private TextBox nameInput;
        private Label label8;
        private TextBox allergyInput;
        private Label label7;
        private TextBox sicknessInput;
        private DateTimePicker birthdateInput;
        private ComboBox comboBox1;
    }
}