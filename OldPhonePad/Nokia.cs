using System.Text;

namespace OldPhonePad;

public static class Nokia
{
    private static readonly Dictionary<char, string> _pads = new()
    {
        {'1',"&'(" },
        {'2',"ABC" },
        {'3',"DEF" },
        {'4',"GHI" },
        {'5',"JKL" },
        {'6',"MNO" },
        {'7',"PQRS" },
        {'8',"TUV" },
        {'9',"WXYZ" },
        {'0'," " },
    };

    public static String OldPhonePad(string input)
    {
        StringBuilder result = new();

        char? currentPad = null;
        int padCount = 0;

        foreach (char pad in input ?? string.Empty)
        {
            if (pad == '#') break;
            else if (pad == '*')
            {
                ResetCurrentPad();
            }
            else if (pad == ' ')
            {
                GenerateRealCharacterAndResetCurrentPad();
            }
            else if (char.IsDigit(pad))
            {
                if (pad == '0' || currentPad != pad)
                {
                    GenerateRealCharacterAndResetCurrentPad();
                    currentPad = pad;
                    padCount = 1;
                }
                else
                {
                    padCount++;
                }
            }
        }

        GenerateRealCharacterAndResetCurrentPad();

        return result.ToString();

        void GenerateRealCharacterAndResetCurrentPad()
        {
            if (currentPad is char pad && padCount > 0)
            {
                if (_pads.TryGetValue(pad, out string? chars))
                {
                    var cycleIndex = padCount % chars.Length;
                    if (cycleIndex == 0) cycleIndex = chars.Length;
                    result.Append(chars[cycleIndex - 1]);
                }
            }
            ResetCurrentPad();
        }

        void ResetCurrentPad()
        {
            padCount = 0;
            currentPad = null;
        }
    }
}