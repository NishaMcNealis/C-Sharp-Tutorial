using System;
namespace TreehouseDefense{
  class TreehouseDefenseException : Exception{
    public TreehouseDefenseException(){
    }
    public TreehouseDefenseException(string msg):base(msg){
    }
  }
  class OutOfBoundsException : TreehouseDefenseException{
    public OutOfBoundsException(){
      
    }
    public OutOfBoundsException(string message):base(message){
      
    }
  }
}