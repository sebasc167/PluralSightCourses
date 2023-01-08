using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Structs;

public readonly struct Student
{
    public Student()
    {
        Id = 0;
        Name = string.Empty;
    }
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; init; }
    public string Name { get; init; }
}



/*
 * Structs are value types like ints, bools, enum
 * Classes are reference types
 * 
 * Structs also have constructors
 * Since a struct is a value type, if we have a function
 * that takes an a struct of any type, then whatever struct
 * we pass in to the function is not the original struct.
 * 
 * It is a copy. Any property changed does not affect
 * the original struct passed in
 * 
 * DateTime is immutable for example.
 * If you apply a method it will return a new instance of a struct 
 * 
 * Does not support inheritance either
 * 
 * Mainly we need reference tpyes with classes
 * 
 * If data is short lived than structs can be okay
 * 
 * To make a struct immutable you add the readonly keyword to it
 */

