namespace MouseSpy
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtClassName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtWindowText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtWindowHandle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtPixelHex = new System.Windows.Forms.TextBox();
			this.txtPixelDec = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtClientY = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtScreenY = new System.Windows.Forms.TextBox();
			this.txtClientX = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtScreenX = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblPropmt = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtClassName);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtWindowText);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtWindowHandle);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(415, 112);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Foreground Window";
			// 
			// txtClassName
			// 
			this.txtClassName.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtClassName.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtClassName.Location = new System.Drawing.Point(108, 77);
			this.txtClassName.Name = "txtClassName";
			this.txtClassName.ReadOnly = true;
			this.txtClassName.Size = new System.Drawing.Size(291, 20);
			this.txtClassName.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Class Name:";
			// 
			// txtWindowText
			// 
			this.txtWindowText.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtWindowText.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtWindowText.Location = new System.Drawing.Point(108, 51);
			this.txtWindowText.Name = "txtWindowText";
			this.txtWindowText.ReadOnly = true;
			this.txtWindowText.Size = new System.Drawing.Size(291, 20);
			this.txtWindowText.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Window Text:";
			// 
			// txtWindowHandle
			// 
			this.txtWindowHandle.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtWindowHandle.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtWindowHandle.Location = new System.Drawing.Point(108, 25);
			this.txtWindowHandle.Name = "txtWindowHandle";
			this.txtWindowHandle.ReadOnly = true;
			this.txtWindowHandle.Size = new System.Drawing.Size(291, 20);
			this.txtWindowHandle.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Window Handle:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtPixelHex);
			this.groupBox2.Controls.Add(this.txtPixelDec);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.txtClientY);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtScreenY);
			this.groupBox2.Controls.Add(this.txtClientX);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtScreenX);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(12, 140);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(415, 111);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cursor Information";
			// 
			// txtPixelHex
			// 
			this.txtPixelHex.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtPixelHex.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtPixelHex.Location = new System.Drawing.Point(292, 76);
			this.txtPixelHex.Name = "txtPixelHex";
			this.txtPixelHex.ReadOnly = true;
			this.txtPixelHex.Size = new System.Drawing.Size(107, 20);
			this.txtPixelHex.TabIndex = 11;
			// 
			// txtPixelDec
			// 
			this.txtPixelDec.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtPixelDec.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtPixelDec.Location = new System.Drawing.Point(84, 76);
			this.txtPixelDec.Name = "txtPixelDec";
			this.txtPixelDec.ReadOnly = true;
			this.txtPixelDec.Size = new System.Drawing.Size(107, 20);
			this.txtPixelDec.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(222, 79);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(57, 13);
			this.label9.TabIndex = 10;
			this.label9.Text = "Pixel HEX:";
			// 
			// txtClientY
			// 
			this.txtClientY.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtClientY.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtClientY.Location = new System.Drawing.Point(292, 50);
			this.txtClientY.Name = "txtClientY";
			this.txtClientY.ReadOnly = true;
			this.txtClientY.Size = new System.Drawing.Size(107, 20);
			this.txtClientY.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 79);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Pixel DEC:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(222, 54);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Client Y:";
			// 
			// txtScreenY
			// 
			this.txtScreenY.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtScreenY.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtScreenY.Location = new System.Drawing.Point(292, 24);
			this.txtScreenY.Name = "txtScreenY";
			this.txtScreenY.ReadOnly = true;
			this.txtScreenY.Size = new System.Drawing.Size(107, 20);
			this.txtScreenY.TabIndex = 3;
			// 
			// txtClientX
			// 
			this.txtClientX.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtClientX.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtClientX.Location = new System.Drawing.Point(84, 50);
			this.txtClientX.Name = "txtClientX";
			this.txtClientX.ReadOnly = true;
			this.txtClientX.Size = new System.Drawing.Size(107, 20);
			this.txtClientX.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(222, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Screen Y:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 54);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Client X:";
			// 
			// txtScreenX
			// 
			this.txtScreenX.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtScreenX.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtScreenX.Location = new System.Drawing.Point(84, 24);
			this.txtScreenX.Name = "txtScreenX";
			this.txtScreenX.ReadOnly = true;
			this.txtScreenX.Size = new System.Drawing.Size(107, 20);
			this.txtScreenX.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Screen X:";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblPropmt
			// 
			this.lblPropmt.AutoSize = true;
			this.lblPropmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblPropmt.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPropmt.Location = new System.Drawing.Point(12, 260);
			this.lblPropmt.Name = "lblPropmt";
			this.lblPropmt.Size = new System.Drawing.Size(305, 13);
			this.lblPropmt.TabIndex = 3;
			this.lblPropmt.Text = "Hold/release the CTRL key to start/stop capturing...";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 287);
			this.Controls.Add(this.lblPropmt);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "MouseSpy";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtClassName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtWindowText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtWindowHandle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtPixelHex;
		private System.Windows.Forms.TextBox txtPixelDec;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtClientY;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtScreenY;
		private System.Windows.Forms.TextBox txtClientX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtScreenX;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblPropmt;
	}
}

