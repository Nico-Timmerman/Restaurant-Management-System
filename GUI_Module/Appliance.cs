﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Module
{
    public class Appliance
    {
        public bool powerStatus { get; set; }
        float temperature { get; set; }

        public Appliance()
        {
            powerStatus = false;
            temperature = 0;
        }

        //GUI Calls this method when a power button is pressed
        public void PowerSwitch()
        {
            this.powerStatus = !powerStatus; //Flips the power switch bool to represent power on/off
        }


    }

    public class Grill : Appliance
    {
       
    }

    public class Fryer : Appliance
    {

    }
}