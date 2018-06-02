using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Permissions;

[DefaultMember("Item")]
[Serializable]
class Class59 : List<Class58>
{
    [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
    public virtual void vmethod_0(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
    {
    }

    public bool method_0(string string_0)
    {
        string strB = string_0.Replace('\\', '/');
        foreach (Class58 @class in this)
        {
            if (string.Compare(@class.string_0, strB, true) == 0)
            {
                return true;
            }
        }
        return false;
    }

    public Class58 method_1(string string_0)
    {
        string strB = string_0.Replace('\\', '/');
        foreach (Class58 @class in this)
        {
            if (string.Compare(@class.string_0, strB, true) == 0)
            {
                return @class;
            }
        }
        return null;
    }

    public bool method_2(string string_0)
    {
        string strB = string_0.Replace('\\', '/');
        foreach (Class58 @class in this)
        {
            if (string.Compare(@class.string_0, strB, true) == 0)
            {
                base.Remove(@class);
                return true;
            }
        }
        return false;
    }
}
