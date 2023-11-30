using hospital_management_system.Models;
using MongoDB.Bson;

namespace hospital_management_system.Service
{
    public class DoctorService
    {
        private static string _document = "doctors";
        private MongoDBService _mongoDBService = new MongoDBService();

        public List<Doctor> getDoctors()
        {
            try
            {
                List<Doctor> doctors = _mongoDBService.GetAllDocuments<Doctor>(_document);
                return doctors;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void createDoctor(Doctor newDoctor)
        {
            _mongoDBService.InsertDocument(_document, newDoctor);
        }

        public void deleteDoctor(ObjectId doctorId)
        {
            _mongoDBService.DeleteDocument<Doctor>(_document, doctorId);
        }

        public Doctor getDoctor(ObjectId doctorId)
        {
            return _mongoDBService.GetDocumentById<Doctor>(_document, doctorId);
        }

        public void modifyDoctor(ObjectId doctorId, Doctor doctorToModify)
        {
            _mongoDBService.UpdateDocument<Doctor>(_document, doctorId, doctorToModify);
        }

    }
}
