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
        
        /// <summary>
        /// Đọc file JSON trả về ChiMucData, trả về null nếu file không tồn tại hoặc lỗi.
        /// </summary>
        public static ChiMucData LoadIndex(string path)
        {
            try
            {
                if (!File.Exists(path)) return null;
                string json = File.ReadAllText(path, Encoding.UTF8);
                return JsonConvert.DeserializeObject<ChiMucData>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi doc file index " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Ghi ChiMucData ra file JSON.
        /// </summary>
        public static void SaveIndex(string path, ChiMuc chiMuc)
        {
            try
            {
                ChiMucData data = chiMuc.ExportData();
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                
                // Rút gọn các mảng (array) số nguyên trên 1 dòng
                json = System.Text.RegularExpressions.Regex.Replace(json, @"\[\s*([\d\s,]+)\s*\]", m => 
                    "[" + System.Text.RegularExpressions.Regex.Replace(m.Groups[1].Value, @"\s+", "") + "]", 
                    System.Text.RegularExpressions.RegexOptions.Singleline);
                
                // Trả lại dấu cách sau dấu phẩy cho đẹp (ví dụ [0, 1] thay vì [0,1])
                json = json.Replace(",", ", ");
                
                File.WriteAllText(path, json, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi ghi file index " + ex.Message);
            }
        }
        
    }
}
