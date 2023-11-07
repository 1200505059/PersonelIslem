using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int LLPersonelEkle(EntityPersonel personel)
        {
            if (personel.Ad !="" && personel.Soyad!="" && personel.Odeme >=3500)
            {
                return DALPersonel.PersonelEkle(personel);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLPersonelSil(int parameter)
        {
            if (parameter >= 1)
            {
                return DALPersonel.PersonelSil(parameter);
            }
            else
            {
                return false;
            }
        }

    public static bool LLPersonelGuncelle(EntityPersonel ent)
        {
            if(ent.Ad.Length>=3 && ent.Ad!="" && ent.Odeme >= 100)
            {
                return DALPersonel.PersonelGuncelle(ent);
            }
            else
            {
                return false;
            }



        }
    }
}
