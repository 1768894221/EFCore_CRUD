using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EF_Enviroment
{
    public class MyDBContext :DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Dog> Dogs { get; set; }

        //这里是配置
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DbContextOptionsBuilder注入
            base.OnConfiguring(optionsBuilder);
            //设置连接字符串
            optionsBuilder.UseSqlServer("server=localhost;uid=sa;pwd=123456;database=demo1_Enviroment;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //注入ModelBuilder
            base.OnModelCreating(modelBuilder);
            //获取当前程序集默认的是查找所有继承了IEntityTypeConfiguration的类
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
