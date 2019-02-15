using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLyBanHang.Controllers
{
    public class QLBHController : ApiController
    {
        [HttpGet]
        public List<Customer> customerList()
        {
            List<Customer> list = new List<Customer>();
            try
            {
                String strCon = System.Configuration.ConfigurationManager.AppSettings["strConnection"];
                SqlConnection conn = new SqlConnection(strCon);
                conn.Open();
                string sql = "SELECT * FROM KHACHHANG";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                Customer customer;
                while (reader.Read())
                {
                    customer = new Customer();
                    customer.email = reader.GetString(1);
                    customer.name = reader.GetString(2);
                    customer.password = reader.GetString(3);
                    customer.mobile = reader.GetInt32(4);
                    list.Add(customer);
                }
                conn.Close();
                return list;
            }
            catch (Exception e)
            {
                throw e ;
            }     
        }
        [HttpGet]
        public Customer getInfo(String email ,String password)
        {
            try
            {
                String strCon = System.Configuration.ConfigurationManager.AppSettings["strConnection"];
                SqlConnection conn = new SqlConnection(strCon);
                conn.Open();
                string sql = "SELECT Email,Name FROM KHACHHANG Where Email=@email AND Password=@password";    
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                SqlDataReader reader = command.ExecuteReader();
                Customer customer = null;
                while (reader.Read())
                {
                    customer = new Customer();
                    customer.email = reader.GetString(0);
                    customer.name = reader.GetString(1);
                   
                }
                conn.Close();
                return customer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpGet]
        public Boolean checkAccountExits(String email)
        {
            try
            {
                String strCon = System.Configuration.ConfigurationManager.AppSettings["strConnection"];
                SqlConnection conn = new SqlConnection(strCon);
                conn.Open();
                string sql = "SELECT Email FROM KHACHHANG Where Email=@email";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    return false;
                }
                conn.Close();
                return true;

            }
            catch(Exception e)
            {
                throw e;
            }              
        }
        [HttpPost]
        public Boolean signUp(String email, String name, String password, int phone)
        {
            try
            {
                if (!checkAccountExits(email)) return false; //neu co gia tri roi thi khong luu vao nua
                string strCon = System.Configuration.ConfigurationManager.AppSettings["strConnection"];
                SqlConnection conn = new SqlConnection(strCon);
                conn.Open();
                string sql = "INSERT INTO KHACHHANG(Email,Name,Password,Mobile) VALUES(@email,@name,@password,@mobile)";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value =password;
                command.Parameters.Add("@mobile", SqlDbType.Int).Value =phone;
                int kq = command.ExecuteNonQuery();
                conn.Close();
                return kq > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
