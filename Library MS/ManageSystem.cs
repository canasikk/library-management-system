using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;
namespace Library_MS
{
    class ManageSystem
    {


       //public MySqlConnection conn = new MySqlConnection("Server=localhost;database=library;uid=root;pwd=;");
        public  MySqlConnection conn = new MySqlConnection(
            "Server='" + Properties.Settings.Default.server + 
            "';Database='" + Properties.Settings.Default.database + 
            "';Uid='" + Properties.Settings.Default.userid +
            "';Pwd='" + Properties.Settings.Default.password + "';Encrypt=false;AllowUserVariables=True;UseCompression=True");
        
        public Boolean dbCheck()
        {
            try
            {
                conn.Close();
                conn.Open();
                if (conn.State != ConnectionState.Closed)
                {
                    return true;
                }
                 
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean addBook(string title, string author, string desc, string publisher, string length, string lang)
        {
            conn.Close();
            conn.Open();
            MySqlCommand add = new MySqlCommand("insert into books (bookTit,bookAut,bookDesc,bookPub,bookLen,bookLan) values ('"
                + title + "','"
                + author + "','"
                + desc + "','"
                + publisher + "','"
                + length + "','"
                + lang + "')", conn);
            object sonuc = null;
            sonuc = add.ExecuteNonQuery();
            conn.Close();
            if (sonuc != null)
                return true;
            else
                return false;

        }
        public Boolean addMember(string name, string no, string phone, string mail, string adres)
        {
            conn.Close();
            conn.Open();
            MySqlCommand add = new MySqlCommand("insert into members (userNam,userIdNo,userPho,userMai,userAddr) values ('"
                + name + "','"
                + no + "','"
                + phone + "','"
                + mail + "','"
                + adres + "')", conn);
            object sonuc = null;
            sonuc = add.ExecuteNonQuery();
            conn.Close();
            if (sonuc != null)
                return true;
            else
                return false;
        }
        public Boolean addRent(string name, string title, string date)
        {
            conn.Close();
            conn.Open();
            MySqlCommand add = new MySqlCommand("insert into rents (userNam,bookTit,delDat) values ('"
                + name + "','"
                + title + "','"
                + date + "')", conn);
            object sonuc = null;
            sonuc = add.ExecuteNonQuery();
            conn.Close();
            if (sonuc != null)
                return true;
            else
                return false;
        }

        public Boolean delBook(int id)
        {

            MySqlCommand delete = new MySqlCommand("DELETE FROM books WHERE id=@id", conn);
            delete.Parameters.AddWithValue("@id", id);
            conn.Close();
            conn.Open();
            object sonuc = null;
            sonuc = delete.ExecuteNonQuery();
            conn.Close();
            if (sonuc != null)
                return true;
            else{
                return false;}
            
        }
        public Boolean delMember(int id)
        {

            MySqlCommand delete = new MySqlCommand("DELETE FROM members WHERE id=@id", conn);
            delete.Parameters.AddWithValue("@id", id);
            conn.Close();
            conn.Open();
            object sonuc = null;
            sonuc = delete.ExecuteNonQuery();
            conn.Close();
            if (sonuc != null)
                return true;
            else
            {
                return false;
            }
        }
        public Boolean delRent(int id)
        {

            MySqlCommand delete = new MySqlCommand("DELETE FROM rents WHERE id=@id", conn);
            delete.Parameters.AddWithValue("@id", id);
            conn.Close();
            conn.Open();
            object sonuc = null;
            sonuc = delete.ExecuteNonQuery();
            conn.Close();
            if (sonuc != null)
                return true;
            else
            {
                return false;
            }
        }

        public Boolean updateBook(int id, string title, string author, string desc, string publisher, string length, string lang)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE  books  SET bookTit = @bookTit, bookAut= @bookAut, bookDesc= @bookDesc, bookPub=@bookPub , bookLen = @bookLen, bookLan = @bookLan  where id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@bookTit", title);
            cmd.Parameters.AddWithValue("@bookAut", author);
            cmd.Parameters.AddWithValue("@bookDesc", desc);
            cmd.Parameters.AddWithValue("@bookPub", publisher);
            cmd.Parameters.AddWithValue("@bookLen", length);
            cmd.Parameters.AddWithValue("@bookLan", lang);
            conn.Close();
            conn.Open();
            object sonuc = null;
            sonuc = cmd.ExecuteNonQuery();
            conn.Close();
            if (sonuc != null)
                return true;
            else
                return false;
            
        }
        public Boolean updateMember(int id, string name, string no, string phone, string mail, string adres)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE  members  SET userNam = @userNam, userIdNo= @userIdNo, userPho= @userPho, userMai=@userMai , userAddr = @userAddr  where id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@userNam", name);
            cmd.Parameters.AddWithValue("@userIdNo", no);
            cmd.Parameters.AddWithValue("@userPho", phone);
            cmd.Parameters.AddWithValue("@userMai", mail);
            cmd.Parameters.AddWithValue("@userAddr", adres);
            conn.Close();
            conn.Open();
            object sonuc = null;
            sonuc = cmd.ExecuteNonQuery();
            conn.Close();
            if (sonuc != null)
                return true;
            else
                return false;

        }
        public Boolean updateMember(int id, string name, string title, string date)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE  rents  SET userNam = @userNam, bookTit= @bookTit, delDat= @delDat where id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@userNam", name);
            cmd.Parameters.AddWithValue("@userIdNo", title);
            cmd.Parameters.AddWithValue("@userPho", date);

            conn.Close();
            conn.Open();
            object sonuc = null;
            sonuc = cmd.ExecuteNonQuery();
            conn.Close();
            if (sonuc != null)
                return true;
            else
                return false;

        }

        public void msg1() { MessageBox.Show("Successful"); }
        public void msg0() { MessageBox.Show("Unsuccessful"); }






    }
}