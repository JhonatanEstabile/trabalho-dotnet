using System.Collections.Generic;
using FluentValidation;
using ProjBiblio.Application.DTOs;

namespace ProjBiblio.Application.InputModels
{
    public class LivroInputModel
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
    }

    public class LivroInputModelValidator : AbstractValidator<LivroInputModel>
    {
        public LivroInputModelValidator()
        {
            RuleFor(x => x.Titulo).NotEmpty().WithMessage("O Nome é obrigatório.")
                .Length(0, 100).WithMessage("O Nome não pode exceder 100 caracteres.");

            RuleFor(x => x.Quantidade)
                .GreaterThanOrEqualTo(0).WithMessage("A quantidade não pode ter valor negativo.");

            RuleFor(x => x.Foto).Length(0, 300)
                .WithMessage("O Nome não pode exceder 300 caracteres.");     

            RuleFor(x => x.Ano)
                .GreaterThanOrEqualTo(0).WithMessage("Ano não pode ser negativo.");

            RuleFor(x => x.Edicao)
                .GreaterThanOrEqualTo(0).WithMessage("Edicao não pode ser negativo.");

            RuleFor(x => x.Paginas)
                .GreaterThanOrEqualTo(0).WithMessage("Paginas não pode ser negativo.");

            RuleFor(x => x.Editora).NotEmpty().WithMessage("O Editora é obrigatório.")
                .Length(0, 100).WithMessage("O Editora não pode exceder 100 caracteres.");
        }
    }
}