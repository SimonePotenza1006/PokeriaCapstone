namespace PokeriaCapstone.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Ordini
    {
        [Key]
        public int IDOrdine { get; set; }
        [DisplayName("ID Utente")]
        public int FKIDUser { get; set; }
        [DisplayName("ID Poke")]
        public int FKIDPoke { get; set; }
        [DisplayName("Data dell'ordine")]
        public DateTime? DataOrdine { get; set; }

        public virtual T_Poke T_Poke { get; set; }

        public virtual T_User T_User { get; set; }

        public T_Ordini() { }

        public T_Ordini(int fkidUser, int fkidPoke)
        {
            FKIDUser = fkidUser;
            FKIDPoke = fkidPoke;
            
        }
    }
}
