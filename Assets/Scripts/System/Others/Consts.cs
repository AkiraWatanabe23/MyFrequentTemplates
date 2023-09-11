using System.Collections.Generic;

namespace Constants
{
    /// <summary> 定数管理ファイル（プロジェクト毎に必要があれば追記する） </summary>
    public static class Consts
    {
        public static readonly Dictionary<SceneNames, string> Scenes = new()
        {
            [SceneNames.Title] = "TitleScene",
            [SceneNames.Home] = "HomeScene",
            [SceneNames.MainGame] = "MainGameScene",
        };
    }
}

#region enum一覧
public enum SceneNames
{
    Title,
    Home,
    MainGame,
}
#endregion