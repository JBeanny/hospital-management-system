using MongoDB.Bson;

namespace hospital_management_system.Models
{
    public class Doctor : Person
    {
        public ObjectId Id { get; set; }
        public string doctor_id { get; set; }
        public string specialty { get; set; }
        public string room_number { get; set; }

        public Doctor(string id, string name, string phone_number, string email, string gender, string birth_date, string specialty, string room_number) : base(name, phone_number, email, gender, birth_date)
        {
            this.doctor_id = id;
            this.specialty = specialty;
            this.room_number = room_number;
        }

        public Doctor(ObjectId Id, string doctor_id, string name, string phone_number, string email, string gender, string birth_date, string specialty, string room_number) : base(name, phone_number, email, gender, birth_date)
        {
            this.Id = Id;
            this.doctor_id = doctor_id;
            this.specialty = specialty;
            this.room_number = room_number;
        }

        public Doctor()
        {

        }
    }
}
