namespace ArkadiuszCarzynskiLab2
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
            this.labelMyName = new System.Windows.Forms.Label();
            this.groupBoxNewVehicle = new System.Windows.Forms.GroupBox();
            this.radioButtonTram = new System.Windows.Forms.RadioButton();
            this.radioButtonBus = new System.Windows.Forms.RadioButton();
            this.labelVehicleNumber = new System.Windows.Forms.Label();
            this.labelYearOfProduction = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxVehicleNumber = new System.Windows.Forms.TextBox();
            this.textBoxYearOfProduction = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.labelActualVehicle = new System.Windows.Forms.Label();
            this.labelActualNumberOfVehicle = new System.Windows.Forms.Label();
            this.labelActtualYearOfProduction = new System.Windows.Forms.Label();
            this.labelActualModel = new System.Windows.Forms.Label();
            this.labelActualVehicleDescription = new System.Windows.Forms.Label();
            this.labelActualNumberDescription = new System.Windows.Forms.Label();
            this.labelActualYearOfProductionDescription = new System.Windows.Forms.Label();
            this.labelActualModelDescription = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonStartVehicle = new System.Windows.Forms.Button();
            this.buttonRingBell = new System.Windows.Forms.Button();
            this.buttonPantographDown = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonStopVehicle = new System.Windows.Forms.Button();
            this.buttonRefuel = new System.Windows.Forms.Button();
            this.buttonPantographUp = new System.Windows.Forms.Button();
            this.groupBoxNewVehicle.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMyName
            // 
            this.labelMyName.AutoSize = true;
            this.labelMyName.BackColor = System.Drawing.Color.Transparent;
            this.labelMyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyName.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelMyName.Location = new System.Drawing.Point(276, 28);
            this.labelMyName.Name = "labelMyName";
            this.labelMyName.Size = new System.Drawing.Size(226, 29);
            this.labelMyName.TabIndex = 0;
            this.labelMyName.Text = "Arkadiusz Carzyński";
            // 
            // groupBoxNewVehicle
            // 
            this.groupBoxNewVehicle.BackColor = System.Drawing.Color.GreenYellow;
            this.groupBoxNewVehicle.Controls.Add(this.buttonAddVehicle);
            this.groupBoxNewVehicle.Controls.Add(this.textBoxName);
            this.groupBoxNewVehicle.Controls.Add(this.textBoxYearOfProduction);
            this.groupBoxNewVehicle.Controls.Add(this.textBoxVehicleNumber);
            this.groupBoxNewVehicle.Controls.Add(this.labelName);
            this.groupBoxNewVehicle.Controls.Add(this.labelYearOfProduction);
            this.groupBoxNewVehicle.Controls.Add(this.labelVehicleNumber);
            this.groupBoxNewVehicle.Controls.Add(this.radioButtonBus);
            this.groupBoxNewVehicle.Controls.Add(this.radioButtonTram);
            this.groupBoxNewVehicle.Location = new System.Drawing.Point(39, 90);
            this.groupBoxNewVehicle.Name = "groupBoxNewVehicle";
            this.groupBoxNewVehicle.Size = new System.Drawing.Size(308, 366);
            this.groupBoxNewVehicle.TabIndex = 1;
            this.groupBoxNewVehicle.TabStop = false;
            this.groupBoxNewVehicle.Text = "Utwórz nowy pojazd";
            // 
            // radioButtonTram
            // 
            this.radioButtonTram.AutoSize = true;
            this.radioButtonTram.Checked = true;
            this.radioButtonTram.Location = new System.Drawing.Point(19, 54);
            this.radioButtonTram.Name = "radioButtonTram";
            this.radioButtonTram.Size = new System.Drawing.Size(82, 21);
            this.radioButtonTram.TabIndex = 0;
            this.radioButtonTram.TabStop = true;
            this.radioButtonTram.Text = "Tramwaj";
            this.radioButtonTram.UseVisualStyleBackColor = true;
            // 
            // radioButtonBus
            // 
            this.radioButtonBus.AutoSize = true;
            this.radioButtonBus.Location = new System.Drawing.Point(140, 54);
            this.radioButtonBus.Name = "radioButtonBus";
            this.radioButtonBus.Size = new System.Drawing.Size(81, 21);
            this.radioButtonBus.TabIndex = 1;
            this.radioButtonBus.Text = "Autobus";
            this.radioButtonBus.UseVisualStyleBackColor = true;
            // 
            // labelVehicleNumber
            // 
            this.labelVehicleNumber.AutoSize = true;
            this.labelVehicleNumber.Location = new System.Drawing.Point(11, 118);
            this.labelVehicleNumber.Name = "labelVehicleNumber";
            this.labelVehicleNumber.Size = new System.Drawing.Size(85, 17);
            this.labelVehicleNumber.TabIndex = 2;
            this.labelVehicleNumber.Text = "Nr. pojazdu:";
            // 
            // labelYearOfProduction
            // 
            this.labelYearOfProduction.AutoSize = true;
            this.labelYearOfProduction.Location = new System.Drawing.Point(11, 185);
            this.labelYearOfProduction.Name = "labelYearOfProduction";
            this.labelYearOfProduction.Size = new System.Drawing.Size(98, 17);
            this.labelYearOfProduction.TabIndex = 3;
            this.labelYearOfProduction.Text = "Rok produkcji:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 250);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 17);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nazwa pojazdu";
            // 
            // textBoxVehicleNumber
            // 
            this.textBoxVehicleNumber.Location = new System.Drawing.Point(121, 115);
            this.textBoxVehicleNumber.Name = "textBoxVehicleNumber";
            this.textBoxVehicleNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxVehicleNumber.TabIndex = 5;
            // 
            // textBoxYearOfProduction
            // 
            this.textBoxYearOfProduction.Location = new System.Drawing.Point(121, 185);
            this.textBoxYearOfProduction.Name = "textBoxYearOfProduction";
            this.textBoxYearOfProduction.Size = new System.Drawing.Size(100, 22);
            this.textBoxYearOfProduction.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(121, 250);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.AutoSize = true;
            this.buttonAddVehicle.Location = new System.Drawing.Point(84, 300);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(137, 41);
            this.buttonAddVehicle.TabIndex = 8;
            this.buttonAddVehicle.Text = "Dodaj nowy pojazd";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // groupBoxList
            // 
            this.groupBoxList.BackColor = System.Drawing.Color.IndianRed;
            this.groupBoxList.Controls.Add(this.buttonPantographUp);
            this.groupBoxList.Controls.Add(this.buttonRefuel);
            this.groupBoxList.Controls.Add(this.buttonStopVehicle);
            this.groupBoxList.Controls.Add(this.buttonNext);
            this.groupBoxList.Controls.Add(this.buttonPantographDown);
            this.groupBoxList.Controls.Add(this.buttonRingBell);
            this.groupBoxList.Controls.Add(this.buttonStartVehicle);
            this.groupBoxList.Controls.Add(this.buttonPrevious);
            this.groupBoxList.Controls.Add(this.labelActualModelDescription);
            this.groupBoxList.Controls.Add(this.labelActualYearOfProductionDescription);
            this.groupBoxList.Controls.Add(this.labelActualNumberDescription);
            this.groupBoxList.Controls.Add(this.labelActualVehicleDescription);
            this.groupBoxList.Controls.Add(this.labelActualModel);
            this.groupBoxList.Controls.Add(this.labelActtualYearOfProduction);
            this.groupBoxList.Controls.Add(this.labelActualNumberOfVehicle);
            this.groupBoxList.Controls.Add(this.labelActualVehicle);
            this.groupBoxList.Location = new System.Drawing.Point(432, 90);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(308, 366);
            this.groupBoxList.TabIndex = 2;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Lista pojazdów";
            // 
            // labelActualVehicle
            // 
            this.labelActualVehicle.AutoSize = true;
            this.labelActualVehicle.Location = new System.Drawing.Point(6, 41);
            this.labelActualVehicle.Name = "labelActualVehicle";
            this.labelActualVehicle.Size = new System.Drawing.Size(108, 17);
            this.labelActualVehicle.TabIndex = 0;
            this.labelActualVehicle.Text = "Aktualny pojazd";
            // 
            // labelActualNumberOfVehicle
            // 
            this.labelActualNumberOfVehicle.AutoSize = true;
            this.labelActualNumberOfVehicle.Location = new System.Drawing.Point(6, 86);
            this.labelActualNumberOfVehicle.Name = "labelActualNumberOfVehicle";
            this.labelActualNumberOfVehicle.Size = new System.Drawing.Size(85, 17);
            this.labelActualNumberOfVehicle.TabIndex = 1;
            this.labelActualNumberOfVehicle.Text = "Nr. pojazdu:";
            // 
            // labelActtualYearOfProduction
            // 
            this.labelActtualYearOfProduction.AutoSize = true;
            this.labelActtualYearOfProduction.Location = new System.Drawing.Point(6, 131);
            this.labelActtualYearOfProduction.Name = "labelActtualYearOfProduction";
            this.labelActtualYearOfProduction.Size = new System.Drawing.Size(98, 17);
            this.labelActtualYearOfProduction.TabIndex = 2;
            this.labelActtualYearOfProduction.Text = "Rok produkcji:";
            // 
            // labelActualModel
            // 
            this.labelActualModel.AutoSize = true;
            this.labelActualModel.Location = new System.Drawing.Point(6, 176);
            this.labelActualModel.Name = "labelActualModel";
            this.labelActualModel.Size = new System.Drawing.Size(108, 17);
            this.labelActualModel.TabIndex = 3;
            this.labelActualModel.Text = "Nazwa pojazdu:";
            // 
            // labelActualVehicleDescription
            // 
            this.labelActualVehicleDescription.AutoSize = true;
            this.labelActualVehicleDescription.Location = new System.Drawing.Point(186, 41);
            this.labelActualVehicleDescription.Name = "labelActualVehicleDescription";
            this.labelActualVehicleDescription.Size = new System.Drawing.Size(16, 17);
            this.labelActualVehicleDescription.TabIndex = 4;
            this.labelActualVehicleDescription.Text = "#";
            // 
            // labelActualNumberDescription
            // 
            this.labelActualNumberDescription.AutoSize = true;
            this.labelActualNumberDescription.Location = new System.Drawing.Point(186, 86);
            this.labelActualNumberDescription.Name = "labelActualNumberDescription";
            this.labelActualNumberDescription.Size = new System.Drawing.Size(16, 17);
            this.labelActualNumberDescription.TabIndex = 5;
            this.labelActualNumberDescription.Text = "#";
            // 
            // labelActualYearOfProductionDescription
            // 
            this.labelActualYearOfProductionDescription.AutoSize = true;
            this.labelActualYearOfProductionDescription.Location = new System.Drawing.Point(186, 131);
            this.labelActualYearOfProductionDescription.Name = "labelActualYearOfProductionDescription";
            this.labelActualYearOfProductionDescription.Size = new System.Drawing.Size(16, 17);
            this.labelActualYearOfProductionDescription.TabIndex = 6;
            this.labelActualYearOfProductionDescription.Text = "#";
            // 
            // labelActualModelDescription
            // 
            this.labelActualModelDescription.AutoSize = true;
            this.labelActualModelDescription.Location = new System.Drawing.Point(186, 176);
            this.labelActualModelDescription.Name = "labelActualModelDescription";
            this.labelActualModelDescription.Size = new System.Drawing.Size(16, 17);
            this.labelActualModelDescription.TabIndex = 7;
            this.labelActualModelDescription.Text = "#";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.AutoSize = true;
            this.buttonPrevious.Location = new System.Drawing.Point(6, 205);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(136, 40);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "Poprzedni element";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonStartVehicle
            // 
            this.buttonStartVehicle.AutoSize = true;
            this.buttonStartVehicle.Location = new System.Drawing.Point(7, 248);
            this.buttonStartVehicle.Name = "buttonStartVehicle";
            this.buttonStartVehicle.Size = new System.Drawing.Size(136, 37);
            this.buttonStartVehicle.TabIndex = 9;
            this.buttonStartVehicle.Text = "Rusz pojazdem";
            this.buttonStartVehicle.UseVisualStyleBackColor = true;
            this.buttonStartVehicle.Click += new System.EventHandler(this.buttonStartVehicle_Click);
            // 
            // buttonRingBell
            // 
            this.buttonRingBell.AutoSize = true;
            this.buttonRingBell.Location = new System.Drawing.Point(8, 290);
            this.buttonRingBell.Name = "buttonRingBell";
            this.buttonRingBell.Size = new System.Drawing.Size(148, 30);
            this.buttonRingBell.TabIndex = 10;
            this.buttonRingBell.Text = "Zadzwoń dzwonkiem";
            this.buttonRingBell.UseVisualStyleBackColor = true;
            this.buttonRingBell.Click += new System.EventHandler(this.buttonRingBell_Click);
            // 
            // buttonPantographDown
            // 
            this.buttonPantographDown.AutoSize = true;
            this.buttonPantographDown.Location = new System.Drawing.Point(9, 326);
            this.buttonPantographDown.Name = "buttonPantographDown";
            this.buttonPantographDown.Size = new System.Drawing.Size(136, 27);
            this.buttonPantographDown.TabIndex = 11;
            this.buttonPantographDown.Text = "Opuść pantograf";
            this.buttonPantographDown.UseVisualStyleBackColor = true;
            this.buttonPantographDown.Click += new System.EventHandler(this.buttonPantographDown_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.AutoSize = true;
            this.buttonNext.Location = new System.Drawing.Point(165, 206);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(132, 40);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Następny element";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonStopVehicle
            // 
            this.buttonStopVehicle.AutoSize = true;
            this.buttonStopVehicle.Location = new System.Drawing.Point(165, 250);
            this.buttonStopVehicle.Name = "buttonStopVehicle";
            this.buttonStopVehicle.Size = new System.Drawing.Size(132, 34);
            this.buttonStopVehicle.TabIndex = 13;
            this.buttonStopVehicle.Text = "Zatrzymaj pojazd";
            this.buttonStopVehicle.UseVisualStyleBackColor = true;
            this.buttonStopVehicle.Click += new System.EventHandler(this.buttonStopVehicle_Click);
            // 
            // buttonRefuel
            // 
            this.buttonRefuel.AutoSize = true;
            this.buttonRefuel.Location = new System.Drawing.Point(165, 290);
            this.buttonRefuel.Name = "buttonRefuel";
            this.buttonRefuel.Size = new System.Drawing.Size(132, 27);
            this.buttonRefuel.TabIndex = 14;
            this.buttonRefuel.Text = "Zatankuj";
            this.buttonRefuel.UseVisualStyleBackColor = true;
            this.buttonRefuel.Click += new System.EventHandler(this.buttonRefuel_Click);
            // 
            // buttonPantographUp
            // 
            this.buttonPantographUp.AutoSize = true;
            this.buttonPantographUp.Location = new System.Drawing.Point(165, 326);
            this.buttonPantographUp.Name = "buttonPantographUp";
            this.buttonPantographUp.Size = new System.Drawing.Size(134, 27);
            this.buttonPantographUp.TabIndex = 15;
            this.buttonPantographUp.Text = "Podnieś pantograf";
            this.buttonPantographUp.UseVisualStyleBackColor = true;
            this.buttonPantographUp.Click += new System.EventHandler(this.buttonPantographUp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxNewVehicle);
            this.Controls.Add(this.labelMyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.groupBoxNewVehicle.ResumeLayout(false);
            this.groupBoxNewVehicle.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMyName;
        private System.Windows.Forms.GroupBox groupBoxNewVehicle;
        private System.Windows.Forms.RadioButton radioButtonTram;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxYearOfProduction;
        private System.Windows.Forms.TextBox textBoxVehicleNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYearOfProduction;
        private System.Windows.Forms.Label labelVehicleNumber;
        private System.Windows.Forms.RadioButton radioButtonBus;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Label labelActualModelDescription;
        private System.Windows.Forms.Label labelActualYearOfProductionDescription;
        private System.Windows.Forms.Label labelActualNumberDescription;
        private System.Windows.Forms.Label labelActualVehicleDescription;
        private System.Windows.Forms.Label labelActualModel;
        private System.Windows.Forms.Label labelActtualYearOfProduction;
        private System.Windows.Forms.Label labelActualNumberOfVehicle;
        private System.Windows.Forms.Label labelActualVehicle;
        private System.Windows.Forms.Button buttonPantographUp;
        private System.Windows.Forms.Button buttonRefuel;
        private System.Windows.Forms.Button buttonStopVehicle;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPantographDown;
        private System.Windows.Forms.Button buttonRingBell;
        private System.Windows.Forms.Button buttonStartVehicle;
        private System.Windows.Forms.Button buttonPrevious;
    }
}

