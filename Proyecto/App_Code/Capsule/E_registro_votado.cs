using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for E_registro_votado
/// </summary>
[Serializable]
[Table("registro_votado", Schema = "votaciones")]
public class E_registro_votado
{
    private int id;
    private string nombre;
    private string apellido;
    private string cc;
    private bool voto;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("nombre")]
    public string Nombre { get => nombre; set => nombre = value; }
    [Column("apellido")]
    public string Apellido { get => apellido; set => apellido = value; }
    [Column("cc")]
    public string Cc { get => cc; set => cc = value; }
    [Column("voto")]
    public bool Voto { get => voto; set => voto = value; }
}