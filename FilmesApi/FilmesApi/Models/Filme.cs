using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int? Id { get; set; }

        [Required(ErrorMessage = "O campo TItulo é obrigatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Diretor é obrigatorio")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "O campo Genero é obrigatorio")]
        public string Genero { get; set; }
        public int Duracao { get; set; }
        


    }
}
