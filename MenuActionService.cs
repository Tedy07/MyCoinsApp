using MyCoinsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoinsApp
{
    public class MenuActionService
    {
        private List<MenuAction> menuActions;

        public MenuActionService()
        { 
        menuActions = new List<MenuAction>();  
        }





        
       // = new List<MenuAction>();

        //do wyświetlenia powyższej listy potrzeba poniższych metod

        public void AddNewAction(int id, string name, string menuName)
        {
            MenuAction menuAction = new MenuAction() { Id = id, Name = name, MenuName = menuName };
             menuActions.Add(menuAction);
        }

        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();

            //pętla foreach przeliteruje po wszystkich elementach
            foreach (var menuAction in menuActions)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }

            return result;
        }

    }
}
