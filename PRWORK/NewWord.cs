using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Словарь
{
    public partial class NewWord
    {
        public TextBox wordTextBox;
        public TextBox translateTextBox;

        public DialogResult AddWord()
        {
            
            Form wordForm = new Form();
            wordForm.StartPosition = FormStartPosition.CenterScreen;
            wordForm.FormBorderStyle = FormBorderStyle.Fixed3D;
            wordForm.Size = new Size(250, 180);
            wordForm.MinimizeBox = false;
            wordForm.MaximizeBox = false;
            wordForm.Text = "Новое слово";
            

            Label wordLabel = new Label();
            wordLabel.Location = new Point(10, 10);
            wordLabel.AutoSize = false;
            wordLabel.Size = new Size(230, 25);
            wordLabel.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            wordLabel.Text = "Слово: ";

            Label translateLabel = new Label();
            translateLabel.Location = new Point(10, 60);
            translateLabel.AutoSize = false;
            translateLabel.Size = new Size(230, 25);
            translateLabel.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            translateLabel.Text = "Перевод: ";
            

            
            wordTextBox = new TextBox();
            wordTextBox.Location = new Point(10, 35);
            wordTextBox.Size = new Size(215, 25);
            wordTextBox.Text = null;

            translateTextBox = new TextBox();
            translateTextBox.Location = new Point(10, 85);
            translateTextBox.Size = new Size(215, 25);
            translateTextBox.Text = null;
            

            
            Button okButton = new Button();
            okButton.Location = new Point(80, 115);
            okButton.Size = new Size(70, 25);
            okButton.DialogResult = DialogResult.OK;
            okButton.Text = "OK";

            Button cancelButton = new Button();
            cancelButton.Location = new Point(155, 115);
            cancelButton.Size = new Size(70, 25);
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Text = "Cancel";
            
            
            wordForm.Controls.Add(wordLabel);
            wordForm.Controls.Add(translateLabel);
            wordForm.Controls.Add(wordTextBox);
            wordForm.Controls.Add(translateTextBox);
            wordForm.Controls.Add(okButton);
            wordForm.Controls.Add(cancelButton);
            wordLabel.Show();
            translateLabel.Show();
            wordTextBox.Show();
            translateTextBox.Show();
            okButton.Show();
            cancelButton.Show();
            wordForm.ShowDialog();
            

            return wordForm.DialogResult;
        }
    }
}
