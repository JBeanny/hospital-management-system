using hospital_management_system.Models;
using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class PatientRegistrationForm : Form
    {
        Util util = new Util();
        string filePath = Path.Combine(Environment.CurrentDirectory, "Data", "Patients.txt");
        string patientToUpdate = "";

        // for registration
        public PatientRegistrationForm()
        {
            InitializeComponent();
            label1.Text = "New Patient Registration Form";
            this.Text = "Patient Registration Form";
            registerBtn.Click += register;
            cancelBtn.Click += cancel;
        }

        // for modification
        public PatientRegistrationForm(string method, Patient patientToUpdate)
        {
            InitializeComponent();
            registerBtn.Text = method;
            label1.Text = "Edit Patient Form";
            this.Text = "Patient Modification Form";

            this.patientToUpdate = patientToUpdate.id;
            nameInput.Text = patientToUpdate.name;
            genderInput.Text = patientToUpdate.gender;
            phoneInput.Text = patientToUpdate.phone_number;
            emailInput.Text = patientToUpdate.email;
            birthdateInput.Text = patientToUpdate.birth_date;
            sicknessInput.Text = patientToUpdate.sicknesses;
            allergyInput.Text = patientToUpdate.allergies;

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
            List<Patient> data = new List<Patient>();

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
                            Patient patient = new Patient(dataRow[0], dataRow[1], dataRow[3], dataRow[4], dataRow[2], dataRow[5], dataRow[6], dataRow[7]);

                            if (patient == null) continue;

                            // id is matched then modify
                            if (dataRow[0] == patientToUpdate)
                            {
                                string name = nameInput.Text;
                                string gender = genderInput.Text;
                                string phone = phoneInput.Text;
                                string email = emailInput.Text;
                                string birthdate = birthdateInput.Text;
                                string sickness = sicknessInput.Text;
                                string allergy = allergyInput.Text;

                                if (util.validateInput(patientToUpdate, name, gender, phone, email, birthdate, sickness, allergy))
                                {
                                    // formatted string to add to file
                                    string formattedStr = util.formattedFileData(patientToUpdate, name, gender, phone, email, birthdate, sickness, allergy);

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
            string id = util.generateRandomId(2, "PT");
            string name = nameInput.Text;
            string gender = genderInput.Text;
            string phone = phoneInput.Text;
            string email = emailInput.Text;
            string birthdate = birthdateInput.Text;
            string sickness = sicknessInput.Text;
            string allergy = allergyInput.Text;

            // validate the input
            if (util.validateInput(id, name, gender, phone, email, birthdate, sickness, allergy))
            {
                string stringToWrite = util.formattedFileData(id, name, gender, phone, email, birthdate, sickness, allergy);

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
            sicknessInput.Clear();
            allergyInput.Clear();
        }
    }
}
