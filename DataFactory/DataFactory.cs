using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace DataFactory
{
    public class DataFactory
    {
        public static List<int> ReadFile(string filePath)
        {
            List<int> inputNumbers = new List<int>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    int cur;
                    if (int.TryParse(line, out cur))
                    {
                        inputNumbers.Add(cur);
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("The file path does not exist");
            }

            return inputNumbers;
        }
    }
}
