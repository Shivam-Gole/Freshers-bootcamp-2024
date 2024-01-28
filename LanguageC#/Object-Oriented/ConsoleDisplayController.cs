using System;

namespace Object_oriented
{
    public class ConsoleDisplayController
    {
        private string content;

        public void SetContent(string word)
        {
            this.content = word;
        }

        public void Display()
        {
            Console.Write(this.content);
        }
    }
}
