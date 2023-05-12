using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.UaFx.Client;

namespace OPCUA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            string opcUrl=textBox1.Text;
            var tagName = textBox2.Text;
            var client= new OpcClient(opcUrl);  
            client.Connect();
            var deger = client.ReadNode(tagName);
            textBox3.Text=deger.ToString();
            client.Disconnect();}
            catch
            {
                MessageBox.Show("hata oluştu");
            }
            }
    }
}
