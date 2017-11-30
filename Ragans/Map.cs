using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Threading;

namespace Ragans
{
    class Map
    {

        // Vehicle Names
        string[] vehicleArray = new string[53] {
            "LandRover_TK_CIV_EP1",
            "Ural_INS",
            "ÁN2_DZ",
            "car_sedan",
            "UAZ_Unarmed_UN_EP1",
            "hilux1_civil_1_open",
            "SkodaGreen",
            "UralOpen_INS",
            "Skoda",
            "Volha_1_TK_CIV_EP1",
            "UAZ_Unarmed_TK_EP1",
            "hilux1_civil_3_open_EP1",
            "datsun1_civil_2_covered",
            "UAZ_Unarmed_TK_CIV_EP1",
            "HMMWV_DZ",
            "UAZ_Unarmed_TK_CIV_EP1",
            "hilux1_civil_2_covered",
            "SkodaRed",
            "UralCivil",
            "SUV_TK_EP1",
            "Volha_2_TK_CIV_EP1",
            "datsun1_TK_CIV_EP1",
            "datsun_civil_2_covered",
            "Lada1_TK_CIV_EP1",
            "UralCivil2",
            "VolhaLimo_TK_CIV_EP1",
            "SkodaBlue",
            "datsun1_civil_1_open",
            "car_hatchback",
            "Lada2_TK_CIV_EP1",
            "LandRover_CZ_EP1",
            "hilux1_civil_covered",
            "Ikarus_TK_CIV_EP1",
            "policecar",
            "Tractor",
            "TT650_Ins",
            "TT650_Civ",
            "Old_bike_TK_CIV_EP1",
            "Old_bike_TK_INS_EP1",
            "Ikarus",
            "V3S_Civ",
            "Ural_TK_CIV_EP1",
            "Lada2",
            "UAZ_CDF",
            "UAZ_RU",
            "hilux_civil_3_open",
            "hilux1_civil_3_open",
            "S1203_TK_CIV_EP1",
            "Smallboat_1",
            "smallboat_2",
            "PBX",
            "ATV_CZ_EP1",
            "ATV_US_EP1"
        };

        string[] Valuable = new string[2]{
            "MV22_DZ",
            ""
        };

        public bool ShowVehicles_ = false;
        public bool ShowPlayers_ = false;
        public bool ShowAI_ = false;


        // For Zoom (Don't Change)
        float zoomCoeffecicient = 1;

        Thread oThread;

        ProcessMemory Mem = new ProcessMemory("ArmA2OA");

        // Main Offset
        int objptr = 0xDA8208;


        public void setZoomCoefficient(float zCoef)
        {
            zoomCoeffecicient = zCoef;
        }
        public float getRange()
        {
            int rangePtr1 = Mem.ReadInt(objptr);
            int rangePtr2 = Mem.ReadInt(rangePtr1 + 0x8);

            float rangeValue = Mem.ReadFloat(rangePtr2 + 0x30);
            return rangeValue;

        }

        // Get My Struct
        public void getMe(object sender, PaintEventArgs e)
        {

            // My Struct
            int address1 = Mem.ReadInt(0xDA8208);
            int address2 = Mem.ReadInt(address1 + 0x13A8);
            int myPointer = Mem.ReadInt(address2 + 0x4);

            int coords = Mem.ReadInt(myPointer + 0x18);

            float[] myCoord = myCoords();
            float xPoint = myCoord[0];
            float yPoint = myCoord[1];

            int direction = 0x01C;
            float X = Mem.ReadFloat(coords + direction + 8);
            float Y = Mem.ReadFloat(coords + direction);
            double Dir = Math.Atan2(Y, X) * (180 / Math.PI);
            if (Dir < 0) Dir = 360 + Dir;

            Image bmp = RotateImage(global::Ragans.Properties.Resources.blue_arrow, (float)Dir);
            Font Arial = new Font("Arial", 8 * (1 / zoomCoeffecicient), FontStyle.Regular);
            Brush blueBrush = Brushes.Blue;

            e.Graphics.DrawImage(bmp, xPoint, yPoint, 10 * (1 / zoomCoeffecicient), 15 * (1 / zoomCoeffecicient));
            e.Graphics.DrawString("HERE I AM", Arial, blueBrush, xPoint + (12 / zoomCoeffecicient), yPoint + (3 / zoomCoeffecicient));
            e.Graphics.DrawString(getRange().ToString(), Arial, blueBrush, xPoint + (12 / zoomCoeffecicient), yPoint + (10 / zoomCoeffecicient));
            //e.Graphics.DrawString(Mem.ReadFloat(coords + 0x28).ToString(), Arial, blueBrush, xPoint + (12 / zoomCoeffecicient), yPoint + (10 / zoomCoeffecicient));
            //e.Graphics.DrawString(Mem.ReadFloat(coords + 0x30).ToString(), Arial, blueBrush, xPoint + (12 / zoomCoeffecicient), yPoint + (20 / zoomCoeffecicient));
        }

