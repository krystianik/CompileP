using System.Text;
using Parser.Lexer.Data.Tokens;

namespace Parser.Lexer.Scanners;

public class ScanIndefiers
{
    public void Scan(String line)
    {
        int identifier = 5;
        line.PadLeft(2);

        char currentChar;
        StringBuilder indentifier = new StringBuilder();
        int currentRow = 1;

        while (Char.TryParse(line.PadLeft(++currentRow), out currentChar) && Char.IsLetter((currentChar)))
        {
        }
    }
}