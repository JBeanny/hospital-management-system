using hospital_management_system.Models;
using hospital_management_system.Service;

namespace hospital_management_system
{
    public partial class ConsultationMainForm : Form
    {
        List<Consultation> consultations = new List<Consultation>();
        AddConsultationForm addConsultationForm;
        private ConsultationService consultationService = new ConsultationService();

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
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            if (selectedRow == null || selectedRow.Tag == null || !(selectedRow.Tag is Consultation))
            {
                selectedConsultation = null;
                return;
            }

            selectedConsultation = (Consultation)selectedRow.Tag;
        }

        // delete method
        private void handleDelete(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete this ?", "Delete Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var filteredConsultation = consultationService.getConsultation(selectedConsultation.Id);

                if (filteredConsultation == null)
                {
                    MessageBox.Show("Appointment is not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                consultationService.deleteConsultation(filteredConsultation.Id);
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
            consultations = consultationService.getConsultations();
            viewConsultations();
        }

        // view consultations
        private void viewConsultations()
        {
            dataGridView1.Rows.Clear();
            foreach (var consultation in consultations)
            {
                int index = dataGridView1.Rows.Add(consultation.consultation_id, consultation.patient_id, consultation.doctor_id, consultation.date);

                dataGridView1.Rows[index].Tag = consultation;
                dataGridView1.Tag = dataGridView1.Rows[index];
            }
        }
    }
}