        public float[] myCoords()
        {
            int address1 = Mem.ReadInt(0xDA8208);
            int address2 = Mem.ReadInt(address1 + 0x13A8);
            int myPointer = Mem.ReadInt(address2 + 0x4);

            int coords = Mem.ReadInt(myPointer + 0x18);

            //float xPoint = ((Mem.ReadFloat(coords + 0x28)) / (10200.0f / 975.0f));
            //float yPoint = ((10200.0f - Mem.ReadFloat(coords + 0x30)) / (10200.0f / 975.0f));

            //float xPoint = ((Mem.ReadFloat(coords + 0x28)) / (25600.0f / 975.0f));
            //float yPoint = ((25600.0f - Mem.ReadFloat(coords + 0x30)) / (25600.0f / 975.0f));
            //float xPoint = ((Mem.ReadFloat(coords + 0x28)) / (15360.0f / 975.0f));
            //float yPoint = ((15360.0f - Mem.ReadFloat(coords + 0x30)) / (15360.0f / 975.0f));
            float xPoint = ((Mem.ReadFloat(coords + 0x28)) / (12800.0f / 599.0f));
            float yPoint = ((12800.0f - Mem.ReadFloat(coords + 0x30)) / (12800.0f / 599.0f));

            float[] myCoords = { xPoint, yPoint };
            return myCoords;
        }

        public void teleport(float LocX, float LocY)
        {
            int objTable = Mem.ReadInt(objptr);
            int objTablePtr = Mem.ReadInt(objTable + 0x13A8);
            int objTablePtr1 = Mem.ReadInt(objTablePtr + 0x4);
            int coords = Mem.ReadInt(objTablePtr1 + 0x18);
            Mem.WriteFloat(coords + 0x28, LocX);
            Mem.WriteFloat(coords + 0x30, LocY);
            Mem.WriteFloat(coords + 0x2C, 0f);
        }

        public void teleportZ()
        {
            int objTable = Mem.ReadInt(objptr);
            int objTablePtr = Mem.ReadInt(objTable + 0x13A8);
            int objTablePtr1 = Mem.ReadInt(objTablePtr + 0x4);
            int coords = Mem.ReadInt(objTablePtr1 + 0x18);
            float zcoord = Mem.ReadFloat(coords + 0x2c);
        
            Mem.WriteFloat(coords + 0x28, 0);


        }

        public void teleportZDown()
        {
            int objTable = Mem.ReadInt(objptr);
            int objTablePtr = Mem.ReadInt(objTable + 0x13A8);
            int objTablePtr1 = Mem.ReadInt(objTablePtr + 0x4);
            int coords = Mem.ReadInt(objTablePtr1 + 0x18);
            float zcoord = Mem.ReadFloat(coords + 0x2C);

            Mem.WriteFloat(coords + 0x2C, 123);


        }

        public String getWeapon(int objAddress)
        {
            int weaponID;
            String weaponName = " ";
            weaponID = Mem.ReadInt(objAddress + 0x678 + 0x68);

            if (weaponID != -1)
            {
                int tempPointer = Mem.ReadInt(objAddress + 0x0678 + 0x1c);

                tempPointer = Mem.ReadInt(tempPointer + 0x24 * weaponID + 0x8);

                tempPointer = Mem.ReadInt(tempPointer + 0x10);
                int weaponNameAddress = Mem.ReadInt(tempPointer + 0x4);
                if (weaponName != null)
                {
                    weaponName = readArmaString(weaponNameAddress);
                }
            }
            return weaponName;

        }

