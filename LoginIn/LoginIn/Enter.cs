using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginIn
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //стр 76
        }
        private void tb3PassConf_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.TabIndex = 0;
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pUser;
            string pPass;

            pUser = textBox2.Text;
            //Поиск в базе. возврат значений 
            //объектов Username и Password
            //иначе msg(пользователь не найден)
            //если значение объекта Password совпадает с pPass
            //доступ разрешен
            //иначе пароль не верен, доступ запрещен.


            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Enter_Load(object sender, EventArgs e)
        {

        }
    }
}
