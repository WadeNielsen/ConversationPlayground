using System;
namespace _NetCoreConsolePlayground
{
    public class Game
    {
        public Game()
        {

        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Who would you like to speak to?\n");

                for (int i = 0; i < People.AllPeople.Count; ++i)
                {
                    Person person = People.AllPeople[i];
                    Console.WriteLine($"{i + 1}: {person.Name}");
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.Clear();

                int personIndex = keyInfo.KeyChar - '1';
                bool finished = false;
                while (personIndex >= 0 && personIndex < People.AllPeople.Count && !finished)
                {
                    Person person = People.AllPeople[personIndex];
                    Conversation conversation = person.GetConversation();
                    Console.WriteLine(conversation.Question);

                    for (int i = 0; i < conversation.Answers.Count; ++i)
                    {
                        Console.WriteLine($"{i + 1}: {conversation.Answers[i].Text}");
                    }

                    keyInfo = Console.ReadKey();
                    int answerIndex = keyInfo.KeyChar - '1';

                    finished = person.UserAnswered(answerIndex);
                    Console.Clear();
                }
            }
        }
    }
}
