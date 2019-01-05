using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using CustomWindowsForm;

namespace Project_Moon
{
    class Arcade
    {
        private enum Element { part = 0, level = 1, problem = 2 };

        private string[] Names= new string[5];
        private string _path = @"D:\FFOutput\My_Files\My_Custom_Project\Project_Moon\Project_Moon\arcade";
        private DirectoryInfo _dir;
        Element CurrentElement = Element.part;
        private Button b1, b2, b3, b4, b5;
        public Arcade(Button b1, Button b2, Button b3, Button b4, Button b5)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.b4 = b4;
            this.b5 = b5;
            //Array.Resize(ref Names, 5);
        }

        public void InitializeComponents()
        {
            int i = 0;
i=0;
            if (CurrentElement == Element.part || CurrentElement == Element.level)
            {
                foreach (var d in Directory.GetDirectories(_path))
                {
                    Names[i] = Path.GetDirectoryName(d);
                    i++;
                }
            }
            else if (CurrentElement == Element.problem)
            {
                foreach (var d in Directory.GetDirectories(_path))
                {
                    Names[i] = Path.GetDirectoryName(d);
                    i++;
                }
            }

            b1.Text = Names[0];
            b2.Text = Names[1];
            b3.Text = Names[2];
            b4.Text = Names[3];
            b5.Text = Names[4];

        }

        public string ButtonClicked(int ind)
        {
            if (this.CurrentElement == Element.part)
            {
                CurrentElement = Element.level;
                this._path = this._path + "\\" + Names[ind];
                this.InitializeComponents();
            }
            else if (CurrentElement == Element.level)
            {
                CurrentElement = Element.problem;
                this._path = this._path + "\\" + Names[ind];
                this.InitializeComponents();
            }
            else
            {
                return _path + Names[ind] + ".html";
            }
            return "NULL";
        }

        public void GoBack()
        {
            if (CurrentElement == Element.problem)
            {
                CurrentElement = Element.level;
                this.InitializeComponents();
            }
            else if (CurrentElement == Element.level)
            {
                CurrentElement = Element.part;
                this.InitializeComponents();
            }
        }

    }
}
