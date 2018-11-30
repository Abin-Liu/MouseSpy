using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Win32API;

namespace MouseSpy
{
	public partial class FormMain : Form
	{
		IntPtr dc = IntPtr.Zero;

		public FormMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			OnStop();
			timer1.Start();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			timer1.Stop();
			OnStop();
		}

		void OnStart()
		{
			this.Text = "MouseSpy - Started";
			lblPropmt.Text = "Release the Ctrl key to stop";
			dc = GDI.GetDC(IntPtr.Zero);
		}

		void OnStop()
		{
			GDI.ReleaseDC(IntPtr.Zero, dc);
			this.Text = "MouseSpy - Stopped";
			lblPropmt.Text = "Hold the Ctrl key to start";
		}

		bool keydown = false;
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool wasDown = keydown;
			keydown = Input.IsKeyDown(Keys.ControlKey);
			if (!wasDown && keydown)
			{
				OnStart();
			}
			else if (wasDown && !keydown)
			{
				OnStop();
			}

			if (keydown)
			{
				Spy();
			}
		}

		void Spy()
		{
			IntPtr foreground = Window.GetForegroundWindow();
			string windowText, className;
			Window.GetWindowText(foreground, out windowText);
			Window.GetClassName(foreground, out className);
			txtWindowHandle.Text = string.Format("0x{0:X8}", (int)foreground);
			txtWindowText.Text = windowText;
			txtClassName.Text = className;

			Point screen;
			Input.GetCursorPos(out screen);
			

			Rectangle rect = new Rectangle();
			Window.GetWindowRect(foreground, out rect);

			Point window = new Point(screen.X - rect.X, screen.Y - rect.Y);

			Point offset = new Point(0, 0);
			Window.ScreenToClient(foreground, out offset);
			Point client = new Point(screen.X, screen.Y);
			client.Offset(offset);

			txtScreenXY.Text = string.Format("{0}, {1}", screen.X, screen.Y);			
			txtWindowXY.Text = string.Format("{0}, {1}", window.X, window.Y);
			txtClientXY.Text = string.Format("{0}, {1}", client.X, client.Y);

			int pixel = GDI.GetPixel(dc, screen.X, screen.Y);
			Color color = Color.FromArgb(pixel);

			string dec = string.Format("{0}, {1}, {2}", color.R, color.G, color.B);
			string hex = string.Format("{0:X2}, {1:X2}, {2:X2}", color.R, color.G, color.B);
			txtPixelDec.Text = dec;
			txtPixelHex.Text = hex;
		}
	}
}
