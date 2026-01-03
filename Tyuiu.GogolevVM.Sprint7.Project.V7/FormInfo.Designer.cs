namespace Tyuiu.GogolevVM.Sprint7.Project.V7
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            textBoxInfo_GVM = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxInfo_GVM
            // 
            textBoxInfo_GVM.Location = new Point(279, 12);
            textBoxInfo_GVM.Multiline = true;
            textBoxInfo_GVM.Name = "textBoxInfo_GVM";
            textBoxInfo_GVM.ReadOnly = true;
            textBoxInfo_GVM.Size = new Size(509, 141);
            textBoxInfo_GVM.TabIndex = 0;
            textBoxInfo_GVM.Text = resources.GetString("textBoxInfo_GVM.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Рисунок1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 426);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxInfo_GVM);
            Name = "FormInfo";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo_GVM;
        private PictureBox pictureBox1;
    }
}