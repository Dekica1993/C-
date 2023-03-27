using System;
namespace Homeworkclass7_Option2_
{
	public class Circle : Shape
	{
		public string Radius { get; set; }
		public Circle(string name,string color, int[] x, int[] y)
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

