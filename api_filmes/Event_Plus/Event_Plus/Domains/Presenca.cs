using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Event_plus.Domains;
using EventPlus_.Domains;

namespace Event_Plus.Domains
{
    [Table("Presenca")]
    public class Presenca
    {
        [Key]
        public Guid Pre{ get; set; }

        [Column(TypeName = "BIT")]
        public bool? Situacao { get; set; }

        public Guid UsuarioID { get; set; }

        [ForeignKey("UsuarioID")]
        public Usuarios? Usuarios { get; set; }

        public Guid EventosID { get; set; }
        [ForeignKey("EventosID")]
       public Evento? Evento { get; set; }
    }
}
