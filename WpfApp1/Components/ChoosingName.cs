using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Components
{
    internal class ChoosingName
    {
        public static string Name { get; set; }
        public static string choosingName(string name)
        {
            if (Name == "" || Name == null)
            {
                if (App.Role == "Warrior")
                {
                    Name = "ник - Воин";
                    return Name;
                }
                else if (App.Role == "Rogue")
                {
                    Name = "ник - Вор";
                    return Name;
                }
                else if (App.Role == "Wizard")
                {
                    Name = "ник - Маг";
                    return Name;
                }
                else
                {
                    return "Error";
                }
            }
            else
            {
                if (App.Role == "Warrior")
                {
                    Name = name + " - Воин";
                    return Name;
                }
                else if (App.Role == "Rogue")
                {
                    Name = name + " - Вор";
                    return Name;
                }
                else if (App.Role == "Wizard")
                {
                    Name = name + " - Маг";
                    return Name;
                }
                else
                {
                    return "Error";
                }
            }
        }
    }
}
