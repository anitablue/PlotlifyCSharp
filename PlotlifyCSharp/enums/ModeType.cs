using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlifyCSharp.enums
{
    public enum ModeType
    {
        MARKERS = 0,
        LINES = 1, 
        LINES_MARKERS = 2
    }

    public class ModeTypeModel
    {
        public string Type { get; set; }
        private ModeTypeModel(ModeType type)
        {
            var typeText = String.Empty;
            switch (type)
            {
                case ModeType.MARKERS:
                    typeText = "markers";
                    break;
                case ModeType.LINES:
                    typeText = "lines";
                    break;

                case ModeType.LINES_MARKERS:
                    typeText = "markers";
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
