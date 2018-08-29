using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace P1.ViewModels
{
    public class Locker : INotifyPropertyChanged
    {
        public Locker()
        {
            UnlocksCommand = new Command(Unlocks);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public bool Unlocker
        {
            get { return GLock.Unlock; }
            set
            {
                GLock.Unlock = value;
                OnPropertyChanged();
            }
        }

        public Command UnlocksCommand { get; }

        void Unlocks()
        {
            GLock.Unlock = true;
        }
    }
}
