using hospital_management_system.Utils;

namespace hospital_management_system.Models
{
    internal class Doctor : Person
    {
        private int id { get; set; }
        private string specialty { get; set; }
        private int room_number { get; set; }

        public Doctor(string name, string phone_number, string email, string gender, string birth_date, string specialty, int room_number) : base(name, phone_number, email, gender, birth_date)
        {
            this.id = new Util().generateRandomId(8);
            this.specialty = specialty;
            this.room_number = room_number;
        }
    }
}
