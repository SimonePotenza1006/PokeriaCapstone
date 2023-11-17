namespace PokeriaCapstone.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_User()
        {
            T_Ordini = new HashSet<T_Ordini>();
        }

        [Key]
        public int IDUser { get; set; }

        [StringLength(20)]
        [DisplayName("Username")]
        public string Username { get; set; }

        [StringLength(20)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [StringLength(30)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [StringLength(20)]
        [DisplayName("Role")]
        public string Role { get; set; }

        [StringLength(50)]
        [DisplayName("Indirizzo")]
        public string Indirizzo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Ordini> T_Ordini { get; set; }
    }
}
