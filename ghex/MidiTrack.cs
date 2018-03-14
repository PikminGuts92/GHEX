using System;
using System.Collections.Generic;

public abstract class MidiTrack
{
	public MidiTrack(MidiFile parent)
	{
		this.events = new List<MidiEvent>();
		this.parent = parent;
	}

	public MidiTrack(MidiFile parent, string string_1) : this(parent)
	{
		this.string_0 = string_1;
	}

	public MidiFile Parent()
	{
		return this.parent;
	}

	public string method_1()
	{
		return this.string_0;
	}

	public void method_2(string string_1)
	{
		this.string_0 = string_1;
	}

	public List<MidiEvent> Events()
	{
		return this.events;
	}

	public abstract void vmethod_0(List<MidiEvent> list_1);

	public abstract void vmethod_1(List<MidiEvent> list_1);

	protected void method_4(MidiEvent gclass139_0, int int_0, List<MidiEvent> list_1)
	{
		list_1.Add(new GClass143
		{
			int_0 = gclass139_0.int_0,
			bool_0 = true,
			byte_0 = (byte)int_0,
			byte_1 = 100
		});
		if (gclass139_0.vmethod_0() > 0)
		{
			list_1.Add(new GClass143
			{
				int_0 = gclass139_0.int_0 + gclass139_0.vmethod_0(),
				bool_0 = false,
				byte_0 = (byte)int_0,
				byte_1 = 0
			});
		}
	}

	internal static List<MidiEvent> smethod_0(List<MidiEvent> list_1, int int_0, int int_1, GEnum63 genum63_0)
	{
		int num = int_0 + int_1;
		List<MidiEvent> list = new List<MidiEvent>(list_1.Count);
		foreach (MidiEvent gclass in list_1)
		{
			GEnum63 genum = gclass.vmethod_2();
			if (genum == genum63_0 || genum63_0 == GEnum63.const_9)
			{
				int num2 = gclass.int_0 + gclass.vmethod_0();
				if (gclass.int_0 >= int_0 && gclass.int_0 < num)
				{
					list.Add(gclass);
				}
				else if (num2 >= int_0 && num2 <= num)
				{
					list.Add(gclass);
				}
				else if (gclass.int_0 < int_0 && num2 >= num)
				{
					list.Add(gclass);
				}
			}
		}
		return list;
	}

	public List<MidiEvent> method_5(int int_0, int int_1, GEnum63 genum63_0)
	{
		return MidiTrack.smethod_0(this.events, int_0, int_1, genum63_0);
	}

	public List<MidiEvent> method_6(int int_0, int int_1)
	{
		return MidiTrack.smethod_0(this.events, int_0, int_1, GEnum63.const_9);
	}

	public override string ToString()
	{
		return this.method_1();
	}

	MidiFile parent;

	string string_0;

	List<MidiEvent> events;
}
