namespace ChessGame
{
    partial class InitialForm
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
            this.SuspendLayout();
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 862);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InitialForm";
            this.Text = "InitialForm";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.InitialForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

