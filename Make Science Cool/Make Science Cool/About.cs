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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();

            text.Append("Make Science Cool! was developed by:\n\r\n\r");
            text.Append("Federico Navarrete (El Salvador)\n\r");
            text.Append("Houda Chakkour	(Morocco)\n\r");
            text.Append("Enrique Hernández (Nicaragua)\n\r");
            text.Append("Justyna Kałużka (Poland)\n\r");
            text.Append("Michał Szydłowski (Poland)\n\r\n\r");
            text.Append("And was supervised by:\n\r");
            text.Append("Krzysztof Grudzień (Poland)\n\r\n\r");
            text.Append("The main purpose of this project is to help children around the world to understand science in an innovative way using cartoons and animations.\n\r\n\r");
            text.Append("© All Rights Reserved 2015.");

            label2.Text = text.ToString();
        }
    }
}
