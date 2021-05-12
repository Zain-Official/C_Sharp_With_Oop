
namespace UserActivityLog_OOP_Concept
{
    partial class frmActivity
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
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Discard_Btn = new System.Windows.Forms.Button();
            this.logout_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.DarkOrange;
            this.Add_Btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Btn.Location = new System.Drawing.Point(43, 139);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(117, 40);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Add New";
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.BackColor = System.Drawing.Color.DarkOrange;
            this.Save_Btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save_Btn.Location = new System.Drawing.Point(179, 139);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(102, 40);
            this.Save_Btn.TabIndex = 1;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = false;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Discard_Btn
            // 
            this.Discard_Btn.BackColor = System.Drawing.Color.DarkOrange;
            this.Discard_Btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Discard_Btn.Location = new System.Drawing.Point(298, 139);
            this.Discard_Btn.Name = "Discard_Btn";
            this.Discard_Btn.Size = new System.Drawing.Size(104, 40);
            this.Discard_Btn.TabIndex = 2;
            this.Discard_Btn.Text = "Discard";
            this.Discard_Btn.UseVisualStyleBackColor = false;
            this.Discard_Btn.Click += new System.EventHandler(this.Discard_Btn_Click);
            // 
            // logout_Btn
            // 
            this.logout_Btn.BackColor = System.Drawing.Color.DarkOrange;
            this.logout_Btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logout_Btn.Location = new System.Drawing.Point(158, 195);
            this.logout_Btn.Name = "logout_Btn";
            this.logout_Btn.Size = new System.Drawing.Size(142, 39);
            this.logout_Btn.TabIndex = 3;
            this.logout_Btn.Text = "Logout";
            this.logout_Btn.UseVisualStyleBackColor = false;
            this.logout_Btn.Click += new System.EventHandler(this.logout_Btn_Click);
            // 
            // frmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 277);
            this.Controls.Add(this.logout_Btn);
            this.Controls.Add(this.Discard_Btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.Add_Btn);
            this.Name = "frmActivity";
            this.Text = "frmActivity";
            this.Load += new System.EventHandler(this.frmActivity_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Discard_Btn;
        private System.Windows.Forms.Button logout_Btn;
    }
}