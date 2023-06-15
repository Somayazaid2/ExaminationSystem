using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class AnswersList:List<Answers>
    {
        QuestionList Q;
        IDictionary<int, Answers> modelanswer;

        public AnswersList(QuestionList Q, IDictionary<int, Answers> modelanswer)
        {
            this.Q = Q;
            this.modelanswer = modelanswer;
        }
        public void Add(Answers A)
        {
            base.Add(A);
        }
        public override string ToString()
        {
            string answers = "";
            foreach (Answers A in this)
            {
                Console.WriteLine(A.Answer);
            }
            return answers;
        }

        public void ShowModelAnswer()
        {
            if (modelanswer != null && this != null && modelanswer.Count > 0)
            {
                foreach (KeyValuePair<int, Answers> Key in modelanswer)
                {
                    Console.WriteLine(Key.Value.useranswer);

                }
            }
        }
        public int CalcMark()
        {
            int mark = 0;
            if (modelanswer != null && this != null && modelanswer.Count > 0)
            {
                foreach (KeyValuePair<int, Answers> Key in modelanswer)
                {

                    if (this[Key.Key - 1].useranswer == (Key.Value.useranswer))
                    {

                        mark += Q[Key.Key - 1].Marks;


                    }
                }

            }
            return mark;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(ToString());
        }
    }
}
