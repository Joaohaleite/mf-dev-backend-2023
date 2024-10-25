using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage ="Obrigatório infiormar descrição!")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório infiormar data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório infiormar Valor!")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório infiormar Km!")]
        public int Km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório infiormar o Veículo!")]
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
