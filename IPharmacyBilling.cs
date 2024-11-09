using MetaDataLibrary.PatientBilling;
using MetaDataLibrary.PatientRegistration;
using MetaDataLibrary.SB;
using MetaDataLibrary.SR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLibrary.PatientBilling
{
    public interface IPharmacyBilling
    {
        IQueryable<SBHead> GetAllSBHeadByRegNo(string reg_no, string date_from, string date_to);
        IQueryable<SBDtl> GetAllSBDtlsByBillId(int bill_id);
        IQueryable<SRHead> GetAllSRHeadByRegNo(string reg_no, string date_from, string date_to);
        IQueryable<SRDtl> GetAllSRDtlsByReturnId(int return_id);
        Dictionary<SBHead, IQueryable<SBDtl>> GetSBHeadSBDtlsDics(string reg_no, string date_from, string date_to);
        Dictionary<SRHead, IQueryable<SRDtl>> GetSRHeadSRDtlsDics(string reg_no, string date_from, string date_to);
        decimal GetAdvanceDeposit(string reg_no, string date_from, string date_to);
        decimal GetAmountPaid(string reg_no, string date_from, string date_to);
        decimal GetRefundAmount(string reg_no, string date_from, string date_to);
        PharmacyBillingReport GetPharmacyBillingReport(string reg_no, string date_from, string date_to);
        string GetTotalBalance(string reg_no, string date_from, string date_to);
        IQueryable<PatientBillingComponents> GetAllAdmitedIPDPatientDetails();
        IQueryable<PatientBillingComponents> GetDischargePatient(string fromdate, string todate);
    } // IPharmacyBilling...
}
