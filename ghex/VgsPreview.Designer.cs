using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class VgsPreview : UserControl
{
    public VgsPreview(ArkEntry gclass126_0, object object_0, List<GClass109> list_0)
    {
        this.InitializeComponent();
        this.pbVolume.Value = (int)(100f * VgsPreview.float_1);
        this.gstream2_0 = gclass126_0.GetArkEntryStream();
        BinaryReader binaryReader_ = new BinaryReader(this.gstream2_0);
        VgsHelper.VgsFile @struct = VgsHelper.ReadVgsFromStream(binaryReader_);
        list_0.Add(new GClass109("Channels", @struct.channels.Length));
        this.int_0 += 28 - this.int_0 % 28;
        string[] array = new string[@struct.channels.Length];
        this.pcmAudio = new Class87[@struct.channels.Length];
        for (int i = 0; i < @struct.channels.Length; i++)
        {
            this.pcmAudio[i] = new Class87();
            if (i % 2 == 1)
            {
                this.pcmAudio[i].genum47_0 = GEnum47.const_1;
            }
            else
            {
                this.pcmAudio[i].genum47_0 = GEnum47.const_0;
            }
            this.pcmAudio[i].int_0 = @struct.channels[i].sampleRate;
            this.pcmAudio[i].int_1 = @struct.channels[i].blockCount;
            int num = (int)((float)this.pcmAudio[i].int_0 * 0.25f + 0.5f);
            num += 28 - num % 28;
            foreach (Class87.Class88 @class in this.pcmAudio[i].class88_0)
            {
                @class.float_0 = new float[num];
            }
            if (i == 0)
            {
                list_0.Add(new GClass109("Length", Class109.smethod_1((float)(28 * this.pcmAudio[i].int_1 / this.pcmAudio[i].int_0))));
            }
            array[i] = this.pcmAudio[i].int_0 + "Hz";
        }
        list_0.Add(new GClass109("SampleRate", array));
        switch (this.pcmAudio.Length)
        {
        case 1:
            this.class86_0 = new VgsPreview.Class86[]
            {
                new VgsPreview.Class86()
            };
            this.class86_0[0].string_0 = "Mono";
            this.class86_0[0].class87_0 = new Class87[]
            {
                this.pcmAudio[0]
            };
            goto IL_6B5;
        case 2:
            this.class86_0 = new VgsPreview.Class86[]
            {
                new VgsPreview.Class86()
            };
            this.class86_0[0].string_0 = "Stereo";
            this.class86_0[0].class87_0 = new Class87[]
            {
                this.pcmAudio[0],
                this.pcmAudio[1]
            };
            goto IL_6B5;
        case 4:
            this.class86_0 = new VgsPreview.Class86[]
            {
                new VgsPreview.Class86(),
                new VgsPreview.Class86()
            };
            this.class86_0[0].string_0 = "Band";
            this.class86_0[0].class87_0 = new Class87[]
            {
                this.pcmAudio[0],
                this.pcmAudio[1]
            };
            this.class86_0[1].string_0 = "Lead";
            this.class86_0[1].class87_0 = new Class87[]
            {
                this.pcmAudio[2],
                this.pcmAudio[3]
            };
            goto IL_6B5;
        case 5:
            this.class86_0 = new VgsPreview.Class86[]
            {
                new VgsPreview.Class86(),
                new VgsPreview.Class86(),
                new VgsPreview.Class86()
            };
            this.class86_0[0].string_0 = "Band";
            this.class86_0[0].class87_0 = new Class87[]
            {
                this.pcmAudio[0],
                this.pcmAudio[1]
            };
            this.class86_0[1].string_0 = "Lead";
            this.class86_0[1].class87_0 = new Class87[]
            {
                this.pcmAudio[2],
                this.pcmAudio[3]
            };
            this.class86_0[2].string_0 = "Co-op";
            this.class86_0[2].class87_0 = new Class87[]
            {
                this.pcmAudio[4]
            };
            goto IL_6B5;
        case 6:
            this.class86_0 = new VgsPreview.Class86[]
            {
                new VgsPreview.Class86(),
                new VgsPreview.Class86(),
                new VgsPreview.Class86()
            };
            this.class86_0[0].string_0 = "Band";
            this.class86_0[0].class87_0 = new Class87[]
            {
                this.pcmAudio[0],
                this.pcmAudio[1]
            };
            this.class86_0[1].string_0 = "Lead";
            this.class86_0[1].class87_0 = new Class87[]
            {
                this.pcmAudio[2],
                this.pcmAudio[3]
            };
            this.class86_0[2].string_0 = "Co-op";
            this.class86_0[2].class87_0 = new Class87[]
            {
                this.pcmAudio[4],
                this.pcmAudio[5]
            };
            goto IL_6B5;
        case 7:
            this.class86_0 = new VgsPreview.Class86[]
            {
                new VgsPreview.Class86(),
                new VgsPreview.Class86(),
                new VgsPreview.Class86(),
                new VgsPreview.Class86()
            };
            this.class86_0[0].string_0 = "Band";
            this.class86_0[0].class87_0 = new Class87[]
            {
                this.pcmAudio[0],
                this.pcmAudio[1]
            };
            this.class86_0[1].string_0 = "Lead";
            this.class86_0[1].class87_0 = new Class87[]
            {
                this.pcmAudio[2],
                this.pcmAudio[3]
            };
            this.class86_0[2].string_0 = "Co-op";
            this.class86_0[2].class87_0 = new Class87[]
            {
                this.pcmAudio[4],
                this.pcmAudio[5]
            };
            this.class86_0[3].string_0 = "Track";
            this.class86_0[3].class87_0 = new Class87[]
            {
                this.pcmAudio[6]
            };
            goto IL_6B5;
        }
        throw new NotImplementedException(this.pcmAudio.Length + "ch");
        IL_6B5:
        base.HandleDestroyed += this.VgsPreview_HandleDestroyed;
    }

    public int method_0()
    {
        return this.panel1.Height;
    }

    void ResetPCMAudio()
    {
        foreach (Class87 @class in this.pcmAudio)
        {
            @class.long_0 = 0L;
            @class.long_1 = 0L;
            foreach (Class87.Class88 class2 in @class.class88_0)
            {
                Array.Clear(class2.float_0, 0, class2.float_0.Length);
                class2.bool_0 = true;
            }
            @class.bool_0 = false;
            @class.int_2 = 0;
            @class.float_0 = 0f;
            @class.int_5 = 0;
            @class.float_1 = 0f;
            @class.int_3 = 0;
            @class.int_4 = 0;
            @class.long_2 = 128L;
        }
    }

    void method_2(object sender, EventArgs e)
    {
        TrackBar trackBar = sender as TrackBar;
        Class87 @class = trackBar.Tag as Class87;
        @class.float_2 = (float)trackBar.Value / 100f;
    }

    void VgsPreview_HandleDestroyed(object sender, EventArgs e)
    {
        if (this.isAudioInitialized)
        {
            this.btnStop_Click(sender, e);
        }
        this.gstream2_0.Close();
    }

    void method_3()
    {
        long position = this.gstream2_0.Position;
        byte[] array = new byte[16];
        float[] array2 = new float[28];
        foreach (Class87 @class in this.pcmAudio)
        {
            @class.short_0 = new short[@class.int_1 * 28];
        }
        int j = 0;
        while (j < this.pcmAudio.Length)
        {
            this.gstream2_0.Read(array, 0, 16);
            int num = (int)(array[1] & 15);
            GClass80.smethod_3(ref array, 0L, ref array2, 0L, ref this.pcmAudio[num].long_0, ref this.pcmAudio[num].long_1);
            for (int k = 0; k < 28; k++)
            {
                float num2 = array2[k] / 32767f;
                this.pcmAudio[num].short_0[this.pcmAudio[num].int_5++] = (short)(num2 * 32767f);
            }
            if ((array[1] & 128) == 128)
            {
                this.pcmAudio[num].bool_0 = true;
                j++;
            }
        }
        this.gstream2_0.Seek(position, SeekOrigin.Begin);
        this.ResetPCMAudio();
    }

    bool method_4(bool bool_4)
    {
        byte[] array = new byte[16];
        int[] array2 = new int[this.pcmAudio.Length];
        int i = 0;
        long num = this.gstream2_0.Length;
        for (int j = 0; j < this.pcmAudio.Length; j++)
        {
            array2[j] = 0;
            if (this.pcmAudio[j].method_0() && !this.pcmAudio[j].bool_0)
            {
                array2[j] += this.pcmAudio[j].class88_0[this.pcmAudio[j].int_4].float_0.Length / 28;
                if (bool_4)
                {
                    array2[j] *= Math.Min(this.pcmAudio[j].class88_0.Length - 1, 2);
                }
                i += array2[j];
                num = Math.Min(this.pcmAudio[j].long_2, num);
            }
        }
        this.gstream2_0.Seek(num, SeekOrigin.Begin);
        int num2 = 0;
        while (i > 0)
        {
            long position = this.gstream2_0.Position;
            this.gstream2_0.Read(array, 0, 16);
            int num3 = (int)(array[1] & 15);
            Class87 @class = this.pcmAudio[num3];
            if (@class.class88_0[@class.int_4].bool_0 && position >= @class.long_2)
            {
                @class.long_2 = this.gstream2_0.Position;
                i--;
                GClass80.smethod_3(ref array, 0L, ref @class.class88_0[@class.int_4].float_0, (long)@class.int_5, ref @class.long_0, ref @class.long_1);
                @class.int_2++;
                @class.int_5 += 28;
                if (@class.int_5 >= @class.class88_0[@class.int_4].float_0.Length)
                {
                    @class.class88_0[@class.int_4].bool_0 = false;
                    @class.class88_0[@class.int_4].int_0 = @class.int_2 * 28 - @class.int_5;
                    @class.int_4 = (@class.int_4 + 1) % @class.class88_0.Length;
                    @class.int_5 = 0;
                }
                if ((array[1] & 128) == 128)
                {
                    @class.bool_0 = true;
                    num2++;
                    if (num2 == this.pcmAudio.Length)
                    {
                        break;
                    }
                }
            }
        }
        if (num2 == this.pcmAudio.Length)
        {
            this.bool_0 = true;
            return false;
        }
        return true;
    }

    void method_5(IntPtr intptr_0, int int_1)
    {
        GClass103 gclass = new GClass103(new GClass102(44100, 16, 2), (uint)(int_1 / 4));
        this.method_11(gclass);
        int[] source = new int[gclass.method_0()];
        GClass80.smethod_2(gclass.method_3(GEnum47.const_0), gclass.method_3(GEnum47.const_1), ref source, gclass.method_0());
        Marshal.Copy(source, 0, intptr_0, gclass.method_0());
    }

    public bool method_6()
    {
        return this.isAudioInitialized && !this.bool_0;
    }

    public bool IsAudioPlaying()
    {
        return this.isAudioPlaying;
    }

    public bool method_8()
    {
        return this.bool_3;
    }

    public float method_9()
    {
        return (float)this.pcmAudio[0].int_1 * 28f / (float)this.pcmAudio[0].int_0;
    }

    public bool method_10(float float_2)
    {
        bool flag = this.isAudioPlaying;
        this.isAudioPlaying = true;
        float num = Math.Min(Math.Max(float_2 / this.method_9(), 0f), 1f);
        int num2 = this.pcmAudio[0].class88_0[0].float_0.Length / 28;
        int num3 = (int)((float)Math.Max(0, this.pcmAudio[0].int_1 - num2) * num);
        bool result = false;
        lock (this.pcmAudio)
        {
            this.bool_3 = true;
            this.ResetPCMAudio();
            this.gstream2_0.Seek(128L, SeekOrigin.Begin);
            byte[] array = new byte[16];
            bool flag2 = false;
            while (!flag2)
            {
                long position = this.gstream2_0.Position;
                this.gstream2_0.Read(array, 0, 16);
                int num4 = (int)(array[1] & 15);
                if ((array[1] & 128) == 0)
                {
                    Class87 @class = this.pcmAudio[num4];
                    @class.long_2 = this.gstream2_0.Position;
                    if (num4 != 0 || @class.int_2 < num3)
                    {
                        @class.int_2++;
                        continue;
                    }
                    result = true;
                }
                break;
            }
        }
        this.bool_3 = false;
        this.isAudioPlaying = flag;
        return result;
    }

    public GEnum48 method_11(GClass103 gclass103_0)
    {
        Array.Clear(gclass103_0.method_3(GEnum47.const_0), 0, gclass103_0.method_0());
        Array.Clear(gclass103_0.method_3(GEnum47.const_1), 0, gclass103_0.method_0());
        if (!this.isAudioPlaying && !this.bool_3)
        {
            lock (this.pcmAudio)
            {
                bool flag = false;
                int num = gclass103_0.method_0();
                foreach (Class87 @class in this.pcmAudio)
                {
                    int num2 = @class.class88_0[@class.int_3].float_0.Length;
                    float num3 = this.float_0 * (float)@class.int_0 / (float)gclass103_0.method_2().int_0;
                    for (int j = 0; j < num; j++)
                    {
                        float[] array2 = @class.class88_0[@class.int_3].float_0;
                        float num4 = array2[(int)@class.float_0];
                        float num5 = num4;
                        int num6 = (int)(@class.float_0 + 0.5f);
                        if (num6 < num2)
                        {
                            num5 = array2[num6];
                        }
                        float num7 = (float)((double)@class.float_0 - Math.Truncate((double)@class.float_0));
                        gclass103_0.method_3(@class.genum47_0)[j] += (num4 + (num5 - num4) * num7) * @class.float_2 * VgsPreview.float_1;
                        @class.float_0 += num3;
                        @class.float_1 = (float)@class.class88_0[@class.int_3].int_0 + @class.float_0;
                        if (@class.float_0 >= (float)num2)
                        {
                            flag = true;
                            @class.class88_0[@class.int_3].bool_0 = true;
                            @class.int_3 = (@class.int_3 + 1) % @class.class88_0.Length;
                            @class.float_0 = 0f;
                        }
                    }
                }
                if (flag && !this.bool_0)
                {
                    this.method_4(false);
                }
            }
            return GEnum48.const_0;
        }
        return GEnum48.const_0;
    }

    void VgsPreview_Paint(object sender, PaintEventArgs e)
    {
        Graphics graphics = e.Graphics;
    }

    void btnPlay_Click(object sender, EventArgs e)
    {
        if (this.isAudioInitialized)
        {
            // Toggles playback
            this.isAudioPlaying = !this.isAudioPlaying;
            this.btnPlay.ImageIndex = (this.isAudioPlaying ? 1 : 2);
            return;
        }
        if (!this.bool_3)
        {
            this.ResetPCMAudio();
        }
        this.method_4(true);
        this.dateTime_0 = DateTime.Now;

        // Creates new VGS object
        this.gclass62_0 = new GClass62(-1, new WaveFormat(44100, 16, 2), this.int_0 * 4, 4, new GDelegate1(this.method_5));
        //this.gclass62_0 = null;
        this.bool_0 = false;
        this.isAudioPlaying = false;
        this.isAudioInitialized = true;
        this.btnStop.Enabled = true;
        this.btnPlay.ImageIndex = 2;
    }

    void btnStop_Click(object sender, EventArgs e)
    {
        if (this.gclass62_0 != null)
        {
            this.gclass62_0.Dispose();
        }
        this.isAudioInitialized = false;
        this.btnStop.Enabled = false;
        this.btnPlay.ImageIndex = 1;
    }

    int method_12(out int int_1, out int int_2)
    {
        int result = 0;
        int_1 = 0;
        int_2 = 0;
        for (int i = 0; i < this.pcmAudio.Length; i++)
        {
            Class87 @class = this.pcmAudio[i];
            if (@class.int_1 > int_1)
            {
                int_1 = @class.int_1;
                result = @class.int_2;
                int_2 = @class.int_0;
            }
        }
        return result;
    }

    public float method_13()
    {
        float num = 0f;
        foreach (Class87 @class in this.pcmAudio)
        {
            float num2 = (float)(this.int_0 * 3) / 44100f;
            float num3 = @class.float_1 / (float)@class.int_0 - num2;
            if (num3 > num)
            {
                num = num3;
            }
        }
        return num;
    }

    void timer_0_Tick(object sender, EventArgs e)
    {
        if (this.isAudioInitialized)
        {
            int num = 0;
            int num2 = 0;
            int num3 = this.method_12(out num, out num2);
            this.pbSong.Value = (int)((float)(num3 * 100) / (float)num);
            float num4 = (float)num * 28f / (float)num2;
            float num5 = (float)num3 * 28f / (float)num2;
            this.lTime.Text = Class109.smethod_2(num5) + " / " + Class109.smethod_2(num4);
        }
        else
        {
            this.lTime.Text = "Stopped";
            this.pbSong.Value = 0;
        }
        if (this.bool_0)
        {
            bool flag = true;
            Class87[] array = this.pcmAudio;
            int i = 0;
            while (i < array.Length)
            {
                Class87 @class = array[i];
                if (@class.class88_0[@class.int_3].bool_0)
                {
                    i++;
                }
                else
                {
                    flag = false;

                    if (flag)
                    {
                        this.btnStop_Click(sender, e);
                        return;
                    }
                    return;
                }
            }

            if (flag)
            {
                this.btnStop_Click(sender, e);
                return;
            }
            return;
        }
    }

    void tbSpeed_ValueChanged(object sender, EventArgs e)
    {
        this.float_0 = (float)this.tbSpeed.Value / 100f;
        this.lSpeed.Text = this.tbSpeed.Value + "%";
    }

    void pbVolume_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left)
        {
            return;
        }
        VgsPreview.float_1 = Math.Min(Math.Max((float)e.X / (float)this.pbVolume.ClientSize.Width, 0f), 1f);
        this.pbVolume.Value = (int)(100f * VgsPreview.float_1);
    }

    void pbSong_MouseClick(object sender, MouseEventArgs e)
    {
        if (!this.isAudioInitialized)
        {
            return;
        }
        this.method_10(this.method_9() * ((float)e.X / (float)this.pbSong.ClientSize.Width));
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    void InitializeComponent()
    {
        this.icontainer_0 = new Container();
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(VgsPreview));
        this.panel1 = new Panel();
        this.label1 = new Label();
        this.pbVolume = new ProgressBar();
        this.lSpeed = new Label();
        this.lTime = new Label();
        this.pbSong = new ProgressBar();
        this.tbSpeed = new TrackBar();
        this.btnStop = new Button();
        this.imageList_0 = new ImageList(this.icontainer_0);
        this.btnPlay = new Button();
        this.timer_0 = new Timer(this.icontainer_0);
        this.panel1.SuspendLayout();
        ((ISupportInitialize)this.tbSpeed).BeginInit();
        base.SuspendLayout();
        this.panel1.BackColor = SystemColors.Control;
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.pbVolume);
        this.panel1.Controls.Add(this.lSpeed);
        this.panel1.Controls.Add(this.lTime);
        this.panel1.Controls.Add(this.pbSong);
        this.panel1.Controls.Add(this.tbSpeed);
        this.panel1.Controls.Add(this.btnStop);
        this.panel1.Controls.Add(this.btnPlay);
        this.panel1.Dock = DockStyle.Top;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(454, 33);
        this.panel1.TabIndex = 0;
        this.label1.AutoSize = true;
        this.label1.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.label1.Location = new Point(77, 17);
        this.label1.Name = "label1";
        this.label1.Size = new Size(45, 13);
        this.label1.TabIndex = 7;
        this.label1.Text = "Volume:";
        this.label1.TextAlign = ContentAlignment.TopRight;
        this.pbVolume.Location = new Point(128, 19);
        this.pbVolume.Name = "pbVolume";
        this.pbVolume.Size = new Size(100, 11);
        this.pbVolume.Step = 1;
        this.pbVolume.Style = ProgressBarStyle.Continuous;
        this.pbVolume.TabIndex = 6;
        this.pbVolume.Value = 50;
        this.pbVolume.MouseDown += this.pbVolume_MouseMove;
        this.pbVolume.MouseMove += this.pbVolume_MouseMove;
        this.lSpeed.AutoSize = true;
        this.lSpeed.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.lSpeed.Location = new Point(267, 3);
        this.lSpeed.Name = "lSpeed";
        this.lSpeed.Size = new Size(34, 13);
        this.lSpeed.TabIndex = 5;
        this.lSpeed.Text = "100%";
        this.lTime.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.lTime.Location = new Point(61, 3);
        this.lTime.Name = "lTime";
        this.lTime.Size = new Size(61, 15);
        this.lTime.TabIndex = 4;
        this.lTime.Text = "Stopped";
        this.lTime.TextAlign = ContentAlignment.TopRight;
        this.pbSong.Location = new Point(128, 5);
        this.pbSong.MarqueeAnimationSpeed = 5;
        this.pbSong.Name = "pbSong";
        this.pbSong.Size = new Size(100, 11);
        this.pbSong.Step = 1;
        this.pbSong.Style = ProgressBarStyle.Continuous;
        this.pbSong.TabIndex = 3;
        this.pbSong.MouseClick += this.pbSong_MouseClick;
        this.tbSpeed.AutoSize = false;
        this.tbSpeed.LargeChange = 25;
        this.tbSpeed.Location = new Point(234, 15);
        this.tbSpeed.Maximum = 100;
        this.tbSpeed.Minimum = 25;
        this.tbSpeed.Name = "tbSpeed";
        this.tbSpeed.Size = new Size(100, 15);
        this.tbSpeed.SmallChange = 5;
        this.tbSpeed.TabIndex = 0;
        this.tbSpeed.TickFrequency = 10;
        this.tbSpeed.Value = 100;
        this.tbSpeed.ValueChanged += this.tbSpeed_ValueChanged;
        this.btnStop.Enabled = false;
        this.btnStop.FlatStyle = FlatStyle.Popup;
        this.btnStop.ImageIndex = 0;
        this.btnStop.ImageList = this.imageList_0;
        this.btnStop.Location = new Point(32, 5);
        this.btnStop.Name = "btnStop";
        this.btnStop.Size = new Size(23, 23);
        this.btnStop.TabIndex = 2;
        this.btnStop.UseVisualStyleBackColor = true;
        this.btnStop.Click += this.btnStop_Click;
        this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ilToolbarImageStream");
        this.imageList_0.TransparentColor = Color.White;
        this.imageList_0.Images.SetKeyName(0, "Stop.bmp");
        this.imageList_0.Images.SetKeyName(1, "Play.bmp");
        this.imageList_0.Images.SetKeyName(2, "Pause.bmp");
        this.btnPlay.FlatStyle = FlatStyle.Popup;
        this.btnPlay.ImageKey = "Play.bmp";
        this.btnPlay.ImageList = this.imageList_0;
        this.btnPlay.Location = new Point(3, 5);
        this.btnPlay.Name = "btnPlay";
        this.btnPlay.Size = new Size(23, 23);
        this.btnPlay.TabIndex = 1;
        this.btnPlay.UseVisualStyleBackColor = true;
        this.btnPlay.Click += this.btnPlay_Click;
        this.timer_0.Enabled = true;
        this.timer_0.Interval = 30;
        this.timer_0.Tick += this.timer_0_Tick;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = SystemColors.AppWorkspace;
        base.Controls.Add(this.panel1);
        this.DoubleBuffered = true;
        base.Name = "VgsPreview";
        base.Size = new Size(454, 322);
        base.Paint += this.VgsPreview_Paint;
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        ((ISupportInitialize)this.tbSpeed).EndInit();
        base.ResumeLayout(false);
    }

    GClass62 gclass62_0;

    ArkEntryStream gstream2_0;

    VgsPreview.Class86[] class86_0;

    Class87[] pcmAudio;

    bool bool_0;

    bool isAudioInitialized;

    bool isAudioPlaying;

    DateTime dateTime_0;

    int int_0 = 1103;

    bool bool_3;

    float float_0 = 1f;

    static float float_1 = 0.5f;

    IContainer icontainer_0;

    Panel panel1;

    Button btnStop;

    Button btnPlay;

    TrackBar tbSpeed;

    ProgressBar pbSong;

    Timer timer_0;

    Label lTime;

    Label lSpeed;

    Label label1;

    ProgressBar pbVolume;

    ImageList imageList_0;

    internal class Class86
    {
        public string string_0;

        public Class87[] class87_0;
    }
}
