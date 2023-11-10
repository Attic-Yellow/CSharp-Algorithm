using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inventory.UI.BoxHandler;

namespace Inventory.UI
{
    internal class ItemListUI : InventoryWorkUI
    {
        private static readonly List<string> ItemSelectionNumber = new List<string>
        {
            "아이템 1",
            "아이템 2"
        };


        protected static readonly GameBoxHandler ItemSelectionBoxHandler = new GameBoxHandler(ItemSelectionNumber);

        public static void ItemSelectionMenuDisplay(InputHandler inputHandler)
        {
            List<string> selectedItems = new List<string>();

            bool conti = true;
            while (conti)
            {
                Console.Clear();
                UIRender.DrawCharacterMenuBox(InventoryMenuBoxHandler.Box.Width, InventoryMenuBoxHandler.Box.GameMenus.Count);
                UIRender.DrawInventoryMenuWorkBox(InventoryMenuBoxHandler.Box.Width, InventoryMenuBoxHandler.Box.GameMenus.Count);
                InventoryMenuBoxHandler.GameMenuSecondDisplay();
                InventoryWorkMenuBoxHandler.GameMenuThirdDisplay();
                ItemSelectionBoxHandler.GameMenuFifthDisplay();

                var key = inputHandler.GetUserInput();
                ItemSelectionBoxHandler.Navigate(key);

                if (key == ConsoleKey.Enter)
                {
                    selectedItems.Add(ItemSelectionNumber[ItemSelectionBoxHandler.Box.SelectedIndex]);
                    InventoryMenuDisplay(inputHandler, selectedItems);
                    conti = false;
                }
                else if (key == ConsoleKey.V)
                {
                    InventoryWorkMenuDisplay(inputHandler, selectedItems);
                    conti = false;
                }
                else if (key == ConsoleKey.C)
                {
                    
                    conti = false;
                }
            }
        }

    }
}
