class Calculator
{
  power(num1, num2){
    if (num1 < 0 || num2 < 0) {
      throw "n and p should be non-negative";
    }
    let solution;
    try {
      solution = Math.pow(num1, num2);
    }
    catch(e) {
      return e;
    }
    finally {
      return solution;
    }
  }
}