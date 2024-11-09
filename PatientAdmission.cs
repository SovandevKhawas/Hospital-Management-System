using MetaDataLibrary.PatientAdmission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLibrary.PatientAdmission
{
    public interface IPatientAdmission
    {
        IQueryable<PatientAdmissionMasterViewModel> GetAllPatients();
        Task<string> SavePatients(PatientAdmissionMasterViewModel master);
        bool ValidateDates(DateTime admissionDate, DateTime? dischargeDate);
        Task<string> GenerateAutoTransactionNo(string finYear, string regNo);
        bool CheckAdvanceEntry(int id);
        bool CheckIfAdmitted(string regNo);
        Task<int> GetLastInsertedId();
    } // IPatientAdmission...
}
