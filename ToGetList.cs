using System;
using System.Collections.Generic;

namespace ToGetListReborn
{
    /// <summary>
    /// Is the list of items to be gotten
    /// </summary>
    public class ToGetList
    {
        List<string> CurrentList = new List<string>();

        public void AddItem(string item)
        {
            CurrentList.Add(item);
        }
        public void PrintItems()
        {
            CurrentList.ForEach(Console.WriteLine);
        }
    }
}
