﻿namespace WaveCenterModels
{
    public partial class Registo
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime? DataCriacao { get; set; }
    }
}
