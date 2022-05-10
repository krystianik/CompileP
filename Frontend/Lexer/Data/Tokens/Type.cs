using System.Text;

namespace Parser.Lexer.Data.Tokens;

public class Type : Token
{
    public const String Void = "void";
    public const String Int = "int";
    public const String Long = "long";
    public const String Byte = "byte";
    public const String Short = "short";
    public const String Double = "double";
    public const String Float = "float";
    public const String Char = "char";
    public const String Boolean = "boolean";
    public const String String = "string";

    public readonly List<String> Types = new List<String>
    {
        Void, Int, Long, Byte, Short, Double, Float, Char, Boolean, String
    };

    public String Name;
    public byte Array;

    public Type(string name) : base(name)
    {
        this.Name = name;
        this.Array = 0;
    }

    public Type(String name, byte array) : base(name)
    {
        this.Name = name;
        this.Array = array;
    }

    public String Describe()
    {
        StringBuilder strBuilder = new StringBuilder();
        for (int i = 0; i < this.Array; i++)
        {
            strBuilder.Append("[");
        }

        strBuilder.Append(this.Name);
        return strBuilder.ToString();
    }
}