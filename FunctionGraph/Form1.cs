using OfficeOpenXml.Style;
using OfficeOpenXml;
using AstroidaCalc;
using FunctionGraph.Properties;


namespace FunctionGraph
{
    public partial class Form1 : Form
    {
        // PictureBox graphics
        Graphics graphics;
        Pen penBold;
        Pen penMedium;
        Pen penLight;
        Pen penSelector;

        // Drag the win form
        bool drag = false;
        Point mouseStart = new Point();

        // Grid configs
        const int grid_accuracy = 10;

        // Scales
        int mesuar = 0; // unit intervals

        double scale = 1.0f;          // Mesuar multiplier
        int scaled_graph_mesuar = 0; // Zoomed unit intervals
        int scaled_grid_mesuar = 0; // Zoomed grid intervals
        double unit_scale = 1.0f;  // Unit number multiplier

        const double s_dScrollValue = 0.1f; // scrol incriment/decriment step 


        // Function variables
        List<doublePoint> points = new List<doublePoint>();

        int accuracy = 100;
        int accuracy_limit = 10000;

        double leftLimit = -5.0f;
        double rightLimit = 5.0f;

        double radius = 1.0f;

        // Dialog windows
        SaveFileDialog saveFileDialog;
        OpenFileDialog openFileDialog;


        public Form1()
        {
            InitializeComponent();

            this.graphics = pictureBox.CreateGraphics();
            this.penBold = new Pen(Color.Black, 3);    // bold pen
            this.penMedium = new Pen(Color.Black, 2); // medium pen
            this.penLight = new Pen(Color.Gray, 1); // light pen

            this.penSelector = new Pen(Color.Red, 2); // Selector pen

            this.mesuar = Convert.ToInt32(Convert.ToDouble(pictureBox.Width) / grid_accuracy); // unit mesuar
            this.scaled_graph_mesuar = Convert.ToInt32(this.mesuar * scale);                  // Zoomed unit mesuar
            this.scaled_grid_mesuar = Convert.ToInt32(this.mesuar * scale * unit_scale);     // Zoomed grid mesuar


            this.saveFileDialog = new SaveFileDialog()
            {
                Title = "Сохранение таблицы значений функции",
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            this.openFileDialog = new OpenFileDialog()
            {
                Title = "Открытие таблицы значений функции",
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            points = Astroida.CalcGraph(this.accuracy, this.radius);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // render_pictureBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // render_pictureBox();
        }

        #region MenuItems
        private void stripMenuItem_CreateNewProject_Click(object sender, EventArgs e)
        {
            this.accuracy = 100;
            this.accuracy_limit = 10000;

            this.leftLimit = -5.0f;
            this.rightLimit = 5.0f;

            this.radius = 1.0f;

            textBox_LeftLimit.Text = this.leftLimit.ToString();
            textBox_RightLimit.Text = this.rightLimit.ToString();
            textBox_Radius.Text = this.radius.ToString();
            textBox_Accuracy.Text = this.accuracy.ToString();

            points = Astroida.CalcGraph(this.accuracy, this.radius);
            render_pictureBox();
        }
        private void stripMenuItem_OpenProject_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelRead(openFileDialog.FileName);
            }

            textBox_LeftLimit.Text = this.leftLimit.ToString();
            textBox_RightLimit.Text = this.rightLimit.ToString();
            textBox_Radius.Text = this.radius.ToString();
            textBox_Accuracy.Text = this.accuracy.ToString();

            points = Astroida.CalcGraph(this.accuracy, this.radius);
            render_pictureBox();
        }

