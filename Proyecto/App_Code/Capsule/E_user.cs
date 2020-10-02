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
    private int cedula;
    private Nullable<DateTime> expe;
    private Nullable<DateTime> nacimiento;

    [Column("nombre")]
    public string User_name { get => user_name; set => user_name = value; }
    [Column("apellido")]
    public string User_lastname { get => user_lastname; set => user_lastname = value; }
    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("cedula")]
    public int Cedula { get => cedula; set => cedula = value; }
    [Column("fecha_exp")]
    public DateTime? Expe { get => expe; set => expe = value; }
    [Column("fecha_nac")]
    public DateTime? Nacimiento { get => nacimiento; set => nacimiento = value; }
}