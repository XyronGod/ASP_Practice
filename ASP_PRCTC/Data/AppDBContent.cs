using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ASP_Practice.Data.Models;

//класс для работы с БД

namespace ASP_PRCTC.Data
{
    
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        //Получает и устанавливает все категории в магазине
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
