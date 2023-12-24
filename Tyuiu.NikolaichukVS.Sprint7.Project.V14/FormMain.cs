using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.NikolaichukVS.Sprint7.Project.V14.Lib;
using System.IO;

namespace Tyuiu.NikolaichukVS.Sprint7.Project.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();


        private void buttonHelp_NVS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_NVS.ShowDialog();
                openFilePath = openFileDialog_NVS.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridView_NVS.RowCount = rows + 1;
                dataGridView_NVS.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView_NVS.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridView_NVS.AutoResizeColumns();
                dataGridView_NVS.ScrollBars = ScrollBars.Both;
                buttonSave_NVS.Enabled = true;
                buttonAdd_NVS.Enabled = true;
                buttonDelete_NVS.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_NVS_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_NVS.FileName = ".csv";
                saveFileDialog_NVS.InitialDirectory = @"C:\DataSprint5";
                if (saveFileDialog_NVS.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_NVS.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridView_NVS.RowCount;
                    int columns = dataGridView_NVS.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridView_NVS.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_NVS_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_NVS.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_NVS_Click(object sender, EventArgs e)
        {
            if (dataGridView_NVS.RowCount != 0)
            {
                int valueDel = 0;
                var res = MessageBox.Show($"{"Удалить данную строку?"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) valueDel = 1;
                if (valueDel == 1)
                {
                    int del = dataGridView_NVS.CurrentCell.RowIndex;
                    dataGridView_NVS.Rows.Remove(dataGridView_NVS.Rows[del]);
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_NVS_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch_NVS.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView_NVS.Rows)
            {
                if (row.IsNewRow) continue;

                bool found = false;

                for (int j = 0; j < dataGridView_NVS.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found;
            }
        }

        private void buttonInfo_NVS_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }
    }

       
        
    
}
