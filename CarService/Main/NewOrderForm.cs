using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class NewOrderForm : Form
    {
        public Order NewOrderObject = null;

        public NewOrderForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            NewOrderObject.ClientName = "zura";
            N
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}
