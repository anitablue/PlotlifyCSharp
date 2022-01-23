using PlotlifyCSharp.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlifyCSharp.templates
{
    public interface ITemplate
    {
		public void Load();
		public void Export(String filePath);
		public void SetTitle(String title);
		public void SetXLabel(String xLabel);
		public void SetYLabel(String yLabel);
		public void SetModeType(ModeType modeType);
		public void SetPlotType(PlotType plotType);
		public void ReplaceDefault();
	}
}
