namespace AppManagement
{
    partial class frmViewDetails
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
            this.lbPath = new System.Windows.Forms.Label();
            this.lbCate = new System.Windows.Forms.Label();
            this.lbDescrip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPath.Location = new System.Drawing.Point(27, 76);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(76, 16);
            this.lbPath.TabIndex = 0;
            this.lbPath.Text = "File path: ";
            // 
            // lbCate
            // 
            this.lbCate.AutoSize = true;
            this.lbCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCate.Location = new System.Drawing.Point(27, 132);
            this.lbCate.Name = "lbCate";
            this.lbCate.Size = new System.Drawing.Size(79, 16);
            this.lbCate.TabIndex = 1;
            this.lbCate.Text = "Category: ";
            // 
            // lbDescrip
            // 
            this.lbDescrip.AutoSize = true;
            this.lbDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDescrip.Location = new System.Drawing.Point(27, 184);
            this.lbDescrip.Name = "lbDescrip";
            this.lbDescrip.Size = new System.Drawing.Size(95, 16);
            this.lbDescrip.TabIndex = 2;
            this.lbDescrip.Text = "Description: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(137, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Details";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.Location = new System.Drawing.Point(323, 229);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(81, 32);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmViewDetails
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(416, 271);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDescrip);
            this.Controls.Add(this.lbCate);
            this.Controls.Add(this.lbPath);
            this.Name = "frmViewDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbCate;
        private System.Windows.Forms.Label lbDescrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
    }
}