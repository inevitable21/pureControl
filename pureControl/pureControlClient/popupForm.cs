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
    public partial class popupForm : Form
    {
        public popupForm()
        {
            InitializeComponent();
        }

        public popupForm(string sendedData)
        {
            InitializeComponent();
            DataSent.Text = sendedData;
        }
    }
}
