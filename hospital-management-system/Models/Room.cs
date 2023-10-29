namespace hospital_management_system.Models
{
    internal class Room
    {
        private int id { get; set; }
        private int doctor_id { get; set; }
        private int nurse_id { get; set; }

        public Room(int id, int doctor_id, int nurse_id)
        {
            this.id = id;
            this.doctor_id = doctor_id;
            this.nurse_id = nurse_id;
        }
    }
}
