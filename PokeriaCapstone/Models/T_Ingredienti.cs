namespace PokeriaCapstone.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    public partial class T_Ingredienti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Ingredienti()
        {
            T_RelazionePokeIngredienti = new HashSet<T_RelazionePokeIngredienti>();
        }

        [Key]
        public int IDIngrediente { get; set; }

        [Required]
        [StringLength(30)]
        public string NomeIngrediente { get; set; }

        [Required]
        [StringLength(20)]
        public string TipoIngrediente { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrezzoAggiuntivo { get; set; }


        [NotMapped]
        public HttpPostedFileBase Immagine { get; set; }

        [Required]
        [StringLength(150)]
        public string FotoIngrediente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_RelazionePokeIngredienti> T_RelazionePokeIngredienti { get; set; }




    }
}
