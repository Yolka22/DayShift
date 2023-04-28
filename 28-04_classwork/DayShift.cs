using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace _28_04_classwork
{
    internal sealed class DayShiftExctension: MarkupExtension
    {

        private readonly int _dayShift;

        public DayShiftExctension(int dayShift)
        {

            _dayShift = dayShift;

        }


        public DayShiftExctension()
        {
            _dayShift = 0;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            string day_of_week = DateTime.Now.AddDays(_dayShift).DayOfWeek.ToString();
            return day_of_week;
        }
    }
}
