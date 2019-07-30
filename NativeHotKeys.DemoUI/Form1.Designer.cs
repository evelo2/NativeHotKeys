namespace NativeHotKeys.DemoUI
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
            this.cboModifier1 = new System.Windows.Forms.ComboBox();
            this.cboModifier2 = new System.Windows.Forms.ComboBox();
            this.cboKey = new System.Windows.Forms.ComboBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboModifier1
            // 
            this.cboModifier1.FormattingEnabled = true;
            this.cboModifier1.Location = new System.Drawing.Point(116, 29);
            this.cboModifier1.Name = "cboModifier1";
            this.cboModifier1.Size = new System.Drawing.Size(121, 21);
            this.cboModifier1.TabIndex = 0;
            // 
            // cboModifier2
            // 
            this.cboModifier2.FormattingEnabled = true;
            this.cboModifier2.Location = new System.Drawing.Point(116, 83);
            this.cboModifier2.Name = "cboModifier2";
            this.cboModifier2.Size = new System.Drawing.Size(121, 21);
            this.cboModifier2.TabIndex = 1;
            // 
            // cboKey
            // 
            this.cboKey.FormattingEnabled = true;
            this.cboKey.Location = new System.Drawing.Point(116, 140);
            this.cboKey.Name = "cboKey";
            this.cboKey.Size = new System.Drawing.Size(121, 21);
            this.cboKey.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(116, 203);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(427, 20);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "{Key} - Here is a message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modifier One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modifier Two";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sample Message";
            // 
            // cmdRegister
            // 
            this.cmdRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRegister.Location = new System.Drawing.Point(450, 265);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(92, 24);
            this.cmdRegister.TabIndex = 8;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = true;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 306);
            this.Controls.Add(this.cmdRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.cboKey);
            this.Controls.Add(this.cboModifier2);
            this.Controls.Add(this.cboModifier1);
            this.Name = "Form1";
            this.Text = "Demonstration of HotKey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboModifier1;
        private System.Windows.Forms.ComboBox cboModifier2;
        private System.Windows.Forms.ComboBox cboKey;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdRegister;
    }
}

