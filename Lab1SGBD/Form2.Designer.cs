
namespace Lab1SGBD
{
	partial class Form2
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
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bttnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.SuspendLayout();
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(100, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add in tabel Ore";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(181, 80);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(147, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(16, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 51);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ora la care doriti sa tineti cursul:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// bttnAdd
			// 
			this.bttnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
			this.bttnAdd.Location = new System.Drawing.Point(142, 128);
			this.bttnAdd.Name = "bttnAdd";
			this.bttnAdd.Size = new System.Drawing.Size(75, 23);
			this.bttnAdd.TabIndex = 3;
			this.bttnAdd.Text = "Add";
			this.bttnAdd.UseVisualStyleBackColor = false;
			this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(77)))), ((int)(((byte)(99)))));
			this.ClientSize = new System.Drawing.Size(359, 173);
			this.Controls.Add(this.bttnAdd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Add Hour";
			this.Load += new System.EventHandler(this.UpDate_Load);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttnAdd;
    }
}