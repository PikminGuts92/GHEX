using System;
using System.IO;
using System.Text;

public class GStream1 : Stream, IDisposable
{
	public WaveFormat method_0()
	{
		return this.gclass94_0;
	}

	string method_1(BinaryReader binaryReader_0)
	{
		byte[] array = new byte[4];
		binaryReader_0.Read(array, 0, array.Length);
		return Encoding.ASCII.GetString(array);
	}

	void method_2()
	{
		BinaryReader binaryReader = new BinaryReader(this.stream_0);
		if (this.method_1(binaryReader) != "RIFF")
		{
			throw new Exception("Invalid file format");
		}
		binaryReader.ReadInt32();
		if (this.method_1(binaryReader) != "WAVE")
		{
			throw new Exception("Invalid file format");
		}
		if (this.method_1(binaryReader) != "fmt ")
		{
			throw new Exception("Invalid file format");
		}
		int num = binaryReader.ReadInt32();
		if (num < 16)
		{
			throw new Exception("Invalid file format");
		}
		this.gclass94_0 = new WaveFormat(22050, 16, 2);
		this.gclass94_0.short_0 = binaryReader.ReadInt16();
		this.gclass94_0.short_1 = binaryReader.ReadInt16();
		this.gclass94_0.int_0 = binaryReader.ReadInt32();
		this.gclass94_0.int_1 = binaryReader.ReadInt32();
		this.gclass94_0.short_2 = binaryReader.ReadInt16();
		this.gclass94_0.short_3 = binaryReader.ReadInt16();
		if (num > 16)
		{
			this.stream_0.Position += (long)(num - 16);
		}
		while (this.stream_0.Position < this.stream_0.Length && this.method_1(binaryReader) != "data")
		{
		}
		if (this.stream_0.Position >= this.stream_0.Length)
		{
			throw new Exception("Invalid file format");
		}
		this.long_1 = (long)binaryReader.ReadInt32();
		this.long_0 = this.stream_0.Position;
		this.Position = 0L;
	}

	public GStream1(string string_0) : this(new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read))
	{
	}

	public GStream1(Stream stream_1)
	{
		this.stream_0 = stream_1;
		this.method_2();
	}

	~GStream1()
	{
		this.Dispose();
	}

	public new void Dispose()
	{
		if (this.stream_0 != null)
		{
			this.stream_0.Close();
		}
		GC.SuppressFinalize(this);
	}

	public override bool CanRead
	{
		get
		{
			return true;
		}
	}

	public override bool CanSeek
	{
		get
		{
			return true;
		}
	}

	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	public override long Length
	{
		get
		{
			return this.long_1;
		}
	}

	public override long Position
	{
		get
		{
			return this.stream_0.Position - this.long_0;
		}
		set
		{
			this.Seek(value, SeekOrigin.Begin);
		}
	}

	public override void Close()
	{
		this.Dispose();
	}

	public override void Flush()
	{
	}

	public override void SetLength(long value)
	{
		throw new InvalidOperationException();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			this.stream_0.Position = offset + this.long_0;
			break;
		case SeekOrigin.Current:
			this.stream_0.Seek(offset, SeekOrigin.Current);
			break;
		case SeekOrigin.End:
			this.stream_0.Position = this.long_0 + this.long_1 - offset;
			break;
		}
		return this.Position;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int count2 = (int)Math.Min((long)count, this.long_1 - this.Position);
		return this.stream_0.Read(buffer, offset, count2);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new InvalidOperationException();
	}

	Stream stream_0;

	long long_0;

	long long_1;

	WaveFormat gclass94_0;
}
