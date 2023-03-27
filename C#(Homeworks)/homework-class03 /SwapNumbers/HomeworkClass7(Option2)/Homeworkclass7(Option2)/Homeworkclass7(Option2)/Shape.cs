using System;
namespace Homeworkclass7_Option2_
{
	public class Shape
	{
	  public string Name { get; set; }
	  public string Color { get; set; }
      public int[] X {get;set;}
	  public int[] Y { get; set; }

	 public virtual void getArea()
		{
			Console.WriteLine("There is no implementantation for area");
		}
		public virtual  void getPerimeter()
		{
			Console.WriteLine("There is no special implementation for perimeter");
            
        }
        protected  void Move(string input)
        {
			input += 5;
        }
    }
}

