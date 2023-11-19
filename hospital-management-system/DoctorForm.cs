using hospital_management_system.Models;
using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class DoctorForm : Form
    {
        string filePath = Path.Combine(Environment.CurrentDirectory, "Data", "Doctors.txt");
        List<Doctor> doctors = new List<Doctor>();
        private AddDoctorForm addDoctorForm;
        Util util = new Util();

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
        }

        // handle refresh action
        private void handleRefresh(object sender, EventArgs e)
        {
            DoctorForm_Load(sender, e);
        }

        // edit
        private void handleEditDoctor(object? sender, EventArgs e)
        {
            if (addDoctorForm == null || addDoctorForm.IsDisposed)
            {
                addDoctorForm = new AddDoctorForm("Edit", selectedDoctor);
                addDoctorForm.Show();
            }
        }

        // handle row selection
        private void handleRowSelection(object? sender, EventArgs e)
        {
            Doctor selectedRow = dataGridView1.CurrentRow.Tag as Doctor;

            if (selectedRow == null) return;

            selectedDoctor.id = selectedRow.id;
            selectedDoctor.email = selectedRow.email;
            selectedDoctor.name = selectedRow.name;
            selectedDoctor.birth_date = selectedRow.birth_date;
            selectedDoctor.gender = selectedRow.gender;
            selectedDoctor.phone_number = selectedRow.phone_number;
            selectedDoctor.specialty = selectedRow.specialty;
            selectedDoctor.room_number = selectedRow.room_number;
        }

        // delete method
        private void handleDeleteDoctor(object? sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(filePath);
            var result = MessageBox.Show("Are you sure to delete this ?", "Delete Doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                doctors.ForEach(doctor =>
                {
                    if (doctor.id == selectedDoctor.id) return;

                    string formattedString = util.formattedFileData(doctor.id, doctor.name, doctor.gender, doctor.phone_number, doctor.email, doctor.birth_date, doctor.specialty, doctor.room_number);

                    writer.WriteLine(formattedString);
                });

                writer.Close();
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
            readDoctorsData();
        }

        // read data from file
        private void readDoctorsData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);

                    doctors.Clear();
                    if (lines.Length > 0)
                    {
                        foreach (var line in lines)
                        {
                            var dataRow = line.Split("/");
                            Doctor newDoctor = new Doctor(dataRow[0], dataRow[1], dataRow[3], dataRow[4], dataRow[2], dataRow[5], dataRow[6], dataRow[7]);

                            if (newDoctor == null) continue;
                            doctors.Add(newDoctor);
                        }
                    }
                    viewDoctors();
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

        // view doctors
        private void viewDoctors()
        {
            dataGridView1.Rows.Clear();
            foreach (var doctor in doctors)
            {
                int index = dataGridView1.Rows.Add(doctor.id, doctor.name, doctor.gender, doctor.phone_number, doctor.email, doctor.birth_date, doctor.specialty, doctor.room_number);

                dataGridView1.Rows[index].Tag = doctor;
                dataGridView1.Tag = dataGridView1.Rows[index];
            }
        }
    }
}
