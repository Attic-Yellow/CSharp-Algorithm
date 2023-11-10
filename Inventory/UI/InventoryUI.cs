using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inventory.UI.BoxHandler;

namespace Inventory.UI
{

    internal class InventoryUI
    {
        private static readonly List<string> InventoryMenuNumber = new List<string>
        {
            "장비",
            "소모품"
        };

        protected static readonly GameBoxHandler InventoryMenuBoxHandler = new GameBoxHandler(InventoryMenuNumber);

        public static void InventoryMenuDisplay(InputHandler inputHandler, List<string> selectedItems)
        {
            GameBoxHandler selectedBoxHandler = new GameBoxHandler(selectedItems);

            bool conti = true;
            while (conti)
            {
                Console.Clear();
                UIRender.DrawCharacterMenuBox(InventoryMenuBoxHandler.Box.Width, InventoryMenuBoxHandler.Box.GameMenus.Count);
                UIRender.DrawInventoryMenuWorkBox(InventoryMenuBoxHandler.Box.Width, InventoryMenuBoxHandler.Box.GameMenus.Count);
                InventoryMenuBoxHandler.GameMenuSecondDisplay();
                if(selectedItems != null)
                {
                    selectedBoxHandler.GameMenuFourthDisplay();
                }
                

                var key = inputHandler.GetUserInput();
                InventoryMenuBoxHandler.Navigate(key);

                if (key == ConsoleKey.Enter)
                {
                    InventoryMenuPerformAction(inputHandler, selectedItems, InventoryMenuBoxHandler.Box.SelectedIndex);
                    conti = false;
                }
                else if (key == ConsoleKey.V)
                {

                    conti = false;
                }
                else if (key == ConsoleKey.C)
                {

                    conti = false;
                }
            }
        }

        protected static void InventoryMenuPerformAction(InputHandler inputHandler, List<string> selectedItems, int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    InventoryWorkUI.InventoryWorkMenuDisplay(inputHandler, selectedItems);
                    break;
                case 1:
                    break;
            }
        }
    }
}

