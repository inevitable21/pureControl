using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pureControlClient
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void BTNSendData_Click(object sender, EventArgs e)
        {
            /*Sending data and check if it got by server if it does, open the popup*/
            var formPopup = new popupForm(TBDataToSend.Text);
            formPopup.Show(this);
        }
    }
}
