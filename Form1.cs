using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DeepL;

namespace Tłumacz
{
    public partial class Form1 : Form
    {
        private Translator translator;
        private string apiKey = "69a32141-271d-48c8-b5fd-87e3c6cd8f0f:fx";
        private Dictionary<string, string> languages;

        public Form1()
        {
            InitializeComponent();
            InitializeTranslator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InitializeTranslator()
        {
            translator = new Translator(apiKey);

            languages = new Dictionary<string, string>
            {
                { "Polski", LanguageCode.Polish },
                { "Angielski", LanguageCode.English },
                { "Niemiecki", LanguageCode.German },
                { "Francuski", LanguageCode.French },
                { "Hiszpański", LanguageCode.Spanish },
                { "Włoski", LanguageCode.Italian },
                { "Japoński", LanguageCode.Japanese },
                { "Arabski", LanguageCode.Arabic },
                { "Chiński", LanguageCode.Chinese },
                { "Koreański", LanguageCode.Korean },
                { "Rosyjski", LanguageCode.Russian },
                { "Ukraiński", LanguageCode.Ukrainian },
                { "Fiński", LanguageCode.Finnish },
                { "Czeski", LanguageCode.Czech },
                { "Słowacki", LanguageCode.Slovak },
                { "Węgierski", LanguageCode.Hungarian },
                { "Portugalski", LanguageCode.Portuguese },
                { "Holenderski", LanguageCode.Dutch },
                { "Grecki", LanguageCode.Greek }
            };

            cbSource.Items.Clear();
            cbTarget.Items.Clear();

            foreach (var langName in languages.Keys)
            {
                cbSource.Items.Add(langName);
                cbTarget.Items.Add(langName);
            }

            if (cbSource.Items.Count > 0) cbSource.SelectedIndex = 1;
            if (cbTarget.Items.Count > 0) cbTarget.SelectedIndex = 4;
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            string inputText = rtbInput.Text;

            if (string.IsNullOrWhiteSpace(inputText) || cbSource.SelectedItem == null || cbTarget.SelectedItem == null)
            {
                MessageBox.Show("Wpisz tekst i wybierz oba języki przed tłumaczeniem.");
                return;
            }

            string sourceLangCode = languages[cbSource.SelectedItem.ToString()];
            string targetLangCode = languages[cbTarget.SelectedItem.ToString()];

            Cursor previousCursor = this.Cursor;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var result = await translator.TranslateTextAsync(
                    inputText,
                    sourceLangCode,
                    targetLangCode
                );

                rtbOutput.Text = result.Text;
            }
            catch (DeepLException dex)
            {
                MessageBox.Show($"Błąd API DeepL: {dex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił nieoczekiwany błąd: {ex.Message}");
            }
            finally
            {
                this.Cursor = previousCursor;
            }
        }
    }
}