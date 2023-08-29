namespace billiard
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.sum_button = new System.Windows.Forms.Button();
            this.visitor_tb = new System.Windows.Forms.TextBox();
            this.bar_tb = new System.Windows.Forms.TextBox();
            this.souvenir_tb = new System.Windows.Forms.TextBox();
            this.sum_tb = new System.Windows.Forms.TextBox();
            this.cost_label = new System.Windows.Forms.Label();
            this.bar_label = new System.Windows.Forms.Label();
            this.souvenir_label = new System.Windows.Forms.Label();
            this.return_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sum_button
            // 
            this.sum_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sum_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.sum_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sum_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_button.Location = new System.Drawing.Point(62, 177);
            this.sum_button.Name = "sum_button";
            this.sum_button.Size = new System.Drawing.Size(127, 33);
            this.sum_button.TabIndex = 69;
            this.sum_button.Text = "Итого";
            this.sum_button.UseVisualStyleBackColor = false;
            this.sum_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // visitor_tb
            // 
            this.visitor_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitor_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitor_tb.Location = new System.Drawing.Point(195, 68);
            this.visitor_tb.Name = "visitor_tb";
            this.visitor_tb.Size = new System.Drawing.Size(100, 25);
            this.visitor_tb.TabIndex = 70;
            // 
            // bar_tb
            // 
            this.bar_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bar_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bar_tb.Location = new System.Drawing.Point(195, 94);
            this.bar_tb.Name = "bar_tb";
            this.bar_tb.Size = new System.Drawing.Size(100, 25);
            this.bar_tb.TabIndex = 71;
            // 
            // souvenir_tb
            // 
            this.souvenir_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.souvenir_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.souvenir_tb.Location = new System.Drawing.Point(195, 120);
            this.souvenir_tb.Name = "souvenir_tb";
            this.souvenir_tb.Size = new System.Drawing.Size(100, 25);
            this.souvenir_tb.TabIndex = 72;
            // 
            // sum_tb
            // 
            this.sum_tb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sum_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_tb.Location = new System.Drawing.Point(195, 183);
            this.sum_tb.Name = "sum_tb";
            this.sum_tb.Size = new System.Drawing.Size(100, 25);
            this.sum_tb.TabIndex = 73;
            // 
            // cost_label
            // 
            this.cost_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cost_label.AutoSize = true;
            this.cost_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.cost_label.Location = new System.Drawing.Point(87, 74);
            this.cost_label.Name = "cost_label";
            this.cost_label.Size = new System.Drawing.Size(102, 17);
            this.cost_label.TabIndex = 74;
            this.cost_label.Text = "Стоимость/час";
            // 
            // bar_label
            // 
            this.bar_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bar_label.AutoSize = true;
            this.bar_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bar_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.bar_label.Location = new System.Drawing.Point(158, 102);
            this.bar_label.Name = "bar_label";
            this.bar_label.Size = new System.Drawing.Size(31, 17);
            this.bar_label.TabIndex = 75;
            this.bar_label.Text = "Бар";
            // 
            // souvenir_label
            // 
            this.souvenir_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.souvenir_label.AutoSize = true;
            this.souvenir_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.souvenir_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.souvenir_label.Location = new System.Drawing.Point(116, 128);
            this.souvenir_label.Name = "souvenir_label";
            this.souvenir_label.Size = new System.Drawing.Size(73, 17);
            this.souvenir_label.TabIndex = 76;
            this.souvenir_label.Text = "Сувениры";
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.return_button.BackgroundImage = global::billiard.Properties.Resources._return;
            this.return_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.return_button.Location = new System.Drawing.Point(21, 12);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(46, 43);
            this.return_button.TabIndex = 77;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.souvenir_label);
            this.Controls.Add(this.bar_label);
            this.Controls.Add(this.cost_label);
            this.Controls.Add(this.sum_tb);
            this.Controls.Add(this.souvenir_tb);
            this.Controls.Add(this.bar_tb);
            this.Controls.Add(this.visitor_tb);
            this.Controls.Add(this.sum_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(425, 300);
            this.Name = "Payment";
            this.Text = "Чек";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sum_button;
        public System.Windows.Forms.TextBox visitor_tb;
        public System.Windows.Forms.TextBox bar_tb;
        public System.Windows.Forms.TextBox souvenir_tb;
        public System.Windows.Forms.TextBox sum_tb;
        private System.Windows.Forms.Label cost_label;
        private System.Windows.Forms.Label bar_label;
        private System.Windows.Forms.Label souvenir_label;
        private System.Windows.Forms.Button return_button;
    }
}