using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace QUANLY_TTB
{
    public static class FileHelper
    {
        public static List<TrangThietBi> LoadData(string path)
        {
            List <TrangThietBi> list = new List<TrangThietBi>();
            try
            {
                if(!File.Exists(path)) return list;
                string json = File.ReadAllText(path, Encoding.UTF8);

                list = JsonConvert.DeserializeObject<List<TrangThietBi>>(json); 
                if(list == null) list = new List<TrangThietBi>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi Doc file du lieu " + ex.Message);
            }

            return list;
        }
        
        public static void SaveData(string path, List<TrangThietBi> list)
        {
            try
            {
             
                string json = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(path, json, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi ghi file json" + ex.Message);
            }
        }
        
        
    }
}
