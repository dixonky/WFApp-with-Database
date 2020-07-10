namespace WFApp_db
{
     partial class FormNewUser
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
               this.welcomeLabel = new System.Windows.Forms.Label();
               this.submitBtn = new System.Windows.Forms.Button();
               this.nameTextBox = new System.Windows.Forms.TextBox();
               this.nameLabel = new System.Windows.Forms.Label();
               this.passTextBox = new System.Windows.Forms.TextBox();
               this.passLabel = new System.Windows.Forms.Label();
               this.errorTextBox = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // welcomeLabel
               // 
               this.welcomeLabel.AutoSize = true;
               this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.welcomeLabel.Location = new System.Drawing.Point(88, 59);
               this.welcomeLabel.Name = "welcomeLabel";
               this.welcomeLabel.Size = new System.Drawing.Size(423, 52);
               this.welcomeLabel.TabIndex = 0;
               this.welcomeLabel.Text = "Welcome, New User";
               // 
               // submitBtn
               // 
               this.submitBtn.Location = new System.Drawing.Point(224, 370);
               this.submitBtn.Name = "submitBtn";
               this.submitBtn.Size = new System.Drawing.Size(111, 54);
               this.submitBtn.TabIndex = 1;
               this.submitBtn.Text = "Submit Form";
               this.submitBtn.UseVisualStyleBackColor = true;
               this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
               // 
               // nameTextBox
               // 
               this.nameTextBox.Location = new System.Drawing.Point(51, 191);
               this.nameTextBox.Name = "nameTextBox";
               this.nameTextBox.Size = new System.Drawing.Size(326, 26);
               this.nameTextBox.TabIndex = 2;
               // 
               // nameLabel
               // 
               this.nameLabel.AutoSize = true;
               this.nameLabel.Location = new System.Drawing.Point(393, 194);
               this.nameLabel.Name = "nameLabel";
               this.nameLabel.Size = new System.Drawing.Size(83, 20);
               this.nameLabel.TabIndex = 3;
               this.nameLabel.Text = "Username";
               // 
               // passTextBox
               // 
               this.passTextBox.Location = new System.Drawing.Point(51, 258);
               this.passTextBox.Name = "passTextBox";
               this.passTextBox.Size = new System.Drawing.Size(326, 26);
               this.passTextBox.TabIndex = 4;
               // 
               // passLabel
               // 
               this.passLabel.AutoSize = true;
               this.passLabel.Location = new System.Drawing.Point(393, 261);
               this.passLabel.Name = "passLabel";
               this.passLabel.Size = new System.Drawing.Size(78, 20);
               this.passLabel.TabIndex = 5;
               this.passLabel.Text = "Password";
               // 
               // errorTextBox
               // 
               this.errorTextBox.BackColor = System.Drawing.SystemColors.Menu;
               this.errorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.errorTextBox.Location = new System.Drawing.Point(108, 476);
               this.errorTextBox.Name = "errorTextBox";
               this.errorTextBox.Size = new System.Drawing.Size(352, 19);
               this.errorTextBox.TabIndex = 6;
               // 
               // FormNewUser
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(573, 676);
               this.Controls.Add(this.errorTextBox);
               this.Controls.Add(this.passLabel);
               this.Controls.Add(this.passTextBox);
               this.Controls.Add(this.nameLabel);
               this.Controls.Add(this.nameTextBox);
               this.Controls.Add(this.submitBtn);
               this.Controls.Add(this.welcomeLabel);
               this.Name = "FormNewUser";
               this.Text = "FormNewUser";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label welcomeLabel;
          private System.Windows.Forms.Button submitBtn;
          private System.Windows.Forms.TextBox nameTextBox;
          private System.Windows.Forms.Label nameLabel;
          private System.Windows.Forms.TextBox passTextBox;
          private System.Windows.Forms.Label passLabel;
          private System.Windows.Forms.TextBox errorTextBox;
     }
}