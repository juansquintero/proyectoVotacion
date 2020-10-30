using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for E_user
/// </summary>
[Serializable]
[Table("votantes", Schema = "votaciones")]
public class E_user
{
    private string user_name;
    private string user_lastname;
    private int id;
    private string cedula;
    private string expe;
    private string nacimiento;
    private string mail;
    private bool? voto;
    private string session;

    [Column("nombre")]
    public string User_name { get => user_name; set => user_name = value; }
    [Column("apellido")]
    public string User_lastname { get => user_lastname; set => user_lastname = value; }
    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("cedula")]
    public string Cedula { get => cedula; set => cedula = value; }
    [Column("fecha_exp")]
    public string Expe { get => expe; set => expe = value; }
    [Column("fecha_nac")]
    public string Nacimiento { get => nacimiento; set => nacimiento = value; }
    [Column("correo")]
    public string Mail { get => mail; set => mail = value; }
    [Column("voto")]
    public bool? Voto { get => voto; set => voto = value; }
    [Column("session")]
    public string Session { get => session; set => session = value; }
    
}