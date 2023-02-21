using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_Module
{
    public class Program
    {
        /// Resturant Management system
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false);
            
            Kitchen k = new Kitchen();
            k.startupTicketReset();
                        
            dishes.resetDishes();
            Order.resetOrder();

            Home main= new Home();
            Application.Run(main);
        }
    }
}
