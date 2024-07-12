using System.Collections.Generic;

namespace Testing.Models
{
    public interface IProductRepository
    {

        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        public void InsertProduct(Product productToInsert);
        public void DeleteProduct(Product product);

    }
    


}
