namespace WaveCenterModels
{
    public partial class PedidoReparacaoEstados
    {
        public int Id { get; set; }
        public string Estado { get; set; } = "";
        public PedidoReparacao PedidoReparacao { get; set; }
        public int IdPedidoReparacao { get; set; }
        public DateTime Data { get; set; }
    }
}
