using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdeToFood.Core;
namespace OdoToFood.Data
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();

    }
    public class InMemoryResturantData : IResturantData
    {
        List<Resturant> resturants;
        public InMemoryResturantData()
        {
            resturants = new List<Resturant>()
            {
                new Resturant{ Id=1,Name="Scott's Pizza",Location="Egypt",Cuisine=CuisineType.Italian},
                 new Resturant{ Id=2,Name="Mahmoud's Margeretaa",Location="USA",Cuisine=CuisineType.Mexican},
                  new Resturant{ Id=3,Name="Matb3aa's Torta",Location="Londan",Cuisine=CuisineType.Indian}

            };
        }
        public IEnumerable<Resturant> GetAll()
        {
            return from r in resturants
                   orderby r.Name
                   select r;    
        }
    }
}
