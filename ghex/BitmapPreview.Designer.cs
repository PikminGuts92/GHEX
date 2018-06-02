using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
public class BitmapPreview : UserControl
{
    private static global::System.Resources.ResourceManager resourceMan;

    private static global::System.Globalization.CultureInfo resourceCulture;

    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal BitmapPreview()
    {
    }

    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    public static global::System.Resources.ResourceManager ResourceManager
    {
        get
        {
            if (object.ReferenceEquals(resourceMan, null))
            {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BitmapPreview", typeof(BitmapPreview).Assembly);
                resourceMan = temp;
            }
            return resourceMan;
        }
    }

    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    public static global::System.Globalization.CultureInfo Culture
    {
        get
        {
            return resourceCulture;
        }
        set
        {
            resourceCulture = value;
        }
    }

    protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	void InitializeComponent()
	{
		this.panel1 = new Panel();
		this.tbZoom = new TrackBar();
		this.lZoom = new Label();
		this.panel1.SuspendLayout();
		((ISupportInitialize)this.tbZoom).BeginInit();
		base.SuspendLayout();
		this.panel1.BackColor = SystemColors.Control;
		this.panel1.Controls.Add(this.lZoom);
		this.panel1.Controls.Add(this.tbZoom);
		this.panel1.Dock = DockStyle.Top;
		this.panel1.Location = new Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new Size(333, 31);
		this.panel1.TabIndex = 0;
		this.tbZoom.AutoSize = false;
		this.tbZoom.LargeChange = 25;
		this.tbZoom.Location = new Point(3, 3);
		this.tbZoom.Maximum = 500;
		this.tbZoom.Minimum = 25;
		this.tbZoom.Name = "tbZoom";
		this.tbZoom.Size = new Size(200, 20);
		this.tbZoom.SmallChange = 5;
		this.tbZoom.TabIndex = 0;
		this.tbZoom.TickFrequency = 25;
		this.tbZoom.Value = 100;
		this.tbZoom.ValueChanged += this.tbZoom_ValueChanged;
		this.lZoom.AutoSize = true;
		this.lZoom.Location = new Point(209, 10);
		this.lZoom.Name = "lZoom";
		this.lZoom.Size = new Size(33, 13);
		this.lZoom.TabIndex = 1;
		this.lZoom.Text = "100%";
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = SystemColors.AppWorkspace;
		base.Controls.Add(this.panel1);
		this.DoubleBuffered = true;
		base.Name = "BitmapPreview";
		base.Size = new Size(333, 324);
		base.Load += this.BitmapPreview_Load;
		base.MouseDown += this.BitmapPreview_MouseDown;
		base.MouseMove += this.BitmapPreview_MouseMove;
		base.KeyPress += this.BitmapPreview_KeyPress;
		base.Paint += this.BitmapPreview_Paint;
		base.MouseLeave += this.BitmapPreview_MouseLeave;
		base.MouseUp += this.BitmapPreview_MouseUp;
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((ISupportInitialize)this.tbZoom).EndInit();
		base.ResumeLayout(false);
	}

	public BitmapPreview(ArkEntry gclass126_0, List<GClass109> list_0)
	{
		this.InitializeComponent();
		if (gclass126_0.method_5().CompareTo("bmp") != 0 && gclass126_0.method_5().CompareTo("png") != 0)
		{
			this.method_0(gclass126_0.method_8(), list_0);
			return;
		}
		GStream2 gstream = gclass126_0.method_9();
		this.bitmap_0 = new Bitmap(gstream);
		gstream.Close();
	}

	public BitmapPreview(byte[] byte_0, List<GClass109> list_0)
	{
		this.InitializeComponent();
		this.method_0(byte_0, list_0);
	}

