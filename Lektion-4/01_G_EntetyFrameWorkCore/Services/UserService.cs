using _01_G_EntetyFrameWorkCore.Contexts;
using _01_G_EntetyFrameWorkCore.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_G_EntetyFrameWorkCore.Services;

internal class UserService
{
    private readonly DataContext _context;
    public UserService()
    {
        _context = new DataContext();
    }
    public async Task<UserEntety> CreateAsync(UserEntety userEntety)
    {
        if (! await _context.Users.AnyAsync(x => x.Email == userEntety.Email))
        {
            _context.Users.Add(userEntety);
            await _context.SaveChangesAsync();
            return userEntety;
        }

        return null!;
    }
}
