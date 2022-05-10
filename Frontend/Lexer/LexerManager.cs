using System.Text;
using Parser.Common;
using Parser.Lexer.Data.Tokens;
using Parser.Lexer.Scanners.Abstract;

namespace Parser.Lexer;

public class InputScanner
{
    private StringBuilder _stringBuilder;

    private char _character;

    private List<Token> _tokenList;

    private IExecuteScanner scanManager;

    /// <summary>
    /// Comment test
    /// </summary>
    /// <param name="source">Its cool</param>
    /// <returns>Fine too</returns>
    public TokenList getTokens(String source)
    {
        _tokenList = new List<Token>();
        // StringBuilder buffer = new StringBuilder();

        int tokenCount;
        int c;

        FileReader fileReader = new FileReader(source);

        String? sourceLine = null;
        do
        {
            sourceLine = fileReader.ReadLine();
            if (sourceLine != null)
            {
                this._tokenList.Add(this.ScanLine(sourceLine, fileReader.CurrentLine));
            }
        } while (sourceLine != null);

        return new TokenList();
    }

    private Token ScanLine(string sourceLine, int fileReaderCurrentLine)
    {
        return this.scanManager.Execute(sourceLine, fileReaderCurrentLine, 0);
    }
}

public class TokenList
{
}