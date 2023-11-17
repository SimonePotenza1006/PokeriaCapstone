namespace PokeriaCapstone.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_RelazionePokeIngredienti
    {
        [Key]
        public int IDRelazione { get; set; }
        [DisplayName("ID della Poke")]
        public int? FKIDPoke { get; set; }
        [DisplayName("ID dell'ingrediente")]
        public int? FKIDIngrediente { get; set; }

        public virtual T_Ingredienti T_Ingredienti { get; set; }

        public virtual T_Poke T_Poke { get; set; }
    }
}
