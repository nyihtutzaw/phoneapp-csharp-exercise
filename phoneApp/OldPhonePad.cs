using System;
using System.Collections.Generic;
using System.Text;

public enum SpecialKey
{
    Backspace = '*',
    EndOfInput = '#',

}

public static class OldPhonePad
{


    private static readonly Dictionary<char, string> KeypadMapping = new Dictionary<char, string>
    {
        { '1', "" },
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" },
        { '0', " "},
        { (char)SpecialKey.Backspace, "" }, 
        { (char)SpecialKey.EndOfInput, "" } 
    };

    public static string ConvertInput(string inputKey)
    {
        if (string.IsNullOrEmpty(inputKey) || inputKey == "#")
            return string.Empty;

        StringBuilder outputString = new StringBuilder();
        char lastKey = inputKey[0];
        int pressedCounter = 0;

        foreach (char key in inputKey)
        {
            if (key == ' ' || key == (char)SpecialKey.EndOfInput)
            {
                if (lastKey != ' ' && KeypadMapping.ContainsKey(lastKey) && KeypadMapping[lastKey].Length > 0)
                {
                    outputString.Append(KeypadMapping[lastKey][(pressedCounter - 1) % KeypadMapping[lastKey].Length]);
                }
                pressedCounter = 0;
                lastKey = key;
            }
            else if (key == lastKey)
            {
                pressedCounter++;
            }
            else
            {
                if (pressedCounter > 0 && lastKey != ' ' && KeypadMapping.ContainsKey(lastKey) && KeypadMapping[lastKey].Length > 0)
                {
                    outputString.Append(KeypadMapping[lastKey][(pressedCounter - 1) % KeypadMapping[lastKey].Length]);
                }
                lastKey = key;
                pressedCounter = 1;

                if (lastKey == (char)SpecialKey.Backspace)
                {
                    if (outputString.Length > 0)
                    {
                        outputString.Remove(outputString.Length - 1, 1);
                    }
                    pressedCounter = 0;
                }
            }
        }

        return outputString.ToString();
    }
}