namespace WindowsFormsApplication1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.shayan_Label1 = new shayan_material.Controls.shayan_Label();
            this.shayan_SingleLineTextField1 = new shayan_material.Controls.shayan_SingleLineTextField();
            this.shayan_RaisedButton1 = new shayan_material.Controls.shayan_RaisedButton();
            this.shayan_RaisedButton2 = new shayan_material.Controls.shayan_RaisedButton();
            this.shayan_RaisedButton3 = new shayan_material.Controls.shayan_RaisedButton();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 101);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(632, 294);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // shayan_Label1
            // 
            this.shayan_Label1.AutoSize = true;
            this.shayan_Label1.BackColor = System.Drawing.Color.Transparent;
            this.shayan_Label1.Depth = 0;
            this.shayan_Label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.shayan_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shayan_Label1.Location = new System.Drawing.Point(9, 73);
            this.shayan_Label1.MouseState = shayan_material.MouseState.HOVER;
            this.shayan_Label1.Name = "shayan_Label1";
            this.shayan_Label1.Size = new System.Drawing.Size(143, 19);
            this.shayan_Label1.TabIndex = 4;
            this.shayan_Label1.Text = "Domain/IP Address:";
            // 
            // shayan_SingleLineTextField1
            // 
            this.shayan_SingleLineTextField1.Depth = 0;
            this.shayan_SingleLineTextField1.Hint = "Domain/IP Address";
            this.shayan_SingleLineTextField1.Location = new System.Drawing.Point(153, 73);
            this.shayan_SingleLineTextField1.MaxLength = 32767;
            this.shayan_SingleLineTextField1.MouseState = shayan_material.MouseState.HOVER;
            this.shayan_SingleLineTextField1.Name = "shayan_SingleLineTextField1";
            this.shayan_SingleLineTextField1.PasswordChar = '\0';
            this.shayan_SingleLineTextField1.SelectedText = "";
            this.shayan_SingleLineTextField1.SelectionLength = 0;
            this.shayan_SingleLineTextField1.SelectionStart = 0;
            this.shayan_SingleLineTextField1.Size = new System.Drawing.Size(211, 23);
            this.shayan_SingleLineTextField1.TabIndex = 5;
            this.shayan_SingleLineTextField1.TabStop = false;
            this.shayan_SingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // shayan_RaisedButton1
            // 
            this.shayan_RaisedButton1.Depth = 0;
            this.shayan_RaisedButton1.Location = new System.Drawing.Point(373, 69);
            this.shayan_RaisedButton1.MouseState = shayan_material.MouseState.HOVER;
            this.shayan_RaisedButton1.Name = "shayan_RaisedButton1";
            this.shayan_RaisedButton1.Primary = true;
            this.shayan_RaisedButton1.Size = new System.Drawing.Size(109, 26);
            this.shayan_RaisedButton1.TabIndex = 6;
            this.shayan_RaisedButton1.Text = "Lookup";
            this.shayan_RaisedButton1.UseVisualStyleBackColor = true;
            this.shayan_RaisedButton1.Click += new System.EventHandler(this.shayan_RaisedButton1_Click);
            // 
            // shayan_RaisedButton2
            // 
            this.shayan_RaisedButton2.Depth = 0;
            this.shayan_RaisedButton2.Location = new System.Drawing.Point(208, 29);
            this.shayan_RaisedButton2.MouseState = shayan_material.MouseState.HOVER;
            this.shayan_RaisedButton2.Name = "shayan_RaisedButton2";
            this.shayan_RaisedButton2.Primary = true;
            this.shayan_RaisedButton2.Size = new System.Drawing.Size(130, 29);
            this.shayan_RaisedButton2.TabIndex = 7;
            this.shayan_RaisedButton2.Text = "Register Domain";
            this.shayan_RaisedButton2.UseVisualStyleBackColor = true;
            this.shayan_RaisedButton2.Click += new System.EventHandler(this.shayan_RaisedButton2_Click);
            // 
            // shayan_RaisedButton3
            // 
            this.shayan_RaisedButton3.Depth = 0;
            this.shayan_RaisedButton3.Location = new System.Drawing.Point(344, 29);
            this.shayan_RaisedButton3.MouseState = shayan_material.MouseState.HOVER;
            this.shayan_RaisedButton3.Name = "shayan_RaisedButton3";
            this.shayan_RaisedButton3.Primary = true;
            this.shayan_RaisedButton3.Size = new System.Drawing.Size(130, 29);
            this.shayan_RaisedButton3.TabIndex = 8;
            this.shayan_RaisedButton3.Text = "Buy a HOST";
            this.shayan_RaisedButton3.UseVisualStyleBackColor = true;
            this.shayan_RaisedButton3.Click += new System.EventHandler(this.shayan_RaisedButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 395);
            this.Controls.Add(this.shayan_RaisedButton3);
            this.Controls.Add(this.shayan_RaisedButton2);
            this.Controls.Add(this.shayan_RaisedButton1);
            this.Controls.Add(this.shayan_SingleLineTextField1);
            this.Controls.Add(this.shayan_Label1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "WHOIS - MagicoHost.org";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private shayan_material.Controls.shayan_Label shayan_Label1;
        private shayan_material.Controls.shayan_SingleLineTextField shayan_SingleLineTextField1;
        private shayan_material.Controls.shayan_RaisedButton shayan_RaisedButton1;
        private shayan_material.Controls.shayan_RaisedButton shayan_RaisedButton2;
        private shayan_material.Controls.shayan_RaisedButton shayan_RaisedButton3;

    }
}

