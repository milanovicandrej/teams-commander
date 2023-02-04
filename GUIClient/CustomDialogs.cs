using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIClient
{
    public class CustomDialogs
    {
        public static DialogResult InputDialog(ref string input,string prompt, string title = "Title", int width = 300, int height = 100)
        {
            Size size = new Size(width, height);
            
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = title;

            Label label = new Label();
            label.Text = prompt;
            label.Location = new Point(5, 5);
            label.Width = size.Width - 10;
            inputBox.Controls.Add(label);

            TextBox textBox = new TextBox();
            textBox.Size = new Size(size.Width - 10, 20);
            textBox.Location = new Point(5, label.Location.Y + 25);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, size.Height - 30);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, size.Height - 30);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;

            return result;
        }
    }
}
