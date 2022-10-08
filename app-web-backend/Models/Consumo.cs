using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required (ErrorMessage ="Obrigatório Informar a Descrição!")]

        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a quilometragem!")]
        public int Km { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        [Required(ErrorMessage = "Obrigatório Informar o Valor!")]
        public decimal Valor { get; set; }

        [Display(Name = "Tipo de Combustível")]
        [Required(ErrorMessage = "Obrigatório Informar o Tipo!")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Tipo de Veículo")]
        [Required(ErrorMessage = "Obrigatório Informar o Veículo!")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }
    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
