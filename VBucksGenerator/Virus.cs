using System;
using System.Drawing;
using System.Windows.Forms;

namespace VBucksGenerator
{
	public partial class Virus : Form
	{
		public Virus()
		{
			this.InitializeComponent();
		}

		private void Virus_Load(object sender, EventArgs e)
		{
			Rectangle screen = Screen.PrimaryScreen.WorkingArea;
			Random _random = new Random();
			int x = _random.Next(screen.Width - this.Width);   // range [0 .. screen width - form width].
			int y = _random.Next(screen.Height - this.Height); // range [0 .. screen height - form height].
			this.Location = new Point(x, y);
		}
	}
}
