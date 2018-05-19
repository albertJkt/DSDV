using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDV
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
            textBoxRefreshTime.Text = Program._refreshTime + "";
        }

        private void buttonRouterToDelete_Click(object sender, EventArgs e)
        {
            Graph.RemoveRouter(textBoxRouterToDelete.Text).Info(labelInfoLine);
            textBoxRouterToDelete.Text = "";
        }

        private void textBoxRefreshTime_ValueChanged(object sender, EventArgs e)
        {
            Program._refreshTime = Convert.ToInt32(textBoxRefreshTime.Text);
        }

        private void buttonLinkToDelete_Click(object sender, EventArgs e)
        {
            Graph.RemoveLink(textBoxLinkToDeleteA.Text, textBoxLinkToDeleteB.Text).Info(labelInfoLine);
            textBoxLinkToDeleteA.Text = "";
            textBoxLinkToDeleteB.Text = "";
        }

        private void buttonAddRouter_Click(object sender, EventArgs e)
        {
            Graph.AddRouter(new Router(textBoxAddRouter.Text)).Info(labelInfoLine);
            textBoxAddRouter.Text = "";
        }

        private void buttonAddLink_Click(object sender, EventArgs e)
        {
            Graph.AddLink(textBoxAddLinkA.Text, textBoxAddLinkB.Text, Convert.ToInt32(numericUpDownWeight.Text)).Info(labelInfoLine);
            textBoxAddLinkA.Text = "";
            textBoxAddLinkB.Text = "";
            numericUpDownWeight.Text = "0";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            labelInfoLine.Text = "";
            Program._messageAt = Graph.Routers.Find(x => x.Name == textBoxFrom.Text);
            if (Program._messageAt != null)
            {
                Program._messageAt.Message(textBoxTo.Text, labelInfoLine, textBoxMessageAt);
            }
            else
            {
                labelInfoLine.Text = "ERROR";
            }
        }

        private void buttonChange_Click_1(object sender, EventArgs e)
        {
            Graph.ChangeWeight(textBoxAddLinkA.Text, textBoxAddLinkB.Text, Convert.ToInt32(numericUpDownWeight.Text)).Info(labelInfoLine);
            textBoxAddLinkA.Text = "";
            textBoxAddLinkB.Text = "";
            numericUpDownWeight.Text = "0";
        }

        private void PRINT_CheckedChanged(object sender, EventArgs e)
        {
            Graph.print = PRINT.Checked;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(Program._messageAt != null)
            {
                Program._messageAt.Message(textBoxTo.Text, labelInfoLine, textBoxMessageAt);
            }
            else
            {
                labelInfoLine.Text = "ERROR";
            }
        }
    }
}
