namespace TerminalGuiDesigner;

public static class DictionaryExtensions
{

    public static void AddOrUpdate<K,V>(this Dictionary<K,V> dict,K key, V value) where K : class
    {
        if(dict.ContainsKey(key))
        {
            dict[key] = value;
        }
        else
            dict.Add(key,value);
    }
}