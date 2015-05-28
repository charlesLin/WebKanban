using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Send(11);
		}

		private void Send(int lineId)
		{
			var req = new WebClient();
			req.UploadString("http://localhost:4193/api/increase?lineid=" +
			                   lineId, string.Empty);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var random = new Random((int)DateTime.Now.Ticks);

			int length = int.Parse(maxLength.Text);
			int sleep = int.Parse(sleepTextbox.Text);
			Parallel.For(1, length + 1, (i) =>
			{
				var lineId = random.Next(12) + 1;
				Send(lineId);
				Thread.Sleep(random.Next(sleep));
			});

			
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
