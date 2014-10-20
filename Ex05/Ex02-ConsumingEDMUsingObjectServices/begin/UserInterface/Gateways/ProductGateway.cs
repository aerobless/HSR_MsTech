//===============================================================================
// Microsoft Developer & Platform Evangelism
// .NET Framework 3.5 SP1 - Training Kit
//===============================================================================
// Copyright  Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================
namespace UserInterface.Gateways
{
    using System;
    using System.Collections.Generic;
    using System.Data.Objects;
    using System.Linq;
    using System.Text;
    using AdventureWorksLibrary;

    public class ProductGateway : IProductGateway
    {
        private AdventureWorksLTEntities context;

        public ProductGateway()
        {
            context = new AdventureWorksLTEntities();
        }

        public IList<Product> GetProducts(string productName, Category category, Model model)
        {
            var products = from p in context.Products
                           where p.ProductCategory.CategoryID == category.CategoryID &&
                           p.ProductModel.ModelID == model.ModelID
                           select p;
            if (!string.IsNullOrEmpty(productName))
            {
                products = products.Where(p => p.Name.Contains(productName));
            }
            return products.ToList();
        }

        public void RefreshProduct(Product product)
        {
            context.Entry(product).Reload();
        }

        public IList<Category> GetCategories()
        {
            var categories = from c in context.Categories
                             where c.ParentCategory.Name != null
                             orderby c.Name
                             select c;
            return categories.ToList();
        }

        public IList<Model> GetModels()
        {
            var models = from m in context.Models
                         orderby m.Name
                         select m;
            return models.ToList();
        }

        public void DeleteProduct(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public void UpdateProduct()
        {
            context.SaveChanges();
        }

        public void AddProduct(Product product)
        {
            product.rowguid = Guid.NewGuid();
            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}