using System;
using System.Linq;
using System.Windows.Forms;

namespace Password_Generation_WinForm
{
    public partial class MainForm : Form
    {
        private readonly string _russianAplhabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private readonly string _englishAplhabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string _numbersAplhabet = "0123456789";
        private readonly string _symbolsAplhabet = "@#$%*?";
        private string InputText;
        private string OutputText;
        private string Alphabet;
        private int SelectedEcryptMethod;


        public MainForm()
        {
            InitializeComponent();
            InputText = string.Empty;
            OutputText = string.Empty;
            Alphabet = string.Empty;
            SelectedEcryptMethod = new int();
        }

        private void BtnClick(object sender, EventArgs e)
        {
            OutputText = string.Empty;
            switch (((Button)sender).Name)
            {
                case "BtnEncrypt":
                    EncryptOfMethod(SelectedEcryptMethod);
                    RtbOutputEncrypted.Text = OutputText;
                    break;
                case "BtnGeneratePassword":
                    GeneratePassword(Convert.ToInt32(TbLenght.Value), Convert.ToInt32(TbNumber.Value),
                        Alphabet);
                    RtbOutputPassword.Text = OutputText;
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

        private void GetAplhabetForGeneratePassword(int cbChecked, string alphabet)
        {
            switch (cbChecked)
            {
                case 0:
                    if (Alphabet.Contains(_numbersAplhabet))
                        Alphabet = Alphabet.Replace(_numbersAplhabet, "");
                    else
                        Alphabet += _numbersAplhabet;
                    break;
                case 1:
                    if (Alphabet.Contains(_englishAplhabet))
                        Alphabet = Alphabet.Replace(_englishAplhabet, "");
                    else
                        Alphabet += _englishAplhabet;
                    break;
                case 2:
                    if (Alphabet.Contains(_russianAplhabet))
                        Alphabet = Alphabet.Replace(_russianAplhabet, "");
                    else
                        Alphabet += _russianAplhabet;
                    break;
                case 3:
                    if (Alphabet.Contains(_symbolsAplhabet))
                        Alphabet = Alphabet.Replace(_symbolsAplhabet, "");
                    else
                        Alphabet += _symbolsAplhabet;
                    break;
                case 4:
                    if (Alphabet.Contains(_englishAplhabet))
                        Alphabet = Alphabet.Replace(_englishAplhabet.ToLower(), "");
                    else
                        Alphabet += _englishAplhabet.ToLower();
                    break;
                case 5:
                    if (Alphabet.Contains(_russianAplhabet))
                        Alphabet = Alphabet.Replace(_russianAplhabet.ToLower(), "");
                    else
                        Alphabet += _russianAplhabet.ToLower();
                    break;
            }
        }

        private void EncryptOfMethod(int a)
        {
            if (TbInputEncrypted.Text.Equals(string.Empty))
            {
                MessageBox.Show("Введите строку");
                return;
            }

            InputText = TbInputEncrypted.Text.ToUpper();

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
                    step = Convert.ToInt32(TbStepOfCesar.Value) % _russianAplhabet.Length;
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
                    var stepVizhener = new int[TbStepOfVizhener.Text.Length];
                    var j = 0;
                    InputText = InputText.Replace(" ", "");
                    for (var i = 0; i < TbStepOfVizhener.Text.Length; i++)
                    {
                        if (_russianAplhabet.Contains(InputText[i]))
                            stepVizhener[i] = _russianAplhabet.IndexOf(TbStepOfVizhener.Text[i]);

                        if (_englishAplhabet.Contains(InputText[i]))
                            stepVizhener[i] = _englishAplhabet.IndexOf(TbStepOfVizhener.Text[i]);

                        if (_numbersAplhabet.Contains(InputText[i]))
                            stepVizhener[i] = _numbersAplhabet.IndexOf(TbStepOfVizhener.Text[i]);
                    }

                    for (var i = 0; i < InputText.Length; i++)
                    {
                        if (j == stepVizhener.Length) j = 0;
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

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (((CheckBox)sender).Name)
            {
                case "CbNumbers":
                    GetAplhabetForGeneratePassword(0, Alphabet);
                    break;
                case "CbUpperCaseEnglish":
                    GetAplhabetForGeneratePassword(1, Alphabet);
                    break;
                case "CbUpperCaseRussian":
                    GetAplhabetForGeneratePassword(2, Alphabet);
                    break;
                case "CbSymbols":
                    GetAplhabetForGeneratePassword(3, Alphabet);
                    break;
                case "CbLowerCaseEnglish":
                    GetAplhabetForGeneratePassword(4, Alphabet);
                    break;
                case "CbLowerCaseRussian":
                    GetAplhabetForGeneratePassword(5, Alphabet);
                    break;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "RbAtbash":
                    SelectedEcryptMethod = 1;
                    GbCesar.Enabled = false;
                    GbVizhener.Enabled = false;
                    break;
                case "RbCesar":
                    SelectedEcryptMethod = 2;
                    GbCesar.Enabled = true;
                    GbVizhener.Enabled = false;
                    break;
                case "RbVigener":
                    SelectedEcryptMethod = 3;
                    GbCesar.Enabled = false;
                    GbVizhener.Enabled = true;
                    break;
            }
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            switch (((NumericUpDown)sender).Name)
            {
                case "NudLenght":
                    TbLenght.Value = Convert.ToInt32(NudLenght.Value);
                    break;
                case "NudNumber":
                    TbNumber.Value = Convert.ToInt32(NudNumber.Value);
                    break;
                case "NudStepOfCesar":
                    TbStepOfCesar.Value = Convert.ToInt32(NudStepOfCesar.Value);
                    break;
            }
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            switch (((TrackBar)sender).Name)
            {
                case "TbLenght":
                    NudLenght.Value = Convert.ToInt32(TbLenght.Value);
                    break;
                case "TbNumber":
                    NudNumber.Value = Convert.ToInt32(TbNumber.Value);
                    break;
                case "TbStepOfCesar":
                    NudStepOfCesar.Value = Convert.ToInt32(TbStepOfCesar.Value);
                    break;
            }
        }
    }
}