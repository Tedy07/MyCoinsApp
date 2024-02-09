using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
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
        // Ta metoda odpowiedzialna jest za wyświetlanie kolejnych menu
        {
            var addNewItemViewMenu = actionService.GetMenuActionsByMenuName("AddNewItemViewMain");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please select item type:");
            for (int i = 0; i < addNewItemViewMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemViewMenu[i].Id}. {addNewItemViewMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            return operation;
        }

        public int AddNewItem(char itemType)
        {
            int itemTypeId;
            Int32.TryParse(itemType.ToString(), out itemTypeId);
            Item item = new Item();
            item.TypeId = itemTypeId;
            Console.WriteLine();
            Console.WriteLine("Please enter id for new item: ");
            var id = Console.ReadLine();

            int itemId;
            Int32.TryParse(id, out itemId);
            Console.WriteLine("Please enter name for new item:");
            var name = Console.ReadLine();

            item.id = itemId;
            item.Name = name;

            Items.Add(item);
            return itemId;
        }

        public int RemoveItemView()
        // metoda ta zwróci int ponieważ użytkjownik poda numer przedmiotu do usunięcia
        {
            Console.WriteLine();
            Console.WriteLine("Please enter id for item you want to remove:");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);

            return id;

        }

        public void RemoveItem(int removeId)
        {
            Item productToRemove = new Item();
            foreach (var item in Items)
            {
                if (item.id == removeId)
                {
                    productToRemove = item;
                    break;
                }
            }
            Items.Remove(productToRemove);
        }

        internal int ItemDetailSelectionView()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter id for item you want to show:");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);

            return id;
        }

        internal void ItemDetailView(int detailId)
        {
            //ta metoda powinna wyświetlić wszystkie informacje o naszym item

            Item productToShow = new Item();
            foreach (var item in Items)
            {
                if (item.id == detailId)
                {
                    productToShow = item;
                    break;
                }
            }
            Console.WriteLine($"Item id: {productToShow.id}");
            Console.WriteLine($"Item id: {productToShow.Name}");
            Console.WriteLine($"Item id: {productToShow.TypeId}");
        }
    }
}
