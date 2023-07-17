using AngularAuthAPI.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.RegularExpressions;

namespace AngularAuthAPI.Utilities
{
    public  class Validations
    {
        //AppDbContext _db;
        //public Validations( AppDbContext db)
        //{
        //    _db = db;
        //}
        //public async Task<bool> CheckUserNameAsync(string userName)
        //{
        //   var model=await _db.Users.AnyAsync(x=>x.Username==userName);
        //    return model;
        //}
        //public async Task<bool> CheckEmailAsync(string email)
        //{
        //    var model = await _db.Users.AnyAsync(x => x.Email == email);
        //    return model;
        //}
        //public string CheckPasswordWeakness(string password)
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    if(password.Length<8)
        //        stringBuilder.Append("Minmum Characters must be 8"+Environment.NewLine);
        //    if (!Regex.IsMatch(password,"[a-z]")&& Regex.IsMatch(password, "[A-Z]")&& Regex.IsMatch(password, "[0-9]"))
        //        stringBuilder.Append("Password must contain Captial Letters and Numbers!"+Environment.NewLine);
        //    if(!Regex.IsMatch(password, "[<,>,@,~,#,$,%,^,&,*,+,//,/,;,:,']"))
        //        stringBuilder.Append("Password must contain Special Characters!"+Environment.NewLine) ;
        //    return stringBuilder.ToString();
        //}

    }
}
