using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Main
{
    public partial class Summary : Form
    {
        public NewOrderForm NewOrderFormObj = null;
        private Order orderObject = new Order();

        public Summary()
        {
            InitializeComponent();
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            NewOrderFormObj = new NewOrderForm();
            NewOrderFormObj.NewOrderObject = orderObject; 
            NewOrderFormObj.ShowDialog();
            if (NewOrderFormObj.DialogResult == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                XmlSerializer ser = new XmlSerializer(typeof(Order));
                TextWriter wr = new StringWriter(sb);
                ser.Serialize(wr, orderObject);
                wr.Close();

                Debug.Text = sb.ToString();
            }
        }
    }
}
