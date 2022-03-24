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
                if (adbe.Alcohols.ToList().LastOrDefault() == null)
                {
                    a.Id = 1;
                }
                else
                {
                    a.Id = adbe.Alcohols.ToList().LastOrDefault().Id + 1;
                }
                adbe.Alcohols.Add(a);
                adbe.SaveChanges();
            }
        }

        public void DeleteAlcohol(int id)
        {
            using (AlcoholDBEntities adbe = new AlcoholDBEntities())
            {
                var alcoholToDelete = adbe.Alcohols.Where(a => a.Id == id).FirstOrDefault();
                if (alcoholToDelete != null)
                {
                    adbe.Alcohols.Remove(alcoholToDelete);
                    adbe.SaveChanges();
                }
            }
        }
    }
}
