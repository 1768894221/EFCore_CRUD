using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EF_Enviroment
{
    //继承了IEntityTypeConfiguration，用来数据库查找相应的实体配置
    class BookConfig :IEntityTypeConfiguration<Book>
    {
        public void  Configure(EntityTypeBuilder<Book> builder)
        {
            //表名T_Books
            builder.ToTable("T_Books");
            //设置Tittle的最大长度，不能为空
            builder.Property(b => b.Tittle).HasMaxLength(50).IsRequired();
            //设置AuthorName的最大长度，不能为空
            builder.Property(b => b.AuthorName).HasMaxLength(20).IsRequired();
        }
    }
}
