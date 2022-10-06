﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class ReadFilmeDto
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
        public DateTime HoraDaConsulta { get; set; }
    }
}
