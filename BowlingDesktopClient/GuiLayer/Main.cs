using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowlingDesktopClient.GuiLayer
{
    public partial class Main : Form
    {
        LaneMenu lMenu = new LaneMenu();
        BookingMenu bMenu = new BookingMenu();

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
           bMenu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lMenu.ShowDialog();
        }
    }
}
