using hospital_management_system.Models;
using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class PatientForm : Form
    {
        string filePath = Path.Combine(Environment.CurrentDirectory, "Data", "Patients.txt");
        List<Patient> patients = new List<Patient>();
        PatientRegistrationForm registrationForm;
        Util util = new Util();

        // selected patient
        Patient selectedPatient = new Patient();

        public PatientForm()
        {
            InitializeComponent();

            addBtn.Click += handleAdd;
            refreshBtn.Click += handleRefresh;
            editBtn.Click += handleEdit;
            deleteBtn.Click += handleDelete;
            dataGridView1.SelectionChanged += handleRowSelection;
        }

        // handle row selection
        private void handleRowSelection(object? sender, EventArgs e)
        {
            Patient selectedRow = dataGridView1.CurrentRow.Tag as Patient;

            if (selectedRow == null) return;

            selectedPatient.id = selectedRow.id;
            selectedPatient.email = selectedRow.email;
            selectedPatient.name = selectedRow.name;
            selectedPatient.birth_date = selectedRow.birth_date;
            selectedPatient.gender = selectedRow.gender;
            selectedPatient.phone_number = selectedRow.phone_number;
            selectedPatient.sicknesses = selectedRow.sicknesses;
            selectedPatient.allergies = selectedRow.allergies;
        }

        // handle delete
        private void handleDelete(object? sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(filePath);
            var result = MessageBox.Show("Are you sure to delete this ?", "Delete Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                patients.ForEach(patient =>
                {
                    if (patient.id == selectedPatient.id) return;

                    string formattedString = util.formattedFileData(patient.id, patient.name, patient.gender, patient.phone_number, patient.email, patient.birth_date, patient.sicknesses, patient.allergies);

                    writer.WriteLine(formattedString);
                });

                writer.Close();
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
            readPatientsData();
        }

        private void readPatientsData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);

                    patients.Clear();
                    if (lines.Length > 0)
                    {
                        foreach (var line in lines)
                        {
                            var dataRow = line.Split("/");

                            // states
                            string id = dataRow[0];
                            string name = dataRow[1];
                            string gender = dataRow[2];
                            string phone = dataRow[3];
                            string email = dataRow[4];
                            string birthdate = dataRow[5];
                            string sicknesses = dataRow[6] != "" ? dataRow[6] : "";
                            string allergies = dataRow[7] != "" ? dataRow[7] : "No allergies";

                            Patient newPatient = new Patient(id, name, phone, email, gender, birthdate, sicknesses, allergies);

                            if (newPatient == null) continue;
                            patients.Add(newPatient);
                        }
                    }
                    viewPatients();
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
        // view patients
        private void viewPatients()
        {
            dataGridView1.Rows.Clear();
            foreach (var patient in patients)
            {
                int index = dataGridView1.Rows.Add(patient.id, patient.name, patient.gender, patient.phone_number, patient.email, patient.birth_date, patient.sicknesses, patient.allergies);

                dataGridView1.Rows[index].Tag = patient;
                dataGridView1.Tag = dataGridView1.Rows[index];
            }
        }
    }

}
