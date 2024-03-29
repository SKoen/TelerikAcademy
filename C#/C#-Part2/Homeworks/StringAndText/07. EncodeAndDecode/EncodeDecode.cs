﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncodeDecode
{
    static void Main(string[] args)
    {
        string key = "key";
        string text = "Test of XOR crypting method.";
        string encodesString = GetEncodesString(key, text);
        Console.WriteLine("Encodes text : {0}", encodesString);
        string decodesString = GetDecodesString(key, encodesString);
        Console.WriteLine("Decodes text : {0}", decodesString);
    }

    private static string GetEncodesString(string key, string textToEncodes)
    {
        StringBuilder encodesText = new StringBuilder();
        int keyIndex = 0;
        for (int i = 0; i < textToEncodes.Length; i++)
        {
            if (keyIndex == key.Length)
            {
                keyIndex = 0;
            }
            encodesText.Append((char)(textToEncodes[i] ^ key[keyIndex]));
            keyIndex++;
        }
        return encodesText.ToString();
    }

    private static string GetDecodesString(string key, string textToDecodes)
    {
        StringBuilder decodesText = new StringBuilder();
        int keyIndex = 0;
        for (int i = 0; i < textToDecodes.Length; i++)
        {
            if (keyIndex == key.Length)
            {
                keyIndex = 0;
            }
            decodesText.Append((char)(textToDecodes[i] ^ key[keyIndex]));
            keyIndex++;
        }
        return decodesText.ToString();
    }
}
