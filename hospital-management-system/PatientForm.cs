using hospital_management_system.Models;
using hospital_management_system.Service;
using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class PatientForm : Form
    {
        List<Patient> patients = new List<Patient>();
        PatientRegistrationForm registrationForm;
        Util util = new Util();
        private PatientService patientService;

        // selected patient
        Patient selectedPatient = new Patient();

        public PatientForm()
        {
            InitializeComponent();

            patientService = new PatientService();

            addBtn.Click += handleAdd;
            refreshBtn.Click += handleRefresh;
            editBtn.Click += handleEdit;
            deleteBtn.Click += handleDelete;
            dataGridView1.SelectionChanged += handleRowSelection;
            searchBtn.Click += handleSearch;
        }

        // handle search action
        private void handleSearch(object sender, EventArgs e)
        {
            if (searchInput.Text == null) return;

            Patient patient = patientService.getPatientByPatientId(searchInput.Text);

            string msgToShow = searchResultFormat(patient);

            MessageBox.Show(msgToShow, "Search Result");
        }

        private string searchResultFormat(Patient patient)
        {
            string allergy = patient.allergies != null ? patient.allergies.ToString() : "No allergy";

            return "ID: " + patient.patient_id + "\n" + "Name: " + patient.name + "\n" + "Gender: " + patient.gender + "\n" + "Email: " + patient.email + "\n" + "Contact: " + patient.phone_number + "\n" + "Sicknesses: " + patient.sicknesses + "\n" + "Allergies: " + allergy;
        }

        // handle row selection
        private void handleRowSelection(object? sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            if (selectedRow == null || selectedRow.Tag == null || !(selectedRow.Tag is Patient))
            {
                selectedPatient = null;
                return;
            }

            selectedPatient = (Patient)selectedRow.Tag;
        }

        // handle delete
        private void handleDelete(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete this ?", "Delete Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // find patient before deleting
                Patient filteredPatient = patientService.getPatient(selectedPatient.Id);

                if (filteredPatient == null)
                {
                    MessageBox.Show("Patient is not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // patient found then delete
                patientService.deletePatient(filteredPatient.Id);
                handleRefresh(sender, e);
            }
        }

        // handle edit
        private void handleEdit(object? sender, EventArgs e)
        {
            if (registrationForm == null || registrationForm.IsDisposed)
            {
                registrationForm = new PatientRegistrationForm("Edit", selectedPatient);
                registrationForm.Show();
            }
        }

        // handle add action
        private void handleAdd(object? sender, EventArgs e)
        {
            if (registrationForm == null || registrationForm.IsDisposed)
            {
                registrationForm = new PatientRegistrationForm();
                registrationForm.Show();
            }
        }

        // handle refresh
        private void handleRefresh(object? sender, EventArgs e)
        {
            PatientForm_Load(sender, e);
        }

        // on load function
        private void PatientForm_Load(object sender, EventArgs e)
        {
            patients = patientService.getPatients();
            viewPatients();
        }

        // view patients
        private void viewPatients()
        {
            dataGridView1.Rows.Clear();
            foreach (var patient in patients)
            {
                int index = dataGridView1.Rows.Add(patient.patient_id, patient.name, patient.gender, patient.phone_number, patient.email, patient.birth_date, patient.sicknesses, patient.allergies);

                dataGridView1.Rows[index].Tag = patient;
                dataGridView1.Tag = dataGridView1.Rows[index];
            }
        }
    }

}
