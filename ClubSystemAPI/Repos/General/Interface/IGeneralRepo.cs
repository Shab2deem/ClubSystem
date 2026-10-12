namespace ClubSystemAPI.Repos.General.Interface
{
    public interface IGeneralRepo<T>
    {
        public ICollection<T> GetAll();
        public T GetById(int id);
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(int id);
    }
}
