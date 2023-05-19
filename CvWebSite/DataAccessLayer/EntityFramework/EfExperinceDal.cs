using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfExperinceDal : GenericRepository<Experience> , IExperinceDal
    {
    }
}
