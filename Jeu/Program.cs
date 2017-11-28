/*******************************************************************************
 * http://codes-sources.commentcamarche.net/source/view/102112/1464183#browser → Jeu de mot 
 * https://www.google.ch/search?q=c+sharp+console+mode&rlz=1C1GGRV_enCH770CH770&tbm=isch&source=lnms&sa=X&ved=0ahUKEwjIjqqR5s_XAhViJ8AKHZaVD9oQ_AUICygC&biw=1920&bih=974&dpr=1#imgdii=9p8HyLFcJa9kpM:&imgrc=91EbWI1wtwnXcM → Morpion
 * http://www.c-sharpcorner.com/UploadFile/75a48f/tic-tac-toe-game-in-C-Sharp/ → Morpion
 *http://meunierwandy.altervista.org/morpion/?doing_wp_cron=1511343518.0097360610961914062500 → Morpion mise en forme
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique ton nom :)");
            Console.ReadLine();
            Console.WriteLine("Tu vas plutôt t'appeler Batiste ! Je préfère..");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t--------------------");
            Console.WriteLine("\t\t\t\t¦      ¦     ¦     ¦");
            Console.WriteLine("\t\t\t\t--------------------");
            Console.WriteLine("\t\t\t\t¦      ¦     ¦     ¦");
            Console.WriteLine("\t\t\t\t--------------------");
            Console.WriteLine("\t\t\t\t¦      ¦     ¦     ¦");
            Console.WriteLine("\t\t\t\t--------------------");
            Console.Read();
        }
    }
}
