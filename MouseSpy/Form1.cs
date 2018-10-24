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
	public partial class Form1 : Form
	{
		IntPtr dc = IntPtr.Zero;

		public Form1()
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

			Point offset, client;
			Window.ScreenToClient(foreground, out offset);
			client = screen;
			client.Offset(offset);

			txtScreenX.Text = string.Format("{0}", screen.X);
			txtScreenY.Text = string.Format("{0}", screen.Y);
			txtClientX.Text = string.Format("{0}", client.X);
			txtClientY.Text = string.Format("{0}", client.Y);

			int pixel = GDI.GetPixel(dc, screen.X, screen.Y);
			Color color = Color.FromArgb(pixel);

			string dec = string.Format("{0}, {1}, {2}", color.R, color.G, color.B);
			string hex = string.Format("{0:X2}, {1:X2}, {2:X2}", color.R, color.G, color.B);
			txtPixelDec.Text = dec;
			txtPixelHex.Text = hex;
		}
	}
}
