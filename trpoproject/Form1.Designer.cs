
namespace trpoproject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonLogMainMenu = new System.Windows.Forms.Button();
            this.ButtonSignMainMenu = new System.Windows.Forms.Button();
            this.ButtonExitMainMenu = new System.Windows.Forms.Button();
            this.panelLog = new System.Windows.Forms.Panel();
            this.ButtonBackLogToMain = new System.Windows.Forms.Button();
            this.ButtonLoginLog = new System.Windows.Forms.Button();
            this.textBoxPasswordLog = new System.Windows.Forms.TextBox();
            this.TextBoxLoginLog = new System.Windows.Forms.TextBox();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.ButtonBackSignIn = new System.Windows.Forms.Button();
            this.ButtonSignSignIn = new System.Windows.Forms.Button();
            this.textBoxRepeatPassSignIn = new System.Windows.Forms.TextBox();
            this.textBoxPassSignIn = new System.Windows.Forms.TextBox();
            this.textBoxLoginSignIn = new System.Windows.Forms.TextBox();
            this.panelLog.SuspendLayout();
            this.panelSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLogMainMenu
            // 
            this.ButtonLogMainMenu.Location = new System.Drawing.Point(252, 118);
            this.ButtonLogMainMenu.Name = "ButtonLogMainMenu";
            this.ButtonLogMainMenu.Size = new System.Drawing.Size(277, 51);
            this.ButtonLogMainMenu.TabIndex = 0;
            this.ButtonLogMainMenu.Text = "Log in";
            this.ButtonLogMainMenu.UseVisualStyleBackColor = true;
            this.ButtonLogMainMenu.Click += new System.EventHandler(this.ButtonLogMainMenu_Click);
            // 
            // ButtonSignMainMenu
            // 
            this.ButtonSignMainMenu.Location = new System.Drawing.Point(252, 191);
            this.ButtonSignMainMenu.Name = "ButtonSignMainMenu";
            this.ButtonSignMainMenu.Size = new System.Drawing.Size(277, 51);
            this.ButtonSignMainMenu.TabIndex = 1;
            this.ButtonSignMainMenu.Text = "Sign in";
            this.ButtonSignMainMenu.UseVisualStyleBackColor = true;
            this.ButtonSignMainMenu.Click += new System.EventHandler(this.ButtonSignMainMenu_Click);
            // 
            // ButtonExitMainMenu
            // 
            this.ButtonExitMainMenu.Location = new System.Drawing.Point(252, 262);
            this.ButtonExitMainMenu.Name = "ButtonExitMainMenu";
            this.ButtonExitMainMenu.Size = new System.Drawing.Size(277, 51);
            this.ButtonExitMainMenu.TabIndex = 2;
            this.ButtonExitMainMenu.Text = "Quit";
            this.ButtonExitMainMenu.UseVisualStyleBackColor = true;
            this.ButtonExitMainMenu.Click += new System.EventHandler(this.ButtonExitMainMenu_Click);
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.ButtonBackLogToMain);
            this.panelLog.Controls.Add(this.ButtonLoginLog);
            this.panelLog.Controls.Add(this.textBoxPasswordLog);
            this.panelLog.Controls.Add(this.TextBoxLoginLog);
            this.panelLog.Location = new System.Drawing.Point(69, 20);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(646, 386);
            this.panelLog.TabIndex = 3;
            this.panelLog.Visible = false;
            // 
            // ButtonBackLogToMain
            // 
            this.ButtonBackLogToMain.Location = new System.Drawing.Point(161, 274);
            this.ButtonBackLogToMain.Name = "ButtonBackLogToMain";
            this.ButtonBackLogToMain.Size = new System.Drawing.Size(317, 62);
            this.ButtonBackLogToMain.TabIndex = 3;
            this.ButtonBackLogToMain.Text = "Back";
            this.ButtonBackLogToMain.UseVisualStyleBackColor = true;
            this.ButtonBackLogToMain.Click += new System.EventHandler(this.ButtonBackLogToMain_Click);
            // 
            // ButtonLoginLog
            // 
            this.ButtonLoginLog.Location = new System.Drawing.Point(161, 206);
            this.ButtonLoginLog.Name = "ButtonLoginLog";
            this.ButtonLoginLog.Size = new System.Drawing.Size(317, 62);
            this.ButtonLoginLog.TabIndex = 2;
            this.ButtonLoginLog.Text = "Log in";
            this.ButtonLoginLog.UseVisualStyleBackColor = true;
            this.ButtonLoginLog.Click += new System.EventHandler(this.ButtonLoginLog_Click);
            // 
            // textBoxPasswordLog
            // 
            this.textBoxPasswordLog.Location = new System.Drawing.Point(183, 148);
            this.textBoxPasswordLog.Multiline = true;
            this.textBoxPasswordLog.Name = "textBoxPasswordLog";
            this.textBoxPasswordLog.Size = new System.Drawing.Size(277, 36);
            this.textBoxPasswordLog.TabIndex = 1;
            this.textBoxPasswordLog.Text = "Password";
            this.textBoxPasswordLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPasswordLog.Click += new System.EventHandler(this.textboxPasswordLog_click);
            // 
            // TextBoxLoginLog
            // 
            this.TextBoxLoginLog.Location = new System.Drawing.Point(183, 98);
            this.TextBoxLoginLog.Multiline = true;
            this.TextBoxLoginLog.Name = "TextBoxLoginLog";
            this.TextBoxLoginLog.Size = new System.Drawing.Size(277, 36);
            this.TextBoxLoginLog.TabIndex = 0;
            this.TextBoxLoginLog.Text = "Login";
            this.TextBoxLoginLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxLoginLog.Click += new System.EventHandler(this.TextBoxLoginLog_click);
            // 
            // panelSignIn
            // 
            this.panelSignIn.Controls.Add(this.ButtonBackSignIn);
            this.panelSignIn.Controls.Add(this.ButtonSignSignIn);
            this.panelSignIn.Controls.Add(this.textBoxRepeatPassSignIn);
            this.panelSignIn.Controls.Add(this.textBoxPassSignIn);
            this.panelSignIn.Controls.Add(this.textBoxLoginSignIn);
            this.panelSignIn.Location = new System.Drawing.Point(50, 12);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(697, 409);
            this.panelSignIn.TabIndex = 4;
            this.panelSignIn.Visible = false;
            // 
            // ButtonBackSignIn
            // 
            this.ButtonBackSignIn.Location = new System.Drawing.Point(191, 307);
            this.ButtonBackSignIn.Name = "ButtonBackSignIn";
            this.ButtonBackSignIn.Size = new System.Drawing.Size(311, 61);
            this.ButtonBackSignIn.TabIndex = 4;
            this.ButtonBackSignIn.Text = "Back";
            this.ButtonBackSignIn.UseVisualStyleBackColor = true;
            this.ButtonBackSignIn.Click += new System.EventHandler(this.ButtonBackSignIn_Click);
            // 
            // ButtonSignSignIn
            // 
            this.ButtonSignSignIn.Location = new System.Drawing.Point(191, 240);
            this.ButtonSignSignIn.Name = "ButtonSignSignIn";
            this.ButtonSignSignIn.Size = new System.Drawing.Size(311, 61);
            this.ButtonSignSignIn.TabIndex = 3;
            this.ButtonSignSignIn.Text = "Sign In";
            this.ButtonSignSignIn.UseVisualStyleBackColor = true;
            this.ButtonSignSignIn.Click += new System.EventHandler(this.ButtonSignSignIn_Click);
            // 
            // textBoxRepeatPassSignIn
            // 
            this.textBoxRepeatPassSignIn.Location = new System.Drawing.Point(206, 195);
            this.textBoxRepeatPassSignIn.Multiline = true;
            this.textBoxRepeatPassSignIn.Name = "textBoxRepeatPassSignIn";
            this.textBoxRepeatPassSignIn.Size = new System.Drawing.Size(277, 39);
            this.textBoxRepeatPassSignIn.TabIndex = 2;
            this.textBoxRepeatPassSignIn.Text = "Repeat password";
            this.textBoxRepeatPassSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRepeatPassSignIn.Click += new System.EventHandler(this.textBoxRepeatPassSignIn_Click);
            // 
            // textBoxPassSignIn
            // 
            this.textBoxPassSignIn.Location = new System.Drawing.Point(206, 150);
            this.textBoxPassSignIn.Multiline = true;
            this.textBoxPassSignIn.Name = "textBoxPassSignIn";
            this.textBoxPassSignIn.Size = new System.Drawing.Size(277, 39);
            this.textBoxPassSignIn.TabIndex = 1;
            this.textBoxPassSignIn.Text = "Password";
            this.textBoxPassSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassSignIn.Click += new System.EventHandler(this.textBoxPassSignIn_Click);
            // 
            // textBoxLoginSignIn
            // 
            this.textBoxLoginSignIn.Location = new System.Drawing.Point(206, 81);
            this.textBoxLoginSignIn.Multiline = true;
            this.textBoxLoginSignIn.Name = "textBoxLoginSignIn";
            this.textBoxLoginSignIn.Size = new System.Drawing.Size(277, 39);
            this.textBoxLoginSignIn.TabIndex = 0;
            this.textBoxLoginSignIn.Text = "Login";
            this.textBoxLoginSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginSignIn.Click += new System.EventHandler(this.textBoxLoginSignIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSignIn);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.ButtonExitMainMenu);
            this.Controls.Add(this.ButtonSignMainMenu);
            this.Controls.Add(this.ButtonLogMainMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogMainMenu;
        private System.Windows.Forms.Button ButtonSignMainMenu;
        private System.Windows.Forms.Button ButtonExitMainMenu;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Button ButtonLoginLog;
        private System.Windows.Forms.TextBox textBoxPasswordLog;
        private System.Windows.Forms.TextBox TextBoxLoginLog;
        private System.Windows.Forms.Button ButtonBackLogToMain;
        private System.Windows.Forms.Panel panelSignIn;
        private System.Windows.Forms.Button ButtonBackSignIn;
        private System.Windows.Forms.Button ButtonSignSignIn;
        private System.Windows.Forms.TextBox textBoxRepeatPassSignIn;
        private System.Windows.Forms.TextBox textBoxPassSignIn;
        private System.Windows.Forms.TextBox textBoxLoginSignIn;
    }
}

