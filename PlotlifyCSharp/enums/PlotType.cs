using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlifyCSharp.enums
{
    public enum PlotType
    {
        SCATTER = 0,
        BAR = 1,
        PIE = 2,
        SCATTER3D = 3
    }

    public class PlotTypeModel
    {
        public string Type { get; set; }
        private PlotTypeModel(PlotType type)
        {
            var typeText = String.Empty;
            switch (type)
            {
                case PlotType.SCATTER:
                    typeText = "scatter";
                    break;
                case PlotType.BAR:
                    typeText = "bar";
                    break;

                case PlotType.PIE:
                    typeText = "pie";
                    break;
                case PlotType.SCATTER3D:
                    typeText = "scatter3d";
                    break;
            }
            this.Type = typeText;
        }

        public override string ToString()
        {
            return this.Type;
        }
    }
}
