using System.ComponentModel.DataAnnotations;

namespace TimeMVC.ViewModels
{
    public class TimeViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Informe o Time")]
        [StringLength(60, MinimumLength = 2)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Ano de Criação")]
        [Range(4, 4)]
        public int Fundado { get; set; }

        [Required]
        [Display(Name = "Informe o Principal Rival")]
        [StringLength(60, MinimumLength = 2)]
        public string Rival { get; set; }

        [Required]
        [Display(Name = "Quantidade de Titulos")]
        [Range(0, 4)]
        public int Titulos { get; set; }
    }
}


