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
            try
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(name, $"Значение свойства '{name}' должно быть положительным, получено {value}.");
                }
                return value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static double AssertOnPositiveValue(double value, string name)
        {
            try
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(name, $"Значение свойства '{name}' должно быть положительным, получено {value}.");
                }
                return value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static int AssertValueInRange(int value, int min, int max, string name)
        {
            try
            {
                if (value < min || value > max)
                {
                    throw new ArgumentOutOfRangeException(name, $"Значение свойства '{name}' должно быть в диапазоне от {min} до {max}, получено {value}.");
                }
                return value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static double AssertValueInRange(double value, double min, double max, string name)
        {
            try
            {
                if (value < min || value > max)
                {
                    throw new ArgumentOutOfRangeException(name, $"Значение свойства '{name}' должно быть в диапазоне от {min} до {max}, получено {value}.");
                }
                return value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        //try catch//др вар соб вместо textchanged

    }
}
//$"Значение свойства '{name}' должно быть в диапазоне от {min} до {max}, получено {value}.\nВведите значение для '{name}' от {min} до {max}:"
//$"Значение свойства '{name}' должно быть положительным, получено {value}.\nВведите положительное значение для '{name}':"

        /*public static double AssertValueInRange(double value, double min, double max, string name)
        {
            if (value < min || value > max)
            {
                //throw new ArgumentException($"Значение свойства '{name}' должно быть в диапазоне от {min} до {max}, получено {value}.");
                MessageBox.Show($"Значение свойства '{name}' должно быть в диапазоне от {min} до {max}, получено {value}.",
                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return value;
        }*/
/*public static double AssertValueInRange(double value, double min, double max, string name)
        {
            while (true)
            {
                if (value >= min && value <= max)
                {
                    return value;
                }
                else
                {
                    using (var inputDialog = new InputDialog())
                    {
                        if (inputDialog.ShowDialog() == DialogResult.OK)
                        {
                            if (double.TryParse(inputDialog.InputText, out double newValue))
                            {
                                value = newValue;
                            }
                            else
                            {
                                MessageBox.Show("Некорректное число. Попробуйте снова.", "Ошибка");
                            }
                        }
                    }
                }
            }
        }*/