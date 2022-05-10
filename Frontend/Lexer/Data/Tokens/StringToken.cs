namespace Parser.Lexer.Data.Tokens;

public class StringToken : Token
{
    public StringToken(String value) : base(value)
    {
    }

    public StringToken worldLocation(Location location)
    {
        this.Location = location;
        return this;
    }

    public override string ToString()
    {
        return "String[" + this.Value + "]";
    }
}