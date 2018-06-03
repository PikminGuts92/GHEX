using System;

public class AudioInfo
{
    public AudioInfo(int bitrate, int bits, int channels)
    {
        this.bitrate = bitrate;
        this.bits = bits;
        this.channels = channels;
    }

    public int bitrate;

    public int bits;

    public int channels;
}
