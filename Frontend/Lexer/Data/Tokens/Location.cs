namespace Parser.Lexer.Data.Tokens;

/**
 * Location inf format of X:Y off the token 
 */
public class Location
{
    public int Column { get; set; }

    public int Line { get; set; }

    public Location(int column, int line)
    {
        this.Column = column;
        this.Line = line;
    }

    public override string ToString()
    {
        return "[X:Y]|[" + this.Column + ":" + this.Line + "]";
    }
}