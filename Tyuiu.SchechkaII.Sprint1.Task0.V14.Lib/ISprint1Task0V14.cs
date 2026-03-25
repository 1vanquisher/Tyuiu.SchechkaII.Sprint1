using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SchechkaII.Sprint1.Task0.V14.Lib
{
    public interface ISprint1Task0V14
    {
        /// <summary>
        /// Вычисляет значение выражения x*5*a + 2*y
        /// </summary>
        /// <param name="x">Первый множитель</param>
        /// <param name="a">Второй множитель</param>
        /// <param name="y">Слагаемое</param>
        /// <returns>Результат вычисления</returns>
        double Calculate(double x, double a, double y);
    }
}
