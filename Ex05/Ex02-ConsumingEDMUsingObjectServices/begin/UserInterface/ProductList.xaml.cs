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
    using System.IO;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Navigation;
    using AdventureWorksLibrary;
    using UserInterface.Gateways;

    public partial class ProductList
    {
        private ProductGateway gateway = new ProductGateway();

        public ProductList()
        {
            this.InitializeComponent();

            this.Loaded += this.Window_Loaded;

            this.deleteButton.Click += this.DeleteButton_Click;
            this.newButton.Click += this.NewButton_Click;
            this.productsListView.MouseDoubleClick += this.ProductsListView_MouseDoubleClick;
            this.searchButton.Click += this.SearchButton_Click;
        }

        private void BindCategories()
        {
            categoryComboBox.ItemsSource = this.gateway.GetCategories();
            categoryComboBox.SelectedIndex = 0;
        }

        private void BindModels()
        {
            modelComboBox.ItemsSource = this.gateway.GetModels();
            modelComboBox.SelectedIndex = 0;
        }

        private void BindProducts()
        {
            if (categoryComboBox.SelectedIndex > -1)
            {
                productsListView.ItemsSource = this.gateway.GetProducts(
                    nameTextBox.Text, 
                    categoryComboBox.SelectedItem as Category,
                    modelComboBox.SelectedItem as Model);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.BindCategories();
            this.BindModels();
        }

        private void ProductsListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var product = productsListView.SelectedItem as Product;
            var window = new ProductView();
            window.Closed += this.Window_Closed;
            window.UpdateProduct(product);
            window.Show();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            this.BindProducts();
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new ProductView();
            window.Closed += this.Window_Closed;
            window.Show();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var product = productsListView.SelectedItem as Product;

            if (product != null)
            {
                this.gateway.DeleteProduct(product);
                this.BindProducts();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            var product = productsListView.SelectedItem as Product;

            if (product != null)
            {
                this.gateway.RefreshProduct(product);
                this.BindProducts();
            }

            this.BindProducts();
        }
    }
}