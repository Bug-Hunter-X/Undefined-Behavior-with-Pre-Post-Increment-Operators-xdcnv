public class MyClass {
    private int myField = 10;

    public void MyMethod() {
        // Correct usage of ++ operator with clear order of operations
        int temp = myField++;
        int result = temp + ++myField; //Now it's well-defined
        Console.WriteLine(result); //Output is now predictable and consistent
    }
} 