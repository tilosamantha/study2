using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class AnswerBank
    {
        //public IEnumerable<KeyValuePair<string, int>> newAnswerBank;

        public string Answer { get; set; }
        public int AnswerKey { get; set; }

        public static IDictionary<int, string> answerBank = new Dictionary<int, string>()
        {
            [0] = "Field",
            [1] = "Operator",
            [2] = "Class statement",
            [3] = "Boolean"
        };
        //public AnswerBank(IDictionary<int, string> topicBank)
        //{
        //    this.answerBank = topicBank;
        //}

        //public string addAnswer(int key)
        //{
        //    return null;
        //}

        //public void printAnswerBank(AnswerBank answerBank)
        //{
        //    foreach (KeyValuePair<string, string> kvpair in answerBank)
        //    {
        //        Console.WriteLine("Key: {0}, Value: {1}", kvpair.Key, kvpair.Value);
        //    }
        //}
    }
}
