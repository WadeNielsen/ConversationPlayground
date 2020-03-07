using System;
using System.Collections.Generic;

namespace _NetCoreConsolePlayground
{
    public class Person
    {
        public int State = 0;

        public List<Conversation> Conversations { set; get; } = new List<Conversation>();

        public string Name { protected set; get; }

        public Person()
        {

        }

        public Conversation GetConversation()
        {
            return Conversations[State];
        }

        public bool UserAnswered(int answer)
        {
            return (Conversations[State].Answers[answer].Action?.Invoke()).GetValueOrDefault();
        }
    }
}
