using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for E_audit_votante
/// </summary>
[Serializable]
[Table("audit_votante", Schema = "seguridad")]
public class E_audit_votante
{
    private int id;
    private string nombre_old;
    private string nombre_new;
    private string apellido_old;
    private string apellido_new;
    private string cedula_old;
    private string cedula_new;
    private string fechaexp_old;
    private string fechaexp_new;
    private string fechanac_old;
    private string fechanac_new;
    private string correo_old;
    private string correo_new;
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
    [Column("fechaexp_old")]
    public string Fechaexp_old { get => fechaexp_old; set => fechaexp_old = value; }
    [Column("fechaexp_new")]
    public string Fechaexp_new { get => fechaexp_new; set => fechaexp_new = value; }
    [Column("fechanac_old")]
    public string Fechanac_old { get => fechanac_old; set => fechanac_old = value; }
    [Column("fechanac_new")]
    public string Fechanac_new { get => fechanac_new; set => fechanac_new = value; }
    [Column("correo_old")]
    public string Correo_old { get => correo_old; set => correo_old = value; }
    [Column("correo_new")]
    public string Correo_new { get => correo_new; set => correo_new = value; }
    [Column("fecha")]
    public DateTime Fecha { get => fecha; set => fecha = value; }
}