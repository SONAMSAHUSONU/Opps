//Abstraction :=
//abstraction is the process of hiding internal implemention and offering 
//set of services to end user.
//we can achive abstraction using abstract class and interface
//using abstract class we can active parstial abstraction 
//and using interface we cn active fully abstraction.

//abstract is a keyword or modifier, we can achive abstraction using abstract keyword.
/*using System;

public abstract class Customer
//if anyclass is normal class then we can't create abstract method inside the normal class.
{
    public void run(int i, int j)// this is a normal method or concreate method
    {
        //normal method have body but abstract method don't have body
    }
    public abstract void OFF(int i, int j); //this is abstract method that don't have a body
    public abstract string FullName(string Fname, string Lname);

}

    public abstract class Employee
    {
    

    public static void Main()
    {
        Console.ReadLine();
    }
}*/
/*using System;

public interface IEmployee  // by default public and abstract
    //what is diffrence blw abstract class and interface
{
    //string name = "Nisha";
    //public int age=23;
    // public abstract void Fullname(string ln, string fn);
     void Fullname(string ln, string fn);

    // we can't make the property or variable inside the interface
    //we can't use public variable inside the interface 
    // we can't create a concreate or normal method inside the interface
    //we can't create abstract method inside the interface becouse by default it is abstract or public
}
public abstract class Customer //abstract class is by default private or we can do public also
    //we can make the property inside the abstrat class
    //we can use public variable inside the abstract class
    // we create the concreate or simple method inside the abstract class
    //we can create abstract method inside the abstract class
    {
    public string Fname = "Nisha";//variable or property or data member
    public int age = 13;
    public int Sum(int i, int j)//concreate or simple or normal method
    {
        return i + j;
    }
    public abstract void Fullname(string ln, string fn);
    }

    public static void Main()
    {
    }

    */
/*using System;
public class Emp
{
     Emp()
    {
        Console.WriteLine("Hi");
    }
    public static void Main()
    {
        Emp e1 = new Emp();
        Emp e2 = new Emp();

        Console.WriteLine("hello");
        Console.ReadLine();
    }
}*/

// Constractor:-// constractor is a special type of method.
//constractor name is always same as a class name.
//the purpose of constractore is to value use to intialize non static variable with diffrent set of value
//when ever are creating the object of the class by default constractor is calling automatically.
//constractor don't have any retun type
/*using System;

public class Employee
{
    public void GetGender(char Gender)//simpl method
    {
    }
    public Employee()//constractor name same as a class name
    {
        //parameter less constractor
    }
    public Employee(int i , int j)
    {
        //parameter constract
    }

    public static void Main()
    {
    }
}*/
//there are two type of constractor
//1.default constractor 2. parameterize constructor 
/*using System;

public class Employee
{
    public static int age;
    public string fname, lname;

    public void GetGender(char Gender)
    {
    }
    public Employee()
    {
        Console.WriteLine("Employee()");
    }
    public Employee(int i, int j)
    {
    }

    public static void Main()
    {
        Employee e1 = new Employee(); //every tiime constractor will call
        Employee e2 = new Employee();//every tiime constractor will call

        Employee e3 = new Employee();

        Employee e4 = new Employee();

        Employee e5 = new Employee();

    }
}*/


/*using System;

public class Employee
{
    public Employee()
    {
        Console.WriteLine("Employee() is Constractor");
    }

        public static void Main()
        {
        Employee e1 = new Employee();
        Console.ReadLine();
        }
    }*/

