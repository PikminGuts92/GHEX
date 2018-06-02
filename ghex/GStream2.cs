using System;
using System.IO;

public class GStream2 : Stream
{
	internal GStream2(ArkEntry gclass126_1, FileStream fileStream_1)
	{
		this.gclass126_0 = gclass126_1;
		this.fileStream_0 = fileStream_1;
		this.fileStream_0.Seek(this.gclass126_0.GetFileOffset(), SeekOrigin.Begin);
	}

	public override void Close()
	{
		base.Close();
		this.fileStream_0.Close();
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return this.fileStream_0.BeginRead(buffer, offset, count, callback, state);
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	public override bool CanRead
	{
		get
		{
			return this.fileStream_0.CanRead;
		}
	}

	public override bool CanSeek
	{
		get
		{
			return this.fileStream_0.CanSeek;
		}
	}

	public override bool CanTimeout
	{
		get
		{
			return this.fileStream_0.CanTimeout;
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
			return this.gclass126_0.GetFileSize();
		}
	}

	public override long Position
	{
		get
		{
			return this.fileStream_0.Position - this.gclass126_0.GetFileOffset();
		}
		set
		{
			this.fileStream_0.Position = this.gclass126_0.GetFileOffset() + value;
		}
	}

	public override void Flush()
	{
		this.fileStream_0.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			return this.fileStream_0.Seek(this.gclass126_0.GetFileOffset() + offset, SeekOrigin.Begin) - this.gclass126_0.GetFileOffset();
		case SeekOrigin.Current:
			return this.fileStream_0.Seek(offset, SeekOrigin.Current) - this.gclass126_0.GetFileOffset();
		case SeekOrigin.End:
			return this.fileStream_0.Seek(this.gclass126_0.GetFileOffset() + this.gclass126_0.GetFileSize() - offset, SeekOrigin.Begin) - this.gclass126_0.GetFileOffset();
		default:
			return 0L;
		}
	}

	public override void SetLength(long value)
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return this.fileStream_0.Read(buffer, offset, count);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	ArkEntry gclass126_0;

	FileStream fileStream_0;
}
