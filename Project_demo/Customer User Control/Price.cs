using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_demo.Customer_User_Control
{
    class Price
    {
        private static int user_id = 0;
        private static int hotelPrice = 0;
        private static int guidePrice = 0;
        private static int tentPrice = 0;
        private static int vehiclePrice = 0;



        private static int hotelRoomId = 0;
        private static int guideId = 0;
        private static int tentId = 0;
        private static int vehicleId = 0;


        public Price()
        {

        }

        public static void setUserId(int value)
        {
            user_id = value;
        }

        public static int getUserId()
        {
            return user_id;
        }

        public static void setHotelPrice(int value)
        {
            hotelPrice = value;
        }

        public static int getHotelPrice()
        {
            return hotelPrice;
        }

        public static void setHotelId(int value)
        {
            hotelRoomId = value;
        }

        public static int getHotelId()
        {
            return hotelRoomId;
        }

        public static void setGuidePrice(int value)
        {
            guidePrice = value;
        }

        public static int getGuidePrice()
        {
            return guidePrice;
        }
        public static void setGuideId(int value)
        {
            guideId = value;
        }

        public static int getGuideId()
        {
            return guideId;
        }
        public static void setTentPrice(int value)
        {
            tentPrice = value;
        }

        public static int getTentPrice()
        {
            return tentPrice;
        }
        public static void setTentId(int value)
        {
            tentId = value;
        }

        public static int getTentId()
        {
            return tentId;
        }
        public static void setVehicleId(int value)
        {
            vehicleId = value;
        }

        public static int getVehicleId()
        {
            return vehicleId;
        }

        public static void setVehiclePrice(int value)
        {
            vehiclePrice = value;
        }

        public static int getVehiclePrice()
        {
            return vehiclePrice;
        }

        public static int getTotal()
        {
            return vehiclePrice + guidePrice + tentPrice + hotelPrice;
        }
    }
}
