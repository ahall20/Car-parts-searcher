namespace Parts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.search = new System.Windows.Forms.Button();
            this.Makelist = new System.Windows.Forms.ListBox();
            this.Modellist = new System.Windows.Forms.ListBox();
            this.Yearlist = new System.Windows.Forms.ListBox();
            this.Typelist = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(909, 213);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 29);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // Makelist
            // 
            this.Makelist.FormattingEnabled = true;
            this.Makelist.ItemHeight = 20;
            this.Makelist.Location = new System.Drawing.Point(374, 213);
            this.Makelist.Name = "Makelist";
            this.Makelist.Size = new System.Drawing.Size(120, 84);
            this.Makelist.TabIndex = 1;
            this.Makelist.SelectedIndexChanged += new System.EventHandler(this.Makelist_SelectedIndexChanged);
            // 
            // Modellist
            // 
            this.Modellist.FormattingEnabled = true;
            this.Modellist.ItemHeight = 20;
            this.Modellist.Location = new System.Drawing.Point(500, 213);
            this.Modellist.Name = "Modellist";
            this.Modellist.Size = new System.Drawing.Size(120, 84);
            this.Modellist.TabIndex = 2;
            this.Modellist.SelectedIndexChanged += new System.EventHandler(this.Modellist_SelectedIndexChanged);
            // 
            // Yearlist
            // 
            this.Yearlist.FormattingEnabled = true;
            this.Yearlist.ItemHeight = 20;
            this.Yearlist.Location = new System.Drawing.Point(626, 213);
            this.Yearlist.Name = "Yearlist";
            this.Yearlist.Size = new System.Drawing.Size(120, 84);
            this.Yearlist.TabIndex = 3;
            this.Yearlist.SelectedIndexChanged += new System.EventHandler(this.Yearlist_SelectedIndexChanged);
            // 
            // Typelist
            // 
            this.Typelist.FormattingEnabled = true;
            this.Typelist.ItemHeight = 20;
            this.Typelist.Location = new System.Drawing.Point(752, 213);
            this.Typelist.Name = "Typelist";
            this.Typelist.Size = new System.Drawing.Size(120, 84);
            this.Typelist.TabIndex = 4;
            this.Typelist.SelectedIndexChanged += new System.EventHandler(this.Typelist_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Make";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(500, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Model";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(626, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Year";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(752, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Type";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1026, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1594, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Typelist);
            this.Controls.Add(this.Yearlist);
            this.Controls.Add(this.Modellist);
            this.Controls.Add(this.Makelist);
            this.Controls.Add(this.search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListBox Makelist;
        private System.Windows.Forms.ListBox Modellist;
        private System.Windows.Forms.ListBox Yearlist;
        private System.Windows.Forms.ListBox Typelist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
    }
}

