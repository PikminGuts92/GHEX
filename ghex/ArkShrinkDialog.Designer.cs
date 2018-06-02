public partial class ArkShrinkDialog : global::System.Windows.Forms.Form
{
    void InitializeComponent()
    {
        this.btnOk = new global::System.Windows.Forms.Button();
        this.btnCancel = new global::System.Windows.Forms.Button();
        this.label1 = new global::System.Windows.Forms.Label();
        this.groupBox1 = new global::System.Windows.Forms.GroupBox();
        this.cbSongs = new global::System.Windows.Forms.CheckBox();
        this.cbTutorials = new global::System.Windows.Forms.CheckBox();
        this.nudSongLength = new global::System.Windows.Forms.NumericUpDown();
        this.label2 = new global::System.Windows.Forms.Label();
        this.cbMenuMusic = new global::System.Windows.Forms.CheckBox();
        this.groupBox1.SuspendLayout();
        ((global::System.ComponentModel.ISupportInitialize)this.nudSongLength).BeginInit();
        base.SuspendLayout();
        this.btnOk.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
        this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new global::System.Drawing.Point(223, 177);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new global::System.Drawing.Size(75, 23);
        this.btnOk.TabIndex = 0;
        this.btnOk.Text = "OK";
        this.btnOk.UseVisualStyleBackColor = true;
        this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
        this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new global::System.Drawing.Point(142, 177);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 1;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
        this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
        this.label1.Location = new global::System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new global::System.Drawing.Size(286, 45);
        this.label1.TabIndex = 2;
        this.label1.Text = "Using this tool will overwrite any files you choose to shrink, so any changes you've made to them will be lost.";
        this.groupBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
        this.groupBox1.Controls.Add(this.cbMenuMusic);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.nudSongLength);
        this.groupBox1.Controls.Add(this.cbTutorials);
        this.groupBox1.Controls.Add(this.cbSongs);
        this.groupBox1.Location = new global::System.Drawing.Point(15, 57);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new global::System.Drawing.Size(283, 94);
        this.groupBox1.TabIndex = 3;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "VGS";
        this.cbSongs.AutoSize = true;
        this.cbSongs.Checked = true;
        this.cbSongs.CheckState = global::System.Windows.Forms.CheckState.Checked;
        this.cbSongs.Location = new global::System.Drawing.Point(15, 19);
        this.cbSongs.Name = "cbSongs";
        this.cbSongs.Size = new global::System.Drawing.Size(91, 17);
        this.cbSongs.TabIndex = 0;
        this.cbSongs.Text = "Fill songs with";
        this.cbSongs.UseVisualStyleBackColor = true;
        this.cbSongs.CheckedChanged += new global::System.EventHandler(this.cbMenuMusic_CheckedChanged);
        this.cbTutorials.AutoSize = true;
        this.cbTutorials.Checked = true;
        this.cbTutorials.CheckState = global::System.Windows.Forms.CheckState.Checked;
        this.cbTutorials.Location = new global::System.Drawing.Point(15, 42);
        this.cbTutorials.Name = "cbTutorials";
        this.cbTutorials.Size = new global::System.Drawing.Size(119, 17);
        this.cbTutorials.TabIndex = 1;
        this.cbTutorials.Text = "Make tutorials silent";
        this.cbTutorials.UseVisualStyleBackColor = true;
        this.cbTutorials.CheckedChanged += new global::System.EventHandler(this.cbMenuMusic_CheckedChanged);
        this.nudSongLength.Location = new global::System.Drawing.Point(112, 18);
        global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudSongLength;
        int[] array = new int[4];
        array[0] = 600;
        numericUpDown.Maximum = new decimal(array);
        this.nudSongLength.Name = "nudSongLength";
        this.nudSongLength.Size = new global::System.Drawing.Size(47, 20);
        this.nudSongLength.TabIndex = 2;
        global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudSongLength;
        int[] array2 = new int[4];
        array2[0] = 1;
        numericUpDown2.Value = new decimal(array2);
        this.label2.AutoSize = true;
        this.label2.Location = new global::System.Drawing.Point(163, 21);
        this.label2.Name = "label2";
        this.label2.Size = new global::System.Drawing.Size(95, 13);
        this.label2.TabIndex = 3;
        this.label2.Text = "seconds of silence";
        this.cbMenuMusic.AutoSize = true;
        this.cbMenuMusic.Location = new global::System.Drawing.Point(15, 65);
        this.cbMenuMusic.Name = "cbMenuMusic";
        this.cbMenuMusic.Size = new global::System.Drawing.Size(139, 17);
        this.cbMenuMusic.TabIndex = 4;
        this.cbMenuMusic.Text = "Make menu music silent";
        this.cbMenuMusic.UseVisualStyleBackColor = true;
        this.cbMenuMusic.CheckedChanged += new global::System.EventHandler(this.cbMenuMusic_CheckedChanged);
        base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new global::System.Drawing.Size(310, 212);
        base.ControlBox = false;
        base.Controls.Add(this.groupBox1);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.btnCancel);
        base.Controls.Add(this.btnOk);
        base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
        base.Name = "ArkShrinkDialog";
        base.ShowInTaskbar = false;
        base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Shrink-o-Matic";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((global::System.ComponentModel.ISupportInitialize)this.nudSongLength).EndInit();
        base.ResumeLayout(false);
    }

    global::System.Windows.Forms.Button btnOk;

    global::System.Windows.Forms.Button btnCancel;

    global::System.Windows.Forms.Label label1;

    global::System.Windows.Forms.GroupBox groupBox1;

    global::System.Windows.Forms.CheckBox cbTutorials;

    global::System.Windows.Forms.CheckBox cbSongs;

    global::System.Windows.Forms.NumericUpDown nudSongLength;

    global::System.Windows.Forms.CheckBox cbMenuMusic;

    global::System.Windows.Forms.Label label2;
}
