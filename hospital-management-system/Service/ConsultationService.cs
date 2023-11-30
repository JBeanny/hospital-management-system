using hospital_management_system.Models;
using MongoDB.Bson;

namespace hospital_management_system.Service
{
    public class ConsultationService
    {
        private static string _document = "appointments";
        private MongoDBService _mongoDBService = new MongoDBService();

        public List<Consultation> getConsultations()
        {
            try
            {
                List<Consultation> consultations = _mongoDBService.GetAllDocuments<Consultation>(_document);
                return consultations;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void createConsultation(Consultation newConsultation)
        {
            _mongoDBService.InsertDocument(_document, newConsultation);
        }

        public void deleteConsultation(ObjectId consultationId)
        {
            _mongoDBService.DeleteDocument<Doctor>(_document, consultationId);
        }

        public Consultation getConsultation(ObjectId consultationId)
        {
            return _mongoDBService.GetDocumentById<Consultation>(_document, consultationId);
        }

        public void modifyConsultation(ObjectId consultationId, Consultation consultationToModify)
        {
            _mongoDBService.UpdateDocument<Consultation>(_document, consultationId, consultationToModify);
        }

        public Boolean duplicateDateTime(string consultation_id, string date)
        {
            Boolean result = false;
            Consultation consultation = _mongoDBService.GetDocumentByModelId<Consultation>(_document, "doctor_id", consultation_id);

            if (consultation != null && date == consultation.date)
            {
                result = true;
            }

            return result;
        }

    }
}
