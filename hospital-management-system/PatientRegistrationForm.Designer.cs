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
            birthdateInput = new TextBox();
            label5 = new Label();
            emailInput = new TextBox();
            label4 = new Label();
            phoneInput = new TextBox();
            label3 = new Label();
            genderInput = new TextBox();
            label2 = new Label();
            nameInput = new TextBox();
            label8 = new Label();
            allergyInput = new TextBox();
            label7 = new Label();
            sicknessInput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(937, 38);
            label1.TabIndex = 0;
            label1.Text = "New Patient Registration Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Salmon;
            cancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            cancelBtn.Location = new Point(458, 468);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(219, 67);
            cancelBtn.TabIndex = 28;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.MediumSeaGreen;
            registerBtn.Location = new Point(701, 468);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(219, 67);
            registerBtn.TabIndex = 27;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 358);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 26;
            label6.Text = "Birthdate";
            // 
            // birthdateInput
            // 
            birthdateInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            birthdateInput.BorderStyle = BorderStyle.FixedSingle;
            birthdateInput.Cursor = Cursors.Cross;
            birthdateInput.Location = new Point(145, 352);
            birthdateInput.MaxLength = 120;
            birthdateInput.Multiline = true;
            birthdateInput.Name = "birthdateInput";
            birthdateInput.Size = new Size(301, 45);
            birthdateInput.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 293);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 24;
            label5.Text = "Email";
            // 
            // emailInput
            // 
            emailInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            emailInput.BorderStyle = BorderStyle.FixedSingle;
            emailInput.Location = new Point(145, 290);
            emailInput.MaxLength = 120;
            emailInput.Multiline = true;
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(301, 45);
            emailInput.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 227);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 22;
            label4.Text = "Phone";
            // 
            // phoneInput
            // 
            phoneInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            phoneInput.BorderStyle = BorderStyle.FixedSingle;
            phoneInput.Location = new Point(145, 223);
            phoneInput.MaxLength = 20;
            phoneInput.Multiline = true;
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(301, 45);
            phoneInput.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 162);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 20;
            label3.Text = "Gender";
            // 
            // genderInput
            // 
            genderInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            genderInput.BorderStyle = BorderStyle.FixedSingle;
            genderInput.ImeMode = ImeMode.Off;
            genderInput.Location = new Point(145, 158);
            genderInput.MaxLength = 30;
            genderInput.Multiline = true;
            genderInput.Name = "genderInput";
            genderInput.Size = new Size(301, 45);
            genderInput.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 102);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 18;
            label2.Text = "Name";
            // 
            // nameInput
            // 
            nameInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            nameInput.BorderStyle = BorderStyle.FixedSingle;
            nameInput.Location = new Point(145, 98);
            nameInput.MaxLength = 120;
            nameInput.Multiline = true;
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(301, 45);
            nameInput.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(473, 158);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 32;
            label8.Text = "Allergy";
            // 
            // allergyInput
            // 
            allergyInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            allergyInput.BorderStyle = BorderStyle.FixedSingle;
            allergyInput.Location = new Point(583, 157);
            allergyInput.Multiline = true;
            allergyInput.Name = "allergyInput";
            allergyInput.Size = new Size(301, 45);
            allergyInput.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 102);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 30;
            label7.Text = "Sickness";
            // 
            // sicknessInput
            // 
            sicknessInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            sicknessInput.BorderStyle = BorderStyle.FixedSingle;
            sicknessInput.Location = new Point(583, 98);
            sicknessInput.MaxLength = 120;
            sicknessInput.Multiline = true;
            sicknessInput.Name = "sicknessInput";
            sicknessInput.Size = new Size(301, 45);
            sicknessInput.TabIndex = 29;
            // 
            // PatientRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 552);
            Controls.Add(label8);
            Controls.Add(allergyInput);
            Controls.Add(label7);
            Controls.Add(sicknessInput);
            Controls.Add(cancelBtn);
            Controls.Add(registerBtn);
            Controls.Add(label6);
            Controls.Add(birthdateInput);
            Controls.Add(label5);
            Controls.Add(emailInput);
            Controls.Add(label4);
            Controls.Add(phoneInput);
            Controls.Add(label3);
            Controls.Add(genderInput);
            Controls.Add(label2);
            Controls.Add(nameInput);
            Controls.Add(label1);
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
        private TextBox birthdateInput;
        private Label label5;
        private TextBox emailInput;
        private Label label4;
        private TextBox phoneInput;
        private Label label3;
        private TextBox genderInput;
        private Label label2;
        private TextBox nameInput;
        private Label label8;
        private TextBox allergyInput;
        private Label label7;
        private TextBox sicknessInput;
    }
}