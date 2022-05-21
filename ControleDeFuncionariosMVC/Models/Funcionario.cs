using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeFuncionariosMVC.Models
{
    public class Funcionario
    {
        [Key]
        [Display(Name = "FuncionarioId")]
        [Column("FuncionarioId")]
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "Digite o nome do funcionario")]
        [Display(Name = "Nome")]
        [Column("Nome")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Display(Name = "Situação")]
        [Column("Situacao")]
        public bool Situacao { get; set; }

        [Display(Name = "Data da Admissão")]
        [Column("Data_Admissao")]
        public DateTime DataAdmissao { get; set; }

        [Display(Name = "Sálario")]
        [Column("Salario")]
        public decimal Salario { get; set; }

        public Cargo Cargo { get; set; }    

        public int CargoId { get; set; }    
    }
}
