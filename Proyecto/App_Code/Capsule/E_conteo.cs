using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for E_conteo
/// </summary>
[Serializable]
[Table("conteo", Schema = "votaciones")]
public class E_conteo
{
    private int id;
    private string nombre;
    private string apellido;
    private string partido;
    private int n_votos;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("nombre")]
    public string Nombre { get => nombre; set => nombre = value; }
    [Column("apellido")]
    public string Apellido { get => apellido; set => apellido = value; }
    [Column("partido")]
    public string Partido { get => partido; set => partido = value; }
    [Column("n_votos")]
    public int N_votos { get => n_votos; set => n_votos = value; }
}