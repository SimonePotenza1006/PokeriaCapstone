namespace PokeriaCapstone.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Ordini
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDOrdine { get; set; }

        public int FKIDUser { get; set; }

        public int FKIDPoke { get; set; }

        public DateTime? DataOrdine { get; set; }

        public virtual T_Poke T_Poke { get; set; }

        public virtual T_User T_User { get; set; }
    }
}
