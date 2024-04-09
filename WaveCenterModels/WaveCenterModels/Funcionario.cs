namespace WaveCenterModels
{
    public partial class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Apelido { get; set; } = string.Empty;
        public DateTime? DataNascimento { get; set; }
        public string Morada { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int NIF { get; set; }
        public bool Verificado { get; set; }
        public TipoFuncionario TipoFuncionario { get; set; }
        public int IdTipoFuncionario { get; set; }
        public Galeria Galeria { get; set; }
        public int IdGaleria { get; set; }
    }
}
