using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlifyCSharp.templates
{
    public interface ITemplate2D
    {
        public void SetData(double[] x, double[] y, String name);
        public void AddData(double[] x, double[] y, String name);
    }
}
