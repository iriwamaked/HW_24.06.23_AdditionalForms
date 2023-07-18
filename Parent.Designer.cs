namespace HW_24._06._23
{
    partial class Parent
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
            textParent = new TextBox();
            SuspendLayout();
            // 
            // textParent
            // 
            textParent.Location = new Point(71, 70);
            textParent.Name = "textParent";
            textParent.Size = new Size(376, 27);
            textParent.TabIndex = 0;
            textParent.TextChanged += textParent_TextChanged;
            // 
            // Parent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 344);
            Controls.Add(textParent);
            Name = "Parent";
            Text = "Parent";
            Load += Parent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textParent;
    }
}