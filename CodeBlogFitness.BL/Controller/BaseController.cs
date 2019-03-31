using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CodeBlogFitness.BL.Controller
{
    public abstract class BaseController
    {        
        protected void Save(string FileName, object item)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item);
            }
        }
        protected T Load <T>(string fileName)
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {                
                if (fs.Length > 0 && formatter.Deserialize(fs) is T items)
                {
                    fs.Seek(0, SeekOrigin.Begin);
                    return items;
                }
                else
                {
                    return default(T);
                }
            }
        }
    }   
}
