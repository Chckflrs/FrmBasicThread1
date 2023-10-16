using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delThread = new ThreadStart(MyTHreadClass.Thread1);
            Thread threadA = new Thread(delThread);
            threadA.Name = "Thread A";
            Thread threadB = new Thread(delThread);
            threadB.Name = "Thread B";
            Console.WriteLine(label1.Text.ToString());
            //label1.Text = "-Before the Thread Starts-";
            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            label1.Text = "-End of Thread-";

            Console.WriteLine(label1.Text.ToString());
        }
    }
}
