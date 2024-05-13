using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entites;

public class SubscribeEntity
{
    [Key]
    public string Email { get; set; } = null!;
    public bool NewsletterCheckbox1 { get; set; }
    public bool NewsletterCheckbox2 { get; set; }
    public bool NewsletterCheckbox3 { get; set; }
    public bool NewsletterCheckbox4 { get; set; }
    public bool NewsletterCheckbox5 { get; set; }
    public bool NewsletterCheckbox6 { get; set; }
}
