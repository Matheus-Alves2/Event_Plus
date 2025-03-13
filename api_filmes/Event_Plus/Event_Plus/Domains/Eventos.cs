using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Event_Plus.Domains;

namespace EventPlus_.Domains
{
    [Table("Evento")]
    public class Evento
    {
        [Key]
        public Guid EventoID { get; set; }

        [Column (TypeName = "Date")]
        [Required(ErrorMessage = "A data do evento e obrigatorio")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nomeento é obrigatório!")]
        public string?  NomeEvento { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descricao do Evento e obrigatorio")]
        public string? Descricao { get; set; }


        [Required(ErrorMessage = "O local do evento é obrigatório!")]
        [Column(TypeName = "VARCHAR(150)")]
        public string? Localizacao { get; set; }

        public Guid IdTipoEventos { get; set; }
        [ForeignKey("IdTipoEventos")]
        public TipoEvento? TipoEvento { get; set; }
        public Guid IdInstituicoes { get; set; }

        [ForeignKey("IdInstituicoes")]
        public Instituicoes? Instituicoes { get; set;}
    }
}