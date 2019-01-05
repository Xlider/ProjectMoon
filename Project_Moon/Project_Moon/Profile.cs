using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Project_Moon
{
    class Profile
    {
        private string id = "";
        private string handle = "";
        private string name = "";
        private string surname = "";
        private string mail_adress = "";
        private string password = "";

        public Profile()
        {

        }

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Handle
        {
            get
            {
                return this.handle;
            }
            set
            {
                this.handle = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                this.surname = value;
            }
        }

        public string Mail_adress
        {
            get
            {
                return this.mail_adress;
            }
            set
            {
                this.mail_adress = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
            
        }

        public void GetDocument(string source)
        {
            StreamReader Cin = new StreamReader(source);
            string str = Cin.ReadLine();
            string[] prof = str.Split('|');
            this.id = prof[0];
            this.handle = prof[1];
            this.name = prof[2];
            this.surname = prof[3];
            this.mail_adress = prof[4];
            this.password = prof[5];
            Cin.Close();
        }

        public void SetDocument(string source)
        {
            StreamWriter Cout = new StreamWriter(source);
            Cout.Write(this.id + '|' + this.handle + '|' + this.name + '|' + this.surname + '|' + this.mail_adress + '|' + this.password);
            Cout.Close();
        }
    }
}
