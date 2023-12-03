namespace hospital_management_system
{
    partial class ConsultationMainForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            refreshBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            searchBtn = new Button();
            searchInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // refreshBtn
            // 
            refreshBtn.BackgroundImage = Resource1.refresh_icon;
            refreshBtn.BackgroundImageLayout = ImageLayout.Stretch;
            refreshBtn.Location = new Point(17, 452);
            refreshBtn.Margin = new Padding(2);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(42, 40);
            refreshBtn.TabIndex = 10;
            refreshBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.White;
            deleteBtn.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.Black;
            deleteBtn.Location = new Point(301, 452);
            deleteBtn.Margin = new Padding(2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(172, 40);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.White;
            editBtn.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            editBtn.ForeColor = Color.Black;
            editBtn.Location = new Point(499, 452);
            editBtn.Margin = new Padding(2);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(172, 40);
            editBtn.TabIndex = 8;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.White;
            addBtn.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = Color.Black;
            addBtn.Location = new Point(695, 452);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(172, 40);
            addBtn.TabIndex = 7;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(120, 214, 198);
            dataGridViewCellStyle4.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(120, 214, 198);
            dataGridViewCellStyle5.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 65);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(885, 368);
            dataGridView1.TabIndex = 6;
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
            Column2.HeaderText = "Patient ID";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 104;
            // 
            // Column3
            // 
            Column3.HeaderText = "Doctor ID";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 101;
            // 
            // Column4
            // 
            Column4.HeaderText = "Date";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 72;
            // 
            // searchBtn
            // 
            searchBtn.BackgroundImage = Resource1.search;
            searchBtn.BackgroundImageLayout = ImageLayout.Zoom;
            searchBtn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.Location = new Point(842, 12);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(30, 30);
            searchBtn.TabIndex = 12;
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchInput
            // 
            searchInput.BorderStyle = BorderStyle.FixedSingle;
            searchInput.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchInput.Location = new Point(633, 12);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(192, 30);
            searchInput.TabIndex = 11;
            // 
            // ConsultationMainForm
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
            Name = "ConsultationMainForm";
            Text = "Consultation Management Form";
            Load += ConsultationMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button refreshBtn;
        private Button deleteBtn;
        private Button editBtn;
        private Button addBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button searchBtn;
        private TextBox searchInput;
    }
}