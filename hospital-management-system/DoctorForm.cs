using hospital_management_system.Models;

namespace hospital_management_system
{
    public partial class DoctorForm : Form
    {
        string filePath = Path.Combine(Environment.CurrentDirectory, "Data", "Doctors.txt");
        List<Doctor> doctors = new List<Doctor>();
        private AddDoctorForm addDoctorForm;
        public DoctorForm()
        {
            InitializeComponent();
            addDoctorBtn.Click += handleAddDoctor;
        }

        private void handleAddDoctor(object sender, EventArgs e)
        {
            if (addDoctorForm == null || addDoctorForm.IsDisposed)
            {
                addDoctorForm = new AddDoctorForm();
                addDoctorForm.Show();
            }
        }

        private void DoctorForm_Load(object sender, EventArgs e)
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
                        Doctor newDoctor = new Doctor((int)Int64.Parse(dataRow[0]), dataRow[1], dataRow[3], dataRow[4], dataRow[2], dataRow[5], dataRow[6], (int)Int64.Parse(dataRow[7]));

                        if (newDoctor == null) continue;
                        doctors.Add(newDoctor);
                    }
                }
                viewDoctors();
            }
            else
            {
                MessageBox.Show("File is not existed");
            }
        }

        private void viewDoctors()
        {
            dataGridView1.Rows.Clear();
            foreach (var doctor in doctors)
            {
                int index = dataGridView1.Rows.Add(doctor.id, doctor.name, doctor.gender, doctor.phone_number, doctor.email, doctor.birth_date, doctor.specialty, doctor.room_number);

                dataGridView1.Rows[index].Tag = doctor;
                dataGridView1.Tag = dataGridView1.Rows[index];
                //dataGridView1.DataModified += DoOnBookModified;
            }
        }
    }
}
