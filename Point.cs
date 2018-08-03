using System;
namespace TreehouseDefense{
  class Point{
    
    public readonly int X;
    public readonly int Y;
    
    public Point(int x, int y){
      X = x;
      Y = y;
    }
    public override string ToString(){
      return "(" + X + ", " + Y + ")";
    }
    public int DistanceTo(int x, int y){
      return (int)(Math.Sqrt(Math.Pow((X-x), 2) + Math.Pow((Y-y), 2)));
    }
    
    public int DistanceTo(Point p){
      return (DistanceTo(p.X, p.Y));
    }
    public override bool Equals(Object obj){
      if (!(obj is Point)){return false;}
      Point that = obj as Point;
      return (this.X == that.X && this.Y == that.Y);
    }
    public override int GetHashCode(){ 
      return (X * 31) + Y;
    }
  }
}