using System.Collections.Generic;
using FluentValidation;
using ProjBiblio.Application.DTOs;

namespace ProjBiblio.Application.InputModels
{
    public class GeneroInputModel
    {
        public int Id { get; set; }

        public string Descricao { get; set; }
    }

    public class GeneroInputModelValidator : AbstractValidator<GeneroInputModel>
    {
        public GeneroInputModelValidator()
        {
            RuleFor(x => x.Descricao).NotEmpty().WithMessage("O Descricao é obrigatório.")
                            .Length(0, 100).WithMessage("O Descricao não pode exceder 100 caracteres.");
        }
    }
}