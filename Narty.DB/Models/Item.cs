using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Models
{

    public enum TypPrzedmiotu
    {
        Narty = 1,
        ButyNarciarskie = 2,
        Snowboard = 3,
        ButySnowboardowe = 4,

    }

    public class Item
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public int NumerKatalogowy { get; set; }
        public string Opis { get; set; }
        public TypPrzedmiotu TypPrzedmiotu { get; set; }
    }
}
