namespace Parser.Common;

public class FileReader
{
    /**
     * 
     */
    private readonly Dictionary<int, String> _fileOutput = new Dictionary<int, string>();

    private int _currentLine = 0;

    private readonly String _filePath;

    public int CurrentLine => this._currentLine;

    public FileReader(String filePath)
    {
        this._filePath = filePath;
    }

    public String? ReadLine()
    {
        if (!ProcessSource()) return null;

        try
        {
            return this._fileOutput[++this._currentLine];
        }
        catch (ArgumentOutOfRangeException exception)
        {
            
            return null;
        }
    }

    private bool ProcessSource()
    {
        if (_currentLine.Equals(0))
        {
            this.ConvertSource(this._filePath);
            if (this._fileOutput.ContainsKey(_currentLine + 1))
            {
                this._currentLine++;
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    public String? ReadLine(int line)
    {
        
        if (_currentLine.Equals(0))
        {
            this.ConvertSource(this._filePath);
            if (this._fileOutput.ContainsKey(_currentLine + 1))
            {
                this._currentLine++;
            }
            else
            {
                return null;
            }
        }

        try
        {
            this._currentLine = line;
            return this._fileOutput[line];
        }
        catch (ArgumentOutOfRangeException exception)
        {
            this._currentLine = 1;
            return null;
        }
    }

    private bool CanRead() => _fileOutput.ContainsKey(this._currentLine) ? true : false;

    private void ConvertSource(String filePath)
    {
        if (File.Exists(filePath))
        {
            int lineNumber = 1;
            foreach (String line in File.ReadLines(filePath))
            {
                _fileOutput.Add(lineNumber++, line);
            }
        } 
    }
}