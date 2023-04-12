namespace DanilSalikov.Views
{
    partial class ViewTableForm
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
            DataGridViewObjects = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridViewObjects).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewObjects
            // 
            DataGridViewObjects.AllowUserToAddRows = false;
            DataGridViewObjects.AllowUserToDeleteRows = false;
            DataGridViewObjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewObjects.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            DataGridViewObjects.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridViewObjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewObjects.Dock = DockStyle.Fill;
            DataGridViewObjects.Location = new Point(0, 0);
            DataGridViewObjects.Name = "DataGridViewObjects";
            DataGridViewObjects.ReadOnly = true;
            DataGridViewObjects.RowTemplate.Height = 25;
            DataGridViewObjects.Size = new Size(800, 450);
            DataGridViewObjects.TabIndex = 0;
            // 
            // ViewTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridViewObjects);
            Name = "ViewTableForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Просмотр таблицы ";
            ((System.ComponentModel.ISupportInitialize)DataGridViewObjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewObjects;
    }
}