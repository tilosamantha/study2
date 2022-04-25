using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class QuestionBank
    {
        public string Question { get; set; }
        public int QuestionKey { get; set; }

        public static IDictionary<int, string> questionBank = new Dictionary<int, string>()
        {
            [0] = "A variable defined by a class", //field
            [1] = "Symbols which transform and combine expressions", //operator
            [2] = "Introduces a new class", //clss statement
            [3] = "Data type that returns either true or false" //boolean
        };

        //public QuestionBank(IDictionary<int, string> topicBank)
        //{
        //    this.questionBank = topicBank;
        //}

        //public string addQuestion(int key)
        //{
        //    return null;
        //}
    }
}
