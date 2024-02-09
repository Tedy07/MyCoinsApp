namespace MyCoinsApp
{
    internal class Program
    {

        public const string FILE_NAME = @"C:\MyCoinsApp\Importfile.xlsx";
        private static object menuList;

        static void Main(string[] args)
        {
            //nowy obiekt serwisu
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);


            Console.WriteLine("Welcome to MyCoinsApp!");
            while (true)
            {
                // stworzono pętlę nieskończoną, aby program działał aż do zamknięcia 
                Console.WriteLine("Please let me know whate you want to do?");
                Console.WriteLine("Press 1, 2, 3 or 4: ");
                Console.WriteLine();

                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }
                var operation = Console.ReadKey();
                //ReadKey odczytuje tylko 1 znak wprowadzony na klawiaturze

                ItemService itemService = new ItemService();
                //pobiera informacje o podmenu do pkt 1

                switch (operation.KeyChar)
                {
                    case '1':
                        var keyInfo = itemService.AddNewItemView(actionService);
                        var id = itemService.AddNewItem(keyInfo.KeyChar);
                        break;
                    case '2':
                        var removeId = itemService.RemoveItemView();
                        itemService.RemoveItem(removeId);
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Action you entered does not exist");
                        break;

                }
                // tutaj się kończy pętla while, ciągłe działanie programu
            }
        }
        private static MenuActionService Initialize(MenuActionService actionService)
        {
            Console.WriteLine();
            actionService.AddNewAction(1, "Add coin", "Main");
            actionService.AddNewAction(2, "Remove coin", "Main");
            actionService.AddNewAction(3, "Show details", "Main");
            actionService.AddNewAction(4, "List of coins ", "Main");

            actionService.AddNewAction(1, "gold", "AddNewItemViewMain");
            actionService.AddNewAction(2, "silver", "AddNewItemViewMain");
            actionService.AddNewAction(3, "platinum", "AddNewItemViewMain");

            return actionService;
        }

    }
}

