namespace Reflection
{
	partial class Reflection
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.OpenBuildDialog = new System.Windows.Forms.OpenFileDialog();
			this.ControlsListBox = new System.Windows.Forms.ListBox();
			this.ControlsGroupBox = new System.Windows.Forms.GroupBox();
			this.BindingControlsHashSet = new System.Windows.Forms.BindingSource(this.components);
			this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.PropertiesGroupBox = new System.Windows.Forms.GroupBox();
			this.PropertiesListBox = new System.Windows.Forms.ListBox();
			this.FieldsGoupBox = new System.Windows.Forms.GroupBox();
			this.FieldListBox = new System.Windows.Forms.ListBox();
			this.EventsGroupBox = new System.Windows.Forms.GroupBox();
			this.EventsListBox = new System.Windows.Forms.ListBox();
			this.AttributesGroupBox = new System.Windows.Forms.GroupBox();
			this.AttributesListBox = new System.Windows.Forms.ListBox();
			this.ExampleGroupBox = new System.Windows.Forms.GroupBox();
			this.MethodsGroupBox = new System.Windows.Forms.GroupBox();
			this.MethodsListBox = new System.Windows.Forms.ListBox();
			this.ExitButton = new System.Windows.Forms.Button();
			this.LoadBuildButton = new System.Windows.Forms.Button();
			this.SaveXMLButton = new System.Windows.Forms.Button();
			this.LoadXMLButton = new System.Windows.Forms.Button();
			this.GeneralTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.SaveXMLDialog = new System.Windows.Forms.SaveFileDialog();
			this.ControlsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BindingControlsHashSet)).BeginInit();
			this.DetailsGroupBox.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.PropertiesGroupBox.SuspendLayout();
			this.FieldsGoupBox.SuspendLayout();
			this.EventsGroupBox.SuspendLayout();
			this.AttributesGroupBox.SuspendLayout();
			this.MethodsGroupBox.SuspendLayout();
			this.GeneralTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ControlsListBox
			// 
			this.ControlsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ControlsListBox.FormattingEnabled = true;
			this.ControlsListBox.HorizontalScrollbar = true;
			this.ControlsListBox.Location = new System.Drawing.Point(6, 19);
			this.ControlsListBox.Name = "ControlsListBox";
			this.ControlsListBox.Size = new System.Drawing.Size(212, 355);
			this.ControlsListBox.TabIndex = 1;
			this.ControlsListBox.SelectedIndexChanged += new System.EventHandler(this.ControlsListBox_SelectedIndexChanged);
			// 
			// ControlsGroupBox
			// 
			this.ControlsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ControlsGroupBox.Controls.Add(this.ControlsListBox);
			this.ControlsGroupBox.Location = new System.Drawing.Point(3, 3);
			this.ControlsGroupBox.Name = "ControlsGroupBox";
			this.ControlsGroupBox.Size = new System.Drawing.Size(224, 395);
			this.ControlsGroupBox.TabIndex = 0;
			this.ControlsGroupBox.TabStop = false;
			this.ControlsGroupBox.Text = "Finded controls:";
			// 
			// DetailsGroupBox
			// 
			this.DetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DetailsGroupBox.Controls.Add(this.tableLayoutPanel1);
			this.DetailsGroupBox.Controls.Add(this.ExitButton);
			this.DetailsGroupBox.Controls.Add(this.LoadBuildButton);
			this.DetailsGroupBox.Controls.Add(this.SaveXMLButton);
			this.DetailsGroupBox.Controls.Add(this.LoadXMLButton);
			this.DetailsGroupBox.Location = new System.Drawing.Point(233, 3);
			this.DetailsGroupBox.Name = "DetailsGroupBox";
			this.DetailsGroupBox.Size = new System.Drawing.Size(687, 395);
			this.DetailsGroupBox.TabIndex = 1;
			this.DetailsGroupBox.TabStop = false;
			this.DetailsGroupBox.Text = "Details:";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.PropertiesGroupBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.FieldsGoupBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.EventsGroupBox, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.AttributesGroupBox, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.ExampleGroupBox, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.MethodsGroupBox, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 340);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// PropertiesGroupBox
			// 
			this.PropertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PropertiesGroupBox.Controls.Add(this.PropertiesListBox);
			this.PropertiesGroupBox.Location = new System.Drawing.Point(3, 3);
			this.PropertiesGroupBox.Name = "PropertiesGroupBox";
			this.PropertiesGroupBox.Size = new System.Drawing.Size(219, 164);
			this.PropertiesGroupBox.TabIndex = 4;
			this.PropertiesGroupBox.TabStop = false;
			this.PropertiesGroupBox.Text = "Properties:";
			// 
			// PropertiesListBox
			// 
			this.PropertiesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PropertiesListBox.FormattingEnabled = true;
			this.PropertiesListBox.HorizontalScrollbar = true;
			this.PropertiesListBox.Location = new System.Drawing.Point(7, 20);
			this.PropertiesListBox.Name = "PropertiesListBox";
			this.PropertiesListBox.Size = new System.Drawing.Size(206, 121);
			this.PropertiesListBox.TabIndex = 0;
			// 
			// FieldsGoupBox
			// 
			this.FieldsGoupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FieldsGoupBox.Controls.Add(this.FieldListBox);
			this.FieldsGoupBox.Location = new System.Drawing.Point(228, 173);
			this.FieldsGoupBox.Name = "FieldsGoupBox";
			this.FieldsGoupBox.Size = new System.Drawing.Size(219, 164);
			this.FieldsGoupBox.TabIndex = 0;
			this.FieldsGoupBox.TabStop = false;
			this.FieldsGoupBox.Text = "Fields:";
			// 
			// FieldListBox
			// 
			this.FieldListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FieldListBox.FormattingEnabled = true;
			this.FieldListBox.HorizontalScrollbar = true;
			this.FieldListBox.Location = new System.Drawing.Point(7, 20);
			this.FieldListBox.Name = "FieldListBox";
			this.FieldListBox.Size = new System.Drawing.Size(206, 121);
			this.FieldListBox.TabIndex = 0;
			// 
			// EventsGroupBox
			// 
			this.EventsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EventsGroupBox.Controls.Add(this.EventsListBox);
			this.EventsGroupBox.Location = new System.Drawing.Point(453, 3);
			this.EventsGroupBox.Name = "EventsGroupBox";
			this.EventsGroupBox.Size = new System.Drawing.Size(219, 164);
			this.EventsGroupBox.TabIndex = 2;
			this.EventsGroupBox.TabStop = false;
			this.EventsGroupBox.Text = "Events:";
			// 
			// EventsListBox
			// 
			this.EventsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EventsListBox.FormattingEnabled = true;
			this.EventsListBox.HorizontalScrollbar = true;
			this.EventsListBox.Location = new System.Drawing.Point(7, 20);
			this.EventsListBox.Name = "EventsListBox";
			this.EventsListBox.Size = new System.Drawing.Size(206, 121);
			this.EventsListBox.TabIndex = 0;
			// 
			// AttributesGroupBox
			// 
			this.AttributesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AttributesGroupBox.Controls.Add(this.AttributesListBox);
			this.AttributesGroupBox.Location = new System.Drawing.Point(3, 173);
			this.AttributesGroupBox.Name = "AttributesGroupBox";
			this.AttributesGroupBox.Size = new System.Drawing.Size(219, 164);
			this.AttributesGroupBox.TabIndex = 3;
			this.AttributesGroupBox.TabStop = false;
			this.AttributesGroupBox.Text = "Attributes:";
			// 
			// AttributesListBox
			// 
			this.AttributesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AttributesListBox.FormattingEnabled = true;
			this.AttributesListBox.HorizontalScrollbar = true;
			this.AttributesListBox.Location = new System.Drawing.Point(7, 20);
			this.AttributesListBox.Name = "AttributesListBox";
			this.AttributesListBox.Size = new System.Drawing.Size(206, 121);
			this.AttributesListBox.TabIndex = 0;
			// 
			// ExampleGroupBox
			// 
			this.ExampleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ExampleGroupBox.Location = new System.Drawing.Point(453, 173);
			this.ExampleGroupBox.Name = "ExampleGroupBox";
			this.ExampleGroupBox.Size = new System.Drawing.Size(219, 164);
			this.ExampleGroupBox.TabIndex = 5;
			this.ExampleGroupBox.TabStop = false;
			this.ExampleGroupBox.Text = "Example:";
			// 
			// MethodsGroupBox
			// 
			this.MethodsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MethodsGroupBox.Controls.Add(this.MethodsListBox);
			this.MethodsGroupBox.Location = new System.Drawing.Point(228, 3);
			this.MethodsGroupBox.Name = "MethodsGroupBox";
			this.MethodsGroupBox.Size = new System.Drawing.Size(219, 164);
			this.MethodsGroupBox.TabIndex = 1;
			this.MethodsGroupBox.TabStop = false;
			this.MethodsGroupBox.Text = "Methods:";
			// 
			// MethodsListBox
			// 
			this.MethodsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MethodsListBox.FormattingEnabled = true;
			this.MethodsListBox.HorizontalScrollbar = true;
			this.MethodsListBox.Location = new System.Drawing.Point(1, 20);
			this.MethodsListBox.Name = "MethodsListBox";
			this.MethodsListBox.Size = new System.Drawing.Size(212, 121);
			this.MethodsListBox.TabIndex = 0;
			// 
			// ExitButton
			// 
			this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ExitButton.Location = new System.Drawing.Point(606, 366);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 5;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// LoadBuildButton
			// 
			this.LoadBuildButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LoadBuildButton.Location = new System.Drawing.Point(6, 366);
			this.LoadBuildButton.Name = "LoadBuildButton";
			this.LoadBuildButton.Size = new System.Drawing.Size(75, 23);
			this.LoadBuildButton.TabIndex = 2;
			this.LoadBuildButton.Text = "Load build";
			this.LoadBuildButton.UseVisualStyleBackColor = true;
			this.LoadBuildButton.Click += new System.EventHandler(this.LoadBuildButton_Click);
			// 
			// SaveXMLButton
			// 
			this.SaveXMLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveXMLButton.Location = new System.Drawing.Point(411, 366);
			this.SaveXMLButton.Name = "SaveXMLButton";
			this.SaveXMLButton.Size = new System.Drawing.Size(75, 23);
			this.SaveXMLButton.TabIndex = 4;
			this.SaveXMLButton.Text = "Save XML";
			this.SaveXMLButton.UseVisualStyleBackColor = true;
			this.SaveXMLButton.Click += new System.EventHandler(this.SaveXMLButton_Click);
			// 
			// LoadXMLButton
			// 
			this.LoadXMLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LoadXMLButton.Location = new System.Drawing.Point(492, 366);
			this.LoadXMLButton.Name = "LoadXMLButton";
			this.LoadXMLButton.Size = new System.Drawing.Size(75, 23);
			this.LoadXMLButton.TabIndex = 3;
			this.LoadXMLButton.Text = "Load XML";
			this.LoadXMLButton.UseVisualStyleBackColor = true;
			// 
			// GeneralTableLayoutPanel
			// 
			this.GeneralTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GeneralTableLayoutPanel.ColumnCount = 2;
			this.GeneralTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.GeneralTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.GeneralTableLayoutPanel.Controls.Add(this.ControlsGroupBox, 0, 0);
			this.GeneralTableLayoutPanel.Controls.Add(this.DetailsGroupBox, 1, 0);
			this.GeneralTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
			this.GeneralTableLayoutPanel.Name = "GeneralTableLayoutPanel";
			this.GeneralTableLayoutPanel.RowCount = 1;
			this.GeneralTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.GeneralTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.GeneralTableLayoutPanel.Size = new System.Drawing.Size(923, 401);
			this.GeneralTableLayoutPanel.TabIndex = 2;
			// 
			// Reflection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 425);
			this.Controls.Add(this.GeneralTableLayoutPanel);
			this.MinimumSize = new System.Drawing.Size(963, 464);
			this.Name = "Reflection";
			this.Text = "Reflection";
			this.ControlsGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BindingControlsHashSet)).EndInit();
			this.DetailsGroupBox.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.PropertiesGroupBox.ResumeLayout(false);
			this.FieldsGoupBox.ResumeLayout(false);
			this.EventsGroupBox.ResumeLayout(false);
			this.AttributesGroupBox.ResumeLayout(false);
			this.MethodsGroupBox.ResumeLayout(false);
			this.GeneralTableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog OpenBuildDialog;
		private System.Windows.Forms.ListBox ControlsListBox;
		private System.Windows.Forms.GroupBox ControlsGroupBox;
		private System.Windows.Forms.BindingSource BindingControlsHashSet;
		private System.Windows.Forms.GroupBox DetailsGroupBox;
		private System.Windows.Forms.GroupBox FieldsGoupBox;
		private System.Windows.Forms.Button LoadBuildButton;
		private System.Windows.Forms.GroupBox AttributesGroupBox;
		private System.Windows.Forms.GroupBox EventsGroupBox;
		private System.Windows.Forms.GroupBox MethodsGroupBox;
		private System.Windows.Forms.ListBox FieldListBox;
		private System.Windows.Forms.ListBox MethodsListBox;
		private System.Windows.Forms.ListBox EventsListBox;
		private System.Windows.Forms.ListBox AttributesListBox;
		private System.Windows.Forms.GroupBox ExampleGroupBox;
		private System.Windows.Forms.GroupBox PropertiesGroupBox;
		private System.Windows.Forms.ListBox PropertiesListBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button LoadXMLButton;
		private System.Windows.Forms.Button SaveXMLButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.TableLayoutPanel GeneralTableLayoutPanel;
		private System.Windows.Forms.SaveFileDialog SaveXMLDialog;
	}
}

