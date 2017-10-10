using System;
using System.IO;

namespace MegaDesk_3_RyanMontgomery {
    class DeskQuote {
        public const float BASE_DESK_PRICE = 200;
        public const int SURFACE_AREA_BREAK_POINT = 1000;
        public const int SHIPPING_LARGE_BREAK_POINT = 2000;
        public const int SHIPPING_MEDIUM_BREAK_POINT = 1000;
        public const float EXTRA_SURFACE_AREA_PRICE = 1;
        public const float OAK_PRICE = 200;
        public const float LAMINATE_PRICE = 100;
        public const float PINE_PRICE = 50;
        public const float ROSEWOOD_PRICE = 300;
        public const float VENEER_PRICE = 125;
        public const float DRAWER_PRICE = 50;
        public const float THREE_DAY_SMALL_RUSH_PRICE = 60;
        public const float THREE_DAY_MEDIUM_RUSH_PRICE = 70;
        public const float THREE_DAY_LARGE_RUSH_PRICE = 80;
        public const float FIVE_DAY_SMALL_RUSH_PRICE = 40;
        public const float FIVE_DAY_MEDIUM_RUSH_PRICE = 50;
        public const float FIVE_DAY_LARGE_RUSH_PRICE = 60;
        public const float SEVEN_DAY_SMALL_RUSH_PRICE = 30;
        public const float SEVEN_DAY_MEDIUM_RUSH_PRICE = 35;
        public const float SEVEN_DAY_LARGE_RUSH_PRICE = 40;

        private float[,] shippingInfo = new float[3, 3];
        public string CustomerName { get; set; }
        public Desk MyDesk { get; set; }
        public int RushDays { get; set; }
        public string QuoteDateTime { get; set; }

        public int SurfaceArea() {
            return MyDesk.Width * MyDesk.Depth;
        }

        public float SurfaceAreaPrice() {
            if (SurfaceArea() > SURFACE_AREA_BREAK_POINT)
                return ((float)SurfaceArea() - (float)SURFACE_AREA_BREAK_POINT) * EXTRA_SURFACE_AREA_PRICE;
            else
                return 0;
        }

        public float DrawerPrice() {
            return (float)MyDesk.Drawers * DRAWER_PRICE;
        }

        public float MaterialPrice() {
            return (float)MyDesk.Material;
        }

        public float DeskPrice() {
            return BASE_DESK_PRICE + SurfaceAreaPrice() + MaterialPrice() + DrawerPrice();
        }

        public void ShippingPriceInitialization() {
            StreamReader file = new StreamReader(@"C:\MegaDesk\rushOrderPrices.txt");
            String line;

            try {
                for (int j = 0; j < 3; j++) {
                    for (int i = 0; i < 3; i++) {
                        line = file.ReadLine();
                        shippingInfo[i, j] = float.Parse(line);
                    }
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public float ShippingPrice() {
            int surfaceArea = SurfaceArea();
            int i, j;
            switch (RushDays) {
                case 3:
                    i = 2;
                    break;
                case 5:
                    i = 1;
                    break;
                case 7:
                    i = 0;
                    break;
                default:
                    return 0;
            }
            if (surfaceArea > SHIPPING_LARGE_BREAK_POINT)
                j = 0;
            else if (surfaceArea > SHIPPING_MEDIUM_BREAK_POINT)
                j = 1;
            else
                j = 2;

            return shippingInfo[i, j];
        }

        //Old Version
        //public float _ShippingPrice() {
        //    switch (RushDays) {
        //        case 3:
        //            if (SurfaceArea() > SHIPPING_LARGE_BREAK_POINT)
        //                return THREE_DAY_LARGE_RUSH_PRICE;
        //            else if (SurfaceArea() > SHIPPING_MEDIUM_BREAK_POINT)
        //                return THREE_DAY_MEDIUM_RUSH_PRICE;
        //            else
        //                return THREE_DAY_SMALL_RUSH_PRICE;

        //        case 5:
        //            if (SurfaceArea() > SHIPPING_LARGE_BREAK_POINT)
        //                return FIVE_DAY_LARGE_RUSH_PRICE;
        //            else if (SurfaceArea() > SHIPPING_MEDIUM_BREAK_POINT)
        //                return FIVE_DAY_MEDIUM_RUSH_PRICE;
        //            else
        //                return FIVE_DAY_SMALL_RUSH_PRICE;

        //        case 7:
        //            if (SurfaceArea() > SHIPPING_LARGE_BREAK_POINT)
        //                return SEVEN_DAY_LARGE_RUSH_PRICE;
        //            else if (SurfaceArea() > SHIPPING_MEDIUM_BREAK_POINT)
        //                return SEVEN_DAY_MEDIUM_RUSH_PRICE;
        //            else
        //                return SEVEN_DAY_SMALL_RUSH_PRICE;

        //        default:
        //            return 0;
        //    }
        //}

        public float TotalPrice() {
            return DeskPrice() + ShippingPrice();
        }

        public DeskQuote(string customerName, Desk desk, int rushDays, string quoteDateTime) {
            CustomerName = customerName;
            MyDesk = desk;
            RushDays = rushDays;
            QuoteDateTime = quoteDateTime;
            ShippingPriceInitialization();
        }
    }
}
