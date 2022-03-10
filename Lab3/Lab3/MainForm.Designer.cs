namespace Lab3
{
    partial class MainForm
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
            this.makeFontBiggerButton = new System.Windows.Forms.Button();
            this.changeSymbolButton = new System.Windows.Forms.Button();
            this.changeColorButton = new System.Windows.Forms.Button();
            this.turnOffButton = new System.Windows.Forms.Button();
            this.screenTextBox = new System.Windows.Forms.TextBox();
            this.turnOnButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.makeFontSmallerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // makeFontBiggerButton
            // 
            this.makeFontBiggerButton.Location = new System.Drawing.Point(12, 274);
            this.makeFontBiggerButton.Name = "makeFontBiggerButton";
            this.makeFontBiggerButton.Size = new System.Drawing.Size(154, 46);
            this.makeFontBiggerButton.TabIndex = 0;
            this.makeFontBiggerButton.Text = "Увеличить символы";
            this.makeFontBiggerButton.UseVisualStyleBackColor = true;
            this.makeFontBiggerButton.Click += new System.EventHandler(this.makeFontBiggerButton_Click);
            // 
            // changeSymbolButton
            // 
            this.changeSymbolButton.Location = new System.Drawing.Point(12, 229);
            this.changeSymbolButton.Name = "changeSymbolButton";
            this.changeSymbolButton.Size = new System.Drawing.Size(320, 39);
            this.changeSymbolButton.TabIndex = 0;
            this.changeSymbolButton.Text = "Поменять символы";
            this.changeSymbolButton.UseVisualStyleBackColor = true;
            this.changeSymbolButton.Click += new System.EventHandler(this.changeSymbolButton_Click);
            // 
            // changeColorButton
            // 
            this.changeColorButton.Location = new System.Drawing.Point(12, 179);
            this.changeColorButton.Name = "changeColorButton";
            this.changeColorButton.Size = new System.Drawing.Size(320, 44);
            this.changeColorButton.TabIndex = 1;
            this.changeColorButton.Text = "Изменить цвет";
            this.changeColorButton.UseVisualStyleBackColor = true;
            this.changeColorButton.Click += new System.EventHandler(this.changeColorButton_Click);
            // 
            // turnOffButton
            // 
            this.turnOffButton.Location = new System.Drawing.Point(12, 136);
            this.turnOffButton.Name = "turnOffButton";
            this.turnOffButton.Size = new System.Drawing.Size(320, 37);
            this.turnOffButton.TabIndex = 2;
            this.turnOffButton.Text = "Выключить экран";
            this.turnOffButton.UseVisualStyleBackColor = true;
            this.turnOffButton.Click += new System.EventHandler(this.turnOffButton_Click);
            // 
            // screenTextBox
            // 
            this.screenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenTextBox.Location = new System.Drawing.Point(12, 12);
            this.screenTextBox.Multiline = true;
            this.screenTextBox.Name = "screenTextBox";
            this.screenTextBox.ReadOnly = true;
            this.screenTextBox.Size = new System.Drawing.Size(320, 75);
            this.screenTextBox.TabIndex = 3;
            // 
            // turnOnButton
            // 
            this.turnOnButton.Location = new System.Drawing.Point(12, 93);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new System.Drawing.Size(320, 37);
            this.turnOnButton.TabIndex = 4;
            this.turnOnButton.Text = "Включить экран";
            this.turnOnButton.UseVisualStyleBackColor = true;
            this.turnOnButton.Click += new System.EventHandler(this.turnOnButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(12, 326);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(154, 112);
            this.undoButton.TabIndex = 5;
            this.undoButton.Text = "Отменить";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.Location = new System.Drawing.Point(172, 326);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(160, 112);
            this.redoButton.TabIndex = 6;
            this.redoButton.Text = "Повторить";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // makeFontSmallerButton
            // 
            this.makeFontSmallerButton.Location = new System.Drawing.Point(172, 274);
            this.makeFontSmallerButton.Name = "makeFontSmallerButton";
            this.makeFontSmallerButton.Size = new System.Drawing.Size(160, 46);
            this.makeFontSmallerButton.TabIndex = 7;
            this.makeFontSmallerButton.Text = "Уменьшить символы";
            this.makeFontSmallerButton.UseVisualStyleBackColor = true;
            this.makeFontSmallerButton.Click += new System.EventHandler(this.makeFontSmallerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.makeFontSmallerButton);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.turnOnButton);
            this.Controls.Add(this.screenTextBox);
            this.Controls.Add(this.turnOffButton);
            this.Controls.Add(this.changeColorButton);
            this.Controls.Add(this.changeSymbolButton);
            this.Controls.Add(this.makeFontBiggerButton);
            this.Name = "MainForm";
            this.Text = "Цветовой пульт";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeFontBiggerButton;
        private System.Windows.Forms.Button changeSymbolButton;
        private System.Windows.Forms.Button changeColorButton;
        private System.Windows.Forms.Button turnOffButton;
        private System.Windows.Forms.TextBox screenTextBox;
        private System.Windows.Forms.Button turnOnButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button makeFontSmallerButton;
    }
}

