using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for E_audit_candidato
/// </summary>
[Serializable]
[Table("audit_candidato", Schema = "seguridad")]
public class E_audit_candidato
{
    private int id;
    private string nombre_old;
    private string nombre_new;
    private string apellido_old;
    private string apellido_new;
    private string cedula_old;
    private string cedula_new;
    private string partido_old;
    private string partido_new;
    private DateTime fecha;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("nombre_old")]
    public string Nombre_old { get => nombre_old; set => nombre_old = value; }
    [Column("nombre_new")]
    public string Nombre_new { get => nombre_new; set => nombre_new = value; }
    [Column("apellido_old")]
    public string Apellido_old { get => apellido_old; set => apellido_old = value; }
    [Column("apellido_new")]
    public string Apellido_new { get => apellido_new; set => apellido_new = value; }
    [Column("cedula_old")]
    public string Cedula_old { get => cedula_old; set => cedula_old = value; }
    [Column("cedula_new")]
    public string Cedula_new { get => cedula_new; set => cedula_new = value; }
    [Column("fecha")]
    public DateTime Fecha { get => fecha; set => fecha = value; }
    [Column("partido_old")]
    public string Partido_old { get => partido_old; set => partido_old = value; }
    [Column("partido_new")]
    public string Partido_new { get => partido_new; set => partido_new = value; }
}