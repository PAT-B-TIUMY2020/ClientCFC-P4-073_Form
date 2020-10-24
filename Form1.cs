using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_073;

namespace ClientCFC_P4_073_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BasicHttpBinding bind = new BasicHttpBinding();
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:2001");
            IMatematika obj = objChannel.CreateChannel();

            double hasilTambah = obj.Tambah(1, 2);

            label6.Text = hasilTambah.ToString();

            double hasilKurang = obj.Kurang(3, 2);

            label7.Text = hasilKurang.ToString();

            double hasilKali = obj.Kali(2, 2);

            label8.Text = hasilKali.ToString();

            double hasilBagi = obj.Bagi(2, 2);

            label9.Text = hasilBagi.ToString();

            Koordinat objk = new Koordinat();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
