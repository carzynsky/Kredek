namespace ArkadiuszCarzynskiLab1
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonColour = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonTextChange = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBoxCount2 = new System.Windows.Forms.TextBox();
            this.labelDivide = new System.Windows.Forms.Label();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.buttonStartTimer = new System.Windows.Forms.Button();
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonColour
            // 
            this.buttonColour.AutoSize = true;
            this.buttonColour.Location = new System.Drawing.Point(56, 293);
            this.buttonColour.Name = "buttonColour";
            this.buttonColour.Size = new System.Drawing.Size(118, 38);
            this.buttonColour.TabIndex = 1;
            this.buttonColour.Text = "Kolor";
            this.buttonColour.UseVisualStyleBackColor = true;
            this.buttonColour.Click += new System.EventHandler(this.Button1_Colour);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Gill Sans MT", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelName.Location = new System.Drawing.Point(160, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(486, 67);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Arkadiusz Carzyński";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResize
            // 
            this.buttonResize.Location = new System.Drawing.Point(56, 176);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(118, 42);
            this.buttonResize.TabIndex = 3;
            this.buttonResize.Text = "Rozmiar";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // buttonTextChange
            // 
            this.buttonTextChange.Location = new System.Drawing.Point(56, 233);
            this.buttonTextChange.Name = "buttonTextChange";
            this.buttonTextChange.Size = new System.Drawing.Size(118, 42);
            this.buttonTextChange.TabIndex = 4;
            this.buttonTextChange.Text = "Zmiana Tekstu";
            this.buttonTextChange.UseVisualStyleBackColor = true;
            this.buttonTextChange.Click += new System.EventHandler(this.ButtonTextChange_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(260, 176);
            this.textBoxCount.Multiline = true;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCount.Size = new System.Drawing.Size(81, 65);
            this.textBoxCount.TabIndex = 5;
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(328, 267);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(108, 42);
            this.buttonCount.TabIndex = 6;
            this.buttonCount.Text = "Policz";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxCount2
            // 
            this.textBoxCount2.Location = new System.Drawing.Point(424, 176);
            this.textBoxCount2.Multiline = true;
            this.textBoxCount2.Name = "textBoxCount2";
            this.textBoxCount2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCount2.Size = new System.Drawing.Size(81, 65);
            this.textBoxCount2.TabIndex = 7;
            // 
            // labelDivide
            // 
            this.labelDivide.AutoSize = true;
            this.labelDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDivide.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDivide.Location = new System.Drawing.Point(370, 186);
            this.labelDivide.Name = "labelDivide";
            this.labelDivide.Size = new System.Drawing.Size(34, 51);
            this.labelDivide.TabIndex = 8;
            this.labelDivide.Text = "/";
            // 
            // timerCount
            // 
            this.timerCount.Tick += new System.EventHandler(this.TimerCount_Tick);
            // 
            // buttonStartTimer
            // 
            this.buttonStartTimer.Location = new System.Drawing.Point(328, 395);
            this.buttonStartTimer.Name = "buttonStartTimer";
            this.buttonStartTimer.Size = new System.Drawing.Size(108, 38);
            this.buttonStartTimer.TabIndex = 9;
            this.buttonStartTimer.Text = "Start";
            this.buttonStartTimer.UseVisualStyleBackColor = true;
            this.buttonStartTimer.Click += new System.EventHandler(this.buttonStartTimer_Click);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(328, 332);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(108, 46);
            this.buttonNewWindow.TabIndex = 10;
            this.buttonNewWindow.Text = "Nowe okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(790, 463);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.buttonStartTimer);
            this.Controls.Add(this.labelDivide);
            this.Controls.Add(this.textBoxCount2);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonTextChange);
            this.Controls.Add(this.buttonResize);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonColour);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonColour;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonTextChange;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxCount2;
        private System.Windows.Forms.Label labelDivide;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Button buttonStartTimer;
        private System.Windows.Forms.Button buttonNewWindow;
    }
}

