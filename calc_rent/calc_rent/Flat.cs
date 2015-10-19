using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calc_rent
{
   public struct fixedprice
    {
        public bool exists;
        public float price;
    }
   public struct service
    {
        public bool exists;
        public bool metered;
    }
  public class Flat
    {

        public int number { get; set; }
        public int inhabitants { get; set; }
        public int area { get; set; }
        public int floor { get; set; }
        public fixedprice ren;
        public fixedprice cleanup;
        public fixedprice elev;
        public fixedprice heat;
        public fixedprice misc;
        public service elec;
        public service hotwater;
        public service coldwater;
        public service gas;

         public Flat()
         {
             number = 0;
             inhabitants = 0;
             area = 0;
             floor = 0;

         }
         public float calcprice()
         {

             return 0;
         }       

    }
}
