using System;
namespace TreehouseDefense {
  class Tower{
    protected virtual int Range {get;} = 1;
    protected virtual int Power {get;} = 1;
    protected readonly MapLocation _location;
    protected virtual double Accuracy {get;} = .75;
    
    public Tower(MapLocation location){
      //if (path.IsOnPath(_location))
      _location = location;
      
    }
    public void FireOnInvaders (IInvader[] invaders){
      foreach (IInvader invader in invaders){
        if (invader.IsActive && _location.InRangeOf(invader.Location, Range)){
          if (IsSuccessfulShot()){
            invader.DecreaseHealth(Power);
            Console.WriteLine("Shot at and hit an invader.");
            if (invader.IsNeutralized) {Console.WriteLine("**********************Neutralized an invader at " + invader.Location + "**********************");}
            break;
          }
          else {Console.WriteLine("Shot at and missed an invader.");}
        }
      }
    }
    public bool IsSuccessfulShot() => Random.NextDouble() < Accuracy;  
  }
}