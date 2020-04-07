using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class Box
    {

		private double length;
		private double width;
		private double height;

		public Box(double length, double width, double height)
		{
			Length = length;
			Width = width;
			Height = height;
		}

		public double Length
		{
			get { return this.length; }
			set 
			{
				if(value <= 0)
				{
					throw new ArgumentException($"Length cannot be zero or negative.");
				}

				this.length = value; 
			}
		}


		public double Width
		{
			get { return this.width; }
			set 
			{
				if (value < 0)
				{
					throw new ArgumentException($"Width cannot be zero or negative.");
				}
				this.width = value; 
			}
		}
		public double Height
		{
			get { return this.height; }
			set 
			{
				if (value <= 0)
				{
					throw new ArgumentException($"Height cannot be zero or negative.");
				}
				this.height = value; 
			}
		}

		public double GetVolume()
		{
			double volume = this.length * this.width * this.height;
			return volume;
		}

		public double GetLateralSurfaceArea()
		{
			double lateralSurfaceArea = (2 * this.length * this.height)
										  + (2 * this.width * this.height);
			return lateralSurfaceArea;
		}

		public double GetSurfaceArea()
		{
			double surfaceArea = this.GetLateralSurfaceArea() + (2 * this.length * this.width);
			return surfaceArea;
		}

	}
}
