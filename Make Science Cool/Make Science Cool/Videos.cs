using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Science_Cool
{
    public partial class Videos : Form
    {
        public string Option { get; set; }
        public Videos()
        {
            InitializeComponent();
        }

        private void Videos_Load(object sender, EventArgs e)
        {
            string URL = "Videos\\";
            switch (Option)
            {
                case "Computer Anatomy":
                    axWindowsMediaPlayer1.URL = URL + "eWorld1.mp4";
                    break;
                case "Nervous System":
                    axWindowsMediaPlayer1.URL = URL + "eWorld2.mp4";
                    break;
                case "Electronic Parts":
                    axWindowsMediaPlayer1.URL = URL + "eWorld3.mp4";
                    break;
                default:
                    axWindowsMediaPlayer1.URL = URL + "eWorld1.mp4";
                    break;
            }
        }
    }
}
