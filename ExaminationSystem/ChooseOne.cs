using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class ChooseOne:Question
    {
        public ChooseOne(string header, int marks, string body) : base(header, marks, body) { }
    }
}
