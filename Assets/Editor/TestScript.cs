
using NUnit.Framework;
using UnityEngine;
using NSubstitute;
using UnityEngine.TestTools;
using System.Collections;
using UnityEngine.SceneManagement;

public class TestScript
{
    [Test]
    [TestCase(10,'+',2,12)]
    [TestCase(10, '-', 2, 8)]
    [TestCase(10, '*', 2, 20)]
    [TestCase(500, '/', 10, 50)]
    public void Calculate_Test(float x, char pointer, float y,float result)
    {
       var Calculator = new Calculator(x,y,pointer);

       var score = Calculator.ScoreCount();

        Assert.That(score,Is.EqualTo(result));
    }

    [Test]
    public void NSubstitute_Method_Test(){
        //Arrange
        ICalculator calculator = Substitute.For<ICalculator>();
        //Act
        calculator.Add(1,2);
        //Assert
        calculator.Received().Add(1,2);
        calculator.DidNotReceive().Add(5,7);
    }

    [Test]
    public void NSubstitute_Property_Test(){
        
        //1.
        //Arrange
        ICalculator calculator = Substitute.For<ICalculator>();
        //Act
        calculator.Mode.Returns("Decimal");
        //Assert
        Assert.That(calculator.Mode == "Decimal");
        
        //2.
        //Act
        calculator.Mode ="Hex";
        //Assert
        Assert.That(calculator.Mode== "Hex");
    }

    [Test]
    public void NSubstitute_ArgsCheck_Test(){

        //Arrange
        ICalculator calculator = Substitute.For<ICalculator>();
        //Act
        calculator.Add(Arg.Is<int>((x)=>x>0),Arg.Is<int>((x)=>x>0))
                  .Returns(x=>(int)x[0]+(int)x[1]);
        //Assert
        Assert.That(calculator.Add(5,10) == 15);
    }

    [Test]
    public void NSubstitute_Return_Test(){
                //Arrange
        ICalculator calculator = Substitute.For<ICalculator>();
        //Act
        calculator.Mode.Returns("Hex","Dec","Bin");
        //Assert
        Assert.That(calculator.Mode=="Hex");
        Assert.That(calculator.Mode=="Dec");
        Assert.That(calculator.Mode=="Bin");
    }

        [Test]
    public void NSubstitute_Event_Test(){
                //Arrange
        ICalculator calculator = Substitute.For<ICalculator>();
        bool isEventTrigger = false;
        //Act
        calculator.AnEventAction += (sender,args)=>{isEventTrigger = true;};
        calculator.AnEventAction += Raise.Event();
        //Assert
        Assert.That(isEventTrigger);
    }
}
