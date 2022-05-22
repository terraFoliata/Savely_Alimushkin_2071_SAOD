using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAOD_1
{
    public partial class Form1 : Form
    {
        public Stack<int> my_stack;
        public int[] arr;
        public Form1()
        {
            InitializeComponent();
        }
        private bool NotEmpty(TextBox tb)
        {
            bool flag = false;
            if (tb.TextLength != 0)
                flag = true;
            return flag;
        }
        private void create_Click(object sender, EventArgs e)
        {
            if (NotEmpty(tb_create))
            {
                my_stack = new Stack<int>(Convert.ToInt32(tb_create.Text));
                st_arr.Clear();
                tb_create.Text = "Lenght(" + Convert.ToInt32(tb_create.Text) + ")";
            }
            else
            {
                MessageBox.Show("Не введено число");
            }
        }
        private void push_Click(object sender, EventArgs e)
        {
            if (NotEmpty(tb_push))
            {
                try
                {
                    my_stack.Push(Convert.ToInt32(tb_push.Text));
                    st_arr.Clear();
                    arr = my_stack.ToArray();
                    foreach (int i in arr)
                    {
                        st_arr.Text += i + "\r\n";
                    }
                    tb_push.Text = "";
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Не задан размер массива");
                }

            }
            else
            {
                MessageBox.Show("Не введено число");
            }
        }

        private void pop_Click(object sender, EventArgs e)
        {
            if (NotEmpty(st_arr))
            {
                tb_pop.Text = Convert.ToString(my_stack.Pop());
                st_arr.Clear();
                arr = my_stack.ToArray();
                foreach (int i in arr)
                {
                    st_arr.Text += i + "\r\n";
                }
                st_arr.Refresh();
            }
            else
                MessageBox.Show("Нет значений в массиве");
        }

        private void top_Click(object sender, EventArgs e)
        {
            if (NotEmpty(st_arr))
                tb_top.Text = Convert.ToString(my_stack.Pop());
            else
                MessageBox.Show("Нет значений в массиве");

        }
    }
}
