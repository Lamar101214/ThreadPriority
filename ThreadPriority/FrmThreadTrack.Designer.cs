namespace ThreadPriority
{
    partial class FrmThreadTrack
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRun = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.FromArgb(192, 255, 255);
            btnRun.Location = new Point(340, 320);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(120, 50);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Microsoft Sans Serif", 24F);
            label1.Location = new Point(50, 150);
            label1.Name = "label1";
            label1.Size = new Size(700, 60);
            label1.TabIndex = 1;
            label1.Text = "-Thread Starts -";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmThreadTrack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnRun);
            Name = "FrmThreadTrack";
            Text = "frmTrackThread";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
    }
}