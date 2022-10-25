using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                "現在時間", MessageBoxButtons.OK,MessageBoxIcon.Information);

            
            DateTime nowTime=DateTime.Now;
            
            string Hi = GetTimeSayHi(nowTime);            

            showLabel.Text = nowTime.ToString()+"\n\r"+Hi;

        }

        private string GetTimeSayHi(DateTime nowTime)
        {
            int hour = nowTime.Hour;
            string Hi=String.Empty;
            if (hour < 12 && hour > 6)
            {
                Hi = "早安";
            }
            else
            {
                if (hour <= 18 && hour >= 12)
                {
                    Hi = "午安";
                }
                else
                {
                    Hi = "晚安";
                }
            }
            return Hi;
        }
    }
}
