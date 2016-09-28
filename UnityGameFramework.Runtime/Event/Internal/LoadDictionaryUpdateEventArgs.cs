﻿//------------------------------------------------------------
// Game Framework v2.x
// Copyright © 2014-2016 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework.Event;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 加载字典更新事件。
    /// </summary>
    public sealed class LoadDictionaryUpdateEventArgs : GameEventArgs
    {
        /// <summary>
        /// 初始化加载字典更新事件的新实例。
        /// </summary>
        /// <param name="e">内部事件。</param>
        public LoadDictionaryUpdateEventArgs(GameFramework.Localization.LoadDictionaryUpdateEventArgs e)
        {
            LoadDictionaryInfo loadDictionaryInfo = e.UserData as LoadDictionaryInfo;
            DictionaryName = loadDictionaryInfo.DictionaryName;
            DictionaryAssetName = e.DictionaryAssetName;
            Progress = e.Progress;
            UserData = loadDictionaryInfo.UserData;
        }

        /// <summary>
        /// 获取加载字典失败事件编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return (int)EventId.LoadDictionaryFailure;
            }
        }

        /// <summary>
        /// 获取字典名称。
        /// </summary>
        public string DictionaryName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取字典资源名称。
        /// </summary>
        public string DictionaryAssetName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取加载字典进度。
        /// </summary>
        public float Progress
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取用户自定义数据。
        /// </summary>
        public object UserData
        {
            get;
            private set;
        }
    }
}