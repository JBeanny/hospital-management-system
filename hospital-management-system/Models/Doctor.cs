namespace hospital_management_system.Models
{
    internal class Doctor : Person
    {
        public int id { get; set; }
        public string specialty { get; set; }
        public int room_number { get; set; }

        public Doctor(int id, string name, string phone_number, string email, string gender, string birth_date, string specialty, int room_number) : base(name, phone_number, email, gender, birth_date)
        {
            //this.id = new Util().generateRandomId(8);
            this.id = id;
            this.specialty = specialty;
            this.room_number = room_number;
        }
    }
}
