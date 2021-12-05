using System.Data.SqlClient;
using System.Collections.Generic;
using System;
// using System.Linq;
// using System.Threading.Tasks;

namespace DETHI.Models
{
    public class DataContext
    {
        public string ConnectionString  {get; set;}
        public DataContext (string connectionstring)
        {
            this.ConnectionString = connectionstring;
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }


        public int sqlInsertCanHo(CanHoModel canho)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into canho values(@MaCanHo, @TenCanHo)";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaCanHo", canho.MaCanHo);
                cmd.Parameters.AddWithValue("TenCanHo", canho.TenChuHo);
                return (cmd.ExecuteNonQuery());
            }
        }
        public List<NhanVienModel> sqlListNhanVien()
        {
            List<NhanVienModel> list = new List<NhanVienModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"SELECT * FROM NHANVIEN";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVienModel()
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            TenNhanVien = reader["TenNhanVien"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            GioiTinh = Convert.ToBoolean(reader["GioiTinh"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<object> sqlListByTimeNhanVien(int soLan)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select nv.MaNhanVien, nv.SoDienThoai, count(*) AS SoLan
                                from nhanvien nv join nv_bt on nv.MaNhanVien = nv_bt.MaNhanVien 
                                group by nv.MaNhanVien, nv.SoDienThoai
                                having count(*) >= @SoLanInput";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("SoLanInput", soLan);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            MaNV = reader["MaNhanVien"].ToString(),
                            SoDT = reader["SoDienThoai"].ToString(),
                            SoLan = Convert.ToInt32(reader["SoLan"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<NVBTModel> sqlListNhanVienTheoThietBi(string manv)
        {
           
            List<NVBTModel> list = new List<NVBTModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"SELECT * FROM NV_BT WHERE MaNhanVien = @manv";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manv", manv);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NVBTModel()
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            MaThietBi = reader["MaThietBi"].ToString(),
                            MaCanHo = reader["MaCanHo"].ToString(),
                            LanThu = Convert.ToInt32(reader["LanThu"]),
                            NgayBaoTri = Convert.ToDateTime (reader["NgayBaoTri"]),
                            
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }


        public int sqlDeleteNVBT(string manv, string matb, string mach, int lt)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"delete from NV_BT
                               where MaNhanVien=@manv and MaThietBi=@matb and MaCanHo=@mach and LanThu=@lt";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manv", manv);
                cmd.Parameters.AddWithValue("matb", matb);
                cmd.Parameters.AddWithValue("mach", mach);
                cmd.Parameters.AddWithValue("lt", lt);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int sqlUpdateNVBT(string matbcu, string machcu, int ltcu, NVBTModel nv)
        {
            int count = 0;
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"update NV_BT
                               set nbt=@nbt, matb=@matb, mach=@mach, lanthu=@lt
                               where MaNhanVien=@manv and MaThietBi=@matbcu
                                     and MaCanHo=@machcu and LanThu=@ltcu";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("@manv", nv.MaNhanVien);
                cmd.Parameters.AddWithValue("@matb", nv.MaThietBi);
                cmd.Parameters.AddWithValue("@mach", nv.MaCanHo);
                cmd.Parameters.AddWithValue("@lt", nv.LanThu);
                cmd.Parameters.AddWithValue("@matbcu", matbcu);
                cmd.Parameters.AddWithValue("@machcu", machcu);
                cmd.Parameters.AddWithValue("@ltcu", ltcu);
                cmd.Parameters.AddWithValue("nbt", Convert.ToDateTime(nv.NgayBaoTri));
                cmd.ExecuteNonQuery();
                count++;
                
            }
            return count;
        }
    }
}