namespace ZnosokKurs.Views
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxSchedule = new GroupBox();
            button_DeleteEditBusStop = new Button();
            button_AddOrSaveRouteTime = new Button();
            dateTimePicker_TimeEndPoint = new DateTimePicker();
            dateTimePicker_TimeStartPoint = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dataGridView_RouteTimeTable = new DataGridView();
            groupBox2 = new GroupBox();
            button_DeleteCityTransport = new Button();
            button_AddCityTransport = new Button();
            dataGridView_CityTransport = new DataGridView();
            groupBox1 = new GroupBox();
            button_DeleteTypeTransport = new Button();
            button_AddTypeTransport = new Button();
            dataGridView_TypeTransport = new DataGridView();
            tabPage2 = new TabPage();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            button_DeleteBusStop = new Button();
            button_AddOrSaveBusStop = new Button();
            textBox_longitude = new TextBox();
            textBox_latitude = new TextBox();
            textBox_NameBusStop = new TextBox();
            textBox_Street = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView_BusStops = new DataGridView();
            groupBox5 = new GroupBox();
            button_DeleteRoute = new Button();
            button_AddRoute = new Button();
            dataGridView_Route = new DataGridView();
            tabPage3 = new TabPage();
            label13 = new Label();
            groupBox9 = new GroupBox();
            pictureBox2 = new PictureBox();
            textBox_PositionUser = new TextBox();
            textBox_PasswordUser = new TextBox();
            textBox_LoginUser = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            textBox_UserNumber = new TextBox();
            textBox_UserName = new TextBox();
            label8 = new Label();
            button_Cancel = new Button();
            button_AddUser = new Button();
            groupBox8 = new GroupBox();
            button_DeleteUser = new Button();
            dataGridView_Users = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_RouteTimeTable).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CityTransport).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_TypeTransport).BeginInit();
            tabPage2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_BusStops).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Route).BeginInit();
            tabPage3.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Users).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1428, 577);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1420, 549);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Транспорт/расписание";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(groupBoxSchedule);
            groupBox3.Controls.Add(dataGridView_RouteTimeTable);
            groupBox3.Location = new Point(684, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(730, 537);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Расписание";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.busmain;
            pictureBox1.Location = new Point(6, 402);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(718, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBoxSchedule
            // 
            groupBoxSchedule.Controls.Add(button_DeleteEditBusStop);
            groupBoxSchedule.Controls.Add(button_AddOrSaveRouteTime);
            groupBoxSchedule.Controls.Add(dateTimePicker_TimeEndPoint);
            groupBoxSchedule.Controls.Add(dateTimePicker_TimeStartPoint);
            groupBoxSchedule.Controls.Add(label3);
            groupBoxSchedule.Controls.Add(label2);
            groupBoxSchedule.Location = new Point(6, 259);
            groupBoxSchedule.Name = "groupBoxSchedule";
            groupBoxSchedule.Size = new Size(718, 137);
            groupBoxSchedule.TabIndex = 1;
            groupBoxSchedule.TabStop = false;
            groupBoxSchedule.Text = "Изменить расписание";
            // 
            // button_DeleteEditBusStop
            // 
            button_DeleteEditBusStop.Location = new Point(512, 76);
            button_DeleteEditBusStop.Name = "button_DeleteEditBusStop";
            button_DeleteEditBusStop.Size = new Size(75, 23);
            button_DeleteEditBusStop.TabIndex = 8;
            button_DeleteEditBusStop.Text = "Удалить";
            button_DeleteEditBusStop.UseVisualStyleBackColor = true;
            button_DeleteEditBusStop.MouseClick += button_DeleteEditBusStop_MouseClick;
            // 
            // button_AddOrSaveRouteTime
            // 
            button_AddOrSaveRouteTime.Location = new Point(512, 42);
            button_AddOrSaveRouteTime.Name = "button_AddOrSaveRouteTime";
            button_AddOrSaveRouteTime.Size = new Size(75, 23);
            button_AddOrSaveRouteTime.TabIndex = 6;
            button_AddOrSaveRouteTime.Text = "Добавить";
            button_AddOrSaveRouteTime.UseVisualStyleBackColor = true;
            button_AddOrSaveRouteTime.MouseClick += button_AddOrSaveRouteTime_MouseClick;
            // 
            // dateTimePicker_TimeEndPoint
            // 
            dateTimePicker_TimeEndPoint.Format = DateTimePickerFormat.Time;
            dateTimePicker_TimeEndPoint.Location = new Point(298, 76);
            dateTimePicker_TimeEndPoint.Name = "dateTimePicker_TimeEndPoint";
            dateTimePicker_TimeEndPoint.Size = new Size(186, 23);
            dateTimePicker_TimeEndPoint.TabIndex = 5;
            // 
            // dateTimePicker_TimeStartPoint
            // 
            dateTimePicker_TimeStartPoint.Format = DateTimePickerFormat.Time;
            dateTimePicker_TimeStartPoint.Location = new Point(298, 46);
            dateTimePicker_TimeStartPoint.Name = "dateTimePicker_TimeStartPoint";
            dateTimePicker_TimeStartPoint.Size = new Size(186, 23);
            dateTimePicker_TimeStartPoint.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(280, 15);
            label3.TabIndex = 2;
            label3.Text = "Время отправления с конечной точки маршрута:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(286, 15);
            label2.TabIndex = 1;
            label2.Text = "Время отправления с начальной точки маршрута:";
            // 
            // dataGridView_RouteTimeTable
            // 
            dataGridView_RouteTimeTable.AllowUserToAddRows = false;
            dataGridView_RouteTimeTable.AllowUserToDeleteRows = false;
            dataGridView_RouteTimeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_RouteTimeTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_RouteTimeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_RouteTimeTable.Location = new Point(6, 22);
            dataGridView_RouteTimeTable.Name = "dataGridView_RouteTimeTable";
            dataGridView_RouteTimeTable.ReadOnly = true;
            dataGridView_RouteTimeTable.RowTemplate.Height = 25;
            dataGridView_RouteTimeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_RouteTimeTable.Size = new Size(718, 231);
            dataGridView_RouteTimeTable.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_DeleteCityTransport);
            groupBox2.Controls.Add(button_AddCityTransport);
            groupBox2.Controls.Add(dataGridView_CityTransport);
            groupBox2.Location = new Point(5, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(673, 310);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Городской транспорт";
            // 
            // button_DeleteCityTransport
            // 
            button_DeleteCityTransport.Location = new Point(381, 258);
            button_DeleteCityTransport.Name = "button_DeleteCityTransport";
            button_DeleteCityTransport.Size = new Size(75, 23);
            button_DeleteCityTransport.TabIndex = 3;
            button_DeleteCityTransport.Text = "Удалить";
            button_DeleteCityTransport.UseVisualStyleBackColor = true;
            button_DeleteCityTransport.MouseClick += button_DeleteCityTransport_MouseClick;
            // 
            // button_AddCityTransport
            // 
            button_AddCityTransport.Location = new Point(253, 258);
            button_AddCityTransport.Name = "button_AddCityTransport";
            button_AddCityTransport.Size = new Size(75, 23);
            button_AddCityTransport.TabIndex = 2;
            button_AddCityTransport.Text = "Добавить";
            button_AddCityTransport.UseVisualStyleBackColor = true;
            button_AddCityTransport.MouseClick += button_AddCityTransport_MouseClick;
            // 
            // dataGridView_CityTransport
            // 
            dataGridView_CityTransport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_CityTransport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_CityTransport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_CityTransport.Location = new Point(7, 22);
            dataGridView_CityTransport.MultiSelect = false;
            dataGridView_CityTransport.Name = "dataGridView_CityTransport";
            dataGridView_CityTransport.RowTemplate.Height = 25;
            dataGridView_CityTransport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_CityTransport.Size = new Size(660, 230);
            dataGridView_CityTransport.TabIndex = 0;
            dataGridView_CityTransport.SelectionChanged += dataGridView_CityTransport_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_DeleteTypeTransport);
            groupBox1.Controls.Add(button_AddTypeTransport);
            groupBox1.Controls.Add(dataGridView_TypeTransport);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип транспорта";
            // 
            // button_DeleteTypeTransport
            // 
            button_DeleteTypeTransport.Location = new Point(380, 178);
            button_DeleteTypeTransport.Name = "button_DeleteTypeTransport";
            button_DeleteTypeTransport.Size = new Size(75, 23);
            button_DeleteTypeTransport.TabIndex = 2;
            button_DeleteTypeTransport.Text = "Удалить";
            button_DeleteTypeTransport.UseVisualStyleBackColor = true;
            button_DeleteTypeTransport.MouseClick += button_DeleteTypeTransport_MouseClick;
            // 
            // button_AddTypeTransport
            // 
            button_AddTypeTransport.Location = new Point(252, 178);
            button_AddTypeTransport.Name = "button_AddTypeTransport";
            button_AddTypeTransport.Size = new Size(75, 23);
            button_AddTypeTransport.TabIndex = 1;
            button_AddTypeTransport.Text = "Добавить";
            button_AddTypeTransport.UseVisualStyleBackColor = true;
            button_AddTypeTransport.MouseClick += button_AddTypeTransport_MouseClick;
            // 
            // dataGridView_TypeTransport
            // 
            dataGridView_TypeTransport.AllowUserToAddRows = false;
            dataGridView_TypeTransport.AllowUserToDeleteRows = false;
            dataGridView_TypeTransport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_TypeTransport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_TypeTransport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_TypeTransport.Location = new Point(6, 22);
            dataGridView_TypeTransport.MultiSelect = false;
            dataGridView_TypeTransport.Name = "dataGridView_TypeTransport";
            dataGridView_TypeTransport.ReadOnly = true;
            dataGridView_TypeTransport.RowTemplate.Height = 25;
            dataGridView_TypeTransport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_TypeTransport.Size = new Size(660, 150);
            dataGridView_TypeTransport.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1420, 549);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Маршруты/Остановки";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(groupBox7);
            groupBox6.Controls.Add(dataGridView_BusStops);
            groupBox6.Location = new Point(796, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(618, 537);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Остановки";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(button_DeleteBusStop);
            groupBox7.Controls.Add(button_AddOrSaveBusStop);
            groupBox7.Controls.Add(textBox_longitude);
            groupBox7.Controls.Add(textBox_latitude);
            groupBox7.Controls.Add(textBox_NameBusStop);
            groupBox7.Controls.Add(textBox_Street);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(label5);
            groupBox7.Controls.Add(label4);
            groupBox7.Location = new Point(6, 306);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(606, 225);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Изменить остановку";
            // 
            // button_DeleteBusStop
            // 
            button_DeleteBusStop.Location = new Point(420, 164);
            button_DeleteBusStop.Name = "button_DeleteBusStop";
            button_DeleteBusStop.Size = new Size(75, 23);
            button_DeleteBusStop.TabIndex = 9;
            button_DeleteBusStop.Text = "Удалить";
            button_DeleteBusStop.UseVisualStyleBackColor = true;
            button_DeleteBusStop.MouseClick += button_DeleteBusStop_MouseClick;
            // 
            // button_AddOrSaveBusStop
            // 
            button_AddOrSaveBusStop.Location = new Point(201, 164);
            button_AddOrSaveBusStop.Name = "button_AddOrSaveBusStop";
            button_AddOrSaveBusStop.Size = new Size(75, 23);
            button_AddOrSaveBusStop.TabIndex = 8;
            button_AddOrSaveBusStop.Text = "Добавить";
            button_AddOrSaveBusStop.UseVisualStyleBackColor = true;
            button_AddOrSaveBusStop.MouseClick += button_AddOrSaveBusStop_MouseClick;
            // 
            // textBox_longitude
            // 
            textBox_longitude.Location = new Point(201, 118);
            textBox_longitude.Name = "textBox_longitude";
            textBox_longitude.Size = new Size(294, 23);
            textBox_longitude.TabIndex = 7;
            // 
            // textBox_latitude
            // 
            textBox_latitude.Location = new Point(201, 89);
            textBox_latitude.Name = "textBox_latitude";
            textBox_latitude.Size = new Size(294, 23);
            textBox_latitude.TabIndex = 6;
            // 
            // textBox_NameBusStop
            // 
            textBox_NameBusStop.Location = new Point(201, 60);
            textBox_NameBusStop.Name = "textBox_NameBusStop";
            textBox_NameBusStop.Size = new Size(294, 23);
            textBox_NameBusStop.TabIndex = 5;
            // 
            // textBox_Street
            // 
            textBox_Street.Location = new Point(201, 32);
            textBox_Street.Name = "textBox_Street";
            textBox_Street.Size = new Size(294, 23);
            textBox_Street.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 126);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 3;
            label7.Text = "Долгота:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 97);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 2;
            label6.Text = "Широта:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 40);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 1;
            label5.Text = "Улица:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 68);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 0;
            label4.Text = "Название остановки:";
            // 
            // dataGridView_BusStops
            // 
            dataGridView_BusStops.AllowUserToAddRows = false;
            dataGridView_BusStops.AllowUserToDeleteRows = false;
            dataGridView_BusStops.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_BusStops.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_BusStops.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_BusStops.Location = new Point(6, 22);
            dataGridView_BusStops.Name = "dataGridView_BusStops";
            dataGridView_BusStops.ReadOnly = true;
            dataGridView_BusStops.RowTemplate.Height = 25;
            dataGridView_BusStops.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_BusStops.Size = new Size(606, 278);
            dataGridView_BusStops.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button_DeleteRoute);
            groupBox5.Controls.Add(button_AddRoute);
            groupBox5.Controls.Add(dataGridView_Route);
            groupBox5.Location = new Point(6, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(784, 537);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Маршруты";
            // 
            // button_DeleteRoute
            // 
            button_DeleteRoute.Location = new Point(567, 491);
            button_DeleteRoute.Name = "button_DeleteRoute";
            button_DeleteRoute.Size = new Size(211, 23);
            button_DeleteRoute.TabIndex = 2;
            button_DeleteRoute.Text = "Удалить";
            button_DeleteRoute.UseVisualStyleBackColor = true;
            button_DeleteRoute.MouseClick += button_DeleteRoute_MouseClick;
            // 
            // button_AddRoute
            // 
            button_AddRoute.Location = new Point(6, 491);
            button_AddRoute.Name = "button_AddRoute";
            button_AddRoute.Size = new Size(211, 23);
            button_AddRoute.TabIndex = 1;
            button_AddRoute.Text = "Добавить";
            button_AddRoute.UseVisualStyleBackColor = true;
            button_AddRoute.MouseClick += button_AddRoute_MouseClick;
            // 
            // dataGridView_Route
            // 
            dataGridView_Route.AllowUserToAddRows = false;
            dataGridView_Route.AllowUserToDeleteRows = false;
            dataGridView_Route.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Route.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Route.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Route.Location = new Point(6, 22);
            dataGridView_Route.MultiSelect = false;
            dataGridView_Route.Name = "dataGridView_Route";
            dataGridView_Route.ReadOnly = true;
            dataGridView_Route.RowTemplate.Height = 25;
            dataGridView_Route.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Route.Size = new Size(772, 463);
            dataGridView_Route.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(groupBox9);
            tabPage3.Controls.Add(groupBox8);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1420, 549);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Пользователи";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(1254, 522);
            label13.Name = "label13";
            label13.Size = new Size(139, 15);
            label13.TabIndex = 2;
            label13.Text = "Made By Sergey Znosok";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(pictureBox2);
            groupBox9.Controls.Add(textBox_PositionUser);
            groupBox9.Controls.Add(textBox_PasswordUser);
            groupBox9.Controls.Add(textBox_LoginUser);
            groupBox9.Controls.Add(label12);
            groupBox9.Controls.Add(label11);
            groupBox9.Controls.Add(label10);
            groupBox9.Controls.Add(label9);
            groupBox9.Controls.Add(textBox_UserNumber);
            groupBox9.Controls.Add(textBox_UserName);
            groupBox9.Controls.Add(label8);
            groupBox9.Controls.Add(button_Cancel);
            groupBox9.Controls.Add(button_AddUser);
            groupBox9.Location = new Point(996, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(420, 480);
            groupBox9.TabIndex = 1;
            groupBox9.TabStop = false;
            groupBox9.Text = "Регистрация пользователя";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.employer;
            pictureBox2.Location = new Point(6, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(408, 249);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // textBox_PositionUser
            // 
            textBox_PositionUser.Location = new Point(142, 394);
            textBox_PositionUser.Name = "textBox_PositionUser";
            textBox_PositionUser.Size = new Size(272, 23);
            textBox_PositionUser.TabIndex = 11;
            // 
            // textBox_PasswordUser
            // 
            textBox_PasswordUser.Location = new Point(142, 365);
            textBox_PasswordUser.Name = "textBox_PasswordUser";
            textBox_PasswordUser.Size = new Size(272, 23);
            textBox_PasswordUser.TabIndex = 10;
            // 
            // textBox_LoginUser
            // 
            textBox_LoginUser.Location = new Point(142, 335);
            textBox_LoginUser.Name = "textBox_LoginUser";
            textBox_LoginUser.Size = new Size(272, 23);
            textBox_LoginUser.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(69, 402);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 8;
            label12.Text = "Должность:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(84, 368);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 7;
            label11.Text = "Пароль:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(97, 338);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 6;
            label10.Text = "Логин:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 309);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 5;
            label9.Text = "Номер телефона:";
            // 
            // textBox_UserNumber
            // 
            textBox_UserNumber.Location = new Point(142, 306);
            textBox_UserNumber.Name = "textBox_UserNumber";
            textBox_UserNumber.Size = new Size(272, 23);
            textBox_UserNumber.TabIndex = 4;
            // 
            // textBox_UserName
            // 
            textBox_UserName.Location = new Point(142, 277);
            textBox_UserName.Name = "textBox_UserName";
            textBox_UserName.Size = new Size(272, 23);
            textBox_UserName.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 280);
            label8.Name = "label8";
            label8.Size = new Size(115, 15);
            label8.TabIndex = 2;
            label8.Text = "ФИО пользователя:";
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(223, 436);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "Отмена";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_AddUser
            // 
            button_AddUser.Location = new Point(142, 436);
            button_AddUser.Name = "button_AddUser";
            button_AddUser.Size = new Size(75, 23);
            button_AddUser.TabIndex = 0;
            button_AddUser.Text = "Добавить";
            button_AddUser.UseVisualStyleBackColor = true;
            button_AddUser.MouseClick += button_AddUser_MouseClick;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(button_DeleteUser);
            groupBox8.Controls.Add(dataGridView_Users);
            groupBox8.Location = new Point(5, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(985, 543);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            groupBox8.Text = "Список пользователей";
            // 
            // button_DeleteUser
            // 
            button_DeleteUser.Location = new Point(411, 499);
            button_DeleteUser.Name = "button_DeleteUser";
            button_DeleteUser.Size = new Size(232, 23);
            button_DeleteUser.TabIndex = 1;
            button_DeleteUser.Text = "Удалить";
            button_DeleteUser.UseVisualStyleBackColor = true;
            button_DeleteUser.MouseClick += button_DeleteUser_MouseClick;
            // 
            // dataGridView_Users
            // 
            dataGridView_Users.AllowUserToAddRows = false;
            dataGridView_Users.AllowUserToDeleteRows = false;
            dataGridView_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Users.Location = new Point(6, 22);
            dataGridView_Users.Name = "dataGridView_Users";
            dataGridView_Users.ReadOnly = true;
            dataGridView_Users.RowTemplate.Height = 25;
            dataGridView_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Users.Size = new Size(973, 458);
            dataGridView_Users.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 581);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Главная";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxSchedule.ResumeLayout(false);
            groupBoxSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_RouteTimeTable).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_CityTransport).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_TypeTransport).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_BusStops).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Route).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private GroupBox groupBoxSchedule;
        private Button button_AddOrSaveRouteTime;
        private DateTimePicker dateTimePicker_TimeEndPoint;
        private DateTimePicker dateTimePicker_TimeStartPoint;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView_RouteTimeTable;
        private GroupBox groupBox2;
        private Button button_DeleteCityTransport;
        private Button button_AddCityTransport;
        private DataGridView dataGridView_CityTransport;
        private GroupBox groupBox1;
        private Button button_DeleteTypeTransport;
        private Button button_AddTypeTransport;
        private DataGridView dataGridView_TypeTransport;
        private GroupBox groupBox6;
        private DataGridView dataGridView_BusStops;
        private GroupBox groupBox5;
        private Button button_DeleteRoute;
        private Button button_AddRoute;
        private DataGridView dataGridView_Route;
        private GroupBox groupBox7;
        private Button button_DeleteBusStop;
        private Button button_AddOrSaveBusStop;
        private TextBox textBox_longitude;
        private TextBox textBox_latitude;
        private TextBox textBox_NameBusStop;
        private TextBox textBox_Street;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TabPage tabPage3;
        private GroupBox groupBox9;
        private PictureBox pictureBox2;
        private TextBox textBox_PositionUser;
        private TextBox textBox_PasswordUser;
        private TextBox textBox_LoginUser;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBox_UserNumber;
        private TextBox textBox_UserName;
        private Label label8;
        private Button button_Cancel;
        private Button button_AddUser;
        private GroupBox groupBox8;
        private Button button_DeleteUser;
        private DataGridView dataGridView_Users;
        private Label label13;
        private Button button_DeleteEditBusStop;
    }
}