public partial class ExceptionDialog : global::System.Windows.Forms.Form
{
    void InitializeComponent()
    {
        this.label1 = new global::System.Windows.Forms.Label();
        this.btnContinue = new global::System.Windows.Forms.Button();
        this.btnRestart = new global::System.Windows.Forms.Button();
        this.cbReport = new global::System.Windows.Forms.CheckBox();
        this.lblNote = new global::System.Windows.Forms.Label();
        this.textBox1 = new global::System.Windows.Forms.TextBox();
        this.tbDescription = new global::System.Windows.Forms.TextBox();
        base.SuspendLayout();
        this.label1.BackColor = global::System.Drawing.Color.White;
        this.label1.Dock = global::System.Windows.Forms.DockStyle.Top;
        this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
        this.label1.Location = new global::System.Drawing.Point(0, 0);
        this.label1.Name = "label1";
        this.label1.Padding = new global::System.Windows.Forms.Padding(3);
        this.label1.Size = new global::System.Drawing.Size(387, 52);
        this.label1.TabIndex = 0;
        this.btnContinue.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
        this.btnContinue.DialogResult = global::System.Windows.Forms.DialogResult.OK;
        this.btnContinue.Location = new global::System.Drawing.Point(300, 171);
        this.btnContinue.Name = "btnContinue";
        this.btnContinue.Size = new global::System.Drawing.Size(75, 23);
        this.btnContinue.TabIndex = 1;
        this.btnContinue.Text = "Continue";
        this.btnContinue.UseVisualStyleBackColor = true;
        this.btnRestart.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
        this.btnRestart.DialogResult = global::System.Windows.Forms.DialogResult.Retry;
        this.btnRestart.Location = new global::System.Drawing.Point(219, 171);
        this.btnRestart.Name = "btnRestart";
        this.btnRestart.Size = new global::System.Drawing.Size(75, 23);
        this.btnRestart.TabIndex = 2;
        this.btnRestart.Text = "Restart";
        this.btnRestart.UseVisualStyleBackColor = true;
        this.cbReport.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
        this.cbReport.AutoSize = true;
        this.cbReport.Location = new global::System.Drawing.Point(12, 175);
        this.cbReport.Name = "cbReport";
        this.cbReport.Size = new global::System.Drawing.Size(183, 17);
        this.cbReport.TabIndex = 3;
        this.cbReport.Text = "Report this error to the ghex team";
        this.cbReport.UseVisualStyleBackColor = true;
        this.cbReport.CheckedChanged += new global::System.EventHandler(this.cbReport_CheckedChanged);
        this.lblNote.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
        this.lblNote.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
        this.lblNote.Location = new global::System.Drawing.Point(20, 149);
        this.lblNote.Name = "lblNote";
        this.lblNote.Size = new global::System.Drawing.Size(346, 13);
        this.lblNote.TabIndex = 5;
        this.lblNote.Text = "Please report this error to help improve Guitar Hero Explorer";
        this.lblNote.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
        this.textBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
        this.textBox1.Location = new global::System.Drawing.Point(12, 64);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.ReadOnly = true;
        this.textBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
        this.textBox1.ShortcutsEnabled = false;
        this.textBox1.Size = new global::System.Drawing.Size(363, 75);
        this.textBox1.TabIndex = 6;
        this.textBox1.WordWrap = false;
        this.tbDescription.AcceptsReturn = true;
        this.tbDescription.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
        this.tbDescription.Location = new global::System.Drawing.Point(12, 200);
        this.tbDescription.MaxLength = 2048;
        this.tbDescription.Multiline = true;
        this.tbDescription.Name = "tbDescription";
        this.tbDescription.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
        this.tbDescription.Size = new global::System.Drawing.Size(363, 52);
        this.tbDescription.TabIndex = 7;
        this.tbDescription.Text = "Please write a short description of what you were doing when the error\r\noccured. Also, any related information such as file/song name, custom\r\ncontent and such is very helpful.";
        this.tbDescription.WordWrap = false;
        base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new global::System.Drawing.Size(387, 264);
        base.ControlBox = false;
        base.Controls.Add(this.tbDescription);
        base.Controls.Add(this.textBox1);
        base.Controls.Add(this.lblNote);
        base.Controls.Add(this.cbReport);
        base.Controls.Add(this.btnRestart);
        base.Controls.Add(this.btnContinue);
        base.Controls.Add(this.label1);
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "ExceptionDialog";
        base.ShowIcon = false;
        base.ShowInTaskbar = false;
        base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Guitar Hero Explorer";
        base.TopMost = true;
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    global::System.Windows.Forms.Label label1;

    global::System.Windows.Forms.Button btnContinue;

    global::System.Windows.Forms.Button btnRestart;

    global::System.Windows.Forms.CheckBox cbReport;

    global::System.Windows.Forms.Label lblNote;

    global::System.Windows.Forms.TextBox textBox1;

    global::System.Windows.Forms.TextBox tbDescription;
}
