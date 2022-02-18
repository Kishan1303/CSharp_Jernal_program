namespace navigation1
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
            this.tname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bsave = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.bfirst = new System.Windows.Forms.Button();
            this.bnext = new System.Windows.Forms.Button();
            this.bpreview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.blast = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tname
            // 
            this.tname.AutoSize = true;
            this.tname.Location = new System.Drawing.Point(12, 20);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(63, 13);
            this.tname.TabIndex = 0;
            this.tname.Text = "Enter Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 1;
            // 
            // bsave
            // 
            this.bsave.Location = new System.Drawing.Point(15, 58);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(75, 23);
            this.bsave.TabIndex = 2;
            this.bsave.Text = "Save";
            this.bsave.UseVisualStyleBackColor = true;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // bclear
            // 
            this.bclear.Location = new System.Drawing.Point(107, 58);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(75, 23);
            this.bclear.TabIndex = 3;
            this.bclear.Text = "clear";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // bfirst
            // 
            this.bfirst.Location = new System.Drawing.Point(197, 58);
            this.bfirst.Name = "bfirst";
            this.bfirst.Size = new System.Drawing.Size(75, 23);
            this.bfirst.TabIndex = 4;
            this.bfirst.Text = "First";
            this.bfirst.UseVisualStyleBackColor = true;
            this.bfirst.Click += new System.EventHandler(this.bfirst_Click);
            // 
            // bnext
            // 
            this.bnext.Location = new System.Drawing.Point(15, 99);
            this.bnext.Name = "bnext";
            this.bnext.Size = new System.Drawing.Size(75, 23);
            this.bnext.TabIndex = 5;
            this.bnext.Text = "Next";
            this.bnext.UseVisualStyleBackColor = true;
            this.bnext.Click += new System.EventHandler(this.bnext_Click);
            // 
            // bpreview
            // 
            this.bpreview.Location = new System.Drawing.Point(107, 99);
            this.bpreview.Name = "bpreview";
            this.bpreview.Size = new System.Drawing.Size(75, 23);
            this.bpreview.TabIndex = 6;
            this.bpreview.Text = "preview";
            this.bpreview.UseVisualStyleBackColor = true;
            this.bpreview.Click += new System.EventHandler(this.bpreview_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(319, 212);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // blast
            // 
            this.blast.Location = new System.Drawing.Point(197, 99);
            this.blast.Name = "blast";
            this.blast.Size = new System.Drawing.Size(75, 23);
            this.blast.TabIndex = 8;
            this.blast.Text = "Last";
            this.blast.UseVisualStyleBackColor = true;
            this.blast.Click += new System.EventHandler(this.blast_Click);
            // 
            // bdelete
            // 
            this.bdelete.Location = new System.Drawing.Point(15, 145);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(75, 23);
            this.bdelete.TabIndex = 9;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 262);
            this.Controls.Add(this.bdelete);
            this.Controls.Add(this.blast);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bpreview);
            this.Controls.Add(this.bnext);
            this.Controls.Add(this.bfirst);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.bsave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tname);
            this.Name = "Form1";
            this.Text = "navigation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.Button bfirst;
        private System.Windows.Forms.Button bnext;
        private System.Windows.Forms.Button bpreview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button blast;
        private System.Windows.Forms.Button bdelete;
    }
}

