namespace Forgot_Password
{
    partial class FormNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonChange);
            this.panel1.Controls.Add(this.buttonLogIn);
            this.panel1.Controls.Add(this.textBoxConfirm);
            this.panel1.Controls.Add(this.textBoxNew);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 818);
            this.panel1.TabIndex = 0;
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChange.BackColor = System.Drawing.Color.Black;
            this.buttonChange.FlatAppearance.BorderSize = 0;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.Location = new System.Drawing.Point(130, 640);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(374, 40);
            this.buttonChange.TabIndex = 21;
            this.buttonChange.Text = "CHANGE";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogIn.BackColor = System.Drawing.Color.Black;
            this.buttonLogIn.FlatAppearance.BorderSize = 0;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogIn.ForeColor = System.Drawing.Color.White;
            this.buttonLogIn.Location = new System.Drawing.Point(130, 706);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(374, 41);
            this.buttonLogIn.TabIndex = 20;
            this.buttonLogIn.Text = "CANCEL";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxConfirm.Location = new System.Drawing.Point(130, 545);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.Size = new System.Drawing.Size(374, 28);
            this.textBoxConfirm.TabIndex = 19;
            this.textBoxConfirm.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxNew
            // 
            this.textBoxNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNew.Location = new System.Drawing.Point(130, 417);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.Size = new System.Drawing.Size(374, 28);
            this.textBoxNew.TabIndex = 18;
            this.textBoxNew.TextChanged += new System.EventHandler(this.textBoxCNIC_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Confirm Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "New Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Forgot_Password.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(130, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 818);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log In | New Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonChange;
        private Button buttonLogIn;
        private TextBox textBoxConfirm;
        private TextBox textBoxNew;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}