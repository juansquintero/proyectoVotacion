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

    public E_admin login(E_admin user)
    {
        using (var db = new Mapping())
        {
            return db.user_admin.Where(x => x.User_name_admin.Equals(user.User_name_admin) && x.User_code_admin.Equals(user.User_code_admin)).FirstOrDefault();
        }
    }

    public void save_admin(E_admin user)
    {
        using (var db = new Mapping())
        {
            db.user_admin.Add(user);
            db.SaveChanges();
        }
    }

    public List<E_candidato> GetCandidato()
    {
        using (var db = new Mapping())
        {
            return db.candidato.ToList();
        }
    }

    public List<E_user> GetVotantes()
    {
        using (var db = new Mapping())
        {
            return db.votantes.ToList();
        }
    }
}