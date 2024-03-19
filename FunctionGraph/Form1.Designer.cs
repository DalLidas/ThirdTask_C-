namespace FunctionGraph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            stripMenuItem_CreateNewProject = new ToolStripMenuItem();
            stripMenuItem_OpenProject = new ToolStripMenuItem();
            stripMenuItem_SaveInExcel = new ToolStripMenuItem();
            stripMenuItem_AboutCreator = new ToolStripMenuItem();
            exit_button = new Button();
            menu_panel = new Panel();
            menu_icon = new PictureBox();
            collapse_button = new Button();
            pictureBox = new PictureBox();
            label_accuracy = new Label();
            textBox_Accuracy = new TextBox();
            label_radius = new Label();
            textBox_Radius = new TextBox();
            label_main = new Label();
            menu_border = new Panel();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label_Graph_parametrs = new Label();
            label_intersection_error = new Label();
            textBox_LeftLimit = new TextBox();
            textBox_RightLimit = new TextBox();
            label_LeftLimit = new Label();
            label_RightLimit = new Label();
            label_mesuar = new Label();
            label_scaled_grid_mesuar = new Label();
            label_unit_scale = new Label();
            label_scaled_graph_mesuar = new Label();
            label_scale = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menu_border.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(31, 31, 31);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(33, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(57, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackgroundImageLayout = ImageLayout.None;
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { stripMenuItem_CreateNewProject, stripMenuItem_OpenProject, stripMenuItem_SaveInExcel, stripMenuItem_AboutCreator });
            toolStripMenuItem1.ForeColor = Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(50, 20);
            toolStripMenuItem1.Text = "Menu";
            // 
            // stripMenuItem_CreateNewProject
            // 
            stripMenuItem_CreateNewProject.BackColor = Color.FromArgb(61, 61, 61);
            stripMenuItem_CreateNewProject.ForeColor = Color.White;
            stripMenuItem_CreateNewProject.Name = "stripMenuItem_CreateNewProject";
            stripMenuItem_CreateNewProject.Size = new Size(147, 22);
            stripMenuItem_CreateNewProject.Text = "New project";
            stripMenuItem_CreateNewProject.Click += stripMenuItem_CreateNewProject_Click;
            // 
            // stripMenuItem_OpenProject
            // 
            stripMenuItem_OpenProject.BackColor = Color.FromArgb(61, 61, 61);
            stripMenuItem_OpenProject.ForeColor = Color.White;
            stripMenuItem_OpenProject.Name = "stripMenuItem_OpenProject";
            stripMenuItem_OpenProject.Size = new Size(147, 22);
            stripMenuItem_OpenProject.Text = "Open project";
            stripMenuItem_OpenProject.Click += stripMenuItem_OpenProject_Click;
            // 
            // stripMenuItem_SaveInExcel
            // 
            stripMenuItem_SaveInExcel.BackColor = Color.FromArgb(61, 61, 61);
            stripMenuItem_SaveInExcel.ForeColor = Color.White;
            stripMenuItem_SaveInExcel.Name = "stripMenuItem_SaveInExcel";
            stripMenuItem_SaveInExcel.Size = new Size(147, 22);
            stripMenuItem_SaveInExcel.Text = "Save as ...";
            stripMenuItem_SaveInExcel.Click += stripMenuItem_SaveInExcel_Click;
            // 
            // stripMenuItem_AboutCreator
            // 
            stripMenuItem_AboutCreator.BackColor = Color.FromArgb(64, 64, 64);
            stripMenuItem_AboutCreator.ForeColor = Color.White;
            stripMenuItem_AboutCreator.Name = "stripMenuItem_AboutCreator";
            stripMenuItem_AboutCreator.Size = new Size(147, 22);
            stripMenuItem_AboutCreator.Text = "About creator";
            stripMenuItem_AboutCreator.Click += stripMenuItem_AboutCreator_Click;
            // 
            // exit_button
            // 
            exit_button.BackColor = Color.FromArgb(31, 31, 31);
            exit_button.FlatAppearance.BorderSize = 0;
            exit_button.FlatStyle = FlatStyle.Flat;
            exit_button.ForeColor = Color.White;
            exit_button.Location = new Point(1332, -2);
            exit_button.Margin = new Padding(5, 3, 4, 3);
            exit_button.Name = "exit_button";
            exit_button.Padding = new Padding(5, 6, 0, 0);
            exit_button.RightToLeft = RightToLeft.No;
            exit_button.Size = new Size(49, 28);
            exit_button.TabIndex = 2;
            exit_button.Text = "X";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += exit_button_Click;
            exit_button.MouseEnter += exit_button_MouseEnter;
            exit_button.MouseLeave += exit_button_MouseLeave;
            // 
            // menu_panel
            // 
            menu_panel.BackColor = Color.FromArgb(31, 31, 31);
            menu_panel.Controls.Add(menu_icon);
            menu_panel.Controls.Add(collapse_button);
            menu_panel.Controls.Add(menuStrip1);
            menu_panel.Controls.Add(exit_button);
            menu_panel.Dock = DockStyle.Top;
            menu_panel.Location = new Point(0, 0);
            menu_panel.Margin = new Padding(2);
            menu_panel.Name = "menu_panel";
            menu_panel.Size = new Size(1381, 27);
            menu_panel.TabIndex = 3;
            menu_panel.MouseDown += menu_panel_MouseDown;
            menu_panel.MouseMove += menu_panel_MouseMove;
            menu_panel.MouseUp += menu_panel_MouseUp;
            // 
            // menu_icon
            // 
            menu_icon.Dock = DockStyle.Left;
            menu_icon.Image = Properties.Resources.KkC1KZQYxzg;
            menu_icon.Location = new Point(0, 0);
            menu_icon.Margin = new Padding(2);
            menu_icon.Name = "menu_icon";
            menu_icon.Size = new Size(30, 27);
            menu_icon.SizeMode = PictureBoxSizeMode.Zoom;
            menu_icon.TabIndex = 4;
            menu_icon.TabStop = false;
            // 
            // collapse_button
            // 
            collapse_button.BackColor = Color.FromArgb(31, 31, 31);
            collapse_button.FlatAppearance.BorderSize = 0;
            collapse_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            collapse_button.FlatStyle = FlatStyle.Flat;
            collapse_button.ForeColor = Color.White;
            collapse_button.Location = new Point(1286, -2);
            collapse_button.Margin = new Padding(5, 3, 4, 3);
            collapse_button.Name = "collapse_button";
            collapse_button.Padding = new Padding(0, 0, 0, 3);
            collapse_button.RightToLeft = RightToLeft.No;
            collapse_button.Size = new Size(49, 28);
            collapse_button.TabIndex = 2;
            collapse_button.Text = "__";
            collapse_button.UseVisualStyleBackColor = false;
            collapse_button.Click += collapse_button_Click;
            collapse_button.MouseEnter += collapse_button_MouseEnter;
            collapse_button.MouseLeave += collapse_button_MouseLeave;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(14, 32);
            pictureBox.Margin = new Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(581, 575);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            pictureBox.MouseWheel += pictureBox_MouseWheel;
            // 
            // label_accuracy
            // 
            label_accuracy.AutoSize = true;
            label_accuracy.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_accuracy.ForeColor = Color.Black;
            label_accuracy.Location = new Point(287, 283);
            label_accuracy.Margin = new Padding(4, 0, 4, 0);
            label_accuracy.Name = "label_accuracy";
            label_accuracy.Size = new Size(115, 29);
            label_accuracy.TabIndex = 6;
            label_accuracy.Text = "Accuracy:";
            // 
            // textBox_Accuracy
            // 
            textBox_Accuracy.BackColor = Color.Silver;
            textBox_Accuracy.BorderStyle = BorderStyle.FixedSingle;
            textBox_Accuracy.Location = new Point(428, 288);
            textBox_Accuracy.Margin = new Padding(4, 3, 4, 3);
            textBox_Accuracy.Name = "textBox_Accuracy";
            textBox_Accuracy.Size = new Size(99, 23);
            textBox_Accuracy.TabIndex = 7;
            textBox_Accuracy.Text = "100";
            textBox_Accuracy.TextChanged += textBox_accuracy_TextChanged;
            // 
            // label_radius
            // 
            label_radius.AutoSize = true;
            label_radius.BackColor = Color.FromArgb(64, 64, 64);
            label_radius.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_radius.ForeColor = Color.Black;
            label_radius.Location = new Point(46, 283);
            label_radius.Margin = new Padding(4, 0, 4, 0);
            label_radius.Name = "label_radius";
            label_radius.Size = new Size(94, 29);
            label_radius.TabIndex = 8;
            label_radius.Text = "Radius:";
            // 
            // textBox_Radius
            // 
            textBox_Radius.BackColor = Color.Silver;
            textBox_Radius.BorderStyle = BorderStyle.FixedSingle;
            textBox_Radius.Location = new Point(162, 288);
            textBox_Radius.Margin = new Padding(4, 3, 4, 3);
            textBox_Radius.Name = "textBox_Radius";
            textBox_Radius.Size = new Size(99, 23);
            textBox_Radius.TabIndex = 9;
            textBox_Radius.Text = "1";
            textBox_Radius.TextChanged += textBox_radius_TextChanged;
            // 
            // label_main
            // 
            label_main.AutoSize = true;
            label_main.BackColor = Color.FromArgb(64, 64, 64);
            label_main.Font = new Font("Lucida Console", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_main.ForeColor = Color.Black;
            label_main.Location = new Point(8, 17);
            label_main.Margin = new Padding(4, 0, 4, 0);
            label_main.Name = "label_main";
            label_main.Size = new Size(467, 40);
            label_main.TabIndex = 10;
            label_main.Text = "Astroid graph menu";
            // 
            // menu_border
            // 
            menu_border.BackColor = Color.FromArgb(64, 64, 64);
            menu_border.Controls.Add(label8);
            menu_border.Controls.Add(label5);
            menu_border.Controls.Add(label7);
            menu_border.Controls.Add(label6);
            menu_border.Controls.Add(label2);
            menu_border.Controls.Add(label4);
            menu_border.Controls.Add(label3);
            menu_border.Controls.Add(label1);
            menu_border.Controls.Add(label_Graph_parametrs);
            menu_border.Controls.Add(label_intersection_error);
            menu_border.Controls.Add(textBox_LeftLimit);
            menu_border.Controls.Add(textBox_RightLimit);
            menu_border.Controls.Add(label_LeftLimit);
            menu_border.Controls.Add(label_RightLimit);
            menu_border.Controls.Add(label_mesuar);
            menu_border.Controls.Add(textBox_Radius);
            menu_border.Controls.Add(label_scaled_grid_mesuar);
            menu_border.Controls.Add(label_main);
            menu_border.Controls.Add(label_unit_scale);
            menu_border.Controls.Add(label_scaled_graph_mesuar);
            menu_border.Controls.Add(textBox_Accuracy);
            menu_border.Controls.Add(label_scale);
            menu_border.Controls.Add(label_radius);
            menu_border.Controls.Add(label_accuracy);
            menu_border.Location = new Point(828, 31);
            menu_border.Margin = new Padding(2);
            menu_border.Name = "menu_border";
            menu_border.Size = new Size(551, 613);
            menu_border.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(369, 89);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 31;
            label8.Text = "2/3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(281, 89);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 28;
            label5.Text = "2/3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(313, 100);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(27, 29);
            label7.TabIndex = 30;
            label7.Text = "=";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(218, 100);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(27, 29);
            label6.TabIndex = 29;
            label6.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(257, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 29);
            label2.TabIndex = 25;
            label2.Text = "Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(183, 89);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 27;
            label4.Text = "2/3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(344, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(30, 29);
            label3.TabIndex = 26;
            label3.Text = "R";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(158, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 29);
            label1.TabIndex = 24;
            label1.Text = "X";
            // 
            // label_Graph_parametrs
            // 
            label_Graph_parametrs.AutoSize = true;
            label_Graph_parametrs.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_Graph_parametrs.ForeColor = Color.Black;
            label_Graph_parametrs.Location = new Point(-1, 396);
            label_Graph_parametrs.Margin = new Padding(4, 0, 4, 0);
            label_Graph_parametrs.Name = "label_Graph_parametrs";
            label_Graph_parametrs.Size = new Size(208, 29);
            label_Graph_parametrs.TabIndex = 23;
            label_Graph_parametrs.Text = "Graph parametrs";
            // 
            // label_intersection_error
            // 
            label_intersection_error.AutoSize = true;
            label_intersection_error.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_intersection_error.ForeColor = Color.Black;
            label_intersection_error.Location = new Point(135, 237);
            label_intersection_error.Margin = new Padding(4, 0, 4, 0);
            label_intersection_error.Name = "label_intersection_error";
            label_intersection_error.Size = new Size(235, 17);
            label_intersection_error.TabIndex = 22;
            label_intersection_error.Text = "*Function dont intersection in limits!!!\r\n";
            label_intersection_error.Visible = false;
            // 
            // textBox_LeftLimit
            // 
            textBox_LeftLimit.BackColor = Color.Silver;
            textBox_LeftLimit.BorderStyle = BorderStyle.FixedSingle;
            textBox_LeftLimit.Location = new Point(162, 196);
            textBox_LeftLimit.Margin = new Padding(4, 3, 4, 3);
            textBox_LeftLimit.Name = "textBox_LeftLimit";
            textBox_LeftLimit.Size = new Size(99, 23);
            textBox_LeftLimit.TabIndex = 21;
            textBox_LeftLimit.Text = "-5";
            textBox_LeftLimit.TextChanged += textBox_leftLimit_TextChanged;
            // 
            // textBox_RightLimit
            // 
            textBox_RightLimit.BackColor = Color.Silver;
            textBox_RightLimit.BorderStyle = BorderStyle.FixedSingle;
            textBox_RightLimit.Location = new Point(428, 196);
            textBox_RightLimit.Margin = new Padding(4, 3, 4, 3);
            textBox_RightLimit.Name = "textBox_RightLimit";
            textBox_RightLimit.Size = new Size(99, 23);
            textBox_RightLimit.TabIndex = 19;
            textBox_RightLimit.Text = "5";
            textBox_RightLimit.TextChanged += textBox_RightLimit_TextChanged;
            // 
            // label_LeftLimit
            // 
            label_LeftLimit.AutoSize = true;
            label_LeftLimit.BackColor = Color.FromArgb(64, 64, 64);
            label_LeftLimit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_LeftLimit.ForeColor = Color.Black;
            label_LeftLimit.Location = new Point(29, 186);
            label_LeftLimit.Margin = new Padding(4, 0, 4, 0);
            label_LeftLimit.Name = "label_LeftLimit";
            label_LeftLimit.Size = new Size(108, 29);
            label_LeftLimit.TabIndex = 20;
            label_LeftLimit.Text = "Left limit:";
            // 
            // label_RightLimit
            // 
            label_RightLimit.AutoSize = true;
            label_RightLimit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_RightLimit.ForeColor = Color.Black;
            label_RightLimit.Location = new Point(280, 186);
            label_RightLimit.Margin = new Padding(4, 0, 4, 0);
            label_RightLimit.Name = "label_RightLimit";
            label_RightLimit.Size = new Size(125, 29);
            label_RightLimit.TabIndex = 18;
            label_RightLimit.Text = "Right limit:";
            // 
            // label_mesuar
            // 
            label_mesuar.AutoSize = true;
            label_mesuar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_mesuar.ForeColor = Color.Black;
            label_mesuar.Location = new Point(21, 440);
            label_mesuar.Margin = new Padding(4, 0, 4, 0);
            label_mesuar.Name = "label_mesuar";
            label_mesuar.Size = new Size(96, 26);
            label_mesuar.TabIndex = 17;
            label_mesuar.Text = "Mesuar: ";
            // 
            // label_scaled_grid_mesuar
            // 
            label_scaled_grid_mesuar.AutoSize = true;
            label_scaled_grid_mesuar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_scaled_grid_mesuar.ForeColor = Color.Black;
            label_scaled_grid_mesuar.Location = new Point(21, 530);
            label_scaled_grid_mesuar.Margin = new Padding(4, 0, 4, 0);
            label_scaled_grid_mesuar.Name = "label_scaled_grid_mesuar";
            label_scaled_grid_mesuar.Size = new Size(206, 26);
            label_scaled_grid_mesuar.TabIndex = 15;
            label_scaled_grid_mesuar.Text = "Scaled grid mesuar:";
            // 
            // label_unit_scale
            // 
            label_unit_scale.AutoSize = true;
            label_unit_scale.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_unit_scale.ForeColor = Color.Black;
            label_unit_scale.Location = new Point(21, 560);
            label_unit_scale.Margin = new Padding(4, 0, 4, 0);
            label_unit_scale.Name = "label_unit_scale";
            label_unit_scale.Size = new Size(114, 26);
            label_unit_scale.TabIndex = 14;
            label_unit_scale.Text = "Unit scale:";
            // 
            // label_scaled_graph_mesuar
            // 
            label_scaled_graph_mesuar.AutoSize = true;
            label_scaled_graph_mesuar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_scaled_graph_mesuar.ForeColor = Color.Black;
            label_scaled_graph_mesuar.Location = new Point(21, 500);
            label_scaled_graph_mesuar.Margin = new Padding(4, 0, 4, 0);
            label_scaled_graph_mesuar.Name = "label_scaled_graph_mesuar";
            label_scaled_graph_mesuar.Size = new Size(225, 26);
            label_scaled_graph_mesuar.TabIndex = 13;
            label_scaled_graph_mesuar.Text = "Scaled graph mesuar:";
            // 
            // label_scale
            // 
            label_scale.AutoSize = true;
            label_scale.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_scale.ForeColor = Color.Black;
            label_scale.Location = new Point(21, 470);
            label_scale.Margin = new Padding(4, 0, 4, 0);
            label_scale.Name = "label_scale";
            label_scale.Size = new Size(73, 26);
            label_scale.TabIndex = 12;
            label_scale.Text = "Scale:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(612, 244);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(99, 23);
            textBox1.TabIndex = 22;
            textBox1.Text = "-5";
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(674, 273);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(99, 23);
            textBox2.TabIndex = 23;
            textBox2.Text = "-5";
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Silver;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(612, 302);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(99, 23);
            textBox3.TabIndex = 24;
            textBox3.Text = "-5";
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Silver;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(674, 331);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(99, 23);
            textBox4.TabIndex = 25;
            textBox4.Text = "-5";
            textBox4.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(650, 372);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1381, 647);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox);
            Controls.Add(menu_panel);
            Controls.Add(menu_border);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(113, 96, 232);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(1381, 647);
            MinimumSize = new Size(1381, 647);
            Name = "Form1";
            Text = " ";
            Activated += Form1_Activated;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menu_panel.ResumeLayout(false);
            menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menu_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menu_border.ResumeLayout(false);
            menu_border.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItem_CreateNewProject;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItem_OpenProject;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItem_SaveInExcel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button collapse_button;
        private System.Windows.Forms.PictureBox menu_icon;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label_accuracy;
        private System.Windows.Forms.TextBox textBox_Accuracy;
        private System.Windows.Forms.Label label_radius;
        private System.Windows.Forms.TextBox textBox_Radius;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.Panel menu_border;
        private System.Windows.Forms.Label label_scale;
        private System.Windows.Forms.Label label_scaled_graph_mesuar;
        private System.Windows.Forms.Label label_unit_scale;
        private System.Windows.Forms.Label label_scaled_grid_mesuar;
        private System.Windows.Forms.Label label_mesuar;
        private System.Windows.Forms.TextBox textBox_LeftLimit;
        private System.Windows.Forms.TextBox textBox_RightLimit;
        private System.Windows.Forms.Label label_LeftLimit;
        private System.Windows.Forms.Label label_RightLimit;
        private System.Windows.Forms.Label label_intersection_error;
        private System.Windows.Forms.Label label_Graph_parametrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private ToolStripMenuItem stripMenuItem_AboutCreator;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}

