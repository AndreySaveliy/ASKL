using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Словарь
{
    public partial class ViewDictionary
    {
        string[] ruText = new string[File.ReadAllLines("ru.txt").Length];
        string[] ukrText = new string[File.ReadAllLines("ukr.txt").Length];

        public ViewDictionary()
        {
            
            Form viewDictionaryForm = new Form();
            viewDictionaryForm.StartPosition = FormStartPosition.CenterScreen;
            viewDictionaryForm.FormBorderStyle = FormBorderStyle.Fixed3D;
            viewDictionaryForm.Size = new Size(250, 185);
            viewDictionaryForm.MinimizeBox = false;
            viewDictionaryForm.MaximizeBox = false;
            viewDictionaryForm.Text = "Просмотр переводчика";
            #endregion

            
            RichTextBox richText = new RichTextBox();
            richText.Location = new Point(10, 10);
            richText.Size = new Size(215, 105);
            richText.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richText.ReadOnly = true;
            for (int i = 0; i < ruText.Length; i++)
            {
                ruText[i] = File.ReadAllLines("ru.txt")[i];
                ukrText[i] = File.ReadAllLines("ukr.txt")[i];
                richText.AppendText(ruText[i] + " - " + ukrText[i] + "\n");
            }
            viewDictionaryForm.Controls.Add(richText);
            
            
            Button closeButton = new Button();
            closeButton.Location = new Point(150, 120);
            closeButton.Size = new Size(75, 25);
            closeButton.Text = "Закрыть";
            closeButton.DialogResult = DialogResult.OK;
            viewDictionaryForm.Controls.Add(closeButton);
            

            viewDictionaryForm.ShowDialog();
        }
    }
}
