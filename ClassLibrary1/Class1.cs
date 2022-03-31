/// <summary>
/// Indexers and indexer overloading
/// </summary>
public class Car
{
    private static string[] _brands = new string[] {"Dacia", "Chevrolet", "Oldsmobile", "Cadillac"};
    private  string[] _names = new string[] { "first", "second", "third", "fourth" };

    private int length = _brands.Length;

    //public indexer
    public string this[int index]
    {
        set
        {
            _brands[index] = value;
        }
        get
        {
            return _brands[index]; 
        }
    }
    public int Length {
        get { return length; }
    }

    //indexer overloading
    public string this[string name]
    {
        set
        {
            _brands[System.Array.IndexOf(_names, name)] = value;
        }
        get
        {
            return _brands[System.Array.IndexOf(_names, name)];
        }

    }
}
