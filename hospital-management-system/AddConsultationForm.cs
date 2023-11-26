using hospital_management_system.Models;
using hospital_management_system.Utils;

namespace hospital_management_system
{
    public partial class AddConsultationForm : Form
    {

        Util util = new Util();
        string filePath = Path.Combine(Environment.CurrentDirectory, "Data", "Consultations.txt");
        string consultationIdToUpdate = "";
        List<Consultation> consultations = new List<Consultation>();

        // for registration
        public AddConsultationForm(List<Consultation> consultations)
        {
            InitializeComponent();
            label1.Text = "New Consultation Registration Form";
            this.Text = "Consultation Registration Form";
            registerBtn.Click += register;
            cancelBtn.Click += cancel;
            this.consultations = consultations;
        }

        // for modification
        public AddConsultationForm(string method, Consultation consultationToUpdate)
        {
            InitializeComponent();
            registerBtn.Text = method;
            label1.Text = "Edit Consultation Form";
            this.Text = "Consulation Modification Form";

            this.consultationIdToUpdate = consultationToUpdate.id;
            patientInput.Text = consultationToUpdate.patient_id;
            doctorInput.Text = consultationToUpdate.doctor_id;
            datetimeInput.Text = consultationToUpdate.date;

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
            List<Consultation> data = new List<Consultation>();

            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);
                    StreamWriter writer = new StreamWriter(filePath);

                    if (duplicateDateTime(doctorInput.Text, datetimeInput.Text))
                    {
                        MessageBox.Show("Duplicate Consultation. Please choose another date", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    data.Clear();
                    if (lines.Length > 0)
                    {
                        // read each line from file
                        foreach (var line in lines)
                        {
                            var dataRow = line.Split("/");
                            Consultation patient = new Consultation(dataRow[0], dataRow[1], dataRow[2], dataRow[3]);

                            if (patient == null) continue;

                            // id is matched then modify
                            if (dataRow[0] == consultationIdToUpdate)
                            {
                                string patient_id = patientInput.Text;
                                string doctor_id = doctorInput.Text;
                                string date = datetimeInput.Text;

                                if (util.validateInput(consultationIdToUpdate, patient_id, doctor_id, date))
                                {
                                    // formatted string to add to file
                                    string formattedStr = util.formattedFileData(consultationIdToUpdate, patient_id, doctor_id, date);

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
            string id = util.generateRandomId(2, "CST");
            string patient_id = patientInput.Text;
            string doctor_id = doctorInput.Text;
            string date = datetimeInput.Text;


            if (duplicateDateTime(doctor_id, date))
            {
                MessageBox.Show("Duplicate Consultation. Please choose another date", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // validate the input
            if (util.validateInput(id, patient_id, doctor_id, date))
            {
                string stringToWrite = util.formattedFileData(id, patient_id, doctor_id, date);

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
            patientInput.Clear();
            doctorInput.Clear();
        }

        private Boolean duplicateDateTime(string doctor_id, string date)
        {
            Boolean result = false;
            consultations.ForEach(consultation =>
            {
                if (consultation.doctor_id == doctor_id)
                {
                    if (date == consultation.date)
                    {
                        result = true;
                    }
                }
            });

            return result;
        }
    }
}
