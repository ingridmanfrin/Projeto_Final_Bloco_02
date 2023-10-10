using FluentValidation;
using projeto_final_bloco_02.Model;

namespace projeto_final_bloco_02.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                   .NotEmpty()
                   .MinimumLength(2)
                   .MaximumLength(255);

            RuleFor(p => p.Descricao)
                    .NotEmpty()
                    .MinimumLength(5)
                    .MaximumLength(1000);
            
            RuleFor(p => p.Marca)
                   .NotEmpty()
                   .MinimumLength(2)
                   .MaximumLength(255);

            RuleFor(p => p.Fabricante)
                   .NotEmpty()
                   .MinimumLength(2)
                   .MaximumLength(255);

            RuleFor(p => p.DataValidade)
                  .NotEmpty();

            RuleFor(p => p.Preco)
                   .NotEmpty();

        }
    }
}
