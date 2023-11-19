using hospital_management_system.Models;
using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class AddDoctorForm : Form
    {
        Util util = new Util();
        string filePath = Path.Combine(Environment.CurrentDirectory, "Data", "Doctors.txt");
        string doctorIdToUpdate = "";

        // for registration
        public AddDoctorForm()
        {
            InitializeComponent();
            label1.Text = "New Doctor Registration Form";
            this.Text = "Doctor Registration Form";
            registerBtn.Click += register;
            cancelBtn.Click += cancel;
        }

        // for modification
        public AddDoctorForm(string method, Doctor doctorToUpdate)
        {
            InitializeComponent();
            registerBtn.Text = method;
            label1.Text = "Edit Doctor Form";
            this.Text = "Doctor Edit Form";

            doctorIdToUpdate = doctorToUpdate.id;
            nameInput.Text = doctorToUpdate.name;
            genderInput.Text = doctorToUpdate.gender;
            phoneInput.Text = doctorToUpdate.phone_number;
            emailInput.Text = doctorToUpdate.email;
            birthdateInput.Text = doctorToUpdate.birth_date;
            specialtyInput.Text = doctorToUpdate.specialty;
            roomInput.Text = doctorToUpdate.specialty;

            registerBtn.Click += modify;
        }

        // cancel
        private void cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        // modify
        private void modify(object sender, EventArgs e)
        {
            List<Doctor> data = new List<Doctor>();

            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);
                    StreamWriter writer = new StreamWriter(filePath);

                    data.Clear();
                    if (lines.Length > 0)
                    {
                        // read each line from file
                        foreach (var line in lines)
                        {
                            var dataRow = line.Split("/");
                            Doctor doctor = new Doctor(dataRow[0], dataRow[1], dataRow[3], dataRow[4], dataRow[2], dataRow[5], dataRow[6], dataRow[7]);

                            if (doctor == null) continue;

                            // id is matched then modify
                            if (dataRow[0] == doctorIdToUpdate)
                            {
                                string name = nameInput.Text;
                                string gender = genderInput.Text;
                                string phone = phoneInput.Text;
                                string email = emailInput.Text;
                                string birthdate = birthdateInput.Text;
                                string specialty = specialtyInput.Text;
                                string room = roomInput.Text;

                                if (util.validateInput(doctorIdToUpdate, name, gender, phone, email, birthdate, specialty, room))
                                {
                                    // formatted string to add to file
                                    string formattedStr = util.formattedFileData(doctorIdToUpdate, name, gender, phone, email, birthdate, specialty, room);

                                    writer.WriteLine(formattedStr);
                                    continue;
                                }

                                // if validate failed then write the old the data
                                writer.WriteLine(line);
                            }

                            // if not matched id then write the old data
                            writer.WriteLine(line);
                        }
                        writer.Close();
                        this.Close();
                    }
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

        // register
        private void register(object sender, EventArgs e)
        {
            // set values to add to file
            string id = util.generateRandomId(2, "DR");
            string name = nameInput.Text;
            string gender = genderInput.Text;
            string phone = phoneInput.Text;
            string email = emailInput.Text;
            string birthdate = birthdateInput.Text;
            string specialty = specialtyInput.Text;
            string room = roomInput.Text;

            // validate the input
            if (util.validateInput(id, name, gender, phone, email, birthdate, specialty, room))
            {
                string stringToWrite = util.formattedFileData(id, name, gender, phone, email, birthdate, specialty, room);

                if (File.Exists(filePath))
                {
                    StreamWriter writer = new StreamWriter(filePath, true);
                    writer.WriteLine(stringToWrite);
                    writer.Close();
                    clearForm();
                }
                else
                {
                    MessageBox.Show("File is not existed", "Failed to open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}
