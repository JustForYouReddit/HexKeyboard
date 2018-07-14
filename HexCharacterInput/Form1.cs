using System;
using System.Windows.Forms;

namespace HexCharacterInput
{
    public partial class Form1 : Form
    {
        private const int waitTime = 1;

        private Timer timer;
        private bool prgMostIncrementing = false;
        private bool prgLeastIncrementing = false;
        private string character;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitTimer();
        }

        private void InitTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = waitTime; // in miliseconds
            timer.Start();
        }

        private void btnMostSign_MouseDown(object sender, EventArgs e) => prgMostIncrementing = true;

        private void btnMostSign_MouseUp(object sedner, EventArgs e) => prgMostIncrementing = false;

        private void btnLeastSign_MouseDown(object sender, EventArgs e) => prgLeastIncrementing = true;

        private void btnLeastSign_MouseUp(object sender, EventArgs e) => prgLeastIncrementing = false;

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendKeys.Send(character);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!chkMostSignLocked.Checked) prgInc(prgMostSign, prgMostIncrementing ? 1 : -1);
            if (!chkLeastSignLocked.Checked) prgInc(prgLeastSign, prgLeastIncrementing ? 1 : -1);
            GetCharacter();
        }

        private void prgInc(ProgressBar prg, int value)
        {
            if ((prg.Value > prg.Minimum && value < 0) || prg.Value < prg.Maximum && value > 0)
                prg.SetProgressNoAnimation(prg.Value + value);
        }

        private void GetCharacter()
        {
            int div = prgMostSign.Maximum / 16;

            int mostSign = prgMostSign.Value / div;
            int leastSign = prgLeastSign.Value / div;

            mostSign = mostSign > 15 ? 15 : mostSign;
            leastSign = leastSign > 15 ? 15 : leastSign;

            int charVal = mostSign * 16 + leastSign;

            string hex = charVal.ToString("X");
            lblHex.Text = hex;

            character = ConvertHex(hex);
            lblChar.Text = character;
        }

        public static string ConvertHex(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;
                }

                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }
    }
}