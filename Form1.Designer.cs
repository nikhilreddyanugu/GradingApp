namespace GradingApp
{
    partial class Form1
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
            btnProcessGrad = new Button();
            SuspendLayout();
            // 
            // btnProcessGrad
            // 
            btnProcessGrad.Location = new Point(262, 97);
            btnProcessGrad.Name = "btnProcessGrad";
            btnProcessGrad.Size = new Size(187, 34);
            btnProcessGrad.TabIndex = 0;
            btnProcessGrad.Text = "ProcessGrad";
            btnProcessGrad.UseVisualStyleBackColor = true;
            btnProcessGrad.Click += btnProcessGrad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcessGrad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcessGrad;
    }
}