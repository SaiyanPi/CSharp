namespace ValueTypeVsReferenceType
{
    // when we pass a value type variable from one method to another method, the system creates a separate 
    // copy of a variable in another method. so even if the value got changed in one method, it would not 
    // affect the variable in another method.
    class ValueType // CLASS1
    {
       public static void ValueTypePrint(int x) //CLASS1.METHOD1
        {
            x = 10; 
            Console.WriteLine(x);
        }
    }


    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 


    // when we pass reference type variable from one method to another, it doesn't create a new copy like value type,
    // instead, it passes the variable's address so if we change the value in one method, it affects the value in another
    public class Name
    {
        public string Username { get; set; }
    }
    class ReferenceType
    {
        public static void ReferenceMethod(Name naam) // METHOD2
        {
            naam.Username = "SaiyanPi";
        }
    }
   

    class Program   // MAIN CLASS
    {
        static void Main(string[] args) // MAIN METHOD
        {
            int b = 200;
            Console.WriteLine(b);   // 200
            // VARIABLE WITH NEW VALUE(200) PASSED TO METHOD1 THROUGH ARGUMENT BUT THE SYSTEM CREATES A COPY OF 
            // VARIABLE(x) in METHOD1 SO DOESN'T AFFECT THE VALUE(10) 
            ValueType.ValueTypePrint(b);    // 10
            Console.WriteLine(b);   // 200


            /////////////////////////////////////////////////////////////////////////////////////////////////

         
            Name name = new Name();
            name.Username = "Vegeta";
            Console.WriteLine(name.Username);   // Vegeta
            // OBJECT PASSED TO METHOD 2 THROUGH ARGUMENT, ACTUALLY IT IS PASSING THE OBJECT(name)'S ADDRESS.
            // SO WHEN METHOD2 CHANGES username TO 'SaiyanPi', IT IS ALSO CHANGING Username OF THE OBJECT(name)
            // BECAUSE  BOTH 'name' and 'naam' ARE POINT TO THE SAME ADDRESS IN MEMORY.
            ReferenceType.ReferenceMethod(name);    
            Console.WriteLine(name.Username);   // SaiyanPi
          
        }
    }
}