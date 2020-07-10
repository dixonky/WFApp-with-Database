namespace WFApp_db
{
     partial class FormUser
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
               this.userLabel = new System.Windows.Forms.Label();
               this.recordsBox = new System.Windows.Forms.ListBox();
               this.recordDataBox = new System.Windows.Forms.TextBox();
               this.delBtn = new System.Windows.Forms.Button();
               this.newRecBtn = new System.Windows.Forms.Button();
               this.recNameBox = new System.Windows.Forms.TextBox();
               this.recNameLabel = new System.Windows.Forms.Label();
               this.recDataBox = new System.Windows.Forms.TextBox();
               this.recDataLabel = new System.Windows.Forms.Label();
               this.recSaveBtn = new System.Windows.Forms.Button();
               this.recEditBtn = new System.Windows.Forms.Button();
               this.recSaveChBtn = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // userLabel
               // 
               this.userLabel.AutoSize = true;
               this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.userLabel.Location = new System.Drawing.Point(12, 9);
               this.userLabel.Name = "userLabel";
               this.userLabel.Size = new System.Drawing.Size(0, 55);
               this.userLabel.TabIndex = 1;
               // 
               // recordsBox
               // 
               this.recordsBox.BackColor = System.Drawing.SystemColors.Menu;
               this.recordsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.recordsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.recordsBox.FormattingEnabled = true;
               this.recordsBox.ItemHeight = 37;
               this.recordsBox.Location = new System.Drawing.Point(22, 215);
               this.recordsBox.Name = "recordsBox";
               this.recordsBox.Size = new System.Drawing.Size(215, 518);
               this.recordsBox.TabIndex = 2;
               // 
               // recordDataBox
               // 
               this.recordDataBox.BackColor = System.Drawing.SystemColors.Menu;
               this.recordDataBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.recordDataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.recordDataBox.Location = new System.Drawing.Point(397, 390);
               this.recordDataBox.Name = "recordDataBox";
               this.recordDataBox.Size = new System.Drawing.Size(369, 32);
               this.recordDataBox.TabIndex = 3;
               this.recordDataBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // delBtn
               // 
               this.delBtn.Location = new System.Drawing.Point(346, 781);
               this.delBtn.Name = "delBtn";
               this.delBtn.Size = new System.Drawing.Size(135, 65);
               this.delBtn.TabIndex = 4;
               this.delBtn.Text = "Delete Record";
               this.delBtn.UseVisualStyleBackColor = true;
               this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
               // 
               // newRecBtn
               // 
               this.newRecBtn.Location = new System.Drawing.Point(22, 781);
               this.newRecBtn.Name = "newRecBtn";
               this.newRecBtn.Size = new System.Drawing.Size(135, 65);
               this.newRecBtn.TabIndex = 5;
               this.newRecBtn.Text = "New Record";
               this.newRecBtn.UseVisualStyleBackColor = true;
               this.newRecBtn.Click += new System.EventHandler(this.newRecBtn_Click);
               // 
               // recNameBox
               // 
               this.recNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.recNameBox.Location = new System.Drawing.Point(280, 296);
               this.recNameBox.Name = "recNameBox";
               this.recNameBox.Size = new System.Drawing.Size(475, 35);
               this.recNameBox.TabIndex = 6;
               this.recNameBox.Visible = false;
               // 
               // recNameLabel
               // 
               this.recNameLabel.AutoSize = true;
               this.recNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.recNameLabel.Location = new System.Drawing.Point(772, 299);
               this.recNameLabel.Name = "recNameLabel";
               this.recNameLabel.Size = new System.Drawing.Size(163, 29);
               this.recNameLabel.TabIndex = 7;
               this.recNameLabel.Text = "Record Name";
               this.recNameLabel.Visible = false;
               // 
               // recDataBox
               // 
               this.recDataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.recDataBox.Location = new System.Drawing.Point(280, 377);
               this.recDataBox.Name = "recDataBox";
               this.recDataBox.Size = new System.Drawing.Size(475, 35);
               this.recDataBox.TabIndex = 8;
               this.recDataBox.Visible = false;
               // 
               // recDataLabel
               // 
               this.recDataLabel.AutoSize = true;
               this.recDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.recDataLabel.Location = new System.Drawing.Point(772, 380);
               this.recDataLabel.Name = "recDataLabel";
               this.recDataLabel.Size = new System.Drawing.Size(147, 29);
               this.recDataLabel.TabIndex = 9;
               this.recDataLabel.Text = "Record Data";
               this.recDataLabel.Visible = false;
               // 
               // recSaveBtn
               // 
               this.recSaveBtn.Location = new System.Drawing.Point(451, 452);
               this.recSaveBtn.Name = "recSaveBtn";
               this.recSaveBtn.Size = new System.Drawing.Size(135, 65);
               this.recSaveBtn.TabIndex = 10;
               this.recSaveBtn.Text = "Save Record";
               this.recSaveBtn.UseVisualStyleBackColor = true;
               this.recSaveBtn.Visible = false;
               this.recSaveBtn.Click += new System.EventHandler(this.recSaveBtn_Click);
               // 
               // recEditBtn
               // 
               this.recEditBtn.Location = new System.Drawing.Point(184, 781);
               this.recEditBtn.Name = "recEditBtn";
               this.recEditBtn.Size = new System.Drawing.Size(135, 65);
               this.recEditBtn.TabIndex = 11;
               this.recEditBtn.Text = "Edit Record";
               this.recEditBtn.UseVisualStyleBackColor = true;
               this.recEditBtn.Click += new System.EventHandler(this.recEditBtn_Click);
               // 
               // recSaveChBtn
               // 
               this.recSaveChBtn.Location = new System.Drawing.Point(451, 452);
               this.recSaveChBtn.Name = "recSaveChBtn";
               this.recSaveChBtn.Size = new System.Drawing.Size(135, 65);
               this.recSaveChBtn.TabIndex = 12;
               this.recSaveChBtn.Text = "Save Changes";
               this.recSaveChBtn.UseVisualStyleBackColor = true;
               this.recSaveChBtn.Click += new System.EventHandler(this.recSaveChBtn_Click);
               // 
               // FormUser
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(956, 949);
               this.Controls.Add(this.recSaveChBtn);
               this.Controls.Add(this.recEditBtn);
               this.Controls.Add(this.recSaveBtn);
               this.Controls.Add(this.recDataLabel);
               this.Controls.Add(this.recDataBox);
               this.Controls.Add(this.recNameLabel);
               this.Controls.Add(this.recNameBox);
               this.Controls.Add(this.newRecBtn);
               this.Controls.Add(this.delBtn);
               this.Controls.Add(this.recordDataBox);
               this.Controls.Add(this.recordsBox);
               this.Controls.Add(this.userLabel);
               this.Name = "FormUser";
               this.Text = "User";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label userLabel;
          private System.Windows.Forms.ListBox recordsBox;
          private System.Windows.Forms.TextBox recordDataBox;
          private System.Windows.Forms.Button delBtn;
          private System.Windows.Forms.Button newRecBtn;
          private System.Windows.Forms.TextBox recNameBox;
          private System.Windows.Forms.Label recNameLabel;
          private System.Windows.Forms.TextBox recDataBox;
          private System.Windows.Forms.Label recDataLabel;
          private System.Windows.Forms.Button recSaveBtn;
          private System.Windows.Forms.Button recEditBtn;
          private System.Windows.Forms.Button recSaveChBtn;
     }
}