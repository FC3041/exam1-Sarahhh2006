namespace Exam1;

public class Q1_Add(){
    public static int Add(int a,int b){
        return a+b;
    }
}

public class Q4Person{
    public string Name{get;set;}
    public int Age{get;set;}
    // public Q4Person(){
    //     this.Name;
    //     this.Age;
    // }
    public Q4Person(string n , int a){
        Name=n;
        Age=a;
    }
    public string Introduce() => $"Hello, my name is {Name} and I am {Age} years old.";

}

public struct Type1{
    public int Count =0;
    public Type1(){
        Count++;
    }
}

public class Type2{
    public int Count =0;
    public Type2(){
        Count++;
    }
}



// static void Q5TryCatchFinally{
//     public bool shouldThrow{get;set;}
//     public List<string> ;
//     try{
//         List<string> m=new List<string>();
//         m.Add(1);

//     }
//     catch(exception ex){
//         if(!shouldThrow){
//             throw new InvalidOperationException;
//         }
//     }
// }
// public class ShapeUtils:IShape{

//     public double  GetArea();
//     public double  GetPerimeter();
//     // IShape[T] s =new IShape[T]();
    

// }

public interface IShape{
    public double  GetArea();
    public double  GetPerimeter();
    
}
public class Q7Circle:IShape{
    public double radius{get;set;}
    public Q7Circle(double r){
        radius =r;
    }
    public double GetArea() => radius*radius*Math.PI;
    public double GetPerimeter() => 2*radius*Math.PI;

}
public class Q7Rectangle:IShape{
    public double W{get;set;}
    public double H{get;set;}
    public Q7Rectangle(double w,double h){
        W=w;
        H=h;
    }
    public double GetArea() => W*H;
    public double GetPerimeter() => (W+H)*2;

}

public class Q6Temperature{
    public  double cel;
    private double fahren;
    public double Celsius{get=>cel;set{
        value=cel;
        // cel= (fahren-32)*(5.0/9.0);
        fahren = cel*(9.0/5.0)+32;

    }
    }
    public double Fahrenheit{get=>fahren;
    set{
        value =fahren;
        fahren = cel*(9.0/5.0)+32;
        
    }
    }

    // public double Fahrenheit => Celsius*(9.0/5.0)+32;
    // public double Celsius{get;set;}
    // public double Fahrenheit{set{
    //     value =Celsius*(9.0/5.0)+32;
    // }}

}