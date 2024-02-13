namespace MgRename
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
            label1 = new Label();
            dirPath_txt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            currentName_txt = new TextBox();
            newName_txt = new TextBox();
            renameAll_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Directory:";
            // 
            // dirPath_txt
            // 
            dirPath_txt.Location = new Point(103, 9);
            dirPath_txt.Name = "dirPath_txt";
            dirPath_txt.Size = new Size(647, 23);
            dirPath_txt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 2;
            label2.Text = "Current Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 48);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "New Name:";
            // 
            // currentName_txt
            // 
            currentName_txt.Location = new Point(103, 40);
            currentName_txt.Name = "currentName_txt";
            currentName_txt.Size = new Size(283, 23);
            currentName_txt.TabIndex = 4;
            // 
            // newName_txt
            // 
            newName_txt.Location = new Point(467, 40);
            newName_txt.Name = "newName_txt";
            newName_txt.Size = new Size(283, 23);
            newName_txt.TabIndex = 5;
            // 
            // renameAll_btn
            // 
            renameAll_btn.Location = new Point(12, 79);
            renameAll_btn.Name = "renameAll_btn";
            renameAll_btn.Size = new Size(738, 23);
            renameAll_btn.TabIndex = 6;
            renameAll_btn.Text = "Rename All";
            renameAll_btn.UseVisualStyleBackColor = true;
            renameAll_btn.Click += renameAll_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 121);
            Controls.Add(renameAll_btn);
            Controls.Add(newName_txt);
            Controls.Add(currentName_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dirPath_txt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox dirPath_txt;
        private Label label2;
        private Label label3;
        private TextBox currentName_txt;
        private TextBox newName_txt;
        private Button renameAll_btn;
    }
}