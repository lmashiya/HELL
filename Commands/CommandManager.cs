using System;
using System.Collections.Generic;
using System.Text;
using HELL.IO.Input;
using HELL.Commands;

namespace HELL.Commands
{
    public class CommandManager
    {
        private Commands _commands = new Commands();
        public CommandManager()
        {
            
        }
        public void ProcessCommand()
        {
            GetInputAgain:
            var userInput = UserInput.GetCommand();
            do

            {
                switch (userInput[0])
                {
                    case "Hero":
                        _commands.HeroCommand(userInput[1], userInput[2]);
                        break;
                    case "Item":
                        _commands.ItemCommand(userInput);
                        break;
                    case "Recipe":
                        _commands.RecipeCommand(userInput);
                        break;
                    case "Inspect":
                        _commands.InspectCommand(userInput);
                        break;
                    case "Quit":
                        _commands.QuitCommand(userInput);
                        break;
                }
                userInput = UserInput.GetCommand();
            } while (userInput[0] != "Quit");


        }
    }
}
