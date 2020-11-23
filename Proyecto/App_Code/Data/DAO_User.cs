using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

    public void save_votado(E_user e_User)
    {
        using (var db = new Mapping())
        {
            db.votantes.Add(e_User);
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

    public E_admin getAdminCheck(string name)
    {
        using (var db = new Mapping())
        {
            return db.user_admin.Where(x => x.User_name_admin.Equals(name)).FirstOrDefault();
        }
    }

    public E_candidato GetCandidatoCheck(string cedula)
    {
        using (var db = new Mapping())
        {
            return db.candidato.Where(x => x.Cc.Equals(cedula)).FirstOrDefault();
        }
    }

    public E_user GetVotanteCheck(string cedula)
    {
        using (var db = new Mapping())
        {
            return db.votantes.Where(x => x.Cedula.Equals(cedula)).FirstOrDefault();
        }
    }

    public List<E_candidato> GetCandidato()
    {
        using (var db = new Mapping())
        {
            return db.candidato.ToList();
        }
    }

    public E_user getCandidatoVoto(string cedula)
    {
        using (var db = new Mapping())
        {
            return db.votantes.Where(x => x.Cedula.Equals(cedula)).FirstOrDefault();
        }
    }

    public List<E_user> GetVotantes()
    {
        using (var db = new Mapping())
        {
            return db.votantes.ToList();
        }
    }

    public List<E_conteo> GetEscrutinio()
    {
        using (var db = new Mapping())
        {
            return db.conteo.ToList();
        }
    }

    //public bool validarCedula (string cedula) { 

    //    using (var db = new Mapping())
    //    {
    //        return db.votantes.Any(x => x.Cedula.Equals(cedula));
    //    }
    //} por favor colocar en github que ya se hizo para no repetir metodos como pendejo, muvcahs gracias por su atención, comprensión y ternura

    public void deleteCandidato(E_candidato e_Candidato)
    {
        using (var db = new Mapping())
        {
            db.candidato.Attach(e_Candidato);
            var entry = db.Entry(e_Candidato);
            entry.State = EntityState.Deleted;
            db.SaveChanges();
        }
    }

    public void editCandidato(E_candidato e_Candidato)
    {
        using (var db = new Mapping())
        {
            E_candidato e_candidato2 = db.candidato.Where(x => x.Id == e_Candidato.Id).FirstOrDefault();
            e_candidato2.Nombre = e_Candidato.Nombre;
            e_candidato2.Apellido = e_Candidato.Apellido;
            e_candidato2.Partido = e_Candidato.Partido;
            e_candidato2.Cc = e_Candidato.Cc;
            db.candidato.Attach(e_candidato2);
            var entry = db.Entry(e_candidato2);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void deleteUser(E_user e_User)
    {
        using (var db = new Mapping())
        {
            db.votantes.Attach(e_User);
            var entry = db.Entry(e_User);
            entry.State = EntityState.Deleted;
            db.SaveChanges();
        }
    }

    public void editUser(E_user e_User)
    {
        using (var db = new Mapping())
        {
            E_user e_user2 = db.votantes.Where(x => x.Id == e_User.Id).FirstOrDefault();
            e_user2.User_name = e_User.User_name;
            e_user2.User_lastname = e_User.User_lastname;
            e_user2.Cedula = e_User.Cedula;
            e_user2.Mail = e_User.Mail;
            e_user2.Nacimiento = e_User.Nacimiento;
            e_user2.Expe = e_User.Expe;
            db.votantes.Attach(e_user2);
            var entry = db.Entry(e_user2);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void truncateTables()
    {
        using (var db = new Mapping())
        {
            List<E_candidato> e_Candidatos = db.candidato.ToList();
            List<E_conteo> e_Conteo = db.conteo.ToList();
            List<E_user> e_User = db.votantes.ToList();
            List<E_registro_votado> e_Registro_s = db.registro_votado.ToList();
            if (e_Candidatos.Count > 0)
            {
                foreach (var candi in e_Candidatos)
                {
                    db.candidato.Remove(candi);
                }
            }
            if (e_Conteo.Count > 0)
            {
                foreach (var cont in e_Conteo)
                {
                    db.conteo.Remove(cont);
                }
            }
            if (e_User.Count > 0)
            {
                foreach (var vota in e_User)
                {
                    db.votantes.Remove(vota);
                }
            }
            if (e_Registro_s.Count > 0)
            {
                foreach (var reg in e_Registro_s)
                {
                    db.registro_votado.Remove(reg);
                }
            }
            db.candidato.SqlQuery("ALTER SEQUENCE votaciones.candidato_id_seq RESTART WITH 1");
            db.conteo.SqlQuery("ALTER SEQUENCE votaciones.conteo_id_seq RESTART WITH 1");
            db.SaveChanges();
        }
    }
}