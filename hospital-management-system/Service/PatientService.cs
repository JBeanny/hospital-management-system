using hospital_management_system.Models;
using MongoDB.Bson;

namespace hospital_management_system.Service
{
    public class PatientService
    {
        private static string _document = "patients";
        private MongoDBService _mongoDBService = new MongoDBService();

        public List<Patient> getPatients()
        {
            try
            {
                List<Patient> patients = _mongoDBService.GetAllDocuments<Patient>(_document);
                return patients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Patient getPatientByPatientId(string patient_id)
        {
            return _mongoDBService.GetDocumentByModelId<Patient>(_document, "patient_id", patient_id);
        }

        public void createPatient(Patient newPatient)
        {
            _mongoDBService.InsertDocument(_document, newPatient);
        }

        public void deletePatient(ObjectId patientId)
        {
            _mongoDBService.DeleteDocument<Patient>(_document, patientId);
        }

        public Patient getPatient(ObjectId patientId)
        {
            return _mongoDBService.GetDocumentById<Patient>(_document, patientId);
        }

        public void modifyPatient(ObjectId patientId, Patient patientToModify)
        {
            _mongoDBService.UpdateDocument<Patient>(_document, patientId, patientToModify);
        }

    }
}
