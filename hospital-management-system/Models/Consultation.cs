namespace hospital_management_system.Models
{
    public class Consultation
    {
        public string id { get; set; }
        public string patient_id { get; set; }
        public string doctor_id { get; set; }
        public string date { get; set; }

        public Consultation(string id, string patient_id, string doctor_id, string date)
        {
            this.id = id;
            this.patient_id = patient_id;
            this.doctor_id = doctor_id;
            this.date = date;
        }

        public Consultation()
        {

        }
    }
}
