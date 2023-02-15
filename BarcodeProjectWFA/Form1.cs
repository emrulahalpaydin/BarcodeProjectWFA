namespace BarcodeProjectWFA
{
    public partial class BarcodeFrom : Form
    {
        public BarcodeFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text != "")
                {
					var adet = Convert.ToInt32(textBox3.Text);
					if (adet != 0 && adet > 0)
					{
						var barkod = textBox2.Text;
						if (barkod != null && barkod != "")
						{
							for (int i = 0; i < adet; i++)
							{
								var newBarcode = barkod + "-" + Guid.NewGuid().ToString().ToUpper().Replace("-", "").Substring(0, 13);
								listBox1.Items.Add(newBarcode);
							}
						}
						else
						{
							MessageBox.Show("Lütfen barkod giriniz.");
						}
					}
					else
					{
						MessageBox.Show("Lütfen geçerli bir adet giriniz.");
					}
				}
				else
				{
					MessageBox.Show("Adet alani bos birakilamaz.");
				}
				
			}
            catch
            {
                throw;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string barcodeList = "";
            foreach (var item in listBox1.Items)
            {
                barcodeList += item.ToString() + "\n";
            }
            Clipboard.SetText(barcodeList);
            MessageBox.Show("Kopyalandi.");
        }

		private void button3_Click(object sender, EventArgs e)
		{
            listBox1.Items.Clear();
		}
	}
}