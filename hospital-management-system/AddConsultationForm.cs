using hospital_management_system.Models;
using hospital_management_system.Service;
using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class AddConsultationForm : Form
    {

        Util util = new Util();
        string consultationIdToUpdate = "";
        private ConsultationService consultationService = new ConsultationService();
        Consultation _consultationToUpdate = new Consultation();

        // for registration
        public AddConsultationForm(List<Consultation> consultations)
        {
            InitializeComponent();
            label1.Text = "New Consultation Registration Form";
            this.Text = "Consultation Registration Form";
            registerBtn.Click += register;
            cancelBtn.Click += cancel;
        }

        // for modification
        public AddConsultationForm(string method, Consultation consultationToUpdate)
        {
            InitializeComponent();
            registerBtn.Text = method;
            label1.Text = "Edit Consultation Form";
            this.Text = "Consulation Modification Form";

            this.consultationIdToUpdate = consultationToUpdate.consultation_id;
            patientInput.Text = consultationToUpdate.patient_id;
            doctorInput.Text = consultationToUpdate.doctor_id;
            datetimeInput.Text = consultationToUpdate.date;

            _consultationToUpdate = consultationToUpdate;

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
                string patient_id = patientInput.Text;
                string doctor_id = doctorInput.Text;
                string date = datetimeInput.Text;

                if (util.validateInput(consultationIdToUpdate, patient_id, doctor_id, date))
                {
                    if (_consultationToUpdate != null && _consultationToUpdate.Id != null)
                    {
                        if (consultationService.duplicateDateTime(doctor_id, date))
                        {
                            MessageBox.Show("Duplicate Appointment. Please choose another date", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Consultation modifiedConsultation = new Consultation(_consultationToUpdate.Id, consultationIdToUpdate, patient_id, doctor_id, date);

                        Consultation filteredConsultation = consultationService.getConsultation(_consultationToUpdate.Id);

                        if (filteredConsultation == null)
                        {
                            MessageBox.Show("Appointment is not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        consultationService.modifyConsultation(filteredConsultation.Id, modifiedConsultation);

                        MessageBox.Show("Successfully modified appointment", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string id = util.generateRandomId(2, "CST");
                string patient_id = patientInput.Text;
                string doctor_id = doctorInput.Text;
                string date = datetimeInput.Text;


                if (consultationService.duplicateDateTime(doctor_id, date))
                {
                    MessageBox.Show("Duplicate Appointment. Please choose another date", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // validate the input
                if (util.validateInput(id, patient_id, doctor_id, date))
                {
                    Consultation newConsultation = new Consultation(id, patient_id, doctor_id, date);
                    consultationService.createConsultation(newConsultation);

                    MessageBox.Show("Successfully Registered Consultation", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            patientInput.Clear();
            doctorInput.Clear();
        }
    }
}
