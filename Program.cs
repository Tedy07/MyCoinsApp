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


            Console.WriteLine("Welcome to MyCoinsApp !");
            Console.WriteLine("Please let me know whate you want to do:");
            var mainMenu = actionService.GetMenuActionsByMenuName("Main");

            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            //odczytuje tylko 1 znak wprowadzony na klawiaturze
            switch (operation.KeyChar)
            {

            }

        }
        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add item", "Main");
            actionService.AddNewAction(2, "Remove item", "Main");
            actionService.AddNewAction(3, "Show details", "Main");
            actionService.AddNewAction(4, "List of Itemss", "Main");
            actionService.AddNewAction(5, "Test test of Itemss", "Main");
            return actionService;
        }

    }
}
}
