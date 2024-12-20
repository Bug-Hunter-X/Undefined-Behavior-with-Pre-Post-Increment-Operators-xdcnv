public class MyClass {
    private int myField = 10;

    public void MyMethod() {
        // Incorrect usage of ++ operator 
        int result = myField++ + ++myField; //Undefined behavior, order of evaluation is not guaranteed
        Console.WriteLine(result); //The output is unpredictable
    }
}