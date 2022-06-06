using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked=true;
            radioButton2.Checked = false;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] rows = new string[,]{ // 1   2     3     4 
                                             
                                              {"1","BLT 安格斯黑牛堡","1","119"}
                                          };


            for (int i = 0; i < rows.GetLength(0); i++)// array rows
            {
                string[] row = new string[rows.GetLength(1)];

                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    row[j] = rows[i, j];
                }
                dataGridView1.Rows.Add(row);




                //string[] c = { "benz", "bmw" };
                //string[] m = { "samsung", "iphone" };

                // if (comboBox1.Text == "car")
                //{
                // listBox1.Items.Clear();
                // listBox1.Items.AddRange(c);

                // };
                // if (comboBox1.Text == "mob")
                // {
                //  listBox1.Items.Clear();
                //  listBox1.Items.AddRange(m);


            };

            bool Found = false;
            
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // if (Convert.ToString(row.Cells[0].Value) == CmbProductName.Text)
                    if (Convert.ToString(row.Cells[1].Value) == dataGridView1.Name)

                        {
                        row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt16(row.Cells[2].Value));
                        Found = true;


                    }
                }

               
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] rows = new string[,]{ // 1   2     3     4 
                                             {"2","BLT 辣脆鷄腿堡","1","119"}

                                          };


            for (int i = 0; i < rows.GetLength(0); i++)// array rows
            {
                string[] row = new string[rows.GetLength(1)];

                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    row[j] = rows[i, j];
                }
                dataGridView1.Rows.Add(row);



                //string[] c = { "benz", "bmw" };
                //string[] m = { "samsung", "iphone" };

                // if (comboBox1.Text == "car")
                //{
                // listBox1.Items.Clear();
                // listBox1.Items.AddRange(c);

                // };
                // if (comboBox1.Text == "mob")
                // {
                //  listBox1.Items.Clear();
                //  listBox1.Items.AddRange(m);


            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[,] rows = new string[,]{ // 1   2     3     4 
                                             {"3","鷄腿中薯豪飽餐","1","204"}

                                          };


            for (int i = 0; i < rows.GetLength(0); i++)// array rows
            {
                string[] row = new string[rows.GetLength(1)];

                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    row[j] = rows[i, j];
                }
                dataGridView1.Rows.Add(row);



                //string[] c = { "benz", "bmw" };
                //string[] m = { "samsung", "iphone" };

                // if (comboBox1.Text == "car")
                //{
                // listBox1.Items.Clear();
                // listBox1.Items.AddRange(c);

                // };
                // if (comboBox1.Text == "mob")
                // {
                //  listBox1.Items.Clear();
                //  listBox1.Items.AddRange(m);


            };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            label6.Text = sum.ToString();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {

                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;

            }

            
        }

       
    }

    }

