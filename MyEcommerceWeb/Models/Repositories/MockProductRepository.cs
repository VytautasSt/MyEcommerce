namespace MyEcommerceWeb.Models.Repositories
{
    public class MockProductRepository : IRepository<Product>
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            return new Product { Id = id, Name = $"Name_{id}", ProductType = "Pastery" };
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
