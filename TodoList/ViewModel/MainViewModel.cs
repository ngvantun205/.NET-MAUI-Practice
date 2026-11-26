using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TodoList.ViewModel {
    public class MainViewModel : INotifyPropertyChanged {
        string text;
        public string Text {
            get => text;
            set {
                text = value;
                OnPropertyChanged(nameof(text));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name) {
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            } }
    }
}
