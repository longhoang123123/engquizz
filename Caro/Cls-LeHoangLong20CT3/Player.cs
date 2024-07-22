using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_LeHoangLong20CT3
{
    public class Player
    {
        private string name;

        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }

        private string mark;

        public string Mark
        { 
            get { return mark; } 
            set {  mark = value; } 
        }

        public Color BackColor { get => backColor; set => backColor = value; }
        public Color ForeColor { get => foreColor; set => foreColor = value; }

        private Color backColor;
        private Color foreColor;

        public Player(string name, string mark, Color backColor, Color foreColor)
        {
            this.Name = name;
            this.Mark = mark;
            this.BackColor = backColor;
            this.ForeColor = foreColor;
        }
    }
}
