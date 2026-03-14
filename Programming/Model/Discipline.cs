using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Discipline
    {
        private string name = "Undefined";
        private int academic_hours;
        private int credit_units;
        private int grade;

        public string Name { get { return name; } set { name = value; } }

        public int AcademicHours { get {  return academic_hours; } set
            {
                if (value >= 0)
                    academic_hours = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "Количество часов должно быть не меньше 0.");
            }
        }
        public int CreditUnits { get { return credit_units; } set
            {
                if (value >= 0)
                    credit_units = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "Количество зачётных единиц должно быть не меньше 0.");
            }
        }
        public int Grade { get { return grade; } set
            {
                if (value > 2 && value < 6)
                    grade = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "Оценка должна быть в диапазоне от 3 до 5.");
            }
        }

    }
}
