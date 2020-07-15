using System;
using System.IO;

using UnityEditor;
using UnityEngine;

namespace Maria.Editor
{
    [InitializeOnLoad]
    public class EditorStartup
    {
        //---------------------------------------------------------------------------------------
        // Fields
        private static EditorService service;

        //---------------------------------------------------------------------------------------
        static EditorStartup()
        {
            initialize();

            UnityEngine.Debug.Log("Engine up and running!");
        }

        //---------------------------------------------------------------------------------------
        private static void initialize()
        {
            if (service == null)
            {
                service = new EditorService();
                service.run();
            }
        }
    }
}
