using MetaDataLibrary.CommonTestMaster;
using MetaDataLibrary.LabMaster;
using MetaDataLibrary.PatientAdmission;
using MetaDataLibrary.Prescription;

namespace RepositoryLibrary.Prescription;
public interface IPrescription
{
    List<PrescriptionModel> GetAllPrescription();
    List<LabmasterModel> GetLabmasters(int headId = 0);
    PrescriptionModel GetPrescriptionByID(int id);
    PrescriptionModel GetPrescriptionForTestAction(int id);
    string? GetPrescriptionNo(string prefix);
    IQueryable<string> GetRegistrationNo();
    PrescriptionModel PatientDetails(string regNo);
    string SavePrescription(PrescriptionModel model);
    List<CommonTestViewModel> GetCommonTest(string CommonType);
    List<MedicineAdviceModel> GetMedicineAdviceList(int headId);
    int GetDoctorPrescriptionHeadIdByRegNoPrescriptionNo(string reg_no, string prescription_no);
    List<PrescriptionModel> GetAllPrescriptionByRegno(string reg_no);
    PatientAdmissionMasterViewModel GetPatientByRegNo(string RegNo);
}
