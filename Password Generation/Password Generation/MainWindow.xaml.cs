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
        private string _stepOfCesar;
        private string _stepOfVizhener;
        private Visibility _stepVisibility;
        private Visibility _vizhenerVisibility;
        private bool[] _cbChecked = new bool[6];

        public string StepOfVizhener
        {
            get => _stepOfVizhener;
            set
            {
                _stepOfVizhener = value;
                OnPropertyChanged("StepOfVizhener");
            }
        }

        public Visibility VizhenerVisibility
        {
            get => _vizhenerVisibility;
            set
            {
                _vizhenerVisibility = value;
                OnPropertyChanged("VizhenerVisibility");
            }
        }

        public Visibility StepVisibility
        {
            get => _stepVisibility;
            set
            {
                _stepVisibility = value;
                OnPropertyChanged("StepVisibility");
            }
        }

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

        public string StepOfCesar
        {
            get => _stepOfCesar;
            set
            {
                _stepOfCesar = value;
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
            StepOfCesar = "1";
            StepVisibility = Visibility.Collapsed;
            VizhenerVisibility = Visibility.Collapsed;
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
                    GeneratePassword(Convert.ToInt32(PasswordLength), Convert.ToInt32(NumberOfPasswords),
                        GetAplhabetForGeneratePassword(CbChecked));
                    break;
            }
            ша
        }

        private void RbChecked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "RbAtbash":
                    _selectedEcryptMethod = 1;
                    StepVisibility = Visibility.Collapsed;
                    VizhenerVisibility = Visibility.Collapsed;
                    break;
                case "RbCesar":
                    _selectedEcryptMethod = 2;
                    StepVisibility = Visibility.Visible;
                    VizhenerVisibility = Visibility.Collapsed;
                    break;
                case "RbVigener":
                    _selectedEcryptMethod = 3;
                    StepVisibility = Visibility.Collapsed;
                    VizhenerVisibility = Visibility.Visible;
                    break;
            }
        }

        private void GeneratePassword(int passwordLenght, int numberOfPassword, string alphabet)
        {
            if (alphabet.Equals(string.Empty))
            {
                MessageBox.Show("Выберите алфавит для генерации!");
                return;
            }

            OutputText = null;
            var rnd = new Random();
            for (var i = 0; i < numberOfPassword; i++)
            {
                for (var j = 0; j < passwordLenght; j++) OutputText += alphabet[rnd.Next(0, alphabet.Length - 1)];

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
            if (InputText == null)
            {
                MessageBox.Show("Введите строку");
                return;
            }

            InputText = InputText.ToUpper();
            OutputText = string.Empty;

            switch (a)
            {
                case 0:
                    MessageBox.Show("Выберите метод шифрования");
                    break;
                case 1:
                    string outAlphabet;
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
                    var step = 0;
                    step = Convert.ToInt32(StepOfCesar) % _russianAplhabet.Length;
                    for (var i = 0; i < InputText.Length; i++)
                    {
                        if (_russianAplhabet.Contains(InputText[i]))
                            OutputText +=
                                _russianAplhabet[
                                        (_russianAplhabet.IndexOf(InputText[i]) + step) % _russianAplhabet.Length]
                                    .ToString();

                        if (_englishAplhabet.Contains(InputText[i]))
                            OutputText +=
                                _englishAplhabet[
                                        (_englishAplhabet.IndexOf(InputText[i]) + step) % _englishAplhabet.Length]
                                    .ToString();

                        if (_numbersAplhabet.Contains(InputText[i]))
                            OutputText +=
                                _numbersAplhabet[
                                        (_numbersAplhabet.IndexOf(InputText[i]) + step) % _numbersAplhabet.Length]
                                    .ToString();
                    }

                    break;
                case 3:
                    int[] stepVizhener = new int[StepOfVizhener.Length];
                    int j = 0;
                    InputText = InputText.Replace(" ", "");
                    for (int i = 0; i < StepOfVizhener.Length; i++)
                    {
                        if (_russianAplhabet.Contains(InputText[i]))
                            stepVizhener[i] = _russianAplhabet.IndexOf(StepOfVizhener[i]);

                        if (_englishAplhabet.Contains(InputText[i]))
                            stepVizhener[i] = _englishAplhabet.IndexOf(StepOfVizhener[i]);

                        if (_numbersAplhabet.Contains(InputText[i]))
                            stepVizhener[i] = _numbersAplhabet.IndexOf(StepOfVizhener[i]);

                    }
                    for (var i = 0; i < InputText.Length; i++)
                    {
                        if (j == stepVizhener.Length)
                        {
                            j = 0;
                        }
                        if (_russianAplhabet.Contains(InputText[i]))
                            OutputText +=
                                _russianAplhabet[
                                    (_russianAplhabet.IndexOf(InputText[i]) + stepVizhener[j]) %
                                    _russianAplhabet.Length].ToString();
                            
                        if (_englishAplhabet.Contains(InputText[i]))
                            OutputText +=
                                _englishAplhabet[
                                    (_englishAplhabet.IndexOf(InputText[i]) + stepVizhener[j]) %
                                    _englishAplhabet.Length].ToString();

                        if (_numbersAplhabet.Contains(InputText[i]))
                            OutputText +=
                                _numbersAplhabet[
                                    (_numbersAplhabet.IndexOf(InputText[i]) + stepVizhener[j]) %
                                    _numbersAplhabet.Length].ToString();
                        j++;
                    }

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