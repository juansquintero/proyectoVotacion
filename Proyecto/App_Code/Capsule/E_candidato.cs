using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

[Serializable]
[Table("candidato", Schema = "votaciones")]
public class E_candidato
{
    private int id;
    private string nombre;
    private string apellido;
    private string cc;
    private string partido;
    private string foto;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("nombre")]
    public string Nombre { get => nombre; set => nombre = value; }
    [Column("apellido")]
    public string Apellido { get => apellido; set => apellido = value; }
    [Column("cc")]
    public string Cc { get => cc; set => cc = value; }
    [Column("partido")]
    public string Partido { get => partido; set => partido = value; }
    [Column("foto")]
    public string Foto { get => foto; set => foto = value; }
}