using System;
using System.Collections.Generic;
using System.Globalization;
using commercetools.Sdk.Client;
using commercetools.Sdk.Domain;
using commercetools.Sdk.Domain.ProductDiscounts;
using commercetools.Sdk.HttpApi.IntegrationTests;

namespace commercetools.Sdk.HttpApi.IntegrationTests.ProductDiscounts
{
    public class ProductDiscountsFixture: ClientFixture, IDisposable
    {
        private readonly ProductTypeFixture productTypeFixture;
        private readonly ProductFixture productFixture;
        public List<ProductDiscount> ProductDiscountsToDelete { get; }
        
        public ProductDiscountsFixture()
        {
            this.ProductDiscountsToDelete = new List<ProductDiscount>();
            this.productTypeFixture = new ProductTypeFixture();
            this.productFixture = new ProductFixture();
        }
        public void Dispose()
        {
            IClient commerceToolsClient = this.GetService<IClient>();
            this.ProductDiscountsToDelete.Reverse();
            foreach (ProductDiscount productDiscount in this.ProductDiscountsToDelete)
            {
                ProductDiscount deletedType = commerceToolsClient
                    .ExecuteAsync(new DeleteByIdCommand<ProductDiscount>(new Guid(productDiscount.Id), productDiscount.Version)).Result;
            }
            this.productTypeFixture.Dispose();
        }
        public ProductDiscountDraft GetProductDiscountDraft()
        {
            var random = new Random();
            ProductType productType = this.productTypeFixture.CreateProductType();
            this.productTypeFixture.ProductTypesToDelete.Add(productType);
            string predicate = $"productType.id = \"{productType.Id}\"";
            var sortOrder = random.NextDouble(0.1, 0.9);
            
            ProductDiscountDraft productDiscountDraft = new ProductDiscountDraft();
            productDiscountDraft.Name = new LocalizedString() {{"en", this.RandomString(4)}};
            productDiscountDraft.Value = GetProductDiscountValue();
            productDiscountDraft.Predicate = predicate;
            productDiscountDraft.SortOrder = string.Format(CultureInfo.InvariantCulture, "{0:0.00}", sortOrder);
            productDiscountDraft.ValidFrom = DateTime.Today.AddMonths(random.Next(-5,-1));
            productDiscountDraft.ValidUntil = DateTime.Today.AddMonths(random.Next(1,5));
            
            return productDiscountDraft;
        }
        public ProductDiscount CreateProductDiscount()
        {
            return this.CreateProductDiscount(this.GetProductDiscountDraft());
        }

        public ProductDiscount CreateProductDiscount(ProductDiscountDraft productDiscountDraft)
        {
            IClient commerceToolsClient = this.GetService<IClient>();
            ProductDiscount productDiscount = commerceToolsClient.ExecuteAsync(new CreateCommand<ProductDiscount>(productDiscountDraft)).Result;
            return productDiscount;
        }

        /// <summary>
        /// Return Relative Product Discount
        /// </summary>
        /// <returns></returns>
        public ProductDiscountValue GetProductDiscountValue()
        {
            var random = new Random();
            var productDiscountValue = new RelativeProductDiscountValue()
            {
                Permyriad = random.Next(1,10)
            };
            return productDiscountValue;
        }
    }
}