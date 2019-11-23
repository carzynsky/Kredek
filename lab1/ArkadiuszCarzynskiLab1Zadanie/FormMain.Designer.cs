namespace ArkadiuszCarzynskiLab1Zadanie
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
            this.timerTimeInGame = new System.Windows.Forms.Timer(this.components);
            this.timerPower = new System.Windows.Forms.Timer(this.components);
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.timerFood = new System.Windows.Forms.Timer(this.components);
            this.timerWater = new System.Windows.Forms.Timer(this.components);
            this.timerScience = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCoins = new System.Windows.Forms.PictureBox();
            this.pictureBoxKitchen = new System.Windows.Forms.PictureBox();
            this.pictureBoxPowerGenerator = new System.Windows.Forms.PictureBox();
            this.gradient1 = new ArkadiuszCarzynskiLab1Zadanie.Gradient();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxInfo2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoins2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxScience2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWater2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFood2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPower2 = new System.Windows.Forms.PictureBox();
            this.buttonScienceRoom = new System.Windows.Forms.Button();
            this.buttonWaterTreatment = new System.Windows.Forms.Button();
            this.buttonKitchen = new System.Windows.Forms.Button();
            this.buttonPowerGeneratorUpgrade = new System.Windows.Forms.Button();
            this.buttonScienceRoomAddWorker = new System.Windows.Forms.Button();
            this.buttonScienceRoomUpgrade = new System.Windows.Forms.Button();
            this.buttonWaterTreatmentUpgrade = new System.Windows.Forms.Button();
            this.buttonWaterTreatmentAddWorker = new System.Windows.Forms.Button();
            this.buttonKitchenAddWorker = new System.Windows.Forms.Button();
            this.buttonKitchenUpgrade = new System.Windows.Forms.Button();
            this.labelScienceRoomPace = new System.Windows.Forms.Label();
            this.labelScienceRoomWorkers = new System.Windows.Forms.Label();
            this.labelScienceRoomLevel = new System.Windows.Forms.Label();
            this.labelWaterTreatmentPace = new System.Windows.Forms.Label();
            this.labelWaterTreatmentWorkers = new System.Windows.Forms.Label();
            this.labelWaterTreatmentLevel = new System.Windows.Forms.Label();
            this.labelKitchenPace = new System.Windows.Forms.Label();
            this.labelKitchenWorkers = new System.Windows.Forms.Label();
            this.labelKitchenLevel = new System.Windows.Forms.Label();
            this.labelPowerGeneratorWorkers = new System.Windows.Forms.Label();
            this.buttonPowerGeneratorAddWorker = new System.Windows.Forms.Button();
            this.labelPowerGeneratorPace = new System.Windows.Forms.Label();
            this.labelPowerGeneratorLevel = new System.Windows.Forms.Label();
            this.labelCoins = new System.Windows.Forms.Label();
            this.labelScienceRoom = new System.Windows.Forms.Label();
            this.labelWaterTreatment = new System.Windows.Forms.Label();
            this.labelKitchen = new System.Windows.Forms.Label();
            this.labelPowerGenerator = new System.Windows.Forms.Label();
            this.progressBarScience = new System.Windows.Forms.ProgressBar();
            this.progressBarWater = new System.Windows.Forms.ProgressBar();
            this.progressBarFood = new System.Windows.Forms.ProgressBar();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.progressBarPower = new System.Windows.Forms.ProgressBar();
            this.pictureBoxPowerGenerator2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxScienceRoom2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWaterTreatment2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxKitchen2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPowerGenerator)).BeginInit();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoins2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScience2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWater2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPower2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPowerGenerator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScienceRoom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaterTreatment2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitchen2)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTimeInGame
            // 
            this.timerTimeInGame.Interval = 1000;
            this.timerTimeInGame.Tick += new System.EventHandler(this.timerTimeInGame_Tick);
            // 
            // timerPower
            // 
            this.timerPower.Interval = 1000;
            this.timerPower.Tick += new System.EventHandler(this.timerPower_Tick);
            // 
            // timerMain
            // 
            this.timerMain.Interval = 5;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // timerFood
            // 
            this.timerFood.Tick += new System.EventHandler(this.timerFood_Tick);
            // 
            // timerWater
            // 
            this.timerWater.Tick += new System.EventHandler(this.timerWater_Tick);
            // 
            // timerScience
            // 
            this.timerScience.Tick += new System.EventHandler(this.timerScience_Tick);
            // 
            // pictureBoxCoins
            // 
            this.pictureBoxCoins.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoins.BackgroundImage = global::ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.coins;
            this.pictureBoxCoins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCoins.Location = new System.Drawing.Point(204, 502);
            this.pictureBoxCoins.Name = "pictureBoxCoins";
            this.pictureBoxCoins.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCoins.TabIndex = 26;
            this.pictureBoxCoins.TabStop = false;
            // 
            // pictureBoxKitchen
            // 
            this.pictureBoxKitchen.BackColor = System.Drawing.Color.Plum;
            this.pictureBoxKitchen.Location = new System.Drawing.Point(439, 207);
            this.pictureBoxKitchen.Name = "pictureBoxKitchen";
            this.pictureBoxKitchen.Size = new System.Drawing.Size(282, 103);
            this.pictureBoxKitchen.TabIndex = 9;
            this.pictureBoxKitchen.TabStop = false;
            // 
            // pictureBoxPowerGenerator
            // 
            this.pictureBoxPowerGenerator.BackColor = System.Drawing.Color.Khaki;
            this.pictureBoxPowerGenerator.Location = new System.Drawing.Point(98, 207);
            this.pictureBoxPowerGenerator.Name = "pictureBoxPowerGenerator";
            this.pictureBoxPowerGenerator.Size = new System.Drawing.Size(282, 103);
            this.pictureBoxPowerGenerator.TabIndex = 8;
            this.pictureBoxPowerGenerator.TabStop = false;
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.Black;
            this.gradient1.ColorTop = System.Drawing.Color.Black;
            this.gradient1.Controls.Add(this.labelUserName);
            this.gradient1.Controls.Add(this.pictureBoxInfo2);
            this.gradient1.Controls.Add(this.pictureBoxExit2);
            this.gradient1.Controls.Add(this.pictureBoxCoins2);
            this.gradient1.Controls.Add(this.pictureBoxScience2);
            this.gradient1.Controls.Add(this.pictureBoxWater2);
            this.gradient1.Controls.Add(this.pictureBoxFood2);
            this.gradient1.Controls.Add(this.pictureBoxPower2);
            this.gradient1.Controls.Add(this.buttonScienceRoom);
            this.gradient1.Controls.Add(this.buttonWaterTreatment);
            this.gradient1.Controls.Add(this.buttonKitchen);
            this.gradient1.Controls.Add(this.buttonPowerGeneratorUpgrade);
            this.gradient1.Controls.Add(this.buttonScienceRoomAddWorker);
            this.gradient1.Controls.Add(this.buttonScienceRoomUpgrade);
            this.gradient1.Controls.Add(this.buttonWaterTreatmentUpgrade);
            this.gradient1.Controls.Add(this.buttonWaterTreatmentAddWorker);
            this.gradient1.Controls.Add(this.buttonKitchenAddWorker);
            this.gradient1.Controls.Add(this.buttonKitchenUpgrade);
            this.gradient1.Controls.Add(this.labelScienceRoomPace);
            this.gradient1.Controls.Add(this.labelScienceRoomWorkers);
            this.gradient1.Controls.Add(this.labelScienceRoomLevel);
            this.gradient1.Controls.Add(this.labelWaterTreatmentPace);
            this.gradient1.Controls.Add(this.labelWaterTreatmentWorkers);
            this.gradient1.Controls.Add(this.labelWaterTreatmentLevel);
            this.gradient1.Controls.Add(this.labelKitchenPace);
            this.gradient1.Controls.Add(this.labelKitchenWorkers);
            this.gradient1.Controls.Add(this.labelKitchenLevel);
            this.gradient1.Controls.Add(this.labelPowerGeneratorWorkers);
            this.gradient1.Controls.Add(this.buttonPowerGeneratorAddWorker);
            this.gradient1.Controls.Add(this.labelPowerGeneratorPace);
            this.gradient1.Controls.Add(this.labelPowerGeneratorLevel);
            this.gradient1.Controls.Add(this.labelCoins);
            this.gradient1.Controls.Add(this.labelScienceRoom);
            this.gradient1.Controls.Add(this.labelWaterTreatment);
            this.gradient1.Controls.Add(this.labelKitchen);
            this.gradient1.Controls.Add(this.labelPowerGenerator);
            this.gradient1.Controls.Add(this.progressBarScience);
            this.gradient1.Controls.Add(this.progressBarWater);
            this.gradient1.Controls.Add(this.progressBarFood);
            this.gradient1.Controls.Add(this.labelMinute);
            this.gradient1.Controls.Add(this.labelHour);
            this.gradient1.Controls.Add(this.labelDay);
            this.gradient1.Controls.Add(this.progressBarPower);
            this.gradient1.Controls.Add(this.pictureBoxPowerGenerator2);
            this.gradient1.Controls.Add(this.pictureBoxScienceRoom2);
            this.gradient1.Controls.Add(this.pictureBoxWaterTreatment2);
            this.gradient1.Controls.Add(this.pictureBoxKitchen2);
            this.gradient1.Location = new System.Drawing.Point(-19, -4);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(816, 560);
            this.gradient1.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserName.ForeColor = System.Drawing.Color.Salmon;
            this.labelUserName.Location = new System.Drawing.Point(32, 480);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(40, 20);
            this.labelUserName.TabIndex = 62;
            this.labelUserName.Text = "Imię";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // pictureBoxInfo2
            // 
            this.pictureBoxInfo2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfo2.BackgroundImage = global::ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.info;
            this.pictureBoxInfo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxInfo2.Location = new System.Drawing.Point(683, 500);
            this.pictureBoxInfo2.Name = "pictureBoxInfo2";
            this.pictureBoxInfo2.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxInfo2.TabIndex = 57;
            this.pictureBoxInfo2.TabStop = false;
            this.pictureBoxInfo2.Click += new System.EventHandler(this.pictureBoxInfo2_Click);
            // 
            // pictureBoxExit2
            // 
            this.pictureBoxExit2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit2.BackgroundImage = global::ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.exit;
            this.pictureBoxExit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExit2.Location = new System.Drawing.Point(739, 500);
            this.pictureBoxExit2.Name = "pictureBoxExit2";
            this.pictureBoxExit2.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxExit2.TabIndex = 56;
            this.pictureBoxExit2.TabStop = false;
            this.pictureBoxExit2.Click += new System.EventHandler(this.pictureBoxExit2_Click);
            // 
            // pictureBoxCoins2
            // 
            this.pictureBoxCoins2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoins2.BackgroundImage = global::ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.coins;
            this.pictureBoxCoins2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCoins2.Location = new System.Drawing.Point(384, 496);
            this.pictureBoxCoins2.Name = "pictureBoxCoins2";
            this.pictureBoxCoins2.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCoins2.TabIndex = 55;
            this.pictureBoxCoins2.TabStop = false;
            // 
            // pictureBoxScience2
            // 
            this.pictureBoxScience2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxScience2.BackgroundImage = global::ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.science;
            this.pictureBoxScience2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxScience2.Location = new System.Drawing.Point(582, 29);
            this.pictureBoxScience2.Name = "pictureBoxScience2";
            this.pictureBoxScience2.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxScience2.TabIndex = 54;
            this.pictureBoxScience2.TabStop = false;
            this.pictureBoxScience2.Click += new System.EventHandler(this.pictureBoxScience2_Click);
            // 
            // pictureBoxWater2
            // 
            this.pictureBoxWater2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWater2.BackgroundImage = global::ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.water;
            this.pictureBoxWater2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxWater2.Location = new System.Drawing.Point(444, 29);
            this.pictureBoxWater2.Name = "pictureBoxWater2";
            this.pictureBoxWater2.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxWater2.TabIndex = 53;
            this.pictureBoxWater2.TabStop = false;
            this.pictureBoxWater2.Click += new System.EventHandler(this.pictureBoxWater2_Click);
            // 
            // pictureBoxFood2
            // 
            this.pictureBoxFood2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFood2.BackgroundImage = global::ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.food;
            this.pictureBoxFood2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFood2.Location = new System.Drawing.Point(319, 29);
            this.pictureBoxFood2.Name = "pictureBoxFood2";
            this.pictureBoxFood2.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxFood2.TabIndex = 52;
            this.pictureBoxFood2.TabStop = false;
            this.pictureBoxFood2.Click += new System.EventHandler(this.pictureBoxFood2_Click);
            // 
            // pictureBoxPower2
            // 
            this.pictureBoxPower2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPower2.BackgroundImage = global::ArkadiuszCarzynskiLab1Zadanie.Properties.Resources.energy;
            this.pictureBoxPower2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPower2.Location = new System.Drawing.Point(161, 29);
            this.pictureBoxPower2.Name = "pictureBoxPower2";
            this.pictureBoxPower2.Size = new System.Drawing.Size(87, 60);
            this.pictureBoxPower2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPower2.TabIndex = 51;
            this.pictureBoxPower2.TabStop = false;
            this.pictureBoxPower2.Click += new System.EventHandler(this.pictureBoxPower2_Click);
            // 
            // buttonScienceRoom
            // 
            this.buttonScienceRoom.BackColor = System.Drawing.Color.Red;
            this.buttonScienceRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonScienceRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonScienceRoom.Location = new System.Drawing.Point(434, 333);
            this.buttonScienceRoom.Name = "buttonScienceRoom";
            this.buttonScienceRoom.Size = new System.Drawing.Size(283, 103);
            this.buttonScienceRoom.TabIndex = 30;
            this.buttonScienceRoom.Text = "Wybuduj (50000)";
            this.buttonScienceRoom.UseVisualStyleBackColor = false;
            this.buttonScienceRoom.Click += new System.EventHandler(this.buttonScienceRoom_Click);
            // 
            // buttonWaterTreatment
            // 
            this.buttonWaterTreatment.BackColor = System.Drawing.Color.Red;
            this.buttonWaterTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWaterTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWaterTreatment.Location = new System.Drawing.Point(98, 333);
            this.buttonWaterTreatment.Name = "buttonWaterTreatment";
            this.buttonWaterTreatment.Size = new System.Drawing.Size(283, 103);
            this.buttonWaterTreatment.TabIndex = 28;
            this.buttonWaterTreatment.Text = "Wybuduj (25000)";
            this.buttonWaterTreatment.UseVisualStyleBackColor = false;
            this.buttonWaterTreatment.Click += new System.EventHandler(this.buttonWaterTreatment_Click);
            // 
            // buttonKitchen
            // 
            this.buttonKitchen.BackColor = System.Drawing.Color.Red;
            this.buttonKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKitchen.Location = new System.Drawing.Point(434, 207);
            this.buttonKitchen.Name = "buttonKitchen";
            this.buttonKitchen.Size = new System.Drawing.Size(283, 103);
            this.buttonKitchen.TabIndex = 29;
            this.buttonKitchen.Text = "Wybuduj (10000)";
            this.buttonKitchen.UseVisualStyleBackColor = false;
            this.buttonKitchen.Click += new System.EventHandler(this.buttonKitchen_Click);
            // 
            // buttonPowerGeneratorUpgrade
            // 
            this.buttonPowerGeneratorUpgrade.BackColor = System.Drawing.Color.Black;
            this.buttonPowerGeneratorUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPowerGeneratorUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.2F);
            this.buttonPowerGeneratorUpgrade.ForeColor = System.Drawing.Color.Yellow;
            this.buttonPowerGeneratorUpgrade.Location = new System.Drawing.Point(103, 263);
            this.buttonPowerGeneratorUpgrade.Name = "buttonPowerGeneratorUpgrade";
            this.buttonPowerGeneratorUpgrade.Size = new System.Drawing.Size(134, 41);
            this.buttonPowerGeneratorUpgrade.TabIndex = 5;
            this.buttonPowerGeneratorUpgrade.Text = "Ulepsz (500)";
            this.buttonPowerGeneratorUpgrade.UseVisualStyleBackColor = false;
            this.buttonPowerGeneratorUpgrade.Click += new System.EventHandler(this.buttonPowerGeneratorUpgrade_Click);
            // 
            // buttonScienceRoomAddWorker
            // 
            this.buttonScienceRoomAddWorker.BackColor = System.Drawing.Color.Black;
            this.buttonScienceRoomAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonScienceRoomAddWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.2F);
            this.buttonScienceRoomAddWorker.ForeColor = System.Drawing.Color.Yellow;
            this.buttonScienceRoomAddWorker.Location = new System.Drawing.Point(579, 399);
            this.buttonScienceRoomAddWorker.Name = "buttonScienceRoomAddWorker";
            this.buttonScienceRoomAddWorker.Size = new System.Drawing.Size(134, 36);
            this.buttonScienceRoomAddWorker.TabIndex = 50;
            this.buttonScienceRoomAddWorker.Text = "Zatrudnij (2500)";
            this.buttonScienceRoomAddWorker.UseVisualStyleBackColor = false;
            this.buttonScienceRoomAddWorker.Click += new System.EventHandler(this.buttonScienceRoomAddWorker_Click);
            // 
            // buttonScienceRoomUpgrade
            // 
            this.buttonScienceRoomUpgrade.BackColor = System.Drawing.Color.Black;
            this.buttonScienceRoomUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonScienceRoomUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.2F);
            this.buttonScienceRoomUpgrade.ForeColor = System.Drawing.Color.Yellow;
            this.buttonScienceRoomUpgrade.Location = new System.Drawing.Point(438, 399);
            this.buttonScienceRoomUpgrade.Name = "buttonScienceRoomUpgrade";
            this.buttonScienceRoomUpgrade.Size = new System.Drawing.Size(134, 36);
            this.buttonScienceRoomUpgrade.TabIndex = 49;
            this.buttonScienceRoomUpgrade.Text = "Ulepsz (2000)";
            this.buttonScienceRoomUpgrade.UseVisualStyleBackColor = false;
            this.buttonScienceRoomUpgrade.Click += new System.EventHandler(this.buttonScienceRoomUpgrade_Click);
            // 
            // buttonWaterTreatmentUpgrade
            // 
            this.buttonWaterTreatmentUpgrade.BackColor = System.Drawing.Color.Black;
            this.buttonWaterTreatmentUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWaterTreatmentUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.2F);
            this.buttonWaterTreatmentUpgrade.ForeColor = System.Drawing.Color.Yellow;
            this.buttonWaterTreatmentUpgrade.Location = new System.Drawing.Point(103, 399);
            this.buttonWaterTreatmentUpgrade.Name = "buttonWaterTreatmentUpgrade";
            this.buttonWaterTreatmentUpgrade.Size = new System.Drawing.Size(134, 36);
            this.buttonWaterTreatmentUpgrade.TabIndex = 48;
            this.buttonWaterTreatmentUpgrade.Text = "Ulepsz (1500)";
            this.buttonWaterTreatmentUpgrade.UseVisualStyleBackColor = false;
            this.buttonWaterTreatmentUpgrade.Click += new System.EventHandler(this.buttonWaterTreatmentUpgrade_Click);
            // 
            // buttonWaterTreatmentAddWorker
            // 
            this.buttonWaterTreatmentAddWorker.BackColor = System.Drawing.Color.Black;
            this.buttonWaterTreatmentAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWaterTreatmentAddWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.2F);
            this.buttonWaterTreatmentAddWorker.ForeColor = System.Drawing.Color.Yellow;
            this.buttonWaterTreatmentAddWorker.Location = new System.Drawing.Point(242, 399);
            this.buttonWaterTreatmentAddWorker.Name = "buttonWaterTreatmentAddWorker";
            this.buttonWaterTreatmentAddWorker.Size = new System.Drawing.Size(134, 36);
            this.buttonWaterTreatmentAddWorker.TabIndex = 47;
            this.buttonWaterTreatmentAddWorker.Text = "Zatrudnij (1500)";
            this.buttonWaterTreatmentAddWorker.UseVisualStyleBackColor = false;
            this.buttonWaterTreatmentAddWorker.Click += new System.EventHandler(this.buttonWaterTreatmentAddWorker_Click);
            // 
            // buttonKitchenAddWorker
            // 
            this.buttonKitchenAddWorker.BackColor = System.Drawing.Color.Black;
            this.buttonKitchenAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKitchenAddWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.2F);
            this.buttonKitchenAddWorker.ForeColor = System.Drawing.Color.Yellow;
            this.buttonKitchenAddWorker.Location = new System.Drawing.Point(579, 270);
            this.buttonKitchenAddWorker.Name = "buttonKitchenAddWorker";
            this.buttonKitchenAddWorker.Size = new System.Drawing.Size(134, 36);
            this.buttonKitchenAddWorker.TabIndex = 46;
            this.buttonKitchenAddWorker.Text = "Zatrudnij (500)";
            this.buttonKitchenAddWorker.UseVisualStyleBackColor = false;
            this.buttonKitchenAddWorker.Click += new System.EventHandler(this.buttonKitchenAddWorker_Click);
            // 
            // buttonKitchenUpgrade
            // 
            this.buttonKitchenUpgrade.BackColor = System.Drawing.Color.Black;
            this.buttonKitchenUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKitchenUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.2F);
            this.buttonKitchenUpgrade.ForeColor = System.Drawing.Color.Yellow;
            this.buttonKitchenUpgrade.Location = new System.Drawing.Point(438, 271);
            this.buttonKitchenUpgrade.Name = "buttonKitchenUpgrade";
            this.buttonKitchenUpgrade.Size = new System.Drawing.Size(134, 36);
            this.buttonKitchenUpgrade.TabIndex = 45;
            this.buttonKitchenUpgrade.Text = "Ulepsz (1000)";
            this.buttonKitchenUpgrade.UseVisualStyleBackColor = false;
            this.buttonKitchenUpgrade.Click += new System.EventHandler(this.buttonKitchenUpgrade_Click);
            // 
            // labelScienceRoomPace
            // 
            this.labelScienceRoomPace.AutoSize = true;
            this.labelScienceRoomPace.BackColor = System.Drawing.Color.PapayaWhip;
            this.labelScienceRoomPace.Location = new System.Drawing.Point(442, 379);
            this.labelScienceRoomPace.Name = "labelScienceRoomPace";
            this.labelScienceRoomPace.Size = new System.Drawing.Size(99, 17);
            this.labelScienceRoomPace.TabIndex = 44;
            this.labelScienceRoomPace.Text = "Tempo pracy: ";
            // 
            // labelScienceRoomWorkers
            // 
            this.labelScienceRoomWorkers.AutoSize = true;
            this.labelScienceRoomWorkers.BackColor = System.Drawing.Color.PapayaWhip;
            this.labelScienceRoomWorkers.Location = new System.Drawing.Point(441, 359);
            this.labelScienceRoomWorkers.Name = "labelScienceRoomWorkers";
            this.labelScienceRoomWorkers.Size = new System.Drawing.Size(149, 17);
            this.labelScienceRoomWorkers.TabIndex = 43;
            this.labelScienceRoomWorkers.Text = "Liczba pracowników: 1";
            // 
            // labelScienceRoomLevel
            // 
            this.labelScienceRoomLevel.AutoSize = true;
            this.labelScienceRoomLevel.BackColor = System.Drawing.Color.PapayaWhip;
            this.labelScienceRoomLevel.Location = new System.Drawing.Point(552, 338);
            this.labelScienceRoomLevel.Name = "labelScienceRoomLevel";
            this.labelScienceRoomLevel.Size = new System.Drawing.Size(66, 17);
            this.labelScienceRoomLevel.TabIndex = 42;
            this.labelScienceRoomLevel.Text = "Poziom 1";
            // 
            // labelWaterTreatmentPace
            // 
            this.labelWaterTreatmentPace.AutoSize = true;
            this.labelWaterTreatmentPace.BackColor = System.Drawing.Color.Salmon;
            this.labelWaterTreatmentPace.Location = new System.Drawing.Point(99, 376);
            this.labelWaterTreatmentPace.Name = "labelWaterTreatmentPace";
            this.labelWaterTreatmentPace.Size = new System.Drawing.Size(99, 17);
            this.labelWaterTreatmentPace.TabIndex = 41;
            this.labelWaterTreatmentPace.Text = "Tempo pracy: ";
            // 
            // labelWaterTreatmentWorkers
            // 
            this.labelWaterTreatmentWorkers.AutoSize = true;
            this.labelWaterTreatmentWorkers.BackColor = System.Drawing.Color.Salmon;
            this.labelWaterTreatmentWorkers.Location = new System.Drawing.Point(99, 359);
            this.labelWaterTreatmentWorkers.Name = "labelWaterTreatmentWorkers";
            this.labelWaterTreatmentWorkers.Size = new System.Drawing.Size(149, 17);
            this.labelWaterTreatmentWorkers.TabIndex = 40;
            this.labelWaterTreatmentWorkers.Text = "Liczba pracowników: 1";
            // 
            // labelWaterTreatmentLevel
            // 
            this.labelWaterTreatmentLevel.AutoSize = true;
            this.labelWaterTreatmentLevel.BackColor = System.Drawing.Color.Salmon;
            this.labelWaterTreatmentLevel.Location = new System.Drawing.Point(201, 339);
            this.labelWaterTreatmentLevel.Name = "labelWaterTreatmentLevel";
            this.labelWaterTreatmentLevel.Size = new System.Drawing.Size(66, 17);
            this.labelWaterTreatmentLevel.TabIndex = 39;
            this.labelWaterTreatmentLevel.Text = "Poziom 1";
            // 
            // labelKitchenPace
            // 
            this.labelKitchenPace.AutoSize = true;
            this.labelKitchenPace.BackColor = System.Drawing.Color.Plum;
            this.labelKitchenPace.Location = new System.Drawing.Point(442, 247);
            this.labelKitchenPace.Name = "labelKitchenPace";
            this.labelKitchenPace.Size = new System.Drawing.Size(99, 17);
            this.labelKitchenPace.TabIndex = 37;
            this.labelKitchenPace.Text = "Tempo pracy: ";
            // 
            // labelKitchenWorkers
            // 
            this.labelKitchenWorkers.AutoSize = true;
            this.labelKitchenWorkers.BackColor = System.Drawing.Color.Plum;
            this.labelKitchenWorkers.Location = new System.Drawing.Point(442, 230);
            this.labelKitchenWorkers.Name = "labelKitchenWorkers";
            this.labelKitchenWorkers.Size = new System.Drawing.Size(149, 17);
            this.labelKitchenWorkers.TabIndex = 36;
            this.labelKitchenWorkers.Text = "Liczba pracowników: 1";
            // 
            // labelKitchenLevel
            // 
            this.labelKitchenLevel.AutoSize = true;
            this.labelKitchenLevel.BackColor = System.Drawing.Color.Plum;
            this.labelKitchenLevel.Location = new System.Drawing.Point(549, 211);
            this.labelKitchenLevel.Name = "labelKitchenLevel";
            this.labelKitchenLevel.Size = new System.Drawing.Size(66, 17);
            this.labelKitchenLevel.TabIndex = 35;
            this.labelKitchenLevel.Text = "Poziom 1";
            // 
            // labelPowerGeneratorWorkers
            // 
            this.labelPowerGeneratorWorkers.AutoSize = true;
            this.labelPowerGeneratorWorkers.BackColor = System.Drawing.Color.Khaki;
            this.labelPowerGeneratorWorkers.Location = new System.Drawing.Point(106, 226);
            this.labelPowerGeneratorWorkers.Name = "labelPowerGeneratorWorkers";
            this.labelPowerGeneratorWorkers.Size = new System.Drawing.Size(149, 17);
            this.labelPowerGeneratorWorkers.TabIndex = 34;
            this.labelPowerGeneratorWorkers.Text = "Liczba pracowników: 1";
            // 
            // buttonPowerGeneratorAddWorker
            // 
            this.buttonPowerGeneratorAddWorker.BackColor = System.Drawing.Color.Black;
            this.buttonPowerGeneratorAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPowerGeneratorAddWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.2F);
            this.buttonPowerGeneratorAddWorker.ForeColor = System.Drawing.Color.Yellow;
            this.buttonPowerGeneratorAddWorker.Location = new System.Drawing.Point(242, 263);
            this.buttonPowerGeneratorAddWorker.Name = "buttonPowerGeneratorAddWorker";
            this.buttonPowerGeneratorAddWorker.Size = new System.Drawing.Size(134, 41);
            this.buttonPowerGeneratorAddWorker.TabIndex = 33;
            this.buttonPowerGeneratorAddWorker.Text = "Zatrudnij (500)";
            this.buttonPowerGeneratorAddWorker.UseVisualStyleBackColor = false;
            this.buttonPowerGeneratorAddWorker.Click += new System.EventHandler(this.buttonPowerGeneratorAddWorker_Click);
            // 
            // labelPowerGeneratorPace
            // 
            this.labelPowerGeneratorPace.AutoSize = true;
            this.labelPowerGeneratorPace.BackColor = System.Drawing.Color.Khaki;
            this.labelPowerGeneratorPace.Location = new System.Drawing.Point(106, 243);
            this.labelPowerGeneratorPace.Name = "labelPowerGeneratorPace";
            this.labelPowerGeneratorPace.Size = new System.Drawing.Size(99, 17);
            this.labelPowerGeneratorPace.TabIndex = 32;
            this.labelPowerGeneratorPace.Text = "Tempo pracy: ";
            // 
            // labelPowerGeneratorLevel
            // 
            this.labelPowerGeneratorLevel.AutoSize = true;
            this.labelPowerGeneratorLevel.BackColor = System.Drawing.Color.Khaki;
            this.labelPowerGeneratorLevel.Location = new System.Drawing.Point(204, 207);
            this.labelPowerGeneratorLevel.Name = "labelPowerGeneratorLevel";
            this.labelPowerGeneratorLevel.Size = new System.Drawing.Size(66, 17);
            this.labelPowerGeneratorLevel.TabIndex = 31;
            this.labelPowerGeneratorLevel.Text = "Poziom 1";
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.Transparent;
            this.labelCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCoins.ForeColor = System.Drawing.Color.Gold;
            this.labelCoins.Location = new System.Drawing.Point(444, 516);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(32, 18);
            this.labelCoins.TabIndex = 27;
            this.labelCoins.Text = "100";
            // 
            // labelScienceRoom
            // 
            this.labelScienceRoom.AutoSize = true;
            this.labelScienceRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelScienceRoom.ForeColor = System.Drawing.Color.PapayaWhip;
            this.labelScienceRoom.Location = new System.Drawing.Point(524, 443);
            this.labelScienceRoom.Name = "labelScienceRoom";
            this.labelScienceRoom.Size = new System.Drawing.Size(119, 17);
            this.labelScienceRoom.TabIndex = 25;
            this.labelScienceRoom.Text = "Pokój naukowców";
            // 
            // labelWaterTreatment
            // 
            this.labelWaterTreatment.AutoSize = true;
            this.labelWaterTreatment.BackColor = System.Drawing.Color.Transparent;
            this.labelWaterTreatment.ForeColor = System.Drawing.Color.Salmon;
            this.labelWaterTreatment.Location = new System.Drawing.Point(196, 442);
            this.labelWaterTreatment.Name = "labelWaterTreatment";
            this.labelWaterTreatment.Size = new System.Drawing.Size(82, 17);
            this.labelWaterTreatment.TabIndex = 24;
            this.labelWaterTreatment.Text = "Hydrofornia";
            // 
            // labelKitchen
            // 
            this.labelKitchen.AutoSize = true;
            this.labelKitchen.BackColor = System.Drawing.Color.Transparent;
            this.labelKitchen.ForeColor = System.Drawing.Color.Plum;
            this.labelKitchen.Location = new System.Drawing.Point(549, 182);
            this.labelKitchen.Name = "labelKitchen";
            this.labelKitchen.Size = new System.Drawing.Size(59, 17);
            this.labelKitchen.TabIndex = 23;
            this.labelKitchen.Text = "Kuchnia";
            // 
            // labelPowerGenerator
            // 
            this.labelPowerGenerator.AutoSize = true;
            this.labelPowerGenerator.BackColor = System.Drawing.Color.Transparent;
            this.labelPowerGenerator.ForeColor = System.Drawing.Color.Khaki;
            this.labelPowerGenerator.Location = new System.Drawing.Point(198, 182);
            this.labelPowerGenerator.Name = "labelPowerGenerator";
            this.labelPowerGenerator.Size = new System.Drawing.Size(80, 17);
            this.labelPowerGenerator.TabIndex = 22;
            this.labelPowerGenerator.Text = "Elektrownia";
            // 
            // progressBarScience
            // 
            this.progressBarScience.Location = new System.Drawing.Point(571, 95);
            this.progressBarScience.Name = "progressBarScience";
            this.progressBarScience.Size = new System.Drawing.Size(89, 23);
            this.progressBarScience.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarScience.TabIndex = 13;
            // 
            // progressBarWater
            // 
            this.progressBarWater.Location = new System.Drawing.Point(432, 95);
            this.progressBarWater.Name = "progressBarWater";
            this.progressBarWater.Size = new System.Drawing.Size(89, 23);
            this.progressBarWater.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarWater.TabIndex = 12;
            // 
            // progressBarFood
            // 
            this.progressBarFood.Location = new System.Drawing.Point(301, 95);
            this.progressBarFood.Name = "progressBarFood";
            this.progressBarFood.Size = new System.Drawing.Size(89, 23);
            this.progressBarFood.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarFood.TabIndex = 11;
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.BackColor = System.Drawing.Color.Transparent;
            this.labelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMinute.ForeColor = System.Drawing.Color.Salmon;
            this.labelMinute.Location = new System.Drawing.Point(65, 525);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(27, 20);
            this.labelMinute.TabIndex = 4;
            this.labelMinute.Text = "00";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.BackColor = System.Drawing.Color.Transparent;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHour.ForeColor = System.Drawing.Color.Salmon;
            this.labelHour.Location = new System.Drawing.Point(32, 525);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(27, 20);
            this.labelHour.TabIndex = 3;
            this.labelHour.Text = "12";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BackColor = System.Drawing.Color.Transparent;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDay.ForeColor = System.Drawing.Color.Salmon;
            this.labelDay.Location = new System.Drawing.Point(31, 501);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(103, 20);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Poniedziałek";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBarPower
            // 
            this.progressBarPower.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarPower.ForeColor = System.Drawing.Color.Transparent;
            this.progressBarPower.Location = new System.Drawing.Point(161, 95);
            this.progressBarPower.Name = "progressBarPower";
            this.progressBarPower.Size = new System.Drawing.Size(89, 23);
            this.progressBarPower.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPower.TabIndex = 1;
            // 
            // pictureBoxPowerGenerator2
            // 
            this.pictureBoxPowerGenerator2.BackColor = System.Drawing.Color.Khaki;
            this.pictureBoxPowerGenerator2.Location = new System.Drawing.Point(99, 207);
            this.pictureBoxPowerGenerator2.Name = "pictureBoxPowerGenerator2";
            this.pictureBoxPowerGenerator2.Size = new System.Drawing.Size(283, 103);
            this.pictureBoxPowerGenerator2.TabIndex = 58;
            this.pictureBoxPowerGenerator2.TabStop = false;
            // 
            // pictureBoxScienceRoom2
            // 
            this.pictureBoxScienceRoom2.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBoxScienceRoom2.Location = new System.Drawing.Point(434, 333);
            this.pictureBoxScienceRoom2.Name = "pictureBoxScienceRoom2";
            this.pictureBoxScienceRoom2.Size = new System.Drawing.Size(283, 103);
            this.pictureBoxScienceRoom2.TabIndex = 59;
            this.pictureBoxScienceRoom2.TabStop = false;
            // 
            // pictureBoxWaterTreatment2
            // 
            this.pictureBoxWaterTreatment2.BackColor = System.Drawing.Color.Salmon;
            this.pictureBoxWaterTreatment2.Location = new System.Drawing.Point(98, 333);
            this.pictureBoxWaterTreatment2.Name = "pictureBoxWaterTreatment2";
            this.pictureBoxWaterTreatment2.Size = new System.Drawing.Size(283, 103);
            this.pictureBoxWaterTreatment2.TabIndex = 60;
            this.pictureBoxWaterTreatment2.TabStop = false;
            // 
            // pictureBoxKitchen2
            // 
            this.pictureBoxKitchen2.BackColor = System.Drawing.Color.Plum;
            this.pictureBoxKitchen2.Location = new System.Drawing.Point(434, 207);
            this.pictureBoxKitchen2.Name = "pictureBoxKitchen2";
            this.pictureBoxKitchen2.Size = new System.Drawing.Size(283, 103);
            this.pictureBoxKitchen2.TabIndex = 61;
            this.pictureBoxKitchen2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.gradient1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTShelter Game";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitchen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPowerGenerator)).EndInit();
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoins2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScience2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWater2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPower2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPowerGenerator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScienceRoom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaterTreatment2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitchen2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.ProgressBar progressBarPower;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Timer timerTimeInGame;
        private System.Windows.Forms.Button buttonPowerGeneratorUpgrade;
        private System.Windows.Forms.PictureBox pictureBoxPowerGenerator;
        private System.Windows.Forms.PictureBox pictureBoxKitchen;
        private System.Windows.Forms.ProgressBar progressBarScience;
        private System.Windows.Forms.ProgressBar progressBarWater;
        private System.Windows.Forms.ProgressBar progressBarFood;
        private System.Windows.Forms.Timer timerPower;
        private System.Windows.Forms.Label labelPowerGenerator;
        private System.Windows.Forms.Label labelKitchen;
        private System.Windows.Forms.Label labelWaterTreatment;
        private System.Windows.Forms.Label labelScienceRoom;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.PictureBox pictureBoxCoins;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonScienceRoom;
        private System.Windows.Forms.Button buttonKitchen;
        private System.Windows.Forms.Button buttonWaterTreatment;
        private System.Windows.Forms.Timer timerFood;
        private System.Windows.Forms.Timer timerWater;
        private System.Windows.Forms.Timer timerScience;
        private System.Windows.Forms.Label labelPowerGeneratorLevel;
        private System.Windows.Forms.Label labelPowerGeneratorPace;
        private System.Windows.Forms.Button buttonPowerGeneratorAddWorker;
        private System.Windows.Forms.Label labelPowerGeneratorWorkers;
        private System.Windows.Forms.Label labelKitchenLevel;
        private System.Windows.Forms.Label labelKitchenWorkers;
        private System.Windows.Forms.Label labelKitchenPace;
        private System.Windows.Forms.Label labelWaterTreatmentLevel;
        private System.Windows.Forms.Label labelWaterTreatmentPace;
        private System.Windows.Forms.Label labelWaterTreatmentWorkers;
        private System.Windows.Forms.Label labelScienceRoomWorkers;
        private System.Windows.Forms.Label labelScienceRoomLevel;
        private System.Windows.Forms.Label labelScienceRoomPace;
        private System.Windows.Forms.Button buttonScienceRoomAddWorker;
        private System.Windows.Forms.Button buttonScienceRoomUpgrade;
        private System.Windows.Forms.Button buttonWaterTreatmentUpgrade;
        private System.Windows.Forms.Button buttonWaterTreatmentAddWorker;
        private System.Windows.Forms.Button buttonKitchenAddWorker;
        private System.Windows.Forms.Button buttonKitchenUpgrade;
        private System.Windows.Forms.PictureBox pictureBoxPower2;
        private System.Windows.Forms.PictureBox pictureBoxWater2;
        private System.Windows.Forms.PictureBox pictureBoxFood2;
        private System.Windows.Forms.PictureBox pictureBoxScience2;
        private System.Windows.Forms.PictureBox pictureBoxInfo2;
        private System.Windows.Forms.PictureBox pictureBoxExit2;
        private System.Windows.Forms.PictureBox pictureBoxCoins2;
        private System.Windows.Forms.PictureBox pictureBoxPowerGenerator2;
        private System.Windows.Forms.PictureBox pictureBoxScienceRoom2;
        private System.Windows.Forms.PictureBox pictureBoxWaterTreatment2;
        private System.Windows.Forms.PictureBox pictureBoxKitchen2;
        private System.Windows.Forms.Label labelUserName;
    }
}

