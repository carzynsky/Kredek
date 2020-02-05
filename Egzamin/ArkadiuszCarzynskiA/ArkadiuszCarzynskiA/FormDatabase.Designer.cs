namespace ArkadiuszCarzynskiA
{
    partial class FormDatabase
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
            this.dataGridViewDatabase = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDatabase
            // 
            this.dataGridViewDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatabase.Location = new System.Drawing.Point(155, 41);
            this.dataGridViewDatabase.Name = "dataGridViewDatabase";
            this.dataGridViewDatabase.RowHeadersWidth = 51;
            this.dataGridViewDatabase.RowTemplate.Height = 24;
            this.dataGridViewDatabase.Size = new System.Drawing.Size(508, 360);
            this.dataGridViewDatabase.TabIndex = 0;
            // 
            // FormDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDatabase);
            this.Name = "FormDatabase";
            this.Text = "FormDatabase";
            this.Load += new System.EventHandler(this.FormsDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDatabase;
    }
}