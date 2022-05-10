namespace Parser.Lexer.Data.Tokens;

public class Symbol : Token
{
    public Symbol(String value) : base(value)
    {
    }

    public Symbol(String value, Location location) : base(value, location)
    {
    }
}