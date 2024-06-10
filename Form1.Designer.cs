namespace Csharp_Tinhgiaithua
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
            this.txtso = new System.Windows.Forms.TextBox();
            this.txtgiaithua = new System.Windows.Forms.TextBox();
            this.lblso = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.lblgiaithua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(213, 77);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(100, 20);
            this.txtso.TabIndex = 0;
            // 
            // txtgiaithua
            // 
            this.txtgiaithua.Location = new System.Drawing.Point(213, 149);
            this.txtgiaithua.Name = "txtgiaithua";
            this.txtgiaithua.Size = new System.Drawing.Size(100, 20);
            this.txtgiaithua.TabIndex = 1;
            // 
            // lblso
            // 
            this.lblso.AutoSize = true;
            this.lblso.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblso.Location = new System.Drawing.Point(104, 74);
            this.lblso.Name = "lblso";
            this.lblso.Size = new System.Drawing.Size(31, 23);
            this.lblso.TabIndex = 2;
            this.lblso.Text = "Số";
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(213, 223);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(100, 42);
            this.btntinh.TabIndex = 3;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lblgiaithua
            // 
            this.lblgiaithua.AutoSize = true;
            this.lblgiaithua.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgiaithua.Location = new System.Drawing.Point(104, 146);
            this.lblgiaithua.Name = "lblgiaithua";
            this.lblgiaithua.Size = new System.Drawing.Size(86, 23);
            this.lblgiaithua.TabIndex = 4;
            this.lblgiaithua.Text = "Giai thừa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblgiaithua);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lblso);
            this.Controls.Add(this.txtgiaithua);
            this.Controls.Add(this.txtso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.TextBox txtgiaithua;
        private System.Windows.Forms.Label lblso;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label lblgiaithua;
    }
}

