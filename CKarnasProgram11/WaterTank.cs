/* Program:         HW05 - Assignment 11
 * Developed by:    Christopher Karnas
 * Date Created:    October 2020
 * Last Modified:   11.03.20
 * Class Name:      Water Tank
 * Description:     Provides the level of water in a tank
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKarnasProgram11
{
    class WaterTank
    {
        #region"Constants"
        //declare any constants
        private int MinWaterLiters = 0;

        #endregion

        #region"Properties"
        //4 auto implemented instance properties

        public int Radius { get; private set; }
        public int Depth { get; private set; }
        public int WaterLevel { get; private set; }
        public int MaxCapacity { get; private set; }

        #endregion

        #region"Constructors"
        //constructor that instantiates an object and sets properties
        public WaterTank(int radius, int depth)
        {
            //set property values
            Radius = radius;
            Depth = depth;

            //call private method to set max water capacity
            MaxCapacity = CalculateMaxWaterCapacity();
        }

        #endregion

        #region"Methods"
        // private method to calculate max water capacity
        private int CalculateMaxWaterCapacity()
        {
            int capacity = Convert.ToInt32(Math.PI * Math.Pow(Radius, 2) * Depth * 1000);
            return capacity;
        }

        //public method to add water to the tank
        public string AddWater(int litersToAdd)
        {
            //declare variables
            int currentToFull = MaxCapacity - WaterLevel;
            string message = string.Empty;

            //if-else statement, with return
            if (litersToAdd <= currentToFull)
            {
                WaterLevel += litersToAdd;
                message = $"Liters increased by {litersToAdd} liters.\nThe tank's current level is {WaterLevel} liters.";
            }
            else
            {
                message = $"The tank will overflow. Water will not be added.\nThe current level right now is {WaterLevel}.\nYou can try again and add up to {currentToFull} liters to the tank.";
            }
            return message;
        }

        //public method to withdraw water from the tank
        public string WithdrawWater(int litersToWithdraw)
        {
            //declare variables
            int currentToEmpty = WaterLevel - MinWaterLiters;
            string message = string.Empty;

            //if else statement, with return
            if (litersToWithdraw <= currentToEmpty)
            {
                WaterLevel -= litersToWithdraw;
                message = $"Liters decreased by {litersToWithdraw} liters.\nThe tank's current level is {WaterLevel} liters.";
            }
            else
            {
                message = $"Unable to withdraw that many liters.\nThe current level right now is {WaterLevel}.\nThe total amount of water that can be withdrawn is {currentToEmpty} liters.";
            }
            return message;
        }

        //public method to fill the water tank at a set rate
        public bool FillTank(int litersPerSec)
        {
            //declare variables
            int currentToFull = MaxCapacity - WaterLevel;
            bool action = false;

            //if statement with return
            if (litersPerSec <= currentToFull)
            {
                WaterLevel += litersPerSec;
                action = true;
            }
            return action;
        }

        //public method to drain the water tank at a set rate
        public bool DrainTank(int litersPerSec)
        {
            //declare variables
            int currentToEmpty = WaterLevel - MinWaterLiters;
            bool action = false;

            //if statement with return
            if (litersPerSec <= currentToEmpty)
            {
                WaterLevel -= litersPerSec;
                action = true;
            }
            return action;
        }
        #endregion
    }
}
