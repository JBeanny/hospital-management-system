namespace hospital_management_system
{
    partial class DoctorForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            addDoctorBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            refreshBtn = new Button();
            searchInput = new TextBox();
            searchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(120, 214, 198);
            dataGridViewCellStyle1.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(120, 214, 198);
            dataGridViewCellStyle2.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(1, 51);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(120, 214, 198);
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.Size = new Size(887, 368);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 55;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 76;
            // 
            // Column3
            // 
            Column3.HeaderText = "Gender";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 83;
            // 
            // Column4
            // 
            Column4.HeaderText = "Phone Number";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 126;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 73;
            // 
            // Column6
            // 
            Column6.HeaderText = "Birth Date";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 98;
            // 
            // Column7
            // 
            Column7.HeaderText = "Specialty";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 94;
            // 
            // Column8
            // 
            Column8.HeaderText = "Room ID";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 91;
            // 
            // addDoctorBtn
            // 
            addDoctorBtn.BackColor = Color.White;
            addDoctorBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addDoctorBtn.ForeColor = Color.Black;
            addDoctorBtn.Location = new Point(702, 444);
            addDoctorBtn.Margin = new Padding(2);
            addDoctorBtn.Name = "addDoctorBtn";
            addDoctorBtn.Size = new Size(172, 40);
            addDoctorBtn.TabIndex = 1;
            addDoctorBtn.Text = "Add";
            addDoctorBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.White;
            editBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            editBtn.ForeColor = Color.Black;
            editBtn.Location = new Point(510, 444);
            editBtn.Margin = new Padding(2);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(172, 40);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.White;
            deleteBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.Black;
            deleteBtn.Location = new Point(319, 444);
            deleteBtn.Margin = new Padding(2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(172, 40);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // refreshBtn
            // 
            refreshBtn.BackgroundImage = Resource1.refresh_icon;
            refreshBtn.BackgroundImageLayout = ImageLayout.Zoom;
            refreshBtn.Location = new Point(12, 444);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(44, 40);
            refreshBtn.TabIndex = 4;
            refreshBtn.UseVisualStyleBackColor = true;
            // 
            // searchInput
            // 
            searchInput.BorderStyle = BorderStyle.FixedSingle;
            searchInput.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchInput.Location = new Point(636, 12);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(192, 30);
            searchInput.TabIndex = 5;
            // 
            // searchBtn
            // 
            searchBtn.BackgroundImage = Resource1.search;
            searchBtn.BackgroundImageLayout = ImageLayout.Zoom;
            searchBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.Location = new Point(845, 12);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(30, 30);
            searchBtn.TabIndex = 6;
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 511);
            Controls.Add(searchBtn);
            Controls.Add(searchInput);
            Controls.Add(refreshBtn);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addDoctorBtn);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "DoctorForm";
            Text = "Doctor Management Form";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button addDoctorBtn;
        private Button editBtn;
        private Button deleteBtn;
        private Button refreshBtn;
        private TextBox searchInput;
        private Button searchBtn;
    }
}