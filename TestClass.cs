using Xunit;
using System.Collections.Generic;
namespace MarsRover
{
    public class TestClass
    {
       [Fact] 
       public void TurnLeft()
       {
           Rover rover = new Rover("1 2 N",5,5);
           rover.TurnLeft();
           Assert.Equal("W",rover.dir);
       } 
        
        [Fact] 
        public void TurnRight()
        {
            Rover rover = new Rover("1 2 N",5,5);
            rover.TurnRight();
            Assert.Equal("E",rover.dir);
        } 

        [Fact] 
        public void Move()
        {
            Rover rover = new Rover("1 2 N",5,5);
            rover.Move();
            Assert.Equal(3,rover.y);
        } 

        [Fact] 
        public void Move1()
        {
            Rover rover = new Rover("1 2 N",5,5);
            rover.Move("LMLMLMLMM");
            Assert.Equal("1 3 N",rover.x + " " + rover.y + " " + rover.dir);
        } 

        [Fact] 
        public void Move2()
        {
            Rover rover = new Rover("3 3 E",5,5);
            rover.Move("MMRMMRMRRM");
            Assert.Equal("5 1 E",rover.x + " " + rover.y + " " + rover.dir);
        } 
    }
}