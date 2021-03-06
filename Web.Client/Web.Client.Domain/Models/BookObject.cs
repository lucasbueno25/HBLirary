﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Web.Client.Domain.Models
{
    public class BookObject
    {

        public int IdBook { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Limite máximo atingido")]
        [DisplayName("Nome do Livro")]
        public string BookName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Limite máximo atingido")]
        [DisplayName("Autor")]
        public string BookAuthor { get; set; }

        [MaxLength(20, ErrorMessage = "Limite máximo atingido")]
        [DisplayName("Editora")]
        public string BookPublisher { get; set; }

        [MaxLength(20, ErrorMessage = "Limite máximo atingido")]
        [DisplayName("País")]
        public string BookRegion { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data de lançamento")]
        public DateTime BookReleaseDate { get; set; }
    }
}
