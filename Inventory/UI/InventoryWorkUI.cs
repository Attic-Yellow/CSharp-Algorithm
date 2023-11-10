using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inventory.UI.BoxHandler;

namespace Inventory.UI
{
    class InventoryWorkUI : InventoryUI
    {
        private static readonly List<string> InventoryWorkMenuNumber = new List<string>
        {
            "아이템 추가",
            "아이템 사용"
        };

        protected static readonly GameBoxHandler InventoryWorkMenuBoxHandler = new GameBoxHandler(InventoryWorkMenuNumber);

        public static void InventoryWorkMenuDisplay(InputHandler inputHandler, List<string> selectedItems)
        {

            bool conti = true;
            while (conti)
            {
                Console.Clear();
                UIRender.DrawCharacterMenuBox(InventoryMenuBoxHandler.Box.Width, InventoryMenuBoxHandler.Box.GameMenus.Count);
                UIRender.DrawInventoryMenuWorkBox(InventoryMenuBoxHandler.Box.Width, InventoryMenuBoxHandler.Box.GameMenus.Count);
                InventoryMenuBoxHandler.GameMenuSecondDisplay();
                InventoryWorkMenuBoxHandler.GameMenuThirdDisplay();

                var key = inputHandler.GetUserInput();
                InventoryWorkMenuBoxHandler.Navigate(key);

                if (key == ConsoleKey.Enter)
                {
                    InventoryWorkMenuPerformAction(inputHandler, selectedItems, InventoryWorkMenuBoxHandler.Box.SelectedIndex);
                    conti = false;
                }
                else if (key == ConsoleKey.V)
                {
                    InventoryMenuDisplay(inputHandler, selectedItems);
                    conti = false;
                }
                else if (key == ConsoleKey.C)
                {
                    InventoryMenuDisplay(inputHandler, selectedItems);
                    conti = false;
                }
            }
        }

        protected static void InventoryWorkMenuPerformAction(InputHandler inputHandler, List<string> selectedItems, int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    ItemListUI.ItemSelectionMenuDisplay(inputHandler);
                    break;
                case 1:
                    break;
            }
        }
    }
}
