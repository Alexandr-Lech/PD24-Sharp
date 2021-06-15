using System;
using System.Drawing;
using System.Xml.Serialization;

namespace Lab8_Sem2
{
    [Serializable]
    public class Save
    {
        public bool[] CheckBox;

        [XmlElement]
        public Point Position { get; set; }

        [XmlElement]
        public Size Size { get; set; }

        public string TextBox { get; set; }

        public Save()
        {
        }

        public Save(Point p, Size s, string textbox, bool[] check)
        {
            this.Position = p;
            this.Size = s;
            this.TextBox = textbox;
            this.CheckBox = check;
        }
    }
}