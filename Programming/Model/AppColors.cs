using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class AppColors
    {
        // валидация
        public static readonly Color ValidationError = Color.FromArgb(33, 150, 243); // Синий

        // пересечения прямоугольников
        public static readonly Color RectangleOk = Color.FromArgb(127, 127, 255, 127); // Зеленый
        public static readonly Color RectangleIsSelected = Color.FromArgb(200, 255, 255, 0);  // Желтый
        public static readonly Color RectanglesIntersect = Color.FromArgb(127, 255, 127, 127); // Красный

        // времена года
        public static readonly Color Spring = Color.FromArgb(60, 179, 113);    // Весна (зеленый)
        public static readonly Color Summer = Color.FromArgb(255, 193, 7);     // Лето (солнечный)
        public static readonly Color Autumn = Color.FromArgb(255, 87, 34);     // Осень (оранжевый)
        public static readonly Color Winter = Color.FromArgb(96, 125, 139);    // Зима (голубой)
    }
}
