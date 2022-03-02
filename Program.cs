namespace TicTacToe;

class Program {
    static string[,] panels = new string[3, 3] {
        {"1", "2", "3"},
        {"4", "5", "6"},
        {"7", "8", "9"}
    };

    static void Main(String[] args) {
        System.Console.Title = "Tic Tac Toe";

        for (int i = 0; i < 9; i++) {
            System.Console.Clear();
            System.Console.WriteLine("TIC TAC TOE\n===========");
            System.Console.WriteLine(Board());

            if (i % 2 == 0) {
                if (PlayerInput("X")) {
                    System.Console.Clear();
                    System.Console.WriteLine("TIC TAC TOE\n===========");
                    System.Console.WriteLine("\nCONGRATS! Player X has won the game!");
                    break;
                }
            } else {
                if (PlayerInput("O")) {
                    System.Console.Clear();
                    System.Console.WriteLine("TIC TAC TOE\n===========");
                    System.Console.WriteLine("\nCONGRATS! Player O has won the game!");
                    break;
                }
            }
        }
    }

    static string Board() {
        string returnString = "\n";

        for  (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) returnString += $"[{panels[i, j]}]";

            returnString += "\n";  
        }

        return returnString;
    } 
    
    static bool Place(int indexY, int indexX, string sign) {

        if (panels[indexY, indexX] != "X" && panels[indexY, indexX] != "O") {
            panels[indexY, indexX] = sign;
        } else {
            System.Console.WriteLine("try again lol\n");
            PlayerInput(sign);
        }

        if (panels[indexY, 0] == sign) {
            if (panels[indexY, 1] == sign) {
                if (panels[indexY, 2] == sign) {
                    return true;
                }
            }
        }
        if (panels[0, indexX] == sign) {
            if (panels[1, indexX] == sign) {
                if (panels[2, indexX] == sign) {
                    return true;
                }
            }
        }
        if (indexY == indexX) {
            if (panels[0, 0] == panels[1, 1]) {
                if (panels[1, 1] == panels[2, 2]) {
                    return true;
                }
            }
        }
        if (indexY == (2 - indexX)) {
            if (panels[0, 2] == panels[1, 1]) {
                if (panels[1, 1] == panels[2, 0]) {
                    return true;
                }
            }
        }

        return false;
    }

    static bool PlayerInput(string sign) {
        System.Console.Write($"Player {sign} input position here: ");
        string choice = Console.ReadLine();

        switch (choice) {
            case "1":
                return Place(0, 0, sign);
            case "2":
                return Place(0, 1, sign);
            case "3":
                return Place(0, 2, sign);
            case "4":
                return Place(1, 0, sign);
            case "5":
                return Place(1, 1, sign);
            case "6":
                return Place(1, 2, sign);
            case "7":
                return Place(2, 0, sign);
            case "8":
                return Place(2, 1, sign);
            case "9":
                return Place(2, 2, sign);
            default:
                System.Console.WriteLine("invalid input\n");
                PlayerInput(sign);
                break;
        }

        return false;
    }
}
