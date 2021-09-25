using System;
using System.Windows.Forms;
using static System.Math;

namespace Währungsrechner
{
    public partial class Main : Form
    {
        Währungen euro = new Währungen();
        Währungen usdollar = new Währungen();
        Währungen pound = new Währungen();
        Währungen yen = new Währungen();
        Währungen inputw;

        public double output = 0;

        public Main()
        {
            InitializeComponent();

            euro.symbol = "€";
            euro.welthe = 1;
            euro.welthg = 1;

            usdollar.symbol = "$";
            usdollar.welthe = 1.1719;
            usdollar.welthg = 0.85331512927724208550217595357966;

            pound.symbol = "£";
            pound.welthe = 0.857;
            pound.welthg = 1.1668611435239206534422403733956;


            yen.symbol = "¥";
            yen.welthe = 129.49;
            yen.welthg = 0.00772260406208973665920148273998;
        }

        private void TSSIeuro_Click(object sender, EventArgs e)
        {
            lblinputw.Text = euro.symbol;
            inputw = euro;
        }

        private void TSSIusdollar_Click(object sender, EventArgs e)
        {
            lblinputw.Text = usdollar.symbol;
            inputw = usdollar;
        }

        private void TSSIpound_Click(object sender, EventArgs e)
        {
            lblinputw.Text = pound.symbol;
            inputw = pound;
        }

        private void TTSIyen_Click(object sender, EventArgs e)
        {
            lblinputw.Text = yen.symbol;
            inputw = yen;
        }

        private void TTSOeuro_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(txtbxinput.Text);
            output = inputw.Calc(input, euro);
            lbloutputw.Text = euro.symbol;
            Output();
        }

        private void TTSOdollar_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(txtbxinput.Text);
            output = inputw.Calc(input, usdollar);
            lbloutputw.Text = usdollar.symbol;
            Output();
        }

        private void TTSOpound_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(txtbxinput.Text);
            output = inputw.Calc(input, pound);
            lbloutputw.Text = pound.symbol;
            Output();
        }

        private void TTSOyen_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(txtbxinput.Text);
            output = inputw.Calc(input, yen);
            lbloutputw.Text = yen.symbol;
            Output();
        }
        
        /// <summary>
        /// Zeigt den Output
        /// </summary>
        private void Output()
        {
            txtbxoutbut.Text = Convert.ToString(Round(output, 2));
        }
    }
}
