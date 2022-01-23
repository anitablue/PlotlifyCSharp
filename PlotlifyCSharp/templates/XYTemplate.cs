using PlotlifyCSharp.enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlifyCSharp.templates
{
    public class XYTemplate : Template
    {
		protected override String TEMPLATE_FILE
		{
			get
			{
				return "res" + "\\" + "html" + "\\" + "XY_TEMPLATE.html";
			}
		}
		public new void ReplaceDefault()
		{
			this.SetData(null, null, "trace" + this.numberOfTraces);
			this.SetPlotType(PlotType.SCATTER);
			this.SetModeType(ModeType.LINES_MARKERS);
			this.SetXLabel("X");
			this.SetYLabel("Y");
			this.SetTitle("trace" + this.numberOfTraces);
		}
	}
}
