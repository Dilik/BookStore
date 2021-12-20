using BookStore.Models;

namespace BookStore.Repository.IRepository
{
    public interface ICompanyRepository:IRepository<Company>
    {
        void Update(Company obj);
    }
}
