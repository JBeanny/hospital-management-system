using hospital_management_system.Models;
using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class ConsultationMainForm : Form
    {
        string filePath = Path.Combine(Environment.CurrentDirectory, "Data", "Consultations.txt");
        List<Consultation> consultations = new List<Consultation>();
        AddConsultationForm addConsultationForm;
        Util util = new Util();

        // selected consultation
        Consultation selectedConsultation = new Consultation();

        public ConsultationMainForm()
        {
            InitializeComponent();

            addBtn.Click += handleAdd;
            dataGridView1.SelectionChanged += handleRowSelection;
            editBtn.Click += handleEdit;
            deleteBtn.Click += handleDelete;
            refreshBtn.Click += handleRefresh;
        }

        // handle refresh action
        private void handleRefresh(object sender, EventArgs e)
        {
            ConsultationMainForm_Load(sender, e);
        }

        // edit
        private void handleEdit(object? sender, EventArgs e)
        {
            if (addConsultationForm == null || addConsultationForm.IsDisposed)
            {
                addConsultationForm = new AddConsultationForm("Edit", selectedConsultation);
                addConsultationForm.Show();
            }
        }

        // handle row selection
        private void handleRowSelection(object? sender, EventArgs e)
        {
            Consultation selectedRow = dataGridView1.CurrentRow.Tag as Consultation;

            if (selectedRow == null) return;

            selectedConsultation.id = selectedRow.id;
            selectedConsultation.patient_id = selectedRow.patient_id;
            selectedConsultation.doctor_id = selectedRow.doctor_id;
            selectedConsultation.date = selectedRow.date;
        }

        // delete method
        private void handleDelete(object? sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(filePath);
            var result = MessageBox.Show("Are you sure to delete this ?", "Delete Consultation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                consultations.ForEach(consultation =>
                {
                    if (consultation.id == selectedConsultation.id) return;

                    string formattedString = util.formattedFileData(consultation.id, consultation.patient_id, consultation.doctor_id, consultation.date);

                    writer.WriteLine(formattedString);
                });

                writer.Close();
                handleRefresh(sender, e);
            }
        }

        // add method
        private void handleAdd(object sender, EventArgs e)
        {
            if (addConsultationForm == null || addConsultationForm.IsDisposed)
            {
                addConsultationForm = new AddConsultationForm(consultations);
                addConsultationForm.Show();
            }
        }

        // on load function
        private void ConsultationMainForm_Load(object sender, EventArgs e)
        {
            readConsultationsData();
        }

        // read data from file
        private void readConsultationsData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);

                    consultations.Clear();
                    if (lines.Length > 0)
                    {
                        foreach (var line in lines)
                        {
                            var dataRow = line.Split("/");
                            Consultation newConsultation = new Consultation(dataRow[0], dataRow[1], dataRow[2], dataRow[3]);

                            if (newConsultation == null) continue;
                            consultations.Add(newConsultation);
                        }
                    }
                    viewConsultations();
                }
                else
                {
                    MessageBox.Show("File is not existed", "Failed to open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // view consultations
        private void viewConsultations()
        {
            dataGridView1.Rows.Clear();
            foreach (var consultation in consultations)
            {
                int index = dataGridView1.Rows.Add(consultation.id, consultation.patient_id, consultation.doctor_id, consultation.date);

                dataGridView1.Rows[index].Tag = consultation;
                dataGridView1.Tag = dataGridView1.Rows[index];
            }
        }
    }
}
