using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DefaultMember("Item")]
public class GClass72 : IEnumerable<GClass71>
{
	public IEnumerator<GClass71> GetEnumerator()
	{
		return this.list_0.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	public int method_0()
	{
		return this.list_0.Count;
	}

	public GClass71 method_1(int int_0)
	{
		return this.list_0[int_0];
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_2(EventHandler eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(EventHandler eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
	}

	public void method_4(string string_0)
	{
		try
		{
			byte[][] array = null;
			Stream stream = null;
			GClass94 gclass = null;
			int[] array2 = null;
			long[][] array3 = null;
			if (string_0.EndsWith(".wav"))
			{
				GStream1 gstream = new GStream1(string_0);
				if (gstream.method_0().short_0 == 1)
				{
					if (gstream.method_0().short_3 == 16)
					{
						gclass = gstream.method_0();
						stream = gstream;
						goto IL_2AE;
					}
				}
				throw new FileLoadException("Only 16bit PCM formats supported for now");
			}
			if (string_0.EndsWith(".vgs"))
			{
				BinaryReader binaryReader = new BinaryReader(new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				Class39.Struct2 @struct = Class39.smethod_0(binaryReader);
				array = new byte[@struct.struct3_0.Length][];
				array2 = new int[@struct.struct3_0.Length];
				array3 = new long[@struct.struct3_0.Length][];
				for (int i = 0; i < @struct.struct3_0.Length; i++)
				{
					array[i] = new byte[16 * @struct.struct3_0[i].int_1];
					array3[i] = new long[2 * @struct.struct3_0[i].int_1];
					array2[i] = @struct.struct3_0[i].int_0;
				}
				byte[] array4 = new byte[16];
				long[] array5 = new long[@struct.struct3_0.Length];
				long[] array6 = new long[2 * @struct.struct3_0.Length];
				float[] array7 = new float[28];
				while (binaryReader.BaseStream.Read(array4, 0, 16) != 0)
				{
					int num = (int)(array4[1] & 15);
					byte[] array8 = array4;
					int num2 = 1;
					array8[num2] &= 128;
					Array.Copy(array4, 0L, array[num], array5[num] * 16L, 16L);
					GClass80.smethod_3(ref array4, 0L, ref array7, 0L, ref array6[num * 2], ref array6[num * 2 + 1]);
					array3[num][(int)(checked((IntPtr)(unchecked(array5[num] * 2L))))] = array6[num * 2];
					array3[num][(int)(checked((IntPtr)(unchecked(array5[num] * 2L + 1L))))] = array6[num * 2 + 1];
					array5[num] += 1L;
				}
				binaryReader.Close();
			}
			else
			{
				GStream0 gstream2 = new GStream0(string_0);
				if (!bool.Parse(gstream2.method_7("HasAudio")))
				{
					throw new FileLoadException("File doesn't contain audio");
				}
				if (gstream2.method_0().short_3 != 16)
				{
					throw new FileLoadException("Only 16bit streams supported");
				}
				stream = gstream2;
				gclass = gstream2.method_0();
			}
			IL_2AE:
			if (stream != null)
			{
				array2 = new int[(int)gclass.short_1];
				for (int j = 0; j < (int)gclass.short_1; j++)
				{
					array2[j] = gclass.int_0;
				}
				byte[] array9 = new byte[(int)(28 * gclass.short_2)];
				float[] array10 = new float[(int)(28 * gclass.short_1)];
				double[] array11 = new double[(int)(4 * gclass.short_1)];
				long num3 = stream.Length / (long)gclass.short_2;
				if (num3 % 28L != 0L)
				{
					num3 += 28L - num3 % 28L;
				}
				long num4 = (num3 + 27L) / 28L;
				array = new byte[(int)gclass.short_1][];
				array3 = new long[(int)gclass.short_1][];
				long[] array12 = new long[(int)(2 * gclass.short_1)];
				for (int k = 0; k < (int)gclass.short_1; k++)
				{
					array[k] = new byte[16L * num4];
					array3[k] = new long[2L * num4];
				}
				for (long num5 = 0L; num5 < num4; num5 += 1L)
				{
					Array.Clear(array10, 0, array10.Length);
					int num6 = stream.Read(array9, 0, array9.Length);
					int num7 = num6 / (int)gclass.short_2;
					if (num7 == 0)
					{
						break;
					}
					for (int l = 0; l < num7; l++)
					{
						for (int m = 0; m < (int)gclass.short_1; m++)
						{
							int num8 = (l * (int)gclass.short_1 + m) * (int)(gclass.short_3 / 8);
							short num9 = (short)((int)array9[num8 + 1] << 8 | (int)array9[num8]);
							array10[m * 28 + l] = (float)num9;
						}
					}
					for (int n = 0; n < (int)gclass.short_1; n++)
					{
						GClass80.smethod_4(ref array10, (long)(n * 28), ref array[n], num5 * 16L, ref array11[n * 4], ref array11[n * 4 + 1], ref array11[n * 4 + 2], ref array11[n * 4 + 3]);
						GClass80.smethod_3(ref array[n], num5 * 16L, ref array10, 0L, ref array12[n * 2], ref array12[n * 2 + 1]);
						array3[n][(int)(checked((IntPtr)(unchecked(num5 * 2L))))] = array12[n * 2];
						array3[n][(int)(checked((IntPtr)(unchecked(num5 * 2L + 1L))))] = array12[n * 2 + 1];
						if (num5 == num4 - 1L)
						{
							byte[] array13 = array[n];
							IntPtr intPtr = checked((IntPtr)(unchecked(num5 * 16L + 1L)));
							array13[(int)intPtr] = (byte)(array13[(int)intPtr] | 128);
						}
					}
				}
				stream.Dispose();
			}
			int num10 = array2.Length;
			GClass71[] array14 = new GClass71[num10];
			for (int num11 = 0; num11 < num10; num11++)
			{
				GClass71 gclass2 = new GClass71(array[num11], array3[num11], array2[num11]);
				if (num11 > 0)
				{
					array14[num11 - 1].method_2(gclass2);
					if (num11 == num10 - 1)
					{
						gclass2.method_2(array14[0]);
					}
				}
				array14[num11] = gclass2;
			}
			this.list_0.AddRange(array14);
			if (this.eventHandler_0 != null)
			{
				for (int num12 = 0; num12 < num10; num12++)
				{
					this.eventHandler_0(array14[num12], EventArgs.Empty);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(string.Concat(new string[]
			{
				"Could not load '",
				string_0,
				"'\n\n\"",
				ex.Message,
				"\""
			}), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	List<GClass71> list_0 = new List<GClass71>(4);

	EventHandler eventHandler_0;
}
