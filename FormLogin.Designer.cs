namespace WFApp_db
{
     partial class Login
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
               this.components = new System.ComponentModel.Container();
               this.connectBtn = new System.Windows.Forms.Button();
               this.userNameBox = new System.Windows.Forms.TextBox();
               this.passwordBox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.loginError = new System.Windows.Forms.ErrorProvider(this.components);
               this.loginTextBox = new System.Windows.Forms.TextBox();
               this.loginWelLabel = new System.Windows.Forms.Label();
               this.passCheckBox = new System.Windows.Forms.CheckBox();
               this.newUserBtn = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.loginError)).BeginInit();
               this.SuspendLayout();
               // 
               // connectBtn
               // 
               this.connectBtn.Location = new System.Drawing.Point(127, 273);
               this.connectBtn.Name = "connectBtn";
               this.connectBtn.Size = new System.Drawing.Size(107, 44);
               this.connectBtn.TabIndex = 0;
               this.connectBtn.Text = "Login";
               this.connectBtn.UseVisualStyleBackColor = true;
               this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
               // 
               // userNameBox
               // 
               this.userNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.userNameBox.Location = new System.Drawing.Point(44, 124);
               this.userNameBox.Name = "userNameBox";
               this.userNameBox.Size = new System.Drawing.Size(207, 30);
               this.userNameBox.TabIndex = 2;
               // 
               // passwordBox
               // 
               this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.passwordBox.Location = new System.Drawing.Point(44, 177);
               this.passwordBox.Name = "passwordBox";
               this.passwordBox.Size = new System.Drawing.Size(207, 30);
               this.passwordBox.TabIndex = 3;
               this.passwordBox.UseSystemPasswordChar = true;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(257, 131);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(83, 20);
               this.label1.TabIndex = 5;
               this.label1.Text = "Username";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(257, 184);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(78, 20);
               this.label2.TabIndex = 6;
               this.label2.Text = "Password";
               // 
               // loginError
               // 
               this.loginError.ContainerControl = this;
               // 
               // loginTextBox
               // 
               this.loginTextBox.BackColor = System.Drawing.SystemColors.Menu;
               this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.loginTextBox.Location = new System.Drawing.Point(34, 323);
               this.loginTextBox.Name = "loginTextBox";
               this.loginTextBox.Size = new System.Drawing.Size(306, 19);
               this.loginTextBox.TabIndex = 7;
               this.loginTextBox.Visible = false;
               // 
               // loginWelLabel
               // 
               this.loginWelLabel.AutoSize = true;
               this.loginWelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.loginWelLabel.Location = new System.Drawing.Point(94, 54);
               this.loginWelLabel.Name = "loginWelLabel";
               this.loginWelLabel.Size = new System.Drawing.Size(150, 37);
               this.loginWelLabel.TabIndex = 8;
               this.loginWelLabel.Text = "Welcome";
               // 
               // passCheckBox
               // 
               this.passCheckBox.AutoSize = true;
               this.passCheckBox.Location = new System.Drawing.Point(44, 226);
               this.passCheckBox.Name = "passCheckBox";
               this.passCheckBox.Size = new System.Drawing.Size(200, 24);
               this.passCheckBox.TabIndex = 9;
               this.passCheckBox.Text = "Check to see password";
               this.passCheckBox.UseVisualStyleBackColor = true;
               this.passCheckBox.CheckedChanged += new System.EventHandler(this.passCheckBox_CheckedChanged);
               // 
               // newUserBtn
               // 
               this.newUserBtn.Location = new System.Drawing.Point(127, 348);
               this.newUserBtn.Name = "newUserBtn";
               this.newUserBtn.Size = new System.Drawing.Size(107, 44);
               this.newUserBtn.TabIndex = 10;
               this.newUserBtn.Text = "New User?";
               this.newUserBtn.UseVisualStyleBackColor = true;
               this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click);
               // 
               // Login
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(366, 441);
               this.Controls.Add(this.newUserBtn);
               this.Controls.Add(this.passCheckBox);
               this.Controls.Add(this.loginWelLabel);
               this.Controls.Add(this.loginTextBox);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.passwordBox);
               this.Controls.Add(this.userNameBox);
               this.Controls.Add(this.connectBtn);
               this.Name = "Login";
               this.Text = "Login";
               ((System.ComponentModel.ISupportInitialize)(this.loginError)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button connectBtn;
          private System.Windows.Forms.TextBox userNameBox;
          private System.Windows.Forms.TextBox passwordBox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.ErrorProvider loginError;
          private System.Windows.Forms.TextBox loginTextBox;
          private System.Windows.Forms.Label loginWelLabel;
          private System.Windows.Forms.CheckBox passCheckBox;
          private System.Windows.Forms.Button newUserBtn;
     }
}

