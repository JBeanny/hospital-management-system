namespace hospital_management_system.Models
{
    internal class Doctor : Person
    {
        public string id { get; set; }
        public string specialty { get; set; }
        public string room_number { get; set; }

        public Doctor(string id, string name, string phone_number, string email, string gender, string birth_date, string specialty, string room_number) : base(name, phone_number, email, gender, birth_date)
        {
            //this.id = new Util().generateRandomId(8);
            this.id = id;
            this.specialty = specialty;
            this.room_number = room_number;
        }
    }
}
