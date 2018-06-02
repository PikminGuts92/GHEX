using System;
using System.IO;

public class ArkEntryStream : Stream
{
	internal ArkEntryStream(ArkEntry entry, FileStream arkStream)
	{
		this.arkEntry = entry;
		this.arkFileStream = arkStream;
		this.arkFileStream.Seek(this.arkEntry.GetFileOffset(), SeekOrigin.Begin);
	}

	public override void Close()
	{
		base.Close();
		this.arkFileStream.Close();
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return this.arkFileStream.BeginRead(buffer, offset, count, callback, state);
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	public override bool CanRead => arkFileStream.CanRead;

	public override bool CanSeek => arkFileStream.CanSeek;

	public override bool CanTimeout => arkFileStream.CanTimeout;

    public override bool CanWrite => false;

	public override long Length => arkEntry.GetFileSize();

	public override long Position
	{
		get
		{
			return this.arkFileStream.Position - this.arkEntry.GetFileOffset();
		}
		set
		{
			this.arkFileStream.Position = this.arkEntry.GetFileOffset() + value;
		}
	}

	public override void Flush() => arkFileStream.Flush();

	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			return this.arkFileStream.Seek(this.arkEntry.GetFileOffset() + offset, SeekOrigin.Begin) - this.arkEntry.GetFileOffset();
		case SeekOrigin.Current:
			return this.arkFileStream.Seek(offset, SeekOrigin.Current) - this.arkEntry.GetFileOffset();
		case SeekOrigin.End:
			return this.arkFileStream.Seek(this.arkEntry.GetFileOffset() + this.arkEntry.GetFileSize() - offset, SeekOrigin.Begin) - this.arkEntry.GetFileOffset();
		default:
			return 0L;
		}
	}

    public override void SetLength(long value) { } // Not implementd

    public override int Read(byte[] buffer, int offset, int count) =>
        arkFileStream.Read(buffer, offset, count);

    public override void Write(byte[] buffer, int offset, int count) { } // Read-only stream

	ArkEntry arkEntry;

	FileStream arkFileStream;
}
