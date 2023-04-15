using MVVM_Test_01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Test_01.ViewModel
{
    public class TextViewModel : INotifyPropertyChanged
    {
        private TextModel _inputText;
        private string _outputText;

        public TextModel InputText
        {
            get => _inputText;
            set
            {
                _inputText = value;
                OnPropertyChanged(nameof(InputText));
            }
        }
        private string _OutputText;
        public string OutputText
        {
            get => _OutputText;
            set
            {
                _OutputText = value;
                OnPropertyChanged(nameof(OutputText));
            }
        }

        private string _OutputText2;
        public string OutputText2
        {
            get => _OutputText2;
            set
            {
                _OutputText2 = value;
                OnPropertyChanged(nameof(OutputText2));
            }
        }

        private string _OutputText3;
        public string OutputText3
        {
            get => _OutputText3;
            set
            {
                _OutputText3 = value;
                OnPropertyChanged(nameof(OutputText3));
            }
        }

        private string _OutputText4;
        public string OutputText4
        {
            get => _OutputText4;
            set
            {
                _OutputText4 = value;
                OnPropertyChanged(nameof(OutputText4));
            }
        }

        public TextViewModel()
        {
            InputText = new TextModel();
        }

        public void ConvertToUpper()
        {
            OutputText = InputText.Text.ToUpper();
            OutputText2 = InputText.Text2.ToUpper();
            OutputText3 = InputText.Text3.ToUpper();
            OutputText4 = InputText.Text4.ToUpper();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
