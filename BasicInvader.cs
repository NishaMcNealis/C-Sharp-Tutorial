using System;
namespace TreehouseDefense{
  class BasicInvader : Invader{
    
    public override int Health {get; protected set;} = 1;
    public BasicInvader(Path path) : base(path){}
    
    
  }
}