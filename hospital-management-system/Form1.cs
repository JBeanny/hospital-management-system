namespace hospital_management_system
{
    public partial class Form1 : Form
    {
        private DoctorForm doctorForm;
        private PatientForm patientForm;
        public Form1()
        {
            InitializeComponent();
            viewDoctorBtn.Click += viewDoctors;
            viewPatientBtn.Click += viewPatients;
            viewNurseBtn.Click += viewNurses;
        }

        private void viewPatients(object sender, EventArgs e)
        {
            if (patientForm == null || patientForm.IsDisposed)
            {
                patientForm = new PatientForm();
                patientForm.Show();
            }
        }

        private void viewNurses(object sender, EventArgs e)
        {
            if (doctorForm == null || doctorForm.IsDisposed)
            {
                doctorForm = new DoctorForm();
                doctorForm.Show();
            }
        }

        private void viewDoctors(object sender, EventArgs e)
        {
            if (doctorForm == null || doctorForm.IsDisposed)
            {
                doctorForm = new DoctorForm();
                doctorForm.Show();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logoImageBox_Click(object sender, EventArgs e)
        {

        }
    }
}