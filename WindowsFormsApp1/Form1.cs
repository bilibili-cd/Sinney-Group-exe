using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace WindowsFormsApp1
{
    public partial class Form1 : UIForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void uiDatePicker1_ValueChanged(object sender, DateTime value)
        {

        }

        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            ShowErrorTip("抱歉，资源已失效！");
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            ShowErrorTip("抱歉，资源已失效！");
        }

        private void aaaa_Click(object sender, EventArgs e)
        {
            ShowErrorTip("抱歉，资源已失效！");
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            ShowErrorTip("抱歉，资源已失效！");
        }

        private void uiSymbolButton6_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("y5e3");
            ShowSuccessTip("提取码已复制");
            System.Diagnostics.Process.Start("https://pan.baidu.com/s/1_Y0TAhobwuDTFmCvLWbsfA");
        }

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("y5e3");
            ShowSuccessTip("忘记提取码了？已为您复制。");
        }

        private void uiSymbolButton7_Click(object sender, EventArgs e)
        {
            ShowInfoTip("正在跳转链接......");
            System.Diagnostics.Process.Start("https://space.bilibili.com/1796553094?spm_id_from=333.788.b_765f7570696e666f.1");
        }

        private void uiSymbolButton11_Click(object sender, EventArgs e)
        {
            ShowInfoTip("正在为您跳转......");
            System.Diagnostics.Process.Start("https://space.bilibili.com/1796553094");
        }

        private void uiSymbolButton10_Click(object sender, EventArgs e)
        {
            ShowInfoTip("正在为您跳转......");
            System.Diagnostics.Process.Start("https://space.bilibili.com/1460809668");
        }

        private void uiSymbolButton9_Click(object sender, EventArgs e)
        {
            ShowInfoTip("正在为您跳转......");
            System.Diagnostics.Process.Start("https://green.hxd3a.cf/");
        }

        private void uiSymbolButton8_Click(object sender, EventArgs e)
        {
            ShowInfoTip("正在为您跳转......");
            System.Diagnostics.Process.Start("https://www.youku.com/profile/index/?spm=a2h0c.8166622.PhoneSokuUgc_1.3&uid=UMTY2Nzg1NzI0OA==");
        }
    }
}
