using System.Security.Cryptography.X509Certificates;

namespace myVersionOfTicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; // tova ni e duskata
            bool Player1Turn = true; //boleva promenliva
            int numCounter = 0;
            while (!CheckIfThereIsAWinner()&& numCounter!=9) //cikula koito vurti izbora
            {
                Print(); //vikame metoda na pechataneto na duskata
                if (Player1Turn)
                {
                    Console.WriteLine("Player 1 turn!");
                }
                else
                {
                    Console.WriteLine("Player 2 turn"); 
                }

                string thePlayersChoice= Console.ReadLine(); // izborut dali O ili X
                if (board.Contains(thePlayersChoice) && thePlayersChoice!= "X" && thePlayersChoice!= "O")
                {
                    int indexChoice = Convert.ToInt32(thePlayersChoice) -1 ; //- 1 zashtoto pochvame ot 1 ne ot 0 ;
                    //
                    if (Player1Turn)
                    {
                        board[indexChoice] = "X" ;
                    }
                    else
                    {
                        board[indexChoice] = "O";
                    }

                    numCounter++;

                }
                    Player1Turn = !Player1Turn; //kraq na while-a; obrushtame i e red na player2

            }

            if (CheckIfThereIsAWinner())
            {
                Console.WriteLine("Pechelish WAAAA");
            }
            else
            {
                Console.WriteLine("KRaq LAAA");
            }
            //when the logic now is done the last thing to do is the winning conditions.
            //They are eight. so now we are going to do them 

            bool CheckIfThereIsAWinner()
            {
               bool row1= board[0] == board[1] && board[1] == board[2];
                bool row2 = board[3] == board[4] && board[4] == board[5];
                bool row3 = board[6] == board[7] && board[7] == board[8];
                //
                bool coll = board[0] == board[3] && board[3] == board[6];
                bool coll2 = board[1] == board[4] && board[4] == board[7];
                bool coll3 = board[2] == board[5] && board[5] == board[8];
                //
                bool diagonalUP = board[0] == board[4] && board[4] == board[8];
                bool diagonalDown = board[6] == board[4] && board[4] == board[8];

            // returnvame
            return row1 || row2 || row3 || coll ||coll2||coll3|| diagonalUP || diagonalDown;    



            }



            void Print()
            { 
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(board[i * 3 + j] + " | ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("___________");


                }
            }
        }
        
    }
}