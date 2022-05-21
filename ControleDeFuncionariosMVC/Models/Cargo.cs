using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeFuncionariosMVC.Models
{
    public class Cargo
    {
        [Display(Name = "IdCargo")]
        [Column("IdCargo")]
        [Key]
        public int CargoId { get; set; }

        [Required(ErrorMessage = "Digite o cargo")]
        [Display(Name = "Nome do Cargo")]
        [Column("NomeCargo")]
        [StringLength(100)]
        public string NomeCargo { get; set; }

        [Display(Name = "Situação")]
        [Column("Situacao")]
        public bool Situacao { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }

    }
}
