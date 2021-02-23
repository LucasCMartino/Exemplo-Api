using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Criado para usar migrações
            var connectionStrings = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=123456";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectionStrings);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
