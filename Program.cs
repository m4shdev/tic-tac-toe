namespace TicTacToe;

class Program {
    
    // static bool running = false;

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

    // static void InputPlayerOne() {
    //     System.Console.Write("Player 1 input position here [X]: ");
    //     string choice = Console.ReadLine();

    //     string panelState = panels[int.Parse(choice) - 1].state;

    //     if (panelState != "X" || panelState != "O") panelState = "X";
    // }

    // static void InputPlayerTwo() {
    //     System.Console.Write("Player 2 input position here [O]: ");
    //     string choice = Console.ReadLine();

    //     string panelState = panels[int.Parse(choice) - 1].state;

    //     if (panelState != "X" || panelState != "O") panelState = "O";
    // }

    static bool CheckWinner(int index, string sign) {
        index--;

        if (panels[index - 1] == sign) {
            if (panels[index - 2] == sign) {
                return true;
            }
        }

        if (panels[index + 2] == sign) {
            if (panels[index + 4] == sign) {
                return true;
            }
        }

        if (panels[index + 3] == sign) {
            if (panels[index + 3] == sign) {
                return true;
            }
        }

        return false;
    }
}