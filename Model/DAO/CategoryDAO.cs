using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Model;

namespace Model.DAO
{
    public class CategoryDAO
    {
        WebBanDtDbContext db = null;
        public CategoryDAO()
        {
            db = new WebBanDtDbContext();
        }

        public List<Categori> ListAll()
        {
            return db.Categoris.Where(x => x.Status == true).ToList();
        }

        public ProductCategory ViewDetail(long id)
        {
            return db.ProductCategories.Find(id);
        }
    }
}
