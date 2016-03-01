using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComperssionatorConsole_JayTsai_113719
{
    static class Program
    {
        [STAThread]
        static void Main( string[] args )
        {
            char choose;
            int x;
            Console.WriteLine( "Do you want use GUI? y/n" );
            x = Console.Read();
            choose = Convert.ToChar( x );
            if( choose == 'y' )
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault( false );
                Application.Run( new Form1() );
            }
            else
            {

            }
        }
    }
}
