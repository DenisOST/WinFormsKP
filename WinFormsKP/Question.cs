﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsKP
{
    public class Question
    {
        private string[] Questions = new string[10];
        private int[] Answers = new int[10];
        private Patient patient = new Patient();
        private Doctor doctor = new Doctor();

        public Question()
        {
            for (int i = 0; i < 10; i++)
            {
                Questions[i] = "";
                Answers[i] = -1;
            }
        }
        public void Set(string[] Q, int length, Patient P, Doctor D)
        {
            for (int i = 0; i < 10 && i < length; i++)
            {
                Questions[i] = Q[i];
            }
            patient = P;
            doctor = D;
        }
        public void SetPatient(Patient P)
        {
            patient = P;
        }
        public void SetDoctor(Doctor D)
        {
            doctor = D;
        }
        public void SetQuestions(string[] Q, int length)
        {
            for (int i = 0; i < 10 && i < length; i++)
            {
                Questions[i] = Q[i];
            }
        }
        public void SetAnswers(int[] A, int length)
        {
            for (int i = 0; i < 10 && i < length; i++)
            {
                Answers[i] = A[i];
            }
        }
        public string GetQuestions(int i)
        {
            if (i < 10 && i >= 0)
                return Questions[i];
            else
                return "";
        }
        public int GetAnswers(int i)
        {
            if (i < 10 && i >= 0)
                return Answers[i];
            else
                return -1;
        }
        public Doctor GetDoctor()
        {
            return doctor;
        }
        public Patient GetPatient()
        {
            return patient;
        }
        public bool SaveQuestion(string Path)
        {
            string FullPath = Path;
            FullPath = FullPath + @"\" + patient.GetSurname() + "_" + doctor.GetSurname() + ".txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(FullPath, false, System.Text.Encoding.Default))
                {

                    sw.WriteLine("ФИО пациента: " + patient.GetSurname() + " " + patient.GetName() + " " + patient.GetPatronymic());
                    sw.WriteLine("\n");
                    sw.WriteLine("Опрос пациента:");
                    string Answer;
                    for (int i = 0; i < 10 && Answers[i] != -1; i++)
                    {
                        if (Answers[i] == 0)
                            Answer = "нет.";
                        else
                            Answer = "да.";
                        sw.WriteLine("Вопрос №" + (i+1) + ": " + GetQuestions(i) + "       Ответ: " + Answer);
                    }
                    sw.WriteLine("\n");
                    sw.WriteLine("ФИО врача: " + doctor.GetSurname() + " " + doctor.GetName() + " " + doctor.GetPatronymic());
                    sw.WriteLine("Специальность врача: " + doctor.GetSpecialization());
                    sw.WriteLine("\n");
                    sw.WriteLine("Заключение врача:________________________________________________________________");
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
