using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoinsApp
{
    public class ItemService
    {
        public List<Item> Items { get; set; }

        public ItemService()
        {
            Items = new List<Item>();
        }

        public ConsoleKeyInfo AddNewItemView(MenuActionService actionService)
        //ta metoda tworzy kolejne podmenu w pkt 1.
        // poniżej wyświetlimy to menu dokładnie jak robiliśmy to w głównym menu, służy też do przekazania do switch
        {
            var AddNewItemViewMenu = actionService.GetMenuActionsByMenuName("Main");
            Console.WriteLine("Please select item type:");
            for (int i = 0; i < AddNewItemViewMenu.Count; i++)
            {
                Console.WriteLine($"{AddNewItemViewMenu[i].Id}. {AddNewItemViewMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            return operation;
        }

        public void AddNewItem(char itemType)
        {
            int 
        }
    }
}