        public void setTime(float value)
        {
            Mem.WriteFloat(0xE256F8, value);
        }

        public void setFatigue(float value)
        {
            int objTable = Mem.ReadInt(objptr);
            int objTablePtr = Mem.ReadInt(objTable + 0x13A8);
            int objTablePtr1 = Mem.ReadInt(objTablePtr + 0x4);
            int fatigueAddress = objTablePtr1 + 0xC44;
            //int wanderXAddress = objTablePtr1 + 0xC64;
            //int wanderYAddress = objTablePtr1 + 0xC68;
            Mem.WriteFloat(fatigueAddress, value);
           // Mem.WriteFloat(wanderXAddress, value);
            //Mem.WriteFloat(wanderYAddress, value);
        }

        public void setRecoil(float value)
        {
            int objTable = Mem.ReadInt(objptr);
            int objTablePtr = Mem.ReadInt(objTable + 0x13A8);
            int objTablePtr1 = Mem.ReadInt(objTablePtr + 0x4);
            int recoilAddress = objTablePtr1 + 0xC28;
            Mem.WriteFloat(recoilAddress, 0);

        }

        public void fillVehicle(int entity)
        {
            int fuelLevelAddress = Mem.ReadInt(entity + 0x18);
            fuelLevelAddress = fuelLevelAddress + 0xAC;
            int fuelCapAddress = Mem.ReadInt(entity + 0x3C);
            fuelCapAddress = fuelCapAddress + 0x600;
            float fuelCap = Mem.ReadFloat(fuelCapAddress);
            float fuelLevel = Mem.ReadFloat(fuelLevelAddress);
            Mem.WriteFloat(fuelLevelAddress, fuelCap);
        }

        public void FixLegs()
        {
            int objTable = Mem.ReadInt(objptr);
            int objTablePtr = Mem.ReadInt(objTable + 0x13A8);
            int objTablePtr1 = Mem.ReadInt(objTablePtr + 0x4);
            int legAddress = Mem.ReadInt(objTablePtr1 + 0xC0);
            legAddress = legAddress + 0xC;
            Mem.WriteFloat(legAddress, 0);
        }

        public String readArmaString(int weaponNameAddress)
        {
            const int maxStringLength = 0x40;
            int absoluteLength = Mem.ReadInt(weaponNameAddress + 0x4);
            if (absoluteLength > maxStringLength)
            {
                return "";
            }

            return Mem.ReadStringAscii(weaponNameAddress + 8, absoluteLength);


        }

        public void startThermalThread()
        {
            if (oThread != null && oThread.IsAlive)
            {
                oThread.Abort();
                return;
            }
            Thermal thermal = new Thermal(this);
            oThread = new Thread(new ThreadStart(thermal.getStarted));
            oThread.Start();
        }

        public void forceThermalVision()
        {
            //0xDE20A8] + 13A8]+ 4]+C16]
            int objTable = Mem.ReadInt(objptr);
            int objTablePtr = Mem.ReadInt(objTable + 0x13A8);
            int objTablePtr1 = Mem.ReadInt(objTablePtr + 0x4);

            Mem.WriteBool(objTablePtr1 + 0xC18, true);



        }


        public static Image RotateImage(Image img, float rotationAngle)
        {
            Bitmap b = new Bitmap(img.Width, img.Height);
            Graphics graphic = Graphics.FromImage(b);
            graphic.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            graphic.RotateTransform(rotationAngle);
            graphic.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.DrawImage(img, new Point(0, 0));
            graphic.Dispose();
            return b;
        }

        String readNameTable(int playerNamePointer)
        {
            int nameLength = Math.Min(Mem.ReadInt(playerNamePointer + 0x4), 32);
            if (nameLength > 0)
                return Mem.ReadStringAscii(playerNamePointer + 8, nameLength);
            else
                return "readNameTableNull";
        }

