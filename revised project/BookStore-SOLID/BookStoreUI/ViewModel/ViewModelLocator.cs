using CommonServiceLocator;
using DbDal;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreUI.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IDataService, DataService>();

            SimpleIoc.Default.Register<SearchViewModel>();
            SimpleIoc.Default.Register<SearchResultViewModel>();
        }

        public SearchViewModel SearchPanel =>
            ServiceLocator.Current.GetInstance<SearchViewModel>();
        public SearchResultViewModel SearchResultPanel =>
            ServiceLocator.Current.GetInstance<SearchResultViewModel>();
    }
}
