using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project_Moon
{
    public partial class ChangeProfile : Form
    {
        private Form1 MainForm = null;
        public ChangeProfile(Form form)
        {
            MainForm = form as Form1;
            InitializeComponent();
        }


        string _path = Path.GetPathRoot(Environment.SystemDirectory);


        string[] ProfileDirs;
        Profile[] Profiles;



        private void LabelForgotPassword_MouseHover(object sender, EventArgs e)
        {
            LabelForgotPassword.ForeColor = Color.Red;
        }

        private void LabelForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            LabelForgotPassword.ForeColor = Color.DimGray;
        }

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
                this.MainForm.ChangeCurrentProfile(ProfileDirs[index]);
                TextLogin.Text = "";
                TextPassword.Text = "";
                this.Hide();
            }
            else
            {
                LabelInvalid2.Text = "Invalid Password";
            }
        }


        private void ChangeProfile_Load(object sender, EventArgs e)
        {
            _path = _path + "Users\\" + Environment.UserName + "\\AppData\\Roaming\\ProjectMoonData";

            ProfileDirs = Directory.GetDirectories(_path);
            Profiles = new Profile[ProfileDirs.Length];
            for (int i = 0; i < ProfileDirs.Length; i++)
            {
                Profiles[i] = new Profile();
                Profiles[i].GetDocument(ProfileDirs[i] + "\\Profile.pro");
            }
        }

        //
        //Labels Use1 and Use2
        //

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

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //
        //TopPanel
        //

        bool isTopPanelDragged = false;
        Point offset;


        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Opacity = 0.88;
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
            this.Opacity = 1;
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
        }


    }
}
