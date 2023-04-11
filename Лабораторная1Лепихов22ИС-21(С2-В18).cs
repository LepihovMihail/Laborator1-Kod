/*
Вычислить гиперболический котангенс двумя способами, зная следующее соотношение: 
coth(x)=1/tanh(x)=(e^x+e^-x)/(e^x-e^-x)
*/
using System;
class SSposoB2{
  static void Main() {
    double x = 3.14;
    double coth = ((Math.Exp(x)+Math.Exp(-x))/(Math.Exp(x)-Math.Exp(-x)));
    Console.WriteLine("coth({0})={1}", x,coth);
  } 
}
