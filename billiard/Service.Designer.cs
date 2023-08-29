namespace billiard
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.table = new System.Windows.Forms.DataGridView();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.vis_tb = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.viritorrb = new System.Windows.Forms.RadioButton();
            this.barrb = new System.Windows.Forms.RadioButton();
            this.souvenirrb = new System.Windows.Forms.RadioButton();
            this.bar_tb = new System.Windows.Forms.TextBox();
            this.souvenir_tb = new System.Windows.Forms.TextBox();
            this.return_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(43, 82);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(557, 213);
            this.table.TabIndex = 0;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // search_tb
            // 
            this.search_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.search_tb.BackColor = System.Drawing.Color.White;
            this.search_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_tb.Location = new System.Drawing.Point(90, 336);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(177, 25);
            this.search_tb.TabIndex = 66;
            // 
            // vis_tb
            // 
            this.vis_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vis_tb.BackColor = System.Drawing.Color.White;
            this.vis_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vis_tb.Location = new System.Drawing.Point(423, 308);
            this.vis_tb.Name = "vis_tb";
            this.vis_tb.Size = new System.Drawing.Size(177, 25);
            this.vis_tb.TabIndex = 67;
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(423, 401);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(177, 33);
            this.add_button.TabIndex = 68;
            this.add_button.Text = "Добавить в чек";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // viritorrb
            // 
            this.viritorrb.AutoSize = true;
            this.viritorrb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viritorrb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.viritorrb.Location = new System.Drawing.Point(44, 54);
            this.viritorrb.Name = "viritorrb";
            this.viritorrb.Size = new System.Drawing.Size(100, 21);
            this.viritorrb.TabIndex = 69;
            this.viritorrb.TabStop = true;
            this.viritorrb.Text = "Посетители";
            this.viritorrb.UseVisualStyleBackColor = true;
            this.viritorrb.CheckedChanged += new System.EventHandler(this.viritorrb_CheckedChanged);
            // 
            // barrb
            // 
            this.barrb.AutoSize = true;
            this.barrb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barrb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.barrb.Location = new System.Drawing.Point(150, 54);
            this.barrb.Name = "barrb";
            this.barrb.Size = new System.Drawing.Size(49, 21);
            this.barrb.TabIndex = 71;
            this.barrb.TabStop = true;
            this.barrb.Text = "Бар";
            this.barrb.UseVisualStyleBackColor = true;
            this.barrb.CheckedChanged += new System.EventHandler(this.barrb_CheckedChanged);
            // 
            // souvenirrb
            // 
            this.souvenirrb.AutoSize = true;
            this.souvenirrb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.souvenirrb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.souvenirrb.Location = new System.Drawing.Point(205, 54);
            this.souvenirrb.Name = "souvenirrb";
            this.souvenirrb.Size = new System.Drawing.Size(91, 21);
            this.souvenirrb.TabIndex = 72;
            this.souvenirrb.TabStop = true;
            this.souvenirrb.Text = "Сувениры";
            this.souvenirrb.UseVisualStyleBackColor = true;
            this.souvenirrb.CheckedChanged += new System.EventHandler(this.souvenirrb_CheckedChanged);
            // 
            // bar_tb
            // 
            this.bar_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bar_tb.BackColor = System.Drawing.Color.White;
            this.bar_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bar_tb.Location = new System.Drawing.Point(423, 336);
            this.bar_tb.Name = "bar_tb";
            this.bar_tb.Size = new System.Drawing.Size(177, 25);
            this.bar_tb.TabIndex = 73;
            // 
            // souvenir_tb
            // 
            this.souvenir_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.souvenir_tb.BackColor = System.Drawing.Color.White;
            this.souvenir_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.souvenir_tb.Location = new System.Drawing.Point(423, 364);
            this.souvenir_tb.Name = "souvenir_tb";
            this.souvenir_tb.Size = new System.Drawing.Size(177, 25);
            this.souvenir_tb.TabIndex = 74;
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.return_button.BackgroundImage = global::billiard.Properties.Resources._return;
            this.return_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.return_button.Location = new System.Drawing.Point(33, 4);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(51, 44);
            this.return_button.TabIndex = 75;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click_1);
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.search_button.BackColor = System.Drawing.Color.Transparent;
            this.search_button.BackgroundImage = global::billiard.Properties.Resources.search;
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.search_button.Location = new System.Drawing.Point(33, 324);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(51, 45);
            this.search_button.TabIndex = 65;
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_button.BackColor = System.Drawing.Color.Transparent;
            this.save_button.BackgroundImage = global::billiard.Properties.Resources.save;
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.save_button.Location = new System.Drawing.Point(553, 12);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(47, 44);
            this.save_button.TabIndex = 63;
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(644, 446);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.souvenir_tb);
            this.Controls.Add(this.bar_tb);
            this.Controls.Add(this.souvenirrb);
            this.Controls.Add(this.barrb);
            this.Controls.Add(this.viritorrb);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.vis_tb);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(660, 485);
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Visitor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_tb;
        public System.Windows.Forms.TextBox vis_tb;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.RadioButton viritorrb;
        private System.Windows.Forms.RadioButton barrb;
        private System.Windows.Forms.RadioButton souvenirrb;
        public System.Windows.Forms.TextBox bar_tb;
        public System.Windows.Forms.TextBox souvenir_tb;
        private System.Windows.Forms.Button return_button;
    }
}