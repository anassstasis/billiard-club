namespace billiard
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.fio_label = new System.Windows.Forms.Label();
            this.fio_tb = new System.Windows.Forms.TextBox();
            this.reg_button = new System.Windows.Forms.Button();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.log_tb = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.return_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fio_label
            // 
            this.fio_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fio_label.AutoSize = true;
            this.fio_label.BackColor = System.Drawing.Color.Transparent;
            this.fio_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.fio_label.Location = new System.Drawing.Point(153, 172);
            this.fio_label.Name = "fio_label";
            this.fio_label.Size = new System.Drawing.Size(48, 21);
            this.fio_label.TabIndex = 65;
            this.fio_label.Text = "ФИО";
            // 
            // fio_tb
            // 
            this.fio_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fio_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(78)))));
            this.fio_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_tb.Location = new System.Drawing.Point(156, 196);
            this.fio_tb.Name = "fio_tb";
            this.fio_tb.Size = new System.Drawing.Size(155, 29);
            this.fio_tb.TabIndex = 58;
            this.fio_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reg_button
            // 
            this.reg_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.reg_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.reg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_button.Location = new System.Drawing.Point(134, 257);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(194, 39);
            this.reg_button.TabIndex = 63;
            this.reg_button.Text = "Зарегестрироваться";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pass_tb
            // 
            this.pass_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pass_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(78)))));
            this.pass_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_tb.Location = new System.Drawing.Point(157, 141);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.PasswordChar = '*';
            this.pass_tb.Size = new System.Drawing.Size(154, 29);
            this.pass_tb.TabIndex = 60;
            this.pass_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass_label
            // 
            this.pass_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pass_label.AutoSize = true;
            this.pass_label.BackColor = System.Drawing.Color.Transparent;
            this.pass_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.pass_label.Location = new System.Drawing.Point(153, 117);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(70, 21);
            this.pass_label.TabIndex = 62;
            this.pass_label.Text = "Пароль";
            // 
            // log_tb
            // 
            this.log_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.log_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(78)))));
            this.log_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_tb.Location = new System.Drawing.Point(157, 85);
            this.log_tb.Name = "log_tb";
            this.log_tb.Size = new System.Drawing.Size(154, 29);
            this.log_tb.TabIndex = 59;
            this.log_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_label
            // 
            this.login_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.login_label.AutoSize = true;
            this.login_label.BackColor = System.Drawing.Color.Transparent;
            this.login_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            this.login_label.Location = new System.Drawing.Point(153, 61);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(59, 21);
            this.login_label.TabIndex = 61;
            this.login_label.Text = "Логин";
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.return_button.BackgroundImage = global::billiard.Properties.Resources._return;
            this.return_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.return_button.Location = new System.Drawing.Point(27, 24);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(46, 43);
            this.return_button.TabIndex = 67;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(459, 336);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.fio_label);
            this.Controls.Add(this.fio_tb);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.log_tb);
            this.Controls.Add(this.login_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(475, 375);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fio_label;
        private System.Windows.Forms.TextBox fio_tb;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox log_tb;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button return_button;
    }
}