
using MyLib;
namespace Bai2_1;
using System.Collections;

public class ArrayPoint
{
	private readonly ArrayList points;

	public ArrayPoint()
	{
		this.points = new ArrayList();
	}

	public int Count
	{
		get { return this.points.Count; }
	}

	public Point this[int index]
	{
		get { return (Point)this.points[index]!; }
		set { this.points[index] = value; }
	}

	public void Add(Point point)
	{
		this.points.Add(point);
	}
}
