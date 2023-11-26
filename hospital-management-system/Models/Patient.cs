namespace hospital_management_system.Models
{
    public class Patient : Person
    {
        public string id { get; set; }
        public int age { get; set; }
        public string sicknesses { get; set; }
        public string allergies { get; set; }

        public Patient(string id, string name, string phone_number, string email, string gender, string birth_date, string sicknesses, string allergies) : base(name, phone_number, email, gender, birth_date)
        {
            this.id = id;
            this.age = 1;
            this.sicknesses = sicknesses;
            this.allergies = allergies;
        }
        public Patient()
        {

        }
    }
}
