﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;
namespace Ragans
{
    class Thermal
    {
        //private Timer _timer;
        const int ObjectTableAddr = 0xDFBD98; //Latest
        Map mapData;
        private int _countDown = 10; //ms
        int interval = 10;

        void thermal_timer_Tick(object sender, EventArgs e)
        {
            _countDown -= 100;
            if (_countDown < 0)
            {
                _countDown = interval;
                thermalTimer();
            }
        }

        void thermalTimer()
        {
            mapData.forceThermalVision();
        }

        public Thermal(Map tempMap)
        {
            mapData = tempMap;
        }


        public void getStarted()
        {
            while (true) mapData.forceThermalVision();
        }
    }
}
