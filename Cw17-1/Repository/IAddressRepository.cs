using Cw17_1.Models;
using Cw17_1.Models.ViewModels;

namespace Cw17_1.Repository
{
    public interface IAddressRepository
    {
        void Create(AddressViewModel adrress);
    }
}