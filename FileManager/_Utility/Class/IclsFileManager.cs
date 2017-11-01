using System;
namespace FileManager._Utility.Class
{
    interface IclsFileManager
    {
        string _File_name { get; set; }
        string _File_path { get; set; }
        string _File_type { get; set; }
        void delete();
        void save();
    }
}