        private void stripMenuItem_SaveInExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelSave(saveFileDialog.FileName);
            }
        }

        private void ExcelSave(string filePath)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage())
                {
                    //Add a new worksheet to the empty workbook
                    var worksheet = package.Workbook.Worksheets.Add("Astroida Graph");

                    worksheet.Cells["A1:H1"].EntireColumn.Width = 15;

                    //Add the headers
                    worksheet.Cells[1, 1].Value = "X";
                    worksheet.Cells[1, 2].Value = "Y";
                    worksheet.Cells[1, 5].Value = "Accuracy";
                    worksheet.Cells[1, 6].Value = "Left Limit";
                    worksheet.Cells[1, 7].Value = "Right Limit";
                    worksheet.Cells[1, 8].Value = "Radius";

                    worksheet.Cells["E2"].Value = this.accuracy;
                    worksheet.Cells["F2"].Value = this.leftLimit;
                    worksheet.Cells["G2"].Value = this.rightLimit;
                    worksheet.Cells["H2"].Value = this.radius;

                    worksheet.Cells["A1:B1"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells["E1:H1"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells["A1:I1"].Style.Font.Bold = true;



                    for (int i = 0; i < points.Count; ++i) //Add some items...
                    {
                        worksheet.Cells["A" + (i + 2)].Value = points[i].x;
                        worksheet.Cells["B" + (i + 2)].Value = points[i].y;
                    }

                    // Set some document properties
                    package.Workbook.Properties.Title = "Astroida Graph";

                    MessageBox.Show(filePath);
                    // Save our new workbook in the output directory and we are done!
                    package.SaveAs(filePath);
                }
            }
            catch
            {
                MessageBox.Show("Something goes wrong. Save error");
            }
        }

        public void ExcelRead(string filePath)
        {
            try
            {
                FileInfo existingFile = new FileInfo(filePath);
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    //get the first worksheet in the workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Astroida Graph"];

                    this.accuracy = Convert.ToInt32(worksheet.Cells["E2"].Text);
                    this.leftLimit = Convert.ToDouble(worksheet.Cells["F2"].Text);
                    this.rightLimit = Convert.ToDouble(worksheet.Cells["G2"].Text);
                    this.radius = Convert.ToDouble(worksheet.Cells["H2"].Text);

                }
            }
            catch
            {
                MessageBox.Show("Something goes wrong. Load error");
            }
        }

        private void stripMenuItem_AboutCreator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola senior. Creator of this program (task option 13) is Danil Mukhametov from 423 group");
        }

        #endregion MenuItems

        #region borderButtons
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            exit_button.BackColor = Color.Red;
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
        }

        private void collapse_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void collapse_button_MouseEnter(object sender, EventArgs e)
        {
            collapse_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(130)))));
        }

        private void collapse_button_MouseLeave(object sender, EventArgs e)
        {
            collapse_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
        }
        #endregion  borderButtons

        #region grip_lable
        private void menu_panel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouseStart = new Point(e.X, e.Y);

            this.Cursor = Cursors.SizeAll;
        }

        private void menu_panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            this.Cursor = Cursors.Default;
        }

        private void menu_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point currPos = PointToScreen(e.Location);
                this.Location = new Point(currPos.X - mouseStart.X, currPos.Y - mouseStart.Y);
            }

        }
        #endregion grip_lable

        #region Render
        private void render_pictureBox()
        {
            pictureBox.Refresh();

            draw_grid();

            draw_graph(points);

            label_mesuar.Text = "Mesuar: " + this.mesuar;

            label_scale.Text = "Scale: " + Math.Round(this.scale, 2);
            label_scaled_graph_mesuar.Text = "Scaled graph mesuar: " + this.scaled_graph_mesuar;

            label_scaled_grid_mesuar.Text = "Scaled grid mesuar: " + this.scaled_grid_mesuar;

            label_unit_scale.Text = "Unit scale: " + this.unit_scale;
        }

        private void draw_graph(List<doublePoint> points)
        {
            bool intersectionFlag = false;

            for (int i = 0; i < points.Count - 1; ++i)
            {
                if (draw_line(points[i], points[i + 1]))
                {
                    intersectionFlag = true;
                }
            }

            if (draw_line(points[points.Count - 1], new doublePoint(this.radius, 0)))
            {
                intersectionFlag = true;
            }

            label_intersection_error.Visible = !intersectionFlag;
        }

        private bool draw_line(doublePoint point1, doublePoint point2)
        {
            if (point1.x > this.leftLimit && point1.x < this.rightLimit && point2.x > this.leftLimit && point2.x < this.rightLimit)
            {
                graphics.DrawLine(this.penSelector,
                    Convert.ToInt32(point1.x * this.scaled_graph_mesuar) + pictureBox.Width / 2,
                    Convert.ToInt32(point1.y * this.scaled_graph_mesuar) + pictureBox.Height / 2,
                    Convert.ToInt32(point2.x * this.scaled_graph_mesuar) + pictureBox.Width / 2,
                    Convert.ToInt32(point2.y * this.scaled_graph_mesuar) + pictureBox.Height / 2);
                return true;
            }
            else
            {
                graphics.DrawLine(this.penMedium,
                    Convert.ToInt32(point1.x * this.scaled_graph_mesuar) + pictureBox.Width / 2,
                    Convert.ToInt32(point1.y * this.scaled_graph_mesuar) + pictureBox.Height / 2,
                    Convert.ToInt32(point2.x * this.scaled_graph_mesuar) + pictureBox.Width / 2,
                    Convert.ToInt32(point2.y * this.scaled_graph_mesuar) + pictureBox.Height / 2);
            }
            return false;
        }

        private void draw_grid()
        {
            Point centerPoint = new Point(Convert.ToInt32(Convert.ToDouble(pictureBox.Width) / 2), Convert.ToInt32(Convert.ToDouble(pictureBox.Height) / 2));

            // Draw x-axis
            graphics.DrawLine(penBold,
                new Point(0, centerPoint.Y),
                new Point(pictureBox.Width, centerPoint.Y)
                );

            // Draw y-axis
            graphics.DrawLine(penBold,
                new Point(centerPoint.X, 0),
                new Point(centerPoint.X, pictureBox.Height)
                );

            int i = 0;
            while (this.scaled_grid_mesuar * i < pictureBox.Width + centerPoint.X) // Draw y-axis
            {
                // Draw positive y-axis
                graphics.DrawLine(penLight,
                    new Point(centerPoint.Y + this.scaled_grid_mesuar * i, 0),
                    new Point(centerPoint.Y + this.scaled_grid_mesuar * i, pictureBox.Height)
                    );

                // Draw negative y-axis
                graphics.DrawLine(penLight,
                    new Point(centerPoint.Y + this.scaled_grid_mesuar * -i, 0),
                    new Point(centerPoint.Y + this.scaled_grid_mesuar * -i, pictureBox.Height)
                    );

                graphics.DrawString(Convert.ToString(i * unit_scale), Font, new SolidBrush(Color.Black), new Point(centerPoint.Y + this.scaled_grid_mesuar * i, Convert.ToInt32(Convert.ToDouble(pictureBox.Height) / 2)));
                graphics.DrawString(Convert.ToString(-i * unit_scale), Font, new SolidBrush(Color.Black), new Point(centerPoint.Y + this.scaled_grid_mesuar * -i, Convert.ToInt32(Convert.ToDouble(pictureBox.Height) / 2)));

                i++;
            }

            i = 0;
            while (this.scaled_grid_mesuar * i < pictureBox.Height + centerPoint.Y) // Draw x-axis
            {
                // Draw positive x-axis
                graphics.DrawLine(penLight,
                    new Point(0, centerPoint.Y + this.scaled_grid_mesuar * i),
                    new Point(pictureBox.Width, centerPoint.Y + this.scaled_grid_mesuar * i)
                    );

                // Draw negative x-axis
                graphics.DrawLine(penLight,
                    new Point(0, centerPoint.Y + this.scaled_grid_mesuar * -i),
                    new Point(pictureBox.Width, centerPoint.Y + this.scaled_grid_mesuar * -i)
                    );

                graphics.DrawString(Convert.ToString(i * unit_scale), Font, new SolidBrush(Color.Black), new Point(Convert.ToInt32(Convert.ToDouble(pictureBox.Width) / 2), centerPoint.Y + this.scaled_grid_mesuar * -i));
                graphics.DrawString(Convert.ToString(-i * unit_scale), Font, new SolidBrush(Color.Black), new Point(Convert.ToInt32(Convert.ToDouble(pictureBox.Width) / 2), centerPoint.Y + this.scaled_grid_mesuar * i));

                i++;
            }

        }
        #endregion Render

        #region EnterParametrs
        private void textBox_leftLimit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.leftLimit = Convert.ToDouble(textBox_LeftLimit.Text);
            }
            catch
            {
            }

            render_pictureBox();
        }

        private void textBox_RightLimit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.rightLimit = Convert.ToDouble(textBox_RightLimit.Text);
            }
            catch
            {
            }

            render_pictureBox();
        }

        private void textBox_accuracy_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.accuracy = Convert.ToInt32(textBox_Accuracy.Text);
                if (this.accuracy > this.accuracy_limit)
                {
                    textBox_Accuracy.Text = "";
                    textBox_Accuracy.AppendText(Convert.ToString(this.accuracy_limit));
                }
            }
            catch
            {
            }

            points = Astroida.CalcGraph(this.accuracy, this.radius);
            render_pictureBox();
        }

        private void textBox_radius_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.radius = Convert.ToDouble(textBox_Radius.Text);
            }
            catch
            {
            }

            points = Astroida.CalcGraph(this.accuracy, this.radius);
            render_pictureBox();
        }
        #endregion EnterParametrs

        #region Zoom

        void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                // Scale linear increse or decrese by pulusing s_dScrollValue
                double newScale = this.scale + (e.Delta > 0 ? s_dScrollValue : -s_dScrollValue);

                if (newScale != this.scale)
                {
                    // Scale can be in this diapazone (-∞; -1]U[1; ∞) 
                    if (newScale > -1 && newScale < 1)
                    {
                        if (newScale > this.scale)
                        {
                            newScale = 1;
                        }
                        else
                        {
                            newScale = -1;
                        }
                    }
                    this.scale = newScale;

                    // Scale units 
                    if (this.scaled_grid_mesuar > this.mesuar * 2)
                    {
                        unit_scale /= 2;
                    }
                    else if (this.scaled_grid_mesuar < this.mesuar / 1.5)
                    {
                        unit_scale *= 2;
                    }

                    // Scale mesures
                    if (this.scale > 0)
                    {
                        this.scaled_graph_mesuar = Convert.ToInt32(this.mesuar * this.scale);
                        this.scaled_grid_mesuar = Convert.ToInt32(this.mesuar * this.scale * unit_scale);
                    }
                    else
                    {
                        this.scaled_graph_mesuar = Convert.ToInt32(this.mesuar / -this.scale);
                        this.scaled_grid_mesuar = Convert.ToInt32(this.mesuar / -this.scale * unit_scale);
                    }

                }

                render_pictureBox();
            }
        }


        #endregion Zoom
    }
}
