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

    public void save_candidatos(E_candidato user)
    {
        using (var db = new Mapping())
        {
            db.candidato.Add(user);
            db.SaveChanges();
        }
    }

    public void save_votado(E_registro_votado user)
    {
        using (var db = new Mapping())
        {
            db.registro_votado.Add(user);
            db.SaveChanges();
        }
    }

    public void conteo_add(E_conteo user)
    {
        using (var db = new Mapping())
        {
            db.conteo.Add(user);
            db.SaveChanges();
        }
    }

    public void anadir_voto(E_conteo voto)
    {
        using (var db = new Mapping())
        {
            E_conteo conteo = db.conteo.Where(x => x.Id == voto.Id).First();
            conteo.N_votos = voto.N_votos;
            db.conteo.Attach(conteo);
            var entry = db.Entry(conteo);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }

    public E_conteo getNoVotos(int pas)
    {
        using (var db = new Mapping())
        {
            return db.conteo.Where(x => x.Id.Equals(pas)).FirstOrDefault();
        }
    }

    public E_user compareUser(E_user user)
    {
        using (var db = new Mapping())
        {
            return db.votantes.Where(x => x.Cedula.Equals(user.Cedula) && x.Nacimiento.Equals(user.Nacimiento) && x.User_name.Equals(user.User_name) && x.User_lastname.Equals(user.User_lastname) && x.Expe.Equals(user.Expe)).FirstOrDefault();
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

    public E_user getCandidatoVoto(int user_id)
    {
        using (var db = new Mapping())
        {
            return db.votantes.Where(x => x.Id.Equals(user_id)).FirstOrDefault();
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