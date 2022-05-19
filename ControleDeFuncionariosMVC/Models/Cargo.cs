namespace ControleDeFuncionariosMVC.Models
{
    public class Cargo
    {
      
        public int CargoId { get; set; }
     
        public string CargoNome { get; set; }

        public bool Situacao { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }

    }
}
