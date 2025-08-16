namespace Testing
{

    // Ctrl + k then Ctrl + c     make it commented
    // Ctrl + k then Ctrl + u     to uncomment it
    // Alt + ↑ / ↓                Move Line Up / Down
    // Ctrl + d                   make a copy of the line just under it
    // Ctrl + m then Ctrl + o     Collapse to Definitions
    // Ctrl + m then Ctrl + l     Toggle All Outlining

    internal class Program
    {
        #region Session 1

        #region Access Modifiers class
        internal class TypeA
        {
            private int x;
            internal int y;
            public int z;

            public TypeA()
            {
                x = 10; // Private Is Assessable Within Its Scope 
                y = 20; // Internal Is Assessable Within Its Scope 
                z = 30; // Public Is Assessable Within Its Scope 
            }
        }
        #endregion

        #region enum
        internal enum Gender
        {
            Male,
            Female
        }
        internal class Person()
        {
            public int id { get; set; }
            public string? name { get; set; }

            //public string? Gender { get; set; }

            public Gender? gender { get; set; }

        }
        #endregion

        #endregion

        #region Session 2

        #region Struct
        internal struct Point
        {
            #region Attributes
            public int X; // 4 bytes
            public int Y; // 4 bytes
            #endregion

            #region Constructor Overloading
            public Point(int x, int y)
            {
                X = x; // 4 bytes
                Y = y; // 4 bytes
            }
            public Point(int x)
            {
                X = x; // 4 bytes
            }
            #endregion

        }
        #endregion

        #endregion

        static void Main(string[] args)
        {

            #region Session 1

            #region Boxing , Unboxing

            #region Boxing [ value type to reference type ] Safe
            //int x = 100;
            //object obj = x; // Boxing - Implicitly - converts the value type to an object
            #endregion

            #region unBoxing [ reference type to value type ] Unsafe
            //object obj = "Jaser"; 
            //int x = (int) obj; // Unboxing - Explicitly - converts the object back to an int
            #endregion

            #endregion

            #region Nullable value types
            // int x = 10;
            // x = null; // Error: Cannot assign null to a non-nullable type

            //Nullable<int> y = 10; // Nullable type can hold a value or null
            //y = null; // Now this is valid
            //// y  can be null or an int value

            //int? z = 10; // This is shorthand for Nullable<int>
            ////z = null; // This is valid, z can be null or an int value

            //// casting from int to Nullable<int>
            ////int x = 10;
            ////int? y = x; // Valid [Implicit Casting]

            ////int? a = 10;
            ////int b = a; // Invalid [Implicit Casting] - This will cause a compile-time error
            ////int c = (int)a; // Valid [Explicit Casting] - This will work if a is not null  [unsafe]

            //int? a = 10;
            //int b = a ?? 0; // Using the null-coalescing operator to provide a default value if a is null
            // int b = a.GetValueOrDefault(); // This will return 0 if a is null
            #endregion

            #region Nullable Reference Types
            //string name01 = null;  // warning: CS8600: Converting null literal to non-nullable type.
            //Console.WriteLine(name01); 

            //string? name02 = null;  // this a compiler enhancement
            //Console.WriteLine(name02);

            //string name03 = null!;  // [Null Forgetting Operator] this is a way to tell the compiler that you know what you are doing
            //Console.WriteLine(name03);
            #endregion

            #region Null—Conditionat | Propagation operator
            //int[] numbers = null;
            //for (int i = 0; i < numbers?.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]); // This will not throw an exception if numbers is null
            //}

            //int[] n = null;
            ////int length = n?.Length ?? 0; // If n is null, length will be 0
            //int? length2 = n?.Length; // If n is null, length2 will be null
            #endregion

            #region Access Modifiers
            TypeA typeA = new TypeA();
            //typeA.x = 100; // Error: x is private and cannot be accessed outside of TypeA
            typeA.y = 200; // Valid: y is internal and can be accessed within the same assembly
            typeA.z = 300; // Valid: z is public and can be accessed from anywhere

            #endregion

            #region enum
            //Person person01 = new Person();
            //person01.id = 10;
            //person01.name = "Jaser";
            //person01.gender = Gender.Male;

            #endregion

            #endregion

            #region Session 2

            #region Struct
            Point P1; // Declare for variable | Object from type "Point"
            // clr will allocate 8 uninitialized bytes memory for P1 at stack
            P1 = new Point(); // new => Is Just For Constructor Collection
            P1 = new Point(10, 20); // user defined constructor
            P1 = new Point(10); // user defined constructor after overloading
            #endregion

            #endregion

        }
    }
}
