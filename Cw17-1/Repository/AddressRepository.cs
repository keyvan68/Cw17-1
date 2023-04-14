using Cw17_1.DAl;
using Cw17_1.Models;
using Cw17_1.Models.ViewModels;

namespace Cw17_1.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDbContext _appDbContext;
        public AddressRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Create(AddressViewModel adrress)
        {
            var adrresRow = new Adrress()
            {
                Name= adrress.Name,
                userId=adrress.userId
            };
            _appDbContext.Adrresses.Add(adrresRow);
            _appDbContext.SaveChanges();
        }
    }
}
