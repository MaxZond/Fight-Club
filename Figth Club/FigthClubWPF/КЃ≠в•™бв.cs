using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigthClubWPF
{
    internal class Контекст : DbContext
    {
        public DbSet<Charecter> Персонажи { get; set; }
        public DbSet<Users> Пользователи { get; set; }
    }
}
