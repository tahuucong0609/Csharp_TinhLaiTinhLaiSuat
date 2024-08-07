using System.Globalization;

namespace Csharp_TinhLaiTinhLaiSuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (double i = 0.01; i <= 0.101; i += 0.001)
            {
                cbxlaisuat.Items.Add(string.Format("{0:P1}", Math.Round(i, 3)));
            }
            txtsotien.Text = "10000000";
            cbxlaisuat.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            lsbketqua.Items.Clear();
            double sotien = Convert.ToInt64(txtsotien.Text);
            int sonam = (int)nudsonam.Value;
            double laiSuat = Double.Parse(cbxlaisuat.SelectedItem.ToString().Replace("%", "")) / 100;
            MessageBox.Show("lai Suat " + laiSuat);
            for (int i = 1; i <= sonam; i++)
            {
                double tienlai = sotien * laiSuat;
                lsbketqua.Items.Add("Năm " + i + " Tiền gốc: " + sotien.ToString("N", new CultureInfo("en-US")) + " - Lãi: " + tienlai.ToString("N", new CultureInfo("en-US")));
                sotien += tienlai;
            }
        }
    }
}
