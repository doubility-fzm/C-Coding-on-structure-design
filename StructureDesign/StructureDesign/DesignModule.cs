using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StructureDesign
{
    static class Constants
    {
        public const double TH_PA = 1.89e8;
        public const double TH_CA = 2.1e8;
        public const double PARAMETER_REDUCE = 0.8;
        public const double STEEL_INTENSITY = 78500;
        public const double spanOfBridge = 30.0;
        public const double widthOfLane = 3.75;
        public const double widthOfleftshouder = 2.5;
        public const double widthOfrightshouder = 2.5;
        public const double widthOfmedialIsland = 2;
        public const int laneNums = 4;
        public const double add = 0.5;
        public enum Vehicle_Load { lord_i, lord_ii };
    }

    public class Technical_Demand
    {
        const double spanOfBridge = 30.0;
        private double widthOfBridge { get; set; }
        /*       private double widthOfLane { get; set; }
               private int laneNums { get; set; }
               private double spanOfBridge { get; set; }
               private double widthOfleftshouder { get; set; }
               private double widthOfrightshouder { get; set; }
               private double widthOfmedialIsland { get; set; }
               private enum Vehicle_Load { lord_i,lord_ii};

               public double Get_SpanOfBridge()
               {
                   Console.WriteLine("请输入计算跨径");
                   spanOfBridge = Convert.ToDouble(Console.ReadLine());
                   return spanOfBridge;
               }

               public double Get_WidthOfLane()
               {
                   Console.WriteLine("请输入车道宽度");
                   widthOfLane= Convert.ToDouble(Console.ReadLine());
                   return widthOfLane;
               }

               public int Get_LaneNums()
               {
                   Console.WriteLine("请输入车道数量");
                   laneNums = Convert.ToInt32(Console.ReadLine());
                   return laneNums;
               }

               public double Get_WidthOfrightshouder()
               {
                   Console.WriteLine("请输入右侧硬路肩宽度");
                   widthOfrightshouder = Convert.ToDouble(Console.ReadLine());
                   return widthOfrightshouder;
               }

               public double Get_WidthOfleftshouder()
               {
                   Console.WriteLine("请输入左侧硬路肩宽度");
                   widthOfleftshouder= Convert.ToDouble(Console.ReadLine());
                   return widthOfleftshouder;
               }

               public double Get_WidthOfmedialIsland()
               {
                   Console.WriteLine("请输入中央分隔带宽度");
                   widthOfmedialIsland = Convert.ToDouble(Console.ReadLine());
                   return widthOfmedialIsland;
               }
       */
        public double Get_WidthOfBridge()
        {
            widthOfBridge = Constants.widthOfleftshouder + Constants.widthOfrightshouder + Constants.widthOfmedialIsland + Constants.widthOfLane * Constants.laneNums * 2 + Constants.add * 2;
            /*           Console.WriteLine("the width of bridge is :");
                       Console.WriteLine(widthOfBridge);*/
            return widthOfBridge;
        }

        public void Write_Info2TXT()
        {
            StreamWriter sw = new StreamWriter("DesignInfo.txt");
            sw.WriteLine("Design Information is belowing:");
            string str = "";
            sw.WriteLine(str.PadRight(40, '-'));
            sw.WriteLine("The Span Of Bridge is {0}m", Constants.spanOfBridge);
            sw.WriteLine("The Width Of Lanes is {0}m", Constants.widthOfLane);
            sw.WriteLine("The Num Of the lane are {0}", Constants.laneNums);
            sw.WriteLine("The Width Of LeftShouder is {0}m", Constants.widthOfleftshouder);
            sw.WriteLine("The Width Of RightShouder is {0}m", Constants.widthOfrightshouder);
            sw.WriteLine("The Width Of widthOfmedialIsland {0}m", Constants.widthOfmedialIsland);
            sw.WriteLine("The Vehicle Load is {0}", Constants.Vehicle_Load.lord_i);
            sw.WriteLine("The Width Of Bridge is {0}m", Get_WidthOfBridge());
            sw.WriteLine(str.PadRight(40, '-'));
            sw.Close();
        }
    }

    class CrossSection
    {
        private int girder_nums { get; set; }
        private double width_flange { get; set; }
        private double girder_gap { get; set; }

    }
    class DesignModule
    {
    }
}
