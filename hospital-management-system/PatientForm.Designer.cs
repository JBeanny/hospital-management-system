namespace hospital_management_system
{
    partial class PatientForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            refreshBtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            searchBtn = new Button();
            searchInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(120, 214, 198);
            dataGridViewCellStyle5.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(120, 214, 198);
            dataGridViewCellStyle6.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(-1, 61);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(885, 368);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 56;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 80;
            // 
            // Column3
            // 
            Column3.HeaderText = "Gender";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 88;
            // 
            // Column4
            // 
            Column4.HeaderText = "Phone Number";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 136;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 77;
            // 
            // Column6
            // 
            Column6.HeaderText = "Birth Date";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 105;
            // 
            // Column7
            // 
            Column7.HeaderText = "Sicknesses";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 111;
            // 
            // Column8
            // 
            Column8.HeaderText = "Allergies";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 95;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.White;
            addBtn.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = Color.Black;
            addBtn.Location = new Point(694, 449);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(172, 40);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.White;
            editBtn.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            editBtn.ForeColor = Color.Black;
            editBtn.Location = new Point(498, 449);
            editBtn.Margin = new Padding(2);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(172, 40);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.White;
            deleteBtn.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.Black;
            deleteBtn.Location = new Point(301, 449);
            deleteBtn.Margin = new Padding(2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(172, 40);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // refreshBtn
            // 
            refreshBtn.BackgroundImage = Resource1.refresh_icon;
            refreshBtn.BackgroundImageLayout = ImageLayout.Stretch;
            refreshBtn.Location = new Point(17, 448);
            refreshBtn.Margin = new Padding(2);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(41, 40);
            refreshBtn.TabIndex = 5;
            refreshBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.BackgroundImage = Resource1.search;
            searchBtn.BackgroundImageLayout = ImageLayout.Zoom;
            searchBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.Location = new Point(837, 12);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(30, 30);
            searchBtn.TabIndex = 8;
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchInput
            // 
            searchInput.BorderStyle = BorderStyle.FixedSingle;
            searchInput.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchInput.Location = new Point(628, 12);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(192, 30);
            searchInput.TabIndex = 7;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 511);
            Controls.Add(searchBtn);
            Controls.Add(searchInput);
            Controls.Add(refreshBtn);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "PatientForm";
            Text = "Patient Management Form";
            Load += PatientForm_Load;
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
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private Button refreshBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button searchBtn;
        private TextBox searchInput;
    }
}