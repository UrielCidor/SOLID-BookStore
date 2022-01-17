using BookLib;
using BookLib.Infra;
using BookStoreUI.Views;
using DbDal;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreUI.ViewModel
{
    public class SearchViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public class SearchState
        {
            public bool InOpenSearch { get; set; }
            public bool InCategorySearch { get; set; }
        }

        private readonly IDataService service;

        public SearchState State { get; set; }

        public SearchViewModel(IDataService service)
        {
            this.service = service;
            State = new SearchState {InOpenSearch=true, InCategorySearch=false };
            FillProductCategories();
        }

        private void FillProductCategories()
        {
            IList<ProductCategory> tmp = service.GetProductCategories();
            ProductCategories = new ObservableCollection<ProductCategory>();
            foreach (var c in tmp)
            {
                ProductCategories.Add(c);
            };
        }

        private ObservableCollection<ProductCategory> _productCategories;
        public ObservableCollection<ProductCategory> ProductCategories
        {
            get
            {
                return _productCategories;
            }
            set
            {
                _productCategories = value;
                NotifyPropertyChanged();
            }
        }
        
        private ProductCategory _selectedProductCategory;
        public ProductCategory SelectedProductCategory
        {
            get
            {
                return _selectedProductCategory;
            }
            set
            {
                _selectedProductCategory = value;
                NotifyPropertyChanged();
                this.State.InOpenSearch = false;
                this.State.InCategorySearch = true;
                FillProductSearchFields();
            }
        }
        
        private void FillProductSearchFields()
        {
            IProduct iProduct = null;
            ProductFactory obj = new ProductFactory();
            iProduct = obj.Create(SelectedProductCategory.Id);

            CategorySearchFields = new ObservableCollection<string>();
            foreach (var f in iProduct.GetSearchFields())
            {
                CategorySearchFields.Add(f);
            }
        }

        private ObservableCollection<string> _categorySearchFields;
        public ObservableCollection<string> CategorySearchFields
        {
            get
            {
                return _categorySearchFields;
            }
            set
            {
                _categorySearchFields = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}

