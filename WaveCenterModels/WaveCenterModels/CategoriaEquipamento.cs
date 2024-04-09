namespace WaveCenterModels
{
    public partial class CategoriaEquipamento
    {
        public int Id { get; set; }
        public string Designacao { get; set; } = string.Empty;
        public Equipamento Equipamento { get; set; }
        public int IdEquipamento { get; set; } 

    }
}
