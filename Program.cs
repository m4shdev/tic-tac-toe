using System.Collection.Generic;

namespace TicTacToe;

class Program {
    
    // static bool running = false;

    static Dictionary<string, int[]> inputToIndices = new Dictionary<string, int[2]>(9);

    inputToIndices.Add("1", {0, 0});
    inputToIndices.Add("2", {0, 1});
    inputToIndices.Add("3", {0, 2});
    inputToIndices.Add("4", {1, 0});
    inputToIndices.Add("5", {1, 1});
    inputToIndices.Add("6", {1, 2});
    inputToIndices.Add("7", {2, 0});
    inputToIndices.Add("8", {2, 1});
    inputToIndices.Add("9", {2, 2});

    static string[,] panels = new string[3, 3] {
        {"1", "2", "3"},
        {"4", "5", "6"},
        {"7", "8", "9"}
    };

    static void Main(String[] args) {
        System.Console.WriteLine("TIC TAC TOE\n");
        System.Console.WriteLine(PanelParser());

        // InputPlayerOne();

        // System.Console.WriteLine(PanelParser());

        // InputPlayerTwo();

        // System.Console.WriteLine(PanelParser());

        // while (!running) {

        // }

        // for (int i = 0; i < 9; i++) {
        //     if (i % 2 == 0) InputPlayerOne();
        //     else InputPlayerTwo();

        //     System.Console.WriteLine(PanelParser());
        // }
    }

    static string PanelParser() {
        string returnString = "";

        for  (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) returnString += $"[{panels[i, j]}]";

            returnString += "\n";    
        }

        return returnString;
    } 

    static void InputPlayerOne() {
        System.Console.Write("Player 1 input position here [X]: ");
        string choice = Console.ReadLine();

        
    }

    // static void InputPlayerTwo() {
    //     System.Console.Write("Player 2 input position here [O]: ");
    //     string choice = Console.ReadLine();

    //     string panelState = panels[int.Parse(choice) - 1].state;

    //     if (panelState != "X" || panelState != "O") panelState = "O";
    // }
    
    static bool Place(int indexX, int indexY, string sign) {
    
        if (panels[indexX, indexY] != "X" || panels[indexX, indexY] != "O") panels[indexX, indexY] = sign;

        if (panels[indexX, 0] == sign)
            if (panels[indexX, 1] == sign)
                if (panels[indexX, 2] == sign)
                    return true;

        else if (panels[0, indexY] == sign)
            if (panels[1, indexY] == sign)
                if (panels[2, indexY] == sign)
                    return true;

        else if (indexX == indexY)
            if (panels[0, 0] == panels[1, 1] && panels[1, 1] == panels[2, 2])
                return true;

        else if (indexX == (2 - indexY))
            if (panels[0, 3] == panels[1, 1] && panels[1, 1] == panels[3, 0])
                return true;

        return false;
    }
}