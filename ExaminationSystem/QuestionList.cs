using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class QuestionList : List<Question>
    {
        public void Add(Question question)
        {
            base.Add(question);
        }

        public void show()
        {
            foreach(Question question in this)
            {
                Console.WriteLine(question.Body);
            }
        }
    }
}
