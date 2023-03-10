namespace Switch_Case_Yapımı
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int ay = Convert.ToInt16(textBox1.Text);
			switch (ay)
			{
				case 1: label2.Text = "Ocak"; break;
				case 2: label2.Text = "Şubat"; break;
				case 3: label2.Text = "Mart"; break;
				case 4: label2.Text = "Nisan"; break;
				case 5: label2.Text = "Mayıs"; break;
				case 6: label2.Text = "Haziran"; break;
				case 7: label2.Text = "Temmuz"; break;
				case 8: label2.Text = "Ağustos"; break;
				case 9: label2.Text = "Eylül"; break;
				case 10: label2.Text = "Ekim"; break;
				case 11: label2.Text = "Kasım"; break;
				case 12: label2.Text = "Aralık"; break;
				default: label2.Text = "Hatalı Ay"; break;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string mevsim = textBox2.Text;
			switch (mevsim)
			{
				case "yaz": label4.Text = "Haziran Temmuz Ağustos"; break;
				case "sonbahar": label4.Text = "Eylül Ekim Kasım"; break;
				case "kış": label4.Text = "Aralık Ocak Şubat"; break;
				case "ilkbahar": label4.Text = "Mart Nisan Mayıs"; break;
				default: label4.Text = "Hatalı Mevsim"; break;
			}
		}
	}
}