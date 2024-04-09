namespace WaveCenterModels
{
    public partial class CategoriaEquipamentoExperiencia
    {
        public Experiencia Experiencia { get; set; }
        public int IdExperiencia { get; set; }
        public  CategoriaEquipamento CategoriaEquipamento { get; set; }
        public int IdCategoriaEquipamento { get; set; } 

    }
}
