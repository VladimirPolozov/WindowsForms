
namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DirectoryOneLabel = new System.Windows.Forms.Label();
            this.DirectoryTwoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseDirectoryOneButton = new System.Windows.Forms.Button();
            this.ChooseDirectoryTwoButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1418, 535);
            this.splitContainer1.SplitterDistance = 385;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ChooseDirectoryOneButton);
            this.splitContainer2.Panel1.Controls.Add(this.DirectoryOneLabel);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ChooseDirectoryTwoButton);
            this.splitContainer2.Panel2.Controls.Add(this.DirectoryTwoLabel);
            this.splitContainer2.Size = new System.Drawing.Size(1029, 535);
            this.splitContainer2.SplitterDistance = 527;
            this.splitContainer2.TabIndex = 0;
            // 
            // DirectoryOneLabel
            // 
            this.DirectoryOneLabel.AutoSize = true;
            this.DirectoryOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryOneLabel.Location = new System.Drawing.Point(3, 9);
            this.DirectoryOneLabel.Name = "DirectoryOneLabel";
            this.DirectoryOneLabel.Size = new System.Drawing.Size(162, 25);
            this.DirectoryOneLabel.TabIndex = 0;
            this.DirectoryOneLabel.Text = "Директория 1";
            this.DirectoryOneLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // DirectoryTwoLabel
            // 
            this.DirectoryTwoLabel.AutoSize = true;
            this.DirectoryTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryTwoLabel.Location = new System.Drawing.Point(3, 9);
            this.DirectoryTwoLabel.Name = "DirectoryTwoLabel";
            this.DirectoryTwoLabel.Size = new System.Drawing.Size(162, 25);
            this.DirectoryTwoLabel.TabIndex = 0;
            this.DirectoryTwoLabel.Text = "Директория 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Журнал сообщений";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChooseDirectoryOneButton
            // 
            this.ChooseDirectoryOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDirectoryOneButton.Location = new System.Drawing.Point(171, 9);
            this.ChooseDirectoryOneButton.Name = "ChooseDirectoryOneButton";
            this.ChooseDirectoryOneButton.Size = new System.Drawing.Size(146, 25);
            this.ChooseDirectoryOneButton.TabIndex = 1;
            this.ChooseDirectoryOneButton.Text = "Выбрать";
            this.ChooseDirectoryOneButton.UseVisualStyleBackColor = true;
            this.ChooseDirectoryOneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChooseDirectoryTwoButton
            // 
            this.ChooseDirectoryTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDirectoryTwoButton.Location = new System.Drawing.Point(171, 9);
            this.ChooseDirectoryTwoButton.Name = "ChooseDirectoryTwoButton";
            this.ChooseDirectoryTwoButton.Size = new System.Drawing.Size(146, 25);
            this.ChooseDirectoryTwoButton.TabIndex = 2;
            this.ChooseDirectoryTwoButton.Text = "Выбрать";
            this.ChooseDirectoryTwoButton.UseVisualStyleBackColor = true;
            this.ChooseDirectoryTwoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 535);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label DirectoryOneLabel;
        private System.Windows.Forms.Label DirectoryTwoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChooseDirectoryOneButton;
        private System.Windows.Forms.Button ChooseDirectoryTwoButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

