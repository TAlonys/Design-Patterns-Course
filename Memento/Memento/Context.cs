using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public class Context
    {

        TextCareTaker careTake = new TextCareTaker();

        public void Save(RichTextBox richTex)
        {
            careTake.AddMemento(new TextMemento(richTex.Text));
        }

        public void Load(RichTextBox richText)
        {
            TextMemento lastMemento = careTake.GetPreviouse();

            if (lastMemento != null && lastMemento.savedText != null)
                richText.Text = lastMemento.savedText;
        }

        public void Next(RichTextBox richText)
        {
            TextMemento nextMemento = careTake.GetNext();

            if (nextMemento != null && nextMemento.savedText != null)
                richText.Text = nextMemento.savedText;
        }
    }
}
