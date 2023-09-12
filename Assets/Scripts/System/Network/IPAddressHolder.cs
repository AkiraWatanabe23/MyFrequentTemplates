using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

/// <summary> jsonファイルから使用するマシンのIPAddressを読み込む（ネットワーク通信の際に使用する） </summary>
public class IPAddressHolder : MonoBehaviour
{
    [SerializeField]
    private TextAsset _textAsset = default;

    private MachinesData _machinesData = default;

    public List<IPAddress> IPAddresses { get; private set; }

    /// <summary> jsonファイルの読み込み、IPAddressへの変換（最初だけ呼び出す） </summary>
    public void IPAddressInitialize()
    {
        if (!_textAsset) { Debug.LogError("jsonファイルの設定がされていません"); return; }

        _machinesData = JsonDataReader<MachinesData>.JsonRead(_textAsset);

        IPAddresses = new();
        foreach (var machineData in _machinesData.Machines) { IPAddresses.Add(IPAddress.Parse(machineData)); }
    }
}

/// <summary> jsonファイルのデータを保存しておくためのクラス </summary>
[Serializable]
public class MachinesData
{
    //以下変数名はjsonファイルに合わせるようにする
    public string MachineName1;
    public string MachineName2;
    public string MachineName3;
    public string MachineName4;

    private string[] _machines = default;
    public string[] Machines
    {
        get
        {
            _machines ??= new string[] { MachineName1, MachineName2, MachineName3, MachineName4 };
            return _machines;
        }
    }
}
