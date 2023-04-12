namespace FarmKurs.Views
{
    partial class MaterialsForm
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
            groupBox1 = new GroupBox();
            button_DeleteMaterial = new Button();
            dataGridView_AllMaterials = new DataGridView();
            groupBox2 = new GroupBox();
            button_ClearAddMaterial = new Button();
            button_AddMaterial = new Button();
            label4 = new Label();
            textBox_HazardIndex = new TextBox();
            label3 = new Label();
            textBox_PriceMaterial = new TextBox();
            label2 = new Label();
            textBox_VolumeMaterial = new TextBox();
            textBox_NameMaterials = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label_CountMaterials = new Label();
            button_ToNaviagate = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AllMaterials).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_DeleteMaterial);
            groupBox1.Controls.Add(dataGridView_AllMaterials);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Все сырье";
            // 
            // button_DeleteMaterial
            // 
            button_DeleteMaterial.Location = new Point(115, 388);
            button_DeleteMaterial.Name = "button_DeleteMaterial";
            button_DeleteMaterial.Size = new Size(190, 23);
            button_DeleteMaterial.TabIndex = 1;
            button_DeleteMaterial.Text = "Удалить материал";
            button_DeleteMaterial.UseVisualStyleBackColor = true;
            button_DeleteMaterial.MouseClick += button_DeleteMaterial_MouseClick;
            // 
            // dataGridView_AllMaterials
            // 
            dataGridView_AllMaterials.AllowUserToAddRows = false;
            dataGridView_AllMaterials.AllowUserToDeleteRows = false;
            dataGridView_AllMaterials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_AllMaterials.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_AllMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AllMaterials.Location = new Point(6, 22);
            dataGridView_AllMaterials.MultiSelect = false;
            dataGridView_AllMaterials.Name = "dataGridView_AllMaterials";
            dataGridView_AllMaterials.ReadOnly = true;
            dataGridView_AllMaterials.RowTemplate.Height = 25;
            dataGridView_AllMaterials.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_AllMaterials.Size = new Size(456, 350);
            dataGridView_AllMaterials.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_ClearAddMaterial);
            groupBox2.Controls.Add(button_AddMaterial);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox_HazardIndex);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox_PriceMaterial);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox_VolumeMaterial);
            groupBox2.Controls.Add(textBox_NameMaterials);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(486, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 288);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавить сырье";
            // 
            // button_ClearAddMaterial
            // 
            button_ClearAddMaterial.Location = new Point(221, 241);
            button_ClearAddMaterial.Name = "button_ClearAddMaterial";
            button_ClearAddMaterial.Size = new Size(75, 23);
            button_ClearAddMaterial.TabIndex = 9;
            button_ClearAddMaterial.Text = "Отмена";
            button_ClearAddMaterial.UseVisualStyleBackColor = true;
            button_ClearAddMaterial.MouseClick += button_ClearAddMaterial_MouseClick;
            // 
            // button_AddMaterial
            // 
            button_AddMaterial.Location = new Point(20, 241);
            button_AddMaterial.Name = "button_AddMaterial";
            button_AddMaterial.Size = new Size(163, 23);
            button_AddMaterial.TabIndex = 8;
            button_AddMaterial.Text = "Добавить материал";
            button_AddMaterial.UseVisualStyleBackColor = true;
            button_AddMaterial.MouseClick += button_AddMaterial_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 200);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 7;
            label4.Text = "Индекс хим. опас.";
            // 
            // textBox_HazardIndex
            // 
            textBox_HazardIndex.Location = new Point(133, 197);
            textBox_HazardIndex.Name = "textBox_HazardIndex";
            textBox_HazardIndex.Size = new Size(163, 23);
            textBox_HazardIndex.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 153);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Цена сырья";
            // 
            // textBox_PriceMaterial
            // 
            textBox_PriceMaterial.Location = new Point(133, 150);
            textBox_PriceMaterial.Name = "textBox_PriceMaterial";
            textBox_PriceMaterial.Size = new Size(163, 23);
            textBox_PriceMaterial.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 103);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Объем сырья";
            // 
            // textBox_VolumeMaterial
            // 
            textBox_VolumeMaterial.Location = new Point(133, 100);
            textBox_VolumeMaterial.Name = "textBox_VolumeMaterial";
            textBox_VolumeMaterial.Size = new Size(163, 23);
            textBox_VolumeMaterial.TabIndex = 2;
            // 
            // textBox_NameMaterials
            // 
            textBox_NameMaterials.Location = new Point(133, 50);
            textBox_NameMaterials.Name = "textBox_NameMaterials";
            textBox_NameMaterials.Size = new Size(163, 23);
            textBox_NameMaterials.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 58);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Название сырья";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(492, 50);
            label5.Name = "label5";
            label5.Size = new Size(180, 15);
            label5.TabIndex = 2;
            label5.Text = "Всего химических материалов:";
            // 
            // label_CountMaterials
            // 
            label_CountMaterials.AutoSize = true;
            label_CountMaterials.Location = new Point(707, 50);
            label_CountMaterials.Name = "label_CountMaterials";
            label_CountMaterials.Size = new Size(0, 15);
            label_CountMaterials.TabIndex = 3;
            // 
            // button_ToNaviagate
            // 
            button_ToNaviagate.Location = new Point(561, 400);
            button_ToNaviagate.Name = "button_ToNaviagate";
            button_ToNaviagate.Size = new Size(163, 23);
            button_ToNaviagate.TabIndex = 4;
            button_ToNaviagate.Text = "Вернуться назад";
            button_ToNaviagate.UseVisualStyleBackColor = true;
            button_ToNaviagate.MouseClick += button_ToNaviagate_MouseClick;
            // 
            // MaterialsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_ToNaviagate);
            Controls.Add(label_CountMaterials);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MaterialsForm";
            Text = "Сырье";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_AllMaterials).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView_AllMaterials;
        private Button button_DeleteMaterial;
        private GroupBox groupBox2;
        private Button button_ClearAddMaterial;
        private Button button_AddMaterial;
        private Label label4;
        private TextBox textBox_HazardIndex;
        private Label label3;
        private TextBox textBox_PriceMaterial;
        private Label label2;
        private TextBox textBox_VolumeMaterial;
        private TextBox textBox_NameMaterials;
        private Label label1;
        private Label label5;
        private Label label_CountMaterials;
        private Button button_ToNaviagate;
    }
}