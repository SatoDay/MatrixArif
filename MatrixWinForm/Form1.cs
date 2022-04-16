using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixWinForm
{
    public partial class Form1 : Form
    {
        private int razmer=3, condition = 1;
        private DataGridView active_datagridview;
        private double[,] array1, array2, array_result, active_array;
        public Form1()
        {
            InitializeComponent();
            OpredelitelLabel.Show();
            checkBox1.Checked = true;
            groupBox2.Enabled = false;
            
            
            textBox2.Hide();
            label2.Hide();

            //OpredelitelLabel.Hide();

            textBox1.Text = "3";
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.Width = 30;
            foreach (DataGridViewColumn column in dataGridView2.Columns)
                column.Width = 30;

            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView1.RowCount = razmer;
            dataGridView1.ColumnCount = razmer;
            
            dataGridView2.RowCount = razmer;
            dataGridView2.ColumnCount = razmer;

            active_datagridview = dataGridView1;
            //int[,] array1 = new int[razmer, razmer];
            //int[,] array2 = new int[razmer, razmer];
            //Random rand = new Random();
            //for (int i = 0; i < razmer; i++)
            //    for (int j = 0; j < razmer; j++)
            //    {
            //        array1[i, j] = rand.Next(-100, 100);
            //        array2[i, j] = rand.Next(-100, 100);
            //    }
            //for (int i = 0; i < razmer; i++)
            //    for (int j = 0; j < razmer; j++)
            //    {
            //        dataGridView1.Rows[i].Cells[j].Value = array1[i, j].ToString();
            //        dataGridView2.Rows[i].Cells[j].Value = array2[i, j].ToString();
            //    }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//засунуть проверку в функцию
        {
            dataGridView3.Rows.Clear();
            if (checkBox1.Checked && checkBox2.Checked)
            {
                condition = 2;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
            else if (checkBox1.Checked || checkBox2.Checked)
            {
                condition = 1;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
            else
            {
                condition = 0;
                groupBox2.Enabled = false;
                groupBox1.Enabled = false;
            }
            if (condition == 1 && checkBox2.Checked)
                active_datagridview = dataGridView2;
            else if (condition == 1 && checkBox1.Checked)
                active_datagridview = dataGridView1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//засунуть проверку в функцию
        {
            dataGridView3.Rows.Clear();
            if (checkBox1.Checked && checkBox2.Checked)
            {
                condition = 2;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
            else if (checkBox1.Checked || checkBox2.Checked)
            {
                condition = 1;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
            else
            {
                condition = 0;
                groupBox2.Enabled = false;
                groupBox1.Enabled = false;
            }
            if (condition == 1 && checkBox1.Checked)
                active_datagridview = dataGridView1;
            else if (condition == 1 && checkBox2.Checked)
                active_datagridview = dataGridView2;
        }

        private void stepen_CheckedChanged(object sender, EventArgs e)
        {
            if (IsEmpty(active_datagridview))
                Operations();

            if((sender as RadioButton).Checked)
            {
                textBox2.Show();
                label2.Show();
            }
            else 
            {
                textBox2.Hide();
                label2.Hide();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (IsEmpty(active_datagridview))
                Operations();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)//if the cell is empty after editing, then the value of the cell is 0
            {
                (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                array2[e.RowIndex, e.ColumnIndex] = 0;
            }
            else
                array2[e.RowIndex, e.ColumnIndex] = double.Parse(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());


            if (IsEmpty(dataGridView2))
                Operations();
        }

        private void sum_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (IsEmpty(dataGridView1) && IsEmpty(dataGridView2))
                Operations();
        }

        private void sub_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (IsEmpty(dataGridView1) && IsEmpty(dataGridView2))
                Operations();
        }

        private void mult_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (IsEmpty(dataGridView1) && IsEmpty(dataGridView2))
                Operations();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "2";
            razmer = int.Parse(textBox1.Text);
            dataGridView1.RowCount = razmer;
            dataGridView1.ColumnCount = razmer;
            dataGridView2.RowCount = razmer;
            dataGridView2.ColumnCount = razmer;
            //for (int i = 0; i < razmer; i++)
            //{
            //    for (int j = 0; j < razmer; j++)
            //    {
            //        dataGridView1.Rows[i].Cells[j].Value = array1[i, j].ToString();
            //        dataGridView2.Rows[i].Cells[j].Value = array2[i, j].ToString();
            //    }
            //}
            //dataGridView2.DataSource = array2;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.Width = 30;
            foreach (DataGridViewColumn column in dataGridView2.Columns)
                column.Width = 30;
            array1 = new double[razmer, razmer];
            array2 = new double[razmer, razmer];
        }

        private void opredel_CheckedChanged(object sender, EventArgs e)
        {
            if (IsEmpty(active_datagridview))
            {
                Operations();
            }

            if ((sender as RadioButton).Checked)
            {
                OpredelitelLabel.Show();
            }
            else
            {
                OpredelitelLabel.Hide();
            }
        }

        private void rank_CheckedChanged(object sender, EventArgs e)
        {
            if (IsEmpty(active_datagridview))
            {
                Operations();
            }
            if ((sender as RadioButton).Checked)
            {
                OpredelitelLabel.Show();
            }
            else
            {
                OpredelitelLabel.Hide();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)//if the cell is empty after editing, then the value of the cell is 0
            {
                (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                array1[e.RowIndex, e.ColumnIndex] = 0;
            }
            else
                array1[e.RowIndex, e.ColumnIndex] = double.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()); 


            if (IsEmpty(dataGridView1))
                Operations();
        }

        private void Operations()
        {
            dataGridView3.ColumnHeadersVisible = false;
            dataGridView3.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dataGridView3.Columns)
                column.Width = 30;
            dataGridView3.RowCount = razmer;
            dataGridView3.ColumnCount = razmer;

            if (condition == 1)
            {
                active_array = new double[razmer, razmer];
                if (checkBox1.Checked)
                    active_array = array1;
                if (checkBox2.Checked)
                    active_array = array2;
                if (transpon.Checked)
                    array_result = SingleOper.Transpon(razmer, active_array);
                else if (stepen.Checked)
                {
                    int stepen = int.Parse(textBox2.Text);
                    array_result = SingleOper.Square(razmer, active_array, stepen);
                }
                else if (opredel.Checked)
                {
                    OpredelitelLabel.Text = ("Определитель: "+SingleOper.Opredelitel(razmer, active_array).ToString());
                    array_result = active_array;
                }
                else if (rank.Checked){
                    array_result = active_array;
                    OpredelitelLabel.Text = ("Ранг матрицы: " + SingleOper.Rank(razmer, active_array).ToString());
                }
                
            }
            else if(condition == 2 && (IsEmpty(dataGridView1) && (IsEmpty(dataGridView2))))
            {
                if (sum_rbtn.Checked)
                    array_result = SingleOper.Addition(array1, array2, razmer);
                else if (sub_rbtn.Checked)
                    array_result = SingleOper.Subtraction(array1, array2, razmer);
                else if (mult_rbtn.Checked)
                    array_result = SingleOper.Multiplication(array1, array2, razmer);
            }


            try
            {
                for (int i = 0; i < razmer; i++)//print result
                {
                    for (int j = 0; j < razmer; j++)
                    {
                        dataGridView3.Rows[i].Cells[j].Value = array_result[i, j].ToString();
                    }
                }
            }
            catch
            {

            }
        }

        private bool IsEmpty(DataGridView datagridview)
        {
            for (int i = 0; i < razmer; i++)
            {
                for (int j = 0; j < razmer; j++)
                {
                    if (datagridview.Rows[i].Cells[j].Value == null)
                        return false;
                }
            }
            return true;
        }

        private double[,] Array_Resize(double[,] array, int razmer)
        {
            double[,] array_res = new double[razmer, razmer];
            for (int i = 0; i < razmer; i++)
            {
                for (int j = 0; j < razmer; j++)
                {
                    array_res[i, j] = array[i, j];
                }
            }
            return array_res;
        }
    }
}
