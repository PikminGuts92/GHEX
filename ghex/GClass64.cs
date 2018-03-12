using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;

public class GClass64 : IDisposable
{
	public GClass64(GClass71 gclass71_1, int int_1)
	{
		this.gclass71_0 = gclass71_1;
		this.int_0 = int_1;
		this.brush_0 = Brushes.White;
		this.pen_0 = Pens.Black;
		this.pen_1 = Pens.Blue;
	}

	public void Dispose()
	{
		this.dictionary_0.Clear();
		this.brush_0.Dispose();
		this.pen_0.Dispose();
		this.pen_1.Dispose();
	}

	GClass64.GClass65[] method_0(double double_0, double double_1)
	{
		float num = (float)((double)this.gclass71_0.method_7() * double_1);
		long num2 = (long)num;
		long num3 = this.gclass71_0.method_9();
		float num4 = 32767f;
		float num5 = -32768f;
		List<GClass64.GClass65> list = new List<GClass64.GClass65>(10);
		double num6 = (double)(1000 * this.gclass71_0.method_7()) * double_1;
		GClass64.GClass65 gclass = new GClass64.GClass65();
		gclass.graphicsPath_0 = new GraphicsPath();
		gclass.graphicsPath_0.StartFigure();
		int num7 = 0;
		this.gclass71_0.method_7();
		double num8 = (double)this.gclass71_0.method_7() * double_0;
		double num9 = num8;
		double num10 = (double)((float)num2 / num);
		float[] array = new float[28];
		long num11 = -1L;
		while ((long)(num8 + 0.0) < num3)
		{
			int num12 = (int)(num8 + 0.0) % 28;
			long num13 = (long)((int)(num8 + 0.0) / 28);
			if (num12 == 0 && num13 != num11)
			{
				this.gclass71_0.method_11(num13, array, 0L);
				num11 = num13;
			}
			float val = array[num12];
			if (num8 - num9 < (double)num2)
			{
				num4 = Math.Min(val, num4);
				num5 = Math.Max(val, num5);
			}
			else
			{
				num4 = (num4 + 32768f) * (float)this.int_0 / 65536f;
				num5 = (num5 + 32768f) * (float)this.int_0 / 65536f;
				int num14 = (int)(num8 / (double)num);
				gclass.graphicsPath_0.AddLine((float)num14, num4, (float)num14, num5);
				if ((int)(num9 / num6) != (int)(num8 / num6))
				{
					list.Add(gclass);
					gclass = new GClass64.GClass65();
					gclass.graphicsPath_0 = new GraphicsPath();
					gclass.graphicsPath_0.StartFigure();
				}
				num9 = num8;
				num4 = 32767f;
				num5 = -32768f;
				num7++;
			}
			num8 += num10;
		}
		if (gclass.graphicsPath_0.PointCount > 0)
		{
			list.Add(gclass);
		}
		return list.ToArray();
	}

	public GClass64.GClass65[] method_1(double double_0, EventHandler eventHandler_0)
	{
		EventHandler eventHandler = null;
		GClass64.Class23 @class = new GClass64.Class23();
		@class.double_0 = double_0;
		@class.eventHandler_0 = eventHandler_0;
		@class.gclass64_0 = this;
		if (!this.dictionary_0.ContainsKey(@class.double_0))
		{
			GClass64.Class24 class2 = new GClass64.Class24();
			class2.class23_0 = @class;
			class2.class22_0 = new GClass64.Class22();
			GClass64.Class22 class22_ = class2.class22_0;
			if (eventHandler == null)
			{
				eventHandler = new EventHandler(@class.method_0);
			}
			class22_.method_0(eventHandler);
			class2.class22_0.thread_0 = new Thread(new ThreadStart(class2.method_0));
			this.dictionary_0.Add(@class.double_0, class2.class22_0);
			class2.class22_0.thread_0.Start();
			return null;
		}
		return this.dictionary_0[@class.double_0].gclass65_0;
	}

	Dictionary<double, GClass64.Class22> dictionary_0 = new Dictionary<double, GClass64.Class22>(4);

	GClass71 gclass71_0;

	int int_0;

	Brush brush_0;

	Pen pen_0;

	Pen pen_1;

	public class GClass65
	{
		public GraphicsPath graphicsPath_0;
	}

	class Class22
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void method_0(EventHandler eventHandler_1)
		{
			this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void method_1(EventHandler eventHandler_1)
		{
			this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
		}

		public void method_2()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this.gclass65_0, EventArgs.Empty);
			}
		}

		public Thread thread_0;

		public GClass64.GClass65[] gclass65_0;

		EventHandler eventHandler_0;
	}

	[CompilerGenerated]
	sealed class Class23
	{
		public void method_0(object sender, EventArgs e)
		{
			this.eventHandler_0(sender, e);
		}

		public GClass64 gclass64_0;

		public double double_0;

		public EventHandler eventHandler_0;
	}

	[CompilerGenerated]
	sealed class Class24
	{
		public void method_0()
		{
			this.class22_0.gclass65_0 = this.class23_0.gclass64_0.method_0(0.0, this.class23_0.double_0);
			this.class22_0.method_2();
		}

		public GClass64.Class23 class23_0;

		public GClass64.Class22 class22_0;
	}
}
