namespace LifeProga
{
    partial class WorkForm
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
            this.FLab = new System.Windows.Forms.Label();
            this.OutBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FLab
            // 
            this.FLab.AutoSize = true;
            this.FLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FLab.Location = new System.Drawing.Point(7, 7);
            this.FLab.Name = "FLab";
            this.FLab.Size = new System.Drawing.Size(56, 13);
            this.FLab.TabIndex = 2;
            this.FLab.Text = "Function";
            // 
            // OutBox
            // 
            this.OutBox.Location = new System.Drawing.Point(6, 33);
            this.OutBox.Name = "OutBox";
            this.OutBox.Size = new System.Drawing.Size(614, 424);
            this.OutBox.TabIndex = 3;
            this.OutBox.TabStop = false;
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 460);
            this.Controls.Add(this.OutBox);
            this.Controls.Add(this.FLab);
            this.Name = "WorkForm";
            this.Text = "GrapWin";
            ((System.ComponentModel.ISupportInitialize)(this.OutBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FLab;
        private System.Windows.Forms.PictureBox OutBox;
    }
}