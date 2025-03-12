using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace time
{
        public partial class program311: Form
    {
        public program311()
        {
            InitializeComponent();
            button1.Text = "显示现在时间(北京时间)";
            button2.Text = "看风景";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("成功显示时间");
            Console.WriteLine("成功输出事件");
            string timenow = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");
            TimeBox1.Text = timenow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("美景来了");
            pictureBox1.BackgroundImage = global::time.Properties.Resources.AC3124C1BB6489B03325DB3D1DBF917524FEFCD1_size2234_w3644_h2000;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
      
   

        }
    }
