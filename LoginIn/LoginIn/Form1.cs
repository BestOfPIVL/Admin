﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Windows;

namespace LoginIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string KodAdmina = "123";

        string[] Status = { "Студент", "Преподаватель", "Администратор" };
        string[] Faculty = {"Физико-математический","Естественно-географический",
                "Истории и права","Психолого-педагогический","Социологический",
                "Филологический","Художественно-графический",
                "Экономики и управления", "Дополнительного образования"};


        string[] SpecDopO =
        {"Теология (История русской Православной Церкви нового и новейшего времени)" };

        string[] SpecFizM = { /*очная бакалавр*/"Прикладная информатика (Прикладная информатика в логистике)",
            "Прикладная математика и информатика (Математическое и информационное моделирование)",
            "Строительство (Промышленное и гражданское строительство)",
            "Педагогическое образование (с двумя профилями подготовки) (Математика, информатика)",
            "Педагогическое образование (с двумя профилями подготовки) (Физика, информатика)",
            "Интеллектуальный системы в гуманитарной сферы (Интеллектуальные системы и машинное обучение)",
            /*очная магистр*/ "Прикладная математика и информатика (Прикладные Интернет-технологии)",
            "Математика и компьютерные науки (Прикладной статистический анализ)",
            "Математика и компьютерные науки (Комплексный анализ и приложения)",
            "Педагогическое образование (Технология цифровизации образования)"
            /*очная аспирант*/
            /*заочная магистр*/};


        string[] SpecEstG = { /*очная бакалавр*/"Экология и природопользование (Экология и природопользование)",
            "Землеустройство и кадастры (Кадастр недвижимости)",
            "Ландшафтная архитектура (Декоративное растениеводство)",
            "Педагогическое образование (География)",
            "Педагогическое образование (с двумя профилями подготовки)(Биология, химия)",
            "Педагогическое образование (с двумя профилями подготовки)(Биология, география)",
            /*заочная бакалавр*/"Туризм (Технология и организация туроператорских и турагентских услуг)",
            /*заочная магистр*/"Экология и природопользование (Контроль и надзор в области охраны окружающей среды)",
            "География (Страноведение и международный туризм)" };

        string[] SpecIstP = {/*очная бакалавр*/"Юриспруденция (Правоприменительная деятельность)",
            "Международные отношения (Мировая и региональная политика)",
            "История (Отечественная и всеобщая история)",
            "Педагогическое образование (с двумя профилями подготовки)(История, право)",
            /*очная магистр*/"Юриспруденция (Уголовное право, уголовный процесс)",
            "История (Россия и Европа: история государственного строительства и гражданских институтов)",
                             /*очная аспирант*/
                             /*заочная бакалавр*/"Педагогическое образование (История)",
            /*заочная магистр*/"Юриспруденция (Государственное право и управление)",
            "Юриспруденция (Гражданское право, гражданский процесс)"
                             /*заочная аспирант*/};

        string[] SpecPsiP = {/*очная бакалавр*/"Психология (Психологическое консультирование)",
            "Специальное (дефектологическое) образование (Логопедия)",
            "Психолого-педагогическое образование (Психология в образовании)",
            "Психолого-педагогическое образование (Дошкольное образование)",
            "Психолого-педагогическое образование (Начальное общее образование)",
            /*очная магистр*/"Специальное (дефектологическое) образование (Логопедическое образование)",
            "Психолого-педагогическое образование (Обучение и развитие младших школьников)",
            "Психолого-педагогическое образование (Психология в социально-педагогичсекой практике)",
            "Психолого-педагогическое образование (Психология и педагогика развития дошкольников)",
                             /*очная аспирант*/
                             /*заочная бакалавр*/
            /*заочная магистр*/"Психология (Детская и семейная психокоррекция)",
            "Психология (Клиническая психология)"
                             /*заочная аспирант*/};

        string[] SpecSoc = {/*очная бакалавр*/"Конфликтология (Социальная конфликтология)",
            "Социология (Прикладная социология)",
            "Социология (Политтехнологии и маркетинг)",
            "Социальная работа (Социальная работа в государственных и негосударственных организациях)",
            "Организация работы с молодежью (Работа с молодежью в образовательных и культурно-досуговых организациях)",
            "Психолого-педагогическое образование (Социальная педагогика)",
            /*очная магистр*/"Социология (Социология в управлении социокультурными процессами)",
            "Социология (Социологический анализ в экономике, политике и праве)",
            "Социальная работа (Социально-проектная деятельность)",
                             /*очная аспирант*/
                             /*заочная бакалавр*/"Социология (Социологическое сопровождение в политике и экономике)",
            "Социальная работа (Социальная работа в системе социальной защиты)"
                             /*заочная магистр*/
                             /*заочная аспирант*/ };

        string[] SpecFil = {/*очная бакалавр*/"Журналистика (Периодическая печать)",
            "Лингвистика (Перевод и переводоведение)",
            "Педагогическое образование (с двумя профилями подготовки)(Английский язык, французский язык)",
            "Педагогическое образование (с двумя профилями подготовки)(Немецкий язык, английский язык)",
            "Педагогическое образование (с двумя профилями подготовки)(Французский язык, английский язык)",
            "Педагогическое образование (с двумя профилями подготовки)(Русский язык, литература)",
            /*очная магистр*/"Педагогическое образование (Литературное образование)",
            "Филология (Русский язык)",
            "Филология (Филологическое творчество, критика и редактирование)",
                             /*очная аспирант*/
                             /*заочная бакалавр*/"Педагогическое образование (Русский язык)",
                             /*заочная магистр*/"Филология (Русская литература)"
                             /*заочная аспирант*/ };

        string[] SpecHudG = {/*очная бакалавр*/"Дизайн (Дизайн среды)",
            "Педагогическое образование (с двумя профилями подготовки)(Изобразительное искусство, декоративно-прикладное искусство)",
            "Дизайн архитектурной среды (Комплексное проектирование архитектурно-пространственной среды)",
            /*очная магистр*/"Педагогическое образование (Художественное образование)",
                             /*очная аспирант*/
                             /*заочная бакалавр*/
                             /*заочная магистр*/"Дизайн (Графический дизайн)"
                             /*заочная аспирант*/ };

        string[] SpecEconU = {/*очная бакалавр*/"Экономика (Финансы и кредит)",
            "Экономика (Цифровая экономика)",
            "Менеджмент (Таможенная логистика)",
            "Менеджмент (Информационно-аналитическое управление бизнесом и государственной сферой)",
            "Экономическая безопасность (Экономико-правовое обеспечение экономической безопасности)",
            /*очная магистр*/"Экономика (Экономика фирмы)",
            "Менеджмент (Управление проектами и инвестициями)",
            "Педагогическое образование (Образовательный менеджмент)",
                             /*очная аспирант*/
            /*заочная бакалавр*/"Экономика (Финансы организации)",
            "Менеджмент (Производственный менеджмент)",
            /*заочная магистр*/"Экономика (Бухгалтерский учет и налогообложение)",
            "Менеджмент (Маркетинг и управление продажами)",
            "Менеджмент (Управление человеческими ресурсами)",
            "Государственное и муниципальное управление (Современные технологии " +"\n"+
                "государственного и муниципального управления)",
            "Государственный аудит (Финансовое регулирование и контроль)"
                            /*заочная аспирант*/ };

        private void Form1_Load(object sender, EventArgs e)
        {
           // textBox1.Text = dataGridView1.Rows.Count.ToString();
           // dataGridView1.RowHeadersVisible = false;
            tb1Username.Enabled = true;
            tb2Password.Enabled = false;
            tb3PassConf.Enabled = false;
            cb4Status.Enabled = false;
            cb5Faculty.Enabled = false;
            cb6Spec.Enabled = false;
            tb7Year.Enabled = false;
            tb8Mail.Enabled = false;

            label10.Visible = false;
            textBox2.Visible = false;
            label10.Enabled = false;
            textBox2.Enabled = false;
            label14.Visible = false;
            label12.Visible = false;

            tb1Username.MaxLength = 35;
            tb2Password.MaxLength = 20;
            tb3PassConf.MaxLength = 20;
            tb7Year.MaxLength = 4;
                    

            for (int i = 0; i < Status.Length; i++)
            {
                cb4Status.Items.Add(Status[i]);
            }
            for (int j = 0; j < Faculty.Length; j++)
            {
                cb5Faculty.Items.Add(Faculty[j]);
            }
           
            string fmf = cb5Faculty.Items[0].ToString(); 
            //  groupBox1.Visible = false;
            // dataGridView1.Visible = false;

        }

        private void cb4Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb4Status.Text == "Администратор")
            {   cb5Faculty.Enabled = false;
                cb6Spec.Enabled = false;
                cb5Faculty.Visible = false;
                cb6Spec.Visible = false;
                tb7Year.Enabled = false;
                tb7Year.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                label7.Visible = false;


                label10.Visible = true;
                textBox2.Visible = true;
                label10.Enabled = true;
                textBox2.Enabled = true;
                label14.Visible = true;
            }
            if (cb4Status.Text == "Преподаватель")
            {
                cb5Faculty.Enabled = false;
                cb6Spec.Enabled = false;
            }
            else
            {
                cb5Faculty.Enabled = true;
                cb6Spec.Enabled = true;
            }
        }

        private void Cb5Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb6Spec.Items.Clear();
            if (cb5Faculty.Text == "Физико-математический")
            {
                for (int t = 0; t < SpecFizM.Length; t++)
                {
                    cb6Spec.Items.Add(SpecFizM[t]);
                }

            }
            if (cb5Faculty.Text == "Естественно-географический")
            {
               for (int t = 0; t < SpecEstG.Length; t++)
                {
                    cb6Spec.Items.Add(SpecEstG[t]);
                }

            }
            if (cb5Faculty.Text == "Истории и права")
            {
                for (int t = 0; t < SpecIstP.Length; t++)
                {
                    cb6Spec.Items.Add(SpecIstP[t]);
                }

            }
            if (cb5Faculty.Text == "Психолого-педагогический")
            {
                for (int t = 0; t < SpecPsiP.Length; t++)
                {
                    cb6Spec.Items.Add(SpecPsiP[t]);
                }

            }
            if (cb5Faculty.Text == "Социологический")
            {
                for (int t = 0; t < SpecSoc.Length; t++)
                {
                    cb6Spec.Items.Add(SpecSoc[t]);
                }

            }
            if (cb5Faculty.Text == "Филологический")
            {
                for (int t = 0; t < SpecFil.Length; t++)
                {
                    cb6Spec.Items.Add(SpecFil[t]);
                }

            }
            if (cb5Faculty.Text == "Художественно-графический")
            {
                for (int t = 0; t < SpecHudG.Length; t++)
                {
                    cb6Spec.Items.Add(SpecHudG[t]);
                }

            }
            if (cb5Faculty.Text == "Экономики и управления")
            {
                for (int t = 0; t < SpecEconU.Length; t++)
                {
                    cb6Spec.Items.Add(SpecEconU[t]);
                }

            }
            if (cb5Faculty.Text == "Дополнительного образования")
            {
                for (int t = 0; t < SpecDopO.Length; t++)
                {
                    cb6Spec.Items.Add(SpecDopO[t]);
                }
             }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (KodAdmina == textBox2.Text)
            { /*ничего не происходит*/ }
            else
            {
              label14.Text = "Похоже, Вы совсем не админушка.";
            }
              label0.Text = "";
     //       int n = dataGridView1.Rows.Count; определение количества строк

            if (tb2Password.Text == tb3PassConf.Text)
            {
                label11.Text = "Пароли совпадают";
            }
            else
            {
                label11.Text = "Пароли не совпадают";
            }
            try
            {
                int Value = Convert.ToInt32(tb7Year.Text);
                if (((tb7Year.Text.Length == 4) && (Value > 1900) && (Value < 2020)))
                { }
                else
                {
                    label12.Text = " Вы уверены, что это Ваш год поступления?";
                }
            }
            catch { label12.Text = " Вы уверены, что это Ваш год поступления?"; }
            
            foreach (Control ctrl in Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    if (ctrl.Text == "")
                    {
                        label0.Text = "Некоторые поля не заполнены.";
                    }
            }
            // dataGridView1.AllowUserToAddRows = true;
            //  dataGridView1.Rows[1].Cells[2].Value = textBox1.Text;

        }



        private void label9_Click(object sender, EventArgs e)
        {
            //http://xn--d1aiecikab7a.xn--p1ai/json_csharp/
            //https://jsoneditoronline.org/
            // tb1Username.Text  отправляем строку для проверки.
            Login myLog = new Login();
            string serialized = JsonConvert.SerializeObject(myLog);
            if (tb1Username.Text == serialized)
            {
                label13.Text = "Такой логин уже существует. Придумайте другой.";
            }
            if (tb1Username.Text != serialized)
            {
                label0.Text = "Ваш логин оригинален!";
                tb2Password.Enabled = true;
                tb3PassConf.Enabled = true;
                cb4Status.Enabled = true;
                cb5Faculty.Enabled = true;
                cb6Spec.Enabled = true;
                tb7Year.Enabled = true;
                tb8Mail.Enabled = true;
            }
        }
        private void tb7Year_KeyPress(object sender, KeyPressEventArgs e)
        {   //ограничением диапазоном
            //ввод чисел
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            
        }

    









       private void label1_Click(object sender, EventArgs e)
        { }
       private void tb7Year_TextChanged(object sender, EventArgs e)
        { }
       private void cb6Spec_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void tb8Mail_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}