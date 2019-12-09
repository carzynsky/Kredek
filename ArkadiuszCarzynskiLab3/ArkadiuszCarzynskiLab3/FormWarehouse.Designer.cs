namespace ArkadiuszCarzynskiLab3
{
    partial class FormWarehouse
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
            this.dataGridViewWarehouse = new System.Windows.Forms.DataGridView();
            this.textBoxFiltr = new System.Windows.Forms.TextBox();
            this.buttonFiltr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWarehouse
            // 
            this.dataGridViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouse.Location = new System.Drawing.Point(118, -2);
            this.dataGridViewWarehouse.Name = "dataGridViewWarehouse";
            this.dataGridViewWarehouse.RowHeadersWidth = 51;
            this.dataGridViewWarehouse.RowTemplate.Height = 24;
            this.dataGridViewWarehouse.Size = new System.Drawing.Size(620, 364);
            this.dataGridViewWarehouse.TabIndex = 0;
            // 
            // textBoxFiltr
            // 
            this.textBoxFiltr.Location = new System.Drawing.Point(202, 451);
            this.textBoxFiltr.Multiline = true;
            this.textBoxFiltr.Name = "textBoxFiltr";
            this.textBoxFiltr.Size = new System.Drawing.Size(230, 85);
            this.textBoxFiltr.TabIndex = 1;
            // 
            // buttonFiltr
            // 
            this.buttonFiltr.Location = new System.Drawing.Point(578, 473);
            this.buttonFiltr.Name = "buttonFiltr";
            this.buttonFiltr.Size = new System.Drawing.Size(126, 42);
            this.buttonFiltr.TabIndex = 2;
            this.buttonFiltr.Text = "Filtr";
            this.buttonFiltr.UseVisualStyleBackColor = true;
            this.buttonFiltr.Click += new System.EventHandler(this.buttonFiltr_Click);
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 568);
            this.Controls.Add(this.buttonFiltr);
            this.Controls.Add(this.textBoxFiltr);
            this.Controls.Add(this.dataGridViewWarehouse);
            this.Name = "FormWarehouse";
            this.Text = "FormWarehouse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWarehouse;
        private System.Windows.Forms.TextBox textBoxFiltr;
        private System.Windows.Forms.Button buttonFiltr;
    }
}