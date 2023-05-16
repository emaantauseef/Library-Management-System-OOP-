
namespace library_mangement_system
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoginAsStudent_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginAsStaff_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginAsStudent_Button
            // 
            this.LoginAsStudent_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginAsStudent_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginAsStudent_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAsStudent_Button.ForeColor = System.Drawing.Color.White;
            this.LoginAsStudent_Button.Location = new System.Drawing.Point(501, 360);
            this.LoginAsStudent_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginAsStudent_Button.Name = "LoginAsStudent_Button";
            this.LoginAsStudent_Button.Size = new System.Drawing.Size(188, 86);
            this.LoginAsStudent_Button.TabIndex = 9;
            this.LoginAsStudent_Button.Text = "Student";
            this.LoginAsStudent_Button.UseVisualStyleBackColor = false;
            this.LoginAsStudent_Button.Click += new System.EventHandler(this.LoginAsStudent_ButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(142, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(692, 46);
            this.label7.TabIndex = 12;
            this.label7.Text = "Library Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(345, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login As A:";
            // 
            // LoginAsStaff_Button
            // 
            this.LoginAsStaff_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginAsStaff_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginAsStaff_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAsStaff_Button.ForeColor = System.Drawing.Color.White;
            this.LoginAsStaff_Button.Location = new System.Drawing.Point(288, 360);
            this.LoginAsStaff_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginAsStaff_Button.Name = "LoginAsStaff_Button";
            this.LoginAsStaff_Button.Size = new System.Drawing.Size(184, 86);
            this.LoginAsStaff_Button.TabIndex = 13;
            this.LoginAsStaff_Button.Text = "Staff";
            this.LoginAsStaff_Button.UseVisualStyleBackColor = false;
            this.LoginAsStaff_Button.Click += new System.EventHandler(this.LoginAsStaff_ButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 654);
            this.Controls.Add(this.LoginAsStaff_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginAsStudent_Button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginAsStudent_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginAsStaff_Button;
    }
}

