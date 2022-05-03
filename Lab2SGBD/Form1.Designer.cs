
namespace Lab2SGBD
{
	partial class Form1
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
			this.parentView = new System.Windows.Forms.DataGridView();
			this.childView = new System.Windows.Forms.DataGridView();
			this.Add = new System.Windows.Forms.Button();
			this.Update = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.parentLabel = new System.Windows.Forms.Label();
			this.childLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.parentView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.childView)).BeginInit();
			this.SuspendLayout();
			// 
			// parentView
			// 
			this.parentView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
			this.parentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.parentView.Location = new System.Drawing.Point(39, 72);
			this.parentView.Name = "parentView";
			this.parentView.Size = new System.Drawing.Size(317, 196);
			this.parentView.TabIndex = 0;
			// 
			// childView
			// 
			this.childView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
			this.childView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.childView.Location = new System.Drawing.Point(441, 72);
			this.childView.Name = "childView";
			this.childView.Size = new System.Drawing.Size(317, 196);
			this.childView.TabIndex = 1;
			// 
			// Add
			// 
			this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
			this.Add.Location = new System.Drawing.Point(441, 360);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(75, 23);
			this.Add.TabIndex = 2;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = false;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Update
			// 
			this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
			this.Update.Location = new System.Drawing.Point(562, 360);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(75, 23);
			this.Update.TabIndex = 4;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = false;
			this.Update.Click += new System.EventHandler(this.Update_Click);
			// 
			// Delete
			// 
			this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
			this.Delete.Location = new System.Drawing.Point(683, 360);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(75, 23);
			this.Delete.TabIndex = 5;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = false;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// parentLabel
			// 
			this.parentLabel.AutoSize = true;
			this.parentLabel.ForeColor = System.Drawing.Color.White;
			this.parentLabel.Location = new System.Drawing.Point(147, 38);
			this.parentLabel.Name = "parentLabel";
			this.parentLabel.Size = new System.Drawing.Size(63, 13);
			this.parentLabel.TabIndex = 7;
			this.parentLabel.Text = "parentLabel";
			// 
			// childLabel
			// 
			this.childLabel.AutoSize = true;
			this.childLabel.ForeColor = System.Drawing.Color.White;
			this.childLabel.Location = new System.Drawing.Point(582, 38);
			this.childLabel.Name = "childLabel";
			this.childLabel.Size = new System.Drawing.Size(55, 13);
			this.childLabel.TabIndex = 8;
			this.childLabel.Text = "childLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(77)))), ((int)(((byte)(99)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.childLabel);
			this.Controls.Add(this.parentLabel);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.childView);
			this.Controls.Add(this.parentView);
			this.Name = "Form1";
			this.Text = "Lab2SGBD";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.parentView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.childView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView parentView;
		private System.Windows.Forms.DataGridView childView;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Label parentLabel;
		private System.Windows.Forms.Label childLabel;
	}
}

