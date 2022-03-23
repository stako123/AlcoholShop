using AlcoholShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholShop.Controller
{
    class AlcoholDBController
    {
        //read
        public List<Alcohol> GetAll()
        {
            using (AlcoholDBEntities adbe = new AlcoholDBEntities())
            {
                var alcohols = adbe.Alcohols.ToList();
                return alcohols;
            }
        }

        public void CreateAlcohol(Alcohol a)
        {
            using (AlcoholDBEntities adbe = new AlcoholDBEntities())
            {
                a.Id = adbe.Alcohols.ToList().LastOrDefault().Id + 1;
                adbe.Alcohols.Add(a);
                adbe.SaveChanges();
            }
        }
    }
}
