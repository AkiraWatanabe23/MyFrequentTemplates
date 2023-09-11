using UnityEngine;

/// <summary> Jsonファイルを読み込みを行うためのクラス </summary>
/// <typeparam name="T"> 読み込んだデータを保存する型 </typeparam>
public static class JsonDataReader<T>
{
    private static T _loadData = default;

    public static T LoadData => _loadData;

    /// <summary> jsonファイルの読み込み </summary>
    public static void JsonRead(TextAsset textAsset)
    {
        var jsonText = textAsset.ToString();
        _loadData = JsonUtility.FromJson<T>(jsonText);
    }
}
