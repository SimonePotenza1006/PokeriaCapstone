namespace PokeriaCapstone.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    public partial class T_Poke
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Poke()
        {
            T_Ordini = new HashSet<T_Ordini>();
            T_RelazionePokeIngredienti = new HashSet<T_RelazionePokeIngredienti>();
        }

        [Key]
        public int IDPoke { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Nome Poke")]
        public string NomePoke { get; set; }

        [DisplayName("� composta?")]
        public bool? IsComposta { get; set; }

        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal? Prezzo { get; set; }

        [NotMapped]
        public HttpPostedFileBase Immagine { get; set; }

        [StringLength(150)]
        [DisplayName("Nome Poke")]
        public string FotoPoke { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Ordini> T_Ordini { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_RelazionePokeIngredienti> T_RelazionePokeIngredienti { get; set; }

        public T_Poke(string nomePoke, bool isComposta, decimal prezzo, string fotoPoke)
        {
            NomePoke = nomePoke;
            IsComposta = isComposta;
            Prezzo = prezzo;
            FotoPoke = fotoPoke;
        }
    }
}
