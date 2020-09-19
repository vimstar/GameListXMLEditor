using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using NLog;

namespace GameListXMLEditor
{
    public static class ImageElementUpdater
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// This function parses the XML and looks for images to associate with each game. If found the image will be copied 
        /// and the XML updated with the image path.
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="extension"></param>
        /// <param name="imagePath"></param>
        public static void ProcessXML(string xmlPath, string extension, string imagePath = null)
        {
            if (!File.Exists(xmlPath))
            {
                return;
            }

            XDocument doc = XDocument.Load(xmlPath);

            foreach ( XElement node in doc.Root.Elements().ToList())
            {
                

                string fileName = XmlServices.GetNodeValueAsString(node.Elements(), "path");
                if (fileName[0] == '/')
                {
                    node.Remove();
                    continue;
                }
                int filenameStart = 0;
                int filenameEnd = 0;
                bool endFound = false;
                for (int i= fileName.Length - 1; i>=0; i--)
                {
                    if (fileName.Substring(i, 1) == "." && !endFound)
                    {
                        filenameEnd = i - 1;
                        endFound = true;
                    }
                    if (fileName.Substring(i, 1) == "/")
                    {
                        filenameStart = i + 1;
                        break;
                    }
                }

                fileName = fileName.Substring(filenameStart, (filenameEnd - filenameStart) + 1);

                fileName = fileName + extension;

                string mediaFileName = "./media/images/" + fileName;

                bool exist = XmlServices.DoesNodeExist(node.Elements(), "image");
                if (exist)
                {
                    string path = XmlServices.GetNodeValueAsString(node.Elements(), "image");
                    fileName = Path.GetFileName(path);
                }

                if (!string.IsNullOrEmpty(imagePath))
                {
                    if (CopyImageFile(fileName, imagePath))
                    {
                        if(!exist)
                            node.Add(new XElement("image", mediaFileName));
                    }
                }
            }

            doc.Save(xmlPath + ".new");
        }

        /// <summary>
        /// Change the Name field for each game to match the name of the game file.
        /// </summary>
        /// <param name="xmlPath"></param>
        public static void FixNames(string xmlPath)
        {
            if (!File.Exists(xmlPath))
                return;

            XDocument doc = XDocument.Load(xmlPath);

            foreach (XElement node in doc.Root.Elements().ToList())
            {


                string fileName = XmlServices.GetNodeValueAsString(node.Elements(), "path");
                int filenameStart = 0;
                int filenameEnd = 0;
                bool endFound = false;
                for (int i = fileName.Length - 1; i >= 0; i--)
                {
                    if (fileName.Substring(i, 1) == "." && !endFound)
                    {
                        filenameEnd = i - 1;
                        endFound = true;
                    }
                    if (fileName.Substring(i, 1) == "/")
                    {
                        filenameStart = i + 1;
                        break;
                    }
                }

                fileName = fileName.Substring(filenameStart, (filenameEnd - filenameStart) + 1);

                node.Element("name").Value = fileName;
            }

            doc.Save(xmlPath + ".new");
        }

        /// <summary>
        /// This will validate that each image exists that is listed in the gamelist.xml file.
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="imagePath"></param>
        public static void ValidateImages(string xmlPath, string imagePath)
        {
            if (!File.Exists(xmlPath))
            {
                return;
            }

            XDocument doc = XDocument.Load(xmlPath);

            foreach (XElement node in doc.Root.Elements().ToList())
            {
                if (!XmlServices.DoesNodeExist(node.Elements(), "image"))
                {
                    continue;
                }

                string path = XmlServices.GetNodeValueAsString(node.Elements(), "image");
                string fileName = Path.GetFileName(path);
                string imageFile = Path.Combine(imagePath, fileName);

                if (!File.Exists(imageFile))
                {
                    node.Element("image").Remove();
                }
            }

            doc.Save(xmlPath + ".new");
        }


        private static bool CopyImageFile (string fileName, string path)
        {
            string from = Path.Combine(path, fileName);
            string mediaPath = ".\\media\\images";
            string to = mediaPath + "\\" + fileName;
            try
            {
                Directory.CreateDirectory(mediaPath);
                File.Copy(from, to, true);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Cannot copy file {from} ");
                return false;
            }
            return true;
        }
    }
}
