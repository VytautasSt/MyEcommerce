namespace MyEcommerceWeb.Models.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        T Get(int id);
        List<T> GetAll();
        void Update(T entity);
        void Delete(int id);
    }
}
