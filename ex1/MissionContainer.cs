using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public class FunctionsContainer
    {
        private Dictionary<String, Func<double, double>> dico { get; set; }
        public FunctionsContainer()
        {
            dico = new Dictionary<string, Func<double, double>>();
        }
        public Func<double, double> this[string index]
        {
            get
            {
                if (dico.ContainsKey(index))
                {
                    return dico[index];
                }
                return val => val;
            }
            set
            {
                this.dico[index] = value;
            }
        }

        public List<IMission> getAllMissions()
        {
            var fuctionListNames = new List<IMission>();
            foreach (var funcName in fuctionListNames)
            {
                fuctionListNames.Add(funcName);
            }
            return fuctionListNames;
        }
    }
}

