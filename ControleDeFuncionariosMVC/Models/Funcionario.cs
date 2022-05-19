namespace ControleDeFuncionariosMVC.Models
{
    public class Funcionario
    {
        
        public int FuncionarioId { get; set; }
     
        public string Nome { get; set; }        
        
        public bool Situacao { get; set; }
        
        public DateTime Data_Admissao { get; set; }
       
        public decimal Salario { get; set; }

        public Cargo Cargo { get; set; }    

        public int CargoId { get; set; }    
    }
}
