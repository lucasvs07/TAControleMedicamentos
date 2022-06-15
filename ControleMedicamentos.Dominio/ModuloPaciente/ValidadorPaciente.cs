using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.Dominio.ModuloPaciente
{
    public class ValidadorPaciente : AbstractValidator<Paciente>
    {
        public ValidadorPaciente()
        {
            RuleFor(x => x.Nome)
                                .NotNull().WithMessage("Preencha o campo nome.")
                                .NotEmpty().WithMessage("Preencha o campo nome.");

            RuleFor(x => x.CartaoSUS)
                                .NotNull().WithMessage("Preencha o número do cartão SUS.")
                                .NotEmpty().WithMessage("Preencha o número do cartão SUS.")
                                .MinimumLength(15).WithMessage("Cartão SUS deve ter 15 números.")
                                .MaximumLength(15).WithMessage("Cartão SUS deve ter 15 números.");
        }

    }
}
