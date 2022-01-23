using PlotlifyCSharp.enums;
using PlotlifyCSharp.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlifyCSharp.templates
{
    public abstract class Template : ITemplate, ITemplate2D
    {
        protected abstract String TEMPLATE_FILE {
            get;
        }

        protected static String XDATA_ID = "#XDATA";
	    protected static String YDATA_ID = "#YDATA";
	    protected static String TRACE_NAME_ID = "#TRACE_NAME";
	    protected static String MORE_TRACES_ID = "//#MORE_TRACES";
	    protected static String TRACES_ID = "];//#TRACES";
	    protected static String MARKER_TYPE_ID = "#MARKER_TYPE";
	    protected static String PLOT_TYPE_ID = "#PLOT_TYPE";
	    protected static String XAXIS_TITLE = "#XAXIS_TITLE";
	    protected static String YAXIS_TITLE = "#YAXIS_TITLE";	
	    protected static String TITLE_ID = "#TITLE";
	
	    protected String loadedTemplate = null;
        protected int numberOfTraces = 1;

        /// <summary>
        /// Replace tag with attribute
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        protected void ReplaceTag(String id, String text)
        {
            this.loadedTemplate = this.loadedTemplate.Replace(id, text);
        }
        public void Export(string filePath)
        {
            //this.ReplaceDefault();
            PlotlifyHelper.WriteTextToFile(filePath, this.loadedTemplate);
        }

        public void Load()
        {
            this.loadedTemplate = PlotlifyHelper.ReadTextFromFile(TEMPLATE_FILE);
        }

        public void SetModeType(ModeType modeType)
        {
            this.ReplaceTag(MARKER_TYPE_ID, PlotlifyHelper.GetModeTypeText(modeType));
        }

        public void SetPlotType(PlotType plotType)
        {
            this.ReplaceTag(PLOT_TYPE_ID, PlotlifyHelper.GetPlotTypeText(plotType));
        }

        public void SetTitle(string title)
        {
            if (title != null)
            {
                this.ReplaceTag(TITLE_ID, title);
            }
        }

        public void SetXLabel(string xLabel)
        {
            if (xLabel != null)
            {
                this.ReplaceTag(XAXIS_TITLE, xLabel);
            }
        }

        public void SetYLabel(string yLabel)
        {
            if (yLabel != null)
            {
                this.ReplaceTag(YAXIS_TITLE, yLabel);
            }
        }

        public void ReplaceDefault()
        {
            throw new NotImplementedException();
        }

        public void SetData(double[] x, double[] y, string name)
        {
            PlotlifyHelper.CheckDimensions(x, y, null);
            if (x == null)
            {
                this.ReplaceTag(XDATA_ID, "[]");
            }
            else
            {
                this.ReplaceTag(XDATA_ID, x.ToString());
            }
            if (y == null)
            {
                this.ReplaceTag(YDATA_ID, "[]");
            }
            else
            {
                this.ReplaceTag(YDATA_ID, y.ToString());
            }
            if (name == null)
            {
                this.ReplaceTag(TRACE_NAME_ID, "trace" + this.numberOfTraces);
            }
            else
            {
                this.ReplaceTag(TRACE_NAME_ID, name);
            }
        }

        public void AddData(double[] x, double[] y, string name)
        {
            PlotlifyHelper.CheckDimensions(x, y, null);
            if (x != null && y != null)
            {
                ++this.numberOfTraces;
                if (name == null)
                {
                    name = "trace" + this.numberOfTraces;
                }
                // create the text for new trace
                StringBuilder sb1 = new StringBuilder();
                sb1.Append("\t\t\tvar trace").Append(this.numberOfTraces).Append(" = {\n")
                    .Append("\t\t\t\tx: ").Append(x.ToString()).Append(",\n")
                    .Append("\t\t\t\ty: ").Append(y.ToString()).Append(",\n")
                    .Append("\t\t\t\tmode: '").Append(MARKER_TYPE_ID).Append("',\n")
                    .Append("\t\t\t\ttype: '").Append(PLOT_TYPE_ID).Append("',\n")
                    .Append("\t\t\t\tname: '").Append(name).Append("'\n")
                    .Append("\t\t\t};\n")
                    .Append("\n")
                    .Append("\t\t\t").Append(MORE_TRACES_ID);

                this.ReplaceTag(MORE_TRACES_ID, sb1.ToString());

                StringBuilder sb2 = new StringBuilder();
                sb2.Append(", trace").Append(this.numberOfTraces).Append(TRACES_ID);
                this.ReplaceTag(TRACES_ID, sb2.ToString());
            }
        }
    }
}
