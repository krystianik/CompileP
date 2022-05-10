namespace Parser.Parser.Data;

/**
 * Defines valid Token types of the parser.
 */
public enum TokenType {

    
    ParentOpen, 
    ParentClosed,
    Colon,
    SemiColon,
    Asterisk,
    OpenBracket,
    CloseBracket,
    OpenBrace,
    CloseBrace,
    OpenAngleBracket,
    CloseAngleBracket,

    String,
    Identifier,
    Number,
}