﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLSinhVien
{
    public class DataProvider
    {
        private static MySqlConnection conn;
        const string connectString = "SERVER=localhost;DATABASE=bt_qlsv;UID=root;PASSWORD=123123;";
        public static List<DangNhap> DangNhaps = new List<DangNhap>();
        public static void OpenConnection()
        {
            conn = new MySqlConnection(connectString);
            conn.Open();
        }

        public static void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static void GetAllDangNhap()
        {
            try
            {
                OpenConnection();
                string query = "SELECT * FROM DangNhap";
                MySqlCommand command = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DangNhap dangNhap = new DangNhap();
                        dangNhap.TaiKhoan = reader["TenDangNhap"].ToString();
                        dangNhap.MatKhau = reader["MatKhau"].ToString();
                        dangNhap.Hoten = reader["Hoten"].ToString();
                        dangNhap.Quyen = reader["Quyen"].ToString();
                        DangNhaps.Add(dangNhap);
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public static DataTable LoadCSDL(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter adaper = new MySqlDataAdapter(command);
                adaper.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
        public static int ThaoTacCSDL(string query)
        {
            int kq = 0;
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand(query, conn);
                kq = command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return kq;
        }
    }
}
