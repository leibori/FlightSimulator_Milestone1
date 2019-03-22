using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        public string Name { get; }
        public string Type { get; }
        List<Func<double, double>> ListMission { get; }
        public ComposedMission(string name)
        {
            Name = name;
            Type = "Composed";
            ListMission = new List<Func<double, double>>();
        }
        public ComposedMission Add(Func<double, double> func)
        {
            ListMission.Add(func);
            return this;
        }
        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            foreach(var miss in ListMission)
            {
                value = miss(value);
            }
            OnCalculate?.Invoke(this, value);

            //    value = mission.Invoke(value);
            return value;
        }


    }
}
