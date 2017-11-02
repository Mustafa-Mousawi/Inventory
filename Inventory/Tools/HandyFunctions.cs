using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxialPay.Windows.Libraries.General;

namespace Inventory.Tools
{
    class HandyFunctions
    {
        private static ReaderWriterLockSlim _readerWriterLock = new ReaderWriterLockSlim();

        //For get IP Address
        public static string GetIPAddress()
        {
            string IPAddress = "0.0.0.0";
            try
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses(Dns.GetHostName());

                if (ipAddress != null & ipAddress.Length > 0)
                {
                    foreach (IPAddress ipa in ipAddress)
                    {
                        if (ipa.AddressFamily == AddressFamily.InterNetwork)
                        {
                            IPAddress = ipa.ToString();
                        }
                    }
                }

                return IPAddress;
            }
            catch (Exception)
            {
                return IPAddress;
            }
        }

        public static Rectangle GetScreenBounds(Control control)
        {
            return Screen.FromControl(control).Bounds;
        }



        // For trimming the string and adding ...
        public static string Truncate(string value, int maxChars)
        {
            return value.Trim().Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }

        //Archive current Log file
        public static void ArchiveLog()
        {
            try
            {
                var pathName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AxialPay");
                File.Move(pathName + "\\Log.txt", pathName + "\\Logs\\Log" + DateTime.Now.ToString("_mmddyyyy_HHmmss") + ".txt");
            }
            catch (Exception ex)
            {
            }
        }

        //LaunchKeyboard
        public static void LaunchKeyboard()
        {
            try
            {
                string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
                string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

                Process.Start(keyboardPath);
            }
            catch (Exception ex)
            {
                Utility.Log(ex.Message);
            }
        }



