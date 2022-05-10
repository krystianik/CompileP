using Parser.Lexer.Data.Tokens;

namespace Parser.Lexer.Scanners.Abstract;

public interface IExecuteScanner
{
    public Token Execute(String character, int column, int line);
}