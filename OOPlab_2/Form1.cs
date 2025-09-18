using System;
using System.Windows.Forms;


namespace OOPlab1
{
    public partial class Form1 : Form
    {
       
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            LessonSchedule lesson = new LessonSchedule
            {
                SubjectName = textBox1.Text,
                LessonNumber = (int)numericUpDown1.Value,
                DayOfWeek1 = ComboBoxDayOfWeek.SelectedItem.ToString(),
                TeacherSurname1 = textBox4.Text
            };

            
            

            dataGridView1.Rows.Add(
                lesson.SubjectName,
                lesson.LessonNumber,
                lesson.DayOfWeek1,
                lesson.TeacherSurname1
            );


            textBox1.Clear();
            numericUpDown1.Value = 1;
            ComboBoxDayOfWeek.SelectedIndex = 0;
            textBox4.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    

    public class LessonSchedule
    {
        private string subjectName;
        private int lessonNumber;
        private string DayOfWeek;
        private string TeacherSurname;
        

        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        public int LessonNumber
        {
            get { return lessonNumber; }
            set { lessonNumber = value; }
        }
        public string DayOfWeek1
        {
            get { return DayOfWeek; }
            set { DayOfWeek = value; }
        }
        public string TeacherSurname1
        {
            get { return TeacherSurname; }
            set { TeacherSurname = value; }
        }

        public void SetSubjectName(string value)
        {
            subjectName = value;
        }

        public string GetSubjectName()
        {
            return subjectName;
        }

        public void SetLessonNumber(int value)
        {
            lessonNumber = value;
        }

        public int GetLessonNumber()
        {
            return lessonNumber;
        }

        public override string ToString()
        {
            return $"Subject: {subjectName}, Lesson #: {lessonNumber}, Day: {DayOfWeek}, Teacher: {TeacherSurname}";
        }
    }
}