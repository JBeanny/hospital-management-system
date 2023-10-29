namespace hospital_management_system.Models
{
    internal class Consultation
    {
        private int id { get; set; }
        private int patient_id { get; set; }
        private int doctor_id { get; set; }
        private int room_number { get; set; }
        private DateTime date { get; set; }

        public Consultation(int id, int patient_id, int doctor_id, int room_number, DateTime date)
        {
            this.id = id;
            this.patient_id = patient_id;
            this.doctor_id = doctor_id;
            this.room_number = room_number;
            this.date = date;
        }

        public void cancel()
        {

        }

        public void delay()
        {

        }
    }
}
