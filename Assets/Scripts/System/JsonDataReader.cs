using UnityEngine;

/// <summary> jsonファイルを読み込みを行うためのクラス </summary>
/// <typeparam name="T"> 読み込んだデータを保存する型 </typeparam>
public static class JsonDataReader<T>
{
    /// <summary> jsonファイルの読み込み </summary>
    public static T JsonRead(TextAsset textAsset)
    {
        //引数に渡されたjsonファイルを文字列型に変換する
        var jsonText = textAsset.ToString();
#if UNITY_EDITOR
        Debug.Log(jsonText);
#endif

        //文字列に変換したjsonデータを指定された型に置き換える
        T loadData = JsonUtility.FromJson<T>(jsonText);

        return loadData;
    }
}
