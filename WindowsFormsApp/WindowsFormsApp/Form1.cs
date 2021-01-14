using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //button1.Click += delegate (object sender, EventArgs e)
            //  {
            //      MessageBox.Show("Salam");
            //  };
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Text =(await Sum()).ToString();
        }

        private async Task<long> Sum()
        {
            long result = 0;
            var task=Task.Run(() =>
            {
                for (long i = 0; i < 1000000000; i++)
                {
                    result += i;
                }
            });
            await task;
            return result;
        }
    }
}
