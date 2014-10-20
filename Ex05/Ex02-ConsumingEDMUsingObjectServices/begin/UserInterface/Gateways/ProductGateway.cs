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
        public ProductGateway()
        {
        }

        public IList<Product> GetProducts(string productName, Category category, Model model)
        {
            return null;
        }

        public void RefreshProduct(Product product)
        {
        }

        public IList<Category> GetCategories()
        {
            return null;
        }

        public IList<Model> GetModels()
        {
            return null;
        }

        public void DeleteProduct(Product product)
        {
        }

        public void UpdateProduct()
        {
        }

        public void AddProduct(Product product)
        {
        }
    }
}