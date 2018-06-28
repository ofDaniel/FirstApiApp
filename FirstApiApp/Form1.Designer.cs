namespace FirstApiApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBasicGet = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBasicOutput = new System.Windows.Forms.TextBox();
            this.tbBasicURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabBasicPost = new System.Windows.Forms.TabPage();
            this.tbBasicPostField1Value = new System.Windows.Forms.TextBox();
            this.tbBasicPostField1Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBasicPostOutput = new System.Windows.Forms.TextBox();
            this.tbBasicPostURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBasicPostPOST = new System.Windows.Forms.Button();
            this.btnBasicPostClear = new System.Windows.Forms.Button();
            this.tabBasicAuthGet = new System.Windows.Forms.TabPage();
            this.tbAuthBasicGetPass = new System.Windows.Forms.TextBox();
            this.tbAuthBasicGetUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.tbAuthBasicGetOutput = new System.Windows.Forms.TextBox();
            this.tbAuthBasicGetUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabBasicGet.SuspendLayout();
            this.tabBasicPost.SuspendLayout();
            this.tabBasicAuthGet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBasicGet);
            this.tabControl1.Controls.Add(this.tabBasicPost);
            this.tabControl1.Controls.Add(this.tabBasicAuthGet);
            this.tabControl1.Location = new System.Drawing.Point(24, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBasicGet
            // 
            this.tabBasicGet.Controls.Add(this.label2);
            this.tabBasicGet.Controls.Add(this.tbBasicOutput);
            this.tabBasicGet.Controls.Add(this.tbBasicURL);
            this.tabBasicGet.Controls.Add(this.label1);
            this.tabBasicGet.Controls.Add(this.button2);
            this.tabBasicGet.Controls.Add(this.button1);
            this.tabBasicGet.Location = new System.Drawing.Point(4, 22);
            this.tabBasicGet.Name = "tabBasicGet";
            this.tabBasicGet.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicGet.Size = new System.Drawing.Size(765, 447);
            this.tabBasicGet.TabIndex = 0;
            this.tabBasicGet.Text = "Basic GET";
            this.tabBasicGet.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // tbBasicOutput
            // 
            this.tbBasicOutput.Location = new System.Drawing.Point(125, 79);
            this.tbBasicOutput.Multiline = true;
            this.tbBasicOutput.Name = "tbBasicOutput";
            this.tbBasicOutput.Size = new System.Drawing.Size(604, 281);
            this.tbBasicOutput.TabIndex = 2;
            // 
            // tbBasicURL
            // 
            this.tbBasicURL.Location = new System.Drawing.Point(125, 42);
            this.tbBasicURL.Name = "tbBasicURL";
            this.tbBasicURL.Size = new System.Drawing.Size(604, 20);
            this.tbBasicURL.TabIndex = 2;
            this.tbBasicURL.Text = "https://postman-echo.com/get?foo1=bar1&foo2=bar2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabBasicPost
            // 
            this.tabBasicPost.Controls.Add(this.tbBasicPostField1Value);
            this.tabBasicPost.Controls.Add(this.tbBasicPostField1Name);
            this.tabBasicPost.Controls.Add(this.label5);
            this.tabBasicPost.Controls.Add(this.label3);
            this.tabBasicPost.Controls.Add(this.tbBasicPostOutput);
            this.tabBasicPost.Controls.Add(this.tbBasicPostURL);
            this.tabBasicPost.Controls.Add(this.label4);
            this.tabBasicPost.Controls.Add(this.btnBasicPostPOST);
            this.tabBasicPost.Controls.Add(this.btnBasicPostClear);
            this.tabBasicPost.Location = new System.Drawing.Point(4, 22);
            this.tabBasicPost.Name = "tabBasicPost";
            this.tabBasicPost.Size = new System.Drawing.Size(765, 447);
            this.tabBasicPost.TabIndex = 1;
            this.tabBasicPost.Text = "Basic POST";
            this.tabBasicPost.UseVisualStyleBackColor = true;
            // 
            // tbBasicPostField1Value
            // 
            this.tbBasicPostField1Value.Location = new System.Drawing.Point(285, 77);
            this.tbBasicPostField1Value.Name = "tbBasicPostField1Value";
            this.tbBasicPostField1Value.Size = new System.Drawing.Size(157, 20);
            this.tbBasicPostField1Value.TabIndex = 10;
            this.tbBasicPostField1Value.Text = "wave";
            // 
            // tbBasicPostField1Name
            // 
            this.tbBasicPostField1Name.Location = new System.Drawing.Point(122, 80);
            this.tbBasicPostField1Name.Name = "tbBasicPostField1Name";
            this.tbBasicPostField1Name.Size = new System.Drawing.Size(157, 20);
            this.tbBasicPostField1Name.TabIndex = 10;
            this.tbBasicPostField1Name.Text = "hand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Field1";
            // 
            // tbBasicPostOutput
            // 
            this.tbBasicPostOutput.Location = new System.Drawing.Point(122, 144);
            this.tbBasicPostOutput.Multiline = true;
            this.tbBasicPostOutput.Name = "tbBasicPostOutput";
            this.tbBasicPostOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbBasicPostOutput.Size = new System.Drawing.Size(604, 214);
            this.tbBasicPostOutput.TabIndex = 7;
            // 
            // tbBasicPostURL
            // 
            this.tbBasicPostURL.Location = new System.Drawing.Point(122, 40);
            this.tbBasicPostURL.Name = "tbBasicPostURL";
            this.tbBasicPostURL.Size = new System.Drawing.Size(604, 20);
            this.tbBasicPostURL.TabIndex = 8;
            this.tbBasicPostURL.Text = "https://postman-echo.com/post";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "URL";
            // 
            // btnBasicPostPOST
            // 
            this.btnBasicPostPOST.Location = new System.Drawing.Point(111, 384);
            this.btnBasicPostPOST.Name = "btnBasicPostPOST";
            this.btnBasicPostPOST.Size = new System.Drawing.Size(75, 23);
            this.btnBasicPostPOST.TabIndex = 4;
            this.btnBasicPostPOST.Text = "POST";
            this.btnBasicPostPOST.UseVisualStyleBackColor = true;
            this.btnBasicPostPOST.Click += new System.EventHandler(this.btnBasicPostPOST_Click);
            // 
            // btnBasicPostClear
            // 
            this.btnBasicPostClear.Location = new System.Drawing.Point(651, 384);
            this.btnBasicPostClear.Name = "btnBasicPostClear";
            this.btnBasicPostClear.Size = new System.Drawing.Size(75, 23);
            this.btnBasicPostClear.TabIndex = 5;
            this.btnBasicPostClear.Text = "Clear";
            this.btnBasicPostClear.UseVisualStyleBackColor = true;
            this.btnBasicPostClear.Click += new System.EventHandler(this.btnBasicPostClear_Click);
            // 
            // tabBasicAuthGet
            // 
            this.tabBasicAuthGet.Controls.Add(this.label7);
            this.tabBasicAuthGet.Controls.Add(this.tbAuthBasicGetPass);
            this.tabBasicAuthGet.Controls.Add(this.tbAuthBasicGetUser);
            this.tabBasicAuthGet.Controls.Add(this.label6);
            this.tabBasicAuthGet.Controls.Add(this.Username);
            this.tabBasicAuthGet.Controls.Add(this.tbAuthBasicGetOutput);
            this.tabBasicAuthGet.Controls.Add(this.tbAuthBasicGetUrl);
            this.tabBasicAuthGet.Controls.Add(this.label8);
            this.tabBasicAuthGet.Controls.Add(this.button3);
            this.tabBasicAuthGet.Controls.Add(this.button4);
            this.tabBasicAuthGet.Location = new System.Drawing.Point(4, 22);
            this.tabBasicAuthGet.Name = "tabBasicAuthGet";
            this.tabBasicAuthGet.Size = new System.Drawing.Size(765, 447);
            this.tabBasicAuthGet.TabIndex = 2;
            this.tabBasicAuthGet.Text = "Auth Basic Get";
            this.tabBasicAuthGet.UseVisualStyleBackColor = true;
            // 
            // tbAuthBasicGetPass
            // 
            this.tbAuthBasicGetPass.Location = new System.Drawing.Point(122, 106);
            this.tbAuthBasicGetPass.Name = "tbAuthBasicGetPass";
            this.tbAuthBasicGetPass.Size = new System.Drawing.Size(157, 20);
            this.tbAuthBasicGetPass.TabIndex = 18;
            this.tbAuthBasicGetPass.Text = "password";
            // 
            // tbAuthBasicGetUser
            // 
            this.tbAuthBasicGetUser.Location = new System.Drawing.Point(122, 80);
            this.tbAuthBasicGetUser.Name = "tbAuthBasicGetUser";
            this.tbAuthBasicGetUser.Size = new System.Drawing.Size(157, 20);
            this.tbAuthBasicGetUser.TabIndex = 19;
            this.tbAuthBasicGetUser.Text = "postman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Output";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(39, 80);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(29, 13);
            this.Username.TabIndex = 17;
            this.Username.Text = "User";
            // 
            // tbAuthBasicGetOutput
            // 
            this.tbAuthBasicGetOutput.Location = new System.Drawing.Point(122, 144);
            this.tbAuthBasicGetOutput.Multiline = true;
            this.tbAuthBasicGetOutput.Name = "tbAuthBasicGetOutput";
            this.tbAuthBasicGetOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAuthBasicGetOutput.Size = new System.Drawing.Size(604, 214);
            this.tbAuthBasicGetOutput.TabIndex = 14;
            // 
            // tbAuthBasicGetUrl
            // 
            this.tbAuthBasicGetUrl.Location = new System.Drawing.Point(122, 40);
            this.tbAuthBasicGetUrl.Name = "tbAuthBasicGetUrl";
            this.tbAuthBasicGetUrl.Size = new System.Drawing.Size(604, 20);
            this.tbAuthBasicGetUrl.TabIndex = 15;
            this.tbAuthBasicGetUrl.Text = "https://postman-echo.com/basic-auth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "URL";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "GET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(651, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 544);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBasicGet.ResumeLayout(false);
            this.tabBasicGet.PerformLayout();
            this.tabBasicPost.ResumeLayout(false);
            this.tabBasicPost.PerformLayout();
            this.tabBasicAuthGet.ResumeLayout(false);
            this.tabBasicAuthGet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBasicGet;
        private System.Windows.Forms.TextBox tbBasicOutput;
        private System.Windows.Forms.TextBox tbBasicURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabBasicPost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBasicPostOutput;
        private System.Windows.Forms.TextBox tbBasicPostURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBasicPostPOST;
        private System.Windows.Forms.Button btnBasicPostClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBasicPostField1Value;
        private System.Windows.Forms.TextBox tbBasicPostField1Name;
        private System.Windows.Forms.TabPage tabBasicAuthGet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAuthBasicGetPass;
        private System.Windows.Forms.TextBox tbAuthBasicGetUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox tbAuthBasicGetOutput;
        private System.Windows.Forms.TextBox tbAuthBasicGetUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

