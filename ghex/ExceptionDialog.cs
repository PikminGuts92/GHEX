using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

public partial class ExceptionDialog : Form
{
	public ExceptionDialog(Exception exception_1)
	{
		this.InitializeComponent();
		if (!this.cbReport.Checked)
		{
			this.cbReport_CheckedChanged(this, EventArgs.Empty);
		}
		this.MinimumSize = base.Size;
		this.MaximumSize = new Size(base.Size.Width * 2, base.Size.Height * 3);
		this.exception_0 = exception_1;
		this.label1.Text = "An error occurred in " + exception_1.TargetSite.Module.Name + ".";
		if (exception_1.Message.Length > 0)
		{
			TextBox textBox = this.textBox1;
			textBox.Text += "=== Message ===\r\n\r\n";
			TextBox textBox2 = this.textBox1;
			textBox2.Text = textBox2.Text + exception_1.Message + "\r\n\r\n";
		}
		TextBox textBox3 = this.textBox1;
		textBox3.Text += "=== Information ===\r\n\r\n";
		TextBox textBox4 = this.textBox1;
		string text = textBox4.Text;
		textBox4.Text = string.Concat(new string[]
		{
			text,
			"An \"",
			exception_1.GetType().Name,
			"\" occurred in ",
			exception_1.TargetSite.Module.Name,
			":",
			exception_1.TargetSite.DeclaringType.Name,
			".",
			exception_1.TargetSite.Name,
			"()\r\n\r\n"
		});
		TextBox textBox5 = this.textBox1;
		textBox5.Text += "=== Call Stack ===\r\n\r\n";
		StackTrace stackTrace = new StackTrace(exception_1, true);
		TextBox textBox6 = this.textBox1;
		textBox6.Text += ExceptionDialog.smethod_0(stackTrace, 2, stackTrace.FrameCount - 2);
		StackTrace stackTrace2 = new StackTrace(true);
		TextBox textBox7 = this.textBox1;
		textBox7.Text += ExceptionDialog.smethod_0(stackTrace2, 3, stackTrace2.FrameCount);
		if (Class61.smethod_0().method_6().CompareTo(Application.ProductVersion) > 0)
		{
			this.lblNote.Text = "Please try the new version (" + Class61.smethod_0().method_6() + ") before reporting!";
			this.cbReport.Enabled = false;
			this.tbDescription.Enabled = false;
		}
	}

	static string smethod_0(StackTrace stackTrace_0, int int_0, int int_1)
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		for (int i = int_0; i < int_1; i++)
		{
			StackFrame frame = stackTrace_0.GetFrame(i);
			MethodBase method = frame.GetMethod();
			stringBuilder.AppendFormat("{0}.{1}(", method.ReflectedType.FullName, method.Name);
			ParameterInfo[] parameters = method.GetParameters();
			for (int j = 0; j < parameters.Length; j++)
			{
				ParameterInfo parameterInfo = parameters[j];
				if (j > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(parameterInfo.ParameterType.Name);
			}
			stringBuilder.Append(")");
			string fileName = frame.GetFileName();
			if (fileName != null)
			{
				stringBuilder.Append(" at " + fileName.Replace("C:\\home\\projects\\gh\\gh", "."));
			}
			int fileLineNumber = frame.GetFileLineNumber();
			if (fileLineNumber > 0)
			{
				stringBuilder.AppendFormat(":{0}", fileLineNumber);
			}
			stringBuilder.Append("\r\n");
		}
		return stringBuilder.ToString();
	}

	public string method_0()
	{
		return this.textBox1.Text;
	}

	public static string smethod_1()
	{
		return "\r\n";
	}

