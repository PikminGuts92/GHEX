public partial class BatchExportNewNameDialog : global::System.Windows.Forms.Form
{
    void InitializeComponent()
    {
        this.textBox1 = new global::System.Windows.Forms.TextBox();
        this.btnOk = new global::System.Windows.Forms.Button();
        this.btnCancel = new global::System.Windows.Forms.Button();
        base.SuspendLayout();
        this.textBox1.Location = new global::System.Drawing.Point(12, 12);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new global::System.Drawing.Size(220, 20);
        this.textBox1.TabIndex = 0;
        this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
        this.btnOk.Location = new global::System.Drawing.Point(157, 44);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new global::System.Drawing.Size(75, 23);
        this.btnOk.TabIndex = 1;
        this.btnOk.Text = "OK";
        this.btnOk.UseVisualStyleBackColor = true;
        this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new global::System.Drawing.Point(76, 44);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 2;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        base.AcceptButton = this.btnOk;
        base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
        base.CancelButton = this.btnCancel;
        base.ClientSize = new global::System.Drawing.Size(244, 79);
        base.ControlBox = false;
        base.Controls.Add(this.btnCancel);
        base.Controls.Add(this.btnOk);
        base.Controls.Add(this.textBox1);
        base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        base.Name = "BatchExportNewNameDialog";
        base.ShowInTaskbar = false;
        base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "..";
        base.TopMost = true;
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    global::System.Windows.Forms.TextBox textBox1;

    global::System.Windows.Forms.Button btnOk;

    global::System.Windows.Forms.Button btnCancel;
}
