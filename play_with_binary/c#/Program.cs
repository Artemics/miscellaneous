using System;

// References
// Tutorial: Create a .NET console application using Visual Studio Code
// https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code
//
namespace ByteTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;

            // Console.WriteLine($"System IsLittleEndian = {System.BitConverter.IsLittleEndian}");

            // float val = 0.898f;
            // path = @"C:\work\artemics\miscellaneous\play_with_binary\data\float_utf8_.898.bin";
            // Console.WriteLine(string.Format("Write {0} to {1}", val, path));
            // ReadWriteBytes.WriteFloatInBinary(path, val, System.Text.Encoding.UTF8);

            // string[] strings;

            // // Ordinary alphabet.
            // strings = new string[]{"aaa", "bbb"};
            // path = @"C:\work\artemics\miscellaneous\play_with_binary\data\texts_aaabbb_utf8.bin";
            // Console.WriteLine(string.Format("Write {0}etc to {1}", strings[1], path));
            // ReadWriteBytes.WriteStringsInBinary(path, strings, System.Text.Encoding.UTF8);
 
            // path = @"C:\work\artemics\miscellaneous\play_with_binary\data\texts_aaabbb_ascii.bin";
            // Console.WriteLine(string.Format("Write {0}etc to {1}", strings[1], path));
            // ReadWriteBytes.WriteStringsInBinary(path, strings, System.Text.Encoding.ASCII);
 
            // // Outside ordinary alphabet.
            // strings = new string[]{"aaa", "いいい", "русский"};
            // path = @"C:\work\artemics\miscellaneous\play_with_binary\data\texts_ljr_utf8.bin";
            // Console.WriteLine(string.Format("Write {0}etc to {1}", strings[1], path));
            // ReadWriteBytes.WriteStringsInBinary(path, strings, System.Text.Encoding.UTF8);
 
            // path = @"C:\work\artemics\miscellaneous\play_with_binary\data\texts_ljr_ascii.bin";
            // Console.WriteLine(string.Format("Write {0}etc to {1}", strings[1], path));
            // ReadWriteBytes.WriteStringsInBinary(path, strings, System.Text.Encoding.ASCII);
 
            // Console.WriteLine("Writing finished!");

            ReadWriteBytes.ReadBinary(@"C:\work\artemics\miscellaneous\play_with_binary\data\float_utf8_.898.bin"
                , "float", System.Text.Encoding.UTF8);

        }
    }
}