	void method_0(byte[] byte_0, List<GClass109> list_0)
	{
		byte b = byte_0[1];
		int num = (int)byte_0[7] | (int)byte_0[8] << 8;
		int num2 = (int)byte_0[9] | (int)byte_0[10] << 8;
		list_0.Add(new GClass109("Width", num));
		list_0.Add(new GClass109("Height", num2));
		list_0.Add(new GClass109("BitsPerPixel", b));
		this.bitmap_0 = new Bitmap(num, num2, PixelFormat.Format32bppArgb);
		Color[] array = new Color[1 << (int)b];
		int num3 = 32;
		if (b < 16)
		{
			for (int i = 0; i < 1 << (int)b; i++)
			{
				int num4 = 32 + i * 4;

                // NEW: Adds alpha channel
                int alpha = byte_0[num4 + 3];
                if (alpha >= 0x80) alpha = 0xFF;
                else alpha = alpha << 1;

                array[i] = Color.FromArgb(alpha, (int)byte_0[num4], (int)byte_0[num4 + 1], (int)byte_0[num4 + 2]);
			}
			if (b == 8)
			{
				for (int j = 0; j < 1 << (int)b; j++)
				{
					if ((j & 24) == 8)
					{
						Color color = array[j];
						array[j] = array[j + 8];
						array[j + 8] = color;
					}
				}
			}
			num3 += 4 << (int)b;
		}
		BitmapData bitmapData = this.bitmap_0.LockBits(new Rectangle(0, 0, num, num2), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
		int num5 = num * num2 * (int)b >> 3;
		byte b2 = b;
		if (b2 <= 8)
		{
			if (b2 == 4)
			{
				int[] array2 = new int[num * num2];
				for (int k = 0; k < num5; k++)
				{
					byte b3 = byte_0[num3 + k];
					array2[k * 2] = array[(int)(b3 & 15)].ToArgb();
					array2[k * 2 + 1] = array[b3 >> 4].ToArgb();
				}
				Marshal.Copy(array2, 0, bitmapData.Scan0, array2.Length);
				goto IL_2B9;
			}
			if (b2 == 8)
			{
				int[] array3 = new int[num * num2];
				for (int l = 0; l < num5; l++)
				{
					array3[l] = array[(int)byte_0[num3 + l]].ToArgb();
				}
				Marshal.Copy(array3, 0, bitmapData.Scan0, array3.Length);
				goto IL_2B9;
			}
		}
		else
		{
			if (b2 == 16)
			{
				int[] array4 = new int[num * num2];
				for (int m = 0; m < num5; m += 2)
				{
					ushort num6 = (ushort)((int)byte_0[num3 + m] | (int)byte_0[num3 + m + 1] << 8);
					array4[m / 2] = Color.FromArgb((int)(num6 & 31), num6 >> 5 & 63, num6 >> 11 & 31).ToArgb();
				}
				Marshal.Copy(array4, 0, bitmapData.Scan0, array4.Length);
				goto IL_2B9;
			}
			if (b2 == 24)
			{
				Marshal.Copy(byte_0, num3, bitmapData.Scan0, num5);
				goto IL_2B9;
			}
		}
		throw new Exception("Unhandled pixel format");
		IL_2B9:
		this.bitmap_0.UnlockBits(bitmapData);
	}

	void BitmapPreview_Paint(object sender, PaintEventArgs e)
	{
		Size size = new Size(this.bitmap_0.Width * this.int_0 / 100, this.bitmap_0.Height * this.int_0 / 100);
		Point pt = this.point_0;
		if (this.bool_0)
		{
			pt = Point.Add(pt, this.size_0);
		}
		Point point = new Point(pt.X * 100 / 100, pt.Y * 100 / 100);
		e.Graphics.DrawImage(this.bitmap_0, base.ClientSize.Width / 2 - size.Width / 2 + point.X, base.ClientSize.Height / 2 - size.Height / 2 + point.Y, size.Width, size.Height);
	}

	void BitmapPreview_Load(object sender, EventArgs e)
	{
	}

	void method_1(object sender, PaintEventArgs e)
	{
	}

	void BitmapPreview_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	void tbZoom_ValueChanged(object sender, EventArgs e)
	{
		this.int_0 = this.tbZoom.Value;
		this.lZoom.Text = this.int_0.ToString() + "%";
		base.Invalidate();
	}

	void BitmapPreview_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && this.bool_0)
		{
			this.size_0 = new Size(e.Location.X - this.point_1.X, e.Location.Y - this.point_1.Y);
			base.Invalidate();
		}
	}

	void BitmapPreview_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			this.bool_0 = true;
			this.point_1 = e.Location;
		}
	}

	void BitmapPreview_MouseUp(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && this.bool_0)
		{
			this.bool_0 = false;
			this.point_0 = Point.Add(this.point_0, this.size_0);
		}
	}

	void BitmapPreview_MouseLeave(object sender, EventArgs e)
	{
		if (this.bool_0)
		{
			this.bool_0 = false;
			base.Invalidate();
		}
	}

	IContainer icontainer_0;

	Panel panel1;

	TrackBar tbZoom;

	Label lZoom;

	Bitmap bitmap_0;

	int int_0 = 100;

	Point point_0 = default(Point);

	bool bool_0;

	Point point_1 = default(Point);

	Size size_0 = default(Size);
}
