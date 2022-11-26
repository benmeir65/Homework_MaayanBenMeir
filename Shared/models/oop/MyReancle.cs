using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.models.oop
{
    public class MyReancle
    {

		public string Color { get; set; }
		public double Length { get; set; }
		public double Width { get; set; }

		public double R_area()
		{
			double area = Length * Width;
			return area;
		}
		public double R_circumference()
		{
			double circumference = (Length * 2) + (Width * 2);
			return circumference;
		}



	}
}
