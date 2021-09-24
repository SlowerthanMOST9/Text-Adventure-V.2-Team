using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*mini game: The code will initiate a countdown, and when it reaches zero, something will appear on the screen. The first person to press space will get the shot and will randomly get a head,
 * body, or limb shot. If someone presses space before the item appears, the other person will get the shot.
 */
namespace Text_Adventure_V._2_Team
{

    class Program
    {
        public class CowBoy
        { 
            public string Name;
            public int Age;
            public double Luck;
            //return an random int from 1 - 10
            static public int roll()
            {
                Random rand = new Random();
                int number = rand.Next(1,  11);
                return number;
            }
            public CowBoy(string name, int age, double luck)
            {
                Name = name;
                Age = age;
                Luck = luck;
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();

            string welcome = @" _    _  _____  _      _____  _____ ___  ___ _____   _____  _____   ______  _____   ___  ______    _____ __   __ _____ 
| |  | ||  ___|| |    /  __ \|  _  ||  \/  ||  ___| |_   _||  _  |  |  _  \|  ___| / _ \ |  _  \  |  ___|\ \ / /|  ___|
| |  | || |__  | |    | /  \/| | | || .  . || |__     | |  | | | |  | | | || |__  / /_\ \| | | |  | |__   \ V / | |__  
| |/\| ||  __| | |    | |    | | | || |\/| ||  __|    | |  | | | |  | | | ||  __| |  _  || | | |  |  __|   \ /  |  __| 
\  /\  /| |___ | |____| \__/\\ \_/ /| |  | || |___    | |  \ \_/ /  | |/ / | |___ | | | || |/ /   | |___   | |  | |___ 
 \/  \/ \____/ \_____/ \____/ \___/ \_|  |_/\____/    \_/   \___/   |___/  \____/ \_| |_/|___/    \____/   \_/  \____/";

            CowBoy player = new CowBoy("Player", 18, rand.NextDouble() + 1);
            int currentRoll = CowBoy.roll();
            Console.WriteLine(welcome);
            // Console.WriteLine($"{player.Name} You must battle another amazing cowboy. The rules are simple, Shoot your enemy before \nthey shoot you! You only have  HP so be careful partner!");
            Console.WriteLine($"\n\nHello {player.Name}, you are {player.Age} years old, your luck is {player.Luck}");
            Console.WriteLine($"You rolled a {currentRoll}");
            Console.ReadKey();
        }
    }
}
