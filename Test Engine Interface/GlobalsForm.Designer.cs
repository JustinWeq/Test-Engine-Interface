namespace Test_Engine_Interface
{
    partial class GlobalsForm
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
            this.globals_textBox = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // globals_textBox
            // 
            this.globals_textBox.Location = new System.Drawing.Point(141, 12);
            this.globals_textBox.Multiline = true;
            this.globals_textBox.Name = "globals_textBox";
            this.globals_textBox.Size = new System.Drawing.Size(380, 493);
            this.globals_textBox.TabIndex = 0;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(24, 64);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(111, 23);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(24, 23);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(111, 23);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // GlobalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(530, 528);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.globals_textBox);
            this.Name = "GlobalsForm";
            this.Text = "Globals Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox globals_textBox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
    }
}