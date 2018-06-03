using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

class Settings
{
    public static Settings GlobalSettings = new Settings();

    public Settings()
    {
        Class109.smethod_14(Color.White);
    }

    public static Settings GetGlobalSettings() => GlobalSettings;

    public string GetXMLFileLocation()
    {
        return Application.UserAppDataPath.Substring(0, Application.UserAppDataPath.LastIndexOf('\\')) + "\\Settings.xml";
    }

    public void LoadXML()
    {
        if (!File.Exists(this.GetXMLFileLocation()))
        {
            this.productVersion = Application.ProductVersion;
            return;
        }
        XmlDocument xmlDocument = new XmlDocument();
        try
        {
            xmlDocument.Load(this.GetXMLFileLocation());
        }
        catch
        {
            try
            {
                if (File.Exists(this.GetXMLFileLocation() + ".bak"))
                {
                    xmlDocument.Load(this.GetXMLFileLocation() + ".bak");
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
                            this.productVersion = xmlNode.Attributes["New"].Value;
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
                    this.archiveSources.Add(new ArchiveSource(xmlNode.Attributes["Path"].Value, bool.Parse(xmlNode.Attributes["Active"].Value), ulong_));
                }
            }
        }
    }

    public void SaveXML()
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml("<Settings/>");
        XmlNode xmlNode = xmlDocument["Settings"];
        foreach (ArchiveSource @class in this.archiveSources)
        {
            XmlElement xmlElement = xmlDocument.CreateElement("ArchiveSource");
            xmlElement.SetAttribute("Path", @class.Path);
            xmlElement.SetAttribute("Active", @class.Active.ToString());
            xmlElement.SetAttribute("Verified", @class.Verified.ToString());
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
        if (this.productVersion.Length > 0 && Application.ProductVersion.CompareTo(this.productVersion) != 0)
        {
            XmlElement xmlElement3 = xmlDocument.CreateElement("AlertVersion");
            xmlElement3.SetAttribute("Old", Application.ProductVersion);
            xmlElement3.SetAttribute("New", this.productVersion);
            xmlNode.AppendChild(xmlElement3);
        }
        foreach (KeyValuePair<string, string> keyValuePair2 in this.class60_0.method_0())
        {
            XmlElement xmlElement4 = xmlDocument.CreateElement("PreviousDir");
            xmlElement4.SetAttribute("Name", keyValuePair2.Key);
            xmlElement4.SetAttribute("Path", keyValuePair2.Value);
            xmlNode.AppendChild(xmlElement4);
        }
        if (File.Exists(this.GetXMLFileLocation()))
        {
            if (File.Exists(this.GetXMLFileLocation() + ".bak"))
            {
                File.Delete(this.GetXMLFileLocation() + ".bak");
            }
            File.Move(this.GetXMLFileLocation(), this.GetXMLFileLocation() + ".bak");
        }
        xmlDocument.Save(this.GetXMLFileLocation());
    }

    public ArchiveSourceCollection GetSources()
    {
        return this.archiveSources;
    }

    public SortedList<string, Rectangle> method_4()
    {
        return this.sortedList_0;
    }

    public Class57 method_5()
    {
        return this.class57_0;
    }

    public string GetProductVersion()
    {
        return this.productVersion;
    }

    public void SetProductVersion(string newVersion)
    {
        this.productVersion = newVersion;
    }

    public Class60 method_8()
    {
        return this.class60_0;
    }
    
    ArchiveSourceCollection archiveSources = new ArchiveSourceCollection();

    SortedList<string, Rectangle> sortedList_0 = new SortedList<string, Rectangle>();

    Class57 class57_0 = new Class57();

    string productVersion = "";

    Class60 class60_0 = new Class60();
}
