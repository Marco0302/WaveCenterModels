namespace WaveCenterModels
{
    public partial class FuncionarioMarcacao
    {
        public Marcacao Marcacao { get; set; }  
        public int IdMarcacao { get; set; }
        public Funcionario Funcionario { get; set; }
        public int IdFuncionario { get; set; }
    }
}
