using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ServiceProcess;

namespace Ragans
{
    public partial class MapForm : Form
    {

        Map mapData = new Map();
        private int _countDown = 100; //ms
        private Timer _timer;

        public bool StayCentered = false;
        public bool setNoFatigue = false;
        public bool setNoRecoil = false;
        public float teleXCoord;
        public float teleYCoord;

        public bool BEStopped = false;

        public bool Show_Players = false;
        public bool Show_AI = false;
        public bool Show_Vehicles = false;

        ServiceController myService = new ServiceController("BEService");

        public MapForm()
        {
            InitializeComponent();
            objImageViewer1.Paint += new PaintEventHandler(mapData.refreshMap);
            //objImageViewer1.Image = 
            _timer = new Timer();
            _timer.Interval = 100;
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Stop();
        }

        private void StayCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (!StayCentered)
                StayCentered = true;
            else
                StayCentered = false;

        }



        private void TeleportButton_Click_1(object sender, EventArgs e)
        {
            teleXCoord = float.Parse(TeleX.Text, System.Globalization.CultureInfo.InvariantCulture);
            teleYCoord = float.Parse(TeleY.Text, System.Globalization.CultureInfo.InvariantCulture);
            mapData.teleport(teleXCoord, teleYCoord);
        }

        private void NoFatigue_CheckedChanged(object sender, EventArgs e)
        {
            if (!setNoFatigue)
                setNoFatigue = true;
            else
                setNoFatigue = false;

        }



        private void NoRecoil_CheckedChanged(object sender, EventArgs e)
        {
            if (!setNoRecoil)
                setNoRecoil = true;
            else
                setNoRecoil = false;

        }





        private void zoombar_Scroll(object sender, EventArgs e)
        {
            objImageViewer1.Zoom = 1 + .2F * (zoombar.Value);
            //objImageViewer1.Zoom += .1F * (objImageViewer1.Zoom);
            mapData.setZoomCoefficient(objImageViewer1.Zoom);
        }

        private void refTick_CheckedChanged(object sender, EventArgs e)
        {
            if (_timer.Enabled)
            {
                _timer.Stop();
            }
            else
            {
                _timer.Start();
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            _countDown -= 100;
            if (_countDown < 0)
            {
                _countDown = Convert.ToInt32(refTimer.Text);
                mapTimer();
            }
        }

        private void mapTimer()
        {
            mapData.setTime(1280000);

            if (StayCentered)
            {
                float[] playerCoords = mapData.myCoords();
                Point AP = objImageViewer1.AutoScrollPosition;

                playerCoords[0] = playerCoords[0] * objImageViewer1.Zoom - 500;
                playerCoords[1] = playerCoords[1] * objImageViewer1.Zoom - 500;
                AP = new Point((int)playerCoords[0], (int)playerCoords[1]);
                objImageViewer1.AutoScrollPosition = AP;
            }

            if (setNoFatigue)
            {
                mapData.setFatigue(0.0f);
            }

            if (setNoRecoil)
            {
                mapData.setRecoil(0.00001f);
            }

            float range = mapData.getRange();


        
            objImageViewer1.Invalidate();
        }

        private void ThermalBox_CheckedChanged(object sender, EventArgs e)
        {
            mapData.startThermalThread();
        }

        private void NeafTele_Click(object sender, EventArgs e)
        {
            teleXCoord = 12500;
            teleYCoord = 13110;
            mapData.teleport(teleXCoord, teleYCoord);

        }

        private void DavidTele_Click(object sender, EventArgs e)
        {
            teleXCoord = 11800;
            teleYCoord = 7610;
            mapData.teleport(teleXCoord, teleYCoord);

        }

        private void NwafTele_Click(object sender, EventArgs e)
        {
            teleXCoord = 4850;
            teleYCoord = 11210;
            mapData.teleport(teleXCoord, teleYCoord);

        }

        private void BalotaTele_Click(object sender, EventArgs e)
        {
            teleXCoord = 5050;
            teleYCoord = 2710;
            mapData.teleport(teleXCoord, teleYCoord);

        }

        private void ElektroTele_Click(object sender, EventArgs e)
        {
            teleXCoord = 9950;
            teleYCoord = 2910;
            mapData.teleport(teleXCoord, teleYCoord);

        }

        private void DevilsTele_Click(object sender, EventArgs e)
        {
            teleXCoord = 6650;
            teleYCoord = 11610;
            mapData.teleport(teleXCoord, teleYCoord);

        }

        private void MapForm_Load(object sender, EventArgs e)
        {

        }

        private void TeleX_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpZ_Click(object sender, EventArgs e)
        {
            mapData.teleportZ();
        }

        private void DownZ_Click(object sender, EventArgs e)
        {
            mapData.teleportZDown();
        }


        private void ShowPlayersBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Show_Players)
            {
                mapData.ShowPlayers_ = true;
                Show_Players = true;
            }
            else
            {
                mapData.ShowPlayers_ = false;
                Show_Players = false;
            }
        }

        private void ShowAIBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Show_AI)
            {
                mapData.ShowAI_ = true;
                Show_AI = true;
            }
            else
            {
                mapData.ShowAI_ = false;
                Show_AI = false;
            }

        }

        private void ShowVehiclesBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Show_Vehicles)
            {
                mapData.ShowVehicles_ = true;
                Show_Vehicles = true;
            }
            else
            {
                mapData.ShowVehicles_ = false;
                Show_Vehicles = false;
            }

        }

        private void FixLegs_Click(object sender, EventArgs e)
        {
            mapData.FixLegs();
        }

        private void StopBE_Click(object sender, EventArgs e)
        {
            if (!BEStopped)
            {
                BEStopped = true;
                myService.Stop();
            }

            else if(BEStopped)
            {
                BEStopped = false;
                myService.Start();
            }
        }

















    }
}
