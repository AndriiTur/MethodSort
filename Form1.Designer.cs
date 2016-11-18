namespace MethodSort
{
    partial class SortingForm
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.MethodSortButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(12, 12);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(260, 20);
            this.InputTextBox.TabIndex = 0;
            // 
            // MethodSortButton
            // 
            this.MethodSortButton.Location = new System.Drawing.Point(85, 102);
            this.MethodSortButton.Name = "MethodSortButton";
            this.MethodSortButton.Size = new System.Drawing.Size(113, 47);
            this.MethodSortButton.TabIndex = 1;
            this.MethodSortButton.Text = "MethodSort";
            this.MethodSortButton.UseVisualStyleBackColor = true;
            this.MethodSortButton.Click += new System.EventHandler(this.MethodSortButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(12, 229);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(260, 20);
            this.OutputTextBox.TabIndex = 2;
            // 
            // SortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.MethodSortButton);
            this.Controls.Add(this.InputTextBox);
            this.Name = "SortingForm";
            this.Text = "Sorting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button MethodSortButton;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}

