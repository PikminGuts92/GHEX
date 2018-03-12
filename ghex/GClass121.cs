using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GClass121 : ICollection<GClass122>
{
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate19 gdelegate19_2)
	{
		this.gdelegate19_0 = (GDelegate19)Delegate.Combine(this.gdelegate19_0, gdelegate19_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate19 gdelegate19_2)
	{
		this.gdelegate19_0 = (GDelegate19)Delegate.Remove(this.gdelegate19_0, gdelegate19_2);
	}

	public void Add(GClass122 item)
	{
		if (this.list_0.Contains(item))
		{
			return;
		}
		this.list_0.Add(item);
		if (this.gdelegate19_0 != null)
		{
			this.gdelegate19_0(item);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_2(GDelegate19 gdelegate19_2)
	{
		this.gdelegate19_1 = (GDelegate19)Delegate.Combine(this.gdelegate19_1, gdelegate19_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(GDelegate19 gdelegate19_2)
	{
		this.gdelegate19_1 = (GDelegate19)Delegate.Remove(this.gdelegate19_1, gdelegate19_2);
	}

	public bool Remove(GClass122 item)
	{
		if (!this.list_0.Contains(item))
		{
			return false;
		}
		if (!this.list_0.Remove(item))
		{
			return false;
		}
		if (this.gdelegate19_1 != null)
		{
			this.gdelegate19_1(item);
		}
		return true;
	}

	public void Clear()
	{
		if (this.gdelegate19_1 != null)
		{
			foreach (GClass122 gclass122_ in this.list_0)
			{
				this.gdelegate19_1(gclass122_);
			}
		}
		this.list_0.Clear();
	}

	public bool Contains(GClass122 item)
	{
		return this.list_0.Contains(item);
	}

	public int Count
	{
		get
		{
			return this.list_0.Count;
		}
	}

	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	public IEnumerator<GClass122> GetEnumerator()
	{
		return this.list_0.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	public void CopyTo(GClass122[] array, int arrayIndex)
	{
		this.list_0.CopyTo(array, arrayIndex);
	}

	public void method_4(bool bool_0)
	{
		this.System.Collections.Generic.ICollection<GClass122>.Clear();
	}

	List<GClass122> list_0 = new List<GClass122>();

	GDelegate19 gdelegate19_0;

	GDelegate19 gdelegate19_1;
}
