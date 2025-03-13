using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("Instituicoes")]
[Index(nameof(CNPJ), IsUnique = true)]
public class Instituicoes
{
    [Key]

    public Guid InstituicaoID { get; set; }

    [Column(TypeName = "VARCHAR(14)")]
    [Required(ErrorMessage = "O CNPJ é obrigatório!")]
    [StringLength(14)]

    public string? CNPJ { get; set; }

    [Column(TypeName = "VARCHAR(100)")]
    [Required(ErrorMessage = "O endereço é obrigatório!")]

    public string? Endereco { get; set; }

    [Column(TypeName = "VARCHAR(20)")]
    [Required(ErrorMessage = "O nome da fantasia é obrigatória!")]

    public string? NomeFantasia { get; set; }
}