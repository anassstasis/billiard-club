namespace billiard
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.reg_button = new System.Windows.Forms.Button();
            this.auto_button = new System.Windows.Forms.Button();
            this.log_tb = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.log_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reg_button
            // 
            this.reg_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reg_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.reg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_button.ForeColor = System.Drawing.Color.Black;
            this.reg_button.Location = new System.Drawing.Point(130, 235);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(200, 37);
            this.reg_button.TabIndex = 29;
            this.reg_button.Text = "Регистрация";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // auto_button
            // 
            this.auto_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auto_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(18)))));
            this.auto_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auto_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_button.ForeColor = System.Drawing.Color.Black;
            this.auto_button.Location = new System.Drawing.Point(130, 193);
            this.auto_button.Name = "auto_button";
            this.auto_button.Size = new System.Drawing.Size(200, 36);
            this.auto_button.TabIndex = 28;
            this.auto_button.Text = "Войти";
            this.auto_button.UseVisualStyleBackColor = false;
            this.auto_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // log_tb
            // 
            this.log_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(78)))));
            this.log_tb.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_tb.ForeColor = System.Drawing.Color.Black;
            this.log_tb.Location = new System.Drawing.Point(130, 67);
            this.log_tb.Name = "log_tb";
            this.log_tb.Size = new System.Drawing.Size(200, 33);
            this.log_tb.TabIndex = 24;
            this.log_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass_label
            // 
            this.pass_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pass_label.AutoSize = true;
            this.pass_label.BackColor = System.Drawing.Color.Transparent;
            this.pass_label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.pass_label.Location = new System.Drawing.Point(125, 112);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(158, 25);
            this.pass_label.TabIndex = 27;
            this.pass_label.Text = "Введите пароль:";
            // 
            // pass_tb
            // 
            this.pass_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pass_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(78)))));
            this.pass_tb.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_tb.ForeColor = System.Drawing.Color.Black;
            this.pass_tb.Location = new System.Drawing.Point(130, 140);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.PasswordChar = '*';
            this.pass_tb.Size = new System.Drawing.Size(200, 33);
            this.pass_tb.TabIndex = 25;
            this.pass_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // log_label
            // 
            this.log_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.log_label.AutoSize = true;
            this.log_label.BackColor = System.Drawing.Color.Transparent;
            this.log_label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.log_label.Location = new System.Drawing.Point(125, 39);
            this.log_label.Name = "log_label";
            this.log_label.Size = new System.Drawing.Size(146, 25);
            this.log_label.TabIndex = 26;
            this.log_label.Text = "Введите логин:";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(459, 336);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.auto_button);
            this.Controls.Add(this.log_tb);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.log_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(475, 375);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Button auto_button;
        private System.Windows.Forms.TextBox log_tb;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Label log_label;
    }
}