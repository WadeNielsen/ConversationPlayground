using System;
using System.Collections.Generic;

namespace _NetCoreConsolePlayground
{
    public class CuriousGeorge : Person
    {
        public CuriousGeorge()
        {
            Name = "CuriousGeorge";
            Conversations = new List<Conversation>()
            {
                new Conversation()
                {
                    Question = "So now that we are friends will you put gum in cassidys hair?",
                    Answers = new List<PlayerAction>()
                    {
                        new PlayerAction() {
                            Text = "Why?",
                            Action = () => { State = 1; return false; }},
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
                    Question = "Wait, wait, wait, I know, space!",
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