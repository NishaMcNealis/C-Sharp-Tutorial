using System;
namespace TreehouseDefense{
  class ShieldedInvader : Invader{
    public override int Health {get; protected set;} = 2;
    public ShieldedInvader(Path path) : base(path){}
    public override void DecreaseHealth(int factor){
      if (Random.NextDouble() < .5) {
        base.DecreaseHealth(factor); //Reduces Health by given factor
      }
      else{
        Console.WriteLine("Shot at a shielded invader, but it sustained no damage.");
      }
    }
  }
}
