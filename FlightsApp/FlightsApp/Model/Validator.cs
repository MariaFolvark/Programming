using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightsApp.Model
{
    /// <summary>
    /// Валидатор. Проверяет значения.
    /// </summary>
    internal class Validator
    {
        /// <summary>
        /// Проверяет, является ли значение положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Проверяемая переменная.</param>
        /// <returns>Возвращает значение, если оно положительное.</returns>
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

        /// <summary>
        /// Проверяет, является ли значение положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Проверяемая переменная.</param>
        /// <returns>Возвращает значение, если оно положительное.</returns>
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

        /// <summary>
        /// Проверяет, находится ли значение в заданном диапазоне.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <param name="name">Переменная.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Проверяет, находится ли значение в заданном диапазоне.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <param name="name">Переменная.</param>
        /// <returns></returns>
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
