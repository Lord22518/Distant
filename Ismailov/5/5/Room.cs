using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class Room
    {
        double roomLength;// длина комнаты
        double roomWidth;// ширина комнаты
        public double RoomLength 
        {
            get { return roomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// метод вычисляет преиметр комнаты
        /// </summary>
        /// <returns>возвращает значения периметра</returns>
        public double RoomPerimeter()
        { return 2 * (roomLength + roomWidth); }
        /// <summary>
        /// метод вычисляет площадь комнаты
        /// </summary>
        /// <returns>возвращает значения площади</returns>
        public double RoomArea()
        { return roomLength * roomWidth; }
        /// <summary>
        /// метод вычисляет площадь на одного человека
        /// </summary>
        /// <param name="np"></param>
        /// <returns>число квадратных метров на одного человека</returns>
        public double PersonArea(int np)
        { return RoomArea() / np; }
        public virtual string Info()
        {
            return "Комната площадью " + RoomArea() + "кв.м";
        }
    }
    public class LivingRoom : Room
    {
        int numWin;// число окон
        public int NumWin
        { get { return numWin; } set { numWin = value; } }
        public override string Info()
        {
            return "Жилая комната площадью" + RoomArea() + "кв.м, с " + numWin + " окнами";

        }
    }
        public class Office : Room 
        {
            int numSocets;// число розеток
            public int NumSocets
            { get { return numSocets; } set { numSocets = value; } }
            public int NumWorkplaces()
            {
                int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
                return Math.Min(num, numSocets);
            }
            public override string Info()
            {
                return "Офис на " + NumWorkplaces() + " рабочих мест";
            }
        }
    
}
