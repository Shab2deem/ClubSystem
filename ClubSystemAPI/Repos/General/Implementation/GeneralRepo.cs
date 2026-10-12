using ClubSystemAPI.Context;
using ClubSystemAPI.Repos.General.Interface;
using Microsoft.EntityFrameworkCore;

namespace ClubSystemAPI.Repos.General.Implementation
{
    public class GeneralRepo<T>:IGeneralRepo<T> where T : class
    {
        readonly DbSet<T> Set;
        public GeneralRepo(MyContext context) {
        Set= context.Set<T>();
        }
        public ICollection<T> GetAll()
        {
            return Set.ToList();
        }
        public T GetById(int id)
        {
            return Set.Find(id);
        }
        public void Update (T entity)
        {
            Set.Update(entity);
        }
        public void Delete(int id)
        {
            Set.Remove(Set.Find(id));
        }
        
        public void Create(T entity)
        {
            Set.Add(entity);
        }
    }
}
