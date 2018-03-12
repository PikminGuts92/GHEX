using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

[ToolboxItem(false)]
public class GClass77 : ContextMenu
{
	public GClass77()
	{
		this.gclass32_0 = null;
		this.bool_0 = true;
		this.menuItem_0 = new MenuItem("More...", new EventHandler(this.method_4));
		this.menuItem_1 = new MenuItem("-");
	}

	public void method_0(Control control_0, Point point_0)
	{
		if (control_0 == null)
		{
			throw new ArgumentNullException("control", "control cannot be null");
		}
		if (!(control_0 is GControl2))
		{
			throw new ArgumentException("control must be of type Table", "control");
		}
		if (((GControl2)control_0).method_166() == null)
		{
			throw new InvalidOperationException("The specified Table does not have an associated ColumnModel");
		}
		this.gclass32_0 = ((GControl2)control_0).method_166();
		base.MenuItems.Clear();
		base.Show(control_0, point_0);
	}

	internal bool method_1()
	{
		return this.bool_0;
	}

	internal void method_2(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	protected virtual void OnPopup(EventArgs eventArgs_0)
	{
		if (this.gclass32_0.method_23().Count > 0)
		{
			for (int i = 0; i < this.gclass32_0.method_23().Count; i++)
			{
				if (i == 10)
				{
					base.MenuItems.Add(this.menuItem_1);
					base.MenuItems.Add(this.menuItem_0);
					break;
				}
				MenuItem menuItem = new MenuItem(this.gclass32_0.method_23().method_8(i).method_5(), new EventHandler(this.method_3));
				menuItem.Checked = this.gclass32_0.method_23().method_8(i).method_19();
				base.MenuItems.Add(menuItem);
			}
		}
		base.OnPopup(eventArgs_0);
	}

	void method_3(object sender, EventArgs e)
	{
		MenuItem menuItem = (MenuItem)sender;
		this.gclass32_0.method_23().method_8(menuItem.Index).method_20(!menuItem.Checked);
	}

	void method_4(object sender, EventArgs e)
	{
		GClass77.ShowColumnsDialog showColumnsDialog = new GClass77.ShowColumnsDialog();
		showColumnsDialog.method_0(this.gclass32_0);
		showColumnsDialog.ShowDialog(base.SourceControl);
	}

	GClass32 gclass32_0;

	bool bool_0;

	MenuItem menuItem_0;

	MenuItem menuItem_1;

	internal class ShowColumnsDialog : Form
	{
		public ShowColumnsDialog()
		{
			this.label1 = new Label();
			this.columnListBox = new GControl2();
			this.upButton = new Button();
			this.downButton = new Button();
			this.showButton = new Button();
			this.hideButton = new Button();
			this.label2 = new Label();
			this.textBox1 = new TextBox();
			this.autoSizeCheckBox = new CheckBox();
			this.groupBox1 = new GroupBox();
			this.okButton = new Button();
			this.cancelButton = new Button();
			base.SuspendLayout();
			this.label1.Location = new Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new Size(324, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select the columns you want to appear in this view.";
			this.columnListBox.method_191(ColumnHeaderStyle.None);
			this.columnListBox.Location = new Point(12, 52);
			this.columnListBox.Name = "columnListBox";
			this.columnListBox.Size = new Size(231, 240);
			this.columnListBox.TabIndex = 1;
			this.columnListBox.method_167(new GClass32());
			this.columnListBox.method_166().method_23().method_0(new GClass24("Columns", 227));
			this.columnListBox.method_240(new GClass104());
			GClass104 gclass = this.columnListBox.method_239();
			gclass.method_15(gclass.method_14() + 3);
			this.upButton.FlatStyle = FlatStyle.System;
			this.upButton.Location = new Point(253, 52);
			this.upButton.Name = "upButton";
			this.upButton.TabIndex = 2;
			this.upButton.Text = "Move &Up";
			this.upButton.Visible = false;
			this.downButton.FlatStyle = FlatStyle.System;
			this.downButton.Location = new Point(253, 81);
			this.downButton.Name = "downButton";
			this.downButton.TabIndex = 3;
			this.downButton.Text = "Move &Down";
			this.downButton.Visible = false;
			this.showButton.FlatStyle = FlatStyle.System;
			this.showButton.Location = new Point(253, 52);
			this.showButton.Name = "showButton";
			this.showButton.TabIndex = 4;
			this.showButton.Text = "&Show";
			this.showButton.Click += this.showButton_Click;
			this.hideButton.FlatStyle = FlatStyle.System;
			this.hideButton.Location = new Point(253, 81);
			this.hideButton.Name = "hideButton";
			this.hideButton.TabIndex = 5;
			this.hideButton.Text = "&Hide";
			this.hideButton.Click += this.hideButton_Click;
			this.label2.Location = new Point(12, 300);
			this.label2.Name = "label2";
			this.label2.Size = new Size(192, 21);
			this.label2.TabIndex = 6;
			this.label2.Text = "&Width of selected column (in pixels):";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
			this.textBox1.Location = new Point(207, 300);
			this.textBox1.MaxLength = 4;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(36, 21);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = HorizontalAlignment.Right;
			this.textBox1.KeyPress += this.textBox1_KeyPress;
			this.autoSizeCheckBox.Location = new Point(12, 330);
			this.autoSizeCheckBox.Name = "autoSizeCheckBox";
			this.autoSizeCheckBox.Size = new Size(228, 16);
			this.autoSizeCheckBox.TabIndex = 8;
			this.autoSizeCheckBox.Text = "&Automatically size all columns";
			this.autoSizeCheckBox.Visible = false;
			this.groupBox1.Location = new Point(8, 352);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(322, 8);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.okButton.FlatStyle = FlatStyle.System;
			this.okButton.Location = new Point(168, 372);
			this.okButton.Name = "okButton";
			this.okButton.TabIndex = 10;
			this.okButton.Text = "OK";
			this.okButton.Click += this.okButton_Click;
			this.cancelButton.DialogResult = DialogResult.Cancel;
			this.cancelButton.FlatStyle = FlatStyle.System;
			this.cancelButton.Location = new Point(253, 372);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.TabIndex = 11;
			this.cancelButton.Text = "Cancel";
			base.AcceptButton = this.okButton;
			this.AutoScaleBaseSize = new Size(5, 14);
			base.CancelButton = this.cancelButton;
			base.ClientSize = new Size(339, 408);
			base.Controls.Add(this.cancelButton);
			base.Controls.Add(this.okButton);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.autoSizeCheckBox);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.hideButton);
			base.Controls.Add(this.showButton);
			base.Controls.Add(this.downButton);
			base.Controls.Add(this.upButton);
			base.Controls.Add(this.columnListBox);
			base.Controls.Add(this.label1);
			this.Font = new Font("Tahoma", 8.25f);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ShowColumnsDialog";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Choose Columns";
			base.ResumeLayout(false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				this.container_0.Dispose();
			}
			base.Dispose(disposing);
		}

		public void method_0(GClass32 gclass32_1)
		{
			this.gclass32_0 = gclass32_1;
			GClass150 gclass = new GClass150();
			gclass.method_7(new GStruct13(6, 0, 0, 0));
			this.columnListBox.method_135();
			for (int i = 0; i < gclass32_1.method_23().Count; i++)
			{
				GClass83 gclass2 = new GClass83();
				GClass97 gclass3 = new GClass97(gclass32_1.method_23().method_8(i).method_5(), gclass32_1.method_23().method_8(i).method_19());
				gclass3.method_10(gclass32_1.method_23().method_8(i).method_9());
				gclass3.method_12(gclass);
				gclass2.method_9().method_0(gclass3);
				this.columnListBox.method_239().method_12().method_0(gclass2);
			}
			this.columnListBox.method_86(new GDelegate18(this.method_1));
			this.columnListBox.method_28(new GDelegate26(this.method_2));
			if (this.columnListBox.method_214())
			{
				GClass17 gclass4 = this.columnListBox.method_166().method_23().method_8(0);
				gclass4.method_10(gclass4.method_9() - SystemInformation.VerticalScrollBarWidth);
			}
			if (this.columnListBox.method_239().method_12().Count > 0)
			{
				this.columnListBox.method_239().method_13().method_0(0, 0);
				this.showButton.Enabled = !this.gclass32_0.method_23().method_8(0).method_19();
				this.hideButton.Enabled = this.gclass32_0.method_23().method_8(0).method_19();
				this.textBox1.Text = this.gclass32_0.method_23().method_8(0).method_9().ToString();
			}
			this.columnListBox.method_136();
		}

		void showButton_Click(object sender, EventArgs e)
		{
			int[] array = this.columnListBox.method_238();
			if (array.Length > 0)
			{
				this.columnListBox.method_239().method_10(array[0], 0).method_28(true);
				this.hideButton.Focus();
			}
		}

		void hideButton_Click(object sender, EventArgs e)
		{
			int[] array = this.columnListBox.method_238();
			if (array.Length > 0)
			{
				this.columnListBox.method_239().method_10(array[0], 0).method_28(false);
				this.showButton.Focus();
			}
		}

		void okButton_Click(object sender, EventArgs e)
		{
			int[] array = this.columnListBox.method_238();
			if (array.Length > 0)
			{
				if (this.textBox1.Text.Length == 0)
				{
					this.columnListBox.method_239().method_10(array[0], 0).method_10(GClass17.int_8);
				}
				else
				{
					int num = Convert.ToInt32(this.textBox1.Text);
					if (num < GClass17.int_8)
					{
						this.columnListBox.method_239().method_10(array[0], 0).method_10(GClass17.int_8);
					}
					else
					{
						this.columnListBox.method_239().method_10(array[0], 0).method_10(num);
					}
				}
			}
			for (int i = 0; i < this.columnListBox.method_239().method_12().Count; i++)
			{
				this.gclass32_0.method_23().method_8(i).method_20(this.columnListBox.method_239().method_10(i, 0).method_27());
				this.gclass32_0.method_23().method_8(i).method_10((int)this.columnListBox.method_239().method_10(i, 0).method_9());
			}
			base.Close();
		}

		void method_1(object sender, GEventArgs13 e)
		{
			if (e.method_1().Length > 0)
			{
				if (this.textBox1.Text.Length == 0)
				{
					this.columnListBox.method_239().method_10(e.method_1()[0], 0).method_10(GClass17.int_8);
				}
				else
				{
					int num = Convert.ToInt32(this.textBox1.Text);
					if (num < GClass17.int_8)
					{
						this.columnListBox.method_239().method_10(e.method_1()[0], 0).method_10(GClass17.int_8);
					}
					else
					{
						this.columnListBox.method_239().method_10(e.method_1()[0], 0).method_10(num);
					}
				}
			}
			if (e.method_2().Length > 0)
			{
				this.showButton.Enabled = !this.columnListBox.method_239().method_10(e.method_2()[0], 0).method_27();
				this.hideButton.Enabled = this.columnListBox.method_239().method_10(e.method_2()[0], 0).method_27();
				this.textBox1.Text = this.columnListBox.method_239().method_10(e.method_2()[0], 0).method_9().ToString();
				return;
			}
			this.showButton.Enabled = false;
			this.hideButton.Enabled = false;
			this.textBox1.Text = "0";
		}

		void method_2(object sender, GEventArgs4 e)
		{
			this.showButton.Enabled = !e.method_0().method_27();
			this.hideButton.Enabled = e.method_0().method_27();
		}

		void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != GClass68.char_8 && e.KeyChar != GClass68.char_127 && (Control.ModifierKeys & (Keys.Control | Keys.Alt)) == Keys.None)
			{
				e.Handled = true;
				Class96.MessageBeep(0);
			}
		}

		Container container_0;

		GClass32 gclass32_0;

		Label label1;

		Button upButton;

		Button downButton;

		Button showButton;

		Button hideButton;

		Label label2;

		TextBox textBox1;

		CheckBox autoSizeCheckBox;

		GroupBox groupBox1;

		Button okButton;

		Button cancelButton;

		GControl2 columnListBox;
	}
}
