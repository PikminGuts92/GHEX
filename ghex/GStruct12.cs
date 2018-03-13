using System;

public struct GStruct12
{
	public GStruct12(string string_1, GEnum15 genum15_1, object object_1)
	{
		this.string_0 = string_1;
		this.genum15_0 = genum15_1;
		switch (genum15_1)
		{
		case GEnum15.const_0:
			this.object_0 = (uint)object_1;
			return;
		case GEnum15.const_1:
			this.object_0 = (string)object_1;
			return;
		case GEnum15.const_2:
			this.object_0 = (byte[])object_1;
			return;
		case GEnum15.const_3:
			this.object_0 = (bool)object_1;
			return;
		case GEnum15.const_4:
			this.object_0 = (ulong)object_1;
			return;
		case GEnum15.const_5:
			this.object_0 = (ushort)object_1;
			return;
		case GEnum15.const_6:
			this.object_0 = (Guid)object_1;
			return;
		default:
			throw new ArgumentException("Invalid data type", "type");
		}
	}

	public override string ToString()
	{
		return string.Format("{0} = {1}", this.string_0, this.object_0);
	}

	public string method_0()
	{
		return this.string_0;
	}

	public GEnum15 method_1()
	{
		return this.genum15_0;
	}

	public object method_2()
	{
		return this.object_0;
	}

	public void method_3(object object_1)
	{
		switch (this.genum15_0)
		{
		case GEnum15.const_0:
			this.object_0 = (uint)object_1;
			return;
		case GEnum15.const_1:
			this.object_0 = (string)object_1;
			return;
		case GEnum15.const_2:
			this.object_0 = (byte[])object_1;
			return;
		case GEnum15.const_3:
			this.object_0 = (bool)object_1;
			return;
		case GEnum15.const_4:
			this.object_0 = (ulong)object_1;
			return;
		case GEnum15.const_5:
			this.object_0 = (ushort)object_1;
			return;
		case GEnum15.const_6:
			this.object_0 = (Guid)object_1;
			return;
		default:
			return;
		}
	}

	public static string smethod_0(GStruct12 gstruct12_0)
	{
		if (gstruct12_0.genum15_0 == GEnum15.const_1)
		{
			return (string)gstruct12_0.object_0;
		}
		throw new InvalidCastException();
	}

	public static bool smethod_1(GStruct12 gstruct12_0)
	{
		if (gstruct12_0.genum15_0 == GEnum15.const_3)
		{
			return (bool)gstruct12_0.object_0;
		}
		throw new InvalidCastException();
	}

	public static Guid smethod_2(GStruct12 gstruct12_0)
	{
		if (gstruct12_0.genum15_0 == GEnum15.const_6)
		{
			return (Guid)gstruct12_0.object_0;
		}
		throw new InvalidCastException();
	}

	public static byte[] smethod_3(GStruct12 gstruct12_0)
	{
		if (gstruct12_0.genum15_0 == GEnum15.const_2)
		{
			return (byte[])gstruct12_0.object_0;
		}
		throw new InvalidCastException();
	}

	public static ulong smethod_4(GStruct12 gstruct12_0)
	{
		GEnum15 genum = gstruct12_0.genum15_0;
		if (genum != GEnum15.const_0)
		{
			switch (genum)
			{
			case GEnum15.const_4:
			case GEnum15.const_5:
				break;
			default:
				throw new InvalidCastException();
			}
		}
		return (ulong)gstruct12_0.object_0;
	}

	public static long smethod_5(GStruct12 gstruct12_0)
	{
		return (long)GStruct12.smethod_4(gstruct12_0);
	}

	public static int smethod_6(GStruct12 gstruct12_0)
	{
		return (int)GStruct12.smethod_4(gstruct12_0);
	}

	public static uint smethod_7(GStruct12 gstruct12_0)
	{
		return (uint)GStruct12.smethod_4(gstruct12_0);
	}

	public static ushort smethod_8(GStruct12 gstruct12_0)
	{
		return (ushort)GStruct12.smethod_4(gstruct12_0);
	}

	GEnum15 genum15_0;

	object object_0;

	string string_0;
}
