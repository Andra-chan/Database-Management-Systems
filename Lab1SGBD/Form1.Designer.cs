
namespace Lab1SGBD
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.id_grupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.toolTipShow = new System.Windows.Forms.ToolTip(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_gr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_grupa,
            this.numar});
			this.dataGridView1.Location = new System.Drawing.Point(16, 74);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(324, 423);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// id_grupa
			// 
			this.id_grupa.HeaderText = "id_grupa";
			this.id_grupa.MinimumWidth = 6;
			this.id_grupa.Name = "id_grupa";
			this.id_grupa.Width = 125;
			// 
			// numar
			// 
			this.numar.HeaderText = "numar";
			this.numar.MinimumWidth = 6;
			this.numar.Name = "numar";
			this.numar.Width = 125;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
			this.button1.Location = new System.Drawing.Point(360, 91);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 39);
			this.button1.TabIndex = 1;
			this.button1.Text = "Show";
			this.toolTipShow.SetToolTip(this.button1, "Show data for parent table.\r\n");
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ora,
            this.id_gr});
			this.dataGridView2.Location = new System.Drawing.Point(569, 74);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.Size = new System.Drawing.Size(393, 330);
			this.dataGridView2.TabIndex = 2;
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
			this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
			this.button2.Location = new System.Drawing.Point(747, 444);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 37);
			this.button2.TabIndex = 3;
			this.button2.Text = "Update";
			this.toolTipShow.SetToolTip(this.button2, "Click for update.\r\n");
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
			this.button3.Location = new System.Drawing.Point(604, 444);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 37);
			this.button3.TabIndex = 4;
			this.button3.Text = "Add";
			this.toolTipShow.SetToolTip(this.button3, "Add a new record to database.\r\n");
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip2.Name = "contextMenuStrip1";
			this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(581, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 29);
			this.label1.TabIndex = 5;
			this.label1.Text = "Tabel Ore";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(53, 27);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 29);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tabel Grupe";
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.Width = 125;
			// 
			// ora
			// 
			this.ora.HeaderText = "ora";
			this.ora.MinimumWidth = 6;
			this.ora.Name = "ora";
			this.ora.Width = 125;
			// 
			// id_gr
			// 
			this.id_gr.HeaderText = "id_gr";
			this.id_gr.MinimumWidth = 6;
			this.id_gr.Name = "id_gr";
			this.id_gr.Width = 125;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(77)))), ((int)(((byte)(99)))));
			this.ClientSize = new System.Drawing.Size(991, 512);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Lab1SGBD";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTipShow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_grupa;
		private System.Windows.Forms.DataGridViewTextBoxColumn numar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn ora;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_gr;
	}
}

