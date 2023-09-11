using UnityEngine;

/// <summary> Jsonファイルを読み込みを行うためのクラス </summary>
/// <typeparam name="T"> 読み込んだデータを保存する型 </typeparam>
public static class JsonDataReader<T>
{
    private static T _loadData = default;

    public static T LoadData => _loadData;

    /// <summary> jsonファイルの読み込み </summary>
    public static void JsonRead()
    {
        //jsonファイル名はプロジェクト毎で異なると思われるため、都度変更
        var jsonText = Resources.Load<TextAsset>("JsonData").ToString();
        _loadData = JsonUtility.FromJson<T>(jsonText);
    }
}
