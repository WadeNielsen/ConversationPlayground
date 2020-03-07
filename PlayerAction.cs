using System;
namespace _NetCoreConsolePlayground
{
    public class PlayerAction
    {
        public string Text { set; get; }

        public Func<bool> Action { set; get; }

        public PlayerAction()
        {
        }
    }
}
