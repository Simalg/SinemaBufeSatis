namespace SinemaBufeSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            toplam = misir * 150 + su * 20 + cay * 50 + bilet * 200;
            lblToplam.Text = toplam.ToString() + "TL";

            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtMisir.Focus();
        }
    }
}
