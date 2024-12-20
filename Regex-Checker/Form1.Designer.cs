namespace Regex_Checker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbRegex = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRegex
            // 
            this.tbRegex.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbRegex.Location = new System.Drawing.Point(12, 21);
            this.tbRegex.Name = "tbRegex";
            this.tbRegex.Size = new System.Drawing.Size(231, 24);
            this.tbRegex.TabIndex = 0;
            this.tbRegex.TabStop = false;
            this.tbRegex.Text = "Write Your Pattern...";
            this.tbRegex.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbRegex.Enter += new System.EventHandler(this.tb_Enter);
            this.tbRegex.Leave += new System.EventHandler(this.tb_Leave);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbInput.Location = new System.Drawing.Point(12, 60);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(231, 24);
            this.tbInput.TabIndex = 1;
            this.tbInput.TabStop = false;
            this.tbInput.Text = "Write Your Text...";
            this.tbInput.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbInput.Enter += new System.EventHandler(this.tb_Enter);
            this.tbInput.Leave += new System.EventHandler(this.tb_Leave);
            // 
            // btCheck
            // 
            this.btCheck.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btCheck.FlatAppearance.BorderSize = 0;
            this.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheck.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheck.ForeColor = System.Drawing.Color.Navy;
            this.btCheck.Location = new System.Drawing.Point(259, 21);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 26);
            this.btCheck.TabIndex = 1;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = false;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.SeaShell;
            this.btClear.Location = new System.Drawing.Point(259, 60);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 27);
            this.btClear.TabIndex = 0;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(346, 103);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbRegex);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regex-Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRegex;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btClear;
    }
}