        int getPlayerInfo(int id)
        {
            int currentObject = 0, idx, i = 0;
            int currentPointer = Mem.ReadInt(0xDA8208 + 0x24);
            int playerCount = Mem.ReadInt(currentPointer + 0x1C);
            currentPointer = Mem.ReadInt(currentPointer + 0x18);

            while (i < playerCount)
            {
                currentObject = currentPointer + i * 0x118; // Used to be F0

                idx = Mem.ReadInt(currentObject + 4);
                if (idx == id)
                {
                    return currentObject;
                }
                i++;

            }
            return 0;
        }

        String getPlayerName(int currentObject)
        {
            int currentItem;
            string playerID = Mem.ReadStringAscii(currentObject+ 0x8, 25);
            string playerName = "UnwrittenName";
            int nameID = Mem.ReadInt(currentObject + 0xAC8);

            if (nameID == 1)
            {
                currentItem = Mem.ReadInt(currentObject + 0xA20);
                playerName = readNameTable(currentItem);
                return playerName;

            }
            else if (nameID > 0)
            {
                currentItem = getPlayerInfo(nameID);
                if (currentItem != 0)
                {

                    playerID = readNameTable(Mem.ReadInt(currentItem + 0x30));
                    playerName = readNameTable(Mem.ReadInt(currentItem + 0xA8)); // used to be 80

                    return playerName;
                }
                else
                    return "NoMatch";
            }
            else
            {
                return nameID.ToString();
            }
        }



