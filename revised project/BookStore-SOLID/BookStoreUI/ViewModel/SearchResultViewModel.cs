using BookLib;
using BookLib.Infra;
using DbDal;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreUI.ViewModel
{
    public class SearchResultViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private readonly IDataService service;

        public SearchResultViewModel(IDataService service)
        {
            this.service = service;
            GetSearchResult();
        }

        private void GetSearchResult()
        {
            IList<ProductBase> products = service.GetProducts();
            SearchResults = new();
            foreach (var p in products)
            {
                SearchResults.Add(p);
            }
        }

        private ObservableCollection<ProductBase> _searchResults;
        public ObservableCollection<ProductBase> SearchResults
        {
            get
            {
                return _searchResults;
            }
            set
            {
                _searchResults = value;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged()
        {
            //throw new NotImplementedException();
        }
    }
}
