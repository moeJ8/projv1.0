using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiSQLite.Models;
using SQLite;


namespace MauiSQLite.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<StudentClass>();
            conn.CreateTable<UniversityClass>(); 
            conn.CreateTable<MajorClass>();
            conn.CreateTable<PaymentInfo>();
        }

        public List<StudentClass> GetAllStudents()
        {
            Init();
            return conn.Table<StudentClass>().ToList();
        }
        public void Add(StudentClass student)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(student);
        }

        public void DeleteStudent(int student_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new StudentClass { ID = student_ID});
        }


        public List<UniversityClass> GetAllUniversities()
        {
            Init();
            return conn.Table<UniversityClass>().ToList();
        }

        public void AddUniversity(UniversityClass university)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(university);
        }

        public void DeleteUniversity(int university_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new UniversityClass { ID = university_ID });
        }

        
        public List<MajorClass> GetAllMajors()
        {
            Init();
            return conn.Table<MajorClass>().ToList();
        }

        public void AddMajor(MajorClass major)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(major);
        }

        public void DeleteMajor(int major_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new MajorClass { ID = major_ID });
        }

        public List<PaymentInfo> GetAllPayments()
        {
            Init();
            return conn.Table<PaymentInfo>().ToList();
        }
        public void AddPayment(PaymentInfo payment)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(payment);
        }

        public void DeletePayment(int payment_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new PaymentInfo { ID = payment_ID });
        }
    }
}
