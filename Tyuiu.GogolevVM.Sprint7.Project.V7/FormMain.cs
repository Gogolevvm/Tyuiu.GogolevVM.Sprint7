using System.ComponentModel;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GogolevVM.Sprint7.Project.V7.Lib;
namespace Tyuiu.GogolevVM.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string filepath;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void labelVal_GVM_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownPods_GVM_ValueChanged(object sender, EventArgs e)
        {

        }
        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);
            FileData = FileData.Replace('\n', '\r');

            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_GVM_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogMain_GVM.ShowDialog();
                filepath = openFileDialogMain_GVM.FileName;

                string[,] arrayValues = new string[rows, columns];

                

                arrayValues = LoadFromFileData(filepath);
                dataGridViewBase_GVM.ColumnCount = columns;
                dataGridViewBase_GVM.RowCount = rows;
                
                
                for (int i = 0; i < columns; i++)
                {
                    dataGridViewBase_GVM.Columns[i].Width = 120;
                    dataGridViewBase_GVM.Columns[i].Width = 120;
                }

                for (int r = 0;r < rows;r++)
                {
                    for (int c = 0;c < columns;c++)
                    {
                        dataGridViewBase_GVM.Rows[r].Cells[c].Value = arrayValues[r,c];
                    }
                }


                buttonFiltCwi_GVM.Enabled = true;
                buttonSearch_GVM.Enabled = true;
                buttonDelete_GVM.Enabled = true;
                buttonSave_GVM.Enabled = true;
                buttonAdd_GVM.Enabled = true;
                buttonMin_GVM.Enabled = true;
                buttonMax_GVM.Enabled = true;
                buttonAverage_GVM.Enabled = true;
                buttonFlitCancel_GVM.Enabled = true;
                buttonFiltMoney_GVVM.Enabled = true;
                textBoxSearch_GVM.Enabled = true;
                textBoxMax_GVM.Enabled = true;
                textBoxMin_GVM.Enabled = true;
                textBoxAverage_GVM.Enabled = true;
                comboBoxFiltMoney_GVM.Enabled = true;
                buttonNum_GVM.Enabled = true;
                buttonGraph_GVM.Enabled = true;
                listBoxSort_GVM.Enabled = true;
                buttonVoz_GVM.Enabled = true;
                buttonUb_GVM.Enabled = true;
                numericUpDownFilCw_GVM.Enabled = true;
                numericUpDownPad_GVM.Enabled = true;
                numericUpDownPods_GVM.Enabled = true;
                textBoxFamilia_GVM.Enabled = true;
                dateTimePickerDate_GVM.Enabled = true;
                numericUpDownCw_GVM.Enabled = true;
                numericUpDownK_GVM.Enabled = true;
                numericUpDownVal_GVM.Enabled = true;
                numericUpDownChild_GVM.Enabled = true;
                comboBoxMoney_GVM.Enabled = true;
                numericUpDownFamily_GVM.Enabled = true;
                textBoxPrim_GVM.Enabled = true;
                buttonDelete_GVM.Enabled = true;
                buttonRed_GVM.Enabled = true;
                buttonAdd_GVM.Enabled = true;



                

            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_GVM_Click(object sender, EventArgs e)
        {
            saveFileDialog_GVM.FileName = "Base.csv";
            saveFileDialog_GVM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_GVM.ShowDialog();

            string path = saveFileDialog_GVM.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewBase_GVM.RowCount;
            int columns = dataGridViewBase_GVM.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewBase_GVM.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewBase_GVM.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);
                str = "";
            }
        }

        private void buttonDelete_GVM_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBase_GVM.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewBase_GVM.CurrentRow.Index;
                    dataGridViewBase_GVM.Rows.Remove(dataGridViewBase_GVM.Rows[a]);
                    if (dataGridViewBase_GVM.Rows.Count == 0)
                    {
                        dataGridViewBase_GVM.Rows.Clear();
                    }
                }
                if (dataGridViewBase_GVM.Rows.Count <= 1)
                {
                    buttonDelete_GVM.Enabled = false;
                    buttonSearch_GVM.Enabled = false;
                }
                if (dataGridViewBase_GVM.Rows.Count > 1)
                {
                    buttonDelete_GVM.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonViewBase_GVM_Click(object sender, EventArgs e)
        {
          FormGuide formGuide = new FormGuide();
          formGuide.ShowDialog();


        }

        private void buttonAdd_GVM_Click(object sender, EventArgs e)
        {
            if ((textBoxFamilia_GVM.Text == "") || (comboBoxMoney_GVM.Text == "") || (textBoxPrim_GVM.Text == ""))
            {
                MessageBox.Show("Введите все данные для продолжения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridViewBase_GVM.Rows.Add(Convert.ToString(numericUpDownPods_GVM.Value), textBoxFamilia_GVM.Text, dateTimePickerDate_GVM.Text, Convert.ToString(numericUpDownCw_GVM.Value), Convert.ToString(numericUpDownK_GVM.Value), Convert.ToString(numericUpDownPolVal_GVM.Value), Convert.ToString(numericUpDownVal_GVM.Value), Convert.ToString(numericUpDownChild_GVM.Value), comboBoxMoney_GVM.Text, Convert.ToString(numericUpDownFamily_GVM.Value), textBoxPrim_GVM);
            }
        }

        private void buttonVoz_GVM_Click(object sender, EventArgs e)
        {
            if (listBoxSort_GVM.Items.Count != 0)
            {
                if (listBoxSort_GVM.SelectedItem.ToString() == "Фамилия")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[1], ListSortDirection.Ascending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Дата прописки")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[2], ListSortDirection.Ascending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Номер квартиры")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[3], ListSortDirection.Ascending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Количество комнат")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[4], ListSortDirection.Ascending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Общая площадь")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[5], ListSortDirection.Ascending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Полезная площадь")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[6], ListSortDirection.Ascending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Количество детей")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[7], ListSortDirection.Ascending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Количество членов семьи")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[9], ListSortDirection.Ascending);
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент для сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUb_GVM_Click(object sender, EventArgs e)
        {
            if (listBoxSort_GVM.Items.Count != 0)
            {
                if (listBoxSort_GVM.SelectedItem.ToString() == "Фамилия")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[1], ListSortDirection.Descending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Дата прописки")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[2], ListSortDirection.Descending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Номер квартиры")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[3], ListSortDirection.Descending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Количество комнат")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[4], ListSortDirection.Descending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Общая площадь")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[5], ListSortDirection.Descending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Полезная площадь")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[6], ListSortDirection.Descending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Количество детей")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[7], ListSortDirection.Descending);
                }
                if (listBoxSort_GVM.SelectedItem.ToString() == "Количество членов семьи")
                {
                    dataGridViewBase_GVM.Sort(dataGridViewBase_GVM.Columns[9], ListSortDirection.Descending);
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент для сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_GVM_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewBase_GVM.RowCount; i++)
                {
                    dataGridViewBase_GVM.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewBase_GVM.ColumnCount; j++)

                        if (dataGridViewBase_GVM.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_GVM.Text))
                        {
                            dataGridViewBase_GVM.Rows[i].Selected = true;
                            break;
                        }

                }
            }
            catch
            {
                MessageBox.Show("Ошибка поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFiltMoney_GVVM_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBase_GVM.Rows)
            {
                string cellValue = row.Cells[8].Value.ToString();
                if (cellValue == comboBoxFiltMoney_GVM.SelectedItem.ToString())
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void buttonFlitCancel_GVM_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBase_GVM.Rows)
            {
                row.Visible = true;
            }
        }

        private void buttonNum_GVM_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBase_GVM.Rows)
            {
                string cellValue = row.Cells[0].Value.ToString();
                string num = Convert.ToString(numericUpDownPad_GVM.Value);
                if (numericUpDownPad_GVM.Value > 0)
                {
                    if (cellValue == num)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка фильтрации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRed_GVM_Click(object sender, EventArgs e)
        {
            int cur = dataGridViewBase_GVM.CurrentRow.Index;
            if ((textBoxFamilia_GVM.Text == "") || (comboBoxMoney_GVM.Text == "") || (textBoxPrim_GVM.Text == ""))
            {
                MessageBox.Show("Введите все данные для продолжения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridViewBase_GVM.Rows[cur].Cells[0].Value = Convert.ToSingle(numericUpDownPods_GVM.Value);
                dataGridViewBase_GVM.Rows[cur].Cells[1].Value = textBoxFamilia_GVM.Text;
                dataGridViewBase_GVM.Rows[cur].Cells[2].Value = dateTimePickerDate_GVM.Text;
                dataGridViewBase_GVM.Rows[cur].Cells[3].Value = Convert.ToString(numericUpDownCw_GVM.Value);
                dataGridViewBase_GVM.Rows[cur].Cells[4].Value = Convert.ToString(numericUpDownK_GVM.Value);
                dataGridViewBase_GVM.Rows[cur].Cells[5].Value = Convert.ToString(numericUpDownVal_GVM.Value);
                dataGridViewBase_GVM.Rows[cur].Cells[6].Value = Convert.ToString(numericUpDownPolVal_GVM.Value);
                dataGridViewBase_GVM.Rows[cur].Cells[7].Value = Convert.ToString(numericUpDownChild_GVM.Value);
                dataGridViewBase_GVM.Rows[cur].Cells[8].Value = comboBoxMoney_GVM.Text;
                dataGridViewBase_GVM.Rows[cur].Cells[9].Value = Convert.ToString(numericUpDownFamily_GVM.Value);
                dataGridViewBase_GVM.Rows[cur].Cells[10].Value = textBoxPrim_GVM.Text;
            }
        }

        private void buttonGraph_GVM_Click(object sender, EventArgs e)
        {
            chartFunc_GVM.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Area;
            foreach (DataGridViewRow row in dataGridViewBase_GVM.Rows)
            {

                double area = Convert.ToDouble(row.Cells[4].Value);
                int roomCount = Convert.ToInt32(row.Cells[5].Value);
                series.Points.AddXY(roomCount, area);
            }
            chartFunc_GVM.Series.Add(series);
            chartFunc_GVM.Show();
        }

        private void buttonMin_GVM_Click(object sender, EventArgs e)
        {
            double minValue = double.MaxValue;
            foreach (DataGridViewRow row in dataGridViewBase_GVM.Rows)
            {
                if (row.Cells[5].Value != null && row.Cells[5].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[5].Value);
                    if (cellValue < minValue)
                    {
                        minValue = cellValue;
                    }
                }
            }
            textBoxMin_GVM.Text = minValue.ToString();
        }

        private void buttonMax_GVM_Click(object sender, EventArgs e)
        {
            double maxValue = double.MinValue;
            foreach (DataGridViewRow row in dataGridViewBase_GVM.Rows)
            {
                if (row.Cells[5].Value != null && row.Cells[5].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[5].Value);
                    if (cellValue > maxValue)
                    {
                        maxValue = cellValue;
                    }
                }
            }
            textBoxMax_GVM.Text = maxValue.ToString();
        }

        private void buttonAverage_GVM_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int count = 0;

            foreach (DataGridViewRow row in dataGridViewBase_GVM.Rows)
            {
                if (row.Cells[5].Value != null && row.Cells[5].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[5].Value);
                    sum += cellValue;
                    count++;
                }
            }
            double average = sum / count;
            textBoxAverage_GVM.Text = Convert.ToString(Math.Round(average, 2));
        }

        private void buttonFiltCwi_GVM_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBase_GVM.Rows)
            {
                string cellValue = row.Cells[4].Value.ToString();
                string num = Convert.ToString(numericUpDownFilCw_GVM.Value);
                if (numericUpDownPad_GVM.Value > 0)
                {
                    if (cellValue == num)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Фильтрации ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonInfo_GVM_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }
    }
}
