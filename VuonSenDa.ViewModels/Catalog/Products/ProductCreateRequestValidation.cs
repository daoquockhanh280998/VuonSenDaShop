using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using VuonSenDa.ViewModels.Catalog.Products;

namespace VuonSenDa.ViewModels.System.Users
{
    public class ProductCreateRequestValidation : AbstractValidator<ProductCreateRequest>
    {
        public ProductCreateRequestValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is Not Empty");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Price is Not Empty");
            RuleFor(x => x.OriginalPrice).NotEmpty().WithMessage("OriginalPrice is Not Empty");
            RuleFor(x => x.Details).NotEmpty().WithMessage("Details is Not Empty")
                .MaximumLength(4000).WithMessage("Details must not exceed 4000 characters");
            RuleFor(x => x.Dercription).NotEmpty().WithMessage("Dercription is Not Empty")
                .MaximumLength(4000).WithMessage("Dercription must not exceed 4000 characters");
            RuleFor(x => x.SeoDescription).NotEmpty().WithMessage("SeoDescription is Not Empty")
              .MaximumLength(500).WithMessage("SeoDescription must not exceed 500 characters");
            RuleFor(x => x.SeoTitle).NotEmpty().WithMessage("SeoTitle is Not Empty")
                .MaximumLength(500).WithMessage("SeoTitle must not exceed 500 characters");
            RuleFor(x => x.SeoAlias).NotEmpty().WithMessage("SeoAlias is Not Empty")
               .MaximumLength(500).WithMessage("SeoAlias must not exceed 500 characters");
            RuleFor(x => x.ProductCategoryId).NotEmpty().WithMessage("ProductCategoryId is Not Empty");
        }
    }
}