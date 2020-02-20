using System;
public interface ICalculator
{
    int Add(int x,int y);
    string Mode{get;set;}

    event EventHandler AnEventAction;
}