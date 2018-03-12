using System;
using System.Collections.Generic;

public class GClass36 : GClass34
{
	public GClass36(GClass136 gclass136_1) : base(gclass136_1)
	{
	}

	double method_19(int int_0)
	{
		GClass117 gclass = null;
		GClass116 gclass2 = null;
		foreach (GClass114 gclass3 in base.method_1())
		{
			if (gclass2 == null && gclass3 is GClass116)
			{
				gclass2 = (gclass3 as GClass116);
			}
			else if (gclass == null && gclass3 is GClass117)
			{
				gclass = (gclass3 as GClass117);
			}
			if (gclass != null && gclass2 != null)
			{
				break;
			}
		}
		double num = 0.0;
		int num2 = 0;
		foreach (GClass114 gclass4 in base.method_1())
		{
			GClass116 gclass5 = gclass4 as GClass116;
			if (gclass5 != null)
			{
				if (gclass4.method_2() >= int_0)
				{
					break;
				}
				int num3 = gclass4.method_2() - num2;
				double num4 = (double)num3 * (double)gclass2.method_10() / (double)((float)base.method_0().method_9() * 1000000f);
				num += num4;
				gclass2 = gclass5;
				num2 = gclass4.method_2();
			}
		}
		int num5 = int_0 - num2;
		double num6 = (double)num5 * (double)gclass2.method_10() / (double)((float)base.method_0().method_9() * 1000000f);
		num += num6;
		return num;
	}

	public double method_20(int int_0)
	{
		GClass151 gclass = null;
		foreach (GClass151 gclass2 in this.list_1)
		{
			if (int_0 >= gclass2.int_1 && int_0 < gclass2.int_1 + base.method_0().method_9())
			{
				gclass = gclass2;
				break;
			}
		}
		if (gclass == null)
		{
			gclass = this.list_1[this.list_1.Count - 1];
		}
		int num = gclass.int_1;
		double num2 = gclass.double_0;
		GClass116 gclass3 = gclass.list_0[0];
		foreach (GClass116 gclass4 in gclass.list_0)
		{
			if (gclass4.method_2() >= num)
			{
				if (gclass4.method_2() >= int_0)
				{
					break;
				}
				int num3 = gclass4.method_2() - num;
				double num4 = (double)(num3 * gclass3.method_10()) / ((double)base.method_0().method_9() * 1000000.0);
				num2 += num4;
				gclass3 = gclass4;
				num = gclass4.method_2();
			}
		}
		int num5 = int_0 - num;
		double num6 = (double)(num5 * gclass3.method_10()) / ((double)base.method_0().method_9() * 1000000.0);
		num2 += num6;
		return num2;
	}

	int method_21(double double_0)
	{
		GClass117 gclass = null;
		GClass116 gclass2 = null;
		foreach (GClass114 gclass3 in base.method_1())
		{
			if (gclass2 == null && gclass3 is GClass116)
			{
				gclass2 = (gclass3 as GClass116);
			}
			else if (gclass == null && gclass3 is GClass117)
			{
				gclass = (gclass3 as GClass117);
			}
			if (gclass != null && gclass2 != null)
			{
				break;
			}
		}
		double num = 0.0;
		int num2 = 0;
		foreach (GClass114 gclass4 in base.method_1())
		{
			int num3 = gclass4.method_2() - num2;
			GClass116 gclass5 = gclass4 as GClass116;
			if (gclass5 != null)
			{
				double num4 = (double)num3 * (double)gclass2.method_10() / (double)((float)base.method_0().method_9() * 1000000f);
				if (num + num4 >= double_0)
				{
					break;
				}
				num += num4;
				gclass2 = gclass5;
				num2 = gclass4.method_2();
			}
			int num5 = gclass4.method_2();
		}
		double num6 = double_0 - num;
		double num7 = num6 * (double)base.method_0().method_9() * 1000000.0 / (double)gclass2.method_10();
		return num2 + (int)num7;
	}