        //Clearing current Log file
        public static void ClearLog()
        {
            try
            {
                StreamWriter w = File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AxialPay\\Log.txt"));
                w.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public static DateTime getTime()
        {
            return DateTime.Now;
        }

        public static string calculateTime(DateTime startTime, DateTime endTime)
        {
            var result = "";

            TimeSpan difference = endTime - startTime;
            result = "Total Seconds: " + difference.TotalSeconds;
            return result;
        }

        //Log writing
        public static void Log(String logMessage)
        {
            try
            {
                var pathName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AxialPay\\Log.txt");

                StreamWriter w = File.AppendText(pathName);
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("  :");
                w.WriteLine("  :{0}", logMessage);
                w.WriteLine("-------------------------------");
                w.Close();
            }
            catch (Exception ex)
            {
                var pathName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AxialPay");

                if (!Directory.Exists(pathName))
                {
                    Directory.CreateDirectory(pathName);
                }

                if (!Directory.Exists(pathName + "\\Logs"))
                {
                    Directory.CreateDirectory(pathName + "\\Logs");
                }
            }
        }

        //Clean Log files
        public static void CleanLogs()
        {
            try
            {
                var pathName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AxialPay");

                string[] files = Directory.GetFiles(pathName + "\\Logs");

                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    if (fi.LastAccessTime < DateTime.Now.AddMonths(-1))
                        fi.Delete();
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        //Encrypting String 
        public static string EncryptString(string inputString)
        {
            MemoryStream memStream = null;
            try
            {
                byte[] key = { };
                byte[] IV = { 12, 21, 43, 17, 57, 35, 67, 27 };
                string encryptKey = "0YPnQ8kP";
                key = Encoding.UTF8.GetBytes(encryptKey);
                byte[] byteInput = Encoding.UTF8.GetBytes(inputString);
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                memStream = new MemoryStream();
                ICryptoTransform transform = provider.CreateEncryptor(key, IV);
                CryptoStream cryptoStream = new CryptoStream(memStream, transform, CryptoStreamMode.Write);
                cryptoStream.Write(byteInput, 0, byteInput.Length);
                cryptoStream.FlushFinalBlock();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }

            return Convert.ToBase64String(memStream.ToArray());
        }

        //Decrypting String 
        public static string DecryptString(string inputString)
        {
            MemoryStream memStream = null;
            try
            {
                byte[] key = { };
                byte[] IV = { 12, 21, 43, 17, 57, 35, 67, 27 };
                string encryptKey = "0YPnQ8kP";
                key = Encoding.UTF8.GetBytes(encryptKey);
                byte[] byteInput = new byte[inputString.Length];
                byteInput = Convert.FromBase64String(inputString);
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                memStream = new MemoryStream();
                ICryptoTransform transform = provider.CreateDecryptor(key, IV);
                CryptoStream cryptoStream = new CryptoStream(memStream, transform, CryptoStreamMode.Write);
                cryptoStream.Write(byteInput, 0, byteInput.Length);
                cryptoStream.FlushFinalBlock();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }

            Encoding encoding1 = Encoding.UTF8;
            return encoding1.GetString(memStream.ToArray());
        }


        public static void textBox_Click(object sender, EventArgs e)
        {
            LaunchKeyboard();
        }




        //Getting the utc time
        public static string GetUTCDateTimeNow()
        {
            return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //Getting the local time
        public static string GetDateTimeNow()
        {
            // return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Central Standard Time").ToString();            
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //Getting the configuration parameter
        public static DBDataObject GetSettings()
        {
            string[] fieldstoselect = { "ReceiptPrinter", "BarcodeReceiptPrinter", "StoreName", "StoreAddress", "StorePhone" };
            NameValueCollection whereValues = new NameValueCollection()
            {
                {"rowid", "1"}
            };

            string[] relator = { " = " };
            string query = Utility.SelectQuery(fieldstoselect, "[Settings]", whereValues, relator);
            DBDataObject dbDataObject = Utility.ExecuteSelect(query);

            return dbDataObject;
        }


        //For building the insert query
        public static string InsertQuery(string INTO, NameValueCollection values, String insertedId)
        {
            string queryString = "INSERT INTO " + INTO + " (";
            for (int i = 0; i < values.Count; i++)
            {
                queryString += values.Keys[i] + (i + 1 == values.Count ? "" : ",");
            }

            if (insertedId != null)
            {
                queryString += ")" + " VALUES (";
            }
            else
            {
                queryString += ") VALUES (";
            }

            for (int i = 0; i < values.Count; i++)
            {
                queryString += Escape(values[values.Keys[i]]) + (i + 1 == values.Count ? ("") : (","));
            }

            queryString += ");";
            return queryString;
        }

        //For building the update query
        public static string UpdateQuery(string UPDATE, NameValueCollection set, NameValueCollection where)
        {
            string queryString = "UPDATE " + UPDATE + " SET";

            for (int i = 0; i < set.Count; i++)
            {
                queryString += " " + set.Keys[i] + "=" + Escape(set[set.Keys[i]]) + (i + 1 == set.Count ? ("") : (","));
            }

            if (where != null)
            {
                queryString += " WHERE";

                for (int i = 0; i < where.Count; i++)
                {
                    queryString += " " + where.Keys[i] + "=" + Escape(where[where.Keys[i]]);
                }
            }

            queryString += ";";

            return queryString;
        }

        //For building the select query
        public static string SelectPageQuery(string[] select, string from, NameValueCollection where, string[] relator, string startpage, string endpage)
        {
            string queryString = "SELECT ";

            for (int i = 0; i < select.Length; i++)
            {
                queryString += select[i] + (i + 1 == select.Length ? ("") : (","));
            }
            queryString += " FROM " + from;

            if (where != null)
            {
                queryString += " WHERE ";

                for (int i = 0; i < where.Count; i++)
                {

                    if (relator[i] != " IN " && relator[i] != " ")
                    {
                        queryString += " " + where.Keys[i] + relator[i] + Escape(where[where.Keys[i]]);
                    }
                    else
                    {
                        queryString += " " + where.Keys[i] + relator[i] + where[where.Keys[i]];
                    }
                }
            }

            queryString += " LIMIT " + startpage + ", " + endpage + " ;";
            return queryString;
        }


        //For building the select query
        public static string SelectQuery(string[] select, string from, NameValueCollection where, string[] relator)
        {
            string queryString = "SELECT ";

            for (int i = 0; i < select.Length; i++)
            {
                queryString += select[i] + (i + 1 == select.Length ? ("") : (","));
            }
            queryString += " FROM " + from;

            if (where != null)
            {
                queryString += " WHERE ";

                for (int i = 0; i < where.Count; i++)
                {
                    if (relator != null)
                    {
                        if (relator[i] != " IN " && relator[i] != " NOT IN " && relator[i] != " ")
                        {
                            queryString += " " + where.Keys[i] + relator[i] + Escape(where[where.Keys[i]]);
                        }
                        else
                        {
                            queryString += " " + where.Keys[i] + relator[i] + where[where.Keys[i]];
                        }
                    }
                    else
                    {
                        queryString += " " + where.Keys[i] + where[where.Keys[i]];
                    }
                }
            }

            queryString += ";";
            return queryString;
        }

        //For building the delete query
        public static string DeleteQuery(string from, NameValueCollection where)
        {

            string queryString = "DELETE FROM " + from + " WHERE";
            for (int i = 0; i < where.Count; i++)
            {
                queryString += " " + where.Keys[i] + "=" + Escape(where[where.Keys[i]]);
            }

            queryString += ";";
            return queryString;
        }

        //For building the delete query
        public static string DeleteQuery(string from)
        {
            string queryString = "DELETE FROM " + from;
            queryString += ";";
            return queryString;
        }

        //Excape character for query building
        public static string Escape(string input)
        {
            return "'" + input + "'";
        }

        private static string DBConnectionString()
        {
            return "Data Source=database.db";
        }

        //Standard menthod for select query
        public static DBDataObject ExecuteSelect(String query)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection(DBConnectionString());
            DBDataObject dbDataObject = new DBDataObject();

            try
            {
                _readerWriterLock.EnterReadLock();

                SQLiteCommand sqlCommand = new SQLiteCommand(sqlConnection);
                sqlConnection.Open();
                sqlCommand.CommandText = query;
                SQLiteDataReader reader = sqlCommand.ExecuteReader();
                dbDataObject.data = new DataTable();

                //for (int i = 0; i < reader.FieldCount; i++)
                //{
                //    dbDataObject.data.Columns.Add(reader.GetName(i));
                //}

                //var j = reader.FieldCount;

                //while (reader.Read())
                //{
                //    DataRow row = dbDataObject.data.NewRow();
                //    row["Name"] = reader[reader];
                //    row["Marks"] = "500";
                //}

                dbDataObject.data.Load(reader);

            }
            catch (Exception ex)
            {
                dbDataObject.message = ex.Message;
                Log(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                _readerWriterLock.ExitReadLock();
            }

            return dbDataObject;
        }

        //Standard menthod for insert query
        public static DBDataObject ExecuteInsert(String query)
        {

            SQLiteConnection sqlConnection = new SQLiteConnection(DBConnectionString());
            DBDataObject dbDataObject = new DBDataObject();
            bool isbreaked = false;

            try
            {
                _readerWriterLock.EnterWriteLock();

                if (_readerWriterLock.WaitingReadCount > 0)
                {
                    isbreaked = true;
                }
                else
                {
                    SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
                    sqlConnection.Open();

                    Int32 count = (Int32)sqlCommand.ExecuteNonQuery();

                    query = "SELECT last_insert_rowid()";
                    sqlCommand = new SQLiteCommand(query, sqlConnection);
                    var lastID = sqlCommand.ExecuteScalar();

                    dbDataObject.message = lastID.ToString();
                    dbDataObject.code = "Success";
                }
            }
            catch (Exception ex)
            {
                dbDataObject.message = ex.Message;
                dbDataObject.code = "Error";
                Log(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                _readerWriterLock.ExitWriteLock();
            }

            if (isbreaked)
            {
                Thread.Sleep(3);
                return ExecuteInsert(query);
            }

            return dbDataObject;
        }

        public static DBDataObject ExecuteBulkInsert(List<string> queryList)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection(DBConnectionString());
            DBDataObject dbDataObject = new DBDataObject();
            bool isbreaked = false;

            try
            {
                _readerWriterLock.EnterWriteLock();

                if (_readerWriterLock.WaitingReadCount > 0)
                {
                    isbreaked = true;
                }
                else
                {
                    sqlConnection.Open();

                    using (var cmd = new SQLiteCommand(sqlConnection))
                    {
                        using (var transaction = sqlConnection.BeginTransaction())
                        {
                            //inserts
                            foreach (var item in queryList)
                            {
                                cmd.CommandText = item;
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                dbDataObject.message = ex.Message;
                dbDataObject.code = "Error";
                Log(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                _readerWriterLock.ExitWriteLock();
            }

            if (isbreaked)
            {
                Thread.Sleep(3);
                return ExecuteBulkInsert(queryList);
            }

            return dbDataObject;
        }

        //Standard menthod for update query
        public static DBDataObject ExecuteUpdate(String query)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection(DBConnectionString());
            DBDataObject dbDataObject = new DBDataObject();
            bool isbreaked = false;

            try
            {
                _readerWriterLock.EnterWriteLock();

                if (_readerWriterLock.WaitingReadCount > 0)
                {
                    isbreaked = true;
                }
                else
                {

                    SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    dbDataObject.code = "Success";
                }
            }
            catch (Exception ex)
            {
                dbDataObject.message = ex.Message;
                Log(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                _readerWriterLock.ExitWriteLock();
            }


            if (isbreaked)
            {
                Thread.Sleep(3);
                return ExecuteUpdate(query);
            }

            return dbDataObject;
        }

        //Standard menthod for update query with parameters
        public static DBDataObject ExecuteUpdate(String query, byte[] input, String parameter)
        {

            SQLiteConnection sqlConnection = new SQLiteConnection(DBConnectionString());
            DBDataObject dbDataObject = new DBDataObject();

            try
            {
                SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
                SQLiteParameter sqlParameter = sqlCommand.Parameters.Add("@" + parameter, DbType.Binary);
                sqlParameter.Value = input;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                dbDataObject.code = "Success";
            }
            catch (Exception ex)
            {
                dbDataObject.message = ex.Message;
                dbDataObject.code = "Error";
                Log(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return dbDataObject;
        }

        // Key Value Update from the provided keypress
        //public static string KeyValueUpdate (string keorderId)
        //{
        //    string value;

        //    value = orderId.PadLeft(Constants.BARCODE_SIZE, '0');
        //    return value;
        //}

    }
}
