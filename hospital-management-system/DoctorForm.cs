using hospital_management_system.Models;
using hospital_management_system.Service;
using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class DoctorForm : Form
    {
        List<Doctor> doctors = new List<Doctor>();
        private AddDoctorForm addDoctorForm;
        Util util = new Util();
        private DoctorService doctorService = new DoctorService();

        // selected row
        Doctor selectedDoctor = new Doctor();

        public DoctorForm()
        {
            InitializeComponent();

            addDoctorBtn.Click += handleAddDoctor;
            dataGridView1.SelectionChanged += handleRowSelection;
            editBtn.Click += handleEditDoctor;
            deleteBtn.Click += handleDeleteDoctor;
            refreshBtn.Click += handleRefresh;
            searchBtn.Click += handleSearch;
        }

        // handle search action
        private void handleSearch(object sender, EventArgs e)
        {
            if (searchInput.Text == null) return;

            Doctor doctor = doctorService.getDoctorByDoctorId(searchInput.Text);

            string msgToShow = searchResultFormat(doctor);

            MessageBox.Show(msgToShow, "Search Result");
        }

        private string searchResultFormat(Doctor doctor)
        {
            return "ID: " + doctor.doctor_id + "\n" + "Name: " + doctor.name + "\n" + "Gender: " + doctor.gender + "\n" + "Email: " + doctor.email + "\n" + "Contact: " + doctor.phone_number + "\n" + "Specialty: " + doctor.specialty;
        }

        // handle refresh action
        private void handleRefresh(object sender, EventArgs e)
        {
            DoctorForm_Load(sender, e);
        }

        // edit
        private void handleEditDoctor(object? sender, EventArgs e)
        {
            if (selectedDoctor == null)
            {
                MessageBox.Show("No doctor selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addDoctorForm == null || addDoctorForm.IsDisposed)
            {
                addDoctorForm = new AddDoctorForm("Edit", selectedDoctor);
                addDoctorForm.Show();
            }
        }

        // handle row selection
        private void handleRowSelection(object? sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            if (selectedRow == null || selectedRow.Tag == null || !(selectedRow.Tag is Doctor))
            {
                selectedDoctor = null;
                return;
            }

            selectedDoctor = (Doctor)selectedRow.Tag;
        }

        // delete method
        private void handleDeleteDoctor(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete this ?", "Delete Doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Finding specific products using a filter
                var filteredDoctor = doctorService.getDoctor(selectedDoctor.Id);

                if (filteredDoctor == null)
                {
                    MessageBox.Show("Doctor is not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                doctorService.deleteDoctor(filteredDoctor.Id);
                handleRefresh(sender, e);
            }
        }

        // add method
        private void handleAddDoctor(object sender, EventArgs e)
        {
            if (addDoctorForm == null || addDoctorForm.IsDisposed)
            {
                addDoctorForm = new AddDoctorForm();
                addDoctorForm.Show();
            }
        }

        // on load function
        private void DoctorForm_Load(object sender, EventArgs e)
        {
            doctors = doctorService.getDoctors();
            viewDoctors();
        }

        // view doctors
        private void viewDoctors()
        {
            dataGridView1.Rows.Clear();
            foreach (var doctor in doctors)
            {
                int index = dataGridView1.Rows.Add(doctor.doctor_id, doctor.name, doctor.gender, doctor.phone_number, doctor.email, doctor.birth_date, doctor.specialty, doctor.room_number);

                dataGridView1.Rows[index].Tag = doctor;
                dataGridView1.Tag = dataGridView1.Rows[index];
            }
        }
    }
}
