﻿using Jing;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Zero.Edit
{
    /// <summary>
    /// Zero框架编辑器菜单
    /// </summary>
    public class EditorMenu : AEditorWin
    {
        [MenuItem("Zero/发布/Setting", false, 0)]
        public static void Setting()
        {
            SettingEditorWin.Open();
        }

        [MenuItem("Zero/发布/HotRes", false, 100)]
        public static void PublishHotRes()
        {
            HotResEditorWin.Open();
        }     

        [MenuItem("Zero/iOS/ProjectInit", false, 300)]
        public static void IosProjectInit()
        {
            IOSProjectInitEditorWin.Open();
        }

        [MenuItem("Zero/调试/清理[Caches]目录", false, 400)]
        public static void ClearCachesDir()
        {
            var root = Directory.GetParent(Application.dataPath).FullName;
            var cacheDirPath = FileSystem.CombineDirs(false, root, "Caches");
            Directory.Delete(cacheDirPath, true);
        }

        [MenuItem("Zero/调试/GC", false, 401)]
        public static void GC()
        {
            ResMgr.Ins.DoGC();
        }

        [MenuItem("Zero/资源/Packing Tag Delete", false, 501)]
        public static void PackingTagEdit()
        {
            PackingTagEditorWin.Open();
        }

        [MenuItem("Zero/资源/查找无用的资源", false, 502)]
        public static void FindUselessAssets()
        {
            FindUselessAssetsEditorWin.Open();
        }

        [MenuItem("Zero/IL2CPP/Create [Link.xml]", false, 600)]
        public static void LinkerXMLCreate()
        {
            LinkXMLEditorWin.Open();
        }

        [MenuItem("Zero/ILRuntime", false, 700)]
        public static void ILRuntimeEdit()
        {
            ILRuntimeEditorWin.Open();
        }

        [MenuItem("Zero/Document", false, 800)]
        public static void Document()
        {            
            //访问网站
            Application.OpenURL(@"https://jinglikeblue.github.io/Zero/Docs/Intro");
        }
    }
}