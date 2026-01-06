namespace Tyuiu.GogolevVM.Sprint7.Project.V7
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            textBoxGuide_GVM = new TextBox();
            SuspendLayout();
            // 
            // textBoxGuide_GVM
            // 
            textBoxGuide_GVM.Location = new Point(13, 12);
            textBoxGuide_GVM.Multiline = true;
            textBoxGuide_GVM.Name = "textBoxGuide_GVM";
            textBoxGuide_GVM.ReadOnly = true;
            textBoxGuide_GVM.ScrollBars = ScrollBars.Vertical;
            textBoxGuide_GVM.Size = new Size(998, 569);
            textBoxGuide_GVM.TabIndex = 0;
            textBoxGuide_GVM.Text = resources.GetString("textBoxGuide_GVM.Text");
            textBoxGuide_GVM.TextChanged += textBox1_TextChanged;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 659);
            Controls.Add(textBoxGuide_GVM);
            MaximizeBox = false;
            MaximumSize = new Size(1070, 706);
            MinimumSize = new Size(1070, 706);
            Name = "FormGuide";
            Text = "Руководство к программе \"Домоуправление\"";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxGuide_GVM;
    }
}