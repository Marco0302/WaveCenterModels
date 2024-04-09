namespace WaveCenterModels
{
    public partial class PedidoReparacao
    {
        public int Id { get; set; }
        public Equipamento Equipamento { get; set; }
        public int IdEquipamento { get; set; }
        public Funcionario Funcionario { get; set; }
        public int IdFuncionario { get; set; }
        public string Notas { get; set; } = "";
        public DateTime DataPedido { get; set; }
        public DateTime DataConclusao { get; set; }
        public string Estado { get; set; } = "";

    }
}
