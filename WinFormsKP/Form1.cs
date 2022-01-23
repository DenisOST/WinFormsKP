using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsKP
{
    public partial class Form1 : Form
    {
        int ID = 0;
        static int Num;
        Patient Patient1 = new Patient();
        Doctor[] DoctorMas = new Doctor[10];
        Doctor DoctorSelect = new Doctor();
        static Question[] Question1 = new Question[2];
        Form2 form2 = new Form2(Question1, Num);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoctorMas[0] = new Doctor("Сергеев", "Юрий", "Владимирович", "Терапевт");
            DoctorMas[1] = new Doctor("Буянов", "Виталий", "Юрьевич", "Проктолог");
            
            this.ComboBoxSelectDoctor.Items.AddRange(new string[] { DoctorMas[0].GetSpecialization() + ": " + DoctorMas[0].GetSurname() + " " + DoctorMas[0].GetName() + " " + DoctorMas[0].GetPatronymic(), DoctorMas[1].GetSpecialization() + ": " + DoctorMas[1].GetSurname() + " " + DoctorMas[1].GetName() + " " + DoctorMas[1].GetPatronymic() });
        }

        private void ComboBoxSelectDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = ComboBoxSelectDoctor.SelectedItem.ToString();
            int i = 0;
            while (DoctorMas[i] != null && i < 10)
            {
                if (DoctorMas[i].GetSpecialization() + ": " + DoctorMas[i].GetSurname() + " " + DoctorMas[i].GetName() + " " + DoctorMas[i].GetPatronymic() == selectedState)
                {
                    DoctorSelect = DoctorMas[i];
                    ID = i;
                }
                i++;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (TextBoxSurnamePatient.TextLength == 0 || TextBoxNamePatient.TextLength == 0 || TextBoxPatronymicPatient.TextLength == 0 || DoctorSelect.GetSpecialization() == "")
            {
                MessageBox.Show("Вы ввели не все данные!", "Error");
            }
            else
            {
                Patient1.Set(TextBoxSurnamePatient.Text, TextBoxNamePatient.Text, TextBoxPatronymicPatient.Text);
                QuestionPool();
                switch (ID)
                { 
                    case 0:
                        {
                            Question1[0].SetDoctor(DoctorSelect);
                            Question1[0].SetPatient(Patient1);
                            if (Question1[0].GetQuestions(0) != "")
                            {
                                form2.groupBox1.Visible = true;
                                form2.label1.Visible = true;
                                form2.label1.Text = Question1[0].GetQuestions(0);
                            }
                            if (Question1[0].GetQuestions(1) != "")
                            {
                                form2.groupBox2.Visible = true;
                                form2.label2.Visible = true;
                                form2.label2.Text = Question1[0].GetQuestions(1);
                            }
                            if (Question1[0].GetQuestions(2) != "")
                            {
                                form2.groupBox3.Visible = true;
                                form2.label3.Visible = true;
                                form2.label3.Text = Question1[0].GetQuestions(2);
                            }
                            if (Question1[0].GetQuestions(3) != "")
                            {
                                form2.groupBox4.Visible = true;
                                form2.label4.Visible = true;
                                form2.label4.Text = Question1[0].GetQuestions(3);
                            }
                            if (Question1[0].GetQuestions(4) != "")
                            {
                                form2.groupBox5.Visible = true;
                                form2.label5.Visible = true;
                                form2.label5.Text = Question1[0].GetQuestions(4);
                            }
                            if (Question1[0].GetQuestions(5) != "")
                            {
                                form2.groupBox6.Visible = true;
                                form2.label6.Visible = true;
                                form2.label6.Text = Question1[0].GetQuestions(5);
                            }
                            if (Question1[0].GetQuestions(6) != "")
                            {
                                form2.groupBox7.Visible = true;
                                form2.label7.Visible = true;
                                form2.label7.Text = Question1[0].GetQuestions(6);
                            }
                            if (Question1[0].GetQuestions(7) != "")
                            {
                                form2.groupBox8.Visible = true;
                                form2.label8.Visible = true;
                                form2.label8.Text = Question1[0].GetQuestions(7);
                            }
                            if (Question1[0].GetQuestions(8) != "")
                            {
                                form2.groupBox9.Visible = true;
                                form2.label9.Visible = true;
                                form2.label9.Text = Question1[0].GetQuestions(8);
                            }
                            if (Question1[0].GetQuestions(9) != "")
                            {
                                form2.groupBox10.Visible = true;
                                form2.label10.Visible = true;
                                form2.label10.Text = Question1[0].GetQuestions(9);
                            }
                            Num = 0;
                            form2.Show();
                            break;
                        }
                    case 1:
                        {
                            Question1[1].SetDoctor(DoctorSelect);
                            Question1[1].SetPatient(Patient1);
                            if (Question1[1].GetQuestions(0) != "")
                            {
                                form2.groupBox1.Visible = true;
                                form2.label1.Visible = true;
                                form2.label1.Text = Question1[1].GetQuestions(0);
                            }
                            if (Question1[1].GetQuestions(1) != "")
                            {
                                form2.groupBox2.Visible = true;
                                form2.label2.Visible = true;
                                form2.label2.Text = Question1[1].GetQuestions(1);
                            }
                            if (Question1[1].GetQuestions(2) != "")
                            {
                                form2.groupBox3.Visible = true;
                                form2.label3.Visible = true;
                                form2.label3.Text = Question1[1].GetQuestions(2);
                            }
                            if (Question1[1].GetQuestions(3) != "")
                            {
                                form2.groupBox4.Visible = true;
                                form2.label4.Visible = true;
                                form2.label4.Text = Question1[1].GetQuestions(3);
                            }
                            if (Question1[1].GetQuestions(4) != "")
                            {
                                form2.groupBox5.Visible = true;
                                form2.label5.Visible = true;
                                form2.label5.Text = Question1[1].GetQuestions(4);
                            }
                            if (Question1[1].GetQuestions(5) != "")
                            {
                                form2.groupBox6.Visible = true;
                                form2.label6.Visible = true;
                                form2.label6.Text = Question1[1].GetQuestions(5);
                            }
                            if (Question1[1].GetQuestions(6) != "")
                            {
                                form2.groupBox7.Visible = true;
                                form2.label7.Visible = true;
                                form2.label7.Text = Question1[1].GetQuestions(6);
                            }
                            if (Question1[1].GetQuestions(7) != "")
                            {
                                form2.groupBox8.Visible = true;
                                form2.label8.Visible = true;
                                form2.label8.Text = Question1[1].GetQuestions(7);
                            }
                            if (Question1[1].GetQuestions(8) != "")
                            {
                                form2.groupBox9.Visible = true;
                                form2.label9.Visible = true;
                                form2.label9.Text = Question1[1].GetQuestions(8);
                            }
                            if (Question1[1].GetQuestions(9) != "")
                            {
                                form2.groupBox10.Visible = true;
                                form2.label10.Visible = true;
                                form2.label10.Text = Question1[1].GetQuestions(9);
                            }
                            Num = 1;
                            form2.Show();
                            break;
                        }
                }
            }
        }
        public void QuestionPool()
        {
            string[] QuestionMas1 = new string[10];
            for (int i = 0; i < 10; i++)
            {
                QuestionMas1[i] = "";
            }

            QuestionMas1[0] = "Я терапевт";
            QuestionMas1[1] = "2";
            QuestionMas1[2] = "3";
            QuestionMas1[3] = "4";
            QuestionMas1[4] = "5";
            QuestionMas1[5] = "6";
            QuestionMas1[6] = "7";
            QuestionMas1[7] = "8";
            QuestionMas1[8] = "9";
            QuestionMas1[9] = "10";

            string[] QuestionMas2 = new string[10];
            for (int i = 0; i < 10; i++)
            {
                QuestionMas2[i] = "";
            }

            QuestionMas2[0] = "Я проктолог";
            QuestionMas2[1] = "2";
            QuestionMas2[2] = "3";
            QuestionMas2[3] = "4";
            QuestionMas2[4] = "5";
            QuestionMas2[5] = "6";
            QuestionMas2[6] = "7";
            QuestionMas2[7] = "8";
            QuestionMas2[8] = "9";
            QuestionMas2[9] = "10";

            Question1[0] = new Question();
            Question1[1] = new Question();

            Question1[0].SetQuestions(QuestionMas1, 10);
            Question1[1].SetQuestions(QuestionMas2, 10);
        }
    }
}
