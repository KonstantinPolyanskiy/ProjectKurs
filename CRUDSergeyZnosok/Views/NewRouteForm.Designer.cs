namespace ZnosokKurs.Views
{
    partial class NewRouteForm
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
            button_CancelNewRoute = new Button();
            button_AddRoute = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            listBox_AllStops = new ListBox();
            listBox_RouteStops = new ListBox();
            label3 = new Label();
            textBox_RouteLength = new TextBox();
            label2 = new Label();
            textBox_RouteName = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_CancelNewRoute);
            groupBox1.Controls.Add(button_AddRoute);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(listBox_AllStops);
            groupBox1.Controls.Add(listBox_RouteStops);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_RouteLength);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_RouteName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 419);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Новый маршрут";
            // 
            // button_CancelNewRoute
            // 
            button_CancelNewRoute.Location = new Point(184, 358);
            button_CancelNewRoute.Name = "button_CancelNewRoute";
            button_CancelNewRoute.Size = new Size(75, 23);
            button_CancelNewRoute.TabIndex = 14;
            button_CancelNewRoute.Text = "Отмена";
            button_CancelNewRoute.UseVisualStyleBackColor = true;
            // 
            // button_AddRoute
            // 
            button_AddRoute.Location = new Point(103, 358);
            button_AddRoute.Name = "button_AddRoute";
            button_AddRoute.Size = new Size(75, 23);
            button_AddRoute.TabIndex = 13;
            button_AddRoute.Text = "Добавить";
            button_AddRoute.UseVisualStyleBackColor = true;
            button_AddRoute.MouseClick += button_AddRoute_MouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(184, 295);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "<-";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button2_MouseClick;
            // 
            // button1
            // 
            button1.Location = new Point(103, 295);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "->";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 132);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 8;
            label5.Text = "Все остановки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 132);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 7;
            label4.Text = "Остановки маршрута";
            // 
            // listBox_AllStops
            // 
            listBox_AllStops.FormattingEnabled = true;
            listBox_AllStops.ItemHeight = 15;
            listBox_AllStops.Location = new Point(184, 150);
            listBox_AllStops.Name = "listBox_AllStops";
            listBox_AllStops.Size = new Size(170, 139);
            listBox_AllStops.TabIndex = 6;
            // 
            // listBox_RouteStops
            // 
            listBox_RouteStops.FormattingEnabled = true;
            listBox_RouteStops.ItemHeight = 15;
            listBox_RouteStops.Location = new Point(6, 150);
            listBox_RouteStops.Name = "listBox_RouteStops";
            listBox_RouteStops.Size = new Size(172, 139);
            listBox_RouteStops.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 106);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Остановки:";
            // 
            // textBox_RouteLength
            // 
            textBox_RouteLength.Location = new Point(169, 68);
            textBox_RouteLength.Name = "textBox_RouteLength";
            textBox_RouteLength.Size = new Size(185, 23);
            textBox_RouteLength.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(157, 15);
            label2.TabIndex = 2;
            label2.Text = "Протяженность маршрута:";
            // 
            // textBox_RouteName
            // 
            textBox_RouteName.Location = new Point(169, 34);
            textBox_RouteName.Name = "textBox_RouteName";
            textBox_RouteName.Size = new Size(185, 23);
            textBox_RouteName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 37);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Название маршрута:";
            // 
            // NewRouteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 443);
            Controls.Add(groupBox1);
            Name = "NewRouteForm";
            Text = "Добавление нового маршрута";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button button_CancelNewRoute;
        private Button button_AddRoute;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private ListBox listBox_AllStops;
        private ListBox listBox_RouteStops;
        private Label label3;
        private TextBox textBox_RouteLength;
        private Label label2;
        private TextBox textBox_RouteName;
    }
}