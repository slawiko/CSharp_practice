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
			this.ExampleGroupBox = new System.Windows.Forms.GroupBox();
			this.PropertiesGroupBox = new System.Windows.Forms.GroupBox();
			this.PropertiesListBox = new System.Windows.Forms.ListBox();
			this.AttributesGroupBox = new System.Windows.Forms.GroupBox();
			this.AttributesListBox = new System.Windows.Forms.ListBox();
			this.EventsGroupBox = new System.Windows.Forms.GroupBox();
			this.EventsListBox = new System.Windows.Forms.ListBox();
			this.MethodsGroupBox = new System.Windows.Forms.GroupBox();
			this.MethodsListBox = new System.Windows.Forms.ListBox();
			this.FieldsGoupBox = new System.Windows.Forms.GroupBox();
			this.FieldListBox = new System.Windows.Forms.ListBox();
			this.LoadButton = new System.Windows.Forms.Button();
			this.ControlsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BindingControlsHashSet)).BeginInit();
			this.DetailsGroupBox.SuspendLayout();
			this.PropertiesGroupBox.SuspendLayout();
			this.AttributesGroupBox.SuspendLayout();
			this.EventsGroupBox.SuspendLayout();
			this.MethodsGroupBox.SuspendLayout();
			this.FieldsGoupBox.SuspendLayout();
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
			this.ControlsListBox.Size = new System.Drawing.Size(216, 355);
			this.ControlsListBox.TabIndex = 1;
			this.ControlsListBox.SelectedIndexChanged += new System.EventHandler(this.ControlsListBox_SelectedIndexChanged);
			// 
			// ControlsGroupBox
			// 
			this.ControlsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.ControlsGroupBox.Controls.Add(this.ControlsListBox);
			this.ControlsGroupBox.Location = new System.Drawing.Point(13, 13);
			this.ControlsGroupBox.Name = "ControlsGroupBox";
			this.ControlsGroupBox.Size = new System.Drawing.Size(228, 400);
			this.ControlsGroupBox.TabIndex = 0;
			this.ControlsGroupBox.TabStop = false;
			this.ControlsGroupBox.Text = "Finded controls:";
			// 
			// DetailsGroupBox
			// 
			this.DetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DetailsGroupBox.Controls.Add(this.ExampleGroupBox);
			this.DetailsGroupBox.Controls.Add(this.PropertiesGroupBox);
			this.DetailsGroupBox.Controls.Add(this.AttributesGroupBox);
			this.DetailsGroupBox.Controls.Add(this.EventsGroupBox);
			this.DetailsGroupBox.Controls.Add(this.MethodsGroupBox);
			this.DetailsGroupBox.Controls.Add(this.FieldsGoupBox);
			this.DetailsGroupBox.Location = new System.Drawing.Point(247, 13);
			this.DetailsGroupBox.Name = "DetailsGroupBox";
			this.DetailsGroupBox.Size = new System.Drawing.Size(688, 367);
			this.DetailsGroupBox.TabIndex = 1;
			this.DetailsGroupBox.TabStop = false;
			this.DetailsGroupBox.Text = "Details:";
			// 
			// ExampleGroupBox
			// 
			this.ExampleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ExampleGroupBox.Location = new System.Drawing.Point(459, 195);
			this.ExampleGroupBox.Name = "ExampleGroupBox";
			this.ExampleGroupBox.Size = new System.Drawing.Size(219, 166);
			this.ExampleGroupBox.TabIndex = 5;
			this.ExampleGroupBox.TabStop = false;
			this.ExampleGroupBox.Text = "Example:";
			// 
			// PropertiesGroupBox
			// 
			this.PropertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PropertiesGroupBox.Controls.Add(this.PropertiesListBox);
			this.PropertiesGroupBox.Location = new System.Drawing.Point(458, 20);
			this.PropertiesGroupBox.Name = "PropertiesGroupBox";
			this.PropertiesGroupBox.Size = new System.Drawing.Size(220, 170);
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
			this.PropertiesListBox.Size = new System.Drawing.Size(207, 134);
			this.PropertiesListBox.TabIndex = 0;
			// 
			// AttributesGroupBox
			// 
			this.AttributesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AttributesGroupBox.Controls.Add(this.AttributesListBox);
			this.AttributesGroupBox.Location = new System.Drawing.Point(6, 195);
			this.AttributesGroupBox.Name = "AttributesGroupBox";
			this.AttributesGroupBox.Size = new System.Drawing.Size(220, 166);
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
			this.AttributesListBox.Size = new System.Drawing.Size(207, 134);
			this.AttributesListBox.TabIndex = 0;
			// 
			// EventsGroupBox
			// 
			this.EventsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.EventsGroupBox.Controls.Add(this.EventsListBox);
			this.EventsGroupBox.Location = new System.Drawing.Point(232, 195);
			this.EventsGroupBox.Name = "EventsGroupBox";
			this.EventsGroupBox.Size = new System.Drawing.Size(220, 166);
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
			this.EventsListBox.Size = new System.Drawing.Size(207, 134);
			this.EventsListBox.TabIndex = 0;
			// 
			// MethodsGroupBox
			// 
			this.MethodsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.MethodsGroupBox.Controls.Add(this.MethodsListBox);
			this.MethodsGroupBox.Location = new System.Drawing.Point(232, 20);
			this.MethodsGroupBox.Name = "MethodsGroupBox";
			this.MethodsGroupBox.Size = new System.Drawing.Size(220, 170);
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
			this.MethodsListBox.Size = new System.Drawing.Size(213, 134);
			this.MethodsListBox.TabIndex = 0;
			// 
			// FieldsGoupBox
			// 
			this.FieldsGoupBox.Controls.Add(this.FieldListBox);
			this.FieldsGoupBox.Location = new System.Drawing.Point(6, 20);
			this.FieldsGoupBox.Name = "FieldsGoupBox";
			this.FieldsGoupBox.Size = new System.Drawing.Size(220, 170);
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
			this.FieldListBox.Size = new System.Drawing.Size(207, 134);
			this.FieldListBox.TabIndex = 0;
			// 
			// LoadButton
			// 
			this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LoadButton.Location = new System.Drawing.Point(860, 390);
			this.LoadButton.Name = "LoadButton";
			this.LoadButton.Size = new System.Drawing.Size(75, 23);
			this.LoadButton.TabIndex = 2;
			this.LoadButton.Text = "Load";
			this.LoadButton.UseVisualStyleBackColor = true;
			this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
			// 
			// Reflection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 425);
			this.Controls.Add(this.DetailsGroupBox);
			this.Controls.Add(this.LoadButton);
			this.Controls.Add(this.ControlsGroupBox);
			this.MinimumSize = new System.Drawing.Size(963, 464);
			this.Name = "Reflection";
			this.Text = "Reflection";
			this.ControlsGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BindingControlsHashSet)).EndInit();
			this.DetailsGroupBox.ResumeLayout(false);
			this.PropertiesGroupBox.ResumeLayout(false);
			this.AttributesGroupBox.ResumeLayout(false);
			this.EventsGroupBox.ResumeLayout(false);
			this.MethodsGroupBox.ResumeLayout(false);
			this.FieldsGoupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog OpenBuildDialog;
		private System.Windows.Forms.ListBox ControlsListBox;
		private System.Windows.Forms.GroupBox ControlsGroupBox;
		private System.Windows.Forms.BindingSource BindingControlsHashSet;
		private System.Windows.Forms.GroupBox DetailsGroupBox;
		private System.Windows.Forms.GroupBox FieldsGoupBox;
		private System.Windows.Forms.Button LoadButton;
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
	}
}

