using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Project_Moon
{
    public class MainPanel : System.Windows.Forms.Panel
    {
        GroupBox StartGroupBox = new GroupBox();
        GroupBox RecentGroupBox = new GroupBox();
        GroupBox HelpGroupBox = new GroupBox();
        GroupBox NewsGroupBox = new GroupBox();

        private void InitializeStartGroupBox()
        {
            StartGroupBox.Location = new Point(15, 15);
            StartGroupBox.Size = new Size(160,100);
            StartGroupBox.Text = "Start";
            StartGroupBox.ForeColor = Color.White;

        }

        private void InitializeRecentGroupBox()
        {
            RecentGroupBox.Location = new Point(15, 130);
            RecentGroupBox.Size = new Size(160, 100);
            RecentGroupBox.Text = "Recent";
            RecentGroupBox.ForeColor = Color.White;

        }

        private void InitializeHelpGroupBox()
        {
            HelpGroupBox.Location = new Point(15, 245);
            HelpGroupBox.Size = new Size(160, 100);
            HelpGroupBox.Text = "Help";
            HelpGroupBox.ForeColor = Color.White;

        }

        private void InitializeNewsGroupBox()
        {
            NewsGroupBox.Location = new Point(200, 15);
            NewsGroupBox.Size = new Size(415, 330);
            NewsGroupBox.Text = "News";
            NewsGroupBox.ForeColor = Color.White;

        }

        public MainPanel()
        {
            InitializeStartGroupBox();
            InitializeRecentGroupBox();
            InitializeHelpGroupBox();
            InitializeNewsGroupBox();

        }

    }
}
