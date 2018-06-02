public partial class ChangesDialog : global::System.Windows.Forms.Form
{
    void InitializeComponent()
    {
        this.textBox1 = new global::System.Windows.Forms.TextBox();
        this.button1 = new global::System.Windows.Forms.Button();
        base.SuspendLayout();
        this.textBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
        this.textBox1.BackColor = global::System.Drawing.Color.White;
        this.textBox1.Font = new global::System.Drawing.Font("Courier New", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
        this.textBox1.Location = new global::System.Drawing.Point(12, 12);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.ReadOnly = true;
        this.textBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
        this.textBox1.Size = new global::System.Drawing.Size(558, 143);
        this.textBox1.TabIndex = 0;
        this.textBox1.WordWrap = false;
        this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
        this.button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
        this.button1.Location = new global::System.Drawing.Point(495, 161);
        this.button1.Name = "button1";
        this.button1.Size = new global::System.Drawing.Size(75, 23);
        this.button1.TabIndex = 1;
        this.button1.Text = "Close";
        this.button1.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new global::System.Drawing.Size(582, 189);
        base.Controls.Add(this.button1);
        base.Controls.Add(this.textBox1);
        base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.MinimumSize = new global::System.Drawing.Size(400, 200);
        base.Name = "ChangesDialog";
        base.ShowInTaskbar = false;
        base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Change Log";
        base.Load += new global::System.EventHandler(this.ChangesDialog_Load);
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    global::System.Windows.Forms.TextBox textBox1;

    global::System.Windows.Forms.Button button1;
}
