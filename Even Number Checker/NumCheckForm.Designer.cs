namespace WindowsFormsApp3
{
    partial class NumCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumCheckForm));
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_primeResult = new System.Windows.Forms.Label();
            this.txtbox_userInput = new System.Windows.Forms.TextBox();
            this.lbl_isPrime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_description.AutoSize = true;
            this.lbl_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_description.Font = new System.Drawing.Font("Forte", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(24, 34);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_description.Size = new System.Drawing.Size(291, 22);
            this.lbl_description.TabIndex = 0;
            this.lbl_description.Text = "Please enter any positive number.\r\n";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_primeResult
            // 
            this.lbl_primeResult.AutoSize = true;
            this.lbl_primeResult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_primeResult.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primeResult.ForeColor = System.Drawing.Color.White;
            this.lbl_primeResult.Location = new System.Drawing.Point(145, 174);
            this.lbl_primeResult.Name = "lbl_primeResult";
            this.lbl_primeResult.Size = new System.Drawing.Size(0, 21);
            this.lbl_primeResult.TabIndex = 1;
            this.lbl_primeResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_userInput
            // 
            this.txtbox_userInput.AcceptsReturn = true;
            this.txtbox_userInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_userInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_userInput.Location = new System.Drawing.Point(92, 94);
            this.txtbox_userInput.Name = "txtbox_userInput";
            this.txtbox_userInput.Size = new System.Drawing.Size(152, 20);
            this.txtbox_userInput.TabIndex = 2;
            this.txtbox_userInput.TabStop = false;
            this.txtbox_userInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_userInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_userInput_KeyPress);
            // 
            // lbl_isPrime
            // 
            this.lbl_isPrime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_isPrime.AutoSize = true;
            this.lbl_isPrime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_isPrime.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isPrime.ForeColor = System.Drawing.Color.White;
            this.lbl_isPrime.Location = new System.Drawing.Point(126, 136);
            this.lbl_isPrime.Name = "lbl_isPrime";
            this.lbl_isPrime.Size = new System.Drawing.Size(80, 17);
            this.lbl_isPrime.TabIndex = 3;
            this.lbl_isPrime.Text = "Is it Even?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(341, 227);
            this.Controls.Add(this.lbl_isPrime);
            this.Controls.Add(this.txtbox_userInput);
            this.Controls.Add(this.lbl_primeResult);
            this.Controls.Add(this.lbl_description);
            this.ForeColor = System.Drawing.Color.HotPink;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Even Number Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_primeResult;
        private System.Windows.Forms.TextBox txtbox_userInput;
        private System.Windows.Forms.Label lbl_isPrime;
    }
}

