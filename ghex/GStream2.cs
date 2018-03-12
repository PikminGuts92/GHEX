using System;
using System.IO;

public class GStream2 : Stream
{
	internal GStream2(GClass126 gclass126_1, FileStream fileStream_1)
	{
		this.gclass126_0 = gclass126_1;
		this.fileStream_0 = fileStream_1;
		this.fileStream_0.Seek(this.gclass126_0.method_11(), SeekOrigin.Begin);
	}

	public virtual void Close()
	{
		base.Close();
		this.fileStream_0.Close();
	}

	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return this.fileStream_0.BeginRead(buffer, offset, count, callback, state);
	}

	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	public virtual bool CanRead
	{
		get
		{
			return this.fileStream_0.CanRead;
		}
	}

	public virtual bool CanSeek
	{
		get
		{
			return this.fileStream_0.CanSeek;
		}
	}

	public virtual bool CanTimeout
	{
		get
		{
			return this.fileStream_0.CanTimeout;
		}
	}

	public virtual bool CanWrite
	{
		get
		{
			return false;
		}
	}

	public virtual long Length
	{
		get
		{
			return this.gclass126_0.method_4();
		}
	}

	public virtual long Position
	{
		get
		{
			return this.fileStream_0.Position - this.gclass126_0.method_11();
		}
		set
		{
			this.fileStream_0.Position = this.gclass126_0.method_11() + value;
		}
	}

	public virtual void Flush()
	{
		this.fileStream_0.Flush();
	}

	public virtual long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			return this.fileStream_0.Seek(this.gclass126_0.method_11() + offset, SeekOrigin.Begin) - this.gclass126_0.method_11();
		case SeekOrigin.Current:
			return this.fileStream_0.Seek(offset, SeekOrigin.Current) - this.gclass126_0.method_11();
		case SeekOrigin.End:
			return this.fileStream_0.Seek(this.gclass126_0.method_11() + this.gclass126_0.method_4() - offset, SeekOrigin.Begin) - this.gclass126_0.method_11();
		default:
			return 0L;
		}
	}

	public virtual void SetLength(long value)
	{
	}

	public virtual int Read(byte[] buffer, int offset, int count)
	{
		return this.fileStream_0.Read(buffer, offset, count);
	}

	public virtual void Write(byte[] buffer, int offset, int count)
	{
	}

	GClass126 gclass126_0;

	FileStream fileStream_0;
}
