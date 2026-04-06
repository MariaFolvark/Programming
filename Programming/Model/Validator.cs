using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Validator
    {
        public static int AssertOnPositiveValue(int value, string name)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение свойства '{name}' должно быть положительным, получено {value}.");
            }
            return value;
        }
        public static double AssertOnPositiveValue(double value, string name)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение свойства '{name}' должно быть положительным, получено {value}.");
            }
            return value;
        }
        public static int AssertValueInRange(int value, int min, int max, string name)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение свойства '{name}' должно быть в диапазоне от {min} до {max}, получено {value}.");
            }
            return value;
        }
        public static double AssertValueInRange(double value, double min, double max, string name)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение свойства '{name}' должно быть в диапазоне от {min} до {max}, получено {value}.");
            }
            return value;
        }
    }
}
