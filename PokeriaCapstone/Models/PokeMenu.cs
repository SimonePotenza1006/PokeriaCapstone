using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PokeriaCapstone.Models
{
    public class PokeMenu
    {
        [DisplayName("Nome Poke Menú")]
        public string NomePokeMenu {  get; set; }
       
        public bool isComposta = false;
        [DisplayName("Prezzo della Poke")]
        public decimal Prezzo {  get; set; }
        [DisplayName("Immagine")]
        public HttpPostedFileBase Immagine { get; set; }
        [DisplayName("Foto della Poke")]
        public string FotoPokeMenu { get; set; }
        [DisplayName("Base della Poke")]
        public int BasePokeMenu { get; set; }
        [DisplayName("Proteina della Poke")]
        public int ProteinaPokeMenu { get; set; }
        [DisplayName("Primo contorno della Poke")]
        public int Contorno1PokeMenu { get; set; }
        [DisplayName("Secondo contorno della Poke")]
        public int Contorno2PokeMenu { get; set; }
        [DisplayName("Terzo contorno della Poke")]
        public int Contorno3PokeMenu { get; set; }
        [DisplayName("Quarto contorno della Poke")]
        public int Contorno4PokeMenu { get; set; }
        [DisplayName("Topping della Poke")]
        public int ToppingPokeMenu { get; set; }
        [DisplayName("Salsa della Poke")]
        public int SalsaPokeMenu { get; set; }

    }
}