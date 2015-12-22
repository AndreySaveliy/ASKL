using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Словарь
{
    public partial class Translate
    {
        string[] ru = new string[File.ReadAllLines("ru.txt").Length];
        string[] ua = new string[File.ReadAllLines("ukr.txt").Length];

        public Translate(string word, TextBox textBox, int index)
        {
            #region Переводим с русского.
            if (index == 0)
            {
                for (int i = 0; i < ru.Length; i++)
                {
                    ru[i] = File.ReadAllLines("ru.txt")[i];
                    ua[i] = File.ReadAllLines("ukr.txt")[i];

                    if (ru[i].Equals(word, StringComparison.CurrentCultureIgnoreCase))
                    {
                        textBox.Text = ua[i];

                        return;
                    }
                }
            }
            #endregion

            #region Переводим с украинского.
            if (index == 1)
            {
                for (int i = 0; i < ua.Length; i++)
                {
                    ua[i] = File.ReadAllLines("ukr.txt")[i];
                    ru[i] = File.ReadAllLines("ru.txt")[i];

                    if (ua[i].Equals(word, StringComparison.CurrentCultureIgnoreCase))
                    {
                        textBox.Text = ru[i];

                        return;
                    }
                }
            }
            #endregion
        }
    }
}
