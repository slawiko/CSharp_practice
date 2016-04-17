using System.Collections.Generic;
using System;
using ListManager.Command.Utils;
using System.Windows.Forms;

namespace ListManagerApp
{
	partial class ListForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private PointsTarget target;
		private LinkedList<ICommand> undoStack;
		private Dictionary<string, Type> commandDictionary;

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

		private void InitializeListManager()
		{
			this.target = new PointsTarget(new List<Point>());
			this.undoStack = new LinkedList<ICommand>();
			this.commandDictionary = new Dictionary<string, Type>();
			this.InitializeCommands();
		}

		private void InitializeCommands()
		{
			this.commandDictionary.Add("add", Type.GetType("ListManager.Command.AddCommand"));
			this.commandDictionary.Add("undo", Type.GetType("ListManager.Command.UndoCommand"));
			this.commandDictionary.Add("format", Type.GetType("ListManager.Command.FormatCommand"));
			this.commandDictionary.Add("list", Type.GetType("ListManager.Command.ListCommand"));
			this.commandDictionary.Add("load", Type.GetType("ListManager.Command.LoadCommand"));
			this.commandDictionary.Add("path", Type.GetType("ListManager.Command.PathCommand"));
			this.commandDictionary.Add("remove", Type.GetType("ListManager.Command.RemoveCommand"));
			this.commandDictionary.Add("save", Type.GetType("ListManager.Command.SaveCommand"));
			this.commandDictionary.Add("sort", Type.GetType("ListManager.Command.SortCommand"));
			this.commandDictionary.Add("exit", Type.GetType("ListManager.Command.ExitCommand"));
			this.commandDictionary.Add("quit", Type.GetType("ListManager.Command.QuitCommand"));
		}

		private void Execute(ICommand command, string[] args)
		{
			try
			{
				command.Execute(this.target, args, undoStack);
			}
			catch (NoSuchItemException nsi)
			{
				Console.WriteLine("No such item");
			}
			catch (InvalidArgumentsException ia)
			{
				Console.WriteLine("Invalid argument");
			}
			catch (UndoException u)
			{
				Console.WriteLine("Cannot undo");
			}
		}

		private Type Instance(string type)
		{
			Type instance;
			if (this.commandDictionary.TryGetValue(type, out instance))
			{ 
				return instance;
			}
			else
			{
				throw new UnsupportedCommandException();
			}
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
			this.SuspendLayout();
			// 
			// PointsList
			// 
			this.PointsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PointsList.FormattingEnabled = true;
			this.PointsList.Location = new System.Drawing.Point(12, 12);
			this.PointsList.Name = "PointsList";
			this.PointsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.PointsList.Size = new System.Drawing.Size(119, 264);
			this.PointsList.TabIndex = 0;
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.Location = new System.Drawing.Point(217, 12);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(62, 20);
			this.AddButton.TabIndex = 1;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveButton.Location = new System.Drawing.Point(217, 64);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(62, 20);
			this.RemoveButton.TabIndex = 2;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// AddTextBox
			// 
			this.AddTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddTextBox.Location = new System.Drawing.Point(137, 12);
			this.AddTextBox.Name = "AddTextBox";
			this.AddTextBox.Size = new System.Drawing.Size(74, 20);
			this.AddTextBox.TabIndex = 3;
			// 
			// UndoButton
			// 
			this.UndoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.UndoButton.Location = new System.Drawing.Point(217, 183);
			this.UndoButton.Name = "UndoButton";
			this.UndoButton.Size = new System.Drawing.Size(62, 20);
			this.UndoButton.TabIndex = 4;
			this.UndoButton.Text = "Undo";
			this.UndoButton.UseVisualStyleBackColor = true;
			this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ExitButton.Location = new System.Drawing.Point(217, 256);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(62, 20);
			this.ExitButton.TabIndex = 5;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// SortButton
			// 
			this.SortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SortButton.Location = new System.Drawing.Point(217, 38);
			this.SortButton.Name = "SortButton";
			this.SortButton.Size = new System.Drawing.Size(62, 20);
			this.SortButton.TabIndex = 6;
			this.SortButton.Text = "Sort";
			this.SortButton.UseVisualStyleBackColor = true;
			this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
			// 
			// ListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 288);
			this.Controls.Add(this.SortButton);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.UndoButton);
			this.Controls.Add(this.AddTextBox);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.PointsList);
			this.MaximumSize = new System.Drawing.Size(307, 600);
			this.MinimumSize = new System.Drawing.Size(307, 117);
			this.Name = "ListForm";
			this.Text = "List";
			this.Load += new System.EventHandler(this.ListForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox PointsList;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.TextBox AddTextBox;
		private System.Windows.Forms.Button UndoButton;
		private Button ExitButton;
		private Button SortButton;
	}
}

