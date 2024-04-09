namespace WaveCenterModels
{
    public partial class GaleriaExperiencias
    {
        public Experiencia Experiencia { get; set; }
        public int IdExperiencia { get; set; }
        public Galeria Galeria { get; set; }
        public int IdGaleria { get; set; }
        public string Ordem { get; set; } = string.Empty;
    }
}
