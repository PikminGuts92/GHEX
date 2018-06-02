public partial class BugReportDialog : global::System.Windows.Forms.Form
{
    void InitializeComponent()
    {
        global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BugReportDialog));
        this.label1 = new global::System.Windows.Forms.Label();
        this.textBox1 = new global::System.Windows.Forms.TextBox();
        this.btnReport = new global::System.Windows.Forms.Button();
        this.btnCancel = new global::System.Windows.Forms.Button();
        this.label2 = new global::System.Windows.Forms.Label();
        base.SuspendLayout();
        this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
        this.label1.Location = new global::System.Drawing.Point(15, 9);
        this.label1.Name = "label1";
        this.label1.Size = new global::System.Drawing.Size(405, 73);
        this.label1.TabIndex = 0;
        this.label1.Text = componentResourceManager.GetString("label1.Text");
        this.textBox1.AcceptsReturn = true;
        this.textBox1.AcceptsTab = true;
        this.textBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
        this.textBox1.Location = new global::System.Drawing.Point(12, 85);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new global::System.Drawing.Size(408, 184);
        this.textBox1.TabIndex = 1;
        this.btnReport.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
        this.btnReport.DialogResult = global::System.Windows.Forms.DialogResult.OK;
        this.btnReport.Location = new global::System.Drawing.Point(345, 309);
        this.btnReport.Name = "btnReport";
        this.btnReport.Size = new global::System.Drawing.Size(75, 23);
        this.btnReport.TabIndex = 2;
        this.btnReport.Text = "Report";
        this.btnReport.UseVisualStyleBackColor = true;
        this.btnReport.Click += new global::System.EventHandler(this.btnReport_Click);
        this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
        this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new global::System.Drawing.Point(264, 309);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 3;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
        this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
        this.label2.Location = new global::System.Drawing.Point(12, 285);
        this.label2.Name = "label2";
        this.label2.Size = new global::System.Drawing.Size(408, 13);
        this.label2.TabIndex = 4;
        this.label2.Text = "Thank you for helping make Guitar Hero Explorer better!";
        this.label2.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
        base.AcceptButton = this.btnReport;
        base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
        base.CancelButton = this.btnCancel;
        base.ClientSize = new global::System.Drawing.Size(432, 344);
        base.Controls.Add(this.label2);
        base.Controls.Add(this.btnCancel);
        base.Controls.Add(this.btnReport);
        base.Controls.Add(this.textBox1);
        base.Controls.Add(this.label1);
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "BugReportDialog";
        base.ShowIcon = false;
        this.Text = "Report-A-Bug";
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    global::System.Windows.Forms.Label label1;

    global::System.Windows.Forms.TextBox textBox1;

    global::System.Windows.Forms.Button btnReport;

    global::System.Windows.Forms.Button btnCancel;

    global::System.Windows.Forms.Label label2;
}
