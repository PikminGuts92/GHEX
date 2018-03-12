using System;

class Class87
{
	public bool method_0()
	{
		if (this.bool_0)
		{
			return false;
		}
		foreach (Class87.Class88 @class in this.class88_0)
		{
			if (@class.bool_0)
			{
				return true;
			}
		}
		return false;
	}

	public int int_0;

	public int int_1;

	public long long_0;

	public long long_1;

	public GEnum47 genum47_0;

	public Class87.Class88[] class88_0 = new Class87.Class88[]
	{
		new Class87.Class88(),
		new Class87.Class88(),
		new Class87.Class88()
	};

	public int int_2;

	public int int_3;

	public int int_4;

	public float float_0;

	public int int_5;

	public long long_2;

	public float float_1;

	public bool bool_0;

	public float float_2 = 0.25f;

	public short[] short_0;

	public class Class88
	{
		public float[] float_0;

		public bool bool_0 = true;

		public int int_0;
	}
}