        public void refreshMap(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(global::Ragans.Properties.Resources.taviana, 0, 0, 980, 980);
            if (!Mem.CheckProcess())
            {
                //arrowhead is not running
            }
            else
            {
                Mem.StartProcess();



                int ObjTable = Mem.ReadInt(objptr);
                int objTablePtr = Mem.ReadInt(ObjTable + 0x5FC);
                int objTableArrayPtr = Mem.ReadInt(objTablePtr + 0x0);
                int objTableSize = Mem.ReadInt(objTablePtr + 0x4);

                for (int i = 0; i < objTableSize; i++)
                {

                    int objPtr = Mem.ReadInt(objTableArrayPtr + (i * 52));
                    int obj1 = Mem.ReadInt(objPtr + 0x4);
                    int obj2 = Mem.ReadInt(obj1 + 0x3C);
                    int obj3 = Mem.ReadInt(obj2 + 0x30);

                    string objName = Mem.ReadStringAscii(obj3 + 0x8, 25);
                    bool IsDead = (Mem.ReadByte(obj1 + 0x20C) > 0);
                    Image bmp;

                    String playerName = getPlayerName(obj1);

                    //Positions
                    float[] mine = myCoords();
                    float myX = mine[0];
                    float myY = mine[1];
                    int coords = Mem.ReadInt(obj1 + 0x18);

                    //float LocX = ((Mem.ReadFloat(coords + 0x28)) / (25600.0f / 975.0f));
                    //float LocY = ((25600.0f - Mem.ReadFloat(coords + 0x30)) / (25600.0f / 975.0f));

                    //float LocX = ((Mem.ReadFloat(coords + 0x28)) / (10200.0f / 975.0f));
                    //float LocY = ((10200.0f - Mem.ReadFloat(coords + 0x30)) / (10200.0f / 975.0f));

                    //float LocX = ((Mem.ReadFloat(coords + 0x28)) / (15360.0f / 975.0f));
                   // float LocY = ((15360.0f - Mem.ReadFloat(coords + 0x30)) / (15360.0f / 975.0f));
                    
                    float LocX = ((Mem.ReadFloat(coords + 0x28)) / (12800.0f / 599.0f));
                    float LocY = ((12800.0f - Mem.ReadFloat(coords + 0x30)) / (12800.0f / 599.0f));
                    
                    if (myX != LocX)
                    {
                        if (!IsDead)
                        {

                            // Players
                            if (playerName == "NoMatch" && ShowPlayers_ == true)
                            {
                                int direction = 0x01C;
                                float Y = Mem.ReadFloat(coords + direction);
                                float X = Mem.ReadFloat(coords + direction + 8);
                                double Dir = Math.Atan2(Y, X) * (180 / Math.PI);
                                if (Dir < 0) Dir = 360 + Dir;
                                bmp = RotateImage(global::Ragans.Properties.Resources.blue_arrow, (float)Dir);
                                e.Graphics.DrawImage(bmp, LocX, LocY, 10 * (1 / zoomCoeffecicient), 15 * (1 / zoomCoeffecicient));
                                Font Arial = new Font("Arial", 8 * (1 / zoomCoeffecicient), FontStyle.Regular);
                                Brush redBrush = Brushes.Blue;
                                e.Graphics.DrawString("Player: " + getWeapon(obj1), Arial, redBrush, LocX + (12 / zoomCoeffecicient), LocY + (3 / zoomCoeffecicient));
                                e.Graphics.DrawString(Mem.ReadFloat(coords + 0x28).ToString(), Arial, redBrush, LocX + (12 / zoomCoeffecicient), LocY + (12 / zoomCoeffecicient));
                                e.Graphics.DrawString(Mem.ReadFloat(coords + 0x30).ToString(), Arial, redBrush, LocX + (12 / zoomCoeffecicient), LocY + (20 / zoomCoeffecicient));

                                int xDifference = (int) Math.Abs(myX - Mem.ReadFloat(coords + 0x28));
                                int yDifference = (int) Math.Abs(myY - Mem.ReadFloat(coords + 0x30));
                                int xDiffSq = (int) Math.Pow(xDifference, 2);
                                int yDiffSq = (int) Math.Pow(yDifference, 2);
                                int distance = (int)Math.Sqrt(xDiffSq + yDiffSq);

                                //e.Graphics.DrawString(distance.ToString(), Arial, redBrush, LocX + (12 / zoomCoeffecicient), LocY + (12 / zoomCoeffecicient));
                            }

                            // Vehicles or AI
                            else if (ShowAI_ == true)
                            {
                                Brush redBrush = Brushes.Red;
                                Font Arial = new Font("Arial", 8 * (1 / zoomCoeffecicient), FontStyle.Regular);
                                int direction = 0x01C;
                                float Y = Mem.ReadFloat(coords + direction);
                                float X = Mem.ReadFloat(coords + direction + 8);
                                double Dir = Math.Atan2(Y, X) * (180 / Math.PI);
                                if (Dir < 0) Dir = 360 + Dir;
                                bmp = RotateImage(global::Ragans.Properties.Resources.red_arrow, (float)Dir);
                                e.Graphics.DrawImage(bmp, LocX, LocY, 10 * (1 / zoomCoeffecicient), 15 * (1 / zoomCoeffecicient));
                                e.Graphics.DrawString(objName, Arial, redBrush, LocX + (12 / zoomCoeffecicient), LocY + (3 / zoomCoeffecicient));

                            }
                        }

                        // Dead or Blown Up
                        else
                        {
                            Brush redBrush = Brushes.Red;
                            Font Arial = new Font("Arial", 8 * (1 / zoomCoeffecicient), FontStyle.Regular);
                            int direction = 0x01C;
                            float Y = Mem.ReadFloat(coords + direction);
                            float X = Mem.ReadFloat(coords + direction + 8);
                            double Dir = Math.Atan2(Y, X) * (180 / Math.PI);
                            if (Dir < 0) Dir = 360 + Dir;
                            bmp = RotateImage(global::Ragans.Properties.Resources.black_arrow, (float)Dir);
                            e.Graphics.DrawImage(bmp, LocX, LocY, 10 * (1 / zoomCoeffecicient), 15 * (1 / zoomCoeffecicient));
                            e.Graphics.DrawString(Mem.ReadFloat(coords + 0x2c).ToString(), Arial, redBrush, LocX + (12 / zoomCoeffecicient), LocY + (12 / zoomCoeffecicient));
                        }
                    }
                    else
                    {

                    }
                    
                }
                    getMe(sender, e);               
            }        
        }      
    }   
}




    