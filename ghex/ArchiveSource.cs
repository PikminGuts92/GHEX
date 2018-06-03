using System;

class ArchiveSource
{
    public ArchiveSource(string path, bool active, ulong verified)
    {
        this.Path = path;
        this.Active = active;
        this.Verified = verified;
    }

    public string Path;

    public bool Active;

    public ulong Verified;
}
