using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

class Settings
{
    public Settings()
    {
        Class109.smethod_14(Color.White);
    }

    public static Settings smethod_0()
    {
        return Settings.class61_0;
    }

    public string method_0()
    {
        return Application.UserAppDataPath.Substring(0, Application.UserAppDataPath.LastIndexOf('\\')) + "\\Settings.xml";
    }

    public void method_1()
    {
        if (!File.Exists(this.method_0()))
        {
            this.string_0 = Application.ProductVersion;
            return;
        }
        XmlDocument xmlDocument = new XmlDocument();
        try
        {
            xmlDocument.Load(this.method_0());
        }
        catch
        {
            try
            {
                if (File.Exists(this.method_0() + ".bak"))
                {
                    xmlDocument.Load(this.method_0() + ".bak");
                }
            }
            catch
            {
            }
        }
        if (xmlDocument["Settings"] == null)
        {
            return;
        }
        foreach (object obj in xmlDocument["Settings"].ChildNodes)
        {
            XmlNode xmlNode = (XmlNode)obj;
            string name;
            if ((name = xmlNode.Name) != null)
            {
                if (!(name == "ArchiveSource"))
                {
                    if (!(name == "WindowRect"))
                    {
                        if (!(name == "AlertVersion"))
                        {
                            if (name == "PreviousDir")
                            {
                                this.class60_0.method_2(xmlNode.Attributes["Name"].Value, xmlNode.Attributes["Path"].Value);
                            }
                        }
                        else
                        {
                            this.string_0 = xmlNode.Attributes["New"].Value;
                        }
                    }
                    else
                    {
                        this.sortedList_0.Add(xmlNode.Attributes["Name"].Value, new Rectangle(int.Parse(xmlNode.Attributes["X"].Value), int.Parse(xmlNode.Attributes["Y"].Value), int.Parse(xmlNode.Attributes["Width"].Value), int.Parse(xmlNode.Attributes["Height"].Value)));
                    }
                }
                else
                {
                    ulong ulong_ = 0UL;
                    if (xmlNode.Attributes["Verified"] != null)
                    {
                        ulong.TryParse(xmlNode.Attributes["Verified"].Value, out ulong_);
                    }
                    this.class59_0.Add(new Class58(xmlNode.Attributes["Path"].Value, bool.Parse(xmlNode.Attributes["Active"].Value), ulong_));
                }
            }
        }
    }

    public void method_2()
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml("<Settings/>");
        XmlNode xmlNode = xmlDocument["Settings"];
        foreach (Class58 @class in this.class59_0)
        {
            XmlElement xmlElement = xmlDocument.CreateElement("ArchiveSource");
            xmlElement.SetAttribute("Path", @class.string_0);
            xmlElement.SetAttribute("Active", @class.bool_0.ToString());
            xmlElement.SetAttribute("Verified", @class.ulong_0.ToString());
            xmlNode.AppendChild(xmlElement);
        }
        foreach (KeyValuePair<string, Rectangle> keyValuePair in this.sortedList_0)
        {
            XmlElement xmlElement2 = xmlDocument.CreateElement("WindowRect");
            xmlElement2.SetAttribute("Name", keyValuePair.Key);
            xmlElement2.SetAttribute("X", keyValuePair.Value.X.ToString());
            xmlElement2.SetAttribute("Y", keyValuePair.Value.Y.ToString());
            xmlElement2.SetAttribute("Width", keyValuePair.Value.Width.ToString());
            xmlElement2.SetAttribute("Height", keyValuePair.Value.Height.ToString());
            xmlNode.AppendChild(xmlElement2);
        }
        if (this.string_0.Length > 0 && Application.ProductVersion.CompareTo(this.string_0) != 0)
        {
            XmlElement xmlElement3 = xmlDocument.CreateElement("AlertVersion");
            xmlElement3.SetAttribute("Old", Application.ProductVersion);
            xmlElement3.SetAttribute("New", this.string_0);
            xmlNode.AppendChild(xmlElement3);
        }
        foreach (KeyValuePair<string, string> keyValuePair2 in this.class60_0.method_0())
        {
            XmlElement xmlElement4 = xmlDocument.CreateElement("PreviousDir");
            xmlElement4.SetAttribute("Name", keyValuePair2.Key);
            xmlElement4.SetAttribute("Path", keyValuePair2.Value);
            xmlNode.AppendChild(xmlElement4);
        }
        if (File.Exists(this.method_0()))
        {
            if (File.Exists(this.method_0() + ".bak"))
            {
                File.Delete(this.method_0() + ".bak");
            }
            File.Move(this.method_0(), this.method_0() + ".bak");
        }
        xmlDocument.Save(this.method_0());
    }

    public Class59 method_3()
    {
        return this.class59_0;
    }

    public SortedList<string, Rectangle> method_4()
    {
        return this.sortedList_0;
    }

    public Class57 method_5()
    {
        return this.class57_0;
    }

    public string method_6()
    {
        return this.string_0;
    }

    public void method_7(string string_1)
    {
        this.string_0 = string_1;
    }

    public Class60 method_8()
    {
        return this.class60_0;
    }

    static Settings class61_0 = new Settings();

    Class59 class59_0 = new Class59();

    SortedList<string, Rectangle> sortedList_0 = new SortedList<string, Rectangle>();

    Class57 class57_0 = new Class57();

    string string_0 = "";

    Class60 class60_0 = new Class60();
}
