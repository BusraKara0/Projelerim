namespace C__Ödev._3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string urunadı;
			int fiyat, KDV;
			double sonuc;
			urunadı = textBox1.Text;
			fiyat = Convert.ToInt16(textBox2.Text);
			KDV = Convert.ToInt16(textBox3.Text);
			sonuc = (fiyat * KDV) / 100;
			listBox1.Items.Add(urunadı + " " + " Sonuç: " + sonuc);
		}
	}
}