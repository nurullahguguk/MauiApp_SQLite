using MauiApp_SQLite.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp_SQLite.DataTransactions
{
    public class DbTrans
    {
        public string DbPath;
        public SQLiteConnection conn;

        public DbTrans(string _dbPath)
        {
            this.DbPath = _dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.CreateTable<Student>();
        }

        public List<Student> GetAllStudents()
        {
            Init();
            return conn.Table<Student>().ToList();
        }

        public void Add(Student student)
        {
            conn=new SQLiteConnection(this.DbPath);
            conn.Insert(student);
        }

        public void Delete(int student_Id)
        {
            conn=new SQLiteConnection(this.DbPath);
            conn.Delete(new Student { Id = student_Id });
        }

    }
}
