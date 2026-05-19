using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;

namespace QUANLY_TTB
{
    public static class FileHelper
    {
        // Tuần 2: Cài đặt các hàm đọc/ghi file bằng JSON
        public static List<TrangThietBi> LoadData(string path)
        {
            List <TrangThietBi> list = new List<TrangThietBi>();
            try
            {
                if(!File.Exists(path)) return list;
                string json = File.ReadAllText(path, Encoding.UTF8);

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                list = serializer.Deserialize<List<TrangThietBi>>(json);
                if(list == null) list = new List<TrangThietBi>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi Doc file json " + ex.Message);
            }

            return list;
        }
        
        public static void SaveData(string path, List<TrangThietBi> list)
        {
            try
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json = serializer.Serialize(list);
                File.WriteAllText(path, json, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi ghi file json" + ex.Message);
            }
        }
        
        
    }
}