	public static void smethod_2(string string_0, string string_1, ref ProgressDialog.GClass73 gclass73_0)
	{
		TcpClient tcpClient = new TcpClient("smtp.onreally.com", 26);
		List<string> list = new List<string>();
		lock (gclass73_0)
		{
			gclass73_0.string_0 = "Reporting..";
			gclass73_0.int_0 = 0;
		}
		try
		{
			lock (gclass73_0)
			{
				gclass73_0.string_1 = "Connecting..";
			}
			NetworkStream stream = tcpClient.GetStream();
			StreamReader streamReader = new StreamReader(tcpClient.GetStream());
			list.Add(streamReader.ReadLine());
			lock (gclass73_0)
			{
				gclass73_0.string_1 = "Negotiating..";
				gclass73_0.int_0 = 33;
			}
			Dns.GetHostEntry((tcpClient.Client.LocalEndPoint as IPEndPoint).Address);
			string text = "HELO local.domain.name " + ExceptionDialog.smethod_1();
			byte[] bytes = Encoding.ASCII.GetBytes(text.ToCharArray());
			stream.Write(bytes, 0, bytes.Length);
			list.Add(streamReader.ReadLine());
			text = "MAIL FROM: <ghex@onreally.com>" + ExceptionDialog.smethod_1();
			bytes = Encoding.ASCII.GetBytes(text.ToCharArray());
			stream.Write(bytes, 0, bytes.Length);
			list.Add(streamReader.ReadLine());
			text = "RCPT TO: <ghex@onreally.com>" + ExceptionDialog.smethod_1();
			bytes = Encoding.ASCII.GetBytes(text.ToCharArray());
			stream.Write(bytes, 0, bytes.Length);
			list.Add(streamReader.ReadLine());
			text = "DATA " + ExceptionDialog.smethod_1();
			bytes = Encoding.ASCII.GetBytes(text.ToCharArray());
			stream.Write(bytes, 0, bytes.Length);
			list.Add(streamReader.ReadLine());
			lock (gclass73_0)
			{
				gclass73_0.string_1 = "Sending report..";
				gclass73_0.int_0 = 66;
			}
			string text2 = "";
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_PhysicalMedia");
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (managementObject["SerialNumber"] != null)
					{
						text2 = text2 + " " + managementObject["SerialNumber"].ToString().Trim();
					}
				}
			}
			catch
			{
			}
			text = string.Concat(new string[]
			{
				"From: \"ghex\" <ghex@onreally.com>",
				ExceptionDialog.smethod_1(),
				"To: \"ghex\" <ghex@onreally.com>",
				ExceptionDialog.smethod_1(),
				"Date: ",
				DateTime.Now.ToString("d MMM yyyy ", DateTimeFormatInfo.InvariantInfo),
				DateTime.Now.ToString("T"),
				" -0000",
				ExceptionDialog.smethod_1(),
				"Subject: ",
				string_0,
				ExceptionDialog.smethod_1(),
				ExceptionDialog.smethod_1(),
				string_1,
				ExceptionDialog.smethod_1(),
				ExceptionDialog.smethod_1(),
				"=== System information ===",
				ExceptionDialog.smethod_1(),
				ExceptionDialog.smethod_1(),
				"ghex ",
				Application.ProductVersion,
				" as ",
				Application.ExecutablePath,
				ExceptionDialog.smethod_1(),
				"Windows version: ",
				Environment.OSVersion.VersionString,
				ExceptionDialog.smethod_1(),
				".NET version: ",
				Environment.Version.ToString(),
				ExceptionDialog.smethod_1(),
				"Disk(s):",
				text2,
				ExceptionDialog.smethod_1(),
				ExceptionDialog.smethod_1(),
				ExceptionDialog.smethod_1(),
				".",
				ExceptionDialog.smethod_1()
			});
			bytes = Encoding.ASCII.GetBytes(text.ToCharArray());
			stream.Write(bytes, 0, bytes.Length);
			list.Add(streamReader.ReadLine());
			lock (gclass73_0)
			{
				gclass73_0.string_1 = "Closing connection..";
				gclass73_0.int_0 = 100;
				gclass73_0.string_2 = "Successfully reported error!";
			}
			text = "QUIT " + ExceptionDialog.smethod_1();
			bytes = Encoding.ASCII.GetBytes(text.ToCharArray());
			stream.Write(bytes, 0, bytes.Length);
			list.Add(streamReader.ReadLine());
			stream.Close();
			streamReader.Close();
		}
		catch
		{
			lock (gclass73_0)
			{
				gclass73_0.string_2 = "Failed to report error";
			}
		}
	}

	public static void smethod_3(ExceptionDialog.GDelegate22 gdelegate22_0)
	{
		if (!ExceptionDialog.bool_0 && Debugger.IsAttached)
		{
			gdelegate22_0();
			return;
		}
		try
		{
			gdelegate22_0();
		}
		catch (IOException ex)
		{
			MessageBox.Show("Couldn't read the archive.\n" + ex.Message + "\nPlease restart the program and try again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (Exception exception_)
		{
			ExceptionDialog.smethod_4(exception_);
		}
	}

	public static void smethod_4(Exception exception_1)
	{
		ProgressDialog.GDelegate6 gdelegate = null;
		ExceptionDialog.Class100 @class = new ExceptionDialog.Class100();
		@class.exception_0 = exception_1;
		@class.exceptionDialog_0 = new ExceptionDialog(@class.exception_0);
		@class.exceptionDialog_0.ShowDialog();
		DialogResult dialogResult = @class.exceptionDialog_0.DialogResult;
		if (dialogResult != DialogResult.OK && dialogResult == DialogResult.Retry)
		{
			ProcessStartInfo startInfo = Process.GetCurrentProcess().StartInfo;
			if (startInfo.FileName.Length > 0)
			{
				Process.Start(startInfo);
			}
			else
			{
				Process.Start(Application.ExecutablePath, startInfo.Arguments);
			}
		}
		if (@class.exceptionDialog_0.cbReport.Checked)
		{
			if (gdelegate == null)
			{
				gdelegate = new ProgressDialog.GDelegate6(@class.method_0);
			}
			ProgressDialog progressDialog = new ProgressDialog(gdelegate);
			progressDialog.ShowDialog(@class.exceptionDialog_0);
		}
		if (@class.exceptionDialog_0.DialogResult == DialogResult.Retry)
		{
			Application.Exit();
		}
	}

	void cbReport_CheckedChanged(object sender, EventArgs e)
	{
		if (!this.cbReport.Checked)
		{
			this.tbDescription.Visible = false;
			base.Height -= this.tbDescription.Height;
			this.cbReport.Top += this.tbDescription.Height;
			this.btnContinue.Top += this.tbDescription.Height;
			this.btnRestart.Top += this.tbDescription.Height;
			this.textBox1.Height += this.tbDescription.Height;
			this.lblNote.Top += this.tbDescription.Height;
			return;
		}
		base.Height += this.tbDescription.Height;
		this.cbReport.Top -= this.tbDescription.Height;
		this.btnContinue.Top -= this.tbDescription.Height;
		this.btnRestart.Top -= this.tbDescription.Height;
		this.lblNote.Top -= this.tbDescription.Height;
		this.textBox1.Height -= this.tbDescription.Height;
		this.tbDescription.Visible = true;
		this.tbDescription.Focus();
		if (this.bool_1)
		{
			this.bool_1 = false;
			this.tbDescription.SelectAll();
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	Exception exception_0;

	static bool bool_0;

	bool bool_1 = true;

	IContainer icontainer_0;

	public delegate void GDelegate22();

	[CompilerGenerated]
	sealed class Class100
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
			ExceptionDialog.smethod_2("Bug Report: " + this.exception_0.GetType().Name, string.Concat(new string[]
			{
				this.exceptionDialog_0.textBox1.Text,
				ExceptionDialog.smethod_1(),
				ExceptionDialog.smethod_1(),
				"=== User-supplied information ===",
				ExceptionDialog.smethod_1(),
				ExceptionDialog.smethod_1(),
				this.exceptionDialog_0.tbDescription.Text
			}), ref gclass73_0);
		}

		public ExceptionDialog exceptionDialog_0;

		public Exception exception_0;
	}
}
