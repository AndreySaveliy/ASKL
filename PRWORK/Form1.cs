using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Словарь
{
    public partial class DictionaryForm : Form
    {
        #region Переменные.
        ToolTip toolTip = new ToolTip();

        List<string> textToolTip = new List<string>()
        {
            "Доавить в словарь.", "Просмотр словаря.", "Перевести слово.", "Выбор языка перевода."
        };
        List<string> ruLang = new List<string>();
        List<string> ukrLang = new List<string>();
        #endregion

        #region Инициализация программы.
        public DictionaryForm()
        {
            InitializeComponent();
        }

        private void DictionaryForm_Load(object sender, EventArgs e)
        {
            langComboBox.SelectedIndex = 0;

            ruLang.AddRange(File.ReadAllLines("ru.txt"));
            ukrLang.AddRange(File.ReadAllLines("ukr.txt"));
        }
        #endregion

        #region Отображаем всплывающую подсказку.
        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Active = true;

            if (sender == AddButton)
            {
                toolTip.Show(textToolTip[0], AddButton);

                return;
            }

            if (sender == viewDictionaryButton)
            {
                toolTip.Show(textToolTip[1], viewDictionaryButton);

                return;
            }

            if (sender == translateButton)
            {
                toolTip.Show(textToolTip[2], translateButton);

                return;
            }
        }

        private void MouseLeave_Button(object sender, EventArgs e)
        {
            toolTip.Active = false;
        }

        private void langComboBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Active = true;

            toolTip.Show(textToolTip[3], langComboBox);
        }

        private void langComboBox_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Active = false;
        }
        #endregion

        #region Добавляем слово в словарь.
        private void AddButton_Click(object sender, EventArgs e)
        {
            NewWord newWord = new NewWord();
            if (newWord.AddWord() == DialogResult.OK & newWord.wordTextBox.Text != "" & newWord.translateTextBox.Text != "")
            {
                ruLang.Add(newWord.wordTextBox.Text);
                ukrLang.Add(newWord.translateTextBox.Text);

                File.WriteAllLines("ru.txt", ruLang);
                File.WriteAllLines("ukr.txt", ukrLang);
            }
        }
        #endregion

        #region Отображаем словарь.
        private void viewDictionaryButton_Click(object sender, EventArgs e)
        {
            ViewDictionary viewDictionary = new ViewDictionary();
        }
        #endregion

        #region Переводим слово.
        private void translateButton_Click(object sender, EventArgs e)
        {
            translateTextBox.Text = null;

            Translate tanslate = new Translate(wordTextBox.Text, translateTextBox, langComboBox.SelectedIndex);
        }
        #endregion
    }
}
