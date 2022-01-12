using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookLib;

namespace BookStoreGUI
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        public SupplyManager supplyManager = new SupplyManager();
        List<AbstractItem> searchList;
        List<CheckBox> bookGaneresbtnList;
        List<CheckBox> journalTypesList;
        List<CheckBox> journalTopicsList;


        public SearchPage()
        {
            InitializeComponent();
            myListView.ItemsSource = supplyManager.GetSupply();
            searchList = new List<AbstractItem>();
            searchList = supplyManager.GetSupply();
            bookGaneresbtnList = new List<CheckBox>() { HorrorCheck, AdvCheck, HistoryCheck, BioCheck, DetectiveCheck, SciFiCheck, ClasCheck, NovalCheck};
            journalTypesList = new List<CheckBox>() { newsJTypeCheck, magJTypeCheck, perioJTypeCheck, comJTypeCheck };
            journalTopicsList = new List<CheckBox>() { fashJTopicCheck, ecoJTopicCheck, sciJTopicCheck, enteJTopicCheck, newsJTopicCheck, kidsJTopicCheck, proJTopicChheck };
        }

        private void AddToSupplyBtnClick(object sender, RoutedEventArgs e)
        {
            if (BookTypeBtn.IsChecked == false && JournalTypeBtn.IsChecked == false) MessageBox.Show("Please check item type");

            if (BookTypeBtn.IsChecked == true)
            {

                Book.Ganres[] _ganres = new Book.Ganres[8];
                string _ganresListView = "";

                if (!double.TryParse(PriceTxtbx.Text, out double _price) || !int.TryParse(QuantTxtbx.Text, out int _quant)) MessageBox.Show("Enter a correct value for price and/ or Quantity");

                //if (!int.TryParse(QuantTxtbx.Text, out int _quant)) MessageBox.Show("Enter a correct value for quantity");

                else if (BookTitleTxtbx.Text == "") MessageBox.Show("Please enter book title");

                else if (AuthorTxtbx.Text == "") MessageBox.Show("Please enter Author name");

                else if (!int.TryParse(ISBNTxtbx.Text, out int _isbn)) MessageBox.Show("Enter a correct value for ISBN");

                else if (PublisherTxtbx.Text == "") MessageBox.Show("Please enter publisher name");

                else if (!int.TryParse(EditionTxtbx.Text, out int _edition)) MessageBox.Show("Enter a correct value for edition number");

                else if (publisherDateTxtbx == null) MessageBox.Show("Please enter book publishing date");

                else if (HorrorCheck.IsChecked == false && AdvCheck.IsChecked == false && HistoryCheck.IsChecked == false && BioCheck.IsChecked == false && DetectiveCheck.IsChecked == false && SciFiCheck.IsChecked == false && ClasCheck.IsChecked == false && NovalCheck.IsChecked == false) MessageBox.Show("You must pick at list one Ganere for the book");
                else
                {
                    if (HorrorCheck.IsChecked == true)
                    {
                        _ganres[0] = Book.Ganres.Horror;
                        _ganresListView += "Horor \n";
                    }
                    if (AdvCheck.IsChecked == true)
                    {
                        _ganres[1] = Book.Ganres.Advanture;
                        _ganresListView += "Advanture \n";
                    }
                    if (HistoryCheck.IsChecked == true)
                    {
                        _ganres[2] = Book.Ganres.Historical;
                        _ganresListView += "Historical \n";
                    }
                    if (BioCheck.IsChecked == true)
                    {
                        _ganres[3] = Book.Ganres.Biography;
                        _ganresListView += "Biography \n";
                    }
                    if (DetectiveCheck.IsChecked == true)
                    {
                        _ganres[4] = Book.Ganres.Detactive;
                        _ganresListView += "Detactive \n";
                    }
                    if (SciFiCheck.IsChecked == true)
                    {
                        _ganres[5] = Book.Ganres.Science_Fiction;
                        _ganresListView += "SciFi \n";
                    }
                    if (ClasCheck.IsChecked == true)
                    {
                        _ganres[6] = Book.Ganres.Classic;
                        _ganresListView += "Classic \n";
                    }
                    if (NovalCheck.IsChecked == true)
                    {
                        _ganres[7] = Book.Ganres.Noval;
                        _ganresListView += "Noval \n";
                    }
                    supplyManager.AddToSupply(new Book(_price, _quant, BookTitleTxtbx.Text, AuthorTxtbx.Text, PublisherTxtbx.Text, _isbn, _edition, publisherDateTxtbx.DisplayDate, _ganres, _ganresListView));
                    supplyManager.InitSupplyList();
                    myListView.ItemsSource = supplyManager.GetSupply();
                    searchList = supplyManager.GetSupply();
                }
            }

            if (JournalTypeBtn.IsChecked == true)
            {
                Journal.JournalType[] _types = new Journal.JournalType[4];
                string journalTypeListView = "";

                Journal.JournalTopic[] _topics = new Journal.JournalTopic[7];
                string journalTopicsListView = "";

                if (!double.TryParse(PriceTxtbx.Text, out double _Jprice) || !int.TryParse(QuantTxtbx.Text, out int _Jquant)) MessageBox.Show("Enter a correct value for journal price ans/ or quantity");

                //if (!int.TryParse(QuantTxtbx.Text, out int _Jquant)) MessageBox.Show("Enter a correct value for quantity");

                else if (jNametxtbx.Text == "") MessageBox.Show("Please enter journal name");

                else if (jPublisherTxtbx.Text == "") MessageBox.Show("Please enter journal publisher name");

                else if (jPDateTxtbx == null) MessageBox.Show("Please enter journal publishing date");

                else if (newsJTypeCheck.IsChecked == false && magJTypeCheck.IsChecked == false && perioJTypeCheck.IsChecked == false && comJTypeCheck.IsChecked == false) MessageBox.Show("You must pick at list one type for the journal");

                else if (fashJTopicCheck.IsChecked == false && ecoJTopicCheck.IsChecked == false && sciJTopicCheck.IsChecked == false && enteJTopicCheck.IsChecked == false && newsJTopicCheck.IsChecked == false && kidsJTopicCheck.IsChecked == false && proJTopicChheck.IsChecked == false) MessageBox.Show("You must pick at list one topic for the journal");

                else
                {
                    if (newsJTypeCheck.IsChecked == true)
                    {
                        _types[0] = Journal.JournalType.NewsPaper;
                        journalTypeListView += "Newspaper \n";
                    }
                    if (magJTypeCheck.IsChecked == true)
                    {
                        _types[1] = Journal.JournalType.Magazine;
                        journalTypeListView += "Magazine \n";
                    }
                    if (perioJTypeCheck.IsChecked == true)
                    {
                        _types[2] = Journal.JournalType.Periodical;
                        journalTypeListView += "Periodical \n";
                    }
                    if (comJTypeCheck.IsChecked == true)
                    {
                        _types[3] = Journal.JournalType.Comics;
                        journalTypeListView += "Comics \n ";

                    }
                    if (fashJTopicCheck.IsChecked == true)
                    {
                        _topics[0] = Journal.JournalTopic.Fashion;
                        journalTopicsListView += "Fashion \n";
                    }
                    if (ecoJTopicCheck.IsChecked == true)
                    {
                        _topics[1] = Journal.JournalTopic.Economics;
                        journalTopicsListView += "Economics \n";
                    }
                    if (sciJTopicCheck.IsChecked == true)
                    {
                        _topics[2] = Journal.JournalTopic.Sceince;
                        journalTopicsListView += "Science \n";
                    }
                    if (enteJTopicCheck.IsChecked == true)
                    {
                        _topics[3] = Journal.JournalTopic.Enterteinment;
                        journalTopicsListView += "Enterteinment \n ";
                    }
                    if (newsJTopicCheck.IsChecked == true)
                    {
                        _topics[4] = Journal.JournalTopic.News;
                        journalTopicsListView += "News \n ";
                    }
                    if (kidsJTopicCheck.IsChecked == true)
                    {
                        _topics[4] = Journal.JournalTopic.Kids;
                        journalTopicsListView += "Kids \n ";
                    }
                    if (proJTopicChheck.IsChecked == true)
                    {
                        _topics[4] = Journal.JournalTopic.Proffessional;
                        journalTopicsListView += "Proffesional \n ";
                    }
                    supplyManager.AddToSupply(new Journal(_Jprice, _Jquant, jNametxtbx.Text, jPublisherTxtbx.Text, jPDateTxtbx.DisplayDate, _types, _topics, journalTypeListView, journalTopicsListView));
                    supplyManager.InitSupplyList();
                    myListView.ItemsSource = supplyManager.GetSupply();
                    searchList = supplyManager.GetSupply();
                }
            }
        }

        private void removeItemFromSupply(object sender, RoutedEventArgs e)
        {
            AbstractItem tmp = myListView.SelectedItem as AbstractItem;
            supplyManager.RemoveFromSupply(tmp);
            supplyManager.InitSupplyList();
            myListView.ItemsSource = supplyManager.GetSupply();
            searchList = supplyManager.GetSupply();
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            searchList = supplyManager.GetSupply();
            myListView.ItemsSource = supplyManager.GetSupply();
        }

        private void searchType_Click(object sender, RoutedEventArgs e)
        {
            List<AbstractItem> typeSearchList = new List<AbstractItem>();

            if (BookTypeBtn.IsChecked == true)
            {
                foreach (var item in searchList)
                {
                    if(item.ItemType == AbstractItem.Itemtype.Book)
                    typeSearchList.Add(item);
                }
            }
            else
            {
                foreach (var item in searchList)
                {
                    if(item.ItemType == AbstractItem.Itemtype.Journal)
                    typeSearchList.Add(item);
                }
            }
            searchList = typeSearchList;
            myListView.ItemsSource = searchList;
        }

        private void titleSearch_Click(object sender, RoutedEventArgs e)
        {
            if (BookTitleTxtbx.Text == "") MessageBox.Show("Enter title to preform search");
            else
            {
                List<AbstractItem> titleSearchList = new List<AbstractItem>();
                foreach (var item in searchList)
                {
                    if (item.ItemType == AbstractItem.Itemtype.Book)
                    {
                        Book tmp = item as Book;
                        if (tmp.Title == BookTitleTxtbx.Text)
                            titleSearchList.Add(tmp);
                    }
                }
                searchList = titleSearchList;
                myListView.ItemsSource = searchList;
            }
        }

        private void authorSearch_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorTxtbx.Text == "") MessageBox.Show("Enter Author name to preform search");
            else { 
                List<AbstractItem> authorSearchList = new List<AbstractItem>();
                foreach (var item in searchList)
                {
                    if (item.ItemType == AbstractItem.Itemtype.Book)
                    {
                        Book tmp = item as Book;
                        if (tmp.Author == AuthorTxtbx.Text)
                            authorSearchList.Add(tmp);
                    }
                }
                searchList = authorSearchList;
                myListView.ItemsSource = searchList;
            }
        }

        private void ISBNSearch_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(ISBNTxtbx.Text, out int isbn)) MessageBox.Show("Enter Author name to preform search");
            else
            {
                List<AbstractItem> isbnSearchList = new List<AbstractItem>();
                foreach (var item in searchList)
                {
                    if (item.ItemType == AbstractItem.Itemtype.Book)
                    {
                        Book tmp = item as Book;
                        if (tmp.ISBN == isbn)
                            isbnSearchList.Add(tmp);
                    }
                }
                searchList = isbnSearchList;
                myListView.ItemsSource = searchList;
            }
        }
        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            BookTypeBtn.IsChecked = false;
            JournalTypeBtn.IsChecked = false;
            book_border.IsEnabled = false;
            journal_border.IsEnabled = false;
            BookTitleTxtbx.Clear();
            AuthorTxtbx.Clear();
            ISBNTxtbx.Clear();
            PublisherTxtbx.Clear();
            EditionTxtbx.Clear();
            publisherDateTxtbx.DisplayDate = DateTime.Now;
            foreach (var checkbox in bookGaneresbtnList)
            {
                checkbox.IsChecked = false;
            }
            jNametxtbx.Clear();
            jPublisherTxtbx.Clear();
            foreach (var checkbox in journalTypesList)
            {
                checkbox.IsChecked = false;
            }
            foreach (var checkbox in journalTopicsList)
            {
                checkbox.IsChecked = false;
            }
            PriceTxtbx.Clear();
            QuantTxtbx.Clear();
        }

        private void myListView_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AbstractItem tmp = myListView.SelectedItem as AbstractItem;
            if (tmp != null)
            {
                if (tmp.ItemType == AbstractItem.Itemtype.Book)
                {
                    Book tmpBook = tmp as Book;
                    BookTypeBtn.IsChecked = true;
                    BookTitleTxtbx.Text = tmpBook.Title;

                }
                if (tmp.ItemType == AbstractItem.Itemtype.Journal)
                {
                    Journal tmpJournal = tmp as Journal;
                    JournalTypeBtn.IsChecked = true;
                    jNametxtbx.Text = tmpJournal.JournalName;
                }
            }
        }
        private void BookTypeBtn_Checked(object sender, RoutedEventArgs e)
        {
            journal_border.IsEnabled = false;
            journal_border.BorderBrush = Brushes.Gray;
            book_border.BorderBrush = Brushes.OrangeRed;
            book_border.IsEnabled = true;

        }

        private void JournalTypeBtn_Checked(object sender, RoutedEventArgs e)
        {
            book_border.IsEnabled = false;
            book_border.BorderBrush = Brushes.Gray;
            journal_border.BorderBrush = Brushes.OrangeRed;
            journal_border.IsEnabled = true;

        }

        
    }
}
