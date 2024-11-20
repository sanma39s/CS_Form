using System;
using System.Threading;

class Program
{
    static int playerPosX = 5;  // プレイヤーのX座標
    static int playerPosY = 5;  // プレイヤーのY座標
    static bool isJumping = false;  // ジャンプ中かどうか
    static int groundLevel = 10; // 地面のY座標
    static int screenHeight = 20;  // コンソール画面の高さ
    static int screenWidth = 30;   // コンソール画面の幅

    static void Main()
    {
        Console.CursorVisible = false; // カーソルを非表示にする

        while (true)
        {
            DrawScreen();
            HandleInput();
            Thread.Sleep(100); // ゲームループの速度調整
        }
    }

    // ゲーム画面を描画する
    static void DrawScreen()
    {
        Console.Clear(); // 画面をクリア

        // 地面を描画
        for (int y = groundLevel; y < screenHeight; y++)
        {
            for (int x = 0; x < screenWidth; x++)
            {
                Console.SetCursorPosition(x, y);
                if (y == groundLevel)
                {
                    Console.Write("-");  // 地面を表示
                }
                else
                {
                    Console.Write(" ");  // 空白を表示
                }
            }
        }

        // プレイヤー（マリオ）を描画
        Console.SetCursorPosition(playerPosX, playerPosY);
        Console.Write("M");  // プレイヤーを "M" で表現

        // プレイヤーの位置情報を表示
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Player Position: (" + playerPosX + ", " + playerPosY + ")");
    }

    // 入力を処理する
    static void HandleInput()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;

            // 左右の移動
            if (key == ConsoleKey.LeftArrow && playerPosX > 0)
            {
                playerPosX--;
            }
            if (key == ConsoleKey.RightArrow && playerPosX < screenWidth - 1)
            {
                playerPosX++;
            }

            // ジャンプ
            if (key == ConsoleKey.Spacebar && !isJumping)
            {
                isJumping = true;
                Jump();
            }
        }

        // ジャンプの処理
        if (isJumping)
        {
            if (playerPosY > groundLevel - 5)
            {
                playerPosY--; // 上に移動
            }
            else
            {
                isJumping = false;
                Fall();  // 最大ジャンプ位置に到達したら落下開始
            }
        }
    }

    // ジャンプ後に落下
    static void Fall()
    {
        while (playerPosY < groundLevel)
        {
            playerPosY++;
            Thread.Sleep(50);  // 落下速度を調整
        }
    }

    // プレイヤーのジャンプ処理
    static void Jump()
    {
        while (playerPosY > groundLevel - 5)
        {
            playerPosY--;  // ジャンプして上に移動
            Thread.Sleep(50);  // ジャンプ速度を調整
        }
    }
}