/*using System;

public class Employee
{
    public Employee(int i, int j)
    {
        Console.WriteLine("Employee() is Constractor");
    }

    public static void Main()
    {
        Employee e1 = new Employee(30,40);
        Console.ReadLine();
    }
}*/
/*
using System;

public class Employee
{
    public Employee()
    {
        Console.WriteLine("Employee() is  default Constractor");
    }
    public Employee(int i, int j)
    {
        Console.WriteLine("Employee() is parameterize Constractor");
    }

    public static void Main()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee(10,20);

        Console.ReadLine();
    }
}*/
/*
//constructor overloading : in constractor overloading constractor name 
//will be same and parameter will we diffrent 
//Rules of constractor Overloading 
//Constractor name will be same 
//in folloring order we can overload the constructor 
//1. number of parameter will we diffrent 
using System;
public class Employee
{
    public Employee(int i , int j )
    {
        Console.WriteLine("Employee(int i, int k )");
    }
    public Employee(int i, int j, int k)
    {
        Console.WriteLine("Employee(int i, int j, int k)");
    }
    public Employee(int age, string name)
    {
        Console.WriteLine("Employee age and name");
    }
    public static void Main()
    {
    }
}*/
//Constructor Chaning:-
/*using System;//namspace
using System.Collections;
using System.Data.SqlClient;
public class Employee
{


    public Employee(long l)
    {
        Console.WriteLine("Employee(long l)");
    }
    public Employee(byte b)
    {
        Console.WriteLine("Employee(byte b)");
    }

    public Employee(char name)
    {
        Console.WriteLine("Employee(char name)");
    }
    public Employee(short s)
    {
        Console.WriteLine("Employee(short s)");
    }
    public static void Main()
    {
        Employee e1 = new Employee(100);
        Console.ReadLine();
    }


}
*/


/*using System;//namspace
using System.Collections;
using System.Data.SqlClient;



public class Employee
{


    //public Employee(long l)
    //{
    //    Console.WriteLine("Employee(long l)");
    //}
    //public Employee(byte b)
    //{
    //    Console.WriteLine("Employee(byte b)");
    //}

    public Employee(char name)
    {
        Console.WriteLine("Employee(char name)");
    }
    public Employee(short s)
    {
        Console.WriteLine("Employee(short s)");
    }
    public static void Main()
    {
        Employee e1 = new Employee(100);
        Console.ReadLine();
    }


}*/




/*
using System;//namspace
using System.Collections;
using System.Data.SqlClient;



public class Employee
{


    //public Employee(long l)
    //{
    //    Console.WriteLine("Employee(long l)");
    //}
    //public Employee(byte b)
    //{
    //    Console.WriteLine("Employee(byte b)");
    //}

    public Employee(char name)
    {
        Console.WriteLine("Employee(char name)");
    }
    //public Employee(short s)
    //{
    //    Console.WriteLine("Employee(short s)");
    //}
    public static void Main()
    {
        Employee e1 = new Employee('A');
        Console.ReadLine();
    }


}
*/
/*
using System;//namspace
using System.Collections;
using System.Data.SqlClient;

public class Employee
{
    public Employee(int i)
    {
        Console.WriteLine("Employee(int i)");
    }

    public Employee(float f)
    {
        Console.WriteLine("(float f)");
    }
    public static void Main()
    {
        Employee e1 = new Employee('A');
        Console.ReadLine();
    }


}
*/
/*
using System;//namspace
using System.Collections;
using System.Data.SqlClient;



public class Employee
{







    public Employee(float f)
    {
        //byte-> short char   int float long double 
        Console.WriteLine("(float f)");
    }
    public static void Main()
    {
        Employee e1 = new Employee('A');
        Console.ReadLine();
    }


}*/


/*
using System;//namspace
using System.Collections;
using System.Data.SqlClient;



public class Employee
{
    public Employee(int x)
    {

    }

    public Employee(byte y)
    {

    }

    public Employee(long l)
    {

    }
    public static void Main()
    {
        Employee e1 = new Employee('A');
        Console.ReadLine();
    }


}*/

/*
using System;//namspace
using System.Collections;
using System.Data.SqlClient;
public class Employee
{

    string name = "rj";
    string city = "bhopal";
    int age = 30;
    //This:-This is the keywords use to refere current class object 
    //this is used to access non static membar
    //this can not be used in static context.
    // this use to acess non static variable method constrctor

    public Employee() : this(1000, 2000)
    {
        Console.WriteLine("Employee()");
    }

    public Employee(int i, int j)
    {
        Console.WriteLine("(int i,int j)");
    }
    public static void Main()
    {
        Employee obj = new Employee();
        obj.DisplayMessage();
        Console.ReadLine();

    }
    public void DisplayMessage()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();

        Console.WriteLine("Name:" + e1.name + " " + e1.city + " " + e1.age);
        Console.WriteLine("Name:" + this.name + " " + this.city + " " + this.age);
    }
}
    
*/
using System;
public class Employee
{

    static void Main()
    {
        Console.ReadLine();
    }
}
class A
{
    int a = 10;
    public void Click2()
    {
        int b = 100;   
    }
}
class B:A
{

    public void Click()
    {
        base.Click2();
    }
    B b = new B();
}


