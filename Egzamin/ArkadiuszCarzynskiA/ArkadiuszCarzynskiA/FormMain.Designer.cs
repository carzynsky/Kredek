namespace ArkadiuszCarzynskiA
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonnSignin = new System.Windows.Forms.Button();
            this.labelSignStatus = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerButtonPosition = new System.Windows.Forms.Timer(this.components);
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(367, 142);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(134, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(367, 194);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(134, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(287, 147);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 17);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(287, 199);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Hasło:";
            // 
            // buttonnSignin
            // 
            this.buttonnSignin.Location = new System.Drawing.Point(341, 242);
            this.buttonnSignin.Name = "buttonnSignin";
            this.buttonnSignin.Size = new System.Drawing.Size(122, 32);
            this.buttonnSignin.TabIndex = 4;
            this.buttonnSignin.Text = "A1 Zaloguj";
            this.buttonnSignin.UseVisualStyleBackColor = true;
            this.buttonnSignin.Click += new System.EventHandler(this.buttonnSignin_Click);
            // 
            // labelSignStatus
            // 
            this.labelSignStatus.AutoSize = true;
            this.labelSignStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSignStatus.Location = new System.Drawing.Point(256, 85);
            this.labelSignStatus.Name = "labelSignStatus";
            this.labelSignStatus.Size = new System.Drawing.Size(259, 29);
            this.labelSignStatus.TabIndex = 5;
            this.labelSignStatus.Text = "Zaloguj się do systemu";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(341, 280);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(122, 32);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "A2 Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerButtonPosition
            // 
            this.timerButtonPosition.Interval = 3000;
            this.timerButtonPosition.Tick += new System.EventHandler(this.timerButtonPosition_Tick);
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.Location = new System.Drawing.Point(341, 318);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(122, 32);
            this.buttonWorkers.TabIndex = 7;
            this.buttonWorkers.Text = "A3 Pracownicy";
            this.buttonWorkers.UseVisualStyleBackColor = true;
            this.buttonWorkers.Click += new System.EventHandler(this.buttonWorkers_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(341, 356);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(122, 32);
            this.buttonProducts.TabIndex = 8;
            this.buttonProducts.Text = "A5 Produkty";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonWorkers);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelSignStatus);
            this.Controls.Add(this.buttonnSignin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonnSignin;
        private System.Windows.Forms.Label labelSignStatus;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerButtonPosition;
        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Button buttonProducts;
    }
}

