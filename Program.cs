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
            switch (operation.KeyChar)
            {
                case '1':
                    break;
                case '2':
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

        }
        private static MenuActionService Initialize(MenuActionService actionService)
        {
            Console.WriteLine();
            actionService.AddNewAction(1, "Add coin", "Main");
            actionService.AddNewAction(2, "Remove coin", "Main");
            actionService.AddNewAction(3, "Show details", "Main");
            actionService.AddNewAction(4, "List of coins ", "Main");
            return actionService;
        }

    }
}

