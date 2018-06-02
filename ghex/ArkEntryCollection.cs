using System;
using System.Collections.Generic;

public class ArkEntryCollection : List<ArkEntry>
{
    internal ArkEntryCollection(ArkFile ark)
    {
        this.ark = ark;
    }

    internal ArkFile GetArkFile()
    {
        return this.ark;
    }

    ArkFile ark;
}