	public int method_22(double double_0)
	{
		GClass151 gclass = null;
		foreach (GClass151 gclass2 in this.list_1)
		{
			if (double_0 >= gclass2.double_0 && double_0 < gclass2.double_1)
			{
				gclass = gclass2;
				break;
			}
		}
		if (gclass == null)
		{
			gclass = this.list_1[this.list_1.Count - 1];
		}
		GClass116 gclass3 = gclass.list_0[0];
		double num = gclass.double_0;
		int num2 = gclass.int_1;
		foreach (GClass116 gclass4 in gclass.list_0)
		{
			if (gclass4.method_2() > num2)
			{
				int num3 = gclass4.method_2() - num2;
				double num4 = (double)(num3 * gclass3.method_10()) / ((double)base.method_0().method_9() * 1000000.0);
				if (num + num4 >= double_0)
				{
					break;
				}
				num += num4;
				gclass3 = gclass4;
				num2 = gclass4.method_2();
			}
		}
		double num5 = double_0 - num;
		double num6 = num5 * (double)base.method_0().method_9() * 1000000.0 / (double)gclass3.method_10();
		num2 += (int)(num6 + 0.5);
		return num2;
	}

	public List<GClass151> method_23()
	{
		return this.list_1;
	}

	internal void method_24(int int_0)
	{
		this.list_1.RemoveRange(int_0, this.list_1.Count - int_0);
		if (int_0 != 0)
		{
			throw new NotImplementedException("jfk");
		}
		int num = base.method_0().method_5();
		int i = 0;
		IL_1BA:
		while (i <= num)
		{
			GClass151 gclass = new GClass151();
			gclass.int_0 = this.list_1.Count;
			gclass.int_1 = i;
			gclass.double_0 = this.method_19(i);
			gclass.double_1 = this.method_19(i + base.method_0().method_9());
			gclass.list_0 = new List<GClass116>();
			int num2 = base.method_1().Count - 1;
			for (int j = base.method_1().Count - 1; j >= 0; j--)
			{
				GClass114 gclass2 = base.method_1()[j];
				if (gclass2.method_2() <= gclass.int_1)
				{
					if (gclass2 is GClass116)
					{
						gclass.list_0.Insert(0, gclass2 as GClass116);

						for (int k = num2; k >= 0; k--)
						{
							GClass114 gclass3 = base.method_1()[k];
							if (gclass3.method_2() <= gclass.int_1 && gclass3 is GClass117)
							{
								if ((gclass.int_1 - gclass3.method_2()) % ((1 << (int)(gclass3 as GClass117).method_16()) * base.method_0().method_9()) == 0)
								{
									gclass.genum66_0 |= GEnum66.const_0;
								}

								this.list_1.Add(gclass);
								i += base.method_0().method_9();
								goto IL_1BA;
							}
						}

                        this.list_1.Add(gclass);
                        i += base.method_0().method_9();
                        goto IL_1BA;
                    }
				}
				else if (gclass2.method_2() < gclass.int_1 + base.method_0().method_9())
				{
					num2 = j;
					if (gclass2 is GClass116)
					{
						gclass.list_0.Insert(0, gclass2 as GClass116);
					}
				}
			}

            for (int k = num2; k >= 0; k--)
            {
                GClass114 gclass3 = base.method_1()[k];
                if (gclass3.method_2() <= gclass.int_1 && gclass3 is GClass117)
                {
                    if ((gclass.int_1 - gclass3.method_2()) % ((1 << (int)(gclass3 as GClass117).method_16()) * base.method_0().method_9()) == 0)
                    {
                        gclass.genum66_0 |= GEnum66.const_0;
                    }

                    this.list_1.Add(gclass);
                    i += base.method_0().method_9();
                    goto IL_1BA;
                }
            }

            this.list_1.Add(gclass);
            i += base.method_0().method_9();
            goto IL_1BA;
        }
	}

	protected override void vmethod_0(GClass114 gclass114_0, GEnum5 genum5_0)
	{
		this.method_24(0);
		base.vmethod_0(gclass114_0, genum5_0);
	}

	List<GClass151> list_1 = new List<GClass151>(100);
}
