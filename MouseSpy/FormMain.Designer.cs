namespace MouseSpy
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtClassName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtWindowText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtWindowHandle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnRegain = new System.Windows.Forms.Button();
			this.txtCurrentPixel = new System.Windows.Forms.TextBox();
			this.txtPixel = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtClientXY = new System.Windows.Forms.TextBox();
			this.txtWindowXY = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtScreenXY = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblPropmt = new System.Windows.Forms.Label();
			this.chkHex = new System.Windows.Forms.CheckBox();
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
			this.groupBox2.Controls.Add(this.chkHex);
			this.groupBox2.Controls.Add(this.btnRegain);
			this.groupBox2.Controls.Add(this.txtCurrentPixel);
			this.groupBox2.Controls.Add(this.txtPixel);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtClientXY);
			this.groupBox2.Controls.Add(this.txtWindowXY);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtScreenXY);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(12, 140);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(415, 111);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cursor Information";
			// 
			// btnRegain
			// 
			this.btnRegain.Location = new System.Drawing.Point(218, 50);
			this.btnRegain.Name = "btnRegain";
			this.btnRegain.Size = new System.Drawing.Size(61, 23);
			this.btnRegain.TabIndex = 8;
			this.btnRegain.Text = "Regain";
			this.btnRegain.UseVisualStyleBackColor = true;
			this.btnRegain.Click += new System.EventHandler(this.btnRegain_Click);
			// 
			// txtCurrentPixel
			// 
			this.txtCurrentPixel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtCurrentPixel.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtCurrentPixel.Location = new System.Drawing.Point(292, 51);
			this.txtCurrentPixel.Name = "txtCurrentPixel";
			this.txtCurrentPixel.ReadOnly = true;
			this.txtCurrentPixel.Size = new System.Drawing.Size(107, 20);
			this.txtCurrentPixel.TabIndex = 9;
			// 
			// txtPixel
			// 
			this.txtPixel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtPixel.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtPixel.Location = new System.Drawing.Point(292, 21);
			this.txtPixel.Name = "txtPixel";
			this.txtPixel.ReadOnly = true;
			this.txtPixel.Size = new System.Drawing.Size(107, 20);
			this.txtPixel.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(222, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Pixel RGB:";
			// 
			// txtClientXY
			// 
			this.txtClientXY.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtClientXY.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtClientXY.Location = new System.Drawing.Point(84, 79);
			this.txtClientXY.Name = "txtClientXY";
			this.txtClientXY.ReadOnly = true;
			this.txtClientXY.Size = new System.Drawing.Size(107, 20);
			this.txtClientXY.TabIndex = 5;
			// 
			// txtWindowXY
			// 
			this.txtWindowXY.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtWindowXY.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtWindowXY.Location = new System.Drawing.Point(84, 51);
			this.txtWindowXY.Name = "txtWindowXY";
			this.txtWindowXY.ReadOnly = true;
			this.txtWindowXY.Size = new System.Drawing.Size(107, 20);
			this.txtWindowXY.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 83);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Client  XY:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Window XY:";
			// 
			// txtScreenXY
			// 
			this.txtScreenXY.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtScreenXY.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtScreenXY.Location = new System.Drawing.Point(84, 24);
			this.txtScreenXY.Name = "txtScreenXY";
			this.txtScreenXY.ReadOnly = true;
			this.txtScreenXY.Size = new System.Drawing.Size(107, 20);
			this.txtScreenXY.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Screen XY:";
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
			this.lblPropmt.Size = new System.Drawing.Size(289, 13);
			this.lblPropmt.TabIndex = 2;
			this.lblPropmt.Text = "Hold/release Ctrl-Alt key to start/stop capturing...";
			// 
			// chkHex
			// 
			this.chkHex.AutoSize = true;
			this.chkHex.Location = new System.Drawing.Point(225, 83);
			this.chkHex.Name = "chkHex";
			this.chkHex.Size = new System.Drawing.Size(119, 17);
			this.chkHex.TabIndex = 10;
			this.chkHex.Text = "Hexadecimal format";
			this.chkHex.UseVisualStyleBackColor = true;
			this.chkHex.CheckedChanged += new System.EventHandler(this.chkHex_CheckedChanged);
			// 
			// FormMain
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
			this.Name = "FormMain";
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
		private System.Windows.Forms.TextBox txtCurrentPixel;
		private System.Windows.Forms.TextBox txtPixel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtClientXY;
		private System.Windows.Forms.TextBox txtWindowXY;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtScreenXY;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblPropmt;
		private System.Windows.Forms.Button btnRegain;
		private System.Windows.Forms.CheckBox chkHex;
	}
}

