using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace ListManagerApp
{
	partial class ListForm
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
			this.PointsList = new System.Windows.Forms.ListBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.AddTextBox = new System.Windows.Forms.TextBox();
			this.UndoButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SortButton = new System.Windows.Forms.Button();
			this.FormatButton = new System.Windows.Forms.Button();
			this.LongRadioButton = new System.Windows.Forms.RadioButton();
			this.AddGroupBox = new System.Windows.Forms.GroupBox();
			this.RemoveGroupBox = new System.Windows.Forms.GroupBox();
			this.UndoGroupBox = new System.Windows.Forms.GroupBox();
			this.SortGroupBox = new System.Windows.Forms.GroupBox();
			this.FormatGroupBox = new System.Windows.Forms.GroupBox();
			this.JSONRadioButton = new System.Windows.Forms.RadioButton();
			this.TagRadioButton = new System.Windows.Forms.RadioButton();
			this.ShortRadioButton = new System.Windows.Forms.RadioButton();
			this.LoadButton = new System.Windows.Forms.Button();
			this.LoadCommandDialog = new System.Windows.Forms.OpenFileDialog();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SaveCommandDialog = new System.Windows.Forms.SaveFileDialog();
			this.AddGroupBox.SuspendLayout();
			this.RemoveGroupBox.SuspendLayout();
			this.UndoGroupBox.SuspendLayout();
			this.SortGroupBox.SuspendLayout();
			this.FormatGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// PointsList
			// 
			this.PointsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.PointsList.FormattingEnabled = true;
			this.PointsList.HorizontalScrollbar = true;
			this.PointsList.Location = new System.Drawing.Point(12, 12);
			this.PointsList.Name = "PointsList";
			this.PointsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.PointsList.Size = new System.Drawing.Size(122, 316);
			this.PointsList.TabIndex = 7;
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(86, 19);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(60, 20);
			this.AddButton.TabIndex = 1;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(6, 19);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(60, 20);
			this.RemoveButton.TabIndex = 0;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// AddTextBox
			// 
			this.AddTextBox.Location = new System.Drawing.Point(6, 19);
			this.AddTextBox.Name = "AddTextBox";
			this.AddTextBox.Size = new System.Drawing.Size(74, 20);
			this.AddTextBox.TabIndex = 0;
			// 
			// UndoButton
			// 
			this.UndoButton.Location = new System.Drawing.Point(6, 19);
			this.UndoButton.Name = "UndoButton";
			this.UndoButton.Size = new System.Drawing.Size(60, 20);
			this.UndoButton.TabIndex = 0;
			this.UndoButton.Text = "Undo";
			this.UndoButton.UseVisualStyleBackColor = true;
			this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ExitButton.Location = new System.Drawing.Point(274, 320);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(62, 20);
			this.ExitButton.TabIndex = 8;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// SortButton
			// 
			this.SortButton.Location = new System.Drawing.Point(6, 19);
			this.SortButton.Name = "SortButton";
			this.SortButton.Size = new System.Drawing.Size(60, 20);
			this.SortButton.TabIndex = 0;
			this.SortButton.Text = "Sort";
			this.SortButton.UseVisualStyleBackColor = true;
			this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
			// 
			// FormatButton
			// 
			this.FormatButton.Location = new System.Drawing.Point(130, 19);
			this.FormatButton.Name = "FormatButton";
			this.FormatButton.Size = new System.Drawing.Size(60, 20);
			this.FormatButton.TabIndex = 4;
			this.FormatButton.Text = "Format";
			this.FormatButton.UseVisualStyleBackColor = true;
			this.FormatButton.Click += new System.EventHandler(this.FormatButton_Click);
			// 
			// LongRadioButton
			// 
			this.LongRadioButton.AutoSize = true;
			this.LongRadioButton.Location = new System.Drawing.Point(6, 19);
			this.LongRadioButton.Name = "LongRadioButton";
			this.LongRadioButton.Size = new System.Drawing.Size(49, 17);
			this.LongRadioButton.TabIndex = 0;
			this.LongRadioButton.TabStop = true;
			this.LongRadioButton.Text = "Long";
			this.LongRadioButton.UseVisualStyleBackColor = true;
			this.LongRadioButton.CheckedChanged += new System.EventHandler(this.LongRadioButton_CheckedChanged);
			// 
			// AddGroupBox
			// 
			this.AddGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddGroupBox.Controls.Add(this.AddTextBox);
			this.AddGroupBox.Controls.Add(this.AddButton);
			this.AddGroupBox.Location = new System.Drawing.Point(140, 12);
			this.AddGroupBox.Name = "AddGroupBox";
			this.AddGroupBox.Size = new System.Drawing.Size(196, 50);
			this.AddGroupBox.TabIndex = 0;
			this.AddGroupBox.TabStop = false;
			this.AddGroupBox.Text = "Enter two integers:";
			// 
			// RemoveGroupBox
			// 
			this.RemoveGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveGroupBox.Controls.Add(this.RemoveButton);
			this.RemoveGroupBox.Location = new System.Drawing.Point(140, 68);
			this.RemoveGroupBox.Name = "RemoveGroupBox";
			this.RemoveGroupBox.Size = new System.Drawing.Size(196, 50);
			this.RemoveGroupBox.TabIndex = 1;
			this.RemoveGroupBox.TabStop = false;
			this.RemoveGroupBox.Text = "Choose item(s):";
			// 
			// UndoGroupBox
			// 
			this.UndoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UndoGroupBox.Controls.Add(this.UndoButton);
			this.UndoGroupBox.Location = new System.Drawing.Point(140, 124);
			this.UndoGroupBox.Name = "UndoGroupBox";
			this.UndoGroupBox.Size = new System.Drawing.Size(196, 50);
			this.UndoGroupBox.TabIndex = 2;
			this.UndoGroupBox.TabStop = false;
			this.UndoGroupBox.Text = "Undo last command:";
			// 
			// SortGroupBox
			// 
			this.SortGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SortGroupBox.Controls.Add(this.SortButton);
			this.SortGroupBox.Location = new System.Drawing.Point(140, 180);
			this.SortGroupBox.Name = "SortGroupBox";
			this.SortGroupBox.Size = new System.Drawing.Size(196, 50);
			this.SortGroupBox.TabIndex = 3;
			this.SortGroupBox.TabStop = false;
			this.SortGroupBox.Text = "Sort:";
			// 
			// FormatGroupBox
			// 
			this.FormatGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FormatGroupBox.Controls.Add(this.JSONRadioButton);
			this.FormatGroupBox.Controls.Add(this.TagRadioButton);
			this.FormatGroupBox.Controls.Add(this.ShortRadioButton);
			this.FormatGroupBox.Controls.Add(this.FormatButton);
			this.FormatGroupBox.Controls.Add(this.LongRadioButton);
			this.FormatGroupBox.Location = new System.Drawing.Point(140, 236);
			this.FormatGroupBox.Name = "FormatGroupBox";
			this.FormatGroupBox.Size = new System.Drawing.Size(196, 70);
			this.FormatGroupBox.TabIndex = 4;
			this.FormatGroupBox.TabStop = false;
			this.FormatGroupBox.Text = "Choose format:";
			// 
			// JSONRadioButton
			// 
			this.JSONRadioButton.AutoSize = true;
			this.JSONRadioButton.Location = new System.Drawing.Point(61, 43);
			this.JSONRadioButton.Name = "JSONRadioButton";
			this.JSONRadioButton.Size = new System.Drawing.Size(53, 17);
			this.JSONRadioButton.TabIndex = 3;
			this.JSONRadioButton.TabStop = true;
			this.JSONRadioButton.Text = "JSON";
			this.JSONRadioButton.UseVisualStyleBackColor = true;
			this.JSONRadioButton.CheckedChanged += new System.EventHandler(this.JSONRadioButton_CheckedChanged);
			// 
			// TagRadioButton
			// 
			this.TagRadioButton.AutoSize = true;
			this.TagRadioButton.Location = new System.Drawing.Point(61, 19);
			this.TagRadioButton.Name = "TagRadioButton";
			this.TagRadioButton.Size = new System.Drawing.Size(44, 17);
			this.TagRadioButton.TabIndex = 2;
			this.TagRadioButton.TabStop = true;
			this.TagRadioButton.Text = "Tag";
			this.TagRadioButton.UseVisualStyleBackColor = true;
			this.TagRadioButton.CheckedChanged += new System.EventHandler(this.TagRadioButton_CheckedChanged);
			// 
			// ShortRadioButton
			// 
			this.ShortRadioButton.AutoSize = true;
			this.ShortRadioButton.Location = new System.Drawing.Point(6, 43);
			this.ShortRadioButton.Name = "ShortRadioButton";
			this.ShortRadioButton.Size = new System.Drawing.Size(50, 17);
			this.ShortRadioButton.TabIndex = 1;
			this.ShortRadioButton.TabStop = true;
			this.ShortRadioButton.Text = "Short";
			this.ShortRadioButton.UseVisualStyleBackColor = true;
			this.ShortRadioButton.CheckedChanged += new System.EventHandler(this.ShortRadioButton_CheckedChanged);
			// 
			// LoadButton
			// 
			this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LoadButton.Location = new System.Drawing.Point(142, 320);
			this.LoadButton.Name = "LoadButton";
			this.LoadButton.Size = new System.Drawing.Size(60, 20);
			this.LoadButton.TabIndex = 5;
			this.LoadButton.Text = "Load";
			this.LoadButton.UseVisualStyleBackColor = true;
			this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.Location = new System.Drawing.Point(208, 320);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(60, 20);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// ListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 351);
			this.Controls.Add(this.LoadButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.FormatGroupBox);
			this.Controls.Add(this.SortGroupBox);
			this.Controls.Add(this.UndoGroupBox);
			this.Controls.Add(this.RemoveGroupBox);
			this.Controls.Add(this.AddGroupBox);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.PointsList);
			this.MinimumSize = new System.Drawing.Size(360, 390);
			this.Name = "ListForm";
			this.Text = "List";
			this.Load += new System.EventHandler(this.ListForm_Load);
			this.AddGroupBox.ResumeLayout(false);
			this.AddGroupBox.PerformLayout();
			this.RemoveGroupBox.ResumeLayout(false);
			this.UndoGroupBox.ResumeLayout(false);
			this.SortGroupBox.ResumeLayout(false);
			this.FormatGroupBox.ResumeLayout(false);
			this.FormatGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox PointsList;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.TextBox AddTextBox;
		private System.Windows.Forms.Button UndoButton;
		private Button ExitButton;
		private Button SortButton;
		private Button FormatButton;
		private RadioButton LongRadioButton;
		private GroupBox AddGroupBox;
		private GroupBox RemoveGroupBox;
		private GroupBox UndoGroupBox;
		private GroupBox SortGroupBox;
		private GroupBox FormatGroupBox;
		private RadioButton JSONRadioButton;
		private RadioButton TagRadioButton;
		private RadioButton ShortRadioButton;
		private Button LoadButton;
		private OpenFileDialog LoadCommandDialog;
		private Button SaveButton;
		private SaveFileDialog SaveCommandDialog;
	}
}

