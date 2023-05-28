using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Password_Generation
{
    public partial class MainWindow : INotifyPropertyChanged
    {
        private int _selectedEcryptMethod;

        private readonly string _russianAplhabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private readonly string _englishAplhabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string _numbersAplhabet = "0123456789";
        private readonly string _symbolsAplhabet = "@#$%*?";

        private string _inputText;
        private string _outputText;
        private string _passwordLength;
        private string _numberOfPasswords;
        private bool[] _cbChecked = new bool[6];

        public string InputText
        {
            get => _inputText;
            set
            {
                _inputText = value;
                OnPropertyChanged();
            }
        }

        public string OutputText
        {
            get => _outputText;
            set
            {
                _outputText = value;
                OnPropertyChanged();
            }
        }

        public string PasswordLength
        {
            get => _passwordLength;
            set
            {
                _passwordLength = value;
                OnPropertyChanged();
            }
        }

        public string NumberOfPasswords
        {
            get => _numberOfPasswords;
            set
            {
                _numberOfPasswords = value;
                OnPropertyChanged();
            }
        }

        public bool[] CbChecked
        {
            get => _cbChecked;
            set
            {
                _cbChecked = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            PasswordLength = "1";
            NumberOfPasswords = "1";
            DataContext = this;
        }

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "BtnEncrypt":
                    EncryptOfMethod(_selectedEcryptMethod);
                    break;
                case "BtnGeneratePassword":
                    GeneratePassword(Convert.ToInt32(PasswordLength), Convert.ToInt32(NumberOfPasswords), GetAplhabetForGeneratePassword(CbChecked));
                    break;
            }
        }

        private void RbChecked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "RbAtbash":
                    _selectedEcryptMethod = 1;
                    break;
                case "RbCesar":
                    _selectedEcryptMethod = 2;
                    break;
                case "RbVigener":
                    _selectedEcryptMethod = 3;
                    break;
            }
        }

        private void GeneratePassword(int passwordLenght, int numberOfPassword, string alphabet)
        {
            if (alphabet.Equals(String.Empty))
            {
                MessageBox.Show("Выберите алфавит для генерации!");
                return;
            }
            OutputText = null;
            Random rnd = new Random();
            for (int i = 0; i < numberOfPassword; i++)
            {
                for (int j = 0; j < passwordLenght; j++)
                {
                    OutputText += alphabet[rnd.Next(0, alphabet.Length - 1)];
                }

                OutputText += "\n";
            }
        }

        private string GetAplhabetForGeneratePassword(bool[] cbChecked)
        {
            var alphabet = string.Empty;
            for (var i = 0; i < cbChecked.Length; i++)
                if (cbChecked[i].Equals(true))
                    switch (i)
                    {
                        case 0:
                            alphabet += _numbersAplhabet;
                            break;
                        case 1:
                            alphabet += _englishAplhabet;
                            break;
                        case 2:
                            alphabet += _russianAplhabet;
                            break;
                        case 3:
                            alphabet += _symbolsAplhabet;
                            break;
                        case 4:
                            alphabet += _englishAplhabet.ToLower();
                            break;
                        case 5:
                            alphabet += _russianAplhabet.ToLower();
                            break;
                    }

            return alphabet;
        }

        private void EncryptOfMethod(int a)
        {
            switch (a)
            {
                case 0:
                    MessageBox.Show("Выберите метод шифрования");
                    break;
                case 1:
                    string outAlphabet;
                    OutputText = string.Empty;
                    InputText = InputText.ToUpper();
                    for (var i = 0; i < InputText.Length; i++)
                    {
                        if (_russianAplhabet.Contains(InputText[i]))
                        {
                            outAlphabet = new string(_russianAplhabet.Reverse().ToArray());
                            OutputText += outAlphabet[_russianAplhabet.IndexOf(InputText[i])].ToString();
                        }

                        if (_englishAplhabet.Contains(InputText[i]))
                        {
                            outAlphabet = new string(_englishAplhabet.Reverse().ToArray());
                            OutputText += outAlphabet[_englishAplhabet.IndexOf(InputText[i])].ToString();
                        }

                        if (_numbersAplhabet.Contains(InputText[i]))
                        {
                            outAlphabet = new string(_numbersAplhabet.Reverse().ToArray());
                            OutputText += outAlphabet[_numbersAplhabet.IndexOf(InputText[i])].ToString();
                        }
                    }

                    break;
                case 2:
                    MessageBox.Show("Цезарь");
                    break;
                case 3:
                    MessageBox.Show("Виженер");
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
        }
    }
}