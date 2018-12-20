using Parkeezzi.ViewModels;

namespace Parkeezzi.Services
{
    public interface IContractorService
    {
        void AddContractor(NewContractor vm);
        void AddContractorInvoice(NewContractorInvoice vm);
        void AddContractorInvoiceItem(NewContractorInvoiceItem vm);
        ContractorView GetContractor(int id);
        ContractorList ListContractors();

    }
}