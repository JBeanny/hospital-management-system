using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class AddDoctorForm : Form
    {
        Util util = new Util();
        string filePath = Path.Combine(Environment.CurrentDirectory, "Data", "Doctors.txt");

        public AddDoctorForm()
        {
            InitializeComponent();
            registerBtn.Click += register;
            cancelBtn.Click += cancel;
        }

        private void cancel(object sender, EventArgs e)
        {
            this.Close();
        }


        private void register(object sender, EventArgs e)
        {
            string id = util.generateRandomId(2, "DR");
            string name = nameInput.Text;
            string gender = genderInput.Text;
            string phone = phoneInput.Text;
            string email = emailInput.Text;
            string birthdate = birthdateInput.Text;
            string specialty = specialtyInput.Text;
            string room = roomInput.Text;

            if (validateInput(id, name, gender, phone, email, birthdate, specialty, room))
            {
                string stringToWrite = formattedFileData(id, name, gender, phone, email, birthdate, specialty, room);

                if (File.Exists(filePath))
                {
                    StreamWriter writer = new StreamWriter(filePath, true);
                    writer.WriteLine(stringToWrite);
                    writer.Close();
                    clearForm();
                }
                else
                {
                    MessageBox.Show("File is not existed");
                }
            }

        }

        private Boolean validateInput(string id, string name, string gender, string phone, string email, string birthdate, string specialty, string room)
        {
            return id != "" || name != "" || gender != "" || phone != "" || email != "" || birthdate != "" || specialty != "" || room != "";
        }
        private string formattedFileData(string id, string name, string gender, string phone, string email, string birthdate, string specialty, string room)
        {
            return id + "/" + name + "/" + gender + "/" + phone + "/" + email + "/" + birthdate + "/" + specialty + "/" + room;
        }

        private void clearForm()
        {
            nameInput.Clear();
            genderInput.Clear();
            phoneInput.Clear();
            emailInput.Clear();
            birthdateInput.Clear();
            specialtyInput.Clear();
            roomInput.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
