using System;
using System.Reflection;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace AssessmentHelperLib
{
    public class FileDatabase
    {
        private FileDatabase()
        {
        }

        public static FileDatabase Setup(string a_filename)
        {
            return new FileDatabase();
        }

        private static string GetFileName()
        {
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return Path.Combine(dir, "assessment.asm");
        }

        public static Assessment Read()
        {
            string path = GetFileName();
            return Read(path);
        }

        public static Assessment Read(string a_path)
        {
            if (!File.Exists(a_path))
                return new Assessment();

            using (var fs = new FileStream(a_path, FileMode.Open))
            {
                var ds = new DataContractJsonSerializer(typeof(Assessment));
                Assessment ass = (Assessment)ds.ReadObject(fs);
                return ass;
            }
        }


        public static void Write(Assessment a_assessment)
        {
            string path = GetFileName();
            Write(a_assessment, path);
        }

        public static void Write(Assessment a_assessment, string a_path)
        {
            using (var fs = new FileStream(a_path, FileMode.Create))
            {
                var ds = new DataContractJsonSerializer(typeof(Assessment));
                ds.WriteObject(fs, a_assessment);
            }
        }

    }
}
