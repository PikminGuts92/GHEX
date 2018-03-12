using System;
using System.Collections.Generic;
using System.Reflection;

[DefaultMember("Item")]
class Class60
{
	public Dictionary<string, string> method_0()
	{
		return this.dictionary_0;
	}

	public string method_1(string string_0)
	{
		if (this.dictionary_0.ContainsKey(string_0))
		{
			return this.dictionary_0[string_0];
		}
		return "";
	}

	public void method_2(string string_0, string string_1)
	{
		this.dictionary_0[string_0] = string_1;
	}

	Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();
}
