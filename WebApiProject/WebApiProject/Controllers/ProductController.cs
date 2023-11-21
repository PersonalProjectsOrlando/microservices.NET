using Microsoft.AspNetCore.Mvc;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("/products")]
    public class ProductController : ControllerBase
    {
        static List<Product> ListProducts = new List<Product>()
        /*Product p1 = new Product(1, "Hot Dog", 100, "Hot Dog wit Samdwich");
        Product p2 = new Product(2, "Potatoes", 200, "French fries");
        public ProductController() {
            ListProducts.Add(p1);
            ListProducts.Add(p2);
        }*/
        // otra opcion sin necesidad de usar el metodo constructor
        {
        new Product{Id=1,Name="Hot Dog", Price = 100,Description = "Hot Dog with sausage"},
        new Product{Id=2,Name="Potatoes", Price = 200,Description = "French fries"},
        new Product{Id=3,Name="Potatoes", Price = 200,Description = "French fries"},
        };
        [HttpGet("/products")]
        public  ActionResult<List<Product>> GetAll() {
            return ListProducts;
        }
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id) {
            
            //return ListProducts.Single(x => x.Id ==id );
            var product = ListProducts.FirstOrDefault(x => x.Id == id);
            if (product == null) {
                return NotFound();
            }
            return product;
         }
       
        [HttpPost]
        public ActionResult<string> Create(Product product) {
            product.Id = ListProducts.Count()+1;
            ListProducts.Add(product);
            //return CreatedAtAction(nameof(Get),new { id = product.Id}, product);
            CreatedAtAction("Get",new { id = product.Id}, product);
            return "Created OK"+ CreatedAtAction("Get",new { id = product.Id}, product);;

        }
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id){
            ListProducts = ListProducts.Where(x => x.Id  != id).ToList();
            //return NoContent();
            return "Delete Product Ok";
        }
        [HttpPut("{productId}")]
        public ActionResult<string> Update(int productId, Product product) {
            var originalEntry = ListProducts.Single(x => x.Id ==productId);
            originalEntry.Name=product.Name;
            originalEntry.Price=product.Price;
            originalEntry.Description=product.Description;
            //return NoContent();
            return "Update OK";
        }


    }
}
