using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace databaseConnector1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=3.227.166.251;Database=U053QS;Uid=U053QS;Pwd=53688416942;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }
    }
}
