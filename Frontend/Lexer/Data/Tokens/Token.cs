namespace Parser.Lexer.Data.Tokens;

public class Token
{
    public String Value { get; set; }

    public Location Location { get; set; }

    public Token(String value)
    {
        Value = value;
        this.Location = new Location(1, 2);
    }

    public Token(String value, Location location) : this(value)
    {
        this.Location = Location;
    }
}