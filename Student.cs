using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Student : Person
    {
        Address Address { get; set; }

        public string studentNumber { get; set; }

        public List<Score> Scores { get; set; }

        public Student()
        {
            Scores = new List<Score>();
        }

        public void AddScore(string subject, float mark)
        {
            this.Scores.Add(new Score { Subject = subject, Mark = mark });
        }

        public class Score
        {
            public string Subject { get; set; }
            public float Mark { get; set; }
        }

        public string ToExportString()
        {
            string result = "Grades for subjects:" + Environment.NewLine;
            foreach (Score score in this.Scores)
            {
                result += score.Subject + " - " + score.Mark + Environment.NewLine;
            }
            return result;
        }
    }
}
