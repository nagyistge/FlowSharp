﻿/* 
* Copyright (c) Marc Clifton
* The Code Project Open License (CPOL) 1.02
* http://www.codeproject.com/info/cpol10.aspx
*/

using System.Drawing;

namespace FlowSharpLib
{
	public enum GripType
	{
		None,
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight,
		LeftMiddle,
		RightMiddle,
		TopMiddle,
		BottomMiddle,

		// for lines:
		Start,
		End,
	};

	public class ConnectionPoint
	{
		// Setters should be protected, but serializer requires them to be public.
		public GripType Type { get; set; }
		public Point Point { get; set; }

		// Solely for serializer.
		public ConnectionPoint()
		{
		}

		public ConnectionPoint(GripType pos, Point p)
		{
			Type = pos;
			Point = p;
		}
	}
}
