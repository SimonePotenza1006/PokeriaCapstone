using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeriaCapstone.Models
{
    public class PokeMenu
    {
        public string NomePokeMenu {  get; set; }   
        public bool isComposta = false;
        public decimal Prezzo {  get; set; }
        public HttpPostedFileBase Immagine { get; set; }
        public string FotoPokeMenu { get; set; }
        public int BasePokeMenu { get; set; }
        public int ProteinaPokeMenu { get; set; }
        public int Contorno1PokeMenu { get; set; }
        public int Contorno2PokeMenu { get; set; }
        public int Contorno3PokeMenu { get; set; }
        public int Contorno4PokeMenu { get; set; }
        public int ToppingPokeMenu { get; set; }
        public int SalsaPokeMenu { get; set; }

    }
}