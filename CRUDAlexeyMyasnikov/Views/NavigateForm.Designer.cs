namespace FarmKurs.Views
{
    partial class NavigateForm
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
            button_ToMaterials = new Button();
            groupBox1 = new GroupBox();
            button_ToEmployee = new Button();
            button_ToTypeProducts = new Button();
            button_ToLab = new Button();
            button_ToProducts = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_ToMaterials
            // 
            button_ToMaterials.Location = new Point(6, 103);
            button_ToMaterials.Name = "button_ToMaterials";
            button_ToMaterials.Size = new Size(198, 23);
            button_ToMaterials.TabIndex = 0;
            button_ToMaterials.Text = "Сырье";
            button_ToMaterials.UseVisualStyleBackColor = true;
            button_ToMaterials.MouseClick += button_ToMaterials_MouseClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_ToEmployee);
            groupBox1.Controls.Add(button_ToTypeProducts);
            groupBox1.Controls.Add(button_ToLab);
            groupBox1.Controls.Add(button_ToProducts);
            groupBox1.Controls.Add(button_ToMaterials);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Навигация";
            // 
            // button_ToEmployee
            // 
            button_ToEmployee.Location = new Point(6, 297);
            button_ToEmployee.Name = "button_ToEmployee";
            button_ToEmployee.Size = new Size(198, 23);
            button_ToEmployee.TabIndex = 4;
            button_ToEmployee.Text = "Штаб сотрудников/сотрудники";
            button_ToEmployee.UseVisualStyleBackColor = true;
            button_ToEmployee.MouseClick += button_ToEmployee_MouseClick;
            // 
            // button_ToTypeProducts
            // 
            button_ToTypeProducts.Location = new Point(6, 200);
            button_ToTypeProducts.Name = "button_ToTypeProducts";
            button_ToTypeProducts.Size = new Size(198, 23);
            button_ToTypeProducts.TabIndex = 3;
            button_ToTypeProducts.Text = "Тип продукции";
            button_ToTypeProducts.UseVisualStyleBackColor = true;
            button_ToTypeProducts.MouseClick += button_ToTypeProducts_MouseClick;
            // 
            // button_ToLab
            // 
            button_ToLab.Location = new Point(6, 246);
            button_ToLab.Name = "button_ToLab";
            button_ToLab.Size = new Size(198, 23);
            button_ToLab.TabIndex = 2;
            button_ToLab.Text = "Лаборатория";
            button_ToLab.UseVisualStyleBackColor = true;
            button_ToLab.MouseClick += button_ToLab_MouseClick;
            // 
            // button_ToProducts
            // 
            button_ToProducts.Location = new Point(6, 152);
            button_ToProducts.Name = "button_ToProducts";
            button_ToProducts.Size = new Size(198, 23);
            button_ToProducts.TabIndex = 1;
            button_ToProducts.Text = "Продукция";
            button_ToProducts.UseVisualStyleBackColor = true;
            button_ToProducts.MouseClick += button_ToProducts_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1_1;
            pictureBox1.Location = new Point(232, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // NavigateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "NavigateForm";
            Text = "Главная";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_ToMaterials;
        private GroupBox groupBox1;
        private Button button_ToEmployee;
        private Button button_ToTypeProducts;
        private Button button_ToLab;
        private Button button_ToProducts;
        private PictureBox pictureBox1;
    }
}