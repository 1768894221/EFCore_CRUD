using System;
using System.Linq;
using System.Threading.Tasks;

namespace _01_EF_Enviroment
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //MyDBContext继承自DBContext，DbContext继承与IDisposable，所以使用using防止内存泄露。
            using (MyDBContext dbcontext= new MyDBContext() )
            {
                #region  EFCore插入操作（Add）
                ////dbcontext 逻辑上的数据库，并不是真实的
                //Book book1 = new Book { AuthorName = "lty1", Tittle = "深入浅出EFCore", Price = 1.80, PublicTime = new DateTime(2021, 12, 16) };
                //Book book2 = new Book { AuthorName = "lty2", Tittle = "深入浅出数据结构", Price = 1.80, PublicTime = new DateTime(2021, 12, 16) };
                //Book book3 = new Book { AuthorName = "lty3", Tittle = "深入浅出算法分析", Price = 1.80, PublicTime = new DateTime(2021, 12, 16) };
                //Book book4 = new Book { AuthorName = "lty4", Tittle = "深入浅出MySql", Price = 1.80, PublicTime = new DateTime(2021, 12, 16) };
                //Book book5 = new Book { AuthorName = "lty5", Tittle = "深入浅出计算机网络", Price = 1.80, PublicTime = new DateTime(2021, 12, 16) };
                ////把Book加入到逻辑上的Book表中
                //dbcontext.Book.Add(book1);
                //dbcontext.Book.Add(book2);
                //dbcontext.Book.Add(book3);
                //dbcontext.Book.Add(book4);
                //dbcontext.Book.Add(book5);
                ////这会把逻辑上的数据库表，更新到真实的数据库中
                //await dbcontext.SaveChangesAsync();
                #endregion

                #region 查询操作（Where）
                var data = dbcontext.Book.Where(b => b.Tittle == "深入浅出算法分析").FirstOrDefault();
                Console.WriteLine($"书的ID = {data.Id} , 书的价格 = {data.Price} , 书的出版时间 = {data.PublicTime} , 书的名字 = {data.Tittle}");
                #endregion

                #region 修改
                //var data_Alter = dbcontext.Book.Single(b => b.Tittle == "深入浅出算法分析");
                //data_Alter.AuthorName = "深入浅出算法分析的AuthorName";
                //dbcontext.SaveChanges();
                #endregion

                #region 删除
                //var data_Delete = dbcontext.Dogs.Single(b => b.Name == "HaSai");
                //dbcontext.Remove(data_Delete);
                //dbcontext.SaveChanges();
                #endregion

                Console.WriteLine("一切正常");
            }
        }
    }
}
