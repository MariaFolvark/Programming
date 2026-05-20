using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные дисциплины.
    /// </summary>
    internal class Discipline
    {
        /// <summary>
        /// Название.
        /// </summary>
        private string name = "Undefined";
        /// <summary>
        /// Академические часы.
        /// </summary>
        private int academic_hours;
        /// <summary>
        /// Зачётные единицы.
        /// </summary>
        private int credit_units;
        /// <summary>
        ///Оценка.
        /// </summary>
        private int grade;

        /// <summary>
        /// Возвращает и задает имя.
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        /// <summary>
        /// Возвращает и задает академические часы. Значение должно быть положительным.
        /// </summary>
        public int AcademicHours { get { return academic_hours; }
            set
            {
                academic_hours = Validator.AssertOnPositiveValue(value, nameof(academic_hours));
            }
        }
        /// <summary>
        /// Возвращает и задает зачётные единицы. Значение должно быть положительным.
        /// </summary>
        public int CreditUnits { get { return credit_units; }
            set
            {
                credit_units = Validator.AssertOnPositiveValue(value, nameof(credit_units));
            }
        }
        /// <summary>
        /// Возвращает и задает оценку. Значение должно быть от 3 до 5.
        /// </summary>
        public int Grade { get { return grade; }
            set
            {
                grade = Validator.AssertValueInRange(value, 3, 5, nameof(grade));
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="academic_hours">Длина.</param>
        /// <param name="credit_hours">Ширина.</param>
        /// <param name="grade">Цвет.</param>
        public Discipline(string name, int academic_hours, int credit_hours, int grade) 
        {
            this.Name = name;
            this.AcademicHours = academic_hours;
            this.CreditUnits = credit_hours;
            this.Grade = grade;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        public Discipline() { }

    }
}

/*if (value >= 0)
    academic_hours = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Количество часов должно быть не меньше 0.");*/
/*if (value >= 0)
    credit_units = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Количество зачётных единиц должно быть не меньше 0.");*/
/*if (value > 2 && value < 6)
    grade = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Оценка должна быть в диапазоне от 3 до 5.");*/
