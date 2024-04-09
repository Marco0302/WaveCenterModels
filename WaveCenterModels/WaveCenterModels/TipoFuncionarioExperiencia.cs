namespace WaveCenterModels
{
    public partial class TipoFuncionarioExperiencia
    {
        public Experiencia Experiencia { get; set; }
        public int IdExperiencia { get; set; }
        public TipoFuncionario TipoFuncionario { get; set; }
        public int IdTipoFuncionario { get; set; }
    }
}
