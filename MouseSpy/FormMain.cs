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
		IntPtr m_dc = IntPtr.Zero;
		IntPtr m_foreground = IntPtr.Zero;
		Point m_screen = new Point(0, 0);
		int m_RGB = -1;
		int m_currentRGB = -1;

		public FormMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			m_dc = GDI.GetDC(IntPtr.Zero);
			OnStop();			
			timer1.Start();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			timer1.Stop();
			OnStop();
			GDI.ReleaseDC(IntPtr.Zero, m_dc);
		}

		void OnStart()
		{
			this.Text = "MouseSpy - Started";
			lblPropmt.Text = "Release Ctrl-Alt keys to stop";
			
		}

		void OnStop()
		{			
			this.Text = "MouseSpy - Stopped";
			lblPropmt.Text = "Hold Ctrl-Alt keys to start";
		}

		bool keydown = false;
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool wasDown = keydown;
			keydown = Input.IsKeyDown(Keys.ControlKey) && Input.IsKeyDown(Keys.Menu);
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

		private void btnRegain_Click(object sender, EventArgs e)
		{
			RegainPixel();
		}

		private void chkHex_CheckedChanged(object sender, EventArgs e)
		{
			txtPixel.Text = FormatGRB(m_RGB);
			txtCurrentPixel.Text = FormatGRB(m_currentRGB);
		}

		string FormatGRB(int rgb)
		{
			Color color = Color.FromArgb(rgb);
			string value;
			if (chkHex.Checked)
			{
				value = string.Format("{0:X2}, {1:X2}, {2:X2}", color.R, color.G, color.B);
			}
			else
			{
				value = string.Format("{0}, {1}, {2}", color.R, color.G, color.B);
			}
			return value;
		}

		void Spy()
		{
			SpyWindow();
			SpyLocation();
			SpyPixel();
		}

		void SpyWindow()
		{
			m_foreground = Window.GetForegroundWindow();
			string windowText, className;
			Window.GetWindowText(m_foreground, out windowText);
			Window.GetClassName(m_foreground, out className);
			txtWindowHandle.Text = string.Format("0x{0:X8}", (int)m_foreground);
			txtWindowText.Text = windowText;
			txtClassName.Text = className;
		}

		void SpyLocation()
		{
			Input.GetCursorPos(out m_screen);
			Point window = Window.ScreenToWindow(m_foreground, m_screen);
			Point client = Window.ScreenToClient(m_foreground, m_screen);
			txtScreenXY.Text = string.Format("{0}, {1}", m_screen.X, m_screen.Y);
			txtWindowXY.Text = string.Format("{0}, {1}", window.X, window.Y);
			txtClientXY.Text = string.Format("{0}, {1}", client.X, client.Y);
		}

		void SpyPixel()
		{
			m_currentRGB = GDI.GetPixel(m_dc, m_screen.X, m_screen.Y);
			m_RGB = m_currentRGB;			
			txtCurrentPixel.Text = FormatGRB(m_currentRGB);
			txtPixel.Text = FormatGRB(m_RGB);
		}

		void RegainPixel()
		{
			m_currentRGB = GDI.GetPixel(m_dc, m_screen.X, m_screen.Y);
			txtCurrentPixel.Text = FormatGRB(m_currentRGB);
		}		
	}
}
