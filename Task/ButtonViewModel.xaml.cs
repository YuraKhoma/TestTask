using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonViewModel : ContentView, INotifyPropertyChanged
    {
        
        readonly IList<ButtonModel> source;

        ObservableCollection<ButtonModel> Buttons { get; set; }

        public ButtonViewModel()
        {
            source = new List<ButtonModel>();

            CreateButtonCollection();
        }

        void CreateButtonCollection()
        {
            source.Add(new ButtonModel
            {
                Number = 1
            });
            source.Add(new ButtonModel
            {
                Number = 2
            });
            source.Add(new ButtonModel
            {
                Number = 3
            });
            source.Add(new ButtonModel
            {
                Number = 4
            });
            source.Add(new ButtonModel
            {
                Number = 5
            });
            source.Add(new ButtonModel
            {
                Number = 6
            });
            source.Add(new ButtonModel
            {
                Number = 7
            });
            source.Add(new ButtonModel
            {
                Number = 8
            });
            source.Add(new ButtonModel
            {
                Number = 9
            });
            source.Add(new ButtonModel
            {
                Number = 10
            });
            Buttons = new ObservableCollection<ButtonModel>(source);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}