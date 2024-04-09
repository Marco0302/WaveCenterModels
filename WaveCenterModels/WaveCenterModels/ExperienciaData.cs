namespace WaveCenterModels
{
    public partial class ExperienciaData
    {
        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }
        public PrecoExperiencia PrecoExperiencia { get; set; }
        public int IdPrecoExperiencia { get; set; }
    }
}
