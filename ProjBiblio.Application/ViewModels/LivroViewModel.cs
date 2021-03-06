using System.Collections.Generic;
using ProjBiblio.Application.DTOs;
using ProjBiblio.Domain.Entities;

namespace ProjBiblio.Application.ViewModels
{
    public class LivroViewModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int? Quantidade { get; set; }

        public string Foto { get; set; }

        public int Ano { get; set; }

        public int Edicao { get; set; }

        public int Paginas { get; set; }

        public string Editora { get; set; }

        public IList<AutorSelectListDto> Autores { get; set; }

        public Genero Genero { get; set; }
    }
}