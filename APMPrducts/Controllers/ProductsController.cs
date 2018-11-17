using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APMPrducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<ProductModel> Products;
        public ProductsController()
        {
            try
            {
                Products = new List<ProductModel>();
                Products.Add(new ProductModel
                {
                    Id = 1,
                    ProductName = "Leaf Rake",
                    ProductCode = "GDN-0011",
                    ReleaseDate = "March 19, 2016",
                    Description = "Leaf rake with 48-inch wooden handle.",
                    Price = 19.95M,
                    StarRating = 3.2M,
                    ImageUrl = "http://openclipart.org/image/300px/svg_to_png/26215/Anonymous_Leaf_Rake.png",
                    Category = "Garden",
                    Tags = new List<string>{ "rake", "leaf", "yard", "home" }
                });
                Products.Add(
                new ProductModel
                {
                    Id = 2,
                    ProductName = "Garden Cart",
                    ProductCode = "GDN-0023",
                    ReleaseDate = "March 18, 2016",
                    Description = "15 gallon capacity rolling garden cart.",
                    Price = 32.99M,
                    StarRating = 4.2M,
                    ImageUrl = "http://openclipart.org/image/300px/svg_to_png/58471/garden_cart.png",
                    Category = "Garden"
                });
                Products.Add(
                new ProductModel
                {
                    Id = 5,
                    ProductName = "Hammer",
                    ProductCode = "GDN-0048",
                    ReleaseDate = "March 21, 2016",
                    Description = "Curved claw steel hammer",
                    Price = 8.90M,
                    StarRating = 4.8M,
                    ImageUrl = "http://openclipart.org/image/300px/svg_to_png/73/rejon_Hammer.png",
                    Category = "Toolbox",
                    Tags = new List<string>{ "tools", "hammer", "construction" }
                });
                Products.Add(
                new ProductModel
                {
                    Id = 8,
                    ProductName = "Saw",
                    ProductCode = "GDN-0022",
                    ReleaseDate = "May 19, 2016",
                    Description = "15-inch steel blade hand saw.",
                    Price = 11.55M,
                    StarRating = 3.7M,
                    ImageUrl = "http://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png",
                    Category = "Toolbox"
                });
                Products.Add(
                new ProductModel
                {
                    Id = 10,
                    ProductName = "Video Game Controller",
                    ProductCode = "GDN-0042",
                    ReleaseDate = "May 19, 2016",
                    Description = "Standard two-button video game controller.",
                    Price = 35.95M,
                    StarRating = 4.6M,
                    ImageUrl = "http://openclipart.org/image/300px/svg_to_png/120337/xbox-controller_01.png",
                    Category = "Gaming"
                });
        }
            catch(Exception x)
            {

            }
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> Get()
        {
            return Products;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ProductModel> Get(int id)
        {
            return Products[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
