using BowlingDesktopClient.ControlLayer;
using BowlingDesktopClient.Models;
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
    public partial class LaneMenu : Form
    {
        readonly LaneControl _laneControl;
        public LaneMenu()
        {
            InitializeComponent();

            _laneControl = new LaneControl();
        }

        private async Task buttonGetLanes_Click(object sender, EventArgs e)
        {
           string processText = "Good or Not";
            List<Lane>? fethcedLanes = await _laneControl.GetAllLanes();
            if (fethcedLanes != null)
            {
                if (fethcedLanes.Count >= 1)
                {
                    processText = "Ok";
                }
                else
                {
                    processText = "No Lanes found";
                }
            }
            else
            {
                processText = "Failure: An error occurred";
            }
            labelProcessSaved.Text = processText;
            listBoxLanes.DataSource = fethcedLanes;
        }
    }
}
