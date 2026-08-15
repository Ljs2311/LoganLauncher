namespace MyFirstWindowsApp
{
    partial class AddApplicationForm
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
            label1 = new Label();
            appNameTextBox = new TextBox();
            label2 = new Label();
            exePathTextBox = new TextBox();
            browseButton = new Button();
            addAppButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Application Name";
            // 
            // appNameTextBox
            // 
            appNameTextBox.Location = new Point(138, 25);
            appNameTextBox.Name = "appNameTextBox";
            appNameTextBox.Size = new Size(100, 23);
            appNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 58);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Executable";
            // 
            // exePathTextBox
            // 
            exePathTextBox.Location = new Point(101, 54);
            exePathTextBox.Name = "exePathTextBox";
            exePathTextBox.Size = new Size(188, 23);
            exePathTextBox.TabIndex = 3;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(295, 53);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 23);
            browseButton.TabIndex = 4;
            browseButton.Text = "Browse...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // addAppButton
            // 
            addAppButton.Location = new Point(32, 100);
            addAppButton.Name = "addAppButton";
            addAppButton.Size = new Size(140, 40);
            addAppButton.TabIndex = 5;
            addAppButton.Text = "Add Application";
            addAppButton.UseVisualStyleBackColor = true;
            addAppButton.Click += addAppButton_Click;
            // 
            // AddApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addAppButton);
            Controls.Add(browseButton);
            Controls.Add(exePathTextBox);
            Controls.Add(label2);
            Controls.Add(appNameTextBox);
            Controls.Add(label1);
            Name = "AddApplicationForm";
            Text = "Add Application Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox appNameTextBox;
        private Label label2;
        private TextBox exePathTextBox;
        private Button browseButton;
        private Button addAppButton;
    }
}