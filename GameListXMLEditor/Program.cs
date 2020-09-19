using System;
using System.Windows.Forms;
using NLog;
// Used to embed DLL's into EXE
using System.Globalization;
using System.Reflection;
using System.IO;

namespace GameListXMLEditor
{
    static class Program
    {
        static Program()
        {
            // Used to embed DLL's into EXE
            AppDomain.CurrentDomain.AssemblyResolve += OnResolveAssembly;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadNlogConfig();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // Used to embed DLL's into EXE 
        private static Assembly OnResolveAssembly(object sender, ResolveEventArgs args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = new AssemblyName(args.Name);

            string path = assemblyName.Name + ".dll";

            if (assemblyName.CultureInfo.Equals(CultureInfo.InvariantCulture) == false)
            {
                path = String.Format(@"{0}\{1}", assemblyName.CultureInfo, path);
            }

            using (Stream stream = executingAssembly.GetManifestResourceStream(path))
            {
                if (stream == null)
                {
                    return null;
                }

                byte[] assemblyRawBytes = new byte[stream.Length];
                stream.Read(assemblyRawBytes, 0, assemblyRawBytes.Length);
                return Assembly.Load(assemblyRawBytes);
            }
        }

        private static void LoadNlogConfig()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("GameListXMLEditor.nlog.config"));
            string xml = reader.ReadToEnd();
            var xmlStream = new System.IO.StringReader(xml);
            var xmlReader = System.Xml.XmlReader.Create(xmlStream);
            LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(xmlReader, null);
        }
    }
}
