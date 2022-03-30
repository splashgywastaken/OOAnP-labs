namespace Lab3
{
    partial class Remote
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
            this.UndoButton = new System.Windows.Forms.Button();
            this.TurnOnButton = new System.Windows.Forms.Button();
            this.FanOnButton = new System.Windows.Forms.Button();
            this.LightOnButton = new System.Windows.Forms.Button();
            this.HeaterOnButton = new System.Windows.Forms.Button();
            this.MainScreen = new System.Windows.Forms.TextBox();
            this.DoorOpenButton = new System.Windows.Forms.Button();
            this.HeaterOffButton = new System.Windows.Forms.Button();
            this.FanOffButton = new System.Windows.Forms.Button();
            this.LightOffButton = new System.Windows.Forms.Button();
            this.DoorCloseButton = new System.Windows.Forms.Button();
            this.TurnOffButton = new System.Windows.Forms.Button();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.getInfoCommandsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(252, 424);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(235, 39);
            this.UndoButton.TabIndex = 0;
            this.UndoButton.Text = "Отменить действие";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // TurnOnButton
            // 
            this.TurnOnButton.Location = new System.Drawing.Point(11, 379);
            this.TurnOnButton.Name = "TurnOnButton";
            this.TurnOnButton.Size = new System.Drawing.Size(235, 39);
            this.TurnOnButton.TabIndex = 1;
            this.TurnOnButton.Text = "Включить";
            this.TurnOnButton.UseVisualStyleBackColor = true;
            this.TurnOnButton.Click += new System.EventHandler(this.TurnOnButton_Click);
            // 
            // FanOnButton
            // 
            this.FanOnButton.Location = new System.Drawing.Point(11, 244);
            this.FanOnButton.Name = "FanOnButton";
            this.FanOnButton.Size = new System.Drawing.Size(235, 39);
            this.FanOnButton.TabIndex = 5;
            this.FanOnButton.Text = "Включить вентиляцию в гараже";
            this.FanOnButton.UseVisualStyleBackColor = true;
            this.FanOnButton.Click += new System.EventHandler(this.FanOnButton_Click);
            // 
            // LightOnButton
            // 
            this.LightOnButton.Location = new System.Drawing.Point(11, 289);
            this.LightOnButton.Name = "LightOnButton";
            this.LightOnButton.Size = new System.Drawing.Size(235, 39);
            this.LightOnButton.TabIndex = 6;
            this.LightOnButton.Text = "Включить свет в гараже";
            this.LightOnButton.UseVisualStyleBackColor = true;
            this.LightOnButton.Click += new System.EventHandler(this.LightOnButton_Click);
            // 
            // HeaterOnButton
            // 
            this.HeaterOnButton.Location = new System.Drawing.Point(11, 199);
            this.HeaterOnButton.Name = "HeaterOnButton";
            this.HeaterOnButton.Size = new System.Drawing.Size(235, 39);
            this.HeaterOnButton.TabIndex = 7;
            this.HeaterOnButton.Text = "Включить подогрев гаража";
            this.HeaterOnButton.UseVisualStyleBackColor = true;
            this.HeaterOnButton.Click += new System.EventHandler(this.HeaterOnButton_Click);
            // 
            // MainScreen
            // 
            this.MainScreen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainScreen.Location = new System.Drawing.Point(12, 12);
            this.MainScreen.Multiline = true;
            this.MainScreen.Name = "MainScreen";
            this.MainScreen.ReadOnly = true;
            this.MainScreen.Size = new System.Drawing.Size(476, 181);
            this.MainScreen.TabIndex = 8;
            this.MainScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DoorOpenButton
            // 
            this.DoorOpenButton.Location = new System.Drawing.Point(11, 334);
            this.DoorOpenButton.Name = "DoorOpenButton";
            this.DoorOpenButton.Size = new System.Drawing.Size(235, 39);
            this.DoorOpenButton.TabIndex = 9;
            this.DoorOpenButton.Text = "Открыть дверь гаража";
            this.DoorOpenButton.UseVisualStyleBackColor = true;
            this.DoorOpenButton.Click += new System.EventHandler(this.DoorOpenButton_Click);
            // 
            // HeaterOffButton
            // 
            this.HeaterOffButton.Location = new System.Drawing.Point(252, 199);
            this.HeaterOffButton.Name = "HeaterOffButton";
            this.HeaterOffButton.Size = new System.Drawing.Size(235, 39);
            this.HeaterOffButton.TabIndex = 10;
            this.HeaterOffButton.Text = "Выключить подогрев гаража";
            this.HeaterOffButton.UseVisualStyleBackColor = true;
            this.HeaterOffButton.Click += new System.EventHandler(this.HeaterOffButton_Click);
            // 
            // FanOffButton
            // 
            this.FanOffButton.Location = new System.Drawing.Point(252, 244);
            this.FanOffButton.Name = "FanOffButton";
            this.FanOffButton.Size = new System.Drawing.Size(235, 39);
            this.FanOffButton.TabIndex = 11;
            this.FanOffButton.Text = "Выключить вентиляцию";
            this.FanOffButton.UseVisualStyleBackColor = true;
            this.FanOffButton.Click += new System.EventHandler(this.FanOffButton_Click);
            // 
            // LightOffButton
            // 
            this.LightOffButton.Location = new System.Drawing.Point(252, 289);
            this.LightOffButton.Name = "LightOffButton";
            this.LightOffButton.Size = new System.Drawing.Size(235, 39);
            this.LightOffButton.TabIndex = 12;
            this.LightOffButton.Text = "Выключить свет в гараже";
            this.LightOffButton.UseVisualStyleBackColor = true;
            this.LightOffButton.Click += new System.EventHandler(this.LightOffButton_Click);
            // 
            // DoorCloseButton
            // 
            this.DoorCloseButton.Location = new System.Drawing.Point(252, 334);
            this.DoorCloseButton.Name = "DoorCloseButton";
            this.DoorCloseButton.Size = new System.Drawing.Size(235, 39);
            this.DoorCloseButton.TabIndex = 13;
            this.DoorCloseButton.Text = "Закрыть дверь гаража";
            this.DoorCloseButton.UseVisualStyleBackColor = true;
            this.DoorCloseButton.Click += new System.EventHandler(this.DoorCloseButton_Click);
            // 
            // TurnOffButton
            // 
            this.TurnOffButton.Location = new System.Drawing.Point(252, 379);
            this.TurnOffButton.Name = "TurnOffButton";
            this.TurnOffButton.Size = new System.Drawing.Size(235, 39);
            this.TurnOffButton.TabIndex = 14;
            this.TurnOffButton.Text = "Выключить";
            this.TurnOffButton.UseVisualStyleBackColor = true;
            this.TurnOffButton.Click += new System.EventHandler(this.TurnOffButton_Click);
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(11, 424);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(110, 39);
            this.ClearLogButton.TabIndex = 15;
            this.ClearLogButton.Text = "Очистить лог";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // getInfoCommandsButton
            // 
            this.getInfoCommandsButton.Location = new System.Drawing.Point(127, 424);
            this.getInfoCommandsButton.Name = "getInfoCommandsButton";
            this.getInfoCommandsButton.Size = new System.Drawing.Size(119, 39);
            this.getInfoCommandsButton.TabIndex = 16;
            this.getInfoCommandsButton.Text = "Просмотр состояния";
            this.getInfoCommandsButton.UseVisualStyleBackColor = true;
            this.getInfoCommandsButton.Click += new System.EventHandler(this.useCommandsButton_Click);
            // 
            // Remote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(499, 469);
            this.Controls.Add(this.getInfoCommandsButton);
            this.Controls.Add(this.ClearLogButton);
            this.Controls.Add(this.TurnOffButton);
            this.Controls.Add(this.DoorCloseButton);
            this.Controls.Add(this.LightOffButton);
            this.Controls.Add(this.FanOffButton);
            this.Controls.Add(this.HeaterOffButton);
            this.Controls.Add(this.DoorOpenButton);
            this.Controls.Add(this.MainScreen);
            this.Controls.Add(this.HeaterOnButton);
            this.Controls.Add(this.LightOnButton);
            this.Controls.Add(this.FanOnButton);
            this.Controls.Add(this.TurnOnButton);
            this.Controls.Add(this.UndoButton);
            this.Name = "Remote";
            this.Text = "Пульт гаража";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button TurnOnButton;
        private System.Windows.Forms.Button FanOnButton;
        private System.Windows.Forms.Button LightOnButton;
        private System.Windows.Forms.Button HeaterOnButton;
        private System.Windows.Forms.TextBox MainScreen;
        private System.Windows.Forms.Button DoorOpenButton;
        private System.Windows.Forms.Button HeaterOffButton;
        private System.Windows.Forms.Button FanOffButton;
        private System.Windows.Forms.Button LightOffButton;
        private System.Windows.Forms.Button DoorCloseButton;
        private System.Windows.Forms.Button TurnOffButton;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.Button getInfoCommandsButton;
    }
}

