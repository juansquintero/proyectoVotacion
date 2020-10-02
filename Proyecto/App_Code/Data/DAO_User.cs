using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAO_User
/// </summary>
public class DAO_User
{
    public void save_votantes(E_user vot)
    {
        using (var db = new Mapping())
        {
            db.votantes.Add(vot);
            db.SaveChanges();
        }
    }
}