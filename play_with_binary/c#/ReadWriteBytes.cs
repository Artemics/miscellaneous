using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;

namespace ByteTests
{

    // [TODO] Can make a single function that automatically cast and convert input values
    // into binary??

    public class ReadWriteBytes
    {
        static List<Type> targetTypeList = new List<Type>{typeof(int) };//new List<Type>();

        // https://stackoverflow.com/questions/39244449/cast-generic-type-parameter-to-a-specific-type-in-c-sharp/39244683
        // https://stackoverflow.com/questions/6884653/how-to-make-a-generic-type-cast-function
        public static T ConvertValue<T, U>(U value)
            where U : IConvertible{
                return (T)Convert.ChangeType(value, typeof(T));
        }

        public static void WriteFloatInBinary(string filePath, float value, System.Text.Encoding encoding = null)
        {
            byte[] valueBinary = System.BitConverter.GetBytes(value);    

            if (encoding == null)
            {
                encoding = System.Text.Encoding.UTF8;
            }
            // System.Text.Encoding.ASCII
            // Debug.Log("WriteBinary starts");
            // string fileName = fileNameMaster.Replace("ENC", "ascii");
            // fileName = fileNameMaster.Replace("ENC", "utf8");

            try
            {

                //System.Text.Encoding ascii = System.Text.Encoding.ASCII;
                //BinaryWriter bwEncoder = new BinaryWriter(new FileStream(fileName, FileMode.Create), ascii);

                using (BinaryWriter binaryWriter
                    = new BinaryWriter(new FileStream(filePath, FileMode.Create)
                        , encoding))
                {
                    binaryWriter.Write(valueBinary);
                }
                Console.WriteLine("File Written");
                // Debug.Log("File Written");
        
            }
            catch(System.Exception)
            {
                Console.WriteLine("Error in writing to a file");
                // Debug.Log("Error in writing to a file");
            }
        }
        
        public static void WriteStringsInBinary(string filePath, string[] strings
            , System.Text.Encoding encoding = null)
        {

            if (encoding == null)
            {
                encoding = System.Text.Encoding.UTF8;
            }
            // Debug.Log("WriteBinary starts");
            try
            {
                //System.Text.Encoding ascii = System.Text.Encoding.ASCII;
                //BinaryWriter bwEncoder = new BinaryWriter(new FileStream(fileName, FileMode.Create), ascii);

                using (BinaryWriter binaryWriter
                    = new BinaryWriter(new FileStream(filePath, FileMode.Create)
                        , encoding))
                {
                    foreach (var item in strings)
                    {
                        binaryWriter.Write(item);                        
                    }
                }
            }
            catch(System.Exception)
            {
                Console.WriteLine("Error in writing to a file");
            }
        }


        public static void ReadBinary(string filePath, string mode="string"
            , System.Text.Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = System.Text.Encoding.UTF8;
            }
            
            using (BinaryReader binaryReader
                = new BinaryReader(new FileStream(filePath, FileMode.Open)
                    , encoding))
            {
                // Debug.Log("ascii ReadString");
                // Debug.Log(binaryReader.ReadString());
            }

            switch (mode)
            {
                case "string":
                    using (BinaryReader binaryReader
                        = new BinaryReader(new FileStream(filePath, FileMode.Open)))
                    {
                        byte[] bytes = binaryReader.ReadBytes(int.MaxValue);
                        string strTmp = encoding.GetString(bytes);
                        Console.WriteLine(strTmp);
                        // Debug.Log(System.Text.Encoding.ASCII.GetString(bytes));
                        //Debug.Log(binaryReader.ReadBytes(int.MaxValue).ToString());
                    }
                    break;
                case "float":
                    using (BinaryReader binaryReader
                        = new BinaryReader(new FileStream(filePath, FileMode.Open)))
                    {
                        byte[] bytes = binaryReader.ReadBytes(sizeof(float));
                        float myFloat = System.BitConverter.ToSingle(bytes);    
                        Console.WriteLine(myFloat.ToString());
                    }
                    break;
                default:
                    break;
            }
        }
    }
}