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
namespace UserInterface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;
    using AdventureWorksLibrary;
    using UserInterface.Gateways;

    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class ProductView : Window
    {
        private ProductGateway gateway = new ProductGateway();
        private bool formCreateMode = true;

        public ProductView()
        {
            InitializeComponent();
        }

        private bool FormCreateMode
        {
            get
            {
                return this.formCreateMode;
            }

            set
            {
                this.formCreateMode = value;
            }
        }

        private Product _Product { get; set; }

        public void UpdateProduct(Product product)
        {
            this._Product = this.gateway.GetProducts(product.Name, product.ProductCategory, product.ProductModel)[0];
            this.FormCreateMode = false;
            this.Title = "Edit " + this._Product.Name;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.BindCategories();
            this.BindModels();

            if (this.FormCreateMode)
            {
                this._Product = new Product();
                this._Product.ModifiedDate = DateTime.Now;
                this._Product.SellStartDate = DateTime.Now;
            }

            this.BindProduct();
        }

        private void BindProduct()
        {
            txtProductNumber.DataContext = this._Product;
            txtName.DataContext = this._Product;
            txtListPrice.DataContext = this._Product;
            txtColor.DataContext = this._Product;
            categoryComboBox.DataContext = this._Product;
            modelComboBox.DataContext = this._Product;
            txtModifiedDate.DataContext = this._Product;
            txtSellStartDate.DataContext = this._Product;
            txtStandardCost.DataContext = this._Product;
        }

        private void BindCategories()
        {
            this.categoryComboBox.ItemsSource = this.gateway.GetCategories();
            this.categoryComboBox.SelectedIndex = 0;
        }

        private void BindModels()
        {
            this.modelComboBox.ItemsSource = this.gateway.GetModels();
            this.modelComboBox.SelectedIndex = 0;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (this.FormCreateMode)
            {
                this._Product.ProductCategory = (Category)this.categoryComboBox.SelectedItem;
                this._Product.ProductModel = (Model)this.modelComboBox.SelectedItem;
                
                this.gateway.AddProduct(this._Product);
            }
            else 
            {
                this.gateway.UpdateProduct();
            }

            this.Close();
        }
    }
}
