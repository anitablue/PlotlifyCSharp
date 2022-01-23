using PlotlifyCSharp.enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PlotlifyCSharp.helpers
{
	public class PlotlifyHelper
	{
		public static String PLOTLY_NAME = "plotly";
		public static String VERSION = "latest";
		public static String CDN_LINK = "https://cdn.plot.ly/plotly-" + VERSION + ".min.js";

		public static string GetModeTypeText(ModeType type)
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
			return typeText;
		}

		public static string GetPlotTypeText(PlotType type)
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
			return typeText;
	}

		public static void OpenUrl(string url)
		{
			try
			{
				Process.Start(url);
			}
			catch
			{
				if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
				{
					url = url.Replace("&", "^&");
					Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
				}
				else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
				{
					Process.Start("xdg-open", url);
				}
				else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
				{
					Process.Start("open", url);
				}
				else
				{
					throw;
				}
			}
		}


		public static void CheckDimensions(double[] x, double[] y, double[] z)
		{
			if (x == null && y == null && z == null)
			{
				return;
			}
			if (z != null)
			{
				if ((x.Length != y.Length) || (y.Length != z.Length))
				{
					var message = String.Format("Dimension mismatch in input (x[ {0} ], y[ { 1 }], z[ { 2 } ])", x.Length, y.Length, z.Length);
					throw new Exception(message);
				}
			}
			else
			{
				if (x.Length != y.Length)
				{
					var message = String.Format("Dimension mismatch in input (x[ {0} ], y[ {1}] )", x.Length, y.Length);
					Console.WriteLine(message);
				}
			}
		}

		public static void WriteTextToFile(String path, String text)
		{
			if (!File.Exists(path))
			{
				File.WriteAllText(path, text);
			}
		}


		public static String ReadTextFromFile(String path)
		{
			string readText = File.ReadAllText(path);
			return readText;
		}
	}
}

