using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace TicTacToe_test_
{
    class Program
    {
        static void Main(string[] args)
        {
            string strX;
            string strO;
            string strSaisie;
            string strChoix = "";
            int iPointX = 0;
            int iPointO= 0 ;

            Console.WriteLine("     ***************************************");
            Thread.Sleep(200);
            Console.WriteLine("     *                                     *");
            Thread.Sleep(200);
            Console.WriteLine("     *                                     *");
            Thread.Sleep(200);
            Console.WriteLine("     *             TIC TAC TOE             *");
            Thread.Sleep(200);
            Console.WriteLine("     *                                     *");
            Thread.Sleep(200);
            Console.WriteLine("     *                                     *");
            Thread.Sleep(200);
            Console.WriteLine("     ***************************************");
            Thread.Sleep(200);
            Console.WriteLine("\n");
            Console.WriteLine("  ,     ,");
            Thread.Sleep(200);
            Console.WriteLine(" (____ /)                                    Petit rappelle pour les règles:");
            Thread.Sleep(200);
            Console.WriteLine("  (_oo_)                     Le but du jeu est d'aligner les symboles sélectionnés pour gagner !");
            Thread.Sleep(200);
            Console.WriteLine("     (O)");
            Thread.Sleep(200);
            Console.WriteLine("   __|| __    )");
            Thread.Sleep(200);
            Console.WriteLine("[]/ ______[] /");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.Write("Saisie ton nom (tu prendras les X et tu commenceras): ");
            strSaisie = Console.ReadLine();
            strX = strSaisie;

            Console.Write("Saisie ton nom (tu prendras les O et tu seras deuxième): ");
            strSaisie = Console.ReadLine();
            strO = strSaisie;

            //Par défaut il y a le 0 même si on ne l'utilise pas à ne pas prendre en compte.
            //Mais si on souhaite le changer enlever le 9 et mettre -1
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (strChoix == "oui")
            {
                Console.Clear();
            }
            int player = 1;
            int choice;
            int flag = 0;
            do
            {
                do
                {
                    if (flag == 1 && player == 1)
                    {
                        iPointX++;
                    }
                    if (flag == 1 && player == 2)
                    {
                        iPointO ++;
                    }
                    Console.Clear();
                    Console.WriteLine("     ***************************************");
                    Console.WriteLine("     *                                     *");
                    Console.WriteLine("     *                                     *");
                    Console.WriteLine("     *             TIC TAC TOE             *");
                    Console.WriteLine("     *                                     *");
                    Console.WriteLine("     *                                     *");
                    Console.WriteLine("     ***************************************");
                    Console.WriteLine("\n");
                    Console.WriteLine("                                                                                    ****************");
                    Console.WriteLine("{0} joue avec le X et {1} joue avec le O (pour rappelle ^^)                         *  {2}  *  {3} *", strX, strO, iPointX, iPointO);
                    Console.WriteLine("                                                                                    ****************");                                                           
                    Console.WriteLine("\n");
                   
                    if (player % 2 == 0)// tour
                    {
                        Console.WriteLine("Tour de : {0}", strO);
                    }
                    else
                    {
                        Console.WriteLine("Tour de : {0}", strX);
                    }
                    Console.WriteLine("\n");
                    Board(arr);
                    choice = int.Parse(Console.ReadLine());

                    if (arr[choice] != 'X' && arr[choice] != 'O')
                    {
                        char sign;
                        if (player % 2 == 0) //si ce n'est pas le tour du X alors c'est le O qui y joue
                        {
                            sign = 'O';
                        }
                        else
                        {
                            sign = 'X';
                        }
                        arr[choice] = sign;
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Désolé, la ligne {0} est déjà marquée avec {1}", choice, arr[choice]);
                        Console.WriteLine("\n");
                        Console.WriteLine("S'il vous plaît attendez 2 seconde le partie se charge à nouveau .....");
                        Thread.Sleep(2000); //=2sec
                    }
                    flag = CheckWin(arr);
                }
                while (flag == 0);

                Console.Clear();
                Board(arr);

                if (flag == 1)
                {
                    strX = Convert.ToString(player);
                    Console.WriteLine("Player {0} a gagné !", (player % 2) + 1);
                    Console.WriteLine("                                                      ,     ,");
                    Thread.Sleep(200);
                    Console.WriteLine("                                                     (____ /)");
                    Thread.Sleep(200);
                    Console.WriteLine("                Bien joué Player {0}                   (_oo_)", (player % 2) + 1);
                    Thread.Sleep(200);
                    Console.WriteLine("                                                     (U)");
                    Thread.Sleep(200);
                    Console.WriteLine("                                                    __|| __    )");
                    Thread.Sleep(200);
                    Console.WriteLine("                                                 []/ ______[] /");
                    Console.WriteLine("Veux-tu continuer ?(oui/non): ");
                    strChoix = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("draw");
                }
  
            } while (strChoix == "oui");
        }
        //Voir si le joueur gagne ou pas 
        static void Board(char[] arr)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        static int CheckWin(char[] arr)
        {
            #region Condition pour gagner à l'horizontal 
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }
            #endregion

            #region Condition pour gagner à la vertical     
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion

            #region Condition pour gagner en diagognal
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }

            #endregion

            #region Si toutes les cases sont remplies
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }

    }
}


