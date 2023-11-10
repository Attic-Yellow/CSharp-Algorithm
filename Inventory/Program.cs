using System;
using Inventory.Engine;
// GameEngine 초기화
Engine gameEngine = new Engine();
gameEngine.Init();

// 게임 시작
gameEngine.Start();

// 게임 종료 후 자원 해제 
gameEngine.Release();
