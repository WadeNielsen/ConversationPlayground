using System;
using System.Collections.Generic;

namespace _NetCoreConsolePlayground
{
    public class Conversation
    {
        public string Question;
        public List<PlayerAction> Answers = new List<PlayerAction>();
    }
}
