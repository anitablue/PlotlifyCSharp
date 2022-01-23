using PlotlifyCSharp.enums;
using PlotlifyCSharp.helpers;
using PlotlifyCSharp.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlifyCSharp.source
{
    public class Plotlify
    {
		/// <summary>
		/// creates a line plot based on the double arrays passed with {@code x} and {@code y} and exports it as html file under specified {@code filePath}
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public static void line(String filePath, double[] x, double[] y)
		{
			line(filePath, x, y, null, null, null, null);
		}

		/// <summary>
		/// creates a line plot based on the double arrays passed with x and y and exports it as html file under specified filePath title can be used to specify the plot's title
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="title"></param>
		public static void line(String filePath, double[] x, double[] y, String title)
		{
			line(filePath, x, y, null, title, null, null);
		}
		/// <summary>
		/// creates a line plot based on the double arrays passed with {@code x} and {@code y} and exports it as html file under specified {@code filePath}
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="traceName"></param>
		/// <param name="title"></param>
		/// <param name="xLabel"></param>
		/// <param name="yLabel"></param>
		public static void line(String filePath, double[] x, double[] y, String traceName, String title, String xLabel, String yLabel)
		{
			XYTemplate template = new XYTemplate();
			template.Load();
			template.SetData(x, y, traceName);
			template.SetTitle(title);
			template.SetXLabel(xLabel);
			template.SetYLabel(yLabel);
			template.SetPlotType(PlotType.SCATTER);
			template.SetModeType(ModeType.LINES_MARKERS);
			template.Export(filePath);
			PlotlifyHelper.OpenUrl(filePath);
		}

		/// <summary>
		/// creates a scatter plot based on the double arrays passed with {@code x} and {@code y} and exports it as html file under specified {@code filePath}
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public static void scatter(String filePath, double[] x, double[] y)
		{
			scatter(filePath, x, y, null, null, null, null);
		}

		/// <summary>
		/// creates a scatter plot based on the double arrays passed with {@code x} and {@code y} and exports it as html file under specified {@code filePath} code title can be used to specify the plot's title
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="title"></param>
		public static void scatter(String filePath, double[] x, double[] y, String title)
		{
			scatter(filePath, x, y, null, title, null, null);
		}

		/// <summary>
		/// creates a scatter plot based on the double arrays passed with {@code x} and {@code y} and exports it as html file under specified {@code filePath}
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="traceName"></param>
		/// <param name="title"></param>
		/// <param name="xLabel"></param>
		/// <param name="yLabel"></param>
		public static void scatter(String filePath, double[] x, double[] y, String traceName, String title, String xLabel, String yLabel)
		{
			XYTemplate template = new XYTemplate();
			template.SetData(x, y, traceName);
			template.SetTitle(title);
			template.SetXLabel(xLabel);
			template.SetYLabel(yLabel);
			template.SetPlotType(PlotType.SCATTER);
			template.SetModeType(ModeType.MARKERS);
			template.Export(filePath);
			PlotlifyHelper.OpenUrl(filePath);
		}

		/// <summary>
		/// creates a scatter 3D plot based on the double arrays passed with {@code x}, {@code y} and {@code z} and exports it as html file under specified code filePath
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		public static void scatter3D(String filePath, double[] x, double[] y, double[] z)
		{
			scatter3D(filePath, x, y, z, null, null, null, null, null);
		}

		/// <summary>
		/// creates a scatter 3D plot based on the double arrays passed with code x, code y and code z and exports it as html file under specified code filePath 
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="title"></param>
		public static void scatter3D(String filePath, double[] x, double[] y, double[] z, String title)
		{
			scatter3D(filePath, x, y, z, null, title, null, null, null);
		}

		/// <summary>
		/// creates a scatter 3D plot based on the double arrays passed with code x, code y and code z and exports it as html file under specified code filePath
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="traceName"></param>
		/// <param name="title"></param>
		/// <param name="xLabel"></param>
		/// <param name="yLabel"></param>
		/// <param name="zLabel"></param>
		public static void scatter3D(String filePath, double[] x, double[] y, double[] z, String traceName, String title, String xLabel, String yLabel, String zLabel)
		{
			// TODO
		}
	}
}
