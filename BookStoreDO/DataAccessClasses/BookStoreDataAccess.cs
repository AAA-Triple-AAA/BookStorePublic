using BookStoreDO.Models.DataLayer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDO.DataAccessClasses;

public class BookStoreDataAccess
{
    private BookStoreContext _context = new();
}
