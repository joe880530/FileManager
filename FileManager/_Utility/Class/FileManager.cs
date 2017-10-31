using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FileManager._Utility.Class
{
    class FileManager
    {
        #region Property Decleration(속성 선언)
        public string _File_name
        {
            //읽기, 쓰기 용도
            get;
            set;
        }

        public string _File_type
        {
            //읽기, 쓰기 용도
            get;
            set;
        }

        public string _File_path
        {
            //읽기, 쓰기 용도
            get;
            set;
        }
        #endregion
        
        public void save()
        {
            try
            {
                string _objFullPath = "";

                _objFullPath = _File_path + "\\" + _File_name + string.Format(".{0}", _File_type);

                //#region 파일 타입 분류.
                //switch (_File_type)
                //{
                //    case "txt":
                //        {
                //            _objFullPath = _objFullPath + string.Format(".{0}", _File_type);
                //            Console.WriteLine("Save txt...");
                //            break;
                //        }
                //    case "csv":
                //        {
                //            _objFullPath = _objFullPath + string.Format(".{0}", _File_type);
                //            Console.WriteLine("Save csv...");
                //            break;
                //        }
                //    default:
                //        {
                //            Console.WriteLine("Save Default...");
                //            break;
                //        }
                //}
                //#endregion
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void delete()
        {
            
        }
    }
}
