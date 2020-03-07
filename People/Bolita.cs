using System;
using System.Collections.Generic;

namespace _NetCoreConsolePlayground
{
    public class Bolita : Person
    {
        public Bolita()
        {
            Name = "Bolita";
            Conversations = new List<Conversation>()
            {
                new Conversation()
                {
                    Question = "Chimichangas?",
                    Answers = new List<PlayerAction>()
                    {
                        new PlayerAction() {
                            Text = "Why?",
                            Action = () => { State = 0; return true; }},
                        new PlayerAction() {
                            Text = "No?",
                            Action = () => { State = 0; return true; }},
                        new PlayerAction() {
                            Text = "Yes?",
                            Action = () => { State = 0; return true; }}
                    }
                },
                new Conversation()
                {
                    Question = "Callate",
                    Answers = new List<PlayerAction>()
                    {
                        new PlayerAction() {
                            Text = "Why?",
                            Action = () => { State = 0; return true; }},
                        new PlayerAction() {
                            Text = "No?",
                            Action = () => { State = 0; return true; }},
                        new PlayerAction() {
                            Text = "Yes?",
                            Action = () => { State = 0; return true; }}
                    }
                }
            };
        }
    }
}
