using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTrade.OracleDAL
{
    //暂时用Sql Server代替 Oracle
        public static class DBHelper
        {

            //private static string configure = "server=.;uid=sa;pwd=123456;database=RMSchoolDB";
            public static string connStr = /*ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;*/
        "server=.;uid=sa;pwd=123456;database=RMSchoolDB";
        //["connStr"] 是Config里面的索引，对应Config文件内，在节点内add name添加的索引key，

        public static void TestConnection()
        {
            Console.WriteLine("测试Oracle连接");
            #region
            //using (SqlConnection conn1 = new SqlConnection(connStr))
            //{
            //    try
            //    {
            //        conn1.Open();//打开连接
            //        Console.WriteLine("测试");
            //        Console.WriteLine($"DataSource:{conn1.DataSource}");
            //        Console.WriteLine($"DataBase:{conn1.DataSource}");
            //        Console.WriteLine($"DataState:{conn1.State}");
            //        Console.WriteLine("Sqlserver 测试成功");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            #endregion
        }
        /// <summary>
        /// 添加、删除、修改通用方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
            {
                int result = 0;
                //继承IDisposable 接口的类，可执行与释放或重置非托管资源
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    //using原理：类似try catch finally
                    try
                    {
                        conn.Open();//打开连接
                        SqlCommand command = new SqlCommand(sql, conn);
                        result = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //写控制台日志
                        Console.WriteLine(ex.Message);
                        //文档日志 IO
                        //业务日志
                    }
                }
                return result;
            }
            public static int ExecuteNonQuery(string sql, params SqlParameter[] paras)
            {
                if (paras != null)
                {
                    Console.WriteLine("value of first Parameter" + paras[0].Value);
                }
                int result = 0;
                //using 用于继承IDisposable 接口的类，可执行与释放或重置非托管资源
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    //using原理：类似try catch finally
                    try
                    {
                        conn.Open();//打开连接
                        SqlCommand command = new SqlCommand(sql, conn);
                        command.Parameters.AddRange(paras);
                        result = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //写控制台日志
                        Console.WriteLine(ex.Message);
                        //文档日志 IO
                        //业务日志
                    }
                }
                return result;
            }
            public static object ExecuteScalar(string sql, SqlParameter[] paras = null //params SqlParameter[] paras
                )//默认值
            {
                object result = null;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();//打开连接
                        SqlCommand command = new SqlCommand(sql, conn);
                        command.Parameters.AddRange(paras);
                        result = command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        //写控制台日志
                        Console.WriteLine(ex.Message);
                        //文档日志 IO
                        //业务日志
                    }
                }
                return result;
            }
            public static object ExecuteScalar(string sql)
            {
                object obj;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand(sql, conn);
                        obj = command.ExecuteScalar();
                        return obj;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    obj = 0 as object;
                    return obj;

                }
            }
            public static void SqlDataReader()
            {
                string sql = "";
                SqlDataReader reader = null;
                SqlConnection conn = new SqlConnection(connStr);
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    //connection关闭时，reader关闭
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }

            public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] paras)
            {
                SqlDataReader reader = null;
                SqlConnection conn = new SqlConnection(connStr);
                try
                {
                    conn.Open();//打开连接
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddRange(paras);
                    reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    //写控制台日志
                    Console.WriteLine(ex.Message);
                    //文档日志 IO
                    //业务日志
                }
                return reader;
            }
            //案例1
            public static void test1()
            {
                Console.WriteLine("hello");
                //访问数据库步骤
                //步骤一：创建数据库连接对象
                string connString =
                "Data Source= .; Initial Catalog=RMSchoolDB; User ID=sa; pwd=123456";
                SqlConnection conn = new SqlConnection(connString);
                //不论程序操作有多复杂，都属于添加、删除、修改、查询四种操作
                //server:IP,端口
                //server=.;uid=sa;pwd=123456;database=RMSchoolDB;
                Console.WriteLine("初始化");
                //步骤二：打开
                conn.Open();//打开数据库
                            //同一个对象打开多次会报错,多个对象可以多次打开
                Console.WriteLine("连接成功！");

                //步骤三：创建执行脚本的对象，支持存储过程，SQL语句,支持表名
                Console.ReadKey();
                string Sql = "";
                SqlCommand command = new SqlCommand(Sql, conn);
                //步骤四：执行SQL返回第一行第一列
                object obj = command.ExecuteScalar(); //返回受影响的行数

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int userid = (int)reader["userid"];
                    string username = reader["username"].ToString();
                    Console.WriteLine();
                    reader.Close();
                }
                reader.Read();
                if (obj != null)
                {
                    int result = (int)obj;
                    if (result > 0)
                    {
                        Console.WriteLine("登录成功");

                    }
                    else
                    {
                        Console.WriteLine("登录失败");
                    }

                    result = command.ExecuteNonQuery();
                    if (result > 0)
                    {


                    }
                    else { }
                    //新的执行的语句
                    command.CommandText = "delete t1 where id=111";
                    //执行
                    int result2 = command.ExecuteNonQuery();

                    conn.Close();//关闭数据库
                    Console.WriteLine("关闭成功！");


                }
            }

            public static DataSet GetDataSet(string sql, params SqlParameter[] paras)
            {

                DataSet ds = null;
                SqlConnection conn = new SqlConnection(connStr);
                //conn.Open();  如果使用open，则可以Fill多次。否则只能Fill一次后，自动关闭
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddRange(paras);
                //自动打开
                //数据库自动打开
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                ds = new DataSet();
                adapter.Fill(ds);
                //Fill自动关闭
                return ds;

            }
        }
    
}
