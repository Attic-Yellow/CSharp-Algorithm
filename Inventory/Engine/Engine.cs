using Inventory.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Engine
{
    public class Engine
    {
        private InputHandler _inputHandler;
        private List<string> _selectedItem;

        // 기본 생성자
        public Engine()
        {
            _inputHandler = new InputHandler();
        }

        // 소멸자
        ~Engine()
        {

        }

        public void Init()
        {
            
        }

        public void Start()
        {
            InventoryUI.InventoryMenuDisplay(_inputHandler, _selectedItem);

            Update();
        }

        private void Update()
        {
            bool running = true;
            while (running)
            {
               
            }
        }

        public void Release()
        {

        }
    }
}
