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
    public partial class FormSign : Form
    {
        private Form1 MainForm = null;
        public FormSign(Form form)
        {
            MainForm = form as Form1;
            InitializeComponent();
        }

        #region Vars

        string _path = Path.GetPathRoot(Environment.SystemDirectory);
        string[] ProfileDirs;
        Profile[] Profiles;

        #endregion

        #region TopPanel Properties

        bool isTopPanelDragged = false;
        Point offset;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (double _dbl = 1.0; _dbl >= .7; _dbl -= 0.00003)
                {
                    this.Opacity = _dbl;
                }
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isTopPanelDragged = false;
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            for (double _dbl = this.Opacity; _dbl <= 1.0; _dbl += 0.00001)
            {
                this.Opacity = _dbl;
            }
            isTopPanelDragged = false;
            if (this.Location.X < 5)
            {
                this.Location = new Point(5, this.Location.Y);
            }
            if (this.Location.Y < 5)
            {
                this.Location = new Point(this.Location.X, 5);
            }
            if (this.Location.X > SystemInformation.VirtualScreen.Width - this.Width)
            {
                this.Location = new Point(SystemInformation.VirtualScreen.Width - this.Width, this.Location.Y);
            }
            if (this.Location.Y > SystemInformation.VirtualScreen.Height - this.Height)
            {
                this.Location = new Point(this.Location.X, SystemInformation.VirtualScreen.Height - this.Height);
            }
            //MessageBox.Show(Convert.ToString(SystemInformation.VirtualScreen.Width));
        }

        #endregion

        #region ButtonSign(In, Up)_Clicks
        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            PanelSignIn.Location = new Point(0, 76);
            PanelSignUp.Location = new Point(390, 76);
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            PanelSignIn.Location = new Point(390, 76);
            PanelSignUp.Location = new Point(0, 76);
        }

        #endregion

        #region Label ans Text properties

        private void LabelUse2_MouseHover(object sender, EventArgs e)
        {
            LabelUse2.ForeColor = Color.Red;
        }

        private void LabelUse2_MouseLeave(object sender, EventArgs e)
        {
            LabelUse2.ForeColor = Color.DimGray;
        }

        private void LabelUse1_MouseHover(object sender, EventArgs e)
        {
            LabelUse1.ForeColor = Color.Red;
        }

        private void LabelUse1_MouseLeave(object sender, EventArgs e)
        {
            LabelUse1.ForeColor = Color.DimGray;
        }


        private void LabelUse1_MouseClick(object sender, MouseEventArgs e)
        {
            if (LabelUse1.Text == "Use ID")
            {
                LabelLogin.Text = "ID";
                LabelUse1.Text = "Use Handle";
                LabelUse2.Text = "Use Email";
            }
            else if (LabelUse1.Text == "Use Handle")
            {
                LabelLogin.Text = "Handle";
                LabelUse1.Text = "Use ID";
                LabelUse2.Text = "Use Email";
            }
            else if (LabelUse1.Text == "Use Email")
            {
                LabelLogin.Text = "Email";
                LabelUse1.Text = "Use ID";
                LabelUse2.Text = "Use Handle";
            }
            TextLogin.Text = "";
            TextPassword.Text = "";
        }

        private void LabelUse2_MouseClick(object sender, MouseEventArgs e)
        {
            if (LabelUse2.Text == "Use ID")
            {
                LabelLogin.Text = "ID";
                LabelUse1.Text = "Use Handle";
                LabelUse2.Text = "Use Email";
            }
            else if (LabelUse2.Text == "Use Handle")
            {
                LabelLogin.Text = "Handle";
                LabelUse1.Text = "Use ID";
                LabelUse2.Text = "Use Email";
            }
            else if (LabelUse2.Text == "Use Email")
            {
                LabelLogin.Text = "Email";
                LabelUse1.Text = "Use ID";
                LabelUse2.Text = "Use Handle";
            }
            TextLogin.Text = "";
            TextPassword.Text = "";
        }



        private void TextLogin_TextChanged(object sender, EventArgs e)
        {
            LabelInvalid1.Text = "";
        }

        private void TextPassword_TextChanged(object sender, EventArgs e)
        {
            LabelInvalid2.Text = "";
        }

        #endregion

        private void FormSign_Load(object sender, EventArgs e)
        {
            _path = _path + "Users\\" + Environment.UserName + "\\AppData\\Roaming\\ProjectMoonData";
            if (!Directory.Exists(_path))
            {
                DirectoryInfo dir = Directory.CreateDirectory(_path);
            }
            ProfileDirs = Directory.GetDirectories(_path);
            Profiles = new Profile[ProfileDirs.Length];
            for (int i = 0; i < ProfileDirs.Length; i++)
            {
                Profiles[i] = new Profile();
                Profiles[i].GetDocument(ProfileDirs[i] + "\\Profile.pro");
            }
        }

        #region My custom functions

        private bool CheckFields()
        {
            bool Checked = true, bl = true;

            //Handle
            for (int i = 0; i < Profiles.Length; i++)
            {
                if (TextHandle.Text.ToString() == Profiles[i].Handle)
                {
                    Checked = false;
                    bl = false;
                }
            }
            if (bl)
            {
                if (TextHandle.Text.ToString() == "")
                {
                    LabelInvalidHandle.Text = "Field should not be empty!";
                    Checked = false;
                }
                else
                {
                    LabelInvalidHandle.Text = "";
                }
            }
            else
            {
                LabelInvalidHandle.Text = "This handle is currently in use";
            }
            //Name
            bl = true;
            if (TextName.Text.ToString() == "")
            {
                Checked = false;
                bl = false;
                LabelInvalidName.Text = "Field should not be empty!";
            }
            foreach (char ch in TextName.Text.ToString())
            {
                if (!((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || ch == ' '))
                {
                    LabelInvalidName.Text = "Invalid name, only characters \'a\' to \'z\'";
                    Checked = false;
                    bl = false;
                }
            }
            if(bl)
            {
                LabelInvalidName.Text = "";
            }

            //Surname
            bl = true;
            if (TextSurname.Text.ToString() == "")
            {
                Checked = false;
                bl = false;
                LabelInvalidSurname.Text = "Field should not be empty!";
            }
            foreach (char ch in TextSurname.Text.ToString())
            {
                if (!((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || ch == ' '))
                {
                    LabelInvalidSurname.Text = "Invalid surname, only characters \'a\' to \'z\'";
                    Checked = false;
                    bl = false;
                }
            }
            if (bl)
            {
                LabelInvalidSurname.Text = "";
            }

            //Email
            bl = true;
            int counter = 0;
            foreach (char ch in TextEmail.Text.ToString())
            {
                if (ch == '@')
                    counter++;
            }

            if (counter != 1)
            {
                Checked = false;
                bl = false;
            }
            for (int i = 0; i < TextEmail.Text.ToString().IndexOf('@'); i++)
            {
                char ch = TextEmail.Text.ToString()[i];
                if (!((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || ch == '.' || (ch >= '0' && ch <= '9')))
                {
                    Checked = false;
                    bl = false;
                }
            }
            counter = 0;
            for(int i=TextEmail.Text.ToString().IndexOf('@')+1; i<TextEmail.Text.Length; i++)
            {
                char ch = TextEmail.Text.ToString()[i];
                if(ch == '.')
                    counter++;
            }
            if(counter == 1)
            {
                for (int i = TextEmail.Text.ToString().IndexOf('@') + 1; i < TextEmail.Text.Length; i++ )
                {
                    char ch = TextEmail.Text.ToString()[i];
                    if (!((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || ch == '.'))
                    {
                        Checked = false;
                        bl = false;
                    }
                }
            }
            else
            {
                Checked = false;
                bl = false;
            }
            if (bl)
            {
                bool bol = true;
                for (int i = 0; i < Profiles.Length; i++)
                {
                    if (TextEmail.Text.ToString() == Profiles[i].Mail_adress)
                    {
                        Checked = false;
                        bol = false;
                    }
                }
                if(bol)
                    LabelInvalidEmail.Text = "";
                else
                    LabelInvalidEmail.Text = "This Email is currently in use";
            }
            else
            {
                LabelInvalidEmail.Text = "Field should contain valid email!";
            }

            //Password1
            if (TextPassword1.Text.ToString() == "")
            {
                LabelInvalidPassword1.Text = "Field should not be empty!";
                Checked = false;
            }
            else
            {
                LabelInvalidPassword1.Text = "";
            }

            //Password2
            if (TextPassword2.Text.ToString() == "")
            {
                LabelInvalidPassword2.Text = "Field should not be empty!";
                Checked = false;
            }
            else if (TextPassword1.Text.ToString() != TextPassword2.Text.ToString())
            {
                LabelInvalidPassword2.Text = "Confirmation mismatched";
                Checked = false;
            }
            else if (TextPassword1.Text.ToString() == TextPassword2.Text.ToString())
            {
                LabelInvalidPassword2.Text = "";
            }

            return Checked;
        }

        private void CloseForm()
        {
            this.Hide();
            this.MainForm.Show();
            for (double _dbl = .0; _dbl <= 1.0; _dbl += .000008)
            {
                this.MainForm.Opacity = _dbl;
            }
            this.Close();
        }

        #endregion

        #region Register and Login

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                Profile NewProfile = new Profile();
                NewProfile.Handle = TextHandle.Text.ToString();
                NewProfile.Mail_adress= TextEmail.Text.ToString();
                NewProfile.Name = TextName.Text.ToString();
                NewProfile.Surname = TextSurname.Text.ToString();
                NewProfile.Password = TextPassword1.Text.ToString();

                string str;
                if (Profiles.Length == 0)
                    str = "0";
                else
                {
                        str = Profiles.Last().ID;
                        str = str.Remove(0, 1);
                        str = Convert.ToString(Convert.ToInt32(str) + 1);
                }                

                NewProfile.ID = '#' + str;
                string new_path = _path + "\\Profile" + Convert.ToString(Profiles.Length + 1);
                if (!Directory.Exists(new_path))
                {
                    DirectoryInfo dir = Directory.CreateDirectory(new_path);
                }

                try
                {
                    NewProfile.SetDocument(_path + "\\Profile" + Convert.ToString(Profiles.Length + 1) + "\\Profile.pro");
                }
                catch
                {
                    MessageBox.Show("Problem with SetDocument(" + _path + "\\Profile" + Convert.ToString(Profiles.Length + 1) + "\\Profile.pro" + ")");
                }

                MessageBox.Show("Your ID: " + NewProfile.ID + "\nWelcome " + NewProfile.Handle);
                //MessageBox.Show(_path + "Profile" + Convert.ToString(Profiles.Length));
                this.MainForm.ChangeCurrentProfile(_path + "\\Profile" + Convert.ToString(Profiles.Length + 1));
                this.CloseForm();
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < Profiles.Length; i++)
            {
                if (LabelLogin.Text == "Handle")
                {
                    if (Profiles[i].Handle == TextLogin.Text.ToString())
                    {
                        index = i;
                    }
                }
                else if (LabelLogin.Text == "ID")
                {
                    if (Profiles[i].ID == TextLogin.Text.ToString())
                    {
                        index = i;
                    }
                }
                else if (LabelLogin.Text == "Email")
                {
                    if (Profiles[i].Mail_adress == TextLogin.Text.ToString())
                    {
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                LabelInvalid1.Text = "Invalid Handle/Id/Email";
            }
            else if (Profiles[index].Password == TextPassword.Text.ToString())
            {
                MessageBox.Show("Welcome " + Profiles[index].Handle + "!");
                /*if (!File.Exists("F:\\ICO\\Current.cpro"))
                {
                    File.Create("F:\\ICO\\Current.cpro");
                }*/
                //Profiles[index].SetDocument("G:\\ICO\\Current.cpro");
                this.MainForm.ChangeCurrentProfile(ProfileDirs[index]);
                this.CloseForm();
            }
            else
            {
                LabelInvalid2.Text = "Invalid Password";
            }
        }

        #endregion

        #region Enter clicked functions

        private void TextPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ButtonLogin_Click(new object(), new EventArgs());
                e.Handled = true;
            }
        }

        private void TextLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ButtonLogin_Click(new object(), new EventArgs());
                e.Handled = true;
            }
        }

        private void TextEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ButtonRegister_Click(new object(), new EventArgs());
                e.Handled = true;
            }
        }

        private void TextHandle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ButtonRegister_Click(new object(), new EventArgs());
                e.Handled = true;
            }
        }

        private void TextName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ButtonRegister_Click(new object(), new EventArgs());
                e.Handled = true;
            }
        }

        private void TextPassword1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ButtonRegister_Click(new object(), new EventArgs());
                e.Handled = true;
            }
        }

        private void TextPassword2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ButtonRegister_Click(new object(), new EventArgs());
                e.Handled = true;
            }
        }

        private void TextSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ButtonRegister_Click(new object(), new EventArgs());
                e.Handled = true;
            }
        }
        #endregion
    }
}
