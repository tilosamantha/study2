using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class TopicBank
    {
        public string Topic { get; set; }
        public int TopicKey { get; set; }

        IDictionary<int, string> topicBank = new Dictionary<int, string>()
        {
            [0] = "C#",
            [1] = "Java",
            [2] = "HTML",
            [3] = "Python"
        };

        //public TopicBank(IDictionary<int, string> topicBank)
        //{
        //    this.topicBank = topicBank;
        //}

        //public string addTopic(int key)
        //{
        //    return null;
        //}
    }
}
