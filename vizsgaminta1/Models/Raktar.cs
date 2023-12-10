using System;
using System.Collections.Generic;

namespace vizsgaminta1.Models;

public partial class Raktar
{
    public int RaktarKod { get; set; }

    public string RaktarNev { get; set; } = null!;

    public string RaktarCim { get; set; } = null!;

    public virtual ICollection<Termek> Termek { get; set; } = new List<Termek>();
}
