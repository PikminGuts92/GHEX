public partial class VgsImportSourceDialog : global::System.Windows.Forms.Form
{
	void InitializeComponent()
	{
		this.btnOk = new global::System.Windows.Forms.Button();
		this.label1 = new global::System.Windows.Forms.Label();
		this.nudOffset = new global::System.Windows.Forms.NumericUpDown();
		this.nudVolume = new global::System.Windows.Forms.NumericUpDown();
		this.label2 = new global::System.Windows.Forms.Label();
		((global::System.ComponentModel.ISupportInitialize)this.nudOffset).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.nudVolume).BeginInit();
		base.SuspendLayout();
		this.btnOk.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
		this.btnOk.Location = new global::System.Drawing.Point(188, 111);
		this.btnOk.Name = "btnOk";
		this.btnOk.Size = new global::System.Drawing.Size(75, 23);
		this.btnOk.TabIndex = 0;
		this.btnOk.Text = "OK";
		this.btnOk.UseVisualStyleBackColor = true;
		this.label1.Location = new global::System.Drawing.Point(12, 14);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(62, 13);
		this.label1.TabIndex = 1;
		this.label1.Text = "Offset (ms):";
		this.label1.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
		this.nudOffset.Location = new global::System.Drawing.Point(78, 12);
		global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudOffset;
		int[] array = new int[4];
		array[0] = 10000;
		numericUpDown.Maximum = new decimal(array);
		this.nudOffset.Minimum = new decimal(new int[]
		{
			10000,
			0,
			0,
			int.MinValue
		});
		this.nudOffset.Name = "nudOffset";
		this.nudOffset.Size = new global::System.Drawing.Size(63, 20);
		this.nudOffset.TabIndex = 2;
		this.nudVolume.Location = new global::System.Drawing.Point(78, 35);
		global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudVolume;
		int[] array2 = new int[4];
		array2[0] = 300;
		numericUpDown2.Maximum = new decimal(array2);
		global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudVolume;
		int[] array3 = new int[4];
		array3[0] = 10;
		numericUpDown3.Minimum = new decimal(array3);
		this.nudVolume.Name = "nudVolume";
		this.nudVolume.Size = new global::System.Drawing.Size(63, 20);
		this.nudVolume.TabIndex = 4;
		global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudVolume;
		int[] array4 = new int[4];
		array4[0] = 100;
		numericUpDown4.Value = new decimal(array4);
		this.label2.Location = new global::System.Drawing.Point(12, 37);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(62, 13);
		this.label2.TabIndex = 3;
		this.label2.Text = "Volume (%):";
		this.label2.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
		base.AcceptButton = this.btnOk;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(275, 146);
		base.ControlBox = false;
		base.Controls.Add(this.nudVolume);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.nudOffset);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.btnOk);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "VgsImportSourceDialog";
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Properties";
		((global::System.ComponentModel.ISupportInitialize)this.nudOffset).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.nudVolume).EndInit();
		base.ResumeLayout(false);
	}

	global::System.Windows.Forms.Button btnOk;

	global::System.Windows.Forms.Label label1;

	global::System.Windows.Forms.NumericUpDown nudOffset;

	global::System.Windows.Forms.NumericUpDown nudVolume;

	global::System.Windows.Forms.Label label2;
}
