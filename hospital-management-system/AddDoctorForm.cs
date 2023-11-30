using hospital_management_system.Models;
using hospital_management_system.Service;
using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class AddDoctorForm : Form
    {
        Util util = new Util();
        string doctorIdToUpdate = "";
        Doctor _doctorToUpdate = new Doctor();
        private DoctorService doctorService = new DoctorService();

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

            if (doctorIdToUpdate != null)
            {
                doctorIdToUpdate = doctorToUpdate.doctor_id;

                nameInput.Text = doctorToUpdate.name;
                genderInput.Text = doctorToUpdate.gender;
                phoneInput.Text = doctorToUpdate.phone_number;
                emailInput.Text = doctorToUpdate.email;
                birthdateInput.Text = doctorToUpdate.birth_date;
                specialtyInput.Text = doctorToUpdate.specialty;
                roomInput.Text = doctorToUpdate.specialty;

                _doctorToUpdate = doctorToUpdate;

                registerBtn.Click += modify;
            }

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
                string specialty = specialtyInput.Text;
                string room = roomInput.Text;

                if (util.validateInput(doctorIdToUpdate, name, gender, phone, email, birthdate, specialty, room))
                {

                    if (_doctorToUpdate != null && _doctorToUpdate.Id != null)
                    {
                        Doctor modifiedDoctor = new Doctor(_doctorToUpdate.Id, doctorIdToUpdate, name, phone, email, gender, birthdate, specialty, room);
                        // Finding specific products using a filter
                        Doctor filteredDoctor = doctorService.getDoctor(_doctorToUpdate.Id);

                        if (filteredDoctor == null)
                        {
                            MessageBox.Show("Doctor is not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        doctorService.modifyDoctor(filteredDoctor.Id, modifiedDoctor);

                        MessageBox.Show("Successfully modified doctor", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Doctor newDoctor = new Doctor(id, name, phone, email, gender, birthdate, specialty, room);
                    doctorService.createDoctor(newDoctor);

                    MessageBox.Show("Successfully Registered Doctor", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            specialtyInput.Clear();
            roomInput.Clear();
        }
    }
}
