namespace WaveCenterModels
{
    public partial class Grupo
    {
        public int Id { get; set; }
        public CategoriaExperiencia CategoriaExperiencia { get; set; }
        public int IdCategoria { get; set; }
        public string Designacao { get; set; } = string.Empty;
    }
}
