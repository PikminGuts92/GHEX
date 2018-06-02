public partial class AboutDialog : global::System.Windows.Forms.Form
{
    void InitializeComponent()
    {
        this.icontainer_0 = new global::System.ComponentModel.Container();
        global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AboutDialog));
        this.btnOk = new global::System.Windows.Forms.Button();
        this.lName = new global::System.Windows.Forms.Label();
        this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
        this.label1 = new global::System.Windows.Forms.Label();
        this.imageList_0 = new global::System.Windows.Forms.ImageList(this.icontainer_0);
        base.SuspendLayout();
        this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
        this.btnOk.Location = new global::System.Drawing.Point(205, 70);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new global::System.Drawing.Size(75, 23);
        this.btnOk.TabIndex = 0;
        this.btnOk.Text = "OK";
        this.btnOk.UseVisualStyleBackColor = true;
        this.lName.AutoSize = true;
        this.lName.Location = new global::System.Drawing.Point(48, 9);
        this.lName.Name = "lName";
        this.lName.Size = new global::System.Drawing.Size(166, 26);
        this.lName.TabIndex = 1;
        this.lName.Text = "Guitar Hero Explorer <version>\r\nCopyright © 2006-2007, OnReally";
        this.linkLabel1.ActiveLinkColor = global::System.Drawing.Color.Blue;
        this.linkLabel1.AutoSize = true;
        this.linkLabel1.Location = new global::System.Drawing.Point(48, 45);
        this.linkLabel1.Name = "linkLabel1";
        this.linkLabel1.Size = new global::System.Drawing.Size(130, 13);
        this.linkLabel1.TabIndex = 2;
        this.linkLabel1.TabStop = true;
        this.linkLabel1.Text = "http://onreally.com/ghex/";
        this.linkLabel1.VisitedLinkColor = global::System.Drawing.Color.Blue;
        this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
        this.label1.ImageIndex = 0;
        this.label1.ImageList = this.imageList_0;
        this.label1.Location = new global::System.Drawing.Point(10, 9);
        this.label1.Name = "label1";
        this.label1.Size = new global::System.Drawing.Size(32, 32);
        this.label1.TabIndex = 3;
        this.imageList_0.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
        this.imageList_0.TransparentColor = global::System.Drawing.Color.Black;
        this.imageList_0.Images.SetKeyName(0, "logo.bmp");
        this.imageList_0.Images.SetKeyName(1, "logo.ico");
        base.AcceptButton = this.btnOk;
        base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
        base.CancelButton = this.btnOk;
        base.ClientSize = new global::System.Drawing.Size(292, 105);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.linkLabel1);
        base.Controls.Add(this.lName);
        base.Controls.Add(this.btnOk);
        base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "AboutDialog";
        base.ShowIcon = false;
        base.ShowInTaskbar = false;
        base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "About Guitar Hero Explorer";
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    global::System.ComponentModel.IContainer icontainer_0;

    global::System.Windows.Forms.Button btnOk;

    global::System.Windows.Forms.Label lName;

    global::System.Windows.Forms.LinkLabel linkLabel1;

    global::System.Windows.Forms.Label label1;

    global::System.Windows.Forms.ImageList imageList_0;
}
