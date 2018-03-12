using System;
using System.Collections.Generic;

public class GClass88 : GClass87
{
	public GClass88(GClass120 gclass120_1) : this(gclass120_1, "NO NAME")
	{
	}

	public GClass88(GClass120 gclass120_1, string string_1) : base(gclass120_1, string_1)
	{
		this.list_1 = new List<GClass139>[4];
		for (int i = 0; i < 4; i++)
		{
			this.list_1[i] = new List<GClass139>();
		}
	}

	public override void vmethod_1(List<GClass139> list_2)
	{
		GEnum54 genum54_ = base.method_0().method_3();
		foreach (GClass139 gclass in base.method_3())
		{
			GEnum63 genum = gclass.vmethod_2();
			if (genum == GEnum63.const_7)
			{
				base.method_4(gclass, 108, list_2);
			}
			else
			{
				base.method_9(gclass, list_2, genum54_);
			}
		}
		GClass145 gclass2 = new GClass145(this);
		for (int i = 0; i < 4; i++)
		{
			int num = 60 + i * 12;
			int j = 0;
			while (j < this.list_1[i].Count)
			{
				GClass139 gclass3 = this.list_1[i][j];
				switch (gclass3.vmethod_2())
				{
				case GEnum63.const_4:
				{
					if (gclass3.vmethod_0() == 0)
					{
						GClass145 gclass4 = null;
						for (int k = j + 1; k < this.list_1[i].Count; k++)
						{
							GClass139 gclass5 = this.list_1[i][k];
							if (gclass5.vmethod_2() == GEnum63.const_4)
							{
								gclass4 = (gclass5 as GClass145);

								int num2 = base.method_0().method_1() / 3;
								if (gclass4 != null)
								{
									num2 = Math.Min(gclass4.int_0 - gclass3.int_0, num2);
								}
								using (List<GEnum51>.Enumerator enumerator2 = (gclass3 as GClass145).list_0.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										GEnum51 genum2 = enumerator2.Current;
										gclass2.int_0 = gclass3.int_0;
										gclass2.vmethod_1(num2);
										base.method_4(gclass2, (int)(num + genum2), list_2);
									}
									goto IL_229;
								}
							}
						}

                        int num2_0 = base.method_0().method_1() / 3;
                        if (gclass4 != null)
                        {
                                    num2_0 = Math.Min(gclass4.int_0 - gclass3.int_0, num2_0);
                        }
                        using (List<GEnum51>.Enumerator enumerator2 = (gclass3 as GClass145).list_0.GetEnumerator())
                        {
                            while (enumerator2.MoveNext())
                            {
                                GEnum51 genum2 = enumerator2.Current;
                                gclass2.int_0 = gclass3.int_0;
                                gclass2.vmethod_1(num2_0);
                                base.method_4(gclass2, (int)(num + genum2), list_2);
                            }
                            goto IL_229;
                        }
                    }

					GClass145 gclass6 = gclass3 as GClass145;
					if (gclass6.bool_0)
					{
						using (List<GEnum51>.Enumerator enumerator3 = gclass6.list_0.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								GEnum51 genum3 = enumerator3.Current;
								base.method_4(gclass6, (int)(num + genum3), list_2);
							}
							break;
						}
						goto IL_1F4;
					}
					break;
				}
				case GEnum63.const_5:
					goto IL_1F4;
				case GEnum63.const_6:
					base.method_4(gclass3, num + 9 + (gclass3 as GClass147).int_1, list_2);
					break;
				default:
					throw new NotImplementedException(gclass3.vmethod_2().ToString());
				}
				IL_229:
				j++;
				continue;
				IL_1F4:
				base.method_4(gclass3, num + 7, list_2);
				goto IL_229;
			}
		}
	}

	public override void vmethod_0(List<GClass139> list_2)
	{
		GEnum54 genum = base.method_0().method_3();
		for (int i = 0; i < 4; i++)
		{
			this.list_1[i].Capacity = list_2.Count;
		}
		List<GClass139> list = new List<GClass139>();
		int num = (genum == GEnum54.const_1) ? 40 : (base.method_0().method_1() / 16);
		for (int j = 0; j < list_2.Count; j++)
		{
			GClass139 gclass = list_2[j];
			if (gclass.vmethod_2() == GEnum63.const_3)
			{
				GClass143 gclass2 = (GClass143)gclass;
				if (gclass2.byte_0 >= 60 && gclass2.byte_0 < 108)
				{
					int num2 = (int)((gclass2.byte_0 - 60) / 12);
					int num3 = (int)((gclass2.byte_0 - 60) % 12);
					if (num3 < 5)
					{
						if (gclass2.bool_0 && gclass2.byte_1 > 0)
						{
							GClass143 gclass3 = null;
							for (int k = j + 1; k < list_2.Count; k++)
							{
								GClass139 gclass4 = list_2[k];
								if (gclass4.vmethod_2() == GEnum63.const_3 && ((GClass143)gclass4).byte_0 == gclass2.byte_0)
								{
									gclass3 = (GClass143)gclass4;

									bool bool_ = true;
									int num4 = 0;
									if (gclass3 != null)
									{
										num4 = gclass3.int_0 - gclass2.int_0;
										if (gclass3.bool_0 && (!gclass3.bool_0 || gclass3.byte_1 != 0))
										{
											if (num4 < num)
											{
												bool_ = false;
											}
											if (num4 < base.method_0().method_1() / 3)
											{
												num4 = 0;
											}
										}
										else
										{
											list.Add(gclass3);
										}
									}
									gclass2.bool_1 = bool_;
									gclass2.vmethod_1(num4);
									this.list_1[num2].Add(gclass2);
									list.Add(gclass2);
									goto IL_32D;
								}
							}

                            bool bool_0 = true;
                            int num4_0 = 0;
                            if (gclass3 != null)
                            {
                                num4_0 = gclass3.int_0 - gclass2.int_0;
                                if (gclass3.bool_0 && (!gclass3.bool_0 || gclass3.byte_1 != 0))
                                {
                                    if (num4_0 < num)
                                    {
                                        bool_0 = false;
                                    }
                                    if (num4_0 < base.method_0().method_1() / 3)
                                    {
                                        num4_0 = 0;
                                    }
                                }
                                else
                                {
                                    list.Add(gclass3);
                                }
                            }
                            gclass2.bool_1 = bool_0;
                            gclass2.vmethod_1(num4_0);
                            this.list_1[num2].Add(gclass2);
                            list.Add(gclass2);
                            goto IL_32D;
                        }
					}
					else if (num3 == 7)
					{
						if (gclass2.bool_0 && gclass2.byte_1 > 0)
						{
							GClass143 gclass5 = base.method_8(list_2, j + 1, (int)gclass2.byte_0);
							GClass146 gclass6 = new GClass146();
							gclass6.int_0 = gclass2.int_0;
							gclass6.vmethod_1(gclass5.int_0 - gclass2.int_0);
							this.list_1[num2].Add(gclass6);
							list.Add(gclass5);
							list.Add(gclass2);
						}
					}
					else if (num3 >= 9 && gclass2.bool_0 && gclass2.byte_1 > 0)
					{
						GClass143 gclass7 = base.method_8(list_2, j + 1, (int)gclass2.byte_0);
						GClass147 gclass8 = new GClass147();
						gclass8.int_0 = gclass2.int_0;
						gclass8.vmethod_1(gclass7.int_0 - gclass2.int_0);
						gclass8.int_1 = num3 - 9;
						this.list_1[num2].Add(gclass8);
						list.Add(gclass7);
						list.Add(gclass2);
					}
				}
				else if (gclass2.byte_0 == 108 && gclass2.bool_0 && gclass2.byte_1 > 0)
				{
					GClass143 gclass9 = base.method_8(list_2, j + 1, 108);
					GClass148 gclass10 = new GClass148();
					gclass10.int_0 = gclass2.int_0;
					gclass10.vmethod_1(gclass9.int_0 - gclass2.int_0);
					base.method_3().Add(gclass10);
					list.Add(gclass2);
					list.Add(gclass9);
				}
			}
			IL_32D:;
		}
		this.method_11();
		foreach (GClass139 item in list)
		{
			list_2.Remove(item);
		}
		base.vmethod_0(list_2);
	}

	GClass145 method_10(List<GClass143> list_2)
	{
		int num = 0;
		foreach (GClass143 gclass in list_2)
		{
			if (!gclass.bool_1)
			{
				num++;
			}
		}
		GClass145 gclass2 = new GClass145(this);
		gclass2.int_0 = list_2[0].int_0;
		gclass2.vmethod_1(list_2[0].vmethod_0());
		foreach (GClass143 gclass3 in list_2)
		{
			if (gclass3.bool_1 || num >= list_2.Count)
			{
				if (gclass3.int_0 < gclass2.int_0)
				{
					gclass2.int_0 = gclass3.int_0;
					gclass2.vmethod_1(gclass3.vmethod_0());
				}
				if (gclass3.vmethod_0() < gclass2.vmethod_0())
				{
					gclass2.vmethod_1(gclass3.vmethod_0());
				}
				int item = (int)((gclass3.byte_0 - 60) % 12);
				gclass2.list_0.Add((GEnum51)item);
			}
		}
		if (num == list_2.Count)
		{
			gclass2.bool_0 = false;
		}
		return gclass2;
	}

	void method_11()
	{
		List<GClass143> list = new List<GClass143>(5);
		List<GClass145> list2 = new List<GClass145>();
		for (int i = 0; i < 4; i++)
		{
			list2.Clear();
			list.Clear();
			int num = 0;
			foreach (GClass139 gclass in this.list_1[i])
			{
				GClass143 gclass2 = gclass as GClass143;
				if (gclass2 != null)
				{
					int num2 = gclass2.int_0 - num;
					if (num2 >= 8)
					{
						if (list.Count > 0)
						{
							list2.Add(this.method_10(list));
						}
						num = gclass2.int_0;
						list.Clear();
					}
					num2 = gclass2.int_0 - num;
					if (num2 >= 0 && num2 < 8)
					{
						int num3 = (int)((gclass2.byte_0 - 60) % 12);
						if (num3 < 5)
						{
							list.Add(gclass2);
						}
					}
				}
			}
			if (list.Count > 0)
			{
				list2.Add(this.method_10(list));
			}
			this.list_1[i].RemoveAll(new Predicate<GClass139>(this.method_12));
			foreach (GClass145 item in list2)
			{
				this.list_1[i].Add(item);
			}
			this.list_1[i].Sort(new GClass138());
		}
	}

	bool method_12(GClass139 gclass139_0)
	{
		return gclass139_0 is GClass143;
	}

	public List<GClass139> method_13(GEnum53 genum53_0)
	{
		return this.list_1[(int)genum53_0];
	}

	public List<GClass139> method_14(GEnum53 genum53_0, int int_0, int int_1, GEnum63 genum63_0)
	{
		return GClass86.smethod_0(this.list_1[(int)genum53_0], int_0, int_1, genum63_0);
	}

	public List<GClass139> method_15(GEnum53 genum53_0, int int_0, int int_1)
	{
		return GClass86.smethod_0(this.list_1[(int)genum53_0], int_0, int_1, GEnum63.const_9);
	}

	public bool method_16(GClass145 gclass145_0, GClass145 gclass145_1, GEnum54 genum54_0)
	{
		return gclass145_0 != null && (genum54_0 != GEnum54.const_1 || (!gclass145_1.method_1() && !gclass145_0.method_1())) && (!gclass145_1.method_1() && (!gclass145_0.method_1() || !gclass145_0.list_0.Contains(gclass145_1.list_0[0]))) && gclass145_0.list_0[0] != gclass145_1.list_0[0] && gclass145_1.int_0 - gclass145_0.int_0 <= base.method_0().method_1() / 3 && !gclass145_0.method_0();
	}

	public int method_17(GEnum53 genum53_0)
	{
		int num = 0;
		foreach (GClass139 gclass in this.list_1[(int)genum53_0])
		{
			if (gclass.vmethod_2() == GEnum63.const_4)
			{
				GClass145 gclass2 = gclass as GClass145;
				if (gclass2.bool_0)
				{
					num++;
				}
			}
		}
		return num;
	}

	public int method_18(GEnum53 genum53_0)
	{
		int num = 0;
		foreach (GClass139 gclass in this.list_1[(int)genum53_0])
		{
			if (gclass.vmethod_2() == GEnum63.const_4)
			{
				GClass145 gclass2 = (GClass145)gclass;
				if (gclass2.bool_0 && gclass2.method_1())
				{
					num++;
				}
			}
		}
		return num;
	}

	public int method_19(GEnum53 genum53_0)
	{
		int num = 0;
		foreach (GClass139 gclass in this.list_1[(int)genum53_0])
		{
			if (gclass.vmethod_2() == GEnum63.const_4)
			{
				GClass145 gclass2 = (GClass145)gclass;
				if (gclass2.bool_0 && gclass2.method_0())
				{
					num++;
				}
			}
		}
		return num;
	}

	public int method_20(GEnum53 genum53_0)
	{
		int num = 0;
		foreach (GClass139 gclass in this.list_1[(int)genum53_0])
		{
			if (gclass.vmethod_2() == GEnum63.const_4 && !((GClass145)gclass).bool_0)
			{
				num++;
			}
		}
		return num;
	}

	public float method_21(GClass120 gclass120_1, GEnum53 genum53_0)
	{
		float num = 0f;
		foreach (GClass139 gclass in this.list_1[(int)genum53_0])
		{
			if (gclass.vmethod_2() == GEnum63.const_4)
			{
				GClass145 gclass2 = (GClass145)gclass;
				if (gclass2.bool_0)
				{
					float num2 = (float)(50 * gclass2.list_0.Count);
					if (gclass2.method_0())
					{
						num += (float)((int)(num2 * (float)gclass2.vmethod_0() / (float)(2 * gclass120_1.method_1())));
					}
					num += num2;
				}
			}
		}
		return num;
	}

	List<GClass139>[] list_1;
}
