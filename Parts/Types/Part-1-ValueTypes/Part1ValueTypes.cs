namespace CSharpClass2
{
    public static class Part1ValueTypes
    {
        public static void IntegralNumericTypes()
        {
            // Inegral Numeric Types            
            sbyte sbyte1 = -128;    // System.SByte
            sbyte sbyte2 = 127;
            Console.WriteLine($"{sbyte1}, {sbyte2}");

            byte byte1 = 0;
            byte byte2 = 255;
            Console.WriteLine($"{byte1}, {byte2}");

            short short1 = -32768;
            short short2 = -32767;
            Console.WriteLine($"{short1}, {short2}");

            ushort ushort1 = 0;
            ushort ushort2 = 65535;
            Console.WriteLine($"{ushort1}, {ushort2}");

            int int1 = -2147483648;
            int int2 = 2147483647;
            Console.WriteLine($"{int1}, {int2}");

            uint uint1 = 4294967295;
            Console.WriteLine($"{uint1}");

            long long1 = -9223372036854775808;
            long long2 = 9223372036854775807;
            Console.WriteLine($"{long1}, {long2}");

            ulong ulong1 = 18446744073709551615;
            Console.WriteLine($"{ulong1}");
        }

        public static void FloatingPointNumericTypes()
        {
            // Float - range : ±1.5 x 10−45 to ±3.4 x 1038          Precision : ~6-9 digits	        Size: 4 bytes
            // Double - range : ±5.0 × 10−324 to ±1.7 × 10308	    Precision : ~15-17 digits	    Size: 8 bytes            
            // Decimal - range : ±1.0 x 10-28 to ±7.9228 x 1028	    Precision : 28-29 digits	    Size: 16 bytes
            float f = 3_000.5F;
            double d = 3D;
            decimal myMoney = 3_000.5m;

            Console.WriteLine($"{f}, {d}, {myMoney}");
        }

        public static void BooleanAndCharacters()
        {
            bool check = true;
            Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked

            // Character
            // char	U+0000 to U+FFFF	16 bit

            var chars = new[]
            {
                'j',
                '\u006A', // a Unicode escape sequence
                '\x006A', // a hexadecimal escape sequence,
                (char)106,
            };
            Console.WriteLine(string.Join(" ", chars));  // output: j j j j
        }

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter,
        }

        enum ErrorCode : ushort
        {
            None = 0,
            Unknown = 1,
            ConnectionLost = 100,
            OutlierReading = 200
        }

        [Flags]
        public enum Days
        {
            None = 0b_0000_0000,  // 0
            Monday = 0b_0000_0001,  // 1
            Tuesday = 0b_0000_0010,  // 2
            Wednesday = 0b_0000_0100,  // 4
            Thursday = 0b_0000_1000,  // 8
            Friday = 0b_0001_0000,  // 16
            Saturday = 0b_0010_0000,  // 32
            Sunday = 0b_0100_0000,  // 64
            Weekend = Saturday | Sunday
        }

        public static void EnumerationTypes()
        {
            Console.WriteLine(Season.Autumn);
            Console.WriteLine(ErrorCode.ConnectionLost);
            Console.WriteLine(Days.Wednesday);
        }

        class Point
        {
            public int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct PointStruct
        {
            public int x, y;

            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        public static void StructureTypes()
        {
            Point[] points = new Point[100];
            for (int i = 0; i < 100; i++) points[i] = new Point(i, i);

            PointStruct[] pointStructs = new PointStruct[100];
            for (int i = 0; i < 100; i++) pointStructs[i] = new PointStruct(i, i);
        }

        public static void TupleTypes()
        {
            // Use case - when you want to return more than one value from a function / method. 
            (double, int) t1 = (4.5, 3);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
            // Output:
            // Tuple with elements 4.5 and 3.

            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Sum} elements is {t2.Sum}.");
            // Output:
            // Sum of 3 elements is 4.5.
        }
    }
}