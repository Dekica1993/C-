using System;
namespace Homeworkclass7_Option2_
{
	public class Rectangle : Shape
	{
		public string SideA { get; set; }
		public string SideB { get; set; }
		public Rectangle(string name,string color, int[] x, int[] y)
		{
			Name = name;
			Color = color;
			X = x;
			Y = y;
		}
        public override void getArea()
        {
            base.getArea();
        }
		public override void getPerimeter()
		{
			base.getPerimeter();
		}
    }
}

