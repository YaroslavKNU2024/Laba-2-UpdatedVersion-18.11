
namespace LabOOP2WinForms
{
    partial class OutputTextBox
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
            this.Output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(1, 2);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(723, 861);
            this.Output.TabIndex = 1;
            this.Output.Text = "";
            // 
            // OutputTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 863);
            this.Controls.Add(this.Output);
            this.Name = "OutputTextBox";
            this.Text = "Результат";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox Output;
    }
}