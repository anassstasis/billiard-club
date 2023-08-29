namespace billiard
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.service_button = new System.Windows.Forms.Button();
            this.table_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // service_button
            // 
            this.service_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.service_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(167)))), ((int)(((byte)(162)))));
            this.service_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.service_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.service_button.Location = new System.Drawing.Point(89, 90);
            this.service_button.Name = "service_button";
            this.service_button.Size = new System.Drawing.Size(177, 34);
            this.service_button.TabIndex = 63;
            this.service_button.Text = "Услуги";
            this.service_button.UseVisualStyleBackColor = false;
            this.service_button.Click += new System.EventHandler(this.service_button_Click);
            // 
            // table_button
            // 
            this.table_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.table_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(167)))), ((int)(((byte)(162)))));
            this.table_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table_button.Location = new System.Drawing.Point(89, 39);
            this.table_button.Name = "table_button";
            this.table_button.Size = new System.Drawing.Size(177, 34);
            this.table_button.TabIndex = 62;
            this.table_button.Text = "Бронь столов";
            this.table_button.UseVisualStyleBackColor = false;
            this.table_button.Click += new System.EventHandler(this.table_button_Click);
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.return_button.BackgroundImage = global::billiard.Properties.Resources._return;
            this.return_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.return_button.Location = new System.Drawing.Point(12, 12);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(46, 43);
            this.return_button.TabIndex = 66;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(167)))), ((int)(((byte)(162)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(89, 143);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(177, 52);
            this.add_button.TabIndex = 67;
            this.add_button.Text = "Редактирование данных";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(349, 216);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.service_button);
            this.Controls.Add(this.table_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(365, 255);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button service_button;
        private System.Windows.Forms.Button table_button;
        private System.Windows.Forms.Button add_button;
    }
}