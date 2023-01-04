using Entities.Configurations;
using System;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public partial class UcQrConfing : UserControl
    {
        public UcQrConfing()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UcQrConfing_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) { return; }

            //Size
            cmbSize.Items.Clear();
            for (int i = 1; i<=10; i++ )
            cmbSize.Items.Add(String.Format("{0}{0}", i*100));

            //CharSet Souce
            cmbCharsetSouce.Items.Clear();
            cmbCharsetSouce.Items.Add("ISO-8859-1");
            cmbCharsetSouce.Items.Add("UTF-0");

            //CharSet-target
            cmbCharsetTarget.Items.Clear();
            cmbCharsetTarget.Items.Add("ISO-8859-1");
            cmbCharsetTarget.Items.Add("UTF-0");

            //ECC(Aprimoramento das informações contidas dentro do QRCode)
            
            cmbECC.Items.Clear();
            cmbECC.Items.Add("L");
            cmbECC.Items.Add("M");
            cmbECC.Items.Add("Q");
            cmbECC.Items.Add("H");

            //Color

            cmbColor.Items.Clear();
            cmbColor.Items.Add("000000");
            cmbColor.Items.Add("FFFFFF");
            cmbColor.Items.Add("FF0000");
            cmbColor.Items.Add("00FF00");
            cmbColor.Items.Add("0000FF");

            //BGColor

            cmbBGColor.Items.Clear();
            cmbBGColor.Items.Add("000000");
            cmbBGColor.Items.Add("FFFFFF");
            cmbBGColor.Items.Add("FF0000");
            cmbBGColor.Items.Add("00FF00");
            cmbBGColor.Items.Add("0000FF");

            //Margin

            cmbMargin.Items.Clear();
            for (int i = 0; i<= 50; i++)
                cmbMargin.Items.Add(i);

            //QZone

            cmbQZone.Items.Clear();
            for (int i = 0; i <= 100; i++)
                cmbQZone.Items.Add(i);

            //Format

            cmbFormat.Items.Clear();
            cmbFormat.Items.Add("png");
            cmbFormat.Items.Add("gif");
            cmbFormat.Items.Add("jpeg");
            cmbFormat.Items.Add("jpg");

            SetDefaulOptions();
        }

        public void SetDefaulOptions()
        {
            cmbSize.SelectedIndex = 1;
            cmbCharsetSouce.SelectedIndex = 1;
            cmbCharsetTarget.SelectedIndex = 1;
            cmbECC.SelectedIndex = 0;
            cmbColor.SelectedIndex = 0;
            cmbBGColor.SelectedIndex = 1;
            cmbMargin.SelectedIndex = 1;
            cmbQZone.SelectedIndex = 0;
            cmbFormat.SelectedIndex = 0;

        }
        public QRConfig GetConfig()
        {
            QRConfig config = new QRConfig();

            config.Size = cmbSize.SelectedItem.ToString();
            config.CharsetSoucer = cmbCharsetSouce.SelectedItem.ToString();
            config.CharsetTarget = cmbCharsetTarget.SelectedItem.ToString();
            config.ECC = cmbECC.SelectedItem.ToString()[0];
            config.Color = cmbBGColor.SelectedItem.ToString();
            config.BGColor = cmbBGColor.SelectedItem.ToString();
            config.Margin = Convert.ToInt32(cmbMargin.SelectedItem.ToString());
            config.QZone = Convert.ToInt32(cmbQZone.SelectedItem.ToString());
            config.Format = cmbFormat.SelectedItem.ToString();


            return config;
        }


        private void UcQrConfing_Load_1(object sender, EventArgs e)
        {

        }
    }
}
