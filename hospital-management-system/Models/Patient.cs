using hospital_management_system.Utils;

namespace hospital_management_system.Models
{
    internal class Patient : Person
    {
        private string id { get; set; }
        private int age { get; set; }
        private List<string> sicknesses { get; set; }
        private List<string> allergies { get; set; }
        private List<string> prescriptions { get; set; }

        public Patient(string name, string phone_number, string email, string gender, string birth_date, int age, List<string> sicknesses, List<string> allergies, List<string> prescriptions) : base(name, phone_number, email, gender, birth_date)
        {
            this.id = new Util().generateRandomId(8, "PT");
            this.age = age;
            this.sicknesses = sicknesses;
            this.allergies = allergies;
            this.prescriptions = prescriptions;
        }
    }
}
