using hospital_management_system.Models;
using hospital_management_system.Service;
using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class PatientRegistrationForm : Form
    {
        Util util = new Util();
        string patientIdToUpdate = "";
        Patient _patientToUpdate = new Patient();
        private PatientService patientService;

        // for registration
        public PatientRegistrationForm()
        {
            InitializeComponent();

            patientService = new PatientService();

            label1.Text = "New Patient Registration Form";
            this.Text = "Patient Registration Form";
            registerBtn.Click += register;
            cancelBtn.Click += cancel;
        }

        // for modification
        public PatientRegistrationForm(string method, Patient patientToUpdate)
        {
            InitializeComponent();

            patientService = new PatientService();

            registerBtn.Text = method;
            label1.Text = "Edit Patient Form";
            this.Text = "Patient Modification Form";

            this.patientIdToUpdate = patientToUpdate.patient_id;
            nameInput.Text = patientToUpdate.name;
            genderInput.Text = patientToUpdate.gender;
            phoneInput.Text = patientToUpdate.phone_number;
            emailInput.Text = patientToUpdate.email;
            birthdateInput.Text = patientToUpdate.birth_date;
            sicknessInput.Text = patientToUpdate.sicknesses;
            allergyInput.Text = patientToUpdate.allergies;

            _patientToUpdate = patientToUpdate;

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
            try
            {
                string name = nameInput.Text;
                string gender = genderInput.Text;
                string phone = phoneInput.Text;
                string email = emailInput.Text;
                string birthdate = birthdateInput.Text;
                string sickness = sicknessInput.Text;
                string allergy = allergyInput.Text;

                if (util.validateInput(patientIdToUpdate, name, gender, phone, email, birthdate, sickness, allergy))
                {
                    if (_patientToUpdate != null && _patientToUpdate.Id != null)
                    {
                        Patient modifiedPatient = new Patient(_patientToUpdate.Id, patientIdToUpdate, name, phone, email, gender, birthdate, sickness, allergy);

                        // find patient before updating
                        Patient filteredPatient = patientService.getPatient(_patientToUpdate.Id);

                        if (filteredPatient == null)
                        {
                            MessageBox.Show("Patient is not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // if patient found then update
                        patientService.modifyPatient(filteredPatient.Id, modifiedPatient);

                        MessageBox.Show("Successfully modified patient", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            try
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
                    Patient newPatient = new Patient(id, name, phone, email, gender, birthdate, sickness, allergy);
                    patientService.createPatient(newPatient);

                    MessageBox.Show("Successfully Registered Patient", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
