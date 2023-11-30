using MongoDB.Bson;

namespace hospital_management_system.Models
{
    public class Consultation
    {
        public ObjectId Id { get; set; }
        public string consultation_id { get; set; }
        public string patient_id { get; set; }
        public string doctor_id { get; set; }
        public string date { get; set; }

        public Consultation(string id, string patient_id, string doctor_id, string date)
        {
            this.consultation_id = id;
            this.patient_id = patient_id;
            this.doctor_id = doctor_id;
            this.date = date;
        }

        public Consultation(ObjectId Id, string consultation_id, string patient_id, string doctor_id, string date)
        {
            this.Id = Id;
            this.consultation_id = consultation_id;
            this.patient_id = patient_id;
            this.doctor_id = doctor_id;
            this.date = date;
        }

        public Consultation()
        {

        }
    }
}
