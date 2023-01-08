using Practice.Structs;

Student sebas = new Student(1, "Sebastian");
// We can make new objects using the other object

//With is not exclusive to records
Student other = sebas with { Id = 2 };
Console.WriteLine(other); //Uses the toString method()

//Deconstruction
var (x, y) = sebas;

//Delegates take in functions
var converting = new ConversionFtToInchDelegate(Conversion);
var inches = converting(12);
Console.WriteLine(inches);
int Conversion(int feet)
{
    return feet * 12;
}

delegate int ConversionFtToInchDelegate(int feet);

//The thing here is that the delegate doesn't know or care about the class 
//the method is in


//Interpolation

var s = "string";
var prettyPrint = $"the is the value of string s: {s}";

/*Deconstruction - taking appart and object to access 
    its property values easily*/