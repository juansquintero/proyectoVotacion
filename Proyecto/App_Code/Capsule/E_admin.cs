using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for E_admin
/// </summary>
[Serializable]
[Table("user_admin", Schema = "votaciones")]
public class E_admin
{
    private int id;
    private string user_name_admin;
    private string user_code_admin;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("user_name_admin")]
    public string User_name_admin { get => user_name_admin; set => user_name_admin = value; }
    [Column("user_code_admin")]
    public string User_code_admin { get => user_code_admin; set => user_code_admin = value; }
}