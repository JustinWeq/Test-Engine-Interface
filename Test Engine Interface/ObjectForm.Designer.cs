namespace Test_Engine_Interface
{
    partial class ObjectForm
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
            this.accept_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton3D = new System.Windows.Forms.RadioButton();
            this.radioButton2D = new System.Windows.Forms.RadioButton();
            this.controller_radioButton = new System.Windows.Forms.RadioButton();
            this.type_label = new System.Windows.Forms.Label();
            this.collision_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.image_pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.in_rtxbox = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // accept_button
            // 
            this.accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_button.Location = new System.Drawing.Point(12, 470);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(129, 33);
            this.accept_button.TabIndex = 0;
            this.accept_button.Text = "Accept";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(147, 470);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(129, 33);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.radioButton3D);
            this.flowLayoutPanel1.Controls.Add(this.radioButton2D);
            this.flowLayoutPanel1.Controls.Add(this.controller_radioButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 157);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(166, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // radioButton3D
            // 
            this.radioButton3D.AutoSize = true;
            this.radioButton3D.Location = new System.Drawing.Point(3, 3);
            this.radioButton3D.Name = "radioButton3D";
            this.radioButton3D.Size = new System.Drawing.Size(71, 17);
            this.radioButton3D.TabIndex = 0;
            this.radioButton3D.TabStop = true;
            this.radioButton3D.Text = "3D object";
            this.radioButton3D.UseVisualStyleBackColor = true;
            // 
            // radioButton2D
            // 
            this.radioButton2D.AutoSize = true;
            this.radioButton2D.Location = new System.Drawing.Point(3, 26);
            this.radioButton2D.Name = "radioButton2D";
            this.radioButton2D.Size = new System.Drawing.Size(71, 17);
            this.radioButton2D.TabIndex = 1;
            this.radioButton2D.TabStop = true;
            this.radioButton2D.Text = "2D object";
            this.radioButton2D.UseVisualStyleBackColor = true;
            // 
            // controller_radioButton
            // 
            this.controller_radioButton.AutoSize = true;
            this.controller_radioButton.Location = new System.Drawing.Point(3, 49);
            this.controller_radioButton.Name = "controller_radioButton";
            this.controller_radioButton.Size = new System.Drawing.Size(69, 17);
            this.controller_radioButton.TabIndex = 2;
            this.controller_radioButton.TabStop = true;
            this.controller_radioButton.Text = "Controller";
            this.controller_radioButton.UseVisualStyleBackColor = true;
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(17, 138);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(65, 13);
            this.type_label.TabIndex = 4;
            this.type_label.Text = "Object Type";
            // 
            // collision_label
            // 
            this.collision_label.AutoSize = true;
            this.collision_label.Location = new System.Drawing.Point(9, 260);
            this.collision_label.Name = "collision_label";
            this.collision_label.Size = new System.Drawing.Size(72, 13);
            this.collision_label.TabIndex = 6;
            this.collision_label.Text = "Collision Type";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 276);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(166, 100);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // image_pictureBox
            // 
            this.image_pictureBox.Location = new System.Drawing.Point(275, 13);
            this.image_pictureBox.Name = "image_pictureBox";
            this.image_pictureBox.Size = new System.Drawing.Size(293, 212);
            this.image_pictureBox.TabIndex = 7;
            this.image_pictureBox.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(275, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(17, 25);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(148, 20);
            this.name_textBox.TabIndex = 9;
            // 
            // in_rtxbox
            // 
            this.in_rtxbox.Location = new System.Drawing.Point(575, 13);
            this.in_rtxbox.Name = "in_rtxbox";
            this.in_rtxbox.Size = new System.Drawing.Size(697, 502);
            this.in_rtxbox.TabIndex = 12;
            this.in_rtxbox.Text = "";
            // 
            // ObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 527);
            this.Controls.Add(this.in_rtxbox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.image_pictureBox);
            this.Controls.Add(this.collision_label);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.Name = "ObjectForm";
            this.Text = "Object Editor";
            this.Load += new System.EventHandler(this.ObjectForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton3D;
        private System.Windows.Forms.RadioButton radioButton2D;
        private System.Windows.Forms.RadioButton controller_radioButton;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label collision_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox image_pictureBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.RichTextBox in_rtxbox;
    }
}