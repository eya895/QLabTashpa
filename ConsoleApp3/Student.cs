using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLab
{
        public class Student
        {
            public int id;
            public char migdar;// f,e,m
            public int grade;

            public Student(int id, char migdar)
            {
                this.id = id;
                this.migdar = migdar;
                this.grade = -1; //PlaceHolder
            }

            public void SetGrade(int grade) { this.grade = grade; }

            public override string ToString()
            {
                string write;
                if ((grade >= 0) && (grade <= 100))
                {
                    write ="; id: " + id + "; migdar: " + migdar + "; grade: " + grade + "\n";
                }
                else
                {

                    write ="; id: " + id + "; migdar: " + migdar + "\n" + "grade yet defined" + "\n";
                }
                return write;
            }
            
            public int GetGrade() { return this.grade; }
        }
}
