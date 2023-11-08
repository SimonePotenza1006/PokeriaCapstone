using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PokeriaCapstone.Models
{
    public partial class ModelDBContext : DbContext
    {
        public ModelDBContext()
            : base("name=ModelDBContext")
        {
        }

        public virtual DbSet<T_Ingredienti> T_Ingredienti { get; set; }
        public virtual DbSet<T_Ordini> T_Ordini { get; set; }
        public virtual DbSet<T_Poke> T_Poke { get; set; }
        public virtual DbSet<T_RelazionePokeIngredienti> T_RelazionePokeIngredienti { get; set; }
        public virtual DbSet<T_User> T_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_Ingredienti>()
                .Property(e => e.PrezzoAggiuntivo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<T_Ingredienti>()
                .HasMany(e => e.T_RelazionePokeIngredienti)
                .WithOptional(e => e.T_Ingredienti)
                .HasForeignKey(e => e.FKIDIngrediente);

            modelBuilder.Entity<T_Poke>()
                .Property(e => e.Prezzo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<T_Poke>()
                .HasMany(e => e.T_Ordini)
                .WithRequired(e => e.T_Poke)
                .HasForeignKey(e => e.FKIDPoke)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_Poke>()
                .HasMany(e => e.T_RelazionePokeIngredienti)
                .WithOptional(e => e.T_Poke)
                .HasForeignKey(e => e.FKIDPoke);

            modelBuilder.Entity<T_User>()
                .HasMany(e => e.T_Ordini)
                .WithRequired(e => e.T_User)
                .HasForeignKey(e => e.FKIDUser)
                .WillCascadeOnDelete(false);
        }
    }
}
