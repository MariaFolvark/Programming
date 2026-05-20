using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит цвета для элементов программы.
    /// </summary>
    internal class AppColors
    {
        // валидация
        /// <summary>
        /// Синий цвет для валидации.
        /// </summary>
        public static readonly Color ValidationError = Color.FromArgb(33, 150, 243); // Синий

        // пересечения прямоугольников
        /// <summary>
        /// Зелёный цвет для покраски прямоугольников, которые не пересекаются.
        /// </summary>
        public static readonly Color RectangleOk = Color.FromArgb(127, 127, 255, 127);
        /// <summary>
        /// Жёлтый цвет для покраски прямоугольника, которй выбран пользователем.
        /// </summary>
        public static readonly Color RectangleIsSelected = Color.FromArgb(200, 255, 255, 0);
        /// <summary>
        /// Красный цвет для покраски прямоугольников, которые пересекаются.
        /// </summary>
        public static readonly Color RectanglesIntersect = Color.FromArgb(127, 255, 127, 127);

        // времена года
        /// <summary>
        /// Зелёный цвет для ассоциации с весной.
        /// </summary>
        public static readonly Color Spring = Color.FromArgb(60, 179, 113);
        /// <summary>
        /// Жёлтый цвет для ассоциации с летом.
        /// </summary>
        public static readonly Color Summer = Color.FromArgb(255, 193, 7);
        /// <summary>
        /// Оранжевый цвет для ассоциации с осенью.
        /// </summary>
        public static readonly Color Autumn = Color.FromArgb(255, 87, 34);
        /// <summary>
        /// Голубой цвет для ассоциации с зимой.
        /// </summary>
        public static readonly Color Winter = Color.FromArgb(96, 125, 139);
    }
}
