using Prism.Commands;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using VCFSync.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Xamarin.Essentials;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace VCFSync
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {

        private ContentDialog dialog;

        public MainPage()
        {
            this.InitializeComponent();
            this.ImportDelegateCommand = new DelegateCommand(TestClick);
            this.DataContext = this;
        }

        public DelegateCommand ImportDelegateCommand { get; set; }

        public ObservableCollection<Contact> Contacts { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public bool CanShowProgress { get; set; }

        private async void TestClick()
        {
            try
            {

                this.CanShowProgress = true;
                this.OnPropertyChanged(nameof(CanShowProgress));

                var contacts = await new ContactsService().GetAllContact();
                this.Contacts = new ObservableCollection<Contact>(contacts);
                this.OnPropertyChanged(nameof(this.Contacts));

                this.CanShowProgress = false;
                this.OnPropertyChanged(nameof(CanShowProgress));
            }
            catch (Exception ex)
            {
                this.CanShowProgress = false;
                // Handle exception here.
            }
        }

        public void OnPropertyChanged(string propertyName)
        { 
          if(this.PropertyChanged != null)
          { 
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));;
          }
        }
    }
}
