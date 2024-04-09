namespace WaveCenterModels
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Apelido { get; set; } = string.Empty;
        public DateTime? DataNascimento { get; set; }
        public string Morada { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int NIF { get; set; }
        public Galeria? Galeria { get; set; }
        public int? IdAvatar { get; set; }
        public bool Ativo { get; set; }

        public Cliente()
        {

        }

        public Cliente(int id, string nome, string apelido, DateTime? dataNascimento, string morada, string email, string password, int nif, Galeria galeria, int idAvatar,  bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Apelido = apelido;
            this.DataNascimento = dataNascimento;
            this.Morada = morada;
            this.Email = email;
            this.Password = password;
            this.NIF = nif;
            this.Galeria = galeria;
            this.IdAvatar = idAvatar;
            this.Ativo = ativo;
    }

    }
}
