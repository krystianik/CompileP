using Parser.Lexer.Data.Tokens;

namespace Parser.Lexer;

public class TokenReader
{
    private List<Token> _tokens;

    private int _index;

    public TokenReader(List<Token> tokens) : this(tokens, 0)
    {
    }

    public TokenReader(List<Token> tokens, int index)
    {
        this._tokens = tokens;
        this._index = index;
    }

    /**
     * 
     */
    public Token ReadCurrent()
    {
        if (this.IsEndOfLine())
            return new EndOfLine
            {
                Value = null,
                Location = null
            };
        return this._tokens[this._index];
    }

    private bool IsEndOfLine()
    {
        throw new NotImplementedException();
    }
}