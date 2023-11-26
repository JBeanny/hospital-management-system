namespace hospital_management_system
{
    public partial class Form1 : Form
    {
        private DoctorForm doctorForm;
        private PatientForm patientForm;
        private ConsultationMainForm consultationMainForm;
        public Form1()
        {
            InitializeComponent();
            viewDoctorBtn.Click += viewDoctors;
            viewPatientBtn.Click += viewPatients;
            viewConsultationBtn.Click += viewConsultations;
        }

        private void viewPatients(object sender, EventArgs e)
        {
            if (patientForm == null || patientForm.IsDisposed)
            {
                patientForm = new PatientForm();
                patientForm.Show();
            }
        }

        private void viewConsultations(object sender, EventArgs e)
        {
            if (consultationMainForm == null || consultationMainForm.IsDisposed)
            {
                consultationMainForm = new ConsultationMainForm();
                consultationMainForm.Show();
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

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}