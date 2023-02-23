namespace FizzBuzzLibrary;

public static class FizzBuzz
{
    public static  string Submit(int input)
    {
        if(input % 3 == 0 &&input % 5 ==0) return "FizzBuzz";
        if (input % 3 == 0) return "Fizz";
        return input % 5 == 0 ? "Buzz" : input.ToString();
    }
}