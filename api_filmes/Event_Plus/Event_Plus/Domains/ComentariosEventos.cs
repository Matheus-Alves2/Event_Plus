using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventPlus_.Domains;

namespace Event_plus.Domains
{
    [Table("ComentariosEventos")]
    public class ComentariosEventos
    {
        [Key]

        public Guid ComentariosEventosID { get; set; }

        [Column(TypeName = "BIT")]

        public bool? Exibe { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Decrição do evento obrigatória")]

        public string? Decricao { get; set; }

        [Required(ErrorMessage = "O usuário é obrigatório!")]
        public Guid UsuarioID { get; set; }

        [ForeignKey("UsuarioID")]

        public Usuarios? Usuarios { get; set; }

        [Required(ErrorMessage = "O evento é obrigatório!")]
        public Guid EventosID { get; set; }

        [ForeignKey("EventosID")]

        public Evento? Evento { get; set; }
    }

    
}