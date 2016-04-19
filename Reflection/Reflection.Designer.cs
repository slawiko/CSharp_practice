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
			this.FieldsGoupBox = new System.Windows.Forms.GroupBox();
			this.LoadButton = new System.Windows.Forms.Button();
			this.ControlsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BindingControlsHashSet)).BeginInit();
			this.DetailsGroupBox.SuspendLayout();
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
			this.ControlsListBox.Size = new System.Drawing.Size(182, 329);
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
			this.ControlsGroupBox.Size = new System.Drawing.Size(194, 364);
			this.ControlsGroupBox.TabIndex = 0;
			this.ControlsGroupBox.TabStop = false;
			this.ControlsGroupBox.Text = "Finded controls:";
			// 
			// DetailsGroupBox
			// 
			this.DetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DetailsGroupBox.Controls.Add(this.FieldsGoupBox);
			this.DetailsGroupBox.Location = new System.Drawing.Point(213, 13);
			this.DetailsGroupBox.Name = "DetailsGroupBox";
			this.DetailsGroupBox.Size = new System.Drawing.Size(385, 334);
			this.DetailsGroupBox.TabIndex = 1;
			this.DetailsGroupBox.TabStop = false;
			this.DetailsGroupBox.Text = "Details:";
			// 
			// FieldsGoupBox
			// 
			this.FieldsGoupBox.Location = new System.Drawing.Point(7, 20);
			this.FieldsGoupBox.Name = "FieldsGoupBox";
			this.FieldsGoupBox.Size = new System.Drawing.Size(186, 105);
			this.FieldsGoupBox.TabIndex = 0;
			this.FieldsGoupBox.TabStop = false;
			this.FieldsGoupBox.Text = "Fields:";
			// 
			// LoadButton
			// 
			this.LoadButton.Location = new System.Drawing.Point(214, 353);
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
			this.ClientSize = new System.Drawing.Size(610, 389);
			this.Controls.Add(this.LoadButton);
			this.Controls.Add(this.DetailsGroupBox);
			this.Controls.Add(this.ControlsGroupBox);
			this.Name = "Reflection";
			this.Text = "Reflection";
			this.Load += new System.EventHandler(this.Reflection_Load);
			this.ControlsGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BindingControlsHashSet)).EndInit();
			this.DetailsGroupBox.ResumeLayout(false);
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
	}
}

