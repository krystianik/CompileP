using System.Text;
using Parser.Lexer.Data.Tokens;
using Parser.Lexer.Scanners.Abstract;

namespace Parser.Lexer.Scanners;

public class ScanDoubles : IExecuteScanner
{
    public Token Execute(String character, int column, int line)
    {
        StringBuilder charBuffer = new StringBuilder();
        int index = 1;
        while (Char.IsDigit(character, ++index))
        {
            charBuffer.Append(character);
        }

        return new Token(charBuffer.ToString(), new Location(column, line));
    }
}