using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    internal class Validator
    {

        /// <summary>
        /// Проверяет, что длина строки не превышает заданное максимальное число символов.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="max">Максимальная допустимая длина строки.</param>
        /// <param name="name">Переменная.</param>
        /// <returns>Возвращает строку, если она корректна.</returns>
        public static string AssertStringLength(string value, int max, string name)
        {
            try
            {
                if (value == null)
                {
                    throw new ArgumentNullException(name, $"Значение свойства '{name}' не может быть null.");
                }

                if (value.Length > max)
                {
                    throw new ArgumentOutOfRangeException(name, $"Значение свойства '{name}' должно содержать до {max} символов, получено {value.Length}.");
                }

                return value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (ArgumentNullException ex)
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
        /// <returns>Возвращает значение, если оно корректно.</returns>
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
    }
}
